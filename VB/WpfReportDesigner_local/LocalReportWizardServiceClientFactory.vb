Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Data.XtraReports.ServiceModel

Namespace WpfReportDesigner_local
	Friend Class LocalReportWizardServiceClientFactory
		Inherits ReportWizardServiceClientFactory
		Protected Overrides Function CreateClient(ByVal channel As IAsyncReportWizardService) As IReportWizardServiceClient
			Return New LocalReportWizardServiceClient()
		End Function
	End Class
End Namespace
