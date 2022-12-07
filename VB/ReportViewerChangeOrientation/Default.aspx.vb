Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web
Imports DevExpress.XtraReports.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim hf As HtmlInputHidden = CType(Me.Page.FindControl("ReportMsg"), HtmlInputHidden)
		Dim r As New XtraReport1()
		If hf.Value = "landscape" Then
			r.Landscape = True
		End If
		r.CreateDocument()
		Me.ReportViewer1.Report = r
		Me.ReportViewer1.DataBind()
	End Sub
End Class
