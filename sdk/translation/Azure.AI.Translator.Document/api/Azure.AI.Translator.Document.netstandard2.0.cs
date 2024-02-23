namespace Azure.AI.Translator.Document
{
    public static partial class AITranslatorDocumentModelFactory
    {
        public static Azure.AI.Translator.Document.DocumentTranslateContent DocumentTranslateContent(System.BinaryData document = null, System.Collections.Generic.IEnumerable<System.BinaryData> glossary = null) { throw null; }
    }
    public partial class DocumentTranslateContent : System.ClientModel.Primitives.IJsonModel<Azure.AI.Translator.Document.DocumentTranslateContent>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Translator.Document.DocumentTranslateContent>
    {
        public DocumentTranslateContent(System.BinaryData document) { }
        public System.BinaryData Document { get { throw null; } }
        public System.Collections.Generic.IList<System.BinaryData> Glossary { get { throw null; } }
        Azure.AI.Translator.Document.DocumentTranslateContent System.ClientModel.Primitives.IJsonModel<Azure.AI.Translator.Document.DocumentTranslateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Translator.Document.DocumentTranslateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Translator.Document.DocumentTranslateContent System.ClientModel.Primitives.IPersistableModel<Azure.AI.Translator.Document.DocumentTranslateContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Translator.Document.DocumentTranslateContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Translator.Document.DocumentTranslateContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentTranslationClient
    {
        protected DocumentTranslationClient() { }
        public DocumentTranslationClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public DocumentTranslationClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.AI.Translator.Document.DocumentTranslationClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response<System.BinaryData> DocumentTranslate(string targetLanguage, Azure.AI.Translator.Document.DocumentTranslateContent documentTranslateContent, string sourceLanguage = null, string category = null, bool? allowFallback = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DocumentTranslate(string targetLanguage, Azure.Core.RequestContent content, string sourceLanguage = null, string category = null, bool? allowFallback = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.BinaryData>> DocumentTranslateAsync(string targetLanguage, Azure.AI.Translator.Document.DocumentTranslateContent documentTranslateContent, string sourceLanguage = null, string category = null, bool? allowFallback = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DocumentTranslateAsync(string targetLanguage, Azure.Core.RequestContent content, string sourceLanguage = null, string category = null, bool? allowFallback = default(bool?), Azure.RequestContext context = null) { throw null; }
    }
    public partial class DocumentTranslationClientOptions : Azure.Core.ClientOptions
    {
        public DocumentTranslationClientOptions(Azure.AI.Translator.Document.DocumentTranslationClientOptions.ServiceVersion version = Azure.AI.Translator.Document.DocumentTranslationClientOptions.ServiceVersion.V2023_11_01_Preview) { }
        public enum ServiceVersion
        {
            V2023_11_01_Preview = 1,
        }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class AITranslatorDocumentClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Translator.Document.DocumentTranslationClient, Azure.AI.Translator.Document.DocumentTranslationClientOptions> AddDocumentTranslationClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Translator.Document.DocumentTranslationClient, Azure.AI.Translator.Document.DocumentTranslationClientOptions> AddDocumentTranslationClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
