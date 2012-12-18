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
        private int count;

        public Profil()
        {
            InitializeComponent();
        }

        public void refreshView()
        {
            authorityView.Rows.Clear();
            for (int i = 2; i < count; i++)
            {
                authorityView.Columns.RemoveAt(2);
            }
            count = 2;
            List<Component> components = ComponentService.FindAll();
            foreach (Component c in components)
            {
                DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
                column.HeaderText = c.name;
                authorityView.Columns.Insert(count, column);
                count++;
            }
            foreach (Profile p in ProfileService.FindAll())
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell rolename = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                rolename.Value = p.name;
                id.Value = p.id;
                row.Cells.Add(id);
                row.Cells.Add(rolename);
                foreach (Component c in components)
                {
                    DataGridViewCheckBoxCell permission = new DataGridViewCheckBoxCell();
                    permission.Value = false;
                    foreach (Component pc in p.Components())
                    {
                        if (c.id.Equals(pc.id))
                        {
                            permission.Value = true;
                            break;
                        }
                    }
                    row.Cells.Add(permission);
                }
                authorityView.Rows.Add(row);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Profil_Load(object sender, EventArgs e)
        {
            refreshView();
        }

        private void authorityView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Profile p = ProfileService.FindById<Profile>(Convert.ToInt64(authorityView.Rows[e.RowIndex].Cells[0].Value));
            if (e.ColumnIndex == count)
            {
                Simplifier.delete(p);
            }
            else if (e.ColumnIndex == count+1)
            {
                ProfilForm profileForm = new ProfilForm(this);
                profileForm.setProfile(p);
                profileForm.Visible = true;
            }
            refreshView();
        }

        private void btnNewPermission_Click(object sender, EventArgs e)
        {
            ProfilForm profileForm = new ProfilForm(this);
            profileForm.Visible = true;
        }


    }
}
