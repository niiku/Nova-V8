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
    public partial class ReportForm : Form
    {
        Report report;
        Form parent;

        public ReportForm(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            cbCustomer.DataSource = CustomerService.FindAll();
            if (report != null)
            {
                reportDate.Value = report.date;
                tbHours.Text = report.expenditure.ToString();
                cbProject.SelectedItem = report.Project();
                cbTask.SelectedItem = report.Task();
                tbDecription.Text = report.description;
            }
        }

        public void setReport(Report r)
        {
            report = r;
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProject.DataSource = ProjectService.FindProjectsByCustomer((Customer)cbCustomer.SelectedItem);
            cbProject.Enabled = true;
        }

        private void cbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTask.Enabled = true;
            cbTask.DataSource = TaskService.FindAll();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.date = ((DateTime)reportDate.Value);
            if (tbHours.Text.Length > 0)
            {
                r.expenditure = Convert.ToInt16(tbHours.Text);
            }
            else
            {
                r.expenditure = 0;
            }
            r.setProject((Project)cbProject.SelectedItem);
            r.setTask((Task)cbTask.SelectedItem);
            r.setUser(Utils.currentUser);
            r.description = tbDecription.Text;
            if (report != null)
            {
                if (report.id != 0)
                {
                    r.id = report.id;
                }
            }

            Simplifier.insertOrUpdate(r);
            ((Reports)this.parent).refreshView();
            this.Close();
        }

        private void tbHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

        }



    }
}
