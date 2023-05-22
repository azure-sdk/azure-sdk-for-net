namespace Azure.ApiManagement.DeveloperServicesAPI
{
    public partial class DeveloperServicesAPIClient
    {
        protected DeveloperServicesAPIClient() { }
        public DeveloperServicesAPIClient(string endpoint, Azure.Core.TokenCredential credential, Azure.ApiManagement.DeveloperServicesAPI.DeveloperServicesAPIClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class DeveloperServicesAPIClientOptions : Azure.Core.ClientOptions
    {
        public DeveloperServicesAPIClientOptions(Azure.ApiManagement.DeveloperServicesAPI.Generated.DeveloperServicesAPIClientOptions.ServiceVersion version = Azure.ApiManagement.DeveloperServicesAPI.Generated.DeveloperServicesAPIClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}