using RegistryLib;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital.View
{
    public partial class AllDoctors : Form
    {
        public AllDoctors()
        {
            InitializeComponent();
            comboBoxSearch.SelectedIndex = 0;
            FillDataGrid();
        }

        public void FillDataGrid()
        {
            DataTable table = Doctor.AllMembersTable();
            dataGridViewDoctors.DataSource = table;

            dataGridViewDoctors.Columns[0].Width = 60;
            dataGridViewDoctors.Columns[4].Width = 140;

            dataGridViewDoctors.RowsDefaultCellStyle.BackColor = Color.PowderBlue;
            dataGridViewDoctors.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DataTable table = Doctor.AllMembersTable();
            dataGridViewDoctors.DataSource = table;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int index = comboBoxSearch.SelectedIndex;
            string text = textBoxSearch.Text;
            DataTable table = Doctor.SearchDoctor(index, text);
            dataGridViewDoctors.DataSource = table;
        }

        private void Details_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridViewDoctors.CurrentCell.RowIndex;

                int doctirId = Convert.ToInt32(dataGridViewDoctors.Rows[rowIndex].Cells[0].Value);

                try
                {
                    DetailedDoctor form = new DetailedDoctor(doctirId);
                    form.Show();
                }
                catch { }
            }
        }

        private void buttonAddDoctor_Click(object sender, EventArgs e)
        {
            AddDoctor form = new AddDoctor();
            form.Show();
        }
    }
}
