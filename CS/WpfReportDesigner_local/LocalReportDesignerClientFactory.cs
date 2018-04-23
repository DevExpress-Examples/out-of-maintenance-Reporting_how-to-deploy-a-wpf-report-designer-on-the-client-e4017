using DevExpress.Data.Utils.ServiceModel;
using DevExpress.Xpf.ReportDesigner.ServiceModel;

namespace WpfReportDesigner_local {
    class LocalReportDesignerClientFactory : ServiceClientFactory<IReportDesignerServiceClient, IAsyncReportDesignerService>, IReportDesignerServiceClientFactory {
        public LocalReportDesignerClientFactory()
            : base(new System.ServiceModel.EndpointAddress("http://localhost/fakeservice.svc")) {
        }
        public override IReportDesignerServiceClient Create() {
            return new LocalReportDesignerClient();
        }
    }
}
