using System.Data.OleDb;
using System.Windows;
using DevExpress.Data.XtraReports.ServiceModel;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.ReportDesigner;
using DevExpress.XtraReports.Data;
using DevExpress.XtraReports.Service;

namespace WpfReportDesigner_local {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            // Define the application's look-and-feel.
            // (Don't forget to add a corresponding assembly to the project).
            ThemeManager.ApplicationThemeName = "Office2010Black";

            // Create a new string builder.
            var builder = new OleDbConnectionStringBuilder() {
                Provider = "Microsoft.Jet.OLEDB.4.0",
                DataSource = "nwind.mdb"
            };

            // Register the string builder in the current data provider repository.
            DataProviderRepository.Current.Register("nwind", "Northwind", builder.ToString());

            // Create a new client factory and view model for the Designer.
            var factory = new LocalReportDesignerClientFactory();
            var model = new ReportDesignerViewModel() {                
                ReportName = "WpfReportDesigner_local.SampleReport",
                ServiceClientFactory = factory
            };

            // Uncomment the following line, to allow using the Report Wizard in the Designer.
            //model.DesignServices.RegisterType<ReportWizardServiceClientFactory, LocalReportWizardServiceClientFactory>();

            // Assign the model to the Report Designer,
            // and start a design session.
            reportDesigner.Model = model;
            reportDesigner.Model.StartDesign();
        }
    }
}
