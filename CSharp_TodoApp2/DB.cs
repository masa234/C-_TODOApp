using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_TodoApp2
{
    public class DB : IDisposable
    {
        //コネクション
        private SqlConnection Con;
        //トランザクション
        private SqlTransaction Tran;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        ///　2023/03/09 
        public DB()
        {
            //コネクションを開く
            OpenCon(Constant.CONNECTION_STRING);

            //トランザクション作成
            BeginTran();
        }


        /// <summary>
        /// コネクションを開く
        /// </summary>
        ///　2023/03/09 
        private void OpenCon(string ConStr)
        {
            //コネクションが存在しない場合
            if (this.Con == null)
            {
                //コネクションを設定
                this.Con = new SqlConnection(ConStr);

                //コネクションを開く
                this.Con.Open();
            }
        }


        /// <summary>
        /// トランザクション作成
        /// </summary>
        ///　2023/03/09 
        private void BeginTran()
        {
            //トランザクションが存在しない場合
            if (this.Tran == null)
            {
                //トランザクションを作成
                this.Tran = this.Con.BeginTransaction();
            }
        }


        /// <summary>
        /// ロールバック
        /// </summary>
        ///　2023/03/09 
        private void RollBack()
        {
            //トランザクションが存在する場合
            if (this.Tran != null)
            {
                //ロールバック
                this.Tran.Rollback();
            }
        }


        /// <summary>
        /// コミット
        /// </summary>
        ///　2023/03/09 
        private void Commit()
        {
            //トランザクションが存在する場合
            if (this.Tran != null)
            {
                //コミット
                this.Tran.Commit();
            }
        }


        /// <summary>
        /// コマンド取得
        /// </summary>
        ///　2023/03/09 
        private SqlCommand GetCmd(string sql)
        {
            //コマンド作成
            return new SqlCommand(sql, this.Con, this.Tran);
        }


        /// <summary>
        /// INSERT, UPDATE, DELETE用
        /// </summary>
        /// 2023/03/09 
        public void ExecuteNonQuery(string sql,
                                    List<SqlParameter> paramList = null)
        {
            try
            {
                //コマンド作成
                using (SqlCommand cmd = this.GetCmd(sql))
                {
                    //パラム追加
                    if (paramList != null)
                    {
                        cmd.Parameters.AddRange(paramList.ToArray<SqlParameter>());
                    }

                    //SQL実行
                    cmd.ExecuteNonQuery();

                    //コミット
                    this.Commit();
                }
            }
            catch
            {
                //ロールバック
                this.RollBack();

                //例外を投げる
                throw;
            }
        }


        /// <summary>
        /// INSERT, UPDATE, DELETE用
        /// </summary>
        /// 2023/03/09 
        public SqlDataReader ExecuteReader(string sql,
                                    List<SqlParameter> paramList = null)
        {
            //コマンド作成
            using (SqlCommand cmd = this.GetCmd(sql))
            {
                //パラム追加
                if (paramList != null)
                {
                    cmd.Parameters.AddRange(paramList.ToArray<SqlParameter>());
                }

                //実行結果を取得
                return cmd.ExecuteReader();
            }
        }


        /// <summary>
        /// SELECT用
        /// </summary>
        /// 2023/03/09 
        public DataTable GetDt(string sql,
                                    List<SqlParameter> paramList = null)
        {
            DataTable dt;

            //コマンド作成
            using (SqlCommand cmd = this.GetCmd(sql))
            {
                //パラム設定
                if (paramList != null)
                {
                    cmd.Parameters.AddRange(paramList.ToArray<SqlParameter>());
                }

                //アダプター作成
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    //データテーブル作成
                    dt = new DataTable();

                    adapter.Fill(dt);

                    return dt;
                }
            }
        }


        /// <summary>
        /// SELECT COUNT用
        /// </summary>
        /// 2023/03/09 
        public long ExecuteScalar(string sql,
                                    List<SqlParameter> paramList = null)
        {
            //コマンド作成
            using (SqlCommand cmd = this.GetCmd(sql))
            {
                //パラム設定
                if (paramList != null)
                {
                    cmd.Parameters.AddRange(paramList.ToArray<SqlParameter>());
                }

                //実行結果(件数)を取得
                long.TryParse(cmd.ExecuteScalar().ToString(), out long result);

                return result;
            }
        }

        void IDisposable.Dispose()
        {
            //コネクションが存在する場合
            if (this.Con != null)
            {
                //コネクションを閉じる
                this.Con.Close();

                //破棄
                this.Con = null;
            }

            //トランザクションが存在する場合
            if (this.Tran != null)
            {
                //ロールバック
                this.Tran.Rollback();

                //破棄
                this.Tran = null;
            }
        }
    }
}

