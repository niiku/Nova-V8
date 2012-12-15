using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaV8
{
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
            object[] buffer = new object[4];
            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            buffer[0] = "Admin";
            buffer[1] = true;
            buffer[2] = true;
            buffer[3] = true;
            DataGridViewRow row = new DataGridViewRow();
            rows.Add(row);
            row.CreateCells(authorityTable, buffer);

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
