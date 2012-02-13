<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <h3>Welcome!!</h3>
    <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" BorderWidth="1px" 
        Font-Names="Georgia" Height="271px" Width="478px">
    
    <table class="style1" 
       >
    <tr>
        <td style="width: 476px">
            &nbsp;</td>
        
    </tr>
    <tr>
        <td style="width: 476px">
            Please Enter the username and password to access Fund Manager</td>
       
    </tr>
    <tr>
        <td style="width: 476px">
            &nbsp;</td>
       
    </tr>
    <tr>
        <td style="width: 476px; height: 29px;">
            Username:&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBox1" ErrorMessage="Username required"></asp:RequiredFieldValidator>
        </td>
       
    </tr>
    <tr>
        <td style="width: 476px">
            Password:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="TextBox2" ErrorMessage="Password Required"></asp:RequiredFieldValidator>
        </td>
        
    </tr>
    <tr>
        <td style="width: 476px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Sign In" />
        </td>
       
    </tr>
    
        <tr>
            <td style="width: 476px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
    
</table>
</asp:Panel>
<br />
</asp:Content>

