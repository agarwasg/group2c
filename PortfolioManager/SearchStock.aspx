<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SearchStock.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h3>
    <p style="margin-left: 40px; font-family: Arial;">
        Stock Search</p>
    </h3>
    <asp:Panel ID="Panel2" runat="server" Height="205px" Width="330px" 
                    BorderStyle="Solid" BorderWidth="1px" Font-Names="Georgia">
                 &nbsp;
                 <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="121px" 
                    Width="237px">
                <asp:ListItem>Company Name</asp:ListItem>
                <asp:ListItem>Stock Ticker</asp:ListItem>
                <asp:ListItem>CUSIP</asp:ListItem>
            </asp:RadioButtonList>
                    &nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="165px"></asp:TextBox>
                    &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Search" />
                 <br />
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                     ControlToValidate="TextBox1" ErrorMessage="The search field cannot be empty"></asp:RequiredFieldValidator>
                 </asp:Panel>
</asp:Content>

