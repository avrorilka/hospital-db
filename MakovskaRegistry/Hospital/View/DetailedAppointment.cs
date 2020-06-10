using RegistryLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.View
{
    public partial class DetailedAppointment : Form
    {
        Appointment appointment;
        Doctor doctor;
        Patient patient;

        public DetailedAppointment(int id)
        {
            InitializeComponent();
            FillDetailedInfo(id);
        }

        public void FillDoctorDataGrid(int doctorId)
        {
            doctor = Doctor.DetailedDoctor(doctorId);
            DataTable table = new DataTable();

            table.Columns.Add("Номер каб");
            table.Columns.Add("Ім'я");
            table.Columns.Add("Прізвище");
            table.Columns.Add("Спеціальність");
            table.Rows.Add(Convert.ToString(doctor.cabinet.cabinetNumber), doctor.FirstName, doctor.Surname, doctor.type.name);
        
            dataGridViewDoctors.DataSource = table;
            dataGridViewDoctors.Columns[0].Width = 50;
            dataGridViewDoctors.Columns[3].Width = 130;

        }
        public void FillPatientDataGrid(int patientId)
        {
            patient = Patient.DetailedPatient(patientId);
            DataTable table = new DataTable();

            table.Columns.Add("№ картки");
            table.Columns.Add("Ім'я");
            table.Columns.Add("Прізвище");
            table.Columns.Add("Дата народження");
            table.Rows.Add(Convert.ToString(patient.card_number), patient.FirstName, patient.Surname, patient.BirthDate);
            
            dataGridViewPatients.DataSource = table;
            dataGridViewPatients.Columns[0].Width = 50;
            dataGridViewPatients.Columns[3].Width = 130;
        }
        public void FillServiceDataGrid()
        {

            DataTable table = Service.AllMembersTable();
            dataGridViewAllServises.DataSource = table;

            dataGridViewAllServises.Columns[0].Width = 50;
            dataGridViewAllServises.Columns[1].Width = 255;
            dataGridViewAllServises.Columns[2].Width = 60;

            dataGridViewAllServises.RowsDefaultCellStyle.BackColor = Color.PowderBlue;
            dataGridViewAllServises.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        public void FillDetailedInfo(int id)
        {
            appointment = Appointment.DetailedAppointment(id);

            textBoxNumb.Text = Convert.ToString(appointment.id);
            textBoxDateTime.Text = appointment.DataTime;

            FillDoctorDataGrid(appointment.doctorId.id);
            FillPatientDataGrid(appointment.patientId.card_number);
            FillList();


        }
        public void FillList()
        {
            foreach (var service in appointment.serviceList)
            {
                string info = service.name + "    " + service.price + " грн";
                listBoxServises.Items.Add(info);
            }
            CountPrise();
        }

        public double CountPrise()
        {
            double maxDiscount = 0, discount, sum = 0;
            foreach (var group in patient.groupList)
            {
                discount = group.discountPercent;
                if (discount > maxDiscount)
                    maxDiscount = discount;
            }

            foreach (var service in appointment.serviceList)
            {
                sum += service.price;
            }
            sum = sum - (sum * maxDiscount / 100);

            textBoxDiscount.Text = Convert.ToString(maxDiscount) + "%";
            textBoxPrise.Text = Convert.ToString(sum) + " грн";

            return sum;
        }

        private void DetailsDoctor_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows.Count == 1)
            {
                int doctirId = Convert.ToInt32(appointment.doctorId.id);

                DetailedDoctor form = new DetailedDoctor(doctirId);
                form.Show();
            }
        }

        private void DetailsPatient_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridViewPatients.CurrentCell.RowIndex;

                int card_number = Convert.ToInt32(dataGridViewPatients.Rows[rowIndex].Cells[0].Value);

                DetailedPatient form = new DetailedPatient(card_number);
                form.Show();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxDateTime.ReadOnly = false;
            buttonSave.Visible = true;
            labelAvaliableServises.Visible = true;
            dataGridViewAllServises.Visible = true;
            buttonAdd.Visible = true;
            buttonRemove.Visible = true;
            FillServiceDataGrid();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxNumb.Text);
                Patient.DeletePatient(id);
                Close();
            }
            catch
            {
                MessageBox.Show("Неможливо видалити", "Помилка", MessageBoxButtons.OK);
            }
        }


        private bool CheckIndex()
        {
            if (dataGridViewAllServises.SelectedRows.Count == 1) 
            {
                int rowIndex = dataGridViewAllServises.CurrentCell.RowIndex;
                string name = Convert.ToString(dataGridViewAllServises.Rows[rowIndex].Cells[1].Value);

                bool unique = true;
                foreach (var service in appointment.serviceList)
                {
                    if (service.name == name)
                    {
                        unique = false;
                        break;
                    }
                }
                return unique;
            }
            return false;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllServises.SelectedRows.Count == 1) 
            {
                int rowIndex = dataGridViewAllServises.CurrentCell.RowIndex;

                int index = Convert.ToInt32(dataGridViewAllServises.Rows[rowIndex].Cells[0].Value);
                string name = Convert.ToString(dataGridViewAllServises.Rows[rowIndex].Cells[1].Value);
                double prise = Convert.ToDouble(dataGridViewAllServises.Rows[rowIndex].Cells[2].Value);

                if (CheckIndex() == true)
                {
                    Service service = new Service(name, prise);

                    string info = service.name + "    " + service.price + " грн";
                    appointment.serviceList.Add(service);
                    listBoxServises.Items.Add(info);
                    Service.AddService(appointment.id, index);

                    CountPrise();
                }
            }  
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllServises.SelectedRows.Count == 1) 
            {
                int rowIndex = dataGridViewAllServises.CurrentCell.RowIndex;
                int index = Convert.ToInt32(dataGridViewAllServises.Rows[rowIndex].Cells[0].Value);
                string name = Convert.ToString(dataGridViewAllServises.Rows[rowIndex].Cells[1].Value);

                if (CheckIndex() == false)
                {
                    foreach (var service in appointment.serviceList)
                    {
                        if (service.name == name)
                        {
                            Service.RemoveService(appointment.id, index);
                            appointment.serviceList.Remove(service);
                            break;
                        }
                    }

                    listBoxServises.Items.Clear();
                    FillList();
                }
            } 
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string dataTime;
            try
            {
                dataTime = textBoxDateTime.Text;

                Appointment appointmentNew = new Appointment(appointment.id, appointment.doctorId.id, 
                                                            appointment.patientId.card_number, dataTime);
                Appointment.CheckAppointmentData(appointmentNew);

                buttonSave.Visible = false;
                textBoxDateTime.ReadOnly = true;
                labelAvaliableServises.Visible = false;
                dataGridViewAllServises.Visible = false;
                buttonAdd.Visible = false;
                buttonRemove.Visible = false;
                //FillServiceDataGrid();
            }
            catch
            {
                MessageBox.Show("Помилка введення значень!", "Помилка", MessageBoxButtons.OK);
            }
        }
    }
}
