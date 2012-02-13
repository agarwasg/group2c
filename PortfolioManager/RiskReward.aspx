<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RiskReward.aspx.cs" Inherits="Default2" %>
<%@ Register assembly="System.Web.DataVisualization, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <span style="text-decoration: underline"><b>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Back" />
        </b></span>
    </p>
    <p>
        &nbsp;<span style="text-decoration: underline"><b>Correlation:</b></span>&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <table class="style1">
        <tr>
            <td>
        <asp:Chart ID="Chart1" runat="server" Height="413px" Width="608px" >
            <series>
                <asp:Series ChartType="Spline" Name="Series1">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
    
            </td>
            <td>
    
    <asp:Table ID="riskReward" runat="server" BackColor="#FFFFCC" 
            BorderColor="#3399FF" BorderStyle="Double" BorderWidth="2px" CellPadding="15" 
            CellSpacing="5" GridLines="Both">
        </asp:Table>
    
            </td>
        </tr>
        <tr>
            <td style="text-align: center">
                Graph : Risk Vs. Reward</td>
            <td style="text-align: center">
                Table</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<asp:Panel ID="Panel1" runat="server" Width="68px">
</asp:Panel>
</asp:Content>

