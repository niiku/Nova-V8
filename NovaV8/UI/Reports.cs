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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn date = new DataGridViewTextBoxColumn();
            date.DataPropertyName = "Date";
            date.HeaderText = "Date";
            DataGridViewTextBoxColumn expendure = new DataGridViewTextBoxColumn();
            expendure.DataPropertyName = "Expendure";
            expendure.HeaderText = "Expendure";
            DataGridViewTextBoxColumn user = new DataGridViewTextBoxColumn();
            user.DataPropertyName = "User";
            user.HeaderText = "User";
            DataGridViewTextBoxColumn task = new DataGridViewTextBoxColumn();
            task.DataPropertyName = "Task";
            task.HeaderText = "Task";
            DataGridViewTextBoxColumn project = new DataGridViewTextBoxColumn();
            project.DataPropertyName = "Project";
            project.HeaderText = "Project";
            reportsView.Columns.Add(date);
            reportsView.Columns.Add(expendure);
            reportsView.Columns.Add(user);
            reportsView.Columns.Add(task);
            reportsView.Columns.Add(project);

            foreach (Report r in ReportService.FindAll())
            {
                reportsView.Rows.Add(r.date.ToString("dd.MM.yyy"), r.expenditure, r.User().name, r.Task().name, r.Project().name);
            }

            cbCustomer.DataSource = CustomerService.FindAll();
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProject.DataSource = ProjectService.FindProjectsByCustomer((Customer)cbCustomer.SelectedItem);
            cbProject.Enabled = true;
        }

        private void cbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportsView.Rows.Clear();
            foreach (Report r in ReportService.FindReportsByProject((Project)cbProject.SelectedItem))
            {
                reportsView.Rows.Add(r.date.ToString("dd.MM.yyy"), r.expenditure, r.User().name, r.Task().name, r.Project().name);
            }
        }


    }
}
