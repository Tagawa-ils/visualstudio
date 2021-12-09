using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using BL;

namespace WebFormStudy.A900_UserControl
{
    public partial class A902_Menu : System.Web.UI.UserControl
    {

        A950_CommonBL cpb;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblHederTitle.Text = "メニュー";

            // メニュー制御
            String rPath = Request.Path;
            A951_CommonUI cb = new A951_CommonUI();
            cpb = cb.GetCommmonInfo(rPath, "menu");
            LinkMenuLeft.Text = cpb.MenuNameLeft;
            LinkMenuLeft.Visible = cpb.MenuLeftHide;
            LinkMenuLeft.Enabled = cpb.MenuLeftEnab;
            LinkMenuRight.Text = cpb.MenuNameRight;
            LinkMenuRight.Visible = cpb.MenuRightHide;
            LinkMenuRight.Enabled = cpb.MenuRightEnab;


            //課題：未着手。リンクボタンの表示制御と遷移先URLの制御
            //LinkMenu.Enabled = false;
            //LinkMenu.PostBackUrl = "";
        }

        protected void LinkMenu_Click(object sender, EventArgs e)
        {

        }

        protected void LinkMenuLeft_Click(object sender, EventArgs e)
        {

        }

        protected void LinkMenuRight_Click(object sender, EventArgs e)
        {

        }
    }
}