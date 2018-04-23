Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
	Inherits DevExpress.XtraReports.UI.XtraReport
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private xrLabel1 As XRLabel
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
		'
		' TODO: Add constructor logic here
		'
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resourceFileName As String = "XtraReport1.resx"
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
		Me.Detail.Height = 53
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.RepeatCountOnEmptyDataSource = 20
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrLabel1
		' 
		Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
		Me.xrLabel1.Location = New System.Drawing.Point(0, 0)
		Me.xrLabel1.Name = "xrLabel1"
		Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel1.Size = New System.Drawing.Size(400, 33)
		Me.xrLabel1.StylePriority.UseFont = False
		Me.xrLabel1.Text = "Report Content"
		' 
		' XtraReport1
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
		Me.Margins = New System.Drawing.Printing.Margins(0, 0, 100, 100)
		Me.PageHeight = 800
		Me.PageWidth = 400
		Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
		Me.Version = "8.1"
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

End Class
