using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using edu.uc.cbatest;
using System.Xml.Linq;

public partial class CustomerPorfolio : System.Web.UI.Page
{

    private int _EmpId = -1;
    public int EmpId
    {
        get { return _EmpId; }
        set { _EmpId = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        object userobj = Session["username"];
        string UserName = null;
        if (userobj != null)
        {
            UserName = userobj.ToString();
        }

        if (UserName != null && UserName.Length > 0)
        {
            CallStock();
            int rowcount = gvPortfolio.Rows.Count;
            if (rowcount == 2)
            {
                Risk_Profile.Visible = true;

            }
            else
            {
                Risk_Profile.Visible = false;

            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
        
        
    }

    public void CallStock()
    {
        PortfolioService wsbobjservice = new PortfolioService();
        string strusername = Session["username"].ToString();
        String strportfolio = wsbobjservice.GetPortfolioByUserName(strusername);
        XElement portfolio = XElement.Parse(strportfolio);


        var query = from t in portfolio.Elements("Stock")
                    select new
                    {
                        Ticker = t.Element("Ticker").Value,
                        companyname = t.Element("CompanyName").Value,
                        country = t.Element("Country").Value
                    };
        int count1 = query.Count();
        if(count1==2)
        {

            String ticker1 = query.First().Ticker;
            String ticker2 = query.Last().Ticker;
                Session["ticker1"] = ticker1;
                 Session["ticker2"] = ticker2;
            }
       
        


        gvPortfolio.DataSource = query;
        gvPortfolio.DataBind();

        String stremployee = wsbobjservice.GetEmployeeIDByUserName(strusername);
        XElement employee = XElement.Parse(stremployee);

        string strPath = Request.PhysicalApplicationPath;
        employee.Save(strPath + "employee.xml");
        //Response.Write("<a href='employee.xml'>View employee</a>");

        var query1 = from c in employee.Elements("Customer")
                     select new
                    {
                        EMP_ID = c.Element("EMP_ID").Value,
                    };
        
        

        string empid = query1.First().EMP_ID;
        if (empid != null)
        {
            EmpId = Convert.ToInt32(empid);
        }
        //GridView1.DataSource = query1;
        //GridView1.DataBind();
    }


     protected void Add_Click(object sender, EventArgs e)
     {
   
         int rowcount = gvPortfolio.Rows.Count;

         if (rowcount == 2)
         {
             Label1.Visible = true;
             Label1.Text = "Portfolio cannot contain more than two stocks";
         }
         else
         {
             Response.Redirect("~/SearchStock.aspx");
         }
     }

     protected void gvPortfolio_SelectedIndexChanged1(object sender, EventArgs e)
     {
               PortfolioService objectService1 = new PortfolioService();
               string strusername = Session["username"].ToString();
                string strxml1 = objectService1.RemoveStockFromCustomerPortfolio(strusername, gvPortfolio.SelectedRow.Cells[2].Text.ToString(), gvPortfolio.SelectedRow.Cells[3].Text.ToString());
                XElement xmlstockrecord = XElement.Parse(strxml1);
                CallStock();
               
     }
     //protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
     //{
     //    Session["EMP_ID"] = GridView1.SelectedDataKey.Value.ToString();
     //    Response.Redirect("Employeedetail.aspx?EMP_ID=" + GridView1.SelectedPersistedDataKey.Value); 
     //}

     protected void btnRelMan_Click1(object sender, EventArgs e)
     {
         Panel2.Visible = true;
         if (EmpId > 0)
         {
             lblSelected.Text = EmpId.ToString();

             PortfolioService objwebservice = new PortfolioService();
             string strXML = objwebservice.GetEmployeeDetailByEmpID(lblSelected.Text);
             XElement xmlemprecord = XElement.Parse(strXML);
             XElement xmlemp = xmlemprecord.Element("Employee");
             XElement xmlfirstname = xmlemp.Element("FirstName");
             XElement xmllastname = xmlemp.Element("LastName");
             XElement xmlemail = xmlemp.Element("Email");
             XElement xmlSSN = xmlemp.Element("SSN");
             XElement xmlWorkPhone = xmlemp.Element("WorkPhone");
             XElement xmlHomePhone = xmlemp.Element("HomePhone");
             XElement xmldob = xmlemp.Element("DOB");
             XElement xmlAddress = xmlemp.Element("Address");

             tbxfirstName.Text = xmlfirstname.Value.ToString();
             tbxlastName.Text = xmllastname.Value.ToString();
             tbxdob.Text = xmldob.Value.ToString();
             lblEmail.Text = xmlemail.Value.ToString();
             lblSSN.Text = xmlSSN.Value.ToString();
             lblAddress.Text = xmlAddress.Value.ToString();
             lblWork.Text = xmlWorkPhone.Value.ToString();
             lblHome.Text = xmlHomePhone.Value.ToString();
         }
     }
     protected void Button1_Click(object sender, EventArgs e)
     {
         Session["selEmployee"] = EmpId;

         Response.Redirect("Reporters.aspx?empid=" + EmpId);
     }
     protected void Risk_Profile_Click(object sender, EventArgs e)
     {
         int rowcount = gvPortfolio.Rows.Count;

         if (rowcount != 2)
         {
             riskLabel.Text = "Portfolio must contain atleast two stocks";

         }
         else
         {

             Response.Redirect("~/RiskReward.aspx");
         }
     }
}
