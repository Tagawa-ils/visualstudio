using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebFormBL
{
    public class A952_BookBL
    {
        public DataSet SetShouhinSelect(A950_CommonBL cb)
        {

            // クエリ作成
            String queryString = "";
            queryString = "SELECT ISBN, BookTitle, Price FROM BookList ";

            String queryWhereString = "";
            if (cb.ISBN != 0)
            {
                // ISBN条件設定
                queryWhereString = "WHERE ISBN LIKE '%" + cb.ISBN + "%'";
            }

            if (cb.BookTitle != "")
            {
                // 書籍名条件設定
                if (queryWhereString == "")
                {
                    queryWhereString = queryWhereString + "AND BookTitle LIKE '%" + cb.BookTitle + "%'";
                }
                else
                {
                    queryWhereString = queryWhereString + " OR BookTitle LIKE '%" + cb.BookTitle + "%'";
                }
            }
            if (cb.Price != 0)
            {
                // 商品詳細条件設定
                if (queryWhereString == "")
                {
                    queryWhereString = queryWhereString + "AND Price LIKE '%" + cb.Price + "%'";
                }
                else
                {
                    queryWhereString = queryWhereString + " OR Price LIKE '%" + cb.Price + "%'";
                }
            }

            // 商品IDで昇順
            String queryOrderByString = " ORDER BY ISBN";
            queryString = queryString + queryWhereString + queryOrderByString;

            // 接続文字列取得
            String connectionString = ConfigurationManager.ConnectionStrings["HosyuStudy"].ConnectionString;

            // 取得結果を格納するデータセットを生成
            DataSet ds = new DataSet();

            //接続情報を使ってコネクションを生成
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //SQL文とコネクションを設定
                using (SqlCommand cmd = new SqlCommand(queryString, conn))
                {
                    // パラメータ設定
                    cmd.Parameters.AddWithValue("@ISBN", "%" + cb.ISBN + "%");
                    cmd.Parameters.AddWithValue("@BookTitle", "%" + cb.BookTitle + "%");
                    cmd.Parameters.AddWithValue("@Price", "%" + cb.Price + "%");

                    // データアダプターにsqlコマンドを設定
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    // クエリ実行、データセットに設定
                    adapter.Fill(ds);
                }
            }

            return ds;

        }

        // データ登録
        public void ShouhinInsert(A950_CommonBL cb)
        {

            String connectionString = ConfigurationManager.ConnectionStrings["BookList"].ConnectionString;

            DateTime dt = DateTime.Now;
            String DTime = dt.ToString("yyyy/MM/dd HH:mm:ss.fff");

            var insertQuery = @"INSERT INTO BookList (ISBN, BookTitle, Price, DateTime) VALUES ( @ISBN, @BookTitle, @Price, @DateTime)";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(insertQuery, connection))
            {
                connection.Open();

                // パラメーターの追加
                command.Parameters.AddWithValue("@ISBN", cb.ISBN);
                command.Parameters.AddWithValue("@BookTitle", cb.BookTitle);
                command.Parameters.AddWithValue("@Price", cb.Price);
                command.Parameters.AddWithValue("@DateTime", DTime);
                command.ExecuteNonQuery();


            }
        }

    }
}