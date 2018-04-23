Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.Xpf.ReportDesigner.ServiceModel

Namespace WpfReportDesigner_local
	Friend Class LocalReportDesignerClientFactory
		Inherits ServiceClientFactory(Of IReportDesignerServiceClient, IAsyncReportDesignerService)
		Implements IReportDesignerServiceClientFactory
		Public Sub New()
			MyBase.New(New System.ServiceModel.EndpointAddress("http://localhost/fakeservice.svc"))
		End Sub
		Public Overrides Function Create() As IReportDesignerServiceClient
			Return New LocalReportDesignerClient()
		End Function
	End Class
End Namespace
