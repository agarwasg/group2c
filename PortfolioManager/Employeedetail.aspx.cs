using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using edu.uc.cbatest;

public partial class Employeedetail : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["EMP_ID"] != null)
        {
           lblSelected.Text = Request.QueryString["EMP_ID"];

        }
        
        PortfolioService objwebservice = new PortfolioService();


        string strCodeParam = Session["EMP_ID"].ToString();
        string strCodeParam1 = Session["EMP_ID"].ToString();

        string strXML = objwebservice.GetEmployeeDetailByEmpID(strCodeParam);

        XElement xmlemprecord = XElement.Parse(strXML);

        XElement xmlemp = xmlemprecord.Element("Employee");

        
        XElement xmlfirstname = xmlemp.Element("FirstName");
        XElement xmllastname  = xmlemp.Element("LastName");
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
   
