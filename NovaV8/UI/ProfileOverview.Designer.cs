namespace NovaV8
{
    partial class ProfileOverview
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
            this.authorityView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewPermission = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authorityView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(12, 12);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(121, 39);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Rollen";
            // 
            // authorityView
            // 
            this.authorityView.AllowUserToAddRows = false;
            this.authorityView.AllowUserToDeleteRows = false;
            this.authorityView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorityView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.rolename,
            this.delete,
            this.edit});
            this.authorityView.Location = new System.Drawing.Point(12, 61);
            this.authorityView.Name = "authorityView";
            this.authorityView.Size = new System.Drawing.Size(504, 306);
            this.authorityView.TabIndex = 23;
            this.authorityView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.authorityView_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // rolename
            // 
            this.rolename.HeaderText = "Rollenname";
            this.rolename.Name = "rolename";
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
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(354, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 36);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNewPermission
            // 
            this.btnNewPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPermission.Location = new System.Drawing.Point(180, 375);
            this.btnNewPermission.Name = "btnNewPermission";
            this.btnNewPermission.Size = new System.Drawing.Size(162, 36);
            this.btnNewPermission.TabIndex = 25;
            this.btnNewPermission.Text = "Hinzufügen";
            this.btnNewPermission.UseVisualStyleBackColor = true;
            this.btnNewPermission.Click += new System.EventHandler(this.btnNewPermission_Click);
            // 
            // ProfileOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 432);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewPermission);
            this.Controls.Add(this.authorityView);
            this.Controls.Add(this.lblLogin);
            this.Name = "ProfileOverview";
            this.Text = "Rollen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.Load += new System.EventHandler(this.Profil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorityView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.DataGridView authorityView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewPermission;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolename;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
    }
}