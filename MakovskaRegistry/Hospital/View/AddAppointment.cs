using RegistryLib;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital.View
{
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
            FillDoctorDataGrid();
            FillPatientDataGrid();
            FillServiceDataGrid();
        }

        public void FillDoctorDataGrid()
        {
            comboBoxSearchDoctor.SelectedIndex = 0;

            DataTable table = Doctor.AllMembersTable();
            dataGridViewDoctors.DataSource = table;

            dataGridViewDoctors.RowsDefaultCellStyle.BackColor = Color.PowderBlue;
            dataGridViewDoctors.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            dataGridViewDoctors.Columns[0].Width = 30;
            dataGridViewDoctors.Columns[1].Width = 90;
            dataGridViewDoctors.Columns[2].Width = 90;
            dataGridViewDoctors.Columns[3].Width = 30;
            dataGridViewDoctors.Columns[4].Width = 120;

        }
        public void FillPatientDataGrid()
        {
            comboBoxsearchPatient.SelectedIndex = 0;

            DataTable table = Patient.AllMembersTable();
            dataGridViewPatients.DataSource = table;

            dataGridViewPatients.RowsDefaultCellStyle.BackColor = Color.PowderBlue;
            dataGridViewPatients.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            dataGridViewPatients.Columns[0].Width = 50;
            dataGridViewPatients.Columns[3].Width = 110;
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

        private void buttonSearchDoctor_Click(object sender, EventArgs e)
        {
            int index = comboBoxSearchDoctor.SelectedIndex;
            string text = textBoxSearchDoctor.Text;
            DataTable table = Doctor.SearchDoctor(index, text);
            dataGridViewDoctors.DataSource = table;
        }
        private void buttonSearchPatient_Click(object sender, EventArgs e)
        {
            int index = comboBoxsearchPatient.SelectedIndex;
            string text = textBoxSearchPatient.Text;
            DataTable table = Patient.SearchPatient(index, text);
            dataGridViewPatients.DataSource = table;
        }

        private void DetailsDoctor_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridViewDoctors.CurrentCell.RowIndex;

                int doctirId = Convert.ToInt32(dataGridViewDoctors.Rows[rowIndex].Cells[0].Value);

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

        private void buttonAddPAtient_Click(object sender, EventArgs e)
        {
            AddPatient form = new AddPatient();
            form.Show();
        }
        private void buttonAddDoctor_Click(object sender, EventArgs e)
        {
            AddDoctor form = new AddDoctor();
            form.Show();
        }

        private void buttonRefreshDoctors_Click(object sender, EventArgs e)
        {
            FillDoctorDataGrid();
        }
        private void buttonRefreshPatients_Click(object sender, EventArgs e)
        {
            FillPatientDataGrid();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetDetailedInfo()
        {
            int appId = Model.GetLastMemberId("SELECT max(id) FROM Appointment");
            DetailedAppointment form = new DetailedAppointment(appId);
            form.Show();
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int patientId, doctorId, serviceId;
            string dataTime;

            if (dataGridViewDoctors.SelectedRows.Count == 1 &&
                   dataGridViewPatients.SelectedRows.Count == 1 &&
                   dataGridViewAllServises.SelectedRows.Count == 1)
            {
                int rowIndexDoctor = dataGridViewDoctors.CurrentCell.RowIndex;
                doctorId = Convert.ToInt32(dataGridViewDoctors.Rows[rowIndexDoctor].Cells[0].Value);

                int rowIndexPatient = dataGridViewPatients.CurrentCell.RowIndex;
                patientId = Convert.ToInt32(dataGridViewPatients.Rows[rowIndexPatient].Cells[0].Value);

                int rowIndexApp = dataGridViewAllServises.CurrentCell.RowIndex;
                serviceId = Convert.ToInt32(dataGridViewAllServises.Rows[rowIndexApp].Cells[0].Value);

                dataTime = textBoxDateTime.Text;

                Appointment appointment = new Appointment(doctorId, patientId, dataTime);
                Appointment.InsertNewAppointment(appointment, serviceId);
            }
            GetDetailedInfo();

            try
            {
               
            }
            catch
            {
                MessageBox.Show("Помилка введення значень!", "Помилка", MessageBoxButtons.OK);
            }
        }
    }
}
