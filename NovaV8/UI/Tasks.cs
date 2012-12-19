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
    public partial class Tasks : Form
    {
        public Tasks(Form parent)
        {
            InitializeComponent();
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            foreach (Task t in TaskService.FindAll())
            {
                tbTasks.Rows.Add(t.id, t.name, t.description);
            }
        }
    }
}
