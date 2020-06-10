using RegistryLib;
using System;
using System.Windows.Forms;

namespace Hospital.View
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void GetDetailedInfo()
        {
            int patient_id = Model.GetLastMemberId("SELECT max(card_number)FROM Patient");
            DetailedPatient form = new DetailedPatient(patient_id);
            form.Show();
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name, surname, middleName, birthDate, phoneNumb, address;
            try
            {
                name = textBoxFirstName.Text;
                surname = textBoxSurname.Text;
                middleName = textBoxMiddleName.Text;
                birthDate = textBoxBirth.Text;
                phoneNumb = textBoxPhone.Text;
                address = textBoxAddress.Text;

                Patient patient = new Patient(name, surname, middleName, birthDate, phoneNumb, address);
                Patient.InsertNewPatient(patient);

                GetDetailedInfo();
            }
            catch
            {
                MessageBox.Show("Помилка введення значень!", "Помилка", MessageBoxButtons.OK);
            }
        }

      
    }
}
