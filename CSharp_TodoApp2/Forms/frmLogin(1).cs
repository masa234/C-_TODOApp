using CSharp_TodoApp2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_TodoApp2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            long loginUserID;
            string userName;
            string password;
            User user;
            CommonFunc commonFunc;

            try
            {
                //ユーザ名
                userName = txtUserName.Text;
                //パスワード
                password = txtPassword.Text;

                //インスタンス化
                commonFunc = new CommonFunc();

                //文字数チェック(ユーザ名)
                if (! commonFunc.IsFitInText(userName, Constant.USERNAME_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.INVALID_USERNAME_LENGTH,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //文字数チェック(パスワード)
                if (! commonFunc.IsFitInText(password, Constant.PASSWORD_MAX_LENGTH))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.INVALID_PASSWORD_LENGTH,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //インスタンス化
                user = new User();

                //ユーザ存在チェック
                if (! user.IsExistsUser(userName, password))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.FAILED_LOGIN,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //ユーザID取得
                loginUserID = user.GetUserID(userName, password);

                //メイン画面に遷移
                commonFunc.HideAndOpen(this, new frmMain(loginUserID));

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
    }
}
