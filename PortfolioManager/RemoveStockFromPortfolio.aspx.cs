using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using edu.uc.cbatest;
using System.Xml.Linq;

public partial class RemoveStockFromPortfolio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PortfolioService objectService = new PortfolioService();
        string strParam = Session["deletedstock"].ToString();
        
    }
}
