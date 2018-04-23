Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.ReportDesigner.ServiceModel
Imports DevExpress.XtraReports.ServiceModel.DataContracts
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.XtraReports.Service
Imports System.ComponentModel
Imports DevExpress.Data.XtraReports.ServiceModel.DataContracts
Imports DevExpress.Xpf.Printing.ServiceModel.DataContracts
Imports DevExpress.Xpf.Printing.XamlExport

Namespace WpfReportDesigner_local
	Friend Class LocalReportDesignerClient
		Inherits LocalReportServiceClient
		Implements IReportDesignerServiceClient
		#Region "ClearReportAsync"
        Public Sub ClearReportAsync(ByVal reportId As ReportSessionId, ByVal asyncState As Object) Implements IReportDesignerServiceClient.ClearReportAsync
            ReportService.ClearReport(reportId)
            RaiseOperationCompletedEvent(ClearReportCompletedEvent, asyncState)
        End Sub
        Public Event ClearReportCompleted As EventHandler(Of AsyncCompletedEventArgs) Implements IReportDesignerServiceClient.ClearReportCompleted
		#End Region
		#Region "GetDataSourceDisplayNameForFieldListAsync"
        Public Sub GetDataSourceDisplayNameForFieldListAsync(ByVal dataSourceId As DataSourceId, ByVal dataMember As String, ByVal asyncState As Object) Implements IReportDesignerServiceClient.GetDataSourceDisplayNameForFieldListAsync
            RaiseScalarOperationCompletedEvent(GetDataSourceDisplayNameForFieldListCompletedEvent, ReportService.GetDataSourceDisplayNameForFieldList(dataSourceId, dataMember), asyncState)
        End Sub
        Public Event GetDataSourceDisplayNameForFieldListCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of String)) Implements IReportDesignerServiceClient.GetDataSourceDisplayNameForFieldListCompleted
		#End Region
		#Region "GetDataSourcesForFieldListAsync"
        Public Sub GetDataSourcesForFieldListAsync(ByVal reportId As ReportSessionId, ByVal asyncState As Object) Implements IReportDesignerServiceClient.GetDataSourcesForFieldListAsync
            RaiseScalarOperationCompletedEvent(GetDataSourcesForFieldListCompletedEvent, ReportService.GetDataSourcesForFieldList(reportId), asyncState)
        End Sub
        Public Event GetDataSourcesForFieldListCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of DataSourceInformation())) Implements IReportDesignerServiceClient.GetDataSourcesForFieldListCompleted
		#End Region
		#Region "GetItemPropertiesForFieldListAsync"
        Public Sub GetItemPropertiesForFieldListAsync(ByVal dataSourceId As DataSourceId, ByVal dataMember As String, ByVal asyncState As Object) Implements IReportDesignerServiceClient.GetItemPropertiesForFieldListAsync
            RaiseScalarOperationCompletedEvent(GetItemPropertiesForFieldListCompletedEvent, ReportService.GetItemPropertiesForFieldList(dataSourceId, dataMember), asyncState)
        End Sub
        Public Event GetItemPropertiesForFieldListCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of PropertyDescriptorProxy())) Implements IReportDesignerServiceClient.GetItemPropertiesForFieldListCompleted
		#End Region
		#Region "GetListItemPropertiesForFieldListAsync"
        Public Sub GetListItemPropertiesForFieldListAsync(ByVal dataSourceId As DataSourceId, ByVal dataMember As String, ByVal asyncState As Object) Implements IReportDesignerServiceClient.GetListItemPropertiesForFieldListAsync
            RaiseScalarOperationCompletedEvent(GetListItemPropertiesForFieldListCompletedEvent, ReportService.GetListItemPropertiesForFieldList(dataSourceId, dataMember), asyncState)
        End Sub
        Public Event GetListItemPropertiesForFieldListCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of PropertyDescriptorProxy())) Implements IReportDesignerServiceClient.GetListItemPropertiesForFieldListCompleted
		#End Region
		#Region "InvokeReportEditingAsync"
        Public Sub InvokeReportEditingAsync(ByVal reportId As ReportSessionId, ByVal editActions() As EditActionBase, ByVal asyncState As Object) Implements IReportDesignerServiceClient.InvokeReportEditingAsync
            RaiseScalarOperationCompletedEvent(InvokeReportEditingCompletedEvent, ReportService.InvokeReportEditing(reportId, editActions), asyncState)
        End Sub
        Public Event InvokeReportEditingCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of String)) Implements IReportDesignerServiceClient.InvokeReportEditingCompleted
		#End Region
		#Region "SaveReportAsync"
        Public Sub SaveReportAsync(ByVal reportId As ReportSessionId, ByVal asyncState As Object) Implements IReportDesignerServiceClient.SaveReportAsync
            ReportService.SaveReport(reportId)
            RaiseOperationCompletedEvent(SaveReportCompletedEvent, asyncState)
        End Sub
        Public Event SaveReportCompleted As EventHandler(Of AsyncCompletedEventArgs) Implements IReportDesignerServiceClient.SaveReportCompleted
		#End Region
		#Region "StartDesignAsync"
        Public Sub StartDesignAsync(ByVal identity As InstanceIdentity, ByVal compatibility As XamlCompatibility, ByVal asyncState As Object) Implements IReportDesignerServiceClient.StartDesignAsync
            RaiseScalarOperationCompletedEvent(StartDesignCompletedEvent, ReportService.StartDesign(identity, compatibility), asyncState)
        End Sub
        Public Event StartDesignCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of ReportDesignerPage)) Implements IReportDesignerServiceClient.StartDesignCompleted
		#End Region
		#Region "GetBuildStatusAsync"
        Public Sub GetBuildStatusAsync(ByVal documentId As DocumentId, ByVal asyncState As Object) Implements IReportDesignerServiceClient.GetBuildStatusAsync
            RaiseScalarOperationCompletedEvent(GetBuildStatusCompletedEvent, ReportService.GetBuildStatus(documentId), asyncState)
        End Sub
        Public Event GetBuildStatusCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of BuildStatus)) Implements IReportDesignerServiceClient.GetBuildStatusCompleted
		#End Region
		#Region "GetDocumentDataAsync"
        Public Sub GetDocumentDataAsync(ByVal documentId As DocumentId, ByVal asyncState As Object) Implements IReportDesignerServiceClient.GetDocumentDataAsync
            RaiseScalarOperationCompletedEvent(GetDocumentDataCompletedEvent, ReportService.GetDocumentData(documentId), asyncState)
        End Sub
        Public Event GetDocumentDataCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of DocumentData)) Implements IReportDesignerServiceClient.GetDocumentDataCompleted
		#End Region
		#Region "GetPagesAsync"
        Public Sub GetPagesAsync(ByVal documentId As DocumentId, ByVal pageIndexes() As Integer, ByVal compatibility As PageCompatibility, ByVal asyncState As Object) Implements IReportDesignerServiceClient.GetPagesAsync
            RaiseScalarOperationCompletedEvent(GetPagesCompletedEvent, ReportService.GetPages(documentId, pageIndexes, compatibility), asyncState)
        End Sub
        Public Event GetPagesCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of Byte())) Implements IReportDesignerServiceClient.GetPagesCompleted
		#End Region
		#Region "GetPrintDocumentAsync"
        Public Sub GetPrintDocumentAsync(ByVal printId As PrintId, ByVal asyncState As Object) Implements IReportDesignerServiceClient.GetPrintDocumentAsync
            RaiseScalarOperationCompletedEvent(GetPrintDocumentCompletedEvent, ReportService.GetPrintDocument(printId), asyncState)
        End Sub
        Public Event GetPrintDocumentCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of Byte())) Implements IReportDesignerServiceClient.GetPrintDocumentCompleted
		#End Region
		#Region "GetPrintStatusAsync"
        Public Sub GetPrintStatusAsync(ByVal printId As PrintId, ByVal asyncState As Object) Implements IReportDesignerServiceClient.GetPrintStatusAsync
            RaiseScalarOperationCompletedEvent(GetPrintStatusCompletedEvent, ReportService.GetPrintStatus(printId), asyncState)
        End Sub
        Public Event GetPrintStatusCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of PrintStatus)) Implements IReportDesignerServiceClient.GetPrintStatusCompleted
		#End Region
		#Region "GetReportInformationAsync"
        Public Sub GetReportInformationAsync(ByVal identity As InstanceIdentity, ByVal asyncState As Object) Implements IReportDesignerServiceClient.GetReportInformationAsync
            RaiseScalarOperationCompletedEvent(GetReportInformationCompletedEvent, ReportService.GetReportInformation(identity), asyncState)
        End Sub
        Public Event GetReportInformationCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of ReportInformation)) Implements IReportDesignerServiceClient.GetReportInformationCompleted
		#End Region
		#Region "StartBuildAsync"
        Public Sub StartBuildAsync(ByVal identity As InstanceIdentity, ByVal buildArgs As ReportBuildArgs, ByVal asyncState As Object) Implements IReportDesignerServiceClient.StartBuildAsync
            RaiseScalarOperationCompletedEvent(StartBuildCompletedEvent, ReportService.StartBuild(identity, buildArgs), asyncState)
        End Sub
        Public Event StartBuildCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of DocumentId)) Implements IReportDesignerServiceClient.StartBuildCompleted
		#End Region
		#Region "StartPrintAsync"
        Public Sub StartPrintAsync(ByVal documentId As DocumentId, ByVal compatibility As PageCompatibility, ByVal asyncState As Object) Implements IReportDesignerServiceClient.StartPrintAsync
            RaiseScalarOperationCompletedEvent(StartPrintCompletedEvent, ReportService.StartPrint(documentId, compatibility), asyncState)
        End Sub
        Public Event StartPrintCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of PrintId)) Implements IReportDesignerServiceClient.StartPrintCompleted
		#End Region
		#Region "StopBuildAsync"
        Public Sub StopBuildAsync(ByVal documentId As DocumentId, ByVal asyncState As Object) Implements IReportDesignerServiceClient.StopBuildAsync
            ReportService.StopBuild(documentId)
            RaiseOperationCompletedEvent(StopBuildCompletedEvent, asyncState)
        End Sub
        Public Event StopBuildCompleted As EventHandler(Of AsyncCompletedEventArgs) Implements IReportDesignerServiceClient.StopBuildCompleted
		#End Region
		#Region "StopPrintAsync"
        Public Sub StopPrintAsync(ByVal printId As PrintId, ByVal asyncState As Object) Implements IReportDesignerServiceClient.StopPrintAsync
            ReportService.StopPrint(printId)
            RaiseOperationCompletedEvent(StopPrintCompletedEvent, asyncState)
        End Sub
        Public Event StopPrintCompleted As EventHandler(Of AsyncCompletedEventArgs) Implements IReportDesignerServiceClient.StopPrintCompleted
		#End Region
		#Region "Abort"
        Public Sub Abort() Implements IReportDesignerServiceClient.Abort
            'intentionally do nothing
        End Sub
		#End Region
		#Region "AssembleDocumentAsync"
        Public Sub AssembleDocumentAsync(ByVal id As UploadingResourceId, ByVal asyncState As Object) Implements IReportDesignerServiceClient.AssembleDocumentAsync
            RaiseScalarOperationCompletedEvent(AssembleDocumentCompletedEvent, ReportService.AssembleDocument(id), asyncState)
        End Sub
        Public Event AssembleDocumentCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of DocumentId)) Implements IReportDesignerServiceClient.AssembleDocumentCompleted
		#End Region
		#Region "ClearDocumentAsync"
        Public Sub ClearDocumentAsync(ByVal documentId As DocumentId, ByVal asyncState As Object) Implements IReportDesignerServiceClient.ClearDocumentAsync
            ReportService.ClearDocument(documentId)
            RaiseOperationCompletedEvent(ClearDocumentCompletedEvent, asyncState)
        End Sub
        Public Event ClearDocumentCompleted As EventHandler(Of AsyncCompletedEventArgs) Implements IReportDesignerServiceClient.ClearDocumentCompleted
		#End Region
		#Region "CloseAsync"
        Public Sub CloseAsync() Implements IReportDesignerServiceClient.CloseAsync
            'intentionally do nothing
        End Sub
		#End Region
		#Region "GetExportStatusAsync"
        Public Sub GetExportStatusAsync(ByVal exportId As ExportId, ByVal asyncState As Object) Implements IReportDesignerServiceClient.GetExportStatusAsync
            RaiseScalarOperationCompletedEvent(GetExportStatusCompletedEvent, ReportService.GetExportStatus(exportId), asyncState)
        End Sub
        Public Event GetExportStatusCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of ExportStatus)) Implements IReportDesignerServiceClient.GetExportStatusCompleted
		#End Region
		#Region "GetExportedDocumentAsync"
        Public Sub GetExportedDocumentAsync(ByVal exportId As ExportId, ByVal asyncState As Object) Implements IReportDesignerServiceClient.GetExportedDocumentAsync
            RaiseScalarOperationCompletedEvent(GetExportedDocumentCompletedEvent, ReportService.GetExportedDocument(exportId), asyncState)
        End Sub
        Public Event GetExportedDocumentCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of Byte())) Implements IReportDesignerServiceClient.GetExportedDocumentCompleted
		#End Region
		#Region "StartExportAsync"
        Public Sub StartExportAsync(ByVal documentId As DocumentId, ByVal exportArgs As DocumentExportArgs, ByVal asyncState As Object) Implements IReportDesignerServiceClient.StartExportAsync
            RaiseScalarOperationCompletedEvent(StartExportCompletedEvent, ReportService.StartExport(documentId, exportArgs), asyncState)
        End Sub
        Public Event StartExportCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of ExportId)) Implements IReportDesignerServiceClient.StartExportCompleted
		#End Region
		#Region "StartUploadAsync"
        Public Sub StartUploadAsync(ByVal asyncState As Object) Implements IReportDesignerServiceClient.StartUploadAsync
            RaiseScalarOperationCompletedEvent(StartUploadCompletedEvent, ReportService.StartUpload(), asyncState)
        End Sub
        Public Event StartUploadCompleted As EventHandler(Of ScalarOperationCompletedEventArgs(Of UploadingResourceId)) Implements IReportDesignerServiceClient.StartUploadCompleted
		#End Region
		#Region "UploadResourceChunkAsync"
        Public Sub UploadResourceChunkAsync(ByVal id As UploadingResourceId, ByVal data() As Byte, ByVal asyncState As Object) Implements IReportDesignerServiceClient.UploadResourceChunkAsync
            ReportService.UploadResourceChunk(id, data)
            RaiseOperationCompletedEvent(UploadResourceChunkCompletedEvent, asyncState)
        End Sub
        Public Event UploadResourceChunkCompleted As EventHandler(Of AsyncCompletedEventArgs) Implements IReportDesignerServiceClient.UploadResourceChunkCompleted
		#End Region
	End Class
End Namespace
