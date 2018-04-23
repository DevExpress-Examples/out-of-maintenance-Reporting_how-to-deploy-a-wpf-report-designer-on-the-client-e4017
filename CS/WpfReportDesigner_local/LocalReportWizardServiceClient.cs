using System;
using System.Collections.Generic;
using DevExpress.Data.XtraReports.ServiceModel;
using DevExpress.Data.XtraReports.Wizard;
using DevExpress.Data.Utils.ServiceModel;
using DevExpress.Data.XtraReports.DataProviders;
using DevExpress.Data.XtraReports.ServiceModel.DataContracts;

namespace WpfReportDesigner_local {
    class LocalReportWizardServiceClient : LocalReportServiceClient, IReportWizardServiceClient {
        #region AddNewReportAsync
        public void AddNewReportAsync(ReportModel model, object asyncState) {
            RaiseScalarOperationCompletedEvent(AddNewReportCompleted, ReportService.AddNewReport(model), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<string>> AddNewReportCompleted;
        #endregion
        #region GetColumnsAsync
        public void GetColumnsAsync(string dataSourceName, TableInfo tableInfo, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetColumnsCompleted, ReportService.GetColumns(dataSourceName, tableInfo), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<IEnumerable<ColumnInfo>>> GetColumnsCompleted;
        #endregion
        #region GetDataSourceDisplayNameAsync
        public void GetDataSourceDisplayNameAsync(string dataSourceName, string dataMember, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetDataSourceDisplayNameCompleted, ReportService.GetDataSourceDisplayName(dataSourceName, dataMember), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<string>> GetDataSourceDisplayNameCompleted;
        #endregion
        #region GetDataSourcesAsync
        public void GetDataSourcesAsync(object asyncState) {
            RaiseScalarOperationCompletedEvent(GetDataSourcesCompleted, ReportService.GetDataSources(), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<IEnumerable<DataSourceInfo>>> GetDataSourcesCompleted;
        #endregion
        #region GetItemPropertiesAsync
        public void GetItemPropertiesAsync(string dataSourceName, string dataMember, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetItemPropertiesCompleted, ReportService.GetItemProperties(dataSourceName, dataMember), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<PropertyDescriptorProxy[]>> GetItemPropertiesCompleted;
        #endregion
        #region GetListItemPropertiesAsync
        public void GetListItemPropertiesAsync(string dataSourceName, string dataMember, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetListItemPropertiesCompleted, ReportService.GetListItemProperties(dataSourceName, dataMember), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<PropertyDescriptorProxy[]>> GetListItemPropertiesCompleted;
        #endregion
        #region GetTablesAsync
        public void GetTablesAsync(string dataSourceName, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetTablesCompleted, ReportService.GetTables(dataSourceName), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<IEnumerable<TableInfo>>> GetTablesCompleted;
        #endregion
        #region GetViewsAsync
        public void GetViewsAsync(string dataSourceName, object asyncState) {
            RaiseScalarOperationCompletedEvent(GetViewsCompleted, ReportService.GetViews(dataSourceName), asyncState);
        }
        public event EventHandler<ScalarOperationCompletedEventArgs<IEnumerable<TableInfo>>> GetViewsCompleted;
        #endregion
        #region CloseAsync
        public void CloseAsync() {            
        }        
        #endregion
        #region Abort
        public void Abort() {
        }
        #endregion
    }
}
