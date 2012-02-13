<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AboutPM.aspx.cs" Inherits="AboutPM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="Panel1" runat="server" Height="495px" Width="242px">
    <br />
    <center>
    <asp:Image ID="Image2" runat="server" BorderColor="Black" BorderStyle="Groove" 
            BorderWidth="2px" Height="113px" ImageUrl="~/Pics/pm3.jpeg" Width="147px" />
        <br />
        <br />
        <br />
        <asp:Image ID="Image3" runat="server" BorderColor="Black" BorderStyle="Groove" 
            BorderWidth="2px" Height="111px" ImageUrl="~/Pics/pm4.jpeg" Width="143px" />
        <br />
        <br />
        <br />
        <asp:Image ID="Image4" runat="server" BorderColor="Black" BorderStyle="Groove" 
            BorderWidth="2px" Height="114px" ImageUrl="~/Pics/pm5.jpeg" Width="139px" />
    </center>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<asp:Panel ID="Panel2" runat="server" Height="502px" Width="653px" 
        Font-Names="Georgia">
       <center>
    <h2> Portfolio Management
        &nbsp;</h2> </center>
            <p>
                &nbsp;&nbsp; The project is based on the theory formulated by Nobel laureate Dr. Harry 
                Markowitz on&nbsp;&nbsp; efficiency of a portfolio in <b>Capital Asset Pricing Model (CAPM)</b>. 
                It is based upon the&nbsp;&nbsp;&nbsp;&nbsp; following principle:</p>
           <ul>
               <li>
                   <p>
                       When an investor decides to invest in a particular asset he/she hopes to make 
                       some returns on it and/or preserve the principal capital invested.
                   </p>
               </li>
               <li>
                   <p>
                       Every investment (apart from investment in treasury securities) is associated 
                       with certain amount of risk. Investors invest in risky assets with the hope of 
                       making higher returns.</p>
               </li>
       </ul>
           <p>
               &nbsp;Therefore returns are proportional to risk an investor is willing to take.</p>
       
       <p>
           Here, we concentrate only on choosing the right weights of stock in a given 
           portfolio to minimize the risk and maximize profit. The scope is therefore, 
           restricted to a<b> two stock portfolio.</b></p>
       <p>
           Functionalities implemented are:</p>
       <ul>
           <li>
               <p>
                   Search
               </p>
           </li>
           <li>
               <p>
                   Portfolio Creation
               </p>
           </li>
           <li>
               <p>
                   &nbsp;Graphical Output</p>
           </li>
       </ul>
       
</asp:Panel>
</asp:Content>

