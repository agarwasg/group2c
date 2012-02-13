<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DisplayDetailStock.aspx.cs" Inherits="DisplayDetailStock" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3 style="font-family: Arial">Stock Detail</h3>
    <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" BorderWidth="1px" 
        Height="268px" Width="463px">
     
    <table style="width: 87%; font-family: Georgia; height: 214px;">
        <tr>
            <td style="width: 209px">
                <asp:Label ID="Label1" runat="server" Text="Ticker"></asp:Label>
                :</td>
            <td style="width: 200px">
                <asp:Label ID="lblTicker" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 209px">
                CUSIP:</td>
            <td style="width: 200px">
                <asp:Label ID="lblCusip" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 209px">
                Volume:</td>
            <td style="width: 200px">
                <asp:Label ID="lblVolume" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 209px">
                Earnings Per Share (EPS):</td>
            <td style="width: 200px">
                <asp:Label ID="lblEps" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 209px">
                Sector:</td>
            <td style="width: 200px">
                <asp:Label ID="lblSector" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 209px">
                Company:</td>
            <td style="width: 200px">
                <asp:Label ID="lblCompany" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 209px">
                Country:</td>
            <td style="width: 200px">
                <asp:Label ID="lblCountry" runat="server" Text="Label"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 209px">
                <asp:Button ID="Add" runat="server" Text="Add" Width="72px" 
                    onclick="Add_Click" />
            </td>
            <td style="width: 200px">
                &nbsp;</td>
        </tr>
    </table>
    </asp:Panel>
</asp:Content>

