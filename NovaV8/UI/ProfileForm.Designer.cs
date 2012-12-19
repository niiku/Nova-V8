namespace NovaV8
{
    partial class ProfilForm
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbRolename = new System.Windows.Forms.TextBox();
            this.componentsView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.componentsView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(31, 83);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(94, 20);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Rollenname";
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(318, 496);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(142, 37);
            this.btSave.TabIndex = 11;
            this.btSave.Text = "Speichern";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(170, 496);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(142, 37);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Abbrechen";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(12, 19);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(401, 39);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Berechtigung verwalten";
            // 
            // tbRolename
            // 
            this.tbRolename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRolename.Location = new System.Drawing.Point(35, 106);
            this.tbRolename.Name = "tbRolename";
            this.tbRolename.Size = new System.Drawing.Size(424, 29);
            this.tbRolename.TabIndex = 20;
            // 
            // componentsView
            // 
            this.componentsView.AllowUserToAddRows = false;
            this.componentsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.componentsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.componentName,
            this.checkBoxes});
            this.componentsView.Location = new System.Drawing.Point(35, 153);
            this.componentsView.Name = "componentsView";
            this.componentsView.Size = new System.Drawing.Size(424, 337);
            this.componentsView.TabIndex = 21;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // componentName
            // 
            this.componentName.HeaderText = "Komponente";
            this.componentName.Name = "componentName";
            // 
            // checkBoxes
            // 
            this.checkBoxes.HeaderText = "";
            this.checkBoxes.Name = "checkBoxes";
            // 
            // ProfilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 546);
            this.Controls.Add(this.componentsView);
            this.Controls.Add(this.tbRolename);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblLogin);
            this.Name = "ProfilForm";
            this.Text = "Berechtigung verwalen";
            this.Load += new System.EventHandler(this.ProfilForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.componentsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbRolename;
        private System.Windows.Forms.DataGridView componentsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxes;
    }
}