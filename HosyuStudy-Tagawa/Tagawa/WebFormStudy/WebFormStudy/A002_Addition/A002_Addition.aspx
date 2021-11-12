<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="A002_Addition.aspx.cs" Inherits="WebFormStudy.A002_Addition.A002_Addition" %>
<%@ Register Tagprefix="win" Tagname="NaviHeader" Src="~/A900_UserControl/A901_Heder.ascx" %>
<%@ Register Tagprefix="win" Tagname="NaviMenu" Src="~/A900_UserControl/A902_Menu.ascx" %>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>データ追加</title>

    <webopt:bundlereference runat="server" path="~/Content/Common.css" />

</head>
<body>
    <form id="form1" runat="server">
        <div Class="Menu">
            <win:NaviMenu id="navimenu" runat="Server" />
        </div>
        <div Class="Header">
            <win:NaviHeader id="navihead" runat="Server" />
        </div>
        <div Class="Content">
            <div>
                <asp:Label ID="lblBookTitle" runat="server" Text="書籍名" Font-Size="Medium" Height="40px" Width="200px"></asp:Label>
                <asp:TextBox ID="txtBookTitle" runat="server" TabIndex="1" Height="30px" Width="700px"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblISBN" runat="server" Text="ISBN" Font-Size="Medium" Height="40px" Width="200px"></asp:Label>
                <asp:TextBox ID="txtISBN" runat="server" TabIndex="2" Height="30px" Width="300px"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblPrice" runat="server" Text="価格" Font-Size="Medium" Height="40px" Width="200px"></asp:Label>
                <asp:TextBox ID="txtPrice" runat="server" TabIndex="3" Height="30px" Width="100px"></asp:TextBox>
            </div>
        </div>
        <div Class="Footer">
            <asp:Panel ID="PnlFooter" runat="server" BorderColor="Silver" BorderWidth="3px" Height="80px" Width="1650px" HorizontalAlign="Right">
                <P Class="FooterBtn">
                    <asp:Button ID="btnAdd" runat="server" Text="登録" Font-Size="Medium" Height="35px" TabIndex="4" Width="100px" OnClick="btnAdd_Click" />
                    <asp:Button ID="btnClose" runat="server" Text="閉じる" Font-Size="Medium" Height="35px" TabIndex="5" Width="100px" OnClientClick="window.close()" />
                </P>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
