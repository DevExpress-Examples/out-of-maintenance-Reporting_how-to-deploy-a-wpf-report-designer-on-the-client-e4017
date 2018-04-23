Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.Service
Imports DevExpress.Data.Utils.ServiceModel
Imports System.ComponentModel

Namespace WpfReportDesigner_local
	Friend Class LocalReportServiceClient
		Private ReadOnly reportService_Renamed As ReportService
		Protected ReadOnly Property ReportService() As ReportService
			Get
				Return reportService_Renamed
			End Get
		End Property

		Public Sub New()
			reportService_Renamed = New LocalReportService()
		End Sub

		Protected Sub RaiseScalarOperationCompletedEvent(Of T)(ByVal completedEvent As EventHandler(Of ScalarOperationCompletedEventArgs(Of T)), ByVal result As Object, ByVal asyncState As Object)
			If completedEvent IsNot Nothing Then
				completedEvent(Me, New ScalarOperationCompletedEventArgs(Of T)(result, Nothing, False, asyncState))
			End If
		End Sub

		Protected Sub RaiseOperationCompletedEvent(ByVal completedEvent As EventHandler(Of AsyncCompletedEventArgs), ByVal asyncState As Object)
			If completedEvent IsNot Nothing Then
				completedEvent(Me, New AsyncCompletedEventArgs(Nothing, False, asyncState))
			End If
		End Sub
	End Class
End Namespace
