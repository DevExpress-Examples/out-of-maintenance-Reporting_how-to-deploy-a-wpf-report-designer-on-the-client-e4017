<!-- default file list -->
*Files to look at*:

* [LocalDesignerReportStore.cs](./CS/WpfReportDesigner_local/LocalDesignerReportStore.cs) (VB: [LocalDesignerReportStore.vb](./VB/WpfReportDesigner_local/LocalDesignerReportStore.vb))
* [LocalReportDesignerClient.cs](./CS/WpfReportDesigner_local/LocalReportDesignerClient.cs) (VB: [LocalReportDesignerClientFactory.vb](./VB/WpfReportDesigner_local/LocalReportDesignerClientFactory.vb))
* [LocalReportDesignerClientFactory.cs](./CS/WpfReportDesigner_local/LocalReportDesignerClientFactory.cs) (VB: [LocalReportDesignerClientFactory.vb](./VB/WpfReportDesigner_local/LocalReportDesignerClientFactory.vb))
* [LocalReportServiceClient.cs](./CS/WpfReportDesigner_local/LocalReportServiceClient.cs) (VB: [LocalReportServiceClient.vb](./VB/WpfReportDesigner_local/LocalReportServiceClient.vb))
* [MainWindow.xaml](./CS/WpfReportDesigner_local/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfReportDesigner_local/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfReportDesigner_local/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfReportDesigner_local/MainWindow.xaml.vb))
<!-- default file list end -->
# How to deploy a WPF Report Designer on the client


<p>This example illustrates the legacy API that was used to deploy the older version of the Report Designer for WPF on the client (without a reporting server).</p>
<p>This control was discontinued, and starting with version 15.2, we recommend you use the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument114104">newer Report Designer version</a> instead.<br><br><br></p>
<p>To deploy the older Report Designer version locally, do the following.</p>
<p>1. Substitute the default client for the Report Designer with a custom one.</p>
<p>1.1. Create a custom client (in this sample, see <strong>LocalReportDesignerClient</strong>) that implements the <strong>IReportDesignerServiceClient </strong>interface. All methods of this interface are delegated from <strong>ReportService </strong>that is defined as a field or property in this client.</p>
<p>1.2. The client can refer to a <strong>ReportService </strong>type object, but it does not implement saving/loading of a report layout. For this reason, add an extension class that implements <strong>IDesignerReportStore</strong> interface (in this sample, see <strong>LocalDesignerReportStor</strong><strong>e</strong> class showing a simplified implementation of the<strong> LoadLayout</strong> and <strong>SaveLayout</strong> methods of the <strong>IDesignerReportStore</strong> interface). <br>  1.3. In this sample, the <strong>Abort </strong>and <strong>CloseAsync </strong>methods in <strong>LocalReportDesignerClient </strong>are intentionally left empty, because they are not required.</p>
<p>1.4. Since the <strong>ReportDesignerViewModel </strong>exposes not the client, but its factory, you need to create this factory as well (in this sample, <strong>LocalReportDesignerClientFactory</strong>) and assign it to the Designer’s view model (in this sample, see <strong>MainWindow.xaml.cs</strong>).</p>
<p>2. For the <strong>ReportDesignerViewModel</strong>, specify a report's name and namespace, as well as a fake <strong>ServiceUri</strong>.</p>
<p><br> See also: <a href="https://www.devexpress.com/Support/Center/p/E4018">How to use a WPF Report Designer in a client-server mode</a>.</p>

<br/>


