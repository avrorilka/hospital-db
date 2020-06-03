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

    }
}
