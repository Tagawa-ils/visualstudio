using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BL;

namespace WebFormStudy.A010_Book
{
    public partial class A012_ShouhinList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {

            // パラメータの値をプロパティに設定
            A950_CommonBL cb = new A950_CommonBL();
            cb.ISBN = Request.QueryString["ISBN"];
            cb.BookTitle = Request.QueryString["BookTitle"];
            cb.Price = Request.QueryString["Price"];

            // SQLクエリ作成、グリッドビューに設定。
            A952_BookBL sb = new A952_BookBL();
           //ShouhinGridView.DataSource = sb.SetShouhinSelect(cb);
            ShouhinGridView.DataBind();
        }
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            // 商品検索画面に戻る
            Response.Redirect("A011_BookSerch.aspx");
        }
    }
}