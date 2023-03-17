namespace CSharp_TodoApp2.Forms
{
    partial class FrmTasks
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
            this.BtnOutputCSV = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.DgvTasks = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteTask = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUpdateTask = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTaskName = new System.Windows.Forms.Label();
            this.TxtSearchTaskName = new System.Windows.Forms.TextBox();
            this.lblSearchCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOutputCSV
            // 
            this.BtnOutputCSV.Location = new System.Drawing.Point(324, 472);
            this.BtnOutputCSV.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOutputCSV.Name = "BtnOutputCSV";
            this.BtnOutputCSV.Size = new System.Drawing.Size(143, 43);
            this.BtnOutputCSV.TabIndex = 62;
            this.BtnOutputCSV.Text = "CSV出力";
            this.BtnOutputCSV.UseVisualStyleBackColor = true;
            this.BtnOutputCSV.Click += new System.EventHandler(this.BtnOutputCSV_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(500, 112);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(143, 43);
            this.BtnSearch.TabIndex = 61;
            this.BtnSearch.Text = "検索";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(500, 472);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(143, 43);
            this.BtnBack.TabIndex = 60;
            this.BtnBack.Text = "戻る";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DgvTasks
            // 
            this.DgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.txtTaskName,
            this.txtExpiredDate,
            this.txtPriority,
            this.txtDetail,
            this.txtComment,
            this.btnDeleteTask,
            this.btnUpdateTask,
            this.txtUserID});
            this.DgvTasks.Location = new System.Drawing.Point(163, 186);
            this.DgvTasks.Name = "DgvTasks";
            this.DgvTasks.RowHeadersWidth = 51;
            this.DgvTasks.RowTemplate.Height = 24;
            this.DgvTasks.Size = new System.Drawing.Size(480, 240);
            this.DgvTasks.TabIndex = 59;
            this.DgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTasks_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // txtTaskName
            // 
            this.txtTaskName.DataPropertyName = "TaskName";
            this.txtTaskName.HeaderText = "タスク名";
            this.txtTaskName.MinimumWidth = 6;
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Width = 125;
            // 
            // txtExpiredDate
            // 
            this.txtExpiredDate.DataPropertyName = "ExpiredDate";
            this.txtExpiredDate.HeaderText = "有効期限";
            this.txtExpiredDate.MinimumWidth = 6;
            this.txtExpiredDate.Name = "txtExpiredDate";
            this.txtExpiredDate.Width = 125;
            // 
            // txtPriority
            // 
            this.txtPriority.DataPropertyName = "Priority";
            this.txtPriority.HeaderText = "優先度";
            this.txtPriority.MinimumWidth = 6;
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Width = 125;
            // 
            // txtDetail
            // 
            this.txtDetail.DataPropertyName = "Detail";
            this.txtDetail.HeaderText = "詳細";
            this.txtDetail.MinimumWidth = 6;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Width = 125;
            // 
            // txtComment
            // 
            this.txtComment.DataPropertyName = "Comment";
            this.txtComment.HeaderText = "コメント";
            this.txtComment.MinimumWidth = 6;
            this.txtComment.Name = "txtComment";
            this.txtComment.Width = 125;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.HeaderText = "削除";
            this.btnDeleteTask.MinimumWidth = 6;
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Width = 125;
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.HeaderText = "更新";
            this.btnUpdateTask.MinimumWidth = 6;
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Width = 125;
            // 
            // txtUserID
            // 
            this.txtUserID.DataPropertyName = "UserId";
            this.txtUserID.HeaderText = "ユーザID";
            this.txtUserID.MinimumWidth = 6;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Visible = false;
            this.txtUserID.Width = 125;
            // 
            // LblTaskName
            // 
            this.LblTaskName.AutoSize = true;
            this.LblTaskName.Location = new System.Drawing.Point(174, 46);
            this.LblTaskName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTaskName.Name = "LblTaskName";
            this.LblTaskName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblTaskName.Size = new System.Drawing.Size(53, 15);
            this.LblTaskName.TabIndex = 58;
            this.LblTaskName.Text = "タスク名";
            // 
            // TxtSearchTaskName
            // 
            this.TxtSearchTaskName.Location = new System.Drawing.Point(163, 76);
            this.TxtSearchTaskName.Name = "TxtSearchTaskName";
            this.TxtSearchTaskName.Size = new System.Drawing.Size(480, 22);
            this.TxtSearchTaskName.TabIndex = 57;
            // 
            // lblSearchCount
            // 
            this.lblSearchCount.AutoSize = true;
            this.lblSearchCount.Location = new System.Drawing.Point(650, 76);
            this.lblSearchCount.Name = "lblSearchCount";
            this.lblSearchCount.Size = new System.Drawing.Size(0, 15);
            this.lblSearchCount.TabIndex = 63;
            // 
            // FrmTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.lblSearchCount);
            this.Controls.Add(this.BtnOutputCSV);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.DgvTasks);
            this.Controls.Add(this.LblTaskName);
            this.Controls.Add(this.TxtSearchTaskName);
            this.Name = "FrmTasks";
            this.Text = "FrmTasks";
            this.Load += new System.EventHandler(this.FrmTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnOutputCSV;
        internal System.Windows.Forms.Button BtnSearch;
        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.DataGridView DgvTasks;
        internal System.Windows.Forms.Label LblTaskName;
        internal System.Windows.Forms.TextBox TxtSearchTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtExpiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtComment;
        private System.Windows.Forms.DataGridViewButtonColumn btnDeleteTask;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdateTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUserID;
        private System.Windows.Forms.Label lblSearchCount;
    }
}