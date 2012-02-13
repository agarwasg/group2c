<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Reporters.aspx.cs" Inherits="Reporters" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel2" runat="server" Height="381px" Width="312px">
</asp:Panel>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Panel ID="Panel3" runat="server" Height="468px" Width="441px" 
        Font-Names="Georgia">
    
    
        <%--<asp:Label ID="Label1" runat="server" Text="Employee_ID : "></asp:Label>--%>
        <asp:Label ID="Emp_id" runat="server" Text="Label" Visible="False"></asp:Label>
    <center style="height: 474px">
    <h3>Manager Details</h3>
    <table style="border: 2px groove #000000; height: 117px; width: 265px;">
    <tr>
    <td bgcolor="#006600" style="color: #FFFFFF">
    <asp:Label ID="Label2" runat="server" Text="First Name : "></asp:Label>
    </td>
    <td style="border: 2px groove #000000">
    <asp:Label ID="tbxmgrfrstname" runat="server" BorderColor="Black" 
            BorderStyle="None" BorderWidth="2px"></asp:Label>
    </td>
    </tr>
    <tr>
    <td bgcolor="#006600" style="color: #FFFFFF">
    <asp:Label ID="Label3" runat="server" Text="Last Name :"></asp:Label>
    </td>
    <td style="border: 2px groove #000000">
    <asp:Label ID="tbxmgrlastname" runat="server" BorderColor="Black" 
            BorderStyle="None" BorderWidth="2px"></asp:Label>
    </td>
    </tr>
    </table>
    
        <%--<asp:Label ID="Label5" runat="server" Text="Manager_Id"></asp:Label>
    &nbsp;:
        <asp:Label ID="tbxmgrid" runat="server" Text="Label"></asp:Label>
    </p>--%>
    <br />
        
       
            <b>Employees Direct Reports</b>
            <asp:GridView ID="GridView1" runat="server" 
                BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                CellPadding="4" Height="140px" style="margin-top: 14px">
                <RowStyle BackColor="White" ForeColor="#333333" />
                <Columns>
                    <asp:CommandField />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
        <br />
        <asp:HyperLink ID="back2" runat="server" NavigateUrl="CustomerPortfolio.aspx">Go Back to the previous page</asp:HyperLink>
   </center>
</asp:Panel>
    
</asp:Content>

