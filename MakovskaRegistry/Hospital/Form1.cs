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
            FillDataGrid();
        }
        public void FillDataGrid() 
        {
            SQLiteDataReader tableData = Model.AllMembers("Select * From Patient");
            DataTable table = new DataTable();
            table.Columns.Add("№ картки");
            table.Columns.Add("Ім'я");
            table.Columns.Add("Прізвище");
            table.Columns.Add("Дата народження");
            while (tableData.Read())
            {
                table.Rows.Add(tableData[0], tableData[1], tableData[2], tableData[4]);
            }
            dataGridViewPatients.DataSource = table;
        }

        private void Details_Click(object sender, EventArgs e)
        {

            if (dataGridViewPatients.SelectedRows.Count == 1 || dataGridViewPatients.SelectedCells.Count == 1)
            {
                int rowIndex = dataGridViewPatients.CurrentCell.RowIndex;

                int card_number = Convert.ToInt32(dataGridViewPatients.Rows[rowIndex].Cells[0].Value);

                DetailedPatient form = new DetailedPatient(card_number);
                form.Show();
            }
                
        }
    }
}
