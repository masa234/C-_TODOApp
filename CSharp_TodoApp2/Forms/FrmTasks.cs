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
    public partial class FrmTasks : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmTasks(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }

        private void FrmTasks_Load(object sender, EventArgs e)
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

        private void DgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //タスクID
                //TODO :　ここに書くべきかは議論の余地がある
                long.TryParse(this.DgvTasks.Rows[e.RowIndex].Cells[2].Value.ToString(), out long taskID);

                //削除ボタンが押されている場合
                if (this.DgvTasks.Columns[e.ColumnIndex].Name == "btnDeleteTask")
                {
                    //ユーザID
                    //TODO: 変数名改善の余地あり　
                    long.TryParse(this.DgvTasks.Rows[e.RowIndex].Cells[8].Value.ToString(), out long taskCreateUserID);

                    //ログインユーザのタスクかどうか?
                    if (this.loginUserID != taskCreateUserID)
                        return;

                    //インスタンス化
                    Task task = new Task();

                    //削除
                    if (! task.DeleteTask(taskID))
                    {
                        //メッセージボックス
                        MessageBox.Show(Constant.FAILED_DELETE_TASK,
                                        Constant.CONFIRM,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        return;
                    }

                    //データソースの再設定
                    SetDataSource();
                }

                //更新ボタンが押されている場合
                if (this.DgvTasks.Columns[e.ColumnIndex].Name == "btnUpdateTask")
                {
                    //インスタンス化
                    CommonFunc commonFunc = new CommonFunc();

                    //タスク更新画面に遷移
                    commonFunc.HideAndOpen(this, new FrmUpdateTask(this.loginUserID, taskID));
                }
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //タスク名
                string searchTaskName = TxtSearchTaskName.Text;

                //インスタンス化
                Task task = new Task();

                //検索結果(件数)を取得
                long searchTaskCount = task.GetSearchCount(this.loginUserID, searchTaskName);

                //設定
                this.lblSearchCount.Text = searchTaskCount.ToString() + "件";

                //検索結果を表示
                SetSearchDataSource(this.loginUserID, searchTaskName);
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

        private void BtnOutputCSV_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                Task task = new Task();

                //タスクリストを取得
                List<TaskData> taskList = task.GetUserTaskList(this.loginUserID);

                //CSV出力
                if (! task.OutputCSV(taskList, Constant.CSV_OUTPUT_PATH))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.FAILED_OUTPUT_CSV,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;

                }

                //成功メッセージ
                MessageBox.Show(Constant.SUCCESS_OUTPUT_CSV,
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


        /// <summary>
        /// フォーム初期化
        /// </summary>
        /// 2023/03/15
        private void InitForm()
        {
            //データソースの設定
            SetDataSource();
        }


        /// <summary>
        /// フォーム初期化
        /// </summary>
        /// 2023/03/15
        private void SetDataSource()
        {
            //インスタンス化
            Task task = new Task();

            //データソースの設定
            this.DgvTasks.DataSource = task.GetUserTaskList(this.loginUserID);
        }


        /// <summary>
        /// 検索用データソース設定
        /// </summary>
        /// 2023/03/15
        private void SetSearchDataSource(long loginUserID,
                                        string searchTaskName)
        {
            //インスタンス化
            Task task = new Task();

            //検索結果を設定
            this.DgvTasks.DataSource = task.FilterTaskList(loginUserID, searchTaskName);
        }
    }
}
