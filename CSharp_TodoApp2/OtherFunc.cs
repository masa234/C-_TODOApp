using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_TodoApp2
{
    public class OtherFunc
    {
        /// <summary>
        /// 優先度のリストを取得
        /// </summary>
        ///　2023/03/14
        public List<string> GetPriorityList()
        {
            return new List<string>()
            {
                "高", "中", "低"
            };
        }


        /// <summary>
        /// 優先度をint型に変換する
        /// </summary>
        ///　2023/03/15
        public int PriorityToInt(string strPriority)
        {
            //値によって分岐させる
            switch (strPriority)
            {
                case "高":
                    return (int)EnumValue.Priority.High;
                case "中":
                    return (int)EnumValue.Priority.Middle;
                case "低":
                    return (int)EnumValue.Priority.Low;
            }

            return 0;
        }


        /// <summary>
        /// 優先度を文字列にする
        /// </summary>
        /// 2023/03/15
        public string PriorityToString(int intPrioriry)
        {
            //値によって分岐させる
            switch (intPrioriry)
            {
                case (int)EnumValue.Priority.High:
                    return "高";
                case (int)EnumValue.Priority.Middle:
                    return "中";
                case (int)EnumValue.Priority.Low:
                    return "低";
            }

            return string.Empty;
        }
    }
}
