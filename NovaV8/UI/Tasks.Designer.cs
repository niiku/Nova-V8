namespace NovaV8
{
    partial class Tasks
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
            this.tbTasks = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Benutzername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rolle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(12, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(172, 39);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Aufgaben";
            // 
            // tbTasks
            // 
            this.tbTasks.AllowUserToAddRows = false;
            this.tbTasks.AllowUserToDeleteRows = false;
            this.tbTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Benutzername,
            this.Rolle});
            this.tbTasks.Location = new System.Drawing.Point(19, 51);
            this.tbTasks.Name = "tbTasks";
            this.tbTasks.ReadOnly = true;
            this.tbTasks.Size = new System.Drawing.Size(353, 307);
            this.tbTasks.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Benutzername
            // 
            this.Benutzername.HeaderText = "Name";
            this.Benutzername.Name = "Benutzername";
            this.Benutzername.ReadOnly = true;
            // 
            // Rolle
            // 
            this.Rolle.HeaderText = "Beschreibung";
            this.Rolle.Name = "Rolle";
            this.Rolle.ReadOnly = true;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 370);
            this.Controls.Add(this.tbTasks);
            this.Controls.Add(this.lblLogin);
            this.Name = "Tasks";
            this.Text = "Aufgaben";
            this.Load += new System.EventHandler(this.Tasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.DataGridView tbTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Benutzername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rolle;
    }
}