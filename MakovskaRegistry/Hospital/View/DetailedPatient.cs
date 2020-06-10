using RegistryLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.View
{
    public partial class DetailedPatient : Form
    {
        Patient patient;

        public DetailedPatient(int card_number)
        {
            InitializeComponent();
            FillDetailedInfo(card_number);
        }

        public void FillDetailedInfo(int card_number)
        {
            patient = Patient.DetailedPatient(card_number);
            textBoxCardNumb.Text = Convert.ToString(patient.card_number);
            textBoxFirstName.Text = patient.FirstName;
            textBoxSurname.Text = patient.Surname;
            textBoxMiddleName.Text = patient.MiddleName;
            textBoxBirth.Text = patient.BirthDate;
            textBoxPhone.Text = patient.PhoneNumber;
            textBoxAddress.Text = patient.Address;

            FillStatusBox();
            FillGroupBox();

            if (patient.status == null)
                comboBoxStatus.SelectedIndex = 0;

            else
            {
                int status_id = patient.status.id;
                comboBoxStatus.SelectedIndex = status_id;
            }

            Model.Closer(Model.readerData);

            if (patient.groupList != null) { FillList(); }
        }

        public void FillStatusBox()
        {
            foreach(string name in Status.FillStatusBox())
            {
                comboBoxStatus.Items.Add(name);
            }
        }
        public void FillGroupBox()
        {
            foreach (string name in Privileged_group.FillGroupBox())
            {
                comboBoxGroup.Items.Add(name);
            }
            comboBoxGroup.SelectedIndex = 0; 
            Model.Closer(Model.readerData);
        }
        public void FillList()
        {
            foreach (var group in patient.groupList)
            {
                string info = group.name + "     (знижка: " + group.discountPercent + "%)";
                listBoxGroup.Items.Add(info);
            }
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
            labelGroup.Visible = true;
            comboBoxGroup.Visible = true;
            buttonAddGroup.Visible = true;
            buttonRemoveGroup.Visible = true;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string first_name, surname, midlle_name, birth_date, phone_number, address;
            int status;
            try
            {
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

                buttonSave.Visible = false;
                textBoxFirstName.ReadOnly = true;
                textBoxSurname.ReadOnly = true;
                textBoxMiddleName.ReadOnly = true;
                textBoxBirth.ReadOnly = true;
                textBoxPhone.ReadOnly = true;
                textBoxAddress.ReadOnly = true;
                comboBoxStatus.Enabled = false;
                labelGroup.Visible = false;
                comboBoxGroup.Visible = false;
                buttonAddGroup.Visible = false;
                buttonRemoveGroup.Visible = false;
            }
            catch
            {
                MessageBox.Show("Помилка введення значень!", "Помилка", MessageBoxButtons.OK);
            }

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxCardNumb.Text);
                Patient.DeletePatient(id);
                Close();
            }
            catch
            {
                
            }
        }

        private bool CheckIndex() 
        {
            int index = comboBoxGroup.SelectedIndex;
            bool unique = true;
            foreach (var group in patient.groupList)
            {
                if (group.id == index)
                {
                    unique = false;
                    break;
                }
            }
            return unique;
        }
        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            int index = comboBoxGroup.SelectedIndex;

            if (CheckIndex() == true) 
            {
                Privileged_group group = Privileged_group.NewGroup(index);
                patient.groupList.Add(group);
                listBoxGroup.Items.Add(group.name);
                Privileged_group.AddGroup(patient.card_number, group.id);
            }

        }
        private void buttonRemoveGroup_Click(object sender, EventArgs e)
        {
            int index = comboBoxGroup.SelectedIndex;
            if (CheckIndex() == false)
            {
                foreach (var group in patient.groupList)
                {
                    if (group.id == index)
                    {
                        Privileged_group.RemoveGroup(patient.card_number, group.id);
                        patient.groupList.Remove(group);
                        break;
                    }
                }
               
                listBoxGroup.Items.Clear();
                FillList();
            }
        }
    }
}
