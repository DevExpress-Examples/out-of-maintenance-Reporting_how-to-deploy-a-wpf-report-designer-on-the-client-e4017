using System;
using DevExpress.Xpf.ReportDesigner.ServiceModel;
using DevExpress.XtraReports.ServiceModel.DataContracts;
using DevExpress.Data.Utils.ServiceModel;
using DevExpress.XtraReports.Service;
using System.ComponentModel;
using DevExpress.Data.XtraReports.ServiceModel.DataContracts;
using DevExpress.Xpf.Printing.ServiceModel.DataContracts;
using DevExpress.Xpf.Printing.XamlExport;

namespace WpfReportDesigner_local {
    class LocalReportDesignerClient : LocalReportServiceClient, IReportDesignerServiceClient {
        #region ClearReportAsync
        public void ClearReportAsync(ReportSessionId reportId, object asyncState) {
            ReportService.ClearReport(reportId);            
            RaiseOperationCompletedEvent(ClearReportCompleted, asyncState);
        }
        public event EventHandler<AsyncCompletedEventArgs> ClearReportCompleted;
        #endregion
        #region GetDataSourceDisplayNameForFieldListAsync
        public void GetDataSourceDisplayNameForFieldListAsync(DataSourceId dataSourceId, string dataMember, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetDataSourceDisplayNameForFieldListCompleted, ReportService.GetDataSourceDisplayNameForFieldList(dataSourceId, dataMember), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<string>> GetDataSourceDisplayNameForFieldListCompleted;
        #endregion
        #region GetDataSourcesForFieldListAsync
        public void GetDataSourcesForFieldListAsync(ReportSessionId reportId, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetDataSourcesForFieldListCompleted, ReportService.GetDataSourcesForFieldList(reportId), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<DataSourceInformation[]>> GetDataSourcesForFieldListCompleted;
        #endregion
        #region GetItemPropertiesForFieldListAsync
        public void GetItemPropertiesForFieldListAsync(DataSourceId dataSourceId, string dataMember, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetItemPropertiesForFieldListCompleted, ReportService.GetItemPropertiesForFieldList(dataSourceId, dataMember), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<PropertyDescriptorProxy[]>> GetItemPropertiesForFieldListCompleted;
        #endregion
        #region GetListItemPropertiesForFieldListAsync
        public void GetListItemPropertiesForFieldListAsync(DataSourceId dataSourceId, string dataMember, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetListItemPropertiesForFieldListCompleted, ReportService.GetListItemPropertiesForFieldList(dataSourceId, dataMember), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<PropertyDescriptorProxy[]>> GetListItemPropertiesForFieldListCompleted;
        #endregion
        #region InvokeReportEditingAsync
        public void InvokeReportEditingAsync(ReportSessionId reportId, EditActionBase[] editActions, object asyncState) {
            RaiseScalarOperationCompletedEvent(InvokeReportEditingCompleted, ReportService.InvokeReportEditing(reportId, editActions), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<string>> InvokeReportEditingCompleted;
        #endregion
        #region SaveReportAsync
        public void SaveReportAsync(ReportSessionId reportId, object asyncState) {
            ReportService.SaveReport(reportId);
            RaiseOperationCompletedEvent(SaveReportCompleted, asyncState);
        }
        public event EventHandler<AsyncCompletedEventArgs> SaveReportCompleted;
        #endregion
        #region StartDesignAsync
        public void StartDesignAsync(InstanceIdentity identity, XamlCompatibility compatibility, object asyncState) {
            RaiseScalarOperationCompletedEvent(StartDesignCompleted, ReportService.StartDesign(identity, compatibility), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<ReportDesignerPage>> StartDesignCompleted;
        #endregion
        #region GetBuildStatusAsync
        public void GetBuildStatusAsync(DocumentId documentId, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetBuildStatusCompleted, ReportService.GetBuildStatus(documentId), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<BuildStatus>> GetBuildStatusCompleted;
        #endregion
        #region GetDocumentDataAsync
        public void GetDocumentDataAsync(DocumentId documentId, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetDocumentDataCompleted, ReportService.GetDocumentData(documentId), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<DocumentData>> GetDocumentDataCompleted;
        #endregion
        #region GetPagesAsync
        public void GetPagesAsync(DocumentId documentId, int[] pageIndexes, PageCompatibility compatibility, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetPagesCompleted, ReportService.GetPages(documentId, pageIndexes, compatibility), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<byte[]>> GetPagesCompleted;
        #endregion
        #region GetPrintDocumentAsync
        public void GetPrintDocumentAsync(PrintId printId, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetPrintDocumentCompleted, ReportService.GetPrintDocument(printId), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<byte[]>> GetPrintDocumentCompleted;
        #endregion
        #region GetPrintStatusAsync
        public void GetPrintStatusAsync(PrintId printId, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetPrintStatusCompleted, ReportService.GetPrintStatus(printId), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<PrintStatus>> GetPrintStatusCompleted;
        #endregion
        #region GetReportInformationAsync
        public void GetReportInformationAsync(InstanceIdentity identity, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetReportInformationCompleted, ReportService.GetReportInformation(identity), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<ReportInformation>> GetReportInformationCompleted;
        #endregion
        #region StartBuildAsync
        public void StartBuildAsync(InstanceIdentity identity, ReportBuildArgs buildArgs, object asyncState) {
            RaiseScalarOperationCompletedEvent(StartBuildCompleted, ReportService.StartBuild(identity, buildArgs), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<DocumentId>> StartBuildCompleted;
        #endregion
        #region StartPrintAsync
        public void StartPrintAsync(DocumentId documentId, PageCompatibility compatibility, object asyncState) {
            RaiseScalarOperationCompletedEvent(StartPrintCompleted, ReportService.StartPrint(documentId, compatibility), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<PrintId>> StartPrintCompleted;
        #endregion
        #region StopBuildAsync
        public void StopBuildAsync(DocumentId documentId, object asyncState) {
            ReportService.StopBuild(documentId);
            RaiseOperationCompletedEvent(StopBuildCompleted, asyncState);
        }
        public event EventHandler<AsyncCompletedEventArgs> StopBuildCompleted;
        #endregion
        #region StopPrintAsync
        public void StopPrintAsync(PrintId printId, object asyncState) {
            ReportService.StopPrint(printId);
            RaiseOperationCompletedEvent(StopPrintCompleted, asyncState);
        }
        public event EventHandler<AsyncCompletedEventArgs> StopPrintCompleted;
        #endregion
        #region Abort
        public void Abort() {
            //intentionally do nothing
        }
        #endregion
        #region AssembleDocumentAsync
        public void AssembleDocumentAsync(UploadingResourceId id, object asyncState) {
            RaiseScalarOperationCompletedEvent(AssembleDocumentCompleted, ReportService.AssembleDocument(id), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<DocumentId>> AssembleDocumentCompleted;
        #endregion
        #region ClearDocumentAsync
        public void ClearDocumentAsync(DocumentId documentId, object asyncState) {
            ReportService.ClearDocument(documentId);
            RaiseOperationCompletedEvent(ClearDocumentCompleted, asyncState);
        }
        public event EventHandler<AsyncCompletedEventArgs> ClearDocumentCompleted;
        #endregion
        #region CloseAsync
        public void CloseAsync() {
            //intentionally do nothing
        }
        #endregion
        #region GetExportStatusAsync
        public void GetExportStatusAsync(ExportId exportId, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetExportStatusCompleted, ReportService.GetExportStatus(exportId), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<ExportStatus>> GetExportStatusCompleted;
        #endregion
        #region GetExportedDocumentAsync
        public void GetExportedDocumentAsync(ExportId exportId, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetExportedDocumentCompleted, ReportService.GetExportedDocument(exportId), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<byte[]>> GetExportedDocumentCompleted;
        #endregion
        #region StartExportAsync
        public void StartExportAsync(DocumentId documentId, DocumentExportArgs exportArgs, object asyncState) {
            RaiseScalarOperationCompletedEvent(StartExportCompleted, ReportService.StartExport(documentId, exportArgs), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<ExportId>> StartExportCompleted;
        #endregion
        #region StartUploadAsync
        public void StartUploadAsync(object asyncState) {
            RaiseScalarOperationCompletedEvent(StartUploadCompleted, ReportService.StartUpload(), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<UploadingResourceId>> StartUploadCompleted;
        #endregion
        #region UploadResourceChunkAsync
        public void UploadResourceChunkAsync(UploadingResourceId id, byte[] data, object asyncState) {
            ReportService.UploadResourceChunk(id, data);
            RaiseOperationCompletedEvent(UploadResourceChunkCompleted, asyncState);
        }
        public event EventHandler<AsyncCompletedEventArgs> UploadResourceChunkCompleted;
        #endregion
    }
}
