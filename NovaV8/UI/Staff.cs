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
    public partial class Staff : Form
    {
        private Form parent;
        private Profile profile = new Profile();

        public Staff(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }



        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setProfile(Profile p)
        {
            this.profile = p;
        }


        private void ProfilForm_Load(object sender, EventArgs e)
        {
            List<User> users = UserService.FindAll();
            foreach(User user in users) {
                tbStaff.Rows.Add(user.id.ToString(),user.name, user.Profile().name);
            }
        }


    }
}
