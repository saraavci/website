﻿<%@ Master Language="C#" AutoEventWireup="true" CodeBehind="sayfa.aspx.cs" Inherits="deneme_4.sayfa" %>

<%@ Register Assembly="GMaps" Namespace="Subgurim.Controles" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MEKANLAR</title>
    <link href="StyleSheet.css" rel="stylesheet" />
    <asp:ContentPlaceHolder ID="head" runat="server">
    </asp:ContentPlaceHolder>

</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper">
        <header>
            <h1>mekan</h1>
        </header>
            <div class="sayfa1">
                <a href="otel.aspx"> <asp:Button ID="Button1" runat="server" Text="Oteller" OnClick="Button1_Click" /> </a><br />
                <a href="atm.aspx"> <asp:Button ID="Button2" runat="server" Text="atmler" OnClick="Button2_Click" /> </a><br />
                <a href="cafe.aspx"> <asp:Button ID="Button3" runat="server" Text="cafeler" OnClick="Button3_Click" /> </a><br />
                <a href="restoran.aspx"> <asp:Button ID="Button4" runat="server" Text="restoranlar" OnClick="Button4_Click" /> </a><br />
            </div>
            <div class="sayfa2">
                <asp:GridView ID="GridView1" onrowcommand="control" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="150px">
                      <AlternatingRowStyle BackColor="#CCCCCC" />
                      <Columns>
                          <asp:ButtonField Text="Göster" CommandName="cmd1" />
                      </Columns>
                      <FooterStyle BackColor="#CCCCCC" />
                      <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                      <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                      <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                      <SortedAscendingCellStyle BackColor="#F1F1F1" />
                      <SortedAscendingHeaderStyle BackColor="#808080" />
                      <SortedDescendingCellStyle BackColor="#CAC9C9" />
                      <SortedDescendingHeaderStyle BackColor="#383838" />
                  </asp:GridView>
              <asp:ContentPlaceHolder ID="CPH" runat="server">
                  
              </asp:ContentPlaceHolder>
            </div>
            <div class="sayfa3">
                <cc1:GMap ID="GMap1" runat="server" Key="AIzaSyBbzayQWkhyVj3CTlFAh0UoVTt6NcZTpmo" />
            </div>
    </div>
    </form>
</body>
</html>
