using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.IO;

namespace CSharp_TodoApp2
{
    public class Task
    {
        /// <summary>
        /// タスク登録
        /// </summary>
        /// 2023/03/15 
        public bool InsertTask(string taskName,
                               DateTime expiredDate,
                               string strPriority,
                               string detail,
                               string comment,
                               long createUserId)
        {
            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //優先度をint型に変換する
            int intPriority = otherFunc.PriorityToInt(strPriority);

            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("TaskName", taskName),
                new SqlParameter("ExpiredDate", expiredDate),
                new SqlParameter("Priority", intPriority),
                new SqlParameter("Detail", detail),
                new SqlParameter("Comment", comment),
                new SqlParameter("UserId", createUserId)
            };

            //SQL取得
            string sql = Constant.INSERT_TASK_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);

            return true;
        }


        /// <summary>
        /// ユーザのタスク一覧取得
        /// </summary>
        /// 2023/03/15 
        public List<TaskData> GetUserTaskList(long userID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("UserId", userID)
            };

            //SQL取得
            string sql = Constant.GET_USER_TASKS_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(データ)を取得
            //TODO : 変数宣言が必要ない可能性あり
            using (DataTable dt = db.GetDt(sql, paramList))
            {
                List<TaskData> taskList = DtToTaskList(dt);

                return taskList;
            }
        }


        /// <summary>
        /// データテーブルをタスクリストに変換する
        /// </summary>
        /// 2023/03/15 
        public List<TaskData> DtToTaskList(DataTable dt)
        {
            //リスト作成
            List<TaskData> taskList = new List<TaskData>();

            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //データテーブルの行数分だけ繰り返す
            foreach (DataRow row in dt.Rows)
            {
                //インスタンス化
                TaskData taskData = new TaskData();

                //設定
                //ID
                int.TryParse(row["Id"].ToString(), out int id);
                taskData.Id = id;
                //タスク名
                taskData.TaskName = row["TaskName"].ToString();
                //有効期限
                DateTime.TryParse(row["ExpiredDate"].ToString(), out DateTime expiredDate);
                taskData.ExpiredDate =expiredDate;
                //優先度
                int.TryParse(row["Priority"].ToString(), out int priority);
                taskData.Priority = otherFunc.PriorityToString(priority);
                //詳細
                taskData.Detail = row["Detail"].ToString();
                //コメント
                taskData.Comment = row["Comment"].ToString();
                //ユーザID
                int.TryParse(row["UserId"].ToString(), out int userID);
                taskData.UserID = userID;

                //リストに追加
                taskList.Add(taskData);
            }

            return taskList;
        }


        /// <summary>
        /// タスク削除
        /// </summary>
        /// 2023/03/15 
        public bool DeleteTask(long deleteTaskID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", deleteTaskID)
            };

            //SQL取得
            string sql = Constant.DELETE_TASK_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);

            return true;
        }


        /// <summary>
        /// タスク取得
        /// </summary>
        /// 2023/03/16 
        public TaskData GetTask(long taskID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", taskID)
            };

            //SQL取得
            string sql = Constant.GET_TASK_SQL;

            //インスタンス化
            TaskData taskData = new TaskData();

            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //インスタンス化
            DB db = new DB();

            //実行結果(リーダー)を取得
            using (SqlDataReader reader = db.ExecuteReader(sql, paramList))
            {
                //読み込める間、繰り返す
                while (reader.Read())
                {
                    //設定
                    //ID
                    int.TryParse(reader[0].ToString(), out int id);
                    taskData.Id = id;
                    //タスク名
                    taskData.TaskName = reader[1].ToString();
                    //有効期限
                    DateTime.TryParse(reader[2].ToString(), out DateTime expiredDate);
                    taskData.ExpiredDate = expiredDate;
                    //優先度
                    int.TryParse(reader[3].ToString(), out int priority);
                    taskData.Priority =otherFunc.PriorityToString(priority);
                    //詳細
                    taskData.Detail = reader[4].ToString();
                    //コメント
                    taskData.Comment = reader[5].ToString();
                    //ユーザID
                    int.TryParse(reader[6].ToString(), out int userID);
                    taskData.UserID = userID;

                    return taskData;
                }
            }

            return taskData;
        }


        /// <summary>
        /// タスク更新
        /// </summary>
        /// 2023/03/16 
        public bool UpdateTask(string taskName,
                               DateTime expiredDate,
                               string strPriority,
                               string detail,
                               string comment,
                               long updateUserID,
                               long updateTaskID)
        {
            //インスタンス化
            OtherFunc otherFunc = new OtherFunc();

            //優先度をint型にする
            int intPriority = otherFunc.PriorityToInt(strPriority);

            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("TaskName", taskName),
                new SqlParameter("ExpiredDate", expiredDate),
                new SqlParameter("Priority", intPriority),
                new SqlParameter("Detail", detail),
                new SqlParameter("Comment", comment),
                new SqlParameter("UserId", updateUserID),
                new SqlParameter("Id", updateTaskID)
            };

            //SQL取得
            string sql = Constant.UPDATE_TASK_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);

            return true;
        }


        /// <summary>
        /// 検索結果(件数)を取得
        /// </summary>
        /// 2023/03/16 
        public long GetSearchCount(long loginUserID,
                                    string searchTaskName)
        {

            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("UserId", loginUserID),
                new SqlParameter("TaskName", searchTaskName)
            };

            //SQL取得
            string sql = Constant.GET_SEARCH_COUNT_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(件数)を取得
            return db.ExecuteScalar(sql, paramList);
        }


        /// <summary>
        /// 検索結果を取得
        /// </summary>
        /// 2023/03/16 
        public List<TaskData> FilterTaskList(long loginUserID,
                                    string searchTaskName)
        {

            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("UserId", loginUserID),
                new SqlParameter("TaskName", searchTaskName)
            };

            //SQL取得
            string sql = Constant.GET_SEARCH_TASKS_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(データ)を取得
            using (DataTable dt = db.GetDt(sql,paramList))
            {
                //タスクリストに変換
                List<TaskData> taskList = DtToTaskList(dt);

                return taskList;
            }
        }


        /// <summary>
        /// CSV出力
        /// </summary>
        /// 2023/03/16 
        public bool OutputCSV(List<TaskData> taskList,
                             string csvOutputPath)
        {
            //文字列のリストに変換
            List<string> stringTaskList = TaskListToStringList(taskList);

            //区切り文字で区切る
            string.Join(",", stringTaskList);

            //出力
            File.WriteAllLines(csvOutputPath, stringTaskList);

            return true;
        }


        /// <summary>
        /// タスクリストを文字列のリストに変換
        /// </summary>
        /// 2023/03/16 
        public List<string> TaskListToStringList(List<TaskData> taskList)
        {
            //リスト作成
            List<string> retList = new List<string>();

            //リストの要素数だけ繰り返す
            foreach (TaskData task in taskList)
            {
                //リストに追加
                retList.Add(task.TaskName);
            }

            return retList;
        }
    }
}
