using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.View;
using RegistryLib;

namespace Hospital
{
    public partial class HospitalForm : Form
    {
        public HospitalForm()
        {
            InitializeComponent();
        }

        private void buttonPatients_Click(object sender, EventArgs e)
        {
            AllPatients form = new AllPatients();
            form.Show();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAllDoctors_Click(object sender, EventArgs e)
        {
            AllDoctors form = new AllDoctors();
            form.Show();
        }

        private void buttonAppointments_Click(object sender, EventArgs e)
        {
            AllAppointments form = new AllAppointments();
            form.Show();
        }
    }
}
