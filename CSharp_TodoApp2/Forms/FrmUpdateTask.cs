using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_TodoApp2.Forms
{
    public partial class FrmUpdateTask : Form
    {
        //ログインユーザID
        private readonly long loginUserID;
        //更新対象タスクID
        private readonly long updateTaskID;
        public FrmUpdateTask(long loginUserID,
                                long updateTaskID)
        {
            InitializeComponent();

            //設定
            //ログインユーザID
            this.loginUserID = loginUserID;
            //更新対象タスクID
            this.updateTaskID = updateTaskID;
        }

        private void FrmUpdateTask_Load(object sender, EventArgs e)
        {
            try
            {
                //フォーム初期化
                InitForm();
            }
            catch (Exception ex)
            {
                //メッセージボックス
                MessageBox.Show(ex.Message,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateTask_Click(object sender, EventArgs e)
        {
            try
            {
                //タスク名
                string taskName = this.txtTaskName.Text;
                //有効期限
                DateTime expiredDate = this.dateExpiredDate.Value;
                //優先度
                string priority = this.cmbPriority.Text;
                //詳細
                string detail = this.txtDetail.Text;
                //コメント
                string comment = this.txtComment.Text;

                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //文字数チェック(タスク名)
                if (! commonFunc.IsFitInText(taskName, Constant.TASKNAME_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.INVALID_TASKNAME_LENGTH,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //入力チェック(有効期限)
                if (! commonFunc.IsInputed(expiredDate.ToString()))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.EXPIRED_DATE_MUST_INPUT,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //未来日チェック(有効期限)
                if (! commonFunc.IsFuture(expiredDate))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.EXPIRED_DATE_MUST_FUTURE,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //入力チェック(優先度)
                if (! commonFunc.IsInputed(priority))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.PRIORITY_MUST_INPUT,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //コンボボックスの選択肢内かどうか?(優先度)
                if (! commonFunc.IsTextInCmb(this.cmbPriority, priority))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.PRIORITY_MUST_IN_CMB,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //文字数チェック(詳細)
                if (! commonFunc.IsFitInText(detail, Constant.DETAIL_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.INVALID_DETAIL_LENGTH,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //文字数チェック(コメント)
                if (! commonFunc.IsFitInText(comment, Constant.COMMENT_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.INVALID_COMMENT_LENGTH,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //インスタンス化
                Task task = new Task();

                //更新
                if (! task.UpdateTask(taskName, 
                                    expiredDate,
                                    priority,
                                    detail,
                                    comment,
                                    this.loginUserID, 
                                    this.updateTaskID))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.FAILED_UPDATE_TASK,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //成功メッセージ
                MessageBox.Show(Constant.SUCCESS_UPDATE_TASK,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //メッセージボックス
                MessageBox.Show(ex.Message,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //メイン画面に遷移
                commonFunc.HideAndOpen(this, new FrmMain(this.loginUserID));
            }
            catch (Exception ex)
            {
                //メッセージボックス
                MessageBox.Show(ex.Message,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// フォーム初期化
        /// </summary>
        /// 2023/03/15
        private void InitForm()
        {
            //コンボボックス設定
            SetCmb();

            //インスタンス化
            Task task = new Task();

            //タスク情報を取得
            TaskData taskData = task.GetTask(this.updateTaskID);

            //設定
            //タスク名
            this.txtTaskName.Text = taskData.TaskName;
            //有効期限
            this.dateExpiredDate.Value = taskData.ExpiredDate;
            //優先度
            this.cmbPriority.Text = taskData.Priority;
            //詳細
            this.txtDetail.Text = taskData.Detail;
            //コメント
            this.txtComment.Text = taskData.Comment;
        }


        /// <summary>
        /// コンボボックス設定
        /// </summary>
        /// 2023/03/15
        private void SetCmb()
        {
            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //優先度のリストを取得
            List<string> priorityList = otherFunc.GetPriorityList();

            //インスタンス化
            CommonFunc commonFunc = new CommonFunc();

            //コンボボックス設定
            commonFunc.SetCmb(this.cmbPriority, priorityList);
        }
    }
}
