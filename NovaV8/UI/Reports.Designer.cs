﻿namespace NovaV8
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stammdatenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.projectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.taskMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.roleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expendure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNewReport = new System.Windows.Forms.Button();
            this.cbTasks = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(12, 39);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(315, 39);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Raporte verwalten";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(33, 93);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(55, 20);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Kunde";
            // 
            // cbCustomer
            // 
            this.cbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(37, 116);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(243, 32);
            this.cbCustomer.TabIndex = 3;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // cbProject
            // 
            this.cbProject.Enabled = false;
            this.cbProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(326, 115);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(266, 32);
            this.cbProject.TabIndex = 5;
            this.cbProject.SelectedIndexChanged += new System.EventHandler(this.cbProject_SelectedIndexChanged);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(322, 92);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(58, 20);
            this.lblProject.TabIndex = 4;
            this.lblProject.Text = "Projekt";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.infoMenuItem,
            this.stammdatenMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutMenu,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "&Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // infoMenuItem
            // 
            this.infoMenuItem.Name = "infoMenuItem";
            this.infoMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoMenuItem.Text = "&Info";
            this.infoMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // stammdatenMenu
            // 
            this.stammdatenMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeMenu,
            this.customerMenu,
            this.projectMenu,
            this.taskMenu,
            this.roleMenu});
            this.stammdatenMenu.Name = "stammdatenMenu";
            this.stammdatenMenu.Size = new System.Drawing.Size(87, 20);
            this.stammdatenMenu.Text = "Stammdaten";
            // 
            // employeeMenu
            // 
            this.employeeMenu.Name = "employeeMenu";
            this.employeeMenu.Size = new System.Drawing.Size(152, 22);
            this.employeeMenu.Text = "Mitarbeiter";
            this.employeeMenu.Click += new System.EventHandler(this.mitarbeiterToolStripMenuItem_Click);
            // 
            // customerMenu
            // 
            this.customerMenu.Name = "customerMenu";
            this.customerMenu.Size = new System.Drawing.Size(152, 22);
            this.customerMenu.Text = "Kunden";
            this.customerMenu.Click += new System.EventHandler(this.kundenToolStripMenuItem_Click);
            // 
            // projectMenu
            // 
            this.projectMenu.Name = "projectMenu";
            this.projectMenu.Size = new System.Drawing.Size(152, 22);
            this.projectMenu.Text = "Projekte";
            this.projectMenu.Click += new System.EventHandler(this.projectMenu_Click);
            // 
            // taskMenu
            // 
            this.taskMenu.Name = "taskMenu";
            this.taskMenu.Size = new System.Drawing.Size(152, 22);
            this.taskMenu.Text = "Aufgaben";
            this.taskMenu.Click += new System.EventHandler(this.taskMenu_Click);
            // 
            // roleMenu
            // 
            this.roleMenu.Name = "roleMenu";
            this.roleMenu.Size = new System.Drawing.Size(152, 22);
            this.roleMenu.Text = "Rollen";
            this.roleMenu.Click += new System.EventHandler(this.rollenToolStripMenuItem_Click);
            // 
            // reportsView
            // 
            this.reportsView.AllowUserToAddRows = false;
            this.reportsView.AllowUserToDeleteRows = false;
            this.reportsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.activity,
            this.expendure,
            this.task,
            this.customer,
            this.user,
            this.project,
            this.delete,
            this.edit});
            this.reportsView.Location = new System.Drawing.Point(37, 163);
            this.reportsView.Name = "reportsView";
            this.reportsView.Size = new System.Drawing.Size(1062, 463);
            this.reportsView.TabIndex = 20;
            this.reportsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportsView_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // date
            // 
            this.date.HeaderText = "Datum";
            this.date.Name = "date";
            // 
            // activity
            // 
            this.activity.HeaderText = "Aktivität";
            this.activity.Name = "activity";
            // 
            // expendure
            // 
            this.expendure.HeaderText = "Aufwand";
            this.expendure.Name = "expendure";
            // 
            // task
            // 
            this.task.HeaderText = "Tätigkeit";
            this.task.Name = "task";
            // 
            // customer
            // 
            this.customer.HeaderText = "Kunde";
            this.customer.Name = "customer";
            // 
            // user
            // 
            this.user.HeaderText = "Person";
            this.user.Name = "user";
            // 
            // project
            // 
            this.project.HeaderText = "Projekt";
            this.project.Name = "project";
            // 
            // delete
            // 
            this.delete.HeaderText = "Löschen";
            this.delete.Name = "delete";
            this.delete.Text = "Löschen";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "Bearbeiten";
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Text = "Bearbeiten";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // btnNewReport
            // 
            this.btnNewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewReport.Location = new System.Drawing.Point(957, 110);
            this.btnNewReport.Name = "btnNewReport";
            this.btnNewReport.Size = new System.Drawing.Size(142, 37);
            this.btnNewReport.TabIndex = 21;
            this.btnNewReport.Text = "Hinzufügen";
            this.btnNewReport.UseVisualStyleBackColor = true;
            this.btnNewReport.Click += new System.EventHandler(this.btnNewReport_Click);
            // 
            // cbTasks
            // 
            this.cbTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTasks.FormattingEnabled = true;
            this.cbTasks.Items.AddRange(new object[] {
            "-"});
            this.cbTasks.Location = new System.Drawing.Point(633, 115);
            this.cbTasks.Name = "cbTasks";
            this.cbTasks.Size = new System.Drawing.Size(266, 32);
            this.cbTasks.TabIndex = 23;
            this.cbTasks.SelectedIndexChanged += new System.EventHandler(this.cbTasks_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Aufgaben";
            // 
            // logoutMenu
            // 
            this.logoutMenu.Name = "logoutMenu";
            this.logoutMenu.Size = new System.Drawing.Size(152, 22);
            this.logoutMenu.Text = "Abmelden";
            this.logoutMenu.Click += new System.EventHandler(this.logoutMenu_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 651);
            this.Controls.Add(this.cbTasks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewReport);
            this.Controls.Add(this.reportsView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cbProject);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblLogin);
            this.Name = "Reports";
            this.Text = "Raporte";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reports_FormClosed);
            this.Load += new System.EventHandler(this.Reports_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView reportsView;
        private System.Windows.Forms.Button btnNewReport;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoMenuItem;
        private System.Windows.Forms.ComboBox cbTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn activity;
        private System.Windows.Forms.DataGridViewTextBoxColumn expendure;
        private System.Windows.Forms.DataGridViewTextBoxColumn task;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn project;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.ToolStripMenuItem stammdatenMenu;
        private System.Windows.Forms.ToolStripMenuItem employeeMenu;
        private System.Windows.Forms.ToolStripMenuItem customerMenu;
        private System.Windows.Forms.ToolStripMenuItem projectMenu;
        private System.Windows.Forms.ToolStripMenuItem taskMenu;
        private System.Windows.Forms.ToolStripMenuItem roleMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutMenu;
    }
}