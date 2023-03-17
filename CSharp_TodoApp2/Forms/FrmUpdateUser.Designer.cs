namespace CSharp_TodoApp2.Forms
{
    partial class FrmUpdateUser
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
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.BtnUpdateUser = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(158, 247);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtPassword.Size = new System.Drawing.Size(401, 22);
            this.TxtPassword.TabIndex = 37;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(158, 144);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtUserName.Size = new System.Drawing.Size(401, 22);
            this.TxtUserName.TabIndex = 36;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(158, 203);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblPassword.Size = new System.Drawing.Size(64, 15);
            this.LblPassword.TabIndex = 35;
            this.LblPassword.Text = "パスワード";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(164, 89);
            this.LblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblUserName.Size = new System.Drawing.Size(58, 15);
            this.LblUserName.TabIndex = 34;
            this.LblUserName.Text = "ユーザ名";
            // 
            // BtnUpdateUser
            // 
            this.BtnUpdateUser.Location = new System.Drawing.Point(434, 301);
            this.BtnUpdateUser.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdateUser.Name = "BtnUpdateUser";
            this.BtnUpdateUser.Size = new System.Drawing.Size(138, 43);
            this.BtnUpdateUser.TabIndex = 38;
            this.BtnUpdateUser.Text = "更新";
            this.BtnUpdateUser.UseVisualStyleBackColor = true;
            this.BtnUpdateUser.Click += new System.EventHandler(this.BtnUpdateUser_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(268, 301);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(138, 43);
            this.BtnBack.TabIndex = 39;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnUpdateUser);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUserName);
            this.Name = "FrmUpdateUser";
            this.Text = "FrmUpdateUser";
            this.Load += new System.EventHandler(this.FrmUpdateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TxtPassword;
        internal System.Windows.Forms.TextBox TxtUserName;
        internal System.Windows.Forms.Label LblPassword;
        internal System.Windows.Forms.Label LblUserName;
        internal System.Windows.Forms.Button BtnUpdateUser;
        internal System.Windows.Forms.Button BtnBack;
    }
}