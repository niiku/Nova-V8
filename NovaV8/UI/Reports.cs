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
            loadPermissions();

        }

        public void loadPermissions()
        {
            btnNewReport.Enabled = Utils.currentUser.hasPermissionForComponent(Component.ADD_REPORT);
            permissionMenuItem.Visible =  Utils.currentUser.hasPermissionForComponent(Component.EDIT_PERMISSION) || Utils.currentUser.hasPermissionForComponent(Component.ADD_PERMISSION);
            stammdatenMenuItem.Visible = Utils.currentUser.hasPermissionForComponent(Component.SHOW_STAMMDATEN);

        }



        public void refreshView()
        {
            loadPermissions();
            reportsView.Rows.Clear();
            foreach (Report r in ReportService.FindReportsByProject((Project)cbProject.SelectedItem))
            {
                reportsView.Rows.Add(r.id, r.date.ToString("dd.MM.yyy"), r.description, r.expenditure, r.Task().name, r.Project().Customer().name, r.User().name, r.Project().name);
            }
            
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            cbCustomer.DataSource = CustomerService.FindAll();
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProject.DataSource = ProjectService.FindProjectsByCustomer((Customer)cbCustomer.SelectedItem);
            cbProject.Enabled = true;
        }

        private void cbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshView();
        }

        private void btnNewReport_Click(object sender, EventArgs e)
        {
            ReportForm newReportForm = new ReportForm(this);
            newReportForm.Visible = true;
        }

        private void reportsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Report r = ReportService.FindById<Report>(Convert.ToInt64(reportsView.Rows[e.RowIndex].Cells[0].Value));
            if (e.ColumnIndex == 9)
            {
                ReportForm reportForm = new ReportForm(this);
                reportForm.setReport(r);
                reportForm.Visible = true;
            }
            else if (e.ColumnIndex == 8)
            {
                Simplifier.delete(r);
            }
            refreshView();
        }
        private static Info info = new Info();
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info.Visible = true;
        }

        private ProfileOverview profileUi;
        private void optionenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (profileUi == null)
            {
                profileUi = new ProfileOverview(this);
            }
            profileUi.ShowDialog();
        }



    }
}
