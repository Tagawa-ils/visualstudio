using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace WebFormStudy.A002_Addition
{
    public partial class A002_Addition : System.Web.UI.Page
    {
         protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
         // 入力値をプロパティに設定

          A950_CommonBL cb = new A950_CommonBL();
            cb.ISBN = txtISBN.Text;
            cb.BookTitle = txtBookTitle.Text;
            cb.Price = txtPrice.Text;

            // 登録処理実行
            A952_BookBL sb = new A952_BookBL();
            sb.ShouhinInsert(cb);

            // 商品検索画面に戻る
            Response.Redirect("A011_BookSerch.aspx");

        }
    }
}
