using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_TodoApp2
{
    public class CommonFunc
    {
        /// <summary>
        /// 文字列がおさまっているかどうか?
        /// </summary>
        ///　2023/03/09 
        public bool IsFitInText(string str,
                                long maxLength)
        {
            //空かどうか?
            if (String.IsNullOrEmpty(str))
                return false;

            //制限文字列を超えているか?
            if (maxLength < str.Length)
                return false;

            return true;
        }


        /// <summary>
        /// 画面遷移
        /// </summary>
        ///　2023/03/10 
        public void HideAndOpen(Form openedForm,
                                Form openForm)
        {
            //開いている画面を非表示にする
            openedForm.Hide();

            //画面を開く
            openForm.Show();
        }


        /// <summary>
        /// コンボボックス設定
        /// </summary>
        ///　2023/03/14
        public void SetCmb(ComboBox cmb,
                            List<string> cmbTxtList)
        {
            //リストの要素数だけ繰り返す
            foreach(string cmbTxt in cmbTxtList)
            {
                //コンボボックスに追加
                cmb.Items.Add(cmbTxt);
            }
        }


        /// <summary>
        /// 入力されているかどうか?
        /// </summary>
        ///　2023/03/14
        public bool IsInputed(string str)
        {
            //空かどうか?
            if (String.IsNullOrEmpty(str))
                return false;

            return true;
        }


        /// <summary>
        /// 未来日かどうか?
        /// </summary>
        ///　2023/03/14
        public bool IsFuture(DateTime date)
        {
            //現在日付より前かどうか?
            if (date <= DateTime.Now)
                return false;

            return true;
        }


        /// <summary>
        /// コンボボックスの選択肢内かどうか?
        /// </summary>
        ///　2023/03/15
        public bool IsTextInCmb(ComboBox cmb,
                                string str)
        {
            //リストを作成
            List<string> cmbTxtList = new List<string>();

            //コンボボックスの要素数だけ繰り返す
            foreach (string cmbTxt in cmb.Items)
            {
                //リストに追加
                cmbTxtList.Add(cmbTxt);
            }

            //リスト内に存在するかどうか?
            if (!cmbTxtList.Contains(str))
                return false;

            return true;
        }
    }
}
