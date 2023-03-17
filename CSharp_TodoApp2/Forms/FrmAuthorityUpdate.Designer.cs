namespace CSharp_TodoApp2.Forms
{
    partial class FrmAuthorityUpdate
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.txtUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdminUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNormalUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(475, 331);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(143, 43);
            this.BtnBack.TabIndex = 40;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DgvUsers
            // 
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtUserName,
            this.txtPassword,
            this.btnAdminUpdate,
            this.txtID,
            this.btnNormalUpdate});
            this.DgvUsers.Location = new System.Drawing.Point(182, 77);
            this.DgvUsers.Margin = new System.Windows.Forms.Padding(2);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.RowHeadersWidth = 62;
            this.DgvUsers.RowTemplate.Height = 27;
            this.DgvUsers.Size = new System.Drawing.Size(436, 223);
            this.DgvUsers.TabIndex = 39;
            this.DgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsers_CellContentClick);
            // 
            // txtUserName
            // 
            this.txtUserName.DataPropertyName = "UserName";
            this.txtUserName.HeaderText = "ユーザ名";
            this.txtUserName.MinimumWidth = 8;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Width = 150;
            // 
            // txtPassword
            // 
            this.txtPassword.DataPropertyName = "Password";
            this.txtPassword.HeaderText = "パスワード";
            this.txtPassword.MinimumWidth = 8;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Visible = false;
            this.txtPassword.Width = 150;
            // 
            // btnAdminUpdate
            // 
            this.btnAdminUpdate.HeaderText = "管理者にする";
            this.btnAdminUpdate.MinimumWidth = 8;
            this.btnAdminUpdate.Name = "btnAdminUpdate";
            this.btnAdminUpdate.Width = 150;
            // 
            // txtID
            // 
            this.txtID.DataPropertyName = "Id";
            this.txtID.HeaderText = "ID";
            this.txtID.MinimumWidth = 8;
            this.txtID.Name = "txtID";
            this.txtID.Visible = false;
            this.txtID.Width = 150;
            // 
            // btnNormalUpdate
            // 
            this.btnNormalUpdate.HeaderText = "一般ユーザにする";
            this.btnNormalUpdate.MinimumWidth = 6;
            this.btnNormalUpdate.Name = "btnNormalUpdate";
            this.btnNormalUpdate.Width = 125;
            // 
            // FrmAuthorityUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DgvUsers);
            this.Name = "FrmAuthorityUpdate";
            this.Text = "FrmAuthorityUpdate";
            this.Load += new System.EventHandler(this.FrmAuthorityUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPassword;
        private System.Windows.Forms.DataGridViewButtonColumn btnAdminUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewButtonColumn btnNormalUpdate;
    }
}