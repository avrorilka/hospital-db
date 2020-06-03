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
            FillDataGrid();
        }

        public void FillDataGrid()
        {
            DataTable table = Doctor.AllMembersTable();
            dataGridViewDoctors.DataSource = table;
        }
    }
}
