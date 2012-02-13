using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using edu.uc.cbatest;

public partial class Reporters : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["EmpId"] != null)
        {
            Emp_id.Text = Request.QueryString["EmpId"];
        }

        PortfolioService objwebservice = new PortfolioService();

        string stremp_id = Session["selEmployee"].ToString();

        string strXML = objwebservice.GetEmployeeDetailByEmpID(stremp_id);

        XElement xmlemprecord = XElement.Parse(strXML);

        XElement xmlemp = xmlemprecord.Element("Employee");

        XElement xmlmanagers = xmlemp.Element("Managers");

        XElement xmlmanager = xmlmanagers.Element("Manager");

        XElement xmlmgrfrstname = xmlmanager.Element("FirstName");

        XElement xmlmgrlastname = xmlmanager.Element("LastName");

        //XElement xmlmgrid = xmlmanager.Element("ID");

        tbxmgrfrstname.Text = xmlmgrfrstname.Value.ToString();

        tbxmgrlastname.Text = xmlmgrlastname.Value.ToString();

        //tbxmgrid.Text = xmlmgrid.Value.ToString();

        
        XElement xmldirectrep = xmlemp.Element("DirectReports");

        var query = from p in xmldirectrep.Elements("Report")
                    select new
                    {
                        FirstName = p.Element("FirstName").Value,
                        LastName = p.Element("LastName").Value,
                        ID = p.Element("ID").Value
                    };

        GridView1.DataSource = query;
        GridView1.DataBind(); 

    }
}
