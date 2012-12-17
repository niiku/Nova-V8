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

            foreach (Report r in ReportService.FindAll())
            {
                reportsView.Rows.Add(r.date.ToString("dd.MM.yyy"), r.description, r.expenditure, r.Task().name, r.Project().Customer().name, r.User().name, r.Project().name);
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
                reportsView.Rows.Add(r.date.ToString("dd.MM.yyy"), r.description, r.expenditure, r.Task().name, r.Project().Customer().name, r.User().name, r.Project().name);
            }
        }

        private void btnNewReport_Click(object sender, EventArgs e)
        {
            ReportForm newReportForm = new ReportForm();
            newReportForm.Visible = true;
        }



    }
}
