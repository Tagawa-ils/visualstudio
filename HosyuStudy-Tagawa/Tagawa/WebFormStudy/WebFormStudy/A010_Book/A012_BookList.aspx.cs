using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormStudy.A950_BL;
using System.Data;

namespace WebFormStudy.A010_Book
{
    public partial class A012_ShouhinList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // パラメータの値をプロパティに設定
            A950_CommonBL cb = new A950_CommonBL();
            cb.ISBN = Request.QueryString["sISBN"];
            cb.BookTitle = Request.QueryString["sBookTitle"];
            cb.Price = Request.QueryString["sPrice"];

            // SQLクエリ作成、グリッドビューに設定。
            A952_ShouhinBL sb = new A952_ShouhinBL();
            sb.SetShouhinSelect(cb, sds);
        }
    }
}