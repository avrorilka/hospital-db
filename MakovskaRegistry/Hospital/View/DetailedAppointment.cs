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

        public DetailedAppointment(int id)
        {
            InitializeComponent();
            FillDetailedInfo(id);
        }

        public void FillDoctorDataGrid(int doctorId)
        {
            Doctor doctor = Doctor.DetailedDoctor(doctorId);
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
            Patient patient = Patient.DetailedPatient(patientId);
            DataTable table = new DataTable();

            table.Columns.Add("№ картки");
            table.Columns.Add("Ім'я");
            table.Columns.Add("Прізвище");
            table.Columns.Add("Дата народження");
            table.Rows.Add(Convert.ToString(patient.card_number), patient.FirstName, patient.Surname, patient.BirthDate);
            
            dataGridViewPatients.DataSource = table;
            dataGridViewPatients.Columns[0].Width = 50;
        }

        public void FillDetailedInfo(int id)
        {
            appointment = Appointment.DetailedAppointment(id);
            textBoxCardNumb.Text = Convert.ToString(appointment.id);
            FillDoctorDataGrid(appointment.doctorId);
            FillPatientDataGrid(appointment.patientId);

        }
    }
}
