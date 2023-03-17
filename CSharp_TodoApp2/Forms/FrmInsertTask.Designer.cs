namespace CSharp_TodoApp2.Forms
{
    partial class FrmInsertTask
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
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.dateExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpiredDate = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTaskInsert = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(102, 339);
            this.txtDetail.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDetail.Size = new System.Drawing.Size(406, 107);
            this.txtDetail.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "詳細";
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(102, 260);
            this.cmbPriority.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(98, 23);
            this.cmbPriority.TabIndex = 48;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(104, 235);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPriority.Size = new System.Drawing.Size(52, 15);
            this.lblPriority.TabIndex = 47;
            this.lblPriority.Text = "優先度";
            // 
            // dateExpiredDate
            // 
            this.dateExpiredDate.Location = new System.Drawing.Point(104, 190);
            this.dateExpiredDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateExpiredDate.Name = "dateExpiredDate";
            this.dateExpiredDate.Size = new System.Drawing.Size(161, 22);
            this.dateExpiredDate.TabIndex = 46;
            // 
            // lblExpiredDate
            // 
            this.lblExpiredDate.AutoSize = true;
            this.lblExpiredDate.Location = new System.Drawing.Point(104, 156);
            this.lblExpiredDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpiredDate.Name = "lblExpiredDate";
            this.lblExpiredDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblExpiredDate.Size = new System.Drawing.Size(67, 15);
            this.lblExpiredDate.TabIndex = 45;
            this.lblExpiredDate.Text = "有効期限";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(102, 105);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTaskName.Size = new System.Drawing.Size(406, 22);
            this.txtTaskName.TabIndex = 44;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(104, 73);
            this.lblTaskName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTaskName.Size = new System.Drawing.Size(53, 15);
            this.lblTaskName.TabIndex = 43;
            this.lblTaskName.Text = "タスク名";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(201, 674);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 43);
            this.btnBack.TabIndex = 54;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnTaskInsert
            // 
            this.btnTaskInsert.Location = new System.Drawing.Point(365, 674);
            this.btnTaskInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaskInsert.Name = "btnTaskInsert";
            this.btnTaskInsert.Size = new System.Drawing.Size(143, 43);
            this.btnTaskInsert.TabIndex = 53;
            this.btnTaskInsert.Text = "登録";
            this.btnTaskInsert.UseVisualStyleBackColor = true;
            this.btnTaskInsert.Click += new System.EventHandler(this.BtnTaskInsert_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(102, 514);
            this.txtComment.Margin = new System.Windows.Forms.Padding(2);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtComment.Size = new System.Drawing.Size(406, 107);
            this.txtComment.TabIndex = 52;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(104, 470);
            this.lblComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblComment.Size = new System.Drawing.Size(49, 15);
            this.lblComment.TabIndex = 51;
            this.lblComment.Text = "コメント";
            // 
            // FrmInsertTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 870);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTaskInsert);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.dateExpiredDate);
            this.Controls.Add(this.lblExpiredDate);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.lblTaskName);
            this.Name = "FrmInsertTask";
            this.Text = "FrmInsertTask";
            this.Load += new System.EventHandler(this.FrmInsertTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtDetail;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbPriority;
        internal System.Windows.Forms.Label lblPriority;
        internal System.Windows.Forms.DateTimePicker dateExpiredDate;
        internal System.Windows.Forms.Label lblExpiredDate;
        internal System.Windows.Forms.TextBox txtTaskName;
        internal System.Windows.Forms.Label lblTaskName;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnTaskInsert;
        internal System.Windows.Forms.TextBox txtComment;
        internal System.Windows.Forms.Label lblComment;
    }
}