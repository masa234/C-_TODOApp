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
    public partial class FrmMain : Form
    {
        //ログインユーザID
        private readonly long loginUserID;

        public FrmMain(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID =loginUserID;
        }

        private void FrmMain_Load(object sender, EventArgs e)
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

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //ログイン画面に遷移
                commonFunc.HideAndOpen(this, new FrmLogin());
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


        private void BtnRegisterUser_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //登録画面に遷移
                commonFunc.HideAndOpen(this, new FrmRegisterUser(this.loginUserID));
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


        private void BtnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //登録画面に遷移
                commonFunc.HideAndOpen(this, new FrmUsers(this.loginUserID));
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

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //ユーザ更新画面に遷移
                commonFunc.HideAndOpen(this, new FrmUpdateUser(this.loginUserID));
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

        private void BtnAuthorityUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //権限更新画面に遷移
                commonFunc.HideAndOpen(this, new FrmAuthorityUpdate(this.loginUserID));
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


        private void BtnReleaseLock_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //アカウントロック解除画面に遷移
                commonFunc.HideAndOpen(this, new FrmReleaseLock(this.loginUserID));
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


        private void BtnInsertTask_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //タスク登録画面に遷移
                commonFunc.HideAndOpen(this, new FrmInsertTask(this.loginUserID));
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


        private void BtnTasks_Click(object sender, EventArgs e)
        {
            try
            {
                //インスタンス化
                CommonFunc commonFunc = new CommonFunc();

                //タスク一覧画面に遷移
                commonFunc.HideAndOpen(this, new FrmTasks(this.loginUserID));
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
            //インスタンス化
            User user = new User();

            //管理者かどうか?
            if (! user.IsAdmin(this.loginUserID))
            {
                //ボタンを非表示にする
                //登録ボタン
                this.BtnRegisterUser.Visible = false;
                //ユーザ一覧ボタン
                this.BtnUsers.Visible = false;
                //権限更新ボタン
                this.BtnAuthorityUpdate.Visible = false;
                //アカウントロック解除ボタン
                this.BtnReleaseLock.Visible = false;
            }
        }
    }
}
