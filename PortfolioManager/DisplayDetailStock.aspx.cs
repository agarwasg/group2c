using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using edu.uc.cbatest;
using System.Xml.Linq;

public partial class DisplayDetailStock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            string strXML;
            PortfolioService objectService = new PortfolioService();
            string strParam = Session["selectedstock"].ToString();
            strXML = objectService.GetStockInfoByTicker(strParam);
            XElement xmlstockrecord = XElement.Parse(strXML);
            XElement xmlstock = xmlstockrecord.Element("Stock");
            XElement xmlstockticker = xmlstock.Element("Ticker");
            XElement xmlstockCusip = xmlstock.Element("Cusip");
            XElement xmlstockVolume = xmlstock.Element("Volume");
            XElement xmlstockEPS = xmlstock.Element("EPS");
            XElement xmlstockSector = xmlstock.Element("Sector");
            XElement xmlstockCompanyName = xmlstock.Element("CompanyName");
            XElement xmlstockCountry = xmlstock.Element("Country");
            
            lblTicker.Text = xmlstockticker.Value.ToString();
            lblCusip.Text = xmlstockCusip.Value.ToString();
            lblVolume.Text = xmlstockVolume.Value.ToString();
            lblEps.Text = xmlstockEPS.Value.ToString();
            lblSector.Text = xmlstockSector.Value.ToString();
            lblCompany.Text = xmlstockCompanyName.Value.ToString();
            lblCountry.Text = xmlstockCountry.Value.ToString();
            
        }
    }

    protected void Add_Click(object sender, EventArgs e)
    {
        PortfolioService objectService = new PortfolioService();

        String strusername = Session["username"].ToString();

        String strcompany = lblCompany.Text;

        String strcountry = lblCountry.Text;

        String straddedportfolio = objectService.AddStockToCustomerPortfolio(strusername, strcompany, strcountry);

        Response.Redirect("CustomerPortfolio.aspx");

     }
  
}
