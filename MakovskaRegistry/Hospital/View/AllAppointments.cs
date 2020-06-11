using RegistryLib;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital.View
{
    public partial class AllAppointments : Form
    {
        public AllAppointments()
        {
            InitializeComponent();
            FillDataGrid();
            comboBoxSearch.SelectedIndex = 0;
        }
        public void FillDataGrid()
        {
            DataTable table = Appointment.AllMembersTable();
            dataGridViewAppointments.DataSource = table;

            dataGridViewAppointments.Columns[0].Width = 60;
            dataGridViewAppointments.Columns[1].Width = 190;
            dataGridViewAppointments.Columns[2].Width = 60;
            dataGridViewAppointments.Columns[3].Width = 130;

            dataGridViewAppointments.RowsDefaultCellStyle.BackColor = Color.PowderBlue;
            dataGridViewAppointments.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int index = comboBoxSearch.SelectedIndex;
            string text = textBoxSearch.Text;
            DataTable table = Appointment.SearchAppointment(index, text);
            dataGridViewAppointments.DataSource = table;
        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            AddAppointment form = new AddAppointment();
            form.Show();
        }

        private void Details_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridViewAppointments.CurrentCell.RowIndex;

                int id = Convert.ToInt32(dataGridViewAppointments.Rows[rowIndex].Cells[0].Value);

                try
                {
                    DetailedAppointment form = new DetailedAppointment(id);
                    form.Show();
                }
                catch { }
            }
        }
    }
}
