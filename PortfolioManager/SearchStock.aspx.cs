using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedValue == "Company Name")
            Response.Redirect("DisplayStock.aspx?company=" + TextBox1.Text);
        else if (RadioButtonList1.SelectedValue == "Stock Ticker")
            Response.Redirect("DisplayStock.aspx?ticker=" + TextBox1.Text);
        else if (RadioButtonList1.SelectedValue == "CUSIP")
            Response.Redirect("DisplayStock.aspx?cusip=" + TextBox1.Text);                    
        

    }
}
