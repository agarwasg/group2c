<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CustomerPortfolio.aspx.cs" Inherits="CustomerPorfolio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3 style="font-family: Arial">Customer Dashboard</h3>
<asp:Panel ID="Panel1" runat="server" Font-Names="Georgia" Height="440px" 
    Width="489px" ForeColor="#CC0000">

    <asp:GridView ID="gvPortfolio" runat="server" CellPadding="4" 
        DataKeyNames="Ticker" ForeColor="#333333" 
        onselectedindexchanged="gvPortfolio_SelectedIndexChanged1" Height="208px" 
        Width="476px">
        <RowStyle BackColor="#E3EAEB" />
        <Columns>
            <asp:CommandField HeaderText="Delete Stock" ShowHeader="True" 
                ShowSelectButton="True" SelectText="Delete Stock" />
        </Columns>
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
        
    
        <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Visible ="False" Text="Label" 
        Font-Names="Georgia" ForeColor="#CC0000">*</asp:Label>
    <table style="width: 100%">
        <tr>
            <td>
                <asp:Button ID="Add" runat="server" onclick="Add_Click" Text="Add Stock" />
            </td>
            <td>
                <asp:Button ID="btnRelMan" runat="server" onclick="btnRelMan_Click1" 
                    Text="View Relationship Manager" />
            </td>
            <td>
                <asp:Button ID="Risk_Profile" runat="server" onclick="Risk_Profile_Click" 
                    Text="Risk Profile" Visible="False" />
            </td>
        </tr>
    </table>
    <br />
    <br />
    <asp:Label ID="riskLabel" runat="server" Text="*" Visible="False"></asp:Label>
</asp:Panel>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Panel ID="Panel2" runat="server" Height="468px" Width="424px" 
        Visible="False">
    <asp:Label ID="lblSelected" runat="server" Text="Label" Visible="False"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="First Name" Font-Bold="True" 
            Font-Names="Georgia"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="tbxfirstName" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Last Name" Font-Bold="True" 
            Font-Names="Georgia"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; :&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:Label ID="tbxlastName" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="DateofBirth" Font-Bold="True" 
            Font-Names="Georgia"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="tbxdob" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="Labelssn" runat="server" Text="SSN" Font-Bold="True" 
            Font-Names="Georgia"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblSSN" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Email" Font-Bold="True" 
            Font-Names="Georgia"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label8" runat="server" Text="Address" Font-Bold="True" 
            Font-Names="Georgia"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblAddress" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label10" runat="server" Text="Work phone" Font-Bold="True" 
            Font-Names="Georgia"></asp:Label>&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblWork" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Home phone" Font-Bold="True" 
            Font-Names="Georgia"></asp:Label>&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblHome" runat="server" Text=""></asp:Label>
    
&nbsp;<br />
      <br />
        <asp:Button ID="Button1" runat="server" Height="36px" onclick="Button1_Click" 
            style="margin-left: 116px" Text="Employee's Manager" Width="147px" />
    </asp:Panel>
</asp:Content>

