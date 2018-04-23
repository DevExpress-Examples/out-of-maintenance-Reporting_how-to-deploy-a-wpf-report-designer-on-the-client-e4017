Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Windows
Imports DevExpress.Data.XtraReports.ServiceModel
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.ReportDesigner
Imports DevExpress.XtraReports.Data
Imports DevExpress.XtraReports.Service

Namespace WpfReportDesigner_local
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()

			' Define the application's look-and-feel.
			' (Don't forget to add a corresponding assembly to the project).
			ThemeManager.ApplicationThemeName = "Office2010Black"

			' Create a new string builder.
			Dim builder = New OleDbConnectionStringBuilder() With {.Provider = "Microsoft.Jet.OLEDB.4.0", .DataSource = "nwind.mdb"}

			' Register the string builder in the current data provider repository.
			DataProviderRepository.Current.Register("nwind", "Northwind", builder.ToString())

			' Create a new client factory and view model for the Designer.
			Dim factory = New LocalReportDesignerClientFactory()
			Dim model = New ReportDesignerViewModel() With {.ServiceUri = "http://localhost/fakeReportService.svc", .ReportName = "WpfReportDesigner_local.SampleReport", .ServiceClientFactory = factory}

			' Uncomment the following line, to allow using the Report Wizard in the Designer.
			'model.DesignServices.RegisterType<ReportWizardServiceClientFactory, LocalReportWizardServiceClientFactory>();

			' Assign the model to the Report Designer,
			' and start a design session.
			reportDesigner.Model = model
			reportDesigner.Model.StartDesign()
		End Sub
	End Class
End Namespace
