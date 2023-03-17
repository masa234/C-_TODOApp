using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_TodoApp2
{
    public class User
    {
        /// <summary>
        /// ユーザが存在するかどうか?
        /// </summary>
        ///　2023/03/10 
        public bool IsExistsUser(string userName,
                                string password)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("UserName", userName),
                new SqlParameter("Password", password)
            };

            //SQL取得
            string sql = Constant.GET_USER_COUNT_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(件数)を取得
            long userCount = db.ExecuteScalar(sql, paramList);

            //件数が1件以上かどうか?
            if (1 <= userCount)
                return true;

            return false;
        }


        /// <summary>
        /// ユーザID取得
        /// </summary>
        ///　2023/03/10 
        public long GetUserID(string userName,
                              string password)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("UserName", userName),
                new SqlParameter("Password", password)
            };

            //SQL取得
            string sql = Constant.GET_USERID_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果を取得
            using (SqlDataReader reader = db.ExecuteReader(sql, paramList))
            {
                //読み込める間、繰り返す
                while (reader.Read())
                {
                    //long型に変換
                    long.TryParse(reader[0].ToString(), out long result);

                    return result;
                }
            }

            return 0;
        }


        /// <summary>
        /// 管理者かどうか?
        /// </summary>
        ///　2023/03/10 
        public bool IsAdmin(long userID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", userID)
            };

            //SQL取得
            string sql = Constant.GET_ADMIN_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果を取得
            using (SqlDataReader reader = db.ExecuteReader(sql, paramList))
            {
                //読み込める間、繰り返す
                while (reader.Read())
                {
                    //int型に変換
                    int.TryParse(reader[0].ToString(), out int result);

                    //管理者かどうか?
                    if (result == (int)EnumValue.UserType.Admin)
                        return true;
                }
            }

            return false;
        }


        /// <summary>
        /// ユーザ登録
        /// </summary>
        ///　2023/03/10 
        public bool RegisterUser(string userName,
                                    string password)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("UserName", userName),
                new SqlParameter("Password", password),
                new SqlParameter("Admin", EnumValue.UserType.Normal),
                new SqlParameter("LockFlag",EnumValue.IsLock.NotLock)
            };

            //SQL取得
            string sql = Constant.REGISTER_USER_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);

            return true;
        }


        /// <summary>
        /// ユーザ一覧取得
        /// </summary>
        ///　2023/03/10 
        ///　TODO:　関数名、改善の余地あり
        public DataTable GetAllUsers()
        {
            //SQL取得
            string sql = Constant.GET_USERS_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(データ)を取得
            return db.GetDt(sql);
        }


        /// <summary>
        /// ユーザ削除
        /// </summary>
        ///　2023/03/10
        public bool DeleteUser(long deleteUserID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", deleteUserID)
            };

            //SQL取得
            string sql = Constant.DELETE_USER_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);

            return true;
        }


        /// <summary>
        /// ユーザ取得
        /// </summary>
        ///　2023/03/13
        public UserData GetUser(long userID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Id", userID)
            };

            //SQL取得
            string sql = Constant.GET_USER_SQL;

            //インスタンス化
            UserData userData = new UserData();

            //インスタンス化
            DB db = new DB();

            //実行結果(リーダー)を取得
            using (SqlDataReader reader = db.ExecuteReader(sql, paramList))
            {
                //読み込める間、繰り返す
                while (reader.Read())
                {
                    //設定
                    //ユーザ名
                    userData.UserName = reader[0].ToString();
                    //パスワード
                    userData.Password = reader[1].ToString();
                }
            }

            return userData;
        }


        /// <summary>
        /// ユーザ更新
        /// </summary>
        ///　2023/03/13
        public bool UpdateUser(string userName,
                                string password,
                                long updateUserID)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("UserName", userName),
                new SqlParameter("Password", password),
                new SqlParameter("Id", updateUserID)
            };

            //SQL取得
            string sql = Constant.UPDATE_USER_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);

            return true;
        }


        /// <summary>
        /// 権限更新
        /// </summary>
        ///　2023/03/14
        public bool UpdateAuthority(long updateUserID,
                                    int updateUserType)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("Admin", updateUserType),
                new SqlParameter("Id", updateUserID)
            };

            //SQL取得
            string sql = Constant.UPDATE_ADMIN_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);

            return true;
        }


        /// <summary>
        /// ユーザ名が存在するかどうか?
        /// </summary>
        ///　2023/03/14
        public bool IsExistsUserName(string userName)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("UserName", userName)
            };

            //SQL取得
            string sql = Constant.GET_USERNAME_COUNT_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(件数)を取得
            long userCount = db.ExecuteScalar(sql, paramList);

            //1件を超えているかどうか?
            if (1 <= userCount)
                return true;

            return true;
        }


        /// <summary>
        /// アカウントロック
        /// </summary>
        ///　2023/03/14
        public void UpdateLock(string userName,
                                int IsLock)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("UserName", userName),
                new SqlParameter("LockFlag", IsLock)
            };

            //SQL取得
            string sql = Constant.UPDATE_LOCK_SQL;

            //インスタンス化
            DB db = new DB();

            //SQL実行
            db.ExecuteNonQuery(sql, paramList);
        }


        /// <summary>
        /// ロックされているかどうか?
        /// </summary>
        ///　2023/03/14
        public bool IsLockedUserName(string userName)
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("UserName", userName)
            };

            //SQL取得
            string sql = Constant.GET_LOCKFLAG_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(リーダー)を取得
            using (SqlDataReader reader = db.ExecuteReader(sql, paramList))
            {
                //読み込める間、繰り返す
                while (reader.Read())
                {
                    //int型に変換
                    int.TryParse(reader[0].ToString(), out int result);
                    //変換結果がロックかどうか?
                    if (result == (int)EnumValue.IsLock.Locked)
                        return true;
                }
            }

            return false;
        }


        /// <summary>
        /// ロックされているかどうか?
        /// </summary>
        ///　2023/03/14
        public DataTable GetLockedUsers()
        {
            //パラム設定
            List<SqlParameter> paramList = new List<SqlParameter>() {
                new SqlParameter("LockFlag", EnumValue.IsLock.Locked)
            };

            //SQL取得
            string sql = Constant.GET_LOCKED_USERS_SQL;

            //インスタンス化
            DB db = new DB();

            //実行結果(データ)を返却
            return db.GetDt(sql, paramList);
        }
    }
}
