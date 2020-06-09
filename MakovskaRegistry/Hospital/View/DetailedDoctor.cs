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
            try
            {
                doctor = Doctor.DetailedDoctor(id);
                if (labelTitle == null)
                {
                    throw new ArgumentNullException();
                }
                string cab = Convert.ToString(doctor.cabinet.cabinetNumber);
                textBoxCabinet.Text = cab;
                textBoxFirstName.Text = doctor.FirstName;
                textBoxSurname.Text = doctor.Surname;
                textBoxMiddleName.Text = doctor.MiddleName;

                textBoxStartTime.Text = doctor.schedule.TimeStart;
                textBoxEndTime.Text = doctor.schedule.TimeEnd;

                FillTypeBox();
                comboBoxType.SelectedItem = doctor.type.name;

                Model.Closer(Model.readerData);
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Такого значення не існує!", "Помилка", MessageBoxButtons.OK);
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Doctor.DeleteDoctor(doctor.id);
                Close();
            }
            catch 
            {
                MessageBox.Show("Неможливо видалити", "Помилка", MessageBoxButtons.OK);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buttonSave.Visible = true;
            textBoxCabinet.ReadOnly = false;
            textBoxFirstName.ReadOnly = false;
            textBoxSurname.ReadOnly = false;
            textBoxMiddleName.ReadOnly = false;
            comboBoxType.Enabled = true;
            textBoxStartTime.ReadOnly = false;
            textBoxEndTime.ReadOnly = false;
        }

        public void FillTypeBox()
        {
            foreach (string name in RegistryLib.Type.FillTypeBox())
            {
                comboBoxType.Items.Add(name);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string first_name, surname, midlle_name, type, startTime, endTime;
            int cabinet, oldCab = doctor.cabinet.cabinetNumber, id = doctor.id;

            try
            {
                first_name = textBoxFirstName.Text;
                surname = textBoxSurname.Text;
                midlle_name = textBoxMiddleName.Text;
                type = Convert.ToString(comboBoxType.SelectedItem);
                cabinet = Convert.ToInt32(textBoxCabinet.Text);

                startTime = textBoxStartTime.Text;
                endTime = textBoxEndTime.Text;

                int start = Convert.ToInt32(startTime.Split(':')[0]);
                int end = Convert.ToInt32(endTime.Split(':')[0]);

                if (end > start)
                {
                    Doctor doctor = new Doctor(id, first_name, surname, midlle_name, 
                                                cabinet, type, startTime, endTime);

                    Doctor.EditDoctor(doctor, oldCab);

                    buttonSave.Visible = false;
                    textBoxCabinet.ReadOnly = true;
                    textBoxFirstName.ReadOnly = true;
                    textBoxSurname.ReadOnly = true;
                    textBoxMiddleName.ReadOnly = true;
                    comboBoxType.Enabled = false;
                    textBoxStartTime.ReadOnly = true;
                    textBoxEndTime.ReadOnly = true;
                }

                else
                    MessageBox.Show("Помилка в часі!", "Помилка", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Помилка введення значень!", "Помилка", MessageBoxButtons.OK);
            }
        }
    }
}
