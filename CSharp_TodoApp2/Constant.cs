using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_TodoApp2
{
    public class Constant
    {
        //バリデーションメッセージ
        public const string INVALID_USERNAME_LENGTH = "ユーザ名は1～255文字以内で入力してください。";
        public const string INVALID_PASSWORD_LENGTH = "パスワードは1～255文字以内で入力してください。";
        public const string INVALID_TASKNAME_LENGTH = "タスク名は1～255文字以内で入力してください。";
        public const string INVALID_DETAIL_LENGTH = "詳細は1～255文字以内で入力してください。";
        public const string INVALID_COMMENT_LENGTH = "コメントは1～255文字以内で入力してください。";
        public const string EXPIRED_DATE_MUST_INPUT = "有効期限を入力してください。";
        public const string PRIORITY_MUST_INPUT = "優先度を入力してください。";
        public const string EXPIRED_DATE_MUST_FUTURE = "有効期限は未来日でなければいけません。";
        public const string PRIORITY_MUST_IN_CMB = "優先度はコンボボックスから選択してください。";
        //失敗メッセージ
        public const string FAILED_LOGIN = "ログインに失敗しました。";
        public const string FAILED_REGISTER_USER = "ユーザ登録に失敗しました。";
        public const string FAILED_DELETE_USER = "ユーザ削除に失敗しました。";
        public const string FAILED_UPDATE_USER = "ユーザ更新に失敗しました。";
        public const string FAILED_UPDATE_AUTHORITY = "権限更新に失敗しました。";
        public const string FAILED_INSERT_TASK = "タスク登録に失敗しました。";
        public const string FAILED_DELETE_TASK = "タスク削除に失敗しました。";
        public const string FAILED_UPDATE_TASK = "タスク更新に失敗しました。";
        public const string FAILED_OUTPUT_CSV = "CSV出力に失敗しました。";
        //成功メッセージ
        public const string SUCCESS_REGISTER_USER = "ユーザ登録に成功しました。";
        public const string SUCCESS_DELETE_USER = "ユーザ削除に成功しました。";
        public const string SUCCESS_UPDATE_USER = "ユーザ更新に成功しました。";
        public const string SUCCESS_UPDATE_AUTHORITY = "権限更新に成功しました。";
        public const string SUCCESS_RELEASE_LOCK = "ロック解除に成功しました。";
        public const string SUCCESS_INSERT_TASK = "タスク登録に成功しました。";
        public const string SUCCESS_UPDATE_TASK = "タスク更新に成功しました。";
        public const string SUCCESS_OUTPUT_CSV = "CSV出力に成功しました。";
        //接続文字列
        public const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=testDb3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //メッセージタイトル
        public const string CONFIRM = "確認";
        //最大文字数
        public const int USERNAME_MAX_LENGTH = 255;
        public const int PASSWORD_MAX_LENGTH = 255;
        public const int TASKNAME_MAX_LENGTH = 255;
        public const int DETAIL_MAX_LENGTH = 255;
        public const int COMMENT_MAX_LENGTH = 255;
        //その他
        public const string USER_IS_ADMIN = "既に管理者権限を保有しています。";
        public const string USER_IS_NORMAL = "既に一般ユーザです。";
        public const string USER_IS_LOCK = "アカウントがロックされました。管理者に問い合わせてください。";
        public const string USER_IS_LOCKED = "アカウントがロックされています。管理者に問い合わせてください。";
        public const string CSV_OUTPUT_PATH = @"C:\Users\PC01\Desktop";
        public const int LOCK_COUNT = 3;
        //SQL
        public const string GET_USER_COUNT_SQL = "SELECT " +
                                               "    COUNT(*)" +
                                               "  FROM" +
                                               "    Users " +
                                               "  WHERE " +
                                               "    UserName = @UserName " +
                                               "  AND" +
                                               "    Password = @Password";
        public const string GET_USERNAME_COUNT_SQL = "SELECT " +
                                                   "    COUNT(*)" +
                                                   "  FROM" +
                                                   "    Users " +
                                                   "  WHERE " +
                                                   "    UserName = @UserName ";
        public const string GET_USERID_SQL = "SELECT " +
                                            "  Id " +
                                            "FROM " +
                                            "  Users " +
                                            "WHERE " +
                                            "  UserName = @UserName " +
                                            "AND" +
                                            "  Password = @Password";
        public const string GET_ADMIN_SQL = "SELECT " +
                                            "  Admin " +
                                            "FROM " +
                                            "  Users " +
                                            "WHERE " +
                                            "  Id = @Id ";
        public const string GET_LOCKFLAG_SQL = "SELECT " +
                                            "     LockFlag " +
                                            "   FROM " +
                                            "     Users " +
                                            "   WHERE " +
                                            "     UserName = @UserName ";
        public const string GET_USERS_SQL = "SELECT " +
                                            "  Id, " +
                                            "  UserName, " +
                                            "  Password " +
                                            "FROM " +
                                            "  Users " +
                                            "ORDER BY " +
                                            "  Id ";
        public const string GET_USER_SQL = "SELECT " +
                                            "  UserName, " +
                                            "  Password " +
                                            "FROM " +
                                            "  Users " +
                                            "WHERE " +
                                            "  Id = @Id ";
        public const string GET_LOCKED_USERS_SQL = " SELECT " +
                                                    "  Id, " +
                                                    "  UserName, " +
                                                    "  Password " +
                                                    "FROM " +
                                                    "  Users " +
                                                    "WHERE " +
                                                    "  LockFlag = @LockFlag " +
                                                    "ORDER BY " +
                                                    "  Id ";
        public const string REGISTER_USER_SQL = "INSERT " +
                                                "  INTO " +
                                                "Users " +
                                                "  (UserName, " +
                                                "   Password, " +
                                                "   Admin, " +
                                                "   LockFlag) "+
                                                " VALUES "+
                                                "   (@UserName, "+
                                                "    @Password, "+
                                                "    @Admin, "+
                                                "    @LockFlag) ";
        public const string DELETE_USER_SQL = "DELETE " +
                                            "  FROM " +
                                            "    Users " +
                                            "  WHERE " +
                                            "    Id = @Id ";
        public const string UPDATE_USER_SQL = "UPDATE " +
                                            "    Users " +
                                            "  SET " +
                                            "    UserName = @UserName, " +
                                            "    Password = @Password " +
                                            "  WHERE "+
                                            "    Id = @Id ";
        public const string UPDATE_ADMIN_SQL = "UPDATE " +
                                            "    Users " +
                                            "  SET " +
                                            "    Admin = @Admin " +
                                            "  WHERE "+
                                            "    Id = @Id ";
        public const string UPDATE_LOCK_SQL = "UPDATE " +
                                            "    Users " +
                                            "  SET " +
                                            "    LockFlag = @LockFlag " +
                                            "  WHERE "+
                                            "    UserName = @UserName ";
        public const string INSERT_TASK_SQL = "INSERT " +
                                            "    INTO " +
                                            "  Tasks " +
                                            "    (TaskName, " +
                                            "  ExpiredDate, "+
                                            "    Priority, " +
                                            "    Detail, " +
                                            "    Comment, " +
                                            "    UserId) " +
                                            "  VALUES " +
                                            "    (@TaskName, " +
                                            "    @ExpiredDate, " +
                                            "    @Priority, " +
                                            "    @Detail, " +
                                            "    @Comment, " +
                                            "    @UserId) ";
        public const string GET_USER_TASKS_SQL = "SELECT " +
                                                "   Id, " +
                                                "   TaskName, " +
                                                "   ExpiredDate, " +
                                                "   Priority, " +
                                                "   Detail, " +
                                                "   Comment, " +
                                                "   UserId " +
                                                " FROM " +
                                                "   Tasks " +
                                                " WHERE " +
                                                "   UserId = @UserId ";
        public const string GET_TASK_SQL = " SELECT " +
                                            "  Id, " +
                                            "  TaskName, " +
                                            "  ExpiredDate, " +
                                            "  Priority, " +
                                            "  Detail, " +
                                            "  Comment, " +
                                            "  UserId " +
                                            "FROM " +
                                            "  Tasks " +
                                            "WHERE " +
                                            "  Id = @Id ";
        public const string DELETE_TASK_SQL = " DELETE " +
                                            "   FROM "  +
                                            "     Tasks " +
                                            "   WHERE " +
                                            "     Id = @Id ";
        public const string UPDATE_TASK_SQL = "UPDATE " +
                                            "    Tasks " +
                                            "  SET " +
                                            "    TaskName = @TaskName, " +
                                            "    ExpiredDate = @ExpiredDate, " +
                                            "    Priority = @Priority, " +
                                            "    Detail = @Detail, " +
                                            "    Comment = @Comment, " +
                                            "    UserId = @UserId " +
                                            "  WHERE " +
                                            "    Id = @Id ";
        public const string GET_SEARCH_COUNT_SQL = "SELECT " +
                                                "     COUNT(*) " +
                                                "   FROM " +
                                                "     Tasks "+
                                                "   WHERE " +
                                                "     UserId = @UserId " +
                                                "   AND " +
                                                "     TaskName Like @TaskName ";
        public const string GET_SEARCH_TASKS_SQL = " SELECT " +
                                                    "  Id, " +
                                                    "  TaskName, " +
                                                    "  ExpiredDate, " +
                                                    "  Priority, " +
                                                    "  Detail, " +
                                                    "  Comment, " +
                                                    "  UserId " +
                                                    "FROM " +
                                                    "  Tasks " +
                                                    "WHERE " +
                                                    "  UserId = @UserId " +
                                                    "AND " +
                                                    "  TaskName Like @TaskName ";
    }
}
