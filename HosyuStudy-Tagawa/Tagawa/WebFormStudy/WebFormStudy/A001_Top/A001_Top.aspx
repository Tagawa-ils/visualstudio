<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="A001_Top.aspx.cs" Inherits="WebFormStudy.A001_Top.A001_Top" %>
<%@ Register Tagprefix="win" Tagname="NaviHeader" Src="~/A900_UserControl/A901_Heder.ascx" %>
<%@ Register Tagprefix="win" Tagname="NaviMenu" Src="~/A900_UserControl/A902_Menu.ascx" %>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>トップ画面</title>

    <webopt:bundlereference runat="server" path="~/Content/Common.css" />

    <script type="text/javascript">
        function openWin() {
            location.href = "../A010_Book/A011_BookSerch.aspx";
      }
    </script>

</head>
<body>
    <form runat="server">
        <div Class="Menu">
            <win:NaviMenu id="navimenu" runat="Server" />
        </div>
        <div Class="Header">
            <win:NaviHeader id="navihead" runat="Server" />
        </div>
        <div Class="ContentTop">
            <a href="javascript:void(0);" onclick="openWin()">
                <asp:Image ID="btnImgSerch" runat="server" Height="800px" Width="1650px" ImageUrl="~/Images/D7Y_fRAVUAA9khY.jpg" />
            </a>
        </div>
    </form>
</body>
</html>
