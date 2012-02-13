using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;

/// <summary>
/// Summary description for WsLinq
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WsLinq : System.Web.Services.WebService {

    public WsLinq () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string GetPlayersList()
    {

        VBlinqDataContext db = new VBlinqDataContext();

        XElement players = new XElement("players",
        from p in db.Players
        select
        new XElement("player",
        new XElement("name", p.PlrName),
        new XElement("phone", p.PlrPhone),
        new XElement("email", p.PlrEmail)));

        return players.ToString();
    }

    [WebMethod]
    public string GetPlayerRecord(string strEmail)
    {
        VBlinqDataContext db = new VBlinqDataContext();

        XElement player = new XElement("players",
        from p in db.Players
        where p.PlrEmail.ToString() == strEmail
        select
        new XElement("player",
        new XElement("name", p.PlrName),
        new XElement("phone", p.PlrPhone),
        new XElement("email", p.PlrEmail)));

        return player.ToString();
    }
    
}

