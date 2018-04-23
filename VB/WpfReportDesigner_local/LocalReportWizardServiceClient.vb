Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.Data.XtraReports.ServiceModel
Imports DevExpress.Data.XtraReports.Wizard
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.Data.XtraReports.DataProviders
Imports DevExpress.Data.XtraReports.ServiceModel.DataContracts

Namespace WpfReportDesigner_local
	Friend Class LocalReportWizardServiceClient
		Inherits LocalReportServiceClient
		Implements IReportWizardServiceClient
		#Region "AddNewReportAsync"
        Public Sub AddNewReportAsync(ByVal model As ReportModel, ByVal asyncState As Object) Implements IReportWizardServiceClient.AddNewReportAsync
            RaiseScalarOperationCompletedEvent(AddNewReportCompletedEvent, ReportService.AddNewReport(model), asyncState)
        End Sub
        Public Event AddNewReportCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of String)) Implements IReportWizardServiceClient.AddNewReportCompleted
#End Region
		#Region "GetColumnsAsync"
        Public Sub GetColumnsAsync(ByVal dataSourceName As String, ByVal tableInfo As TableInfo, ByVal asyncState As Object) Implements IReportWizardServiceClient.GetColumnsAsync
            RaiseScalarOperationCompletedEvent(GetColumnsCompletedEvent, ReportService.GetColumns(dataSourceName, tableInfo), asyncState)
        End Sub
        Public Event GetColumnsCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of IEnumerable(Of ColumnInfo))) Implements IReportWizardServiceClient.GetColumnsCompleted
		#End Region
		#Region "GetDataSourceDisplayNameAsync"
        Public Sub GetDataSourceDisplayNameAsync(ByVal dataSourceName As String, ByVal dataMember As String, ByVal asyncState As Object) Implements IReportWizardServiceClient.GetDataSourceDisplayNameAsync
            RaiseScalarOperationCompletedEvent(GetDataSourceDisplayNameCompletedEvent, ReportService.GetDataSourceDisplayName(dataSourceName, dataMember), asyncState)
        End Sub
        Public Event GetDataSourceDisplayNameCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of String)) Implements IReportWizardServiceClient.GetDataSourceDisplayNameCompleted
		#End Region
		#Region "GetDataSourcesAsync"
        Public Sub GetDataSourcesAsync(ByVal asyncState As Object) Implements IReportWizardServiceClient.GetDataSourcesAsync
            RaiseScalarOperationCompletedEvent(GetDataSourcesCompletedEvent, ReportService.GetDataSources(), asyncState)
        End Sub
        Public Event GetDataSourcesCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of IEnumerable(Of DataSourceInfo))) Implements IReportWizardServiceClient.GetDataSourcesCompleted
		#End Region
		#Region "GetItemPropertiesAsync"
        Public Sub GetItemPropertiesAsync(ByVal dataSourceName As String, ByVal dataMember As String, ByVal asyncState As Object) Implements IReportWizardServiceClient.GetItemPropertiesAsync
            RaiseScalarOperationCompletedEvent(GetItemPropertiesCompletedEvent, ReportService.GetItemProperties(dataSourceName, dataMember), asyncState)
        End Sub
        Public Event GetItemPropertiesCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of PropertyDescriptorProxy())) Implements IReportWizardServiceClient.GetItemPropertiesCompleted
		#End Region
		#Region "GetListItemPropertiesAsync"
        Public Sub GetListItemPropertiesAsync(ByVal dataSourceName As String, ByVal dataMember As String, ByVal asyncState As Object) Implements IReportWizardServiceClient.GetListItemPropertiesAsync
            RaiseScalarOperationCompletedEvent(GetListItemPropertiesCompletedEvent, ReportService.GetListItemProperties(dataSourceName, dataMember), asyncState)
        End Sub
        Public Event GetListItemPropertiesCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of PropertyDescriptorProxy())) Implements IReportWizardServiceClient.GetListItemPropertiesCompleted
		#End Region
		#Region "GetTablesAsync"
        Public Sub GetTablesAsync(ByVal dataSourceName As String, ByVal asyncState As Object) Implements IReportWizardServiceClient.GetTablesAsync
            RaiseScalarOperationCompletedEvent(GetTablesCompletedEvent, ReportService.GetTables(dataSourceName), asyncState)
        End Sub
        Public Event GetTablesCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of IEnumerable(Of TableInfo))) Implements IReportWizardServiceClient.GetTablesCompleted
		#End Region
		#Region "GetViewsAsync"
        Public Sub GetViewsAsync(ByVal dataSourceName As String, ByVal asyncState As Object) Implements IReportWizardServiceClient.GetViewsAsync
            RaiseScalarOperationCompletedEvent(GetViewsCompletedEvent, ReportService.GetViews(dataSourceName), asyncState)
        End Sub
        Public Event GetViewsCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of IEnumerable(Of TableInfo))) Implements IReportWizardServiceClient.GetViewsCompleted
		#End Region
		#Region "CloseAsync"
        Public Sub CloseAsync() Implements IReportWizardServiceClient.CloseAsync
        End Sub
		#End Region
		#Region "Abort"
        Public Sub Abort() Implements IReportWizardServiceClient.Abort
        End Sub
#End Region
    End Class
End Namespace
