using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StlCollegePrepWebsite.Views.Report
{
    public partial class ReportTemplate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    var appSettings = System.Configuration.ConfigurationManager.AppSettings;
                    string serverUrl = appSettings["SSRSServerUrl"].ToString();
                    string reportFolder = appSettings["SSRSReportsFolder"].ToString();
                    string reportName = Request["ReportName"];
                    string heightString = Request["Height"];
                    
                    if (!string.IsNullOrWhiteSpace(heightString))
                    {
                        rvSiteMapping.Height = Unit.Pixel(Convert.ToInt32(heightString)); //- 58);
                    }

                    rvSiteMapping.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;
                    rvSiteMapping.ServerReport.ReportServerUrl = new Uri(serverUrl);
                    rvSiteMapping.ServerReport.ReportPath = String.Format("/{0}/{1}", reportFolder, reportName);

                    rvSiteMapping.ServerReport.Refresh();
                }
                catch (Exception ex)
                {
                    errorMessage.InnerText = ex.ToString();
                }
            }
        }
    }
}