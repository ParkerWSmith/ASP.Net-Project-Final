using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_1
{
    public partial class Reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Contents["ReportName"] = "";
        }

        protected void btnInstitution_Click(object sender, EventArgs e)
        {
            Session.Contents["ReportName"] = "Institution";
            Response.Redirect("./ReportDisplay.aspx");
        }

        protected void btnClient_Click(object sender, EventArgs e)
        {
            Session.Contents["ReportName"] = "Client";
            Response.Redirect("./ReportDisplay.aspx");
        }

        protected void btnProduct_Click(object sender, EventArgs e)
        {
            Session.Contents["ReportName"] = "Product";
            Response.Redirect("./ReportDisplay.aspx");
        }

        protected void btnTech_Click(object sender, EventArgs e)
        {
            Session.Contents["ReportName"] = "Tech";
            Response.Redirect("./ReportDisplay.aspx");
        }

        protected void btnMainMenu_Click(object sender, EventArgs e)
        {
            Session.Contents["ReportName"] = "";
            Response.Redirect("./Default.aspx");
        }
    }
}