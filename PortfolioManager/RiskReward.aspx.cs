using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.UI.DataVisualization.Charting;
using System.Collections.Generic;
using edu.uc.cbatest;
using System.Xml.XPath;

public partial class Default2 : System.Web.UI.Page
{
    private void Page_Load(object sender, System.EventArgs e)
    {

        float Er1 = 0.0f;
        float Er2 = 0.0f;
        float Sd1 = 0.0f;
        float Sd2 = 0.0f;
        XElement ExpRet1 = null;
        XElement ExpRet2 = null;
        XElement StdDev1 = null;
        XElement StdDev2 = null;
        string ticker1 = Session["ticker1"].ToString();
        string ticker2 = Session["ticker2"].ToString();
        PortfolioService objectService = new PortfolioService();
        string strXML = objectService.GetStockPairInformation(ticker1, ticker2);
        XElement stock_record = XElement.Parse(strXML);
        string strPath = Request.PhysicalApplicationPath;
        stock_record.Save(strPath + "portfolio_record.xml");
     //   Response.Write("<a href='portfolio_record.xml'>View XML1 file</a>");
        XElement isCoorelation = stock_record.Element("Coorelation");

       


        var tickStock = from stock in stock_record.XPathSelectElements("//Stock")
                        select stock;

        XElement isStock1 = stock_record.Element("Stock");

        foreach (XElement stock in tickStock)
        {

            XAttribute attri1 = stock.Attribute("TickerSymbol");
            if (attri1.Value.ToString().Equals(ticker1))
            {

                ExpRet1 = stock.Element("ExpectedReturn");
                StdDev1 = stock.Element("StandarDeviation");

                //Label2.Text = ExpRet1.Value.ToString();
                //Label3.Text = StdDev1.Value.ToString();

            }
            if (attri1.Value.ToString().Equals(ticker2))
            {

                ExpRet2 = stock.Element("ExpectedReturn");
                StdDev2 = stock.Element("StandarDeviation");
               // Label4.Text = ExpRet2.Value.ToString();
                //Label5.Text = StdDev2.Value.ToString();
            }

        }



        float Corr = (float.Parse(isCoorelation.Value.ToString())) * 0.1f;

        Label1.Text = Corr.ToString();

        Er1 = float.Parse(ExpRet1.Value.ToString());
        Er2 = float.Parse(ExpRet2.Value.ToString());
        Sd1 = float.Parse(StdDev1.Value.ToString());
        Sd2 = float.Parse(StdDev2.Value.ToString());



        float[] W1 = new float[] { 1, .8f, .6f, .4f, .2f, 0 };
        float[] W2 = new float[] { 0, .2f, .4f, .6f, .8f, 1 };
        float[] Erp = new float[6];
        float[] Risk = new float[6];
        //float Er1 = .11f;
        // float Er2 = .25f;
        //  float Sd1 = .15f;
        // float Sd2 = .2f;
        // float Corr = .3f;
        TableRow tHead = new TableRow();

        riskReward.Rows.Add(tHead);
        TableCell weight1 = new TableCell();
        TableCell weight2 = new TableCell();
        TableCell risk = new TableCell();
        TableCell reward = new TableCell();
        weight1.Text = ticker1;
        weight2.Text = ticker2;
        risk.Text = "Risk";
        reward.Text = "Expected Return";
        tHead.Cells.Add(weight1);
        tHead.Cells.Add(weight2);
        tHead.Cells.Add(risk);
        tHead.Cells.Add(reward);



        for (int i = 0; i < 6; i++)
        {
            Erp[i] = (float)Math.Round((((W1[i] * Er1) + (W2[i] * Er2)) * 100), 2);
            Erp[i] = (float)Math.Truncate(Erp[i]);
            Risk[i] = (float)Math.Round(((Math.Sqrt((W1[i] * W1[i] * Sd1 * Sd1) + (W2[i] * W2[i] * Sd2 * Sd2) + (2 * W1[i] * W2[i] * Sd1 * Sd2 * Corr))) * 100), 2);
            TableRow tRow = new TableRow();
            riskReward.Rows.Add(tRow);
            TableCell weightCell1 = new TableCell();
            TableCell weightCell2 = new TableCell();
            TableCell riskCell = new TableCell();
            TableCell rewardCell = new TableCell();
            weightCell1.Text = (W1[i] * 100).ToString() + "%";
            weightCell2.Text = (W2[i] * 100).ToString() + "%";
            riskCell.Text = Risk[i].ToString();
            rewardCell.Text = Erp[i].ToString() + "%";
            tRow.Cells.Add(weightCell1);
            tRow.Cells.Add(weightCell2);
            tRow.Cells.Add(riskCell);
            tRow.Cells.Add(rewardCell);



        }


        // Populate series with random data
        


        for (int pointIndex = 0; pointIndex < Erp.Length; pointIndex++)
        {
            

            Chart1.Series["Series1"].Points.AddXY(Risk[pointIndex], Erp[pointIndex]);


            // Chart1.Series["Series2"].Points.AddY(random.Next(5, 75));
        }

        // Set series chart type
        Chart1.Series["Series1"].ChartType = SeriesChartType.Spline;
        ChartArea area = new ChartArea();


        Chart1.ChartAreas[0].AxisX.Minimum = 0;
        Chart1.ChartAreas[0].AxisX.Maximum = 30;

        //Chart1.Series["Series2"].ChartType = SeriesChartType.Spline;

        // Set point labels

        Chart1.Series["Series1"].IsValueShownAsLabel = true;
        Chart1.Series["Series1"]["ShowMarkerLines"] = "True";
        Chart1.ChartAreas[0].AxisX.IsMarginVisible = true;
        Chart1.Series["Series1"].MarkerStyle = MarkerStyle.Diamond;
        Chart1.ChartAreas[0].AxisX.Title = "Risk as Standard Deviation of Portfolio";
        Chart1.ChartAreas[0].AxisY.Title = "Return Expected ";
        Chart1.ChartAreas[0].AxisY2.LineWidth = 3;

        //Chart1.Series["Series2"].IsValueShownAsLabel = true;

        // Enable X axis margin

        // Chart1.ChartAreas["ChartArea1"].AxisX.IsMarginVisible = true;

        // Enable 3D, and show data point marker lines

        //    Chart1.Series["Series1"]["ShowMarkerLines"] = "True";
        //  Chart1.Series["Series2"]["ShowMarkerLines"] = "True";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/CustomerPortfolio.aspx");
    }
}
