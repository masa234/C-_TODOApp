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
    public partial class frmMain : Form
    {
        //ログインユーザID
        private long loginUserID;

        public frmMain(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID =loginUserID;
        }

        private void frmMain_Load(object sender, EventArgs e)
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CommonFunc commonFunc;

            try
            {
                //インスタンス化
                commonFunc = new CommonFunc();

                //ログイン画面に遷移
                commonFunc.HideAndOpen(this, new frmLogin());
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


        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            CommonFunc commonFunc;

            try
            {
                //インスタンス化
                commonFunc = new CommonFunc();

                //登録画面に遷移
                commonFunc.HideAndOpen(this, new frmRegisterUser(this.loginUserID));
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


        private void btnUsers_Click(object sender, EventArgs e)
        {
            CommonFunc commonFunc;

            try
            {
                //インスタンス化
                commonFunc = new CommonFunc();

                //登録画面に遷移
                commonFunc.HideAndOpen(this, new frmUsers(this.loginUserID));
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
            //ボタンの表示非表示を設定
            SetBtnVisible();
        }


        /// <summary>
        /// ボタンの表示、非表示を設定
        /// </summary>
        /// 2023/03/10
        private void SetBtnVisible()
        {
            User user;

            //インスタンス化
            user = new User();

            //管理者かどうか?
            if (! user.IsAdmin(this.loginUserID))
            {
                //ボタンを非表示にする
                //登録ボタン
                this.btnRegisterUser.Visible = false;
                //ユーザ一覧ボタン
                this.btnUsers.Visible = false;
            }
        }
    }
}
