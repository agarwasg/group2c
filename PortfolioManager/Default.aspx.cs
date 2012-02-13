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
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        PortfolioService objectService = new PortfolioService();
        string strUsername = TextBox1.Text.ToString();
        string strPassword = TextBox2.Text.ToString();
        string strXML = objectService.IsValidUser(strUsername, strPassword);
        XElement UsernameRecord = XElement.Parse(strXML);
      //  string strPath = Request.PhysicalApplicationPath;
        //UsernameRecord.Save(strPath + "validuser.xml");
        //Response.Write("<a href='validuser.xml'>View XML1 file</a>");


        //  XElement XMLvalidation = UsernameRecord.Element("Validation");
        XElement isValid = UsernameRecord.Element("IsValid");
        string strValid = isValid.Value.ToString();
        //  Label1.Text = strValid;

        if (strValid.Equals("True"))
        {
            Label1.Text = "Login Successful";
            Session["username"] = strUsername;
            Response.Redirect("CustomerPortfolio.aspx");
            

        }
        else
            if (strValid.Equals("False"))
            {
                {
                    Label1.Text = "Login failed";
                }



            }
    
    }
}
