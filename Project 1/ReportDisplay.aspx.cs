using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Diagnostics;

namespace Project_1
{
    public partial class ReportDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadTitle();
            LoadProblems();
        }

        protected void LoadProblems()
        {
            DataSet dsData = null;

            lblError.Text = "";

            if (Session["ReportName"] == "Client")
            {
                dsData = clsDatabase.ProblemsByClient();
            }
            else if (Session["ReportName"] == "Institution")
            {
                dsData = clsDatabase.ProblemsByInstitution();
            }
            else if (Session["ReportName"] == "Product")
            {
                dsData = clsDatabase.ProblemsByProduct();
            }
            else if (Session["ReportName"] == "Tech")
            {
                dsData = clsDatabase.ProblemsByTechnician();
            }

            if (dsData == null)
            {
                lblError.Text = "Error retrieving Problems";
            }
            else if (dsData.Tables.Count < 1)
            {
                lblError.Text = "Error retrieving Problems";
                dsData.Dispose();
            }
            else
            {
                gvData.DataSource = dsData.Tables[0];
                gvData.DataBind();
                dsData.Dispose();
            }
        }

        protected void LoadTitle()
        {
            if (Session["ReportName"] == "Client")
            {
                lblReport.Text = "Problems By Client";

            }
            else if (Session["ReportName"] == "Institution")
            {
                lblReport.Text = "Problems By Institution";

            }
            else if (Session["ReportName"] == "Product")
            {
                lblReport.Text = "Problems by Product";

            }
            else if (Session["ReportName"] == "Tech")
            {
                lblReport.Text = "Problems by Technician";

            }
            else
            {
                lblReport.Text = "UNKNOWN";
            }
        }
	
    

        protected void btnMainMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Reports.aspx");
        }
    }
}