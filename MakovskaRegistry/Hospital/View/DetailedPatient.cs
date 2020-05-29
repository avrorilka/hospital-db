using RegistryLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.View
{
    public partial class DetailedPatient : Form
    {
        public DetailedPatient(int card_number)
        {
            InitializeComponent();
            FillDetailedInfo(card_number);
        }

        public void FillDetailedInfo(int card_number)
        {
            Patient patient = Patient.ConvertPatient(card_number);

            textBoxCardNumb.Text = Convert.ToString(patient.card_number);
            textBoxFirstName.Text = patient.first_name;
            textBoxSurname.Text = patient.surname;
            textBoxMiddleName.Text = patient.midlle_name;
            textBoxBirth.Text = patient.birth_date;
            textBoxPhone.Text = patient.phone_number;
            textBoxAddress.Text = patient.address;
            int status_id = patient.status.id;

            Model.Closer(Model.readerData);

            FillBoxData(status_id);
        }
        public void FillBoxData(int status_id)
        {
            Model.readerData = Model.AllMembers("SELECT name FROM Status");
            comboBoxStatus.Items.Add("---------------");
            while (Model.readerData.Read())
            {
                comboBoxStatus.Items.Add(Model.readerData[0]);
            }
            comboBoxStatus.SelectedIndex = status_id;

            Model.Closer(Model.readerData);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buttonSave.Visible = true;
            textBoxFirstName.ReadOnly = false;
            textBoxSurname.ReadOnly = false;
            textBoxMiddleName.ReadOnly = false;
            textBoxBirth.ReadOnly = false;
            textBoxPhone.ReadOnly = false;
            textBoxAddress.ReadOnly = false;
            comboBoxStatus.Enabled = true;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            buttonSave.Visible = false;
            textBoxFirstName.ReadOnly = true;
            textBoxSurname.ReadOnly = true;
            textBoxMiddleName.ReadOnly = true;
            textBoxBirth.ReadOnly = true;
            textBoxPhone.ReadOnly = true;
            textBoxAddress.ReadOnly = true;
            comboBoxStatus.Enabled = false;

            string first_name, surname, midlle_name, birth_date, phone_number, address;
            int status;
            first_name = textBoxFirstName.Text;
            surname = textBoxSurname.Text;
            midlle_name = textBoxMiddleName.Text;
            birth_date = textBoxBirth.Text;
            phone_number = textBoxPhone.Text;
            address = textBoxAddress.Text;
            status = comboBoxStatus.SelectedIndex;
            

            Patient patient = new Patient(Convert.ToInt32(textBoxCardNumb.Text), first_name, surname, midlle_name,
                        birth_date, phone_number, address, status);

            Patient.EditPatient(patient);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxCardNumb.Text);
            Patient.DeletePatient(id);
            this.Close();
        }
    }
}
