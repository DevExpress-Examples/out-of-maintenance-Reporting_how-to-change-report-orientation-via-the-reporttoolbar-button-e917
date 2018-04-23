using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxPopupControl;
using DevExpress.Web.ASPxCallbackPanel;
using DevExpress.XtraReports.Web;

public partial class _Default : System.Web.UI.Page 
{

    protected void Page_Load(object sender, EventArgs e) {
        HtmlInputHidden hf = (HtmlInputHidden)this.Page.FindControl("ReportMsg");
        XtraReport1 r = new XtraReport1();
        if (hf.Value == "landscape")
            r.Landscape = true;
        r.CreateDocument();
        this.ReportViewer1.Report = r;
        this.ReportViewer1.DataBind();
    }
}
