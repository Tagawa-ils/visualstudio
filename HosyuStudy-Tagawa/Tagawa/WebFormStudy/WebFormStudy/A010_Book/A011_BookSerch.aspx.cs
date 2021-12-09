using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormStudy.A010_Book
{
    public partial class A011_ShouhinSerch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSerch_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblResult.Text = "すべて正しい値が入力されました。";
            }
        }
    }
}