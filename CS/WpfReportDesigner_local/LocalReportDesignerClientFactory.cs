using DevExpress.Data.Utils.ServiceModel;
using DevExpress.Xpf.ReportDesigner.ServiceModel;

namespace WpfReportDesigner_local {
    class LocalReportDesignerClientFactory : ServiceClientFactory<IReportDesignerServiceClient, IAsyncReportDesignerService>, IReportDesignerServiceClientFactory {
        protected override IReportDesignerServiceClient CreateClient(IAsyncReportDesignerService channel) {
            return new LocalReportDesignerClient();
        }
    }
}
