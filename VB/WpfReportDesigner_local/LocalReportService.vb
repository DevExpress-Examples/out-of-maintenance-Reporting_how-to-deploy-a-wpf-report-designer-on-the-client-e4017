Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports DevExpress.XtraReports.Service

Namespace WpfReportDesigner_local
	Friend Class LocalReportService
		Inherits ReportService
		Private Shared layouts As New Dictionary(Of String, Byte())()

		Protected Overrides Sub SaveReportLayout(ByVal reportName As String, ByVal layoutData() As Byte)
			layouts(reportName) = layoutData
		End Sub

		Protected Overrides Function LoadReportLayout(ByVal reportName As String) As Byte()
			Dim layout() As Byte
			Return If(layouts.TryGetValue(reportName, layout), layout, MyBase.LoadReportLayout(reportName))
		End Function
	End Class
End Namespace
