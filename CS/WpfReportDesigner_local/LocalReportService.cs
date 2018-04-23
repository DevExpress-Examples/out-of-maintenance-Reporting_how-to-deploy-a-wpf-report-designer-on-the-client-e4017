using System.Collections.Generic;
using DevExpress.XtraReports.Service;

namespace WpfReportDesigner_local {
    class LocalReportService : ReportService {
        static Dictionary<string, byte[]> layouts = new Dictionary<string, byte[]>();

        protected override void SaveReportLayout(string reportName, byte[] layoutData) {
            layouts[reportName] = layoutData;
        }

        protected override byte[] LoadReportLayout(string reportName) {
            byte[] layout;
            return layouts.TryGetValue(reportName, out layout) ? layout : base.LoadReportLayout(reportName);
        }
    }
}
