Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.Data.XtraReports.DataProviders
Imports DevExpress.Data.XtraReports.ServiceModel.DataContracts
Imports DevExpress.DocumentServices.ServiceModel.DataContracts
Imports DevExpress.Xpf.ReportDesigner.ServiceModel
Imports DevExpress.XtraPrinting.XamlExport
Imports DevExpress.XtraReports.Service
Imports DevExpress.DocumentServices.ServiceModel.DataContracts.Xpf.Designer
Imports System.Windows.Forms

Namespace WpfReportDesigner_local
	Friend Class LocalReportDesignerClient
		Inherits LocalReportServiceClient
        Implements IReportDesignerServiceClient
#Region "ClearReportAsync"
        Public Sub ClearReportAsync(ByVal reportId As ReportSessionId, ByVal asyncState As Object) _
            Implements IReportDesignerServiceClient.ClearReportAsync
            ReportService.ClearReport(reportId)
            RaiseOperationCompletedEvent(ClearReportCompletedEvent, asyncState)
        End Sub
        Public Event ClearReportCompleted As EventHandler(Of AsyncCompletedEventArgs) _
            Implements IReportDesignerServiceClient.ClearReportCompleted
#End Region
#Region "GetDataSourceDisplayNameForFieldListAsync"
        Public Sub GetDataSourceDisplayNameForFieldListAsync(ByVal dataSourceId As DataSourceId, ByVal dataMember As String, ByVal asyncState As Object) _
            Implements IReportDesignerServiceClient.GetDataSourceDisplayNameForFieldListAsync
            RaiseScalarOperationCompletedEvent(GetDataSourceDisplayNameForFieldListCompletedEvent, ReportService.GetDataSourceDisplayNameForFieldList(dataSourceId, dataMember), asyncState)
        End Sub
        Public Event GetDataSourceDisplayNameForFieldListCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of String)) _
            Implements IReportDesignerServiceClient.GetDataSourceDisplayNameForFieldListCompleted
#End Region
#Region "GetDataSourcesForFieldListAsync"
        Public Sub GetDataSourcesForFieldListAsync(ByVal reportId As ReportSessionId, ByVal asyncState As Object) _
            Implements IReportDesignerServiceClient.GetDataSourcesForFieldListAsync
            RaiseScalarOperationCompletedEvent(GetDataSourcesForFieldListCompletedEvent, ReportService.GetDataSourcesForFieldList(reportId), asyncState)
        End Sub
        Public Event GetDataSourcesForFieldListCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of DataSourceInformation())) _
            Implements IReportDesignerServiceClient.GetDataSourcesForFieldListCompleted
#End Region
#Region "GetItemPropertiesForFieldListAsync"
        Public Sub GetItemPropertiesForFieldListAsync(ByVal dataSourceId As DataSourceId, ByVal dataMember As String, ByVal asyncState As Object) _
            Implements IReportDesignerServiceClient.GetItemPropertiesForFieldListAsync
            RaiseScalarOperationCompletedEvent(GetItemPropertiesForFieldListCompletedEvent, ReportService.GetItemPropertiesForFieldList(dataSourceId, dataMember), asyncState)
        End Sub
        Public Event GetItemPropertiesForFieldListCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of PropertyDescriptorProxy())) _
            Implements IReportDesignerServiceClient.GetItemPropertiesForFieldListCompleted
#End Region
#Region "GetListItemPropertiesForFieldListAsync"
        Public Sub GetListItemPropertiesForFieldListAsync(ByVal dataSourceId As DataSourceId, ByVal dataMember As String, ByVal asyncState As Object) _
            Implements IReportDesignerServiceClient.GetListItemPropertiesForFieldListAsync
            RaiseScalarOperationCompletedEvent(GetListItemPropertiesForFieldListCompletedEvent, ReportService.GetListItemPropertiesForFieldList(dataSourceId, dataMember), asyncState)
        End Sub
        Public Event GetListItemPropertiesForFieldListCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of PropertyDescriptorProxy())) _
            Implements IReportDesignerServiceClient.GetListItemPropertiesForFieldListCompleted
#End Region
#Region "InvokeReportEditingAsync"
        Public Sub InvokeReportEditingAsync(ByVal reportId As ReportSessionId, ByVal editActions() As EditActionBase, ByVal asyncState As Object) _
            Implements IReportDesignerServiceClient.InvokeReportEditingAsync
            RaiseScalarOperationCompletedEvent(InvokeReportEditingCompletedEvent, ReportService.InvokeReportEditing(reportId, editActions), asyncState)
        End Sub
        Public Event InvokeReportEditingCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of String)) _
            Implements IReportDesignerServiceClient.InvokeReportEditingCompleted
#End Region
#Region "SaveReportAsync"
        Public Sub SaveReportAsync(ByVal reportId As ReportSessionId, ByVal asyncState As Object) _
            Implements IReportDesignerServiceClient.SaveReportAsync
            ReportService.SaveReport(reportId)
            RaiseOperationCompletedEvent(SaveReportCompletedEvent, asyncState)
        End Sub
        Public Event SaveReportCompleted As EventHandler(Of AsyncCompletedEventArgs) _
            Implements IReportDesignerServiceClient.SaveReportCompleted
#End Region
#Region "StartDesignAsync"
        Public Sub StartDesignAsync(ByVal identity As InstanceIdentity, ByVal compatibility As XamlCompatibility, ByVal asyncState As Object) _
            Implements IReportDesignerServiceClient.StartDesignAsync
            RaiseScalarOperationCompletedEvent(StartDesignCompletedEvent, ReportService.StartDesign(identity, compatibility), asyncState)
        End Sub
        Public Event StartDesignCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of ReportDesignerPage)) _
            Implements IReportDesignerServiceClient.StartDesignCompleted
#End Region
#Region "GetBuildStatusAsync"
        Public Sub GetBuildStatusAsync(ByVal documentId As DocumentId, ByVal asyncState As Object)
            RaiseScalarOperationCompletedEvent(GetBuildStatusCompletedEvent, ReportService.GetBuildStatus(documentId), asyncState)
        End Sub
        Public Event GetBuildStatusCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of BuildStatus))
#End Region
#Region "GetDocumentDataAsync"
        Public Sub GetDocumentDataAsync(ByVal documentId As DocumentId, ByVal asyncState As Object)
            RaiseScalarOperationCompletedEvent(GetDocumentDataCompletedEvent, ReportService.GetDocumentData(documentId), asyncState)
        End Sub
        Public Event GetDocumentDataCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of DocumentData))
#End Region
#Region "GetPagesAsync"
        Public Sub GetPagesAsync(ByVal documentId As DocumentId, ByVal pageIndexes() As Integer, ByVal compatibility As PageCompatibility, ByVal asyncState As Object)
            RaiseScalarOperationCompletedEvent(GetPagesCompletedEvent, ReportService.GetPages(documentId, pageIndexes, compatibility), asyncState)
        End Sub
        Public Event GetPagesCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of Byte()))
#End Region
#Region "GetPrintDocumentAsync"
        Public Sub GetPrintDocumentAsync(ByVal printId As PrintId, ByVal asyncState As Object)
            RaiseScalarOperationCompletedEvent(GetPrintDocumentCompletedEvent, ReportService.GetPrintDocument(printId), asyncState)
        End Sub
        Public Event GetPrintDocumentCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of Byte()))
#End Region
#Region "GetPrintStatusAsync"
        Public Sub GetPrintStatusAsync(ByVal printId As PrintId, ByVal asyncState As Object)
            RaiseScalarOperationCompletedEvent(GetPrintStatusCompletedEvent, ReportService.GetPrintStatus(printId), asyncState)
        End Sub
        Public Event GetPrintStatusCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of PrintStatus))
#End Region
#Region "GetReportParametersAsync"
        Public Sub GetReportInformationAsync(ByVal identity As InstanceIdentity, ByVal asyncState As Object)
            RaiseScalarOperationCompletedEvent(GetReportParametersCompletedEvent, ReportService.GetReportParameters(identity), asyncState)
        End Sub
        Public Event GetReportParametersCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of ReportParameterContainer))
#End Region
#Region "StartBuildAsync"
        Public Sub StartBuildAsync(ByVal identity As InstanceIdentity, ByVal buildArgs As ReportBuildArgs, ByVal asyncState As Object)
            RaiseScalarOperationCompletedEvent(StartBuildCompletedEvent, ReportService.StartBuild(identity, buildArgs), asyncState)
        End Sub
        Public Event StartBuildCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of DocumentId))
#End Region
#Region "StartPrintAsync"
        Public Sub StartPrintAsync(ByVal documentId As DocumentId, ByVal compatibility As PageCompatibility, ByVal asyncState As Object)
            RaiseScalarOperationCompletedEvent(StartPrintCompletedEvent, ReportService.StartPrint(documentId, compatibility), asyncState)
        End Sub
        Public Event StartPrintCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of PrintId))
#End Region
#Region "StopBuildAsync"
        Public Sub StopBuildAsync(ByVal documentId As DocumentId, ByVal asyncState As Object)
            ReportService.StopBuild(documentId)
            RaiseOperationCompletedEvent(StopBuildCompletedEvent, asyncState)
        End Sub
        Public Event StopBuildCompleted As EventHandler(Of AsyncCompletedEventArgs)
#End Region
#Region "StopPrintAsync"
        Public Sub StopPrintAsync(ByVal printId As PrintId, ByVal asyncState As Object)
            ReportService.StopPrint(printId)
            RaiseOperationCompletedEvent(StopPrintCompletedEvent, asyncState)
        End Sub
        Public Event StopPrintCompleted As EventHandler(Of AsyncCompletedEventArgs)
#End Region
#Region "Abort"
        Public Sub Abort() Implements IReportDesignerServiceClient.Abort
            'intentionally do nothing
        End Sub
#End Region
#Region "AssembleDocumentAsync"
        Public Sub AssembleDocumentAsync(ByVal id As UploadingResourceId, ByVal asyncState As Object)
            RaiseScalarOperationCompletedEvent(AssembleDocumentCompletedEvent, ReportService.AssembleDocument(id), asyncState)
        End Sub
        Public Event AssembleDocumentCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of DocumentId))
#End Region
#Region "ClearDocumentAsync"
        Public Sub ClearDocumentAsync(ByVal documentId As DocumentId, ByVal asyncState As Object)
            ReportService.ClearDocument(documentId)
            RaiseOperationCompletedEvent(ClearDocumentCompletedEvent, asyncState)
        End Sub
        Public Event ClearDocumentCompleted As EventHandler(Of AsyncCompletedEventArgs)
#End Region
#Region "CloseAsync"
        Public Sub CloseAsync() Implements IReportDesignerServiceClient.CloseAsync
            'intentionally do nothing
        End Sub
#End Region
#Region "GetExportStatusAsync"
        Public Sub GetExportStatusAsync(ByVal exportId As ExportId, ByVal asyncState As Object)
            MessageBox.Show("GetExportStatusAsync")
            RaiseScalarOperationCompletedEvent(GetExportStatusCompletedEvent, ReportService.GetExportStatus(exportId), asyncState)
        End Sub
        Public Event GetExportStatusCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of ExportStatus))
#End Region
#Region "GetExportedDocumentAsync"
        Public Sub GetExportedDocumentAsync(ByVal exportId As ExportId, ByVal asyncState As Object)
            RaiseScalarOperationCompletedEvent(GetExportedDocumentCompletedEvent, ReportService.GetExportedDocument(exportId), asyncState)
        End Sub
        Public Event GetExportedDocumentCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of Byte()))
#End Region
#Region "StartExportAsync"
        Public Sub StartExportAsync(ByVal documentId As DocumentId, ByVal exportArgs As DocumentExportArgs, ByVal asyncState As Object)
            RaiseScalarOperationCompletedEvent(StartExportCompletedEvent, ReportService.StartExport(documentId, exportArgs), asyncState)
        End Sub
        Public Event StartExportCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of ExportId))
#End Region
#Region "StartUploadAsync"
        Public Sub StartUploadAsync(ByVal asyncState As Object)
            RaiseScalarOperationCompletedEvent(StartUploadCompletedEvent, ReportService.StartUpload(), asyncState)
        End Sub
        Public Event StartUploadCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of UploadingResourceId))
#End Region
#Region "UploadResourceChunkAsync"
        Public Sub UploadResourceChunkAsync(ByVal id As UploadingResourceId, ByVal data() As Byte, ByVal asyncState As Object)
            ReportService.UploadResourceChunk(id, data)
            RaiseOperationCompletedEvent(UploadResourceChunkCompletedEvent, asyncState)
        End Sub
        Public Event UploadResourceChunkCompleted As EventHandler(Of AsyncCompletedEventArgs)
#End Region
#Region "AddNewReportAsync"
        Public Sub AddNewReportAsync(ByVal model As DevExpress.Data.XtraReports.Wizard.ReportModel, ByVal asyncState As Object) _
            Implements IReportDesignerServiceClient.AddNewReportAsync
            RaiseScalarOperationCompletedEvent(Of String)(AddNewReportCompletedEvent, ReportService.AddNewReport(model), asyncState)
        End Sub
        Public Event AddNewReportCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of String)) _
            Implements IReportDesignerServiceClient.AddNewReportCompleted
#End Region
#Region "GetColumnsAsync"
        Public Sub GetColumnsAsync(ByVal dataSourceName As String, ByVal dataMemberName As TableInfo, ByVal asyncState As Object) _
            Implements IReportDesignerServiceClient.GetColumnsAsync
            RaiseScalarOperationCompletedEvent(Of IEnumerable(Of ColumnInfo))(GetColumnsCompletedEvent, ReportService.GetColumns(dataSourceName, dataMemberName), asyncState)
        End Sub
        Public Event GetColumnsCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of IEnumerable(Of ColumnInfo))) _
             Implements IReportDesignerServiceClient.GetColumnsCompleted
#End Region
#Region "GetDataMembersAsync"
        Public Sub GetDataMembersAsync(ByVal dataSourceName As String, ByVal asyncState As Object) _
            Implements IReportDesignerServiceClient.GetDataMembersAsync
            RaiseScalarOperationCompletedEvent(GetDataMembersCompletedEvent, ReportService.GetDataMembers(dataSourceName), asyncState)
        End Sub
        Public Event GetDataMembersCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of System.Collections.Generic.IEnumerable(Of DevExpress.Data.XtraReports.DataProviders.TableInfo))) _
            Implements IReportDesignerServiceClient.GetDataMembersCompleted
#End Region
#Region "GetDataSourceDisplayNameAsync"
        Public Sub GetDataSourceDisplayNameAsync(ByVal dataSourceName As String, ByVal dataMember As String, ByVal asyncState As Object) _
            Implements IReportDesignerServiceClient.GetDataSourceDisplayNameAsync
            RaiseScalarOperationCompletedEvent(Of String)(GetDataSourceDisplayNameCompletedEvent, ReportService.GetDataSourceDisplayName(dataSourceName, dataMember), asyncState)
        End Sub
        Public Event GetDataSourceDisplayNameCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of String)) _
            Implements IReportDesignerServiceClient.GetDataSourceDisplayNameCompleted
#End Region
#Region "GetDataSourcesAsync"
        Public Sub GetDataSourcesAsync(ByVal asyncState As Object) _
            Implements IReportDesignerServiceClient.GetDataSourcesAsync
            RaiseScalarOperationCompletedEvent(Of IEnumerable(Of DataSourceInfo))(GetDataSourcesCompletedEvent, ReportService.GetDataSources(), asyncState)
        End Sub
        Public Event GetDataSourcesCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of IEnumerable(Of DataSourceInfo))) _
            Implements IReportDesignerServiceClient.GetDataSourcesCompleted
#End Region
#Region "GetItemPropertiesAsync"
        Public Sub GetItemPropertiesAsync(ByVal dataSourceName As String, ByVal dataMember As String, ByVal asyncState As Object) _
            Implements IReportDesignerServiceClient.GetItemPropertiesAsync
            RaiseScalarOperationCompletedEvent(Of PropertyDescriptorProxy())(GetItemPropertiesCompletedEvent, ReportService.GetItemProperties(dataSourceName, dataMember), asyncState)
        End Sub
        Public Event GetItemPropertiesCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of PropertyDescriptorProxy())) _
            Implements IReportDesignerServiceClient.GetItemPropertiesCompleted
#End Region
#Region "GetListItemPropertiesAsync"
        Public Sub GetListItemPropertiesAsync(ByVal dataSourceName As String, ByVal dataMember As String, ByVal asyncState As Object) _
            Implements IReportDesignerServiceClient.GetListItemPropertiesAsync
            RaiseScalarOperationCompletedEvent(Of PropertyDescriptorProxy())(GetListItemPropertiesCompletedEvent, ReportService.GetListItemProperties(dataSourceName, dataMember), asyncState)
        End Sub
        Public Event GetListItemPropertiesCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of PropertyDescriptorProxy())) _
            Implements IReportDesignerServiceClient.GetListItemPropertiesCompleted
#End Region

        Public Sub SetSynchronizationContext(syncContext As System.Threading.SynchronizationContext) _
            Implements IReportDesignerServiceClient.SetSynchronizationContext
            Throw New NotSupportedException()
        End Sub


    End Class
End Namespace
