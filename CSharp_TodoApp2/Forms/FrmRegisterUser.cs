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
    public partial class FrmRegisterUser : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmRegisterUser(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }

        private void BtnRegisterUser_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                User user = new User();

                //管理者かどうか？
                if (!user.IsAdmin(this.loginUserID))
                    return;

                //ユーザ名
                string userName = txtUserName.Text;
                //パスワード
                string password = txtPassword.Text;

                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

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

                //登録
                if (! user.RegisterUser(userName, password))
                {
                    //メッセージボックス
                    MessageBox.Show(Constant.FAILED_REGISTER_USER,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                //成功メッセージ
                MessageBox.Show(Constant.SUCCESS_REGISTER_USER,
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
    }
}
