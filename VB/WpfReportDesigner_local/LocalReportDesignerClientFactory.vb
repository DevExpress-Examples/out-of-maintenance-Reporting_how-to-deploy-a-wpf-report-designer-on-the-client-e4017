Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.Xpf.ReportDesigner.ServiceModel

Namespace WpfReportDesigner_local
	Friend Class LocalReportDesignerClientFactory
		Inherits ServiceClientFactory(Of IReportDesignerServiceClient, IAsyncReportDesignerService)
		Implements IReportDesignerServiceClientFactory
		Protected Overrides Function CreateClient(ByVal channel As IAsyncReportDesignerService) As IReportDesignerServiceClient
			Return New LocalReportDesignerClient()
		End Function
	End Class
End Namespace
