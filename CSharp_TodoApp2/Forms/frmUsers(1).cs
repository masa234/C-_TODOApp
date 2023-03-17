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
    public partial class frmUsers : Form
    {
        //ログインユーザID
        private long loginUserID;

        public frmUsers(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }


        private void frmUsers_Load(object sender, EventArgs e)
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

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            long deleteUserID;
            User user;

            try
            {
                //削除ボタンが押されている場合
                if (dgvUsers.Columns[e.ColumnIndex].Name == "btnDeleteUser")
                {
                    //インスタンス化
                    user = new User();

                    //管理者かどうか?
                    if (!user.IsAdmin(this.loginUserID))
                        return;

                    //削除対象ID
                    deleteUserID = long.Parse(dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString());

                    //削除
                    if (! user.DeleteUser(deleteUserID))
                    {
                        //メッセージボックス
                    }

                    //成功メッセージ
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            CommonFunc commonFunc;

            try
            {
                //インスタンス化
                commonFunc = new CommonFunc();

                //メイン画面に遷移
                commonFunc.HideAndOpen(this, new frmMain(this.loginUserID));
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
            User user;

            //インスタンス化
            user = new User();

            //データソースの設定
            this.dgvUsers.DataSource = user.GetAllUsers();
        }
    }
}
