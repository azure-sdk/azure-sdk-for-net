namespace Azure.Template.Contoso
{
    public partial class FakedSharedModel
    {
        internal FakedSharedModel() { }
        public System.DateTimeOffset CreatedAt { get { throw null; } }
        public string Tag { get { throw null; } }
    }
    public static partial class TemplateContosoModelFactory
    {
        public static Azure.Template.Contoso.FakedSharedModel FakedSharedModel(string tag = null, System.DateTimeOffset createdAt = default(System.DateTimeOffset)) { throw null; }
        public static Azure.Template.Contoso.WidgetSuite WidgetSuite(string name = null, string manufacturerId = null, Azure.Template.Contoso.FakedSharedModel sharedModel = null) { throw null; }
    }
    public partial class WidgetManagerClient
    {
        protected WidgetManagerClient() { }
        public WidgetManagerClient(Azure.Core.TokenCredential credential) { }
        public WidgetManagerClient(Azure.Core.TokenCredential credential, Azure.Template.Contoso.WidgetManagerClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Operation<System.BinaryData> CreateOrUpdateWidget(Azure.WaitUntil waitUntil, string widgetName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> CreateOrUpdateWidgetAsync(Azure.WaitUntil waitUntil, string widgetName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation DeleteWidget(Azure.WaitUntil waitUntil, string widgetName, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeleteWidgetAsync(Azure.WaitUntil waitUntil, string widgetName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetWidget(string widgetName, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.Template.Contoso.WidgetSuite> GetWidget(string widgetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetWidgetAsync(string widgetName, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Template.Contoso.WidgetSuite>> GetWidgetAsync(string widgetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetWidgets(Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.Template.Contoso.WidgetSuite> GetWidgets(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetWidgetsAsync(Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.Template.Contoso.WidgetSuite> GetWidgetsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class WidgetManagerClientOptions : Azure.Core.ClientOptions
    {
        public WidgetManagerClientOptions(Azure.Template.Contoso.WidgetManagerClientOptions.ServiceVersion version = Azure.Template.Contoso.WidgetManagerClientOptions.ServiceVersion.V2022_11_01_Preview) { }
        public enum ServiceVersion
        {
            V2022_11_01_Preview = 1,
        }
    }
    public partial class WidgetSuite
    {
        internal WidgetSuite() { }
        public string ManufacturerId { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.Template.Contoso.FakedSharedModel SharedModel { get { throw null; } }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class TemplateContosoClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Template.Contoso.WidgetManagerClient, Azure.Template.Contoso.WidgetManagerClientOptions> AddWidgetManagerClient<TBuilder>(this TBuilder builder) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithCredential { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Template.Contoso.WidgetManagerClient, Azure.Template.Contoso.WidgetManagerClientOptions> AddWidgetManagerClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
