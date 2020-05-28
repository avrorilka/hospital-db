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
            SQLiteDataReader patientData = Model.AllMembers($"Select * From Patient WHERE card_number = {card_number}");
            while (patientData.Read())
            {
                textBoxCardNumb.Text = Convert.ToString(patientData[0]);
                textBoxFirstName.Text = Convert.ToString(patientData[1]);
                textBoxSurname.Text = Convert.ToString(patientData[2]);
                textBoxMiddleName.Text = Convert.ToString(patientData[3]);
                textBoxBirth.Text = Convert.ToString(patientData[4]);
                textBoxPhone.Text = Convert.ToString(patientData[5]);
                textBoxAddress.Text = Convert.ToString(patientData[6]);
            }

        }
    }
}
