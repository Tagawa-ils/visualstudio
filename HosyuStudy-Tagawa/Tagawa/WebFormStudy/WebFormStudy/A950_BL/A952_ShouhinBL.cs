using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;

namespace WebFormStudy.A950_BL
{
    public class A952_ShouhinBL
    {
        public void SetShouhinSelect(A950_CommonBL cb, SqlDataSource sds)
        {

            // クエリ作成
            String queryString = String.Empty;
            queryString = "SELECT ISBN, BookTitle, Price FROM BookList ";

            String queryWhereString = String.Empty;
            if (cb.ISBN != String.Empty)
            {
                // ISBN条件設定
                queryWhereString = "WHERE ISBN LIKE '%" + cb.ISBN + "%'";
            }
            if (cb.BookTitle != String.Empty)
            {
                // 書籍名条件設定
                if (queryWhereString == String.Empty) 
                {
                    queryWhereString = queryWhereString + "AND BookTitle LIKE '%" + cb.BookTitle + "%'";
                }
                else 
                {
                    queryWhereString = queryWhereString + " OR BookTitle LIKE '%" + cb.BookTitle + "%'";
                }
            }
            if (cb.Price != String.Empty)
            {
                // 商品詳細条件設定
                if (queryWhereString == String.Empty)
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

            sds.SelectCommand = queryString + queryWhereString + queryOrderByString;

        }
    }
}