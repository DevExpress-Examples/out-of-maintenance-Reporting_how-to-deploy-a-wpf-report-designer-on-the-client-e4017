Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports DevExpress.XtraReports.Service.Extensions

Namespace WpfReportDesigner_local
	<System.ComponentModel.Composition.Export(GetType(IDesignerReportStore))> _
	Public Class LocalDesignerReportStore
		Implements IDesignerReportStore
		Private ReadOnly Shared layouts As New Dictionary(Of String, Byte())()

        Public Function LoadLayout(ByVal reportName As String) As Byte() _
            Implements IDesignerReportStore.LoadLayout
            Dim layout(22) As Byte
            layouts.TryGetValue(reportName, layout)
            Return layout
        End Function

        Public Sub SaveLayout(ByVal reportName As String, ByVal layoutData() As Byte) _
            Implements IDesignerReportStore.SaveLayout
            layouts(reportName) = layoutData
        End Sub
	End Class
End Namespace
