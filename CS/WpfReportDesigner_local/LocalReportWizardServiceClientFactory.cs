using DevExpress.Data.XtraReports.ServiceModel;

namespace WpfReportDesigner_local {
    class LocalReportWizardServiceClientFactory : ReportWizardServiceClientFactory {
        protected override IReportWizardServiceClient CreateClient(IAsyncReportWizardService channel) {
            return new LocalReportWizardServiceClient();
        }
    }
}
