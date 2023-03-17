namespace CSharp_TodoApp2.Forms
{
    partial class FrmMain
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.BtnRegisterUser = new System.Windows.Forms.Button();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.BtnUpdateUser = new System.Windows.Forms.Button();
            this.BtnAuthorityUpdate = new System.Windows.Forms.Button();
            this.BtnReleaseLock = new System.Windows.Forms.Button();
            this.BtnInsertTask = new System.Windows.Forms.Button();
            this.BtnTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(616, 377);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(138, 43);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.Text = "ログアウト";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnRegisterUser
            // 
            this.BtnRegisterUser.Location = new System.Drawing.Point(29, 42);
            this.BtnRegisterUser.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegisterUser.Name = "BtnRegisterUser";
            this.BtnRegisterUser.Size = new System.Drawing.Size(138, 43);
            this.BtnRegisterUser.TabIndex = 31;
            this.BtnRegisterUser.Text = "ユーザ登録";
            this.BtnRegisterUser.UseVisualStyleBackColor = true;
            this.BtnRegisterUser.Click += new System.EventHandler(this.BtnRegisterUser_Click);
            // 
            // BtnUsers
            // 
            this.BtnUsers.Location = new System.Drawing.Point(192, 42);
            this.BtnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(138, 43);
            this.BtnUsers.TabIndex = 32;
            this.BtnUsers.Text = "ユーザ一覧";
            this.BtnUsers.UseVisualStyleBackColor = true;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnUpdateUser
            // 
            this.BtnUpdateUser.Location = new System.Drawing.Point(348, 42);
            this.BtnUpdateUser.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdateUser.Name = "BtnUpdateUser";
            this.BtnUpdateUser.Size = new System.Drawing.Size(138, 43);
            this.BtnUpdateUser.TabIndex = 33;
            this.BtnUpdateUser.Text = "ユーザ更新";
            this.BtnUpdateUser.UseVisualStyleBackColor = true;
            this.BtnUpdateUser.Click += new System.EventHandler(this.BtnUpdateUser_Click);
            // 
            // BtnAuthorityUpdate
            // 
            this.BtnAuthorityUpdate.Location = new System.Drawing.Point(29, 118);
            this.BtnAuthorityUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAuthorityUpdate.Name = "BtnAuthorityUpdate";
            this.BtnAuthorityUpdate.Size = new System.Drawing.Size(138, 43);
            this.BtnAuthorityUpdate.TabIndex = 34;
            this.BtnAuthorityUpdate.Text = "権限更新";
            this.BtnAuthorityUpdate.UseVisualStyleBackColor = true;
            this.BtnAuthorityUpdate.Click += new System.EventHandler(this.BtnAuthorityUpdate_Click);
            // 
            // BtnReleaseLock
            // 
            this.BtnReleaseLock.Location = new System.Drawing.Point(192, 118);
            this.BtnReleaseLock.Margin = new System.Windows.Forms.Padding(2);
            this.BtnReleaseLock.Name = "BtnReleaseLock";
            this.BtnReleaseLock.Size = new System.Drawing.Size(138, 43);
            this.BtnReleaseLock.TabIndex = 35;
            this.BtnReleaseLock.Text = "アカウントロック解除";
            this.BtnReleaseLock.UseVisualStyleBackColor = true;
            this.BtnReleaseLock.Click += new System.EventHandler(this.BtnReleaseLock_Click);
            // 
            // BtnInsertTask
            // 
            this.BtnInsertTask.Location = new System.Drawing.Point(29, 195);
            this.BtnInsertTask.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInsertTask.Name = "BtnInsertTask";
            this.BtnInsertTask.Size = new System.Drawing.Size(138, 43);
            this.BtnInsertTask.TabIndex = 36;
            this.BtnInsertTask.Text = "タスク登録";
            this.BtnInsertTask.UseVisualStyleBackColor = true;
            this.BtnInsertTask.Click += new System.EventHandler(this.BtnInsertTask_Click);
            // 
            // BtnTasks
            // 
            this.BtnTasks.Location = new System.Drawing.Point(192, 195);
            this.BtnTasks.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTasks.Name = "BtnTasks";
            this.BtnTasks.Size = new System.Drawing.Size(138, 43);
            this.BtnTasks.TabIndex = 37;
            this.BtnTasks.Text = "タスク一覧";
            this.BtnTasks.UseVisualStyleBackColor = true;
            this.BtnTasks.Click += new System.EventHandler(this.BtnTasks_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnTasks);
            this.Controls.Add(this.BtnInsertTask);
            this.Controls.Add(this.BtnReleaseLock);
            this.Controls.Add(this.BtnAuthorityUpdate);
            this.Controls.Add(this.BtnUpdateUser);
            this.Controls.Add(this.BtnUsers);
            this.Controls.Add(this.BtnRegisterUser);
            this.Controls.Add(this.btnLogout);
            this.Name = "FrmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnLogout;
        internal System.Windows.Forms.Button BtnRegisterUser;
        internal System.Windows.Forms.Button BtnUsers;
        internal System.Windows.Forms.Button BtnUpdateUser;
        internal System.Windows.Forms.Button BtnAuthorityUpdate;
        internal System.Windows.Forms.Button BtnReleaseLock;
        internal System.Windows.Forms.Button BtnInsertTask;
        internal System.Windows.Forms.Button BtnTasks;
    }
}