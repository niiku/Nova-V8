namespace NovaV8
{
    partial class Projects
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
            this.tbProject = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.begin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbProject)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(12, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(153, 39);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Projekte";
            // 
            // tbProject
            // 
            this.tbProject.AllowUserToAddRows = false;
            this.tbProject.AllowUserToDeleteRows = false;
            this.tbProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.number,
            this.name,
            this.begin,
            this.active});
            this.tbProject.Location = new System.Drawing.Point(19, 51);
            this.tbProject.Name = "tbProject";
            this.tbProject.ReadOnly = true;
            this.tbProject.Size = new System.Drawing.Size(552, 307);
            this.tbProject.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // number
            // 
            this.number.HeaderText = "Nummer";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // begin
            // 
            this.begin.HeaderText = "Beginn";
            this.begin.Name = "begin";
            this.begin.ReadOnly = true;
            // 
            // active
            // 
            this.active.HeaderText = "Aktiv";
            this.active.Name = "active";
            this.active.ReadOnly = true;
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 370);
            this.Controls.Add(this.tbProject);
            this.Controls.Add(this.lblLogin);
            this.Name = "Projects";
            this.Text = "Projekte";
            this.Load += new System.EventHandler(this.Projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.DataGridView tbProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn begin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn active;
    }
}