using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaV8.UI
{
    public partial class Customer : Form
    {
        public Customer(Form parent)
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            foreach(NovaV8.Customer c in CustomerService.FindAll())
            {
                tbCustomer.Rows.Add(c.id, c.name, c.description);
            }
        }
    }
}
