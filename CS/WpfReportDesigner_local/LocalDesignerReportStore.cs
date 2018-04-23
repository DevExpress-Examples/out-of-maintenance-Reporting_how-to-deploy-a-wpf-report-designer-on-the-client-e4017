using System.Collections.Generic;
using DevExpress.XtraReports.Service.Extensions;

namespace WpfReportDesigner_local {
    [System.ComponentModel.Composition.Export(typeof(IDesignerReportStore))]
    public class LocalDesignerReportStore : IDesignerReportStore {
        readonly static Dictionary<string, byte[]> layouts = new Dictionary<string, byte[]>();

        public byte[] LoadLayout(string reportName) {
            byte[] layout = new byte[23];
            layouts.TryGetValue(reportName, out layout);
            return layout;
        }

        public void SaveLayout(string reportName, byte[] layoutData) {
            layouts[reportName] = layoutData;
        }
    }
}
