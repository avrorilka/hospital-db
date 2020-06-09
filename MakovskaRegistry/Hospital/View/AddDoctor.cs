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
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
            FillTypeBox();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void GetDetailedInfo()
        {
            int doctorId = Model.GetLastMemberId("SELECT max(id) FROM Doctor");
            DetailedDoctor form = new DetailedDoctor(doctorId);
            form.Show();
            Close();
        }
        public void FillTypeBox()
        {
            foreach (string name in RegistryLib.Type.FillTypeBox())
            {
                comboBoxType.Items.Add(name);
            }
            comboBoxType.SelectedIndex = 1;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string first_name, surname, midlle_name, type, startTime, endTime;
                int cabinet, typeId;


                first_name = textBoxFirstName.Text;
                surname = textBoxSurname.Text;
                midlle_name = textBoxMiddleName.Text;
                typeId = comboBoxType.SelectedIndex + 1;
                type = Convert.ToString(comboBoxType.SelectedIndex);
                cabinet = Convert.ToInt32(textBoxCabinet.Text);

                startTime = textBoxStartTime.Text;
                endTime = textBoxEndTime.Text;

                int start = Convert.ToInt32(startTime.Split(':')[0]);
                int end = Convert.ToInt32(endTime.Split(':')[0]);

                if (end > start)
                {
                    Doctor doctor = new Doctor(first_name, surname, midlle_name,
                                                cabinet, type, startTime, endTime);

                    Doctor.InsertNewDoctor(doctor, typeId);
                    GetDetailedInfo();
                    Close();
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
