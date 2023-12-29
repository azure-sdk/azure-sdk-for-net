namespace Azure.AI.DocumentTranslation
{
    public partial class DocumentTranslateContent
    {
        public DocumentTranslateContent(System.BinaryData document) { }
        public System.BinaryData Document { get { throw null; } }
        public System.Collections.Generic.IList<System.BinaryData> Glossary { get { throw null; } }
    }
    public partial class DocumentTranslationClient
    {
        protected DocumentTranslationClient() { }
        public DocumentTranslationClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public DocumentTranslationClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.AI.DocumentTranslation.DocumentTranslationClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response<System.BinaryData> DocumentTranslate(string targetLanguage, Azure.AI.DocumentTranslation.DocumentTranslateContent documentTranslateContent, string sourceLanguage = null, string category = null, bool? allowFallback = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DocumentTranslate(string targetLanguage, Azure.Core.RequestContent content, string sourceLanguage = null, string category = null, bool? allowFallback = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.BinaryData>> DocumentTranslateAsync(string targetLanguage, Azure.AI.DocumentTranslation.DocumentTranslateContent documentTranslateContent, string sourceLanguage = null, string category = null, bool? allowFallback = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DocumentTranslateAsync(string targetLanguage, Azure.Core.RequestContent content, string sourceLanguage = null, string category = null, bool? allowFallback = default(bool?), Azure.RequestContext context = null) { throw null; }
    }
    public partial class DocumentTranslationClientOptions : Azure.Core.ClientOptions
    {
        public DocumentTranslationClientOptions(Azure.AI.DocumentTranslation.DocumentTranslationClientOptions.ServiceVersion version = Azure.AI.DocumentTranslation.DocumentTranslationClientOptions.ServiceVersion.V2023_11_01_Preview) { }
        public enum ServiceVersion
        {
            V2023_11_01_Preview = 1,
        }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class AIDocumentTranslationClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.DocumentTranslation.DocumentTranslationClient, Azure.AI.DocumentTranslation.DocumentTranslationClientOptions> AddDocumentTranslationClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.DocumentTranslation.DocumentTranslationClient, Azure.AI.DocumentTranslation.DocumentTranslationClientOptions> AddDocumentTranslationClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
