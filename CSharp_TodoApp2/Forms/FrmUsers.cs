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
    public partial class FrmUsers : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmUsers(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }


        private void FrmUsers_Load(object sender, EventArgs e)
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

        private void DgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //削除ボタンが押されている場合
                if (dgvUsers.Columns[e.ColumnIndex].Name == "btnDeleteUser")
                {
                    //インスタンス化
                    User user = new User();

                    //管理者かどうか?
                    if (!user.IsAdmin(this.loginUserID))
                        return;

                    //削除対象ID
                    long.TryParse(dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString(), out long deleteUserID);

                    //削除
                    if (!user.DeleteUser(deleteUserID))
                    {
                        //メッセージボックス
                        MessageBox.Show(Constant.FAILED_DELETE_USER,
                                        Constant.CONFIRM,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        return;
                    }

                    //成功メッセージ
                    MessageBox.Show(Constant.SUCCESS_DELETE_USER,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    //データソースの再設定
                    SetDataSource();
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
        /// 2023/03/10
        private void InitForm()
        {
            //データソースの設定
            SetDataSource();
        }


        /// <summary>
        /// データソースの設定
        /// </summary>
        /// 2023/03/10
        private void SetDataSource()
        {
            //インスタンス化
            User user = new User();

            //データソースの設定
            this.dgvUsers.DataSource = user.GetAllUsers();
        }
    }
}
