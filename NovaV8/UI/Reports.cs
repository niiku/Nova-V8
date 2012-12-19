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
            List<Component> components = Utils.currentUser.Profile().Components();
            List<int> compNumbers = new List<int>();
            foreach (Component c in components)
            {
                compNumbers.Add(c.id);
            }
            btnNewReport.Enabled = compNumbers.Contains(Component.ADD_REPORT);
            permissionMenuItem.Visible = compNumbers.Contains(Component.EDIT_PERMISSION) || compNumbers.Contains(Component.ADD_PERMISSION);
            stammdatenMenuItem.Visible = compNumbers.Contains(Component.SHOW_STAMMDATEN);
            edit.Visible = compNumbers.Contains(Component.EDIT_REPORT);
            delete.Visible = compNumbers.Contains(Component.EDIT_REPORT);


        }



        public void refreshView()
        {
            loadPermissions();
            reportsView.Rows.Clear();
            Project selectedProject = (Project)cbProject.SelectedItem;
            Task selectedTask = (Task)cbTasks.SelectedValue;
            List<Report> reports = selectedTask != null && selectedTask.id != 0 ? ReportService.FindReportsByProjectAndTask(selectedProject, selectedTask) : ReportService.FindReportsByProject(selectedProject);
            foreach (Report r in reports)
            {
                reportsView.Rows.Add(r.id, r.date.ToString("dd.MM.yyy"), r.description, r.expenditure, r.Task().name, r.Project().Customer().name, r.User().name, r.Project().name);
            }

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            cbCustomer.DataSource = CustomerService.FindAll();
            Task empty = new Task();
            empty.name = "";
            List<Task> tasks = new List<Task>();
            tasks.Add(empty);
            tasks.AddRange(TaskService.FindAll());
            cbTasks.DataSource = tasks;
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
            Console.WriteLine("Clicked ReportsTable on Row: " + e.RowIndex);
            if (e.RowIndex != -1)
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

        private void cbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshView();
        }

        private void staffMenuItem_Click(object sender, EventArgs e)
        {

            new Staff(this).ShowDialog();
        }

        private void Reports_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    }
}
