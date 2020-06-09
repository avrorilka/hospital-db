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

        public void FillDetailedInfo(int id)
        {
            appointment = Appointment.DetailedAppointment(id);

            textBoxCardNumb.Text = Convert.ToString(appointment.id);
            textBoxDateTime.Text = appointment.dataTime;

            FillDoctorDataGrid(appointment.doctorId.id);
            FillPatientDataGrid(appointment.patientId.card_number);

            foreach (var service in appointment.serviceList)
            {
                string info = service.name + "    " + service.price + " грн";
                listBoxServises.Items.Add(info);
            }
            textBoxPrise.Text = Convert.ToString(CountPrise()) + " грн";
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
    }
}
