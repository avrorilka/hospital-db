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
    public partial class AllAppointments : Form
    {
        public AllAppointments()
        {
            InitializeComponent();
            FillDataGrid();
        }
        public void FillDataGrid()
        {
            DataTable table = Appointment.AllMembersTable();
            dataGridViewAppointments.DataSource = table;
            dataGridViewAppointments.Columns[3].Width = 130;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //int index = comboBoxSearch.SelectedIndex;
            //string text = textBoxSearch.Text;
            //DataTable table = Patient.SearchPatient(index, text);
            //dataGridViewPatients.DataSource = table;
        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            //AddPatient form = new AddPatient();
            //form.Show();
        }

        private void Details_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridViewAppointments.CurrentCell.RowIndex;

                int id = Convert.ToInt32(dataGridViewAppointments.Rows[rowIndex].Cells[0].Value);

                DetailedAppointment form = new DetailedAppointment(id);
                form.Show();
            }
        }
    }
}
