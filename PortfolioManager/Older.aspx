<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Older.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel2" runat="server" Height="205px" Width="330px" 
                    BorderStyle="None">
                 &nbsp;
                 <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="110px" 
                    Width="228px">
                <asp:ListItem>Company Name</asp:ListItem>
                <asp:ListItem>Stock Ticker</asp:ListItem>
                <asp:ListItem>CUSIP</asp:ListItem>
            </asp:RadioButtonList>
                    <asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="165px"></asp:TextBox>
                    &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Search" 
                        BorderStyle="None" />
                 </asp:Panel>
</asp:Content>

