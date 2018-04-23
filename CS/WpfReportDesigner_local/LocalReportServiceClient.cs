using System;
using DevExpress.XtraReports.Service;
using DevExpress.Data.Utils.ServiceModel;
using System.ComponentModel;

namespace WpfReportDesigner_local {
    class LocalReportServiceClient {
        readonly ReportService reportService;
        protected ReportService ReportService { get { return reportService; } }

        public LocalReportServiceClient() {
            reportService = new LocalReportService();
        }

        protected void RaiseScalarOperationCompletedEvent<T>(EventHandler<ScalarOperationCompletedEventArgs<T>> completedEvent, object result, object asyncState) {
            if(completedEvent != null)
                completedEvent(this, new ScalarOperationCompletedEventArgs<T>(result, null, false, asyncState));
        }

        protected void RaiseOperationCompletedEvent(EventHandler<AsyncCompletedEventArgs> completedEvent, object asyncState) {
            if(completedEvent != null)
                completedEvent(this, new AsyncCompletedEventArgs(null, false, asyncState));
        }
    }
}
