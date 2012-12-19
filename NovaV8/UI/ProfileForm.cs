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
    public partial class ProfilForm : Form
    {
        private Form parent;
        private Profile profile = new Profile();

        public ProfilForm(Form parent)
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

        private void btSave_Click(object sender, EventArgs e)
        {
            if (tbRolename.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bitte einen Rollennamen angeben");
                return;
            }
            profile.name = tbRolename.Text;
            Simplifier.insertOrUpdate(profile);

            foreach (DataGridViewRow row in componentsView.Rows)
            {
                Component c = new Component();
                c.id = Convert.ToInt16(row.Cells[0].Value);
                c.name = row.Cells[1].Value.ToString();
                if ((bool)row.Cells[2].Value)
                {
                    profile.setComponent(c);
                }
                else
                {
                    profile.removeComponent(c);
                }
            }

            ((ProfileOverview)this.parent).refreshView();
            this.Close();
        }

        private void ProfilForm_Load(object sender, EventArgs e)
        {
            if (profile != null)
            {
                tbRolename.Text = profile.name;
                foreach (Component c in ComponentService.FindAll())
                {
                    bool hasRole = false;
                    foreach (Component pc in profile.Components())
                    {
                        if (c.id.Equals(pc.id))
                        {
                            hasRole = true;
                            break;
                        }
                    }
                    componentsView.Rows.Add(c.id, c.name, hasRole);
                }
            }
            else
            {
                foreach (Component c in ComponentService.FindAll())
                {
                    componentsView.Rows.Add(c.id, c.name, false);
                }
            }

        }


    }
}
