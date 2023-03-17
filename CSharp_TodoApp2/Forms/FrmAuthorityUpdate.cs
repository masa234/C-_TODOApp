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
    public partial class FrmAuthorityUpdate : Form
    {
        //ログインユーザID
        private readonly long loginUserID;
        public FrmAuthorityUpdate(long loginUserID)
        {
            InitializeComponent();

            //ログインユーザID設定
            this.loginUserID = loginUserID;
        }

        private void FrmAuthorityUpdate_Load(object sender, EventArgs e)
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
                //更新対象ID
                //TODO: ここに書くべきかは議論の余地がある
                long.TryParse(DgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString() ,out long updateUserID);

                //管理者にするボタンが押されている場合
                if (DgvUsers.Columns[e.ColumnIndex].Name == "btnAdminUpdate")
                {
                    //インスタンス化
                    User user = new User();

                    //既に管理者かどうか?
                    if (user.IsAdmin(updateUserID))
                    {
                        //メッセージボックス
                        MessageBox.Show(Constant.USER_IS_ADMIN,
                                        Constant.CONFIRM,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        return;
                    }

                    //権限更新
                    if (! user.UpdateAuthority(updateUserID, (int)EnumValue.UserType.Admin))
                    {
                        //メッセージボックス
                        MessageBox.Show(Constant.FAILED_UPDATE_AUTHORITY,
                                        Constant.CONFIRM,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        return;
                    }

                    //成功メッセージ
                    MessageBox.Show(Constant.SUCCESS_UPDATE_AUTHORITY,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }


                //一般ユーザにするボタンが押されている場合
                if (DgvUsers.Columns[e.ColumnIndex].Name == "btnNormalUpdate")
                {
                    //インスタンス化
                    User user = new User();

                    //既に一般ユーザかどうか?
                    if (!user.IsAdmin(updateUserID))
                    {
                        //メッセージボックス
                        MessageBox.Show(Constant.USER_IS_NORMAL,
                                        Constant.CONFIRM,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        return;
                    }

                    //権限更新
                    if (! user.UpdateAuthority(updateUserID, (int)EnumValue.UserType.Normal))
                    {
                        //メッセージボックス
                        MessageBox.Show(Constant.FAILED_UPDATE_AUTHORITY,
                                        Constant.CONFIRM,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        return;
                    }

                    //成功メッセージ
                    MessageBox.Show(Constant.SUCCESS_UPDATE_AUTHORITY,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
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
        /// 2023/03/13
        private void InitForm()
        {
            //データソースの設定
            SetDataSource();
        }


        /// <summary>
        /// データソースの設定
        /// </summary>
        /// 2023/03/13
        private void SetDataSource()
        {
            //インスタンス化
            User user = new User();

            //データソースの設定
            this.DgvUsers.DataSource = user.GetAllUsers();
        }
    }
}
