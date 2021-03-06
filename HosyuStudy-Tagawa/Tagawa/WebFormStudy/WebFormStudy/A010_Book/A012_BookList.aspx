<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="A012_BookList.aspx.cs" Inherits="WebFormStudy.A010_Book.A012_ShouhinList" %>
<%@ Register Tagprefix="win" Tagname="NaviHeader" Src="~/A900_UserControl/A901_Heder.ascx" %>
<%@ Register Tagprefix="win" Tagname="NaviMenu" Src="~/A900_UserControl/A902_Menu.ascx" %>

<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>商品一覧</title>
    
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
            <asp:GridView ID="ShouhinGridView" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="sds" ForeColor="#333333" GridLines="None" Width="1200px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                    <asp:BoundField DataField="BookTitle" HeaderText="BookTitle" SortExpression="BookTitle" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                    <asp:BoundField DataField="DateTime" HeaderText="DateTime" SortExpression="DateTime" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:SqlDataSource ID="sds" runat="server" ConnectionString="<%$ ConnectionStrings:BookList %>" SelectCommand="SELECT * FROM [BookList]" ></asp:SqlDataSource>
        </div>
        <div Class="Footer">
            <asp:Panel ID="PnlFooter" runat="server" BorderColor="Silver" BorderWidth="3px" Height="80px" Width="1650px" HorizontalAlign="Right">
                <P Class="FooterBtn">
                    <asp:Button ID="btnClose" runat="server" Text="閉じる" Font-Size="Medium" Height="35px" TabIndex="5" Width="100px" OnClientClick="window.close()" />
                    <asp:Button ID="btnReturn" runat="server" Text="戻る" Font-Size="Medium" Height="35px" TabIndex="5" Width="100px" OnClick="btnReturn_Click" />
                </P>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
