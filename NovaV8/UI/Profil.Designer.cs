namespace NovaV8
{
    partial class Profil
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
            this.authorityTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stammdatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.rolename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createReport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.editReport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.authorityManagement = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteRule = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.authorityTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // authorityTable
            // 
            this.authorityTable.AllowUserToDeleteRows = false;
            this.authorityTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorityTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rolename,
            this.createReport,
            this.editReport,
            this.authorityManagement,
            this.edit,
            this.deleteRule});
            this.authorityTable.Location = new System.Drawing.Point(0, 108);
            this.authorityTable.Name = "authorityTable";
            this.authorityTable.Size = new System.Drawing.Size(748, 285);
            this.authorityTable.TabIndex = 0;
            this.authorityTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.stammdatenToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // stammdatenToolStripMenuItem
            // 
            this.stammdatenToolStripMenuItem.Name = "stammdatenToolStripMenuItem";
            this.stammdatenToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.stammdatenToolStripMenuItem.Text = "Stammdaten";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(12, 37);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(273, 39);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Berechtigungen";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(586, 44);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 36);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "Hinzufügen";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // rolename
            // 
            this.rolename.FillWeight = 200F;
            this.rolename.HeaderText = "Rollenname";
            this.rolename.Name = "rolename";
            this.rolename.Width = 200;
            // 
            // createReport
            // 
            this.createReport.HeaderText = "Rapport erstellen";
            this.createReport.Name = "createReport";
            this.createReport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.createReport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // editReport
            // 
            this.editReport.HeaderText = "Raporte bearbeiten";
            this.editReport.Name = "editReport";
            // 
            // authorityManagement
            // 
            this.authorityManagement.HeaderText = "Berechtigungen verwalten";
            this.authorityManagement.Name = "authorityManagement";
            // 
            // edit
            // 
            this.edit.HeaderText = "Bearbeiten";
            this.edit.Name = "edit";
            // 
            // deleteRule
            // 
            this.deleteRule.HeaderText = "Löschen";
            this.deleteRule.Name = "deleteRule";
            // 
            // Authority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 404);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.authorityTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Authority";
            this.Text = "Berechtigungen verwalten";
            ((System.ComponentModel.ISupportInitialize)(this.authorityTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView authorityTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stammdatenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolename;
        private System.Windows.Forms.DataGridViewCheckBoxColumn createReport;
        private System.Windows.Forms.DataGridViewCheckBoxColumn editReport;
        private System.Windows.Forms.DataGridViewCheckBoxColumn authorityManagement;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn deleteRule;
    }
}