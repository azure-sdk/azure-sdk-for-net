namespace Azure.Developer.TrustedSigning
{
    public partial class TrustedSigningClient
    {
        protected TrustedSigningClient() { }
        public TrustedSigningClient(string endpoint, Azure.Core.TokenCredential credential, Azure.Developer.TrustedSigning.TrustedSigningClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class TrustedSigningClientOptions : Azure.Core.ClientOptions
    {
        public TrustedSigningClientOptions(Azure.Developer.TrustedSigning.Generated.TrustedSigningClientOptions.ServiceVersion version = Azure.Developer.TrustedSigning.Generated.TrustedSigningClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}