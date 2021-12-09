<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="A011_BookSerch.aspx.cs" Inherits="WebFormStudy.A010_Book.A011_ShouhinSerch" %>
<%@ Register Tagprefix="win" Tagname="NaviHeader" Src="~/A900_UserControl/A901_Heder.ascx" %>
<%@ Register Tagprefix="win" Tagname="NaviMenu" Src="~/A900_UserControl/A902_Menu.ascx" %>

<html">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>商品検索</title>
    <link href="../Site.css" rel="stylesheet" />

    <webopt:bundlereference runat="server" path="~/Content/Common.css" />

    <script type="text/javascript">
        function openWin() {
            var url = 'A012_BookList.aspx';
            var sISBN = document.forms.form1.txtISBN.value;
            var sBookTitle = document.forms.form1.txtbooktitle.value;
            var sPrice = document.forms.form1.txtprice.value;
            var url = url + '?sISBN=' + sISBN + '&sname=' + sBookTitle + '&sdetail=' + sPrice;
            // 画面サイズ測定
            x = (screen.width) / 1;
            y = (screen.height) / 1;
            window.open(
                url,
                "_blank",
                "screenX=0,screenY=0,left=0,top=0,width=" + x + ",height=" + y + ",scrollbars=0,toolbar=0,menubar=0,staus=0,resizable=0"
            );
        }

        function openadd() {
            var url = "../A002_Addition/A002_Addition.aspx";
            var sISBN = document.forms.form1.txtISBN.value;
            var sBookTitle = document.forms.form1.txtbooktitle.value;
            var sPrice = document.forms.form1.txtprice.value;
            var url = url + '?sISBN=' + sISBN + '&sname=' + sBookTitle + '&sdetail=' + sPrice;
            // 画面サイズ測定
            x = (screen.width) / 1;
            y = (screen.height) / 1;
            window.open(
                url,
                "_blank",
                "screenX=0,screenY=0,left=0,top=0,width=" + x + ",height=" + y + ",scrollbars=0,toolbar=0,menubar=0,staus=0,resizable=0"
            );

        }
    </script>

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
                <asp:Label ID="lblISBN" runat="server" Text="ISBN" Font-Size="Medium" Height="40px" Width="200px"></asp:Label>
                <asp:TextBox ID="txtISBN" runat="server" TabIndex="1" Height="30px" Width="700px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="ReqISBN" runat="server" 
                ControlToValidate="txtISBN" ErrorMessage="ISBNは13桁の数字を入力してください。" 
                SetFocusOnError="True" 
                ValidationExpression="[0-9]{13}"
                CssClass="valid"></asp:RegularExpressionValidator>
            </div>
            <div>
                <asp:Label ID="lblbooktitle" runat="server" Text="書籍名" Font-Size="Medium" Height="40px" Width="200px"></asp:Label>
                <asp:TextBox ID="txtbooktitle" runat="server" TabIndex="2" Height="30px" Width="700px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqTitle" runat="server" 
                ControlToValidate="txtbookTitle" ErrorMessage="書籍名は必須です。" SetFocusOnError="True" 
                CssClass="valid"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Label ID="lblprice" runat="server" Text="価格" Font-Size="Medium" Height="40px" Width="200px"></asp:Label>
                <asp:TextBox ID="txtprice" runat="server" TabIndex="3" Height="30px" Width="700px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="reqEmail" runat="server" 
                ControlToValidate="txtprice" ErrorMessage="価格は数字で10桁までを入力してください。" 
                SetFocusOnError="True" 
                ValidationExpression="[0-9]{10}"
                CssClass="valid"></asp:RegularExpressionValidator>
            <br />
            </div>
        </div>
        <div Class="Footer">
            <asp:Panel ID="PnlFooter" runat="server" BorderColor="Silver" BorderWidth="3px" Height="80px" Width="1650px" HorizontalAlign="Right">
                <P Class="FooterBtn">
                    <asp:Button ID="Btnadd" runat="server" Text="追加" Font-Size="Medium" Height="35px" TabIndex="5" Width="100px" OnClientClick="openadd()" />
                    <asp:Button ID="btnSerch" runat="server" Text="検索" Font-Size="Medium" Height="35px" TabIndex="4" Width="100px" OnClientClick="openWin()" />
                    <asp:Button ID="btnClose" runat="server" Text="閉じる" Font-Size="Medium" Height="35px" TabIndex="5" Width="100px" OnClientClick="window.close()" />
                </P>
            <asp:Label ID="lblResult" runat="server"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
