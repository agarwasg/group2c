using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using edu.uc.cbatest;
using System.Xml.Linq;

public partial class Default2 : System.Web.UI.Page
{
    
     protected void Page_Load(object sender, EventArgs e)
    {
         string strXML;
         PortfolioService objectService = new PortfolioService();
         if (Request.QueryString.ToString().Contains("company"))
         {
             strXML = objectService.GetStockInfoByCompanyName(Request.QueryString["company"]);
         }
         else if (Request.QueryString.ToString().Contains("ticker"))
         {

             strXML = objectService.GetStockInfoByTicker(Request.QueryString["ticker"]);
         }
         else
             strXML = objectService.GetStockInfoByCUSIP(Request.QueryString["cusip"]);
            
        XElement stock = XElement.Parse(strXML);
       var query = from c in stock.Elements("Stock")
                    select new { Ticker = c.Element("Ticker").Value,
                                 Company= c.Element("CompanyName").Value,
                                 Country = c.Element("Country").Value
                               };
       string strPath = Request.PhysicalApplicationPath;
     //  stock.Save(strPath + "securityoffers.xml");
      // Response.Write("<a href='securityoffers.xml'>View XML file</a>");
       int count1 = query.Count();
            if  (count1 == 0)
            {
                Label1.Visible = true;
                Label1.Text = "No record Found.";
                HyperLink1.Visible = true;
                HyperLink1.Text = "Click to go back To Previous Page";
                HyperLink1.NavigateUrl = "~/SearchStock.aspx";

            }
       
       gvstock.DataSource = query;
       gvstock.DataBind();
       if (count1 == 1)
       {
           Session["selectedstock"] = query.First().Ticker;
           Response.Redirect("DisplayDetailStock.aspx");
       }
    }
      protected void gvStock_SelectedIndexChanged(object sender, EventArgs e)
      {
         // Label1.Visible = true;
       //   Label1.Text = gvstock.SelectedDataKey.Value.ToString();
          Session["selectedstock"] = gvstock.SelectedDataKey.Value.ToString();
         // Label1.Visible = true;
         // Label1.Text = gvstock.SelectedDataKey.Value.ToString();
            Label1.Text = gvstock.Rows.Count.ToString();
            Response.Redirect("DisplayDetailStock.aspx");
      }
    
}
