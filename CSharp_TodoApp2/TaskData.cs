using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_TodoApp2
{
    public class TaskData
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// タスク名
        /// </summary>
        public string TaskName { get; set; }


        /// <summary>
        /// 有効期限
        /// </summary>
        public DateTime ExpiredDate { get; set; }


        /// <summary>
        /// 優先度
        /// </summary>
        public string Priority { get; set; }


        /// <summary>
        /// 詳細
        /// </summary>
        public string Detail { get; set; }


        /// <summary>
        /// コメント
        /// </summary>
        public string Comment { get; set; }


        /// <summary>
        /// ユーザID
        /// </summary>
        public int UserID { get; set; }
    }
}
