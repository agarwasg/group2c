<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DisplayStock.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3 style="font-family: Arial"> View Stock</h3>
    <asp:GridView ID="gvstock" runat="server" DataKeyNames="Ticker" 
        onselectedindexchanged="gvStock_SelectedIndexChanged" BorderStyle="Solid" 
        BorderWidth="1px" CellPadding="4" ForeColor="#333333" Font-Names="Georgia">
        <RowStyle BackColor="#E3EAEB" />
        <Columns>
            <asp:CommandField HeaderText="Select Stock" ShowHeader="True" 
                ShowSelectButton="True"  ControlStyle-ForeColor="#0066FF" >
<ControlStyle ForeColor="#0066FF"></ControlStyle>
            </asp:CommandField>
        </Columns>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    <br />
    <asp:HyperLink ID="HyperLink1" visible = "False" runat="server">HyperLink</asp:HyperLink>
</asp:Content>

