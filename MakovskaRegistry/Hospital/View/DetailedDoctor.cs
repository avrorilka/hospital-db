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
    public partial class DetailedDoctor : Form
    {
        Doctor doctor;
        public DetailedDoctor(int id)
        {
            InitializeComponent();
            FillDetailedInfo(id);
        }

        public void FillDetailedInfo(int id)
        {
            doctor = Doctor.DetailedDoctor(id);
            textBoxCabinet.Text = Convert.ToString(doctor.cabinet.id);
            textBoxFirstName.Text = doctor.FirstName;
            textBoxSurname.Text = doctor.Surname;
            textBoxMiddleName.Text = doctor.MiddleName;
            textBoxType.Text = doctor.type.name;
            textBoxStartTime.Text = doctor.schedule.timeStart;
            textBoxEndTime.Text = doctor.schedule.timeEnd;

            Model.Closer(Model.readerData);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(doctor.id);
            Patient.DeletePatient(id);
            Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buttonSave.Visible = true;
            textBoxCabinet.ReadOnly = false;
            textBoxFirstName.ReadOnly = false;
            textBoxSurname.ReadOnly = false;
            textBoxMiddleName.ReadOnly = false;
            textBoxType.ReadOnly = false;
            textBoxStartTime.ReadOnly = false;
            textBoxEndTime.ReadOnly = false;
        }
    }
}
