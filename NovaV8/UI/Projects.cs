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
    public partial class Projects : Form
    {
        public Projects(Form parent)
        {
            InitializeComponent();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            foreach (Project p in ProjectService.FindAll())
            {
                tbProject.Rows.Add(p.id, p.number, p.name, p.begin.ToString("yyyy.MM.dd"), p.active);
            }
        }
    }
}
