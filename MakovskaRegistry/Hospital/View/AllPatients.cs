using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital.View;
using RegistryLib;

namespace Hospital
{
    public partial class AllPatients : Form
    {
        public AllPatients()
        {
            InitializeComponent();

            comboBoxSearch.SelectedIndex = 0;

            FillDataGrid();
         
        }

        public void FillDataGrid()
        {
            DataTable table = Patient.AllMembersTable();
            dataGridViewPatients.DataSource = table;
        }
      

        private void Details_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridViewPatients.CurrentCell.RowIndex;

                int card_number = Convert.ToInt32(dataGridViewPatients.Rows[rowIndex].Cells[0].Value);

                DetailedPatient form = new DetailedPatient(card_number);
                form.Show();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int index = comboBoxSearch.SelectedIndex;
            string text = textBoxSearch.Text;
            DataTable table = Patient.SearchPatient(index, text);
            dataGridViewPatients.DataSource = table;
        }
    }
}
