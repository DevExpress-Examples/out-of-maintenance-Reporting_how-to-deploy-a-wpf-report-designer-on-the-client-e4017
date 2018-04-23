using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Data.Utils.ServiceModel;
using DevExpress.Data.XtraReports.DataProviders;
using DevExpress.Data.XtraReports.ServiceModel.DataContracts;
using DevExpress.DocumentServices.ServiceModel.DataContracts;
using DevExpress.Xpf.ReportDesigner.ServiceModel;
using DevExpress.XtraPrinting.XamlExport;
using DevExpress.XtraReports.Service;
using DevExpress.DocumentServices.ServiceModel.DataContracts.Xpf.Designer;
using System.Windows.Forms;
using System.Threading;
// ...

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
            RaiseScalarOperationCompletedEvent(GetDataSourceDisplayNameForFieldListCompleted,ReportService.GetDataSourceDisplayNameForFieldList(dataSourceId, dataMember), asyncState);
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
        #region GetReportParametersAsync
        public void GetReportInformationAsync(InstanceIdentity identity, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetReportParametersCompleted, ReportService.GetReportParameters(identity), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<ReportParameterContainer>> GetReportParametersCompleted;
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
            MessageBox.Show("GetExportStatusAsync");
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
        #region AddNewReportAsync
        public void AddNewReportAsync(DevExpress.Data.XtraReports.Wizard.ReportModel model, object asyncState) {
            RaiseScalarOperationCompletedEvent<string>(AddNewReportCompleted, ReportService.AddNewReport(model), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<string>> AddNewReportCompleted;
        #endregion
        #region GetColumnsAsync
        public void GetColumnsAsync(string dataSourceName, TableInfo dataMemberName, object asyncState) {
            RaiseScalarOperationCompletedEvent<IEnumerable<ColumnInfo>>(GetColumnsCompleted, ReportService.GetColumns(dataSourceName, dataMemberName), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<IEnumerable<ColumnInfo>>> GetColumnsCompleted;
        #endregion
        #region GetDataMembersAsync
        public void GetDataMembersAsync(string dataSourceName, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetDataMembersCompleted, ReportService.GetDataMembers(dataSourceName), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<System.Collections.Generic.IEnumerable<DevExpress.Data.XtraReports.DataProviders.TableInfo>>> GetDataMembersCompleted;
        #endregion
        #region GetDataSourceDisplayNameAsync
        public void GetDataSourceDisplayNameAsync(string dataSourceName, string dataMember, object asyncState) {
            RaiseScalarOperationCompletedEvent<string>(GetDataSourceDisplayNameCompleted, ReportService.GetDataSourceDisplayName(dataSourceName, dataMember), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<string>> GetDataSourceDisplayNameCompleted;
        #endregion
        #region GetDataSourcesAsync
        public void GetDataSourcesAsync(object asyncState) {
            RaiseScalarOperationCompletedEvent<IEnumerable<DataSourceInfo>>(GetDataSourcesCompleted, ReportService.GetDataSources(), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<IEnumerable<DataSourceInfo>>> GetDataSourcesCompleted;
        #endregion
        #region GetItemPropertiesAsync
        public void GetItemPropertiesAsync(string dataSourceName, string dataMember, object asyncState) {
            RaiseScalarOperationCompletedEvent<PropertyDescriptorProxy[]>(GetItemPropertiesCompleted, ReportService.GetItemProperties(dataSourceName, dataMember), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<PropertyDescriptorProxy[]>> GetItemPropertiesCompleted;
        #endregion
        #region GetListItemPropertiesAsync
        public void GetListItemPropertiesAsync(string dataSourceName, string dataMember, object asyncState) {
            RaiseScalarOperationCompletedEvent<PropertyDescriptorProxy[]>(GetListItemPropertiesCompleted, ReportService.GetListItemProperties(dataSourceName, dataMember), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<PropertyDescriptorProxy[]>> GetListItemPropertiesCompleted;
        #endregion

        public void SetSynchronizationContext(SynchronizationContext syncContext) {
            throw new NotSupportedException();
        }
    }
}
