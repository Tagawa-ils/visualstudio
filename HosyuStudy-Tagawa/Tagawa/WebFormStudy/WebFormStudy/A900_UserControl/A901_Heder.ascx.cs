using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace WebFormStudy.A900_UserControl
{
    public partial class A901_Heder : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // リクエストパス
            String rPath = Request.Path;

            // ヘッタータイトル
            A951_CommonUI cb = new A951_CommonUI();
            A950_CommonBL cpb = cb.GetCommmonInfo(rPath, "header");
            lblHederTitle.Text = cpb.DisplayName;
        }
    }
}