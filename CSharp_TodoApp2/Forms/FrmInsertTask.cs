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
    public partial class FrmInsertTask : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmInsertTask(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }

        private void FrmInsertTask_Load(object sender, EventArgs e)
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

        private void BtnTaskInsert_Click(object sender, EventArgs e)
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
                if (!commonFunc.IsFitInText(taskName, Constant.TASKNAME_MAX_LENGTH))
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
                if (! commonFunc.IsTextInCmb(cmbPriority, priority))
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

                //登録
                if (! task.InsertTask(taskName, expiredDate, priority, detail, comment, this.loginUserID))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.FAILED_INSERT_TASK,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //成功メッセージ
                MessageBox.Show(Constant.SUCCESS_INSERT_TASK,
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
        /// 2023/03/14
        private void InitForm()
        {
            //有効期限
            this.dateExpiredDate.Value = DateTime.Now;

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
