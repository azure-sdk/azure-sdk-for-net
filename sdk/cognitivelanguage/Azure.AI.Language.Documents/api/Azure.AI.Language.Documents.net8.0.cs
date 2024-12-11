namespace Azure.AI.Language.Documents
{
    public partial class AbstractiveSummarizationActionContent : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummarizationActionContent>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationActionContent>
    {
        public AbstractiveSummarizationActionContent() { }
        public string Instruction { get { throw null; } set { } }
        public bool? LoggingOptOut { get { throw null; } set { } }
        public string ModelVersion { get { throw null; } set { } }
        public int? SentenceCount { get { throw null; } set { } }
        public Azure.AI.Language.Documents.StringIndexType? StringIndexType { get { throw null; } set { } }
        public Azure.AI.Language.Documents.SummaryLengthBucket? SummaryLength { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AbstractiveSummarizationActionContent System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummarizationActionContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummarizationActionContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AbstractiveSummarizationActionContent System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationActionContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationActionContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationActionContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AbstractiveSummarizationOperationAction : Azure.AI.Language.Documents.AnalyzeDocumentsOperationAction, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummarizationOperationAction>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationOperationAction>
    {
        public AbstractiveSummarizationOperationAction(Azure.AI.Language.Documents.AbstractiveSummarizationActionContent actionContent) { }
        public Azure.AI.Language.Documents.AbstractiveSummarizationActionContent ActionContent { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AbstractiveSummarizationOperationAction System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummarizationOperationAction>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummarizationOperationAction>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AbstractiveSummarizationOperationAction System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationOperationAction>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationOperationAction>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationOperationAction>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AbstractiveSummarizationOperationResult : Azure.AI.Language.Documents.AnalyzeDocumentsLROResult, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummarizationOperationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationOperationResult>
    {
        internal AbstractiveSummarizationOperationResult() : base (default(System.DateTimeOffset), default(Azure.AI.Language.Documents.DocumentActionState)) { }
        public Azure.AI.Language.Documents.AbstractiveSummarizationResult Results { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AbstractiveSummarizationOperationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummarizationOperationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummarizationOperationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AbstractiveSummarizationOperationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationOperationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationOperationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationOperationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AbstractiveSummarizationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummarizationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationResult>
    {
        internal AbstractiveSummarizationResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Documents.AbstractiveSummaryDocumentResultWithDetectedLanguage> Documents { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Documents.DocumentError> Errors { get { throw null; } }
        public string ModelVersion { get { throw null; } }
        public Azure.AI.Language.Documents.RequestStatistics Statistics { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AbstractiveSummarizationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummarizationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummarizationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AbstractiveSummarizationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummarizationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AbstractiveSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummary>
    {
        internal AbstractiveSummary() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Documents.SummaryContext> Contexts { get { throw null; } }
        public string Text { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AbstractiveSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AbstractiveSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AbstractiveSummaryDocumentResultWithDetectedLanguage : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummaryDocumentResultWithDetectedLanguage>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummaryDocumentResultWithDetectedLanguage>
    {
        internal AbstractiveSummaryDocumentResultWithDetectedLanguage() { }
        public Azure.AI.Language.Documents.DetectedLanguage DetectedLanguage { get { throw null; } }
        public string Id { get { throw null; } }
        public Azure.AI.Language.Documents.DocumentStatistics Statistics { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Documents.AbstractiveSummary> Summaries { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Documents.DocumentWarning> Warnings { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AbstractiveSummaryDocumentResultWithDetectedLanguage System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummaryDocumentResultWithDetectedLanguage>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AbstractiveSummaryDocumentResultWithDetectedLanguage>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AbstractiveSummaryDocumentResultWithDetectedLanguage System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummaryDocumentResultWithDetectedLanguage>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummaryDocumentResultWithDetectedLanguage>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AbstractiveSummaryDocumentResultWithDetectedLanguage>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class AILanguageDocumentsModelFactory
    {
        public static Azure.AI.Language.Documents.AbstractiveSummarizationOperationAction AbstractiveSummarizationOperationAction(string name = null, Azure.AI.Language.Documents.AbstractiveSummarizationActionContent actionContent = null) { throw null; }
        public static Azure.AI.Language.Documents.AbstractiveSummarizationOperationResult AbstractiveSummarizationOperationResult(System.DateTimeOffset lastUpdateDateTime = default(System.DateTimeOffset), Azure.AI.Language.Documents.DocumentActionState status = default(Azure.AI.Language.Documents.DocumentActionState), string taskName = null, Azure.AI.Language.Documents.AbstractiveSummarizationResult results = null) { throw null; }
        public static Azure.AI.Language.Documents.AbstractiveSummarizationResult AbstractiveSummarizationResult(System.Collections.Generic.IEnumerable<Azure.AI.Language.Documents.DocumentError> errors = null, Azure.AI.Language.Documents.RequestStatistics statistics = null, string modelVersion = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Documents.AbstractiveSummaryDocumentResultWithDetectedLanguage> documents = null) { throw null; }
        public static Azure.AI.Language.Documents.AbstractiveSummary AbstractiveSummary(string text = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Documents.SummaryContext> contexts = null) { throw null; }
        public static Azure.AI.Language.Documents.AbstractiveSummaryDocumentResultWithDetectedLanguage AbstractiveSummaryDocumentResultWithDetectedLanguage(string id = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Documents.DocumentWarning> warnings = null, Azure.AI.Language.Documents.DocumentStatistics statistics = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Documents.AbstractiveSummary> summaries = null, Azure.AI.Language.Documents.DetectedLanguage detectedLanguage = null) { throw null; }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsDocumentError AnalyzeDocumentsDocumentError(string id = null, Azure.AI.Language.Documents.AnalyzeDocumentsError error = null) { throw null; }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsError AnalyzeDocumentsError(Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode code = default(Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode), string message = null, string target = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Documents.AnalyzeDocumentsError> details = null, Azure.AI.Language.Documents.InnerErrorModel innererror = null) { throw null; }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsJobState AnalyzeDocumentsJobState(string displayName = null, System.DateTimeOffset createdAt = default(System.DateTimeOffset), System.DateTimeOffset? expiresOn = default(System.DateTimeOffset?), System.Guid jobId = default(System.Guid), System.DateTimeOffset lastUpdatedAt = default(System.DateTimeOffset), Azure.AI.Language.Documents.DocumentActionState status = default(Azure.AI.Language.Documents.DocumentActionState), System.Collections.Generic.IEnumerable<Azure.AI.Language.Documents.AnalyzeDocumentsError> errors = null, string nextLink = null, Azure.AI.Language.Documents.DocumentActions tasks = null, Azure.AI.Language.Documents.RequestStatistics statistics = null) { throw null; }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsLROResult AnalyzeDocumentsLROResult(System.DateTimeOffset lastUpdateDateTime = default(System.DateTimeOffset), Azure.AI.Language.Documents.DocumentActionState status = default(Azure.AI.Language.Documents.DocumentActionState), string taskName = null, string kind = null) { throw null; }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsOperationInput AnalyzeDocumentsOperationInput(string displayName = null, Azure.AI.Language.Documents.MultiLanguageDocumentInput documentsInput = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Documents.AnalyzeDocumentsOperationAction> actions = null, string defaultLanguage = null) { throw null; }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsResult AnalyzeDocumentsResult(System.Collections.Generic.IEnumerable<Azure.AI.Language.Documents.AnalyzeDocumentsDocumentError> errors = null, Azure.AI.Language.Documents.RequestStatistics statistics = null, string modelVersion = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Documents.DocumentAnalysisDocumentResult> documents = null) { throw null; }
        public static Azure.AI.Language.Documents.DetectedLanguage DetectedLanguage(string name = null, string iso6391Name = null, double confidenceScore = 0, Azure.AI.Language.Documents.ScriptKind? script = default(Azure.AI.Language.Documents.ScriptKind?), Azure.AI.Language.Documents.ScriptCode? scriptCode = default(Azure.AI.Language.Documents.ScriptCode?)) { throw null; }
        public static Azure.AI.Language.Documents.DocumentActions DocumentActions(int completed = 0, int failed = 0, int inProgress = 0, int total = 0, System.Collections.Generic.IEnumerable<Azure.AI.Language.Documents.AnalyzeDocumentsLROResult> items = null) { throw null; }
        public static Azure.AI.Language.Documents.DocumentAnalysisDocumentResult DocumentAnalysisDocumentResult(string id = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Documents.DocumentWarning> warnings = null, Azure.AI.Language.Documents.DocumentStatistics statistics = null, Azure.AI.Language.Documents.DocumentLocation source = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Documents.DocumentLocation> target = null) { throw null; }
        public static Azure.AI.Language.Documents.DocumentError DocumentError(string id = null, Azure.AI.Language.Documents.AnalyzeDocumentsError error = null) { throw null; }
        public static Azure.AI.Language.Documents.DocumentStatistics DocumentStatistics(int charactersCount = 0, int transactionsCount = 0) { throw null; }
        public static Azure.AI.Language.Documents.DocumentWarning DocumentWarning(Azure.AI.Language.Documents.WarningCode code = default(Azure.AI.Language.Documents.WarningCode), string message = null, string targetRef = null) { throw null; }
        public static Azure.AI.Language.Documents.ExtractiveSummarizationOperationResult ExtractiveSummarizationOperationResult(System.DateTimeOffset lastUpdateDateTime = default(System.DateTimeOffset), Azure.AI.Language.Documents.DocumentActionState status = default(Azure.AI.Language.Documents.DocumentActionState), string taskName = null, Azure.AI.Language.Documents.AnalyzeDocumentsResult results = null) { throw null; }
        public static Azure.AI.Language.Documents.InnerErrorModel InnerErrorModel(Azure.AI.Language.Documents.InnerErrorCode code = default(Azure.AI.Language.Documents.InnerErrorCode), string message = null, System.Collections.Generic.IReadOnlyDictionary<string, string> details = null, string target = null, Azure.AI.Language.Documents.InnerErrorModel innererror = null) { throw null; }
        public static Azure.AI.Language.Documents.MultiLanguageInput MultiLanguageInput(string id = null, Azure.AI.Language.Documents.DocumentLocation source = null, Azure.AI.Language.Documents.DocumentLocation target = null, string language = null) { throw null; }
        public static Azure.AI.Language.Documents.PiiEntityRecognitionOperationResult PiiEntityRecognitionOperationResult(System.DateTimeOffset lastUpdateDateTime = default(System.DateTimeOffset), Azure.AI.Language.Documents.DocumentActionState status = default(Azure.AI.Language.Documents.DocumentActionState), string taskName = null, Azure.AI.Language.Documents.AnalyzeDocumentsResult results = null) { throw null; }
        public static Azure.AI.Language.Documents.RequestStatistics RequestStatistics(int documentsCount = 0, int validDocumentsCount = 0, int erroneousDocumentsCount = 0, long transactionsCount = (long)0) { throw null; }
        public static Azure.AI.Language.Documents.SummaryContext SummaryContext(int offset = 0, int length = 0) { throw null; }
    }
    public partial class AnalyzeDocumentsClient
    {
        protected AnalyzeDocumentsClient() { }
        public AnalyzeDocumentsClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public AnalyzeDocumentsClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.AI.Language.Documents.AnalyzeDocumentsClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Operation AnalyzeDocumentsCancelOperation(Azure.WaitUntil waitUntil, System.Guid jobId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> AnalyzeDocumentsCancelOperationAsync(Azure.WaitUntil waitUntil, System.Guid jobId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation AnalyzeDocumentsSubmitOperation(Azure.WaitUntil waitUntil, Azure.AI.Language.Documents.AnalyzeDocumentsOperationInput analyzeDocumentOperationInput, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation AnalyzeDocumentsSubmitOperation(Azure.WaitUntil waitUntil, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> AnalyzeDocumentsSubmitOperationAsync(Azure.WaitUntil waitUntil, Azure.AI.Language.Documents.AnalyzeDocumentsOperationInput analyzeDocumentOperationInput, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> AnalyzeDocumentsSubmitOperationAsync(Azure.WaitUntil waitUntil, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetAnalyzeDocumentsJobStatus(System.Guid jobId, bool? showStats, int? top, int? skip, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Documents.AnalyzeDocumentsJobState> GetAnalyzeDocumentsJobStatus(System.Guid jobId, bool? showStats = default(bool?), int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetAnalyzeDocumentsJobStatusAsync(System.Guid jobId, bool? showStats, int? top, int? skip, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Documents.AnalyzeDocumentsJobState>> GetAnalyzeDocumentsJobStatusAsync(System.Guid jobId, bool? showStats = default(bool?), int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AnalyzeDocumentsClientOptions : Azure.Core.ClientOptions
    {
        public AnalyzeDocumentsClientOptions(Azure.AI.Language.Documents.AnalyzeDocumentsClientOptions.ServiceVersion version = Azure.AI.Language.Documents.AnalyzeDocumentsClientOptions.ServiceVersion.V2024_11_15_Preview) { }
        public enum ServiceVersion
        {
            V2024_11_15_Preview = 1,
        }
    }
    public partial class AnalyzeDocumentsDocumentError : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsDocumentError>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsDocumentError>
    {
        internal AnalyzeDocumentsDocumentError() { }
        public Azure.AI.Language.Documents.AnalyzeDocumentsError Error { get { throw null; } }
        public string Id { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AnalyzeDocumentsDocumentError System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsDocumentError>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsDocumentError>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AnalyzeDocumentsDocumentError System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsDocumentError>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsDocumentError>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsDocumentError>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AnalyzeDocumentsError : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsError>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsError>
    {
        internal AnalyzeDocumentsError() { }
        public Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode Code { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Documents.AnalyzeDocumentsError> Details { get { throw null; } }
        public Azure.AI.Language.Documents.InnerErrorModel Innererror { get { throw null; } }
        public string Message { get { throw null; } }
        public string Target { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AnalyzeDocumentsError System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsError>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsError>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AnalyzeDocumentsError System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsError>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsError>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsError>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AnalyzeDocumentsErrorCode : System.IEquatable<Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AnalyzeDocumentsErrorCode(string value) { throw null; }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode AzureCognitiveSearchIndexLimitReached { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode AzureCognitiveSearchIndexNotFound { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode AzureCognitiveSearchNotFound { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode AzureCognitiveSearchThrottling { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode Conflict { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode Forbidden { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode InternalServerError { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode InvalidArgument { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode InvalidRequest { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode NotFound { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode OperationNotFound { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode ProjectNotFound { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode QuotaExceeded { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode ServiceUnavailable { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode Timeout { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode TooManyRequests { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode Unauthorized { get { throw null; } }
        public static Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode Warning { get { throw null; } }
        public bool Equals(Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode left, Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode right) { throw null; }
        public static implicit operator Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode left, Azure.AI.Language.Documents.AnalyzeDocumentsErrorCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AnalyzeDocumentsJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsJobState>
    {
        internal AnalyzeDocumentsJobState() { }
        public System.DateTimeOffset CreatedAt { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Documents.AnalyzeDocumentsError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpiresOn { get { throw null; } }
        public System.Guid JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedAt { get { throw null; } }
        public string NextLink { get { throw null; } }
        public Azure.AI.Language.Documents.RequestStatistics Statistics { get { throw null; } }
        public Azure.AI.Language.Documents.DocumentActionState Status { get { throw null; } }
        public Azure.AI.Language.Documents.DocumentActions Tasks { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AnalyzeDocumentsJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AnalyzeDocumentsJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class AnalyzeDocumentsLROResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsLROResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsLROResult>
    {
        protected AnalyzeDocumentsLROResult(System.DateTimeOffset lastUpdateDateTime, Azure.AI.Language.Documents.DocumentActionState status) { }
        public System.DateTimeOffset LastUpdateDateTime { get { throw null; } }
        public Azure.AI.Language.Documents.DocumentActionState Status { get { throw null; } }
        public string TaskName { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AnalyzeDocumentsLROResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsLROResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsLROResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AnalyzeDocumentsLROResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsLROResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsLROResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsLROResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class AnalyzeDocumentsOperationAction : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsOperationAction>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsOperationAction>
    {
        protected AnalyzeDocumentsOperationAction() { }
        public string Name { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AnalyzeDocumentsOperationAction System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsOperationAction>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsOperationAction>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AnalyzeDocumentsOperationAction System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsOperationAction>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsOperationAction>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsOperationAction>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AnalyzeDocumentsOperationInput : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsOperationInput>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsOperationInput>
    {
        public AnalyzeDocumentsOperationInput(Azure.AI.Language.Documents.MultiLanguageDocumentInput documentsInput, System.Collections.Generic.IEnumerable<Azure.AI.Language.Documents.AnalyzeDocumentsOperationAction> actions) { }
        public System.Collections.Generic.IList<Azure.AI.Language.Documents.AnalyzeDocumentsOperationAction> Actions { get { throw null; } }
        public string DefaultLanguage { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public Azure.AI.Language.Documents.MultiLanguageDocumentInput DocumentsInput { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AnalyzeDocumentsOperationInput System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsOperationInput>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsOperationInput>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AnalyzeDocumentsOperationInput System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsOperationInput>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsOperationInput>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsOperationInput>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AnalyzeDocumentsResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsResult>
    {
        internal AnalyzeDocumentsResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Documents.DocumentAnalysisDocumentResult> Documents { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Documents.AnalyzeDocumentsDocumentError> Errors { get { throw null; } }
        public string ModelVersion { get { throw null; } }
        public Azure.AI.Language.Documents.RequestStatistics Statistics { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AnalyzeDocumentsResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AnalyzeDocumentsResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AnalyzeDocumentsResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AnalyzeDocumentsResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AzureBlobDocumentLocation : Azure.AI.Language.Documents.DocumentLocation, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AzureBlobDocumentLocation>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AzureBlobDocumentLocation>
    {
        public AzureBlobDocumentLocation(string location) { }
        public string Location { get { throw null; } set { } }
        public string ManagedIdentityClientId { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AzureBlobDocumentLocation System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AzureBlobDocumentLocation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.AzureBlobDocumentLocation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.AzureBlobDocumentLocation System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AzureBlobDocumentLocation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AzureBlobDocumentLocation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.AzureBlobDocumentLocation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class BaseRedactionPolicy : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.BaseRedactionPolicy>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.BaseRedactionPolicy>
    {
        protected BaseRedactionPolicy() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.BaseRedactionPolicy System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.BaseRedactionPolicy>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.BaseRedactionPolicy>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.BaseRedactionPolicy System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.BaseRedactionPolicy>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.BaseRedactionPolicy>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.BaseRedactionPolicy>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CharacterMaskPolicy : Azure.AI.Language.Documents.BaseRedactionPolicy, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.CharacterMaskPolicy>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.CharacterMaskPolicy>
    {
        public CharacterMaskPolicy() { }
        public Azure.AI.Language.Documents.RedactionCharacter? RedactionCharacter { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.CharacterMaskPolicy System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.CharacterMaskPolicy>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.CharacterMaskPolicy>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.CharacterMaskPolicy System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.CharacterMaskPolicy>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.CharacterMaskPolicy>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.CharacterMaskPolicy>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DetectedLanguage : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DetectedLanguage>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DetectedLanguage>
    {
        internal DetectedLanguage() { }
        public double ConfidenceScore { get { throw null; } }
        public string Iso6391Name { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.AI.Language.Documents.ScriptKind? Script { get { throw null; } }
        public Azure.AI.Language.Documents.ScriptCode? ScriptCode { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.DetectedLanguage System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DetectedLanguage>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DetectedLanguage>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.DetectedLanguage System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DetectedLanguage>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DetectedLanguage>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DetectedLanguage>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentActions : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentActions>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentActions>
    {
        internal DocumentActions() { }
        public int Completed { get { throw null; } }
        public int Failed { get { throw null; } }
        public int InProgress { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Documents.AnalyzeDocumentsLROResult> Items { get { throw null; } }
        public int Total { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.DocumentActions System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentActions>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentActions>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.DocumentActions System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentActions>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentActions>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentActions>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DocumentActionState : System.IEquatable<Azure.AI.Language.Documents.DocumentActionState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DocumentActionState(string value) { throw null; }
        public static Azure.AI.Language.Documents.DocumentActionState Cancelled { get { throw null; } }
        public static Azure.AI.Language.Documents.DocumentActionState Cancelling { get { throw null; } }
        public static Azure.AI.Language.Documents.DocumentActionState Failed { get { throw null; } }
        public static Azure.AI.Language.Documents.DocumentActionState NotStarted { get { throw null; } }
        public static Azure.AI.Language.Documents.DocumentActionState PartiallyCompleted { get { throw null; } }
        public static Azure.AI.Language.Documents.DocumentActionState Running { get { throw null; } }
        public static Azure.AI.Language.Documents.DocumentActionState Succeeded { get { throw null; } }
        public bool Equals(Azure.AI.Language.Documents.DocumentActionState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Documents.DocumentActionState left, Azure.AI.Language.Documents.DocumentActionState right) { throw null; }
        public static implicit operator Azure.AI.Language.Documents.DocumentActionState (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Documents.DocumentActionState left, Azure.AI.Language.Documents.DocumentActionState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DocumentAnalysisDocumentResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentAnalysisDocumentResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentAnalysisDocumentResult>
    {
        internal DocumentAnalysisDocumentResult() { }
        public string Id { get { throw null; } }
        public Azure.AI.Language.Documents.DocumentLocation Source { get { throw null; } }
        public Azure.AI.Language.Documents.DocumentStatistics Statistics { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Documents.DocumentLocation> Target { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Documents.DocumentWarning> Warnings { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.DocumentAnalysisDocumentResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentAnalysisDocumentResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentAnalysisDocumentResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.DocumentAnalysisDocumentResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentAnalysisDocumentResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentAnalysisDocumentResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentAnalysisDocumentResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentError : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentError>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentError>
    {
        internal DocumentError() { }
        public Azure.AI.Language.Documents.AnalyzeDocumentsError Error { get { throw null; } }
        public string Id { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.DocumentError System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentError>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentError>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.DocumentError System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentError>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentError>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentError>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class DocumentLocation : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentLocation>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentLocation>
    {
        protected DocumentLocation() { }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.DocumentLocation System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentLocation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentLocation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.DocumentLocation System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentLocation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentLocation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentLocation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentStatistics : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentStatistics>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentStatistics>
    {
        internal DocumentStatistics() { }
        public int CharactersCount { get { throw null; } }
        public int TransactionsCount { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.DocumentStatistics System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentStatistics>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentStatistics>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.DocumentStatistics System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentStatistics>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentStatistics>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentStatistics>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentWarning : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentWarning>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentWarning>
    {
        internal DocumentWarning() { }
        public Azure.AI.Language.Documents.WarningCode Code { get { throw null; } }
        public string Message { get { throw null; } }
        public string TargetRef { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.DocumentWarning System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentWarning>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.DocumentWarning>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.DocumentWarning System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentWarning>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentWarning>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.DocumentWarning>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EntityMaskPolicy : Azure.AI.Language.Documents.BaseRedactionPolicy, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.EntityMaskPolicy>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.EntityMaskPolicy>
    {
        public EntityMaskPolicy() { }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.EntityMaskPolicy System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.EntityMaskPolicy>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.EntityMaskPolicy>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.EntityMaskPolicy System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.EntityMaskPolicy>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.EntityMaskPolicy>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.EntityMaskPolicy>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExtractiveSummarizationActionContent : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.ExtractiveSummarizationActionContent>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.ExtractiveSummarizationActionContent>
    {
        public ExtractiveSummarizationActionContent() { }
        public bool? LoggingOptOut { get { throw null; } set { } }
        public string ModelVersion { get { throw null; } set { } }
        public string Query { get { throw null; } set { } }
        public long? SentenceCount { get { throw null; } set { } }
        public Azure.AI.Language.Documents.ExtractiveSummarizationSortingCriteria? SortBy { get { throw null; } set { } }
        public Azure.AI.Language.Documents.StringIndexType? StringIndexType { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.ExtractiveSummarizationActionContent System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.ExtractiveSummarizationActionContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.ExtractiveSummarizationActionContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.ExtractiveSummarizationActionContent System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.ExtractiveSummarizationActionContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.ExtractiveSummarizationActionContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.ExtractiveSummarizationActionContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExtractiveSummarizationOperationAction : Azure.AI.Language.Documents.AnalyzeDocumentsOperationAction, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.ExtractiveSummarizationOperationAction>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.ExtractiveSummarizationOperationAction>
    {
        public ExtractiveSummarizationOperationAction() { }
        public Azure.AI.Language.Documents.ExtractiveSummarizationActionContent ActionContent { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.ExtractiveSummarizationOperationAction System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.ExtractiveSummarizationOperationAction>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.ExtractiveSummarizationOperationAction>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.ExtractiveSummarizationOperationAction System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.ExtractiveSummarizationOperationAction>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.ExtractiveSummarizationOperationAction>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.ExtractiveSummarizationOperationAction>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExtractiveSummarizationOperationResult : Azure.AI.Language.Documents.AnalyzeDocumentsLROResult, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.ExtractiveSummarizationOperationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.ExtractiveSummarizationOperationResult>
    {
        internal ExtractiveSummarizationOperationResult() : base (default(System.DateTimeOffset), default(Azure.AI.Language.Documents.DocumentActionState)) { }
        public Azure.AI.Language.Documents.AnalyzeDocumentsResult Results { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.ExtractiveSummarizationOperationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.ExtractiveSummarizationOperationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.ExtractiveSummarizationOperationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.ExtractiveSummarizationOperationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.ExtractiveSummarizationOperationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.ExtractiveSummarizationOperationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.ExtractiveSummarizationOperationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ExtractiveSummarizationSortingCriteria : System.IEquatable<Azure.AI.Language.Documents.ExtractiveSummarizationSortingCriteria>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ExtractiveSummarizationSortingCriteria(string value) { throw null; }
        public static Azure.AI.Language.Documents.ExtractiveSummarizationSortingCriteria Offset { get { throw null; } }
        public static Azure.AI.Language.Documents.ExtractiveSummarizationSortingCriteria Rank { get { throw null; } }
        public bool Equals(Azure.AI.Language.Documents.ExtractiveSummarizationSortingCriteria other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Documents.ExtractiveSummarizationSortingCriteria left, Azure.AI.Language.Documents.ExtractiveSummarizationSortingCriteria right) { throw null; }
        public static implicit operator Azure.AI.Language.Documents.ExtractiveSummarizationSortingCriteria (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Documents.ExtractiveSummarizationSortingCriteria left, Azure.AI.Language.Documents.ExtractiveSummarizationSortingCriteria right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct InnerErrorCode : System.IEquatable<Azure.AI.Language.Documents.InnerErrorCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public InnerErrorCode(string value) { throw null; }
        public static Azure.AI.Language.Documents.InnerErrorCode AzureCognitiveSearchNotFound { get { throw null; } }
        public static Azure.AI.Language.Documents.InnerErrorCode AzureCognitiveSearchThrottling { get { throw null; } }
        public static Azure.AI.Language.Documents.InnerErrorCode EmptyRequest { get { throw null; } }
        public static Azure.AI.Language.Documents.InnerErrorCode ExtractionFailure { get { throw null; } }
        public static Azure.AI.Language.Documents.InnerErrorCode InvalidCountryHint { get { throw null; } }
        public static Azure.AI.Language.Documents.InnerErrorCode InvalidDocument { get { throw null; } }
        public static Azure.AI.Language.Documents.InnerErrorCode InvalidDocumentBatch { get { throw null; } }
        public static Azure.AI.Language.Documents.InnerErrorCode InvalidParameterValue { get { throw null; } }
        public static Azure.AI.Language.Documents.InnerErrorCode InvalidRequest { get { throw null; } }
        public static Azure.AI.Language.Documents.InnerErrorCode InvalidRequestBodyFormat { get { throw null; } }
        public static Azure.AI.Language.Documents.InnerErrorCode KnowledgeBaseNotFound { get { throw null; } }
        public static Azure.AI.Language.Documents.InnerErrorCode MissingInputDocuments { get { throw null; } }
        public static Azure.AI.Language.Documents.InnerErrorCode ModelVersionIncorrect { get { throw null; } }
        public static Azure.AI.Language.Documents.InnerErrorCode UnsupportedLanguageCode { get { throw null; } }
        public bool Equals(Azure.AI.Language.Documents.InnerErrorCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Documents.InnerErrorCode left, Azure.AI.Language.Documents.InnerErrorCode right) { throw null; }
        public static implicit operator Azure.AI.Language.Documents.InnerErrorCode (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Documents.InnerErrorCode left, Azure.AI.Language.Documents.InnerErrorCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class InnerErrorModel : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.InnerErrorModel>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.InnerErrorModel>
    {
        internal InnerErrorModel() { }
        public Azure.AI.Language.Documents.InnerErrorCode Code { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Details { get { throw null; } }
        public Azure.AI.Language.Documents.InnerErrorModel Innererror { get { throw null; } }
        public string Message { get { throw null; } }
        public string Target { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.InnerErrorModel System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.InnerErrorModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.InnerErrorModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.InnerErrorModel System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.InnerErrorModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.InnerErrorModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.InnerErrorModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MultiLanguageDocumentInput : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.MultiLanguageDocumentInput>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.MultiLanguageDocumentInput>
    {
        public MultiLanguageDocumentInput() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Documents.MultiLanguageInput> Documents { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.MultiLanguageDocumentInput System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.MultiLanguageDocumentInput>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.MultiLanguageDocumentInput>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.MultiLanguageDocumentInput System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.MultiLanguageDocumentInput>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.MultiLanguageDocumentInput>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.MultiLanguageDocumentInput>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MultiLanguageInput : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.MultiLanguageInput>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.MultiLanguageInput>
    {
        public MultiLanguageInput(string id, Azure.AI.Language.Documents.DocumentLocation source, Azure.AI.Language.Documents.DocumentLocation target) { }
        public string Id { get { throw null; } }
        public string Language { get { throw null; } set { } }
        public Azure.AI.Language.Documents.DocumentLocation Source { get { throw null; } }
        public Azure.AI.Language.Documents.DocumentLocation Target { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.MultiLanguageInput System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.MultiLanguageInput>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.MultiLanguageInput>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.MultiLanguageInput System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.MultiLanguageInput>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.MultiLanguageInput>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.MultiLanguageInput>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class NoMaskPolicy : Azure.AI.Language.Documents.BaseRedactionPolicy, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.NoMaskPolicy>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.NoMaskPolicy>
    {
        public NoMaskPolicy() { }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.NoMaskPolicy System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.NoMaskPolicy>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.NoMaskPolicy>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.NoMaskPolicy System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.NoMaskPolicy>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.NoMaskPolicy>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.NoMaskPolicy>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PiiActionContent : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.PiiActionContent>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.PiiActionContent>
    {
        public PiiActionContent() { }
        public Azure.AI.Language.Documents.PiiDomain? Domain { get { throw null; } set { } }
        public bool? ExcludeExtractionData { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.Language.Documents.PiiCategoriesExclude> ExcludePiiCategories { get { throw null; } }
        public bool? LoggingOptOut { get { throw null; } set { } }
        public string ModelVersion { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.Language.Documents.PiiCategory> PiiCategories { get { throw null; } }
        public Azure.AI.Language.Documents.BaseRedactionPolicy RedactionPolicy { get { throw null; } set { } }
        public Azure.AI.Language.Documents.StringIndexType? StringIndexType { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.PiiActionContent System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.PiiActionContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.PiiActionContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.PiiActionContent System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.PiiActionContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.PiiActionContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.PiiActionContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PiiCategoriesExclude : System.IEquatable<Azure.AI.Language.Documents.PiiCategoriesExclude>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PiiCategoriesExclude(string value) { throw null; }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AbaRoutingNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude Address { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude Age { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude ArNationalIdentityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AtIdentityCard { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AtTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AtValueAddedTaxNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AuBankAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AuBusinessNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AuCompanyNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AuDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AuMedicalAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AuPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AuTaxFileNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AzureDocumentDbauthKey { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AzureIaasDatabaseConnectionAndSqlString { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AzureIoTConnectionString { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AzurePublishSettingPassword { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AzureRedisCacheString { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AzureSas { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AzureServiceBusString { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AzureStorageAccountGeneric { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude AzureStorageAccountKey { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude BeNationalNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude BeNationalNumberV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude BeValueAddedTaxNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude BgUniformCivilNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude BrCpfNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude BrLegalEntityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude BrNationalIdRg { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude CaBankAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude CaDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude CaHealthServiceNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude CaPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude CaPersonalHealthIdentification { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude CaSocialInsuranceNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude ChSocialSecurityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude ClIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude CnResidentIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude CreditCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude CyIdentityCard { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude CyTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude CzPersonalIdentityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude CzPersonalIdentityV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude Date { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude DeDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude DeIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude DePassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude DeTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude DeValueAddedNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude DkPersonalIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude DkPersonalIdentificationV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude DrugEnforcementAgencyNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude EePersonalIdentificationCode { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude Email { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude EsDni { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude EsSocialSecurityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude EsTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude EuDebitCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude EuDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude EuGpsCoordinates { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude EuNationalIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude EuPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude EuSocialSecurityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude EuTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude FiEuropeanHealthNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude FiNationalId { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude FiNationalIdV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude FiPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude FrDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude FrHealthInsuranceNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude FrNationalId { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude FrPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude FrSocialSecurityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude FrTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude FrValueAddedTaxNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude GrNationalIdCard { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude GrNationalIdV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude GrTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude HkIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude HrIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude HrNationalIdNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude HrPersonalIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude HrPersonalIdentificationOIBNumberV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude HuPersonalIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude HuTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude HuValueAddedNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude IdIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude IePersonalPublicServiceNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude IePersonalPublicServiceNumberV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude IlBankAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude IlNationalId { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude InPermanentAccount { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude InternationalBankingAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude InUniqueIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude IPAddress { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude ItDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude ItFiscalCode { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude ItValueAddedTaxNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude JpBankAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude JpDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude JpMyNumberCorporate { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude JpMyNumberPersonal { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude JpPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude JpResidenceCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude JpResidentRegistrationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude JpSocialInsuranceNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude KrResidentRegistrationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude LtPersonalCode { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude LuNationalIdentificationNumberNatural { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude LuNationalIdentificationNumberNonNatural { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude LvPersonalCode { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude MtIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude MtTaxIdNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude MyIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude NlCitizensServiceNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude NlCitizensServiceNumberV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude NlTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude NlValueAddedTaxNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude NoIdentityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude NzBankAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude NzDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude NzInlandRevenueNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude NzMinistryOfHealthNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude NzSocialWelfareNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude Organization { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude Person { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude PhoneNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude PhUnifiedMultiPurposeIdNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude PlIdentityCard { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude PlNationalId { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude PlNationalIdV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude PlPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude PlRegonNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude PlTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude PtCitizenCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude PtCitizenCardNumberV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude PtTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude RoPersonalNumericalCode { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude RuPassportNumberDomestic { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude RuPassportNumberInternational { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude SaNationalId { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude SeNationalId { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude SeNationalIdV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude SePassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude SeTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude SgNationalRegistrationIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude SiTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude SiUniqueMasterCitizenNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude SkPersonalNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude SqlServerConnectionString { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude SwiftCode { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude ThPopulationIdentificationCode { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude TrNationalIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude TwNationalId { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude TwPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude TwResidentCertificate { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude UaPassportNumberDomestic { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude UaPassportNumberInternational { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude UkDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude UkElectoralRollNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude UkNationalHealthNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude UkNationalInsuranceNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude UkUniqueTaxpayerNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude URL { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude UsBankAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude UsDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude UsIndividualTaxpayerIdentification { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude UsSocialSecurityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude UsUkPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategoriesExclude ZaIdentificationNumber { get { throw null; } }
        public bool Equals(Azure.AI.Language.Documents.PiiCategoriesExclude other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Documents.PiiCategoriesExclude left, Azure.AI.Language.Documents.PiiCategoriesExclude right) { throw null; }
        public static implicit operator Azure.AI.Language.Documents.PiiCategoriesExclude (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Documents.PiiCategoriesExclude left, Azure.AI.Language.Documents.PiiCategoriesExclude right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PiiCategory : System.IEquatable<Azure.AI.Language.Documents.PiiCategory>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PiiCategory(string value) { throw null; }
        public static Azure.AI.Language.Documents.PiiCategory AbaRoutingNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory Address { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory Age { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory All { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory ArNationalIdentityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AtIdentityCard { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AtTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AtValueAddedTaxNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AuBankAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AuBusinessNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AuCompanyNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AuDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AuMedicalAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AuPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AuTaxFileNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AzureDocumentDbauthKey { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AzureIaasDatabaseConnectionAndSqlString { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AzureIoTConnectionString { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AzurePublishSettingPassword { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AzureRedisCacheString { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AzureSas { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AzureServiceBusString { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AzureStorageAccountGeneric { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory AzureStorageAccountKey { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory BeNationalNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory BeNationalNumberV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory BeValueAddedTaxNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory BgUniformCivilNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory BrCpfNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory BrLegalEntityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory BrNationalIdRg { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory CaBankAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory CaDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory CaHealthServiceNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory CaPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory CaPersonalHealthIdentification { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory CaSocialInsuranceNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory ChSocialSecurityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory ClIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory CnResidentIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory CreditCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory CyIdentityCard { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory CyTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory CzPersonalIdentityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory CzPersonalIdentityV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory Date { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory DeDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory Default { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory DeIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory DePassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory DeTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory DeValueAddedNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory DkPersonalIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory DkPersonalIdentificationV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory DrugEnforcementAgencyNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory EePersonalIdentificationCode { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory Email { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory EsDni { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory EsSocialSecurityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory EsTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory EuDebitCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory EuDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory EuGpsCoordinates { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory EuNationalIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory EuPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory EuSocialSecurityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory EuTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory FiEuropeanHealthNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory FiNationalId { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory FiNationalIdV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory FiPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory FrDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory FrHealthInsuranceNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory FrNationalId { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory FrPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory FrSocialSecurityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory FrTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory FrValueAddedTaxNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory GrNationalIdCard { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory GrNationalIdV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory GrTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory HkIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory HrIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory HrNationalIdNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory HrPersonalIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory HrPersonalIdentificationOIBNumberV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory HuPersonalIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory HuTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory HuValueAddedNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory IdIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory IePersonalPublicServiceNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory IePersonalPublicServiceNumberV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory IlBankAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory IlNationalId { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory InPermanentAccount { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory InternationalBankingAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory InUniqueIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory IPAddress { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory ItDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory ItFiscalCode { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory ItValueAddedTaxNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory JpBankAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory JpDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory JpMyNumberCorporate { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory JpMyNumberPersonal { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory JpPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory JpResidenceCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory JpResidentRegistrationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory JpSocialInsuranceNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory KrResidentRegistrationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory LtPersonalCode { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory LuNationalIdentificationNumberNatural { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory LuNationalIdentificationNumberNonNatural { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory LvPersonalCode { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory MtIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory MtTaxIdNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory MyIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory NlCitizensServiceNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory NlCitizensServiceNumberV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory NlTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory NlValueAddedTaxNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory NoIdentityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory NzBankAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory NzDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory NzInlandRevenueNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory NzMinistryOfHealthNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory NzSocialWelfareNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory Organization { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory Person { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory PhoneNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory PhUnifiedMultiPurposeIdNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory PlIdentityCard { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory PlNationalId { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory PlNationalIdV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory PlPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory PlRegonNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory PlTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory PtCitizenCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory PtCitizenCardNumberV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory PtTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory RoPersonalNumericalCode { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory RuPassportNumberDomestic { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory RuPassportNumberInternational { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory SaNationalId { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory SeNationalId { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory SeNationalIdV2 { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory SePassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory SeTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory SgNationalRegistrationIdentityCardNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory SiTaxIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory SiUniqueMasterCitizenNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory SkPersonalNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory SqlServerConnectionString { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory SwiftCode { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory ThPopulationIdentificationCode { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory TrNationalIdentificationNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory TwNationalId { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory TwPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory TwResidentCertificate { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory UaPassportNumberDomestic { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory UaPassportNumberInternational { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory UkDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory UkElectoralRollNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory UkNationalHealthNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory UkNationalInsuranceNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory UkUniqueTaxpayerNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory URL { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory UsBankAccountNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory UsDriversLicenseNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory UsIndividualTaxpayerIdentification { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory UsSocialSecurityNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory UsUkPassportNumber { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiCategory ZaIdentificationNumber { get { throw null; } }
        public bool Equals(Azure.AI.Language.Documents.PiiCategory other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Documents.PiiCategory left, Azure.AI.Language.Documents.PiiCategory right) { throw null; }
        public static implicit operator Azure.AI.Language.Documents.PiiCategory (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Documents.PiiCategory left, Azure.AI.Language.Documents.PiiCategory right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PiiDomain : System.IEquatable<Azure.AI.Language.Documents.PiiDomain>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PiiDomain(string value) { throw null; }
        public static Azure.AI.Language.Documents.PiiDomain None { get { throw null; } }
        public static Azure.AI.Language.Documents.PiiDomain Phi { get { throw null; } }
        public bool Equals(Azure.AI.Language.Documents.PiiDomain other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Documents.PiiDomain left, Azure.AI.Language.Documents.PiiDomain right) { throw null; }
        public static implicit operator Azure.AI.Language.Documents.PiiDomain (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Documents.PiiDomain left, Azure.AI.Language.Documents.PiiDomain right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PiiEntityRecognitionOperationResult : Azure.AI.Language.Documents.AnalyzeDocumentsLROResult, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.PiiEntityRecognitionOperationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.PiiEntityRecognitionOperationResult>
    {
        internal PiiEntityRecognitionOperationResult() : base (default(System.DateTimeOffset), default(Azure.AI.Language.Documents.DocumentActionState)) { }
        public Azure.AI.Language.Documents.AnalyzeDocumentsResult Results { get { throw null; } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.PiiEntityRecognitionOperationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.PiiEntityRecognitionOperationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.PiiEntityRecognitionOperationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.PiiEntityRecognitionOperationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.PiiEntityRecognitionOperationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.PiiEntityRecognitionOperationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.PiiEntityRecognitionOperationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PiiLROTask : Azure.AI.Language.Documents.AnalyzeDocumentsOperationAction, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.PiiLROTask>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.PiiLROTask>
    {
        public PiiLROTask() { }
        public Azure.AI.Language.Documents.PiiActionContent Parameters { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.PiiLROTask System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.PiiLROTask>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.PiiLROTask>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.PiiLROTask System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.PiiLROTask>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.PiiLROTask>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.PiiLROTask>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RedactionCharacter : System.IEquatable<Azure.AI.Language.Documents.RedactionCharacter>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RedactionCharacter(string value) { throw null; }
        public static Azure.AI.Language.Documents.RedactionCharacter Ampersand { get { throw null; } }
        public static Azure.AI.Language.Documents.RedactionCharacter Asterisk { get { throw null; } }
        public static Azure.AI.Language.Documents.RedactionCharacter AtSign { get { throw null; } }
        public static Azure.AI.Language.Documents.RedactionCharacter Caret { get { throw null; } }
        public static Azure.AI.Language.Documents.RedactionCharacter Dollar { get { throw null; } }
        public static Azure.AI.Language.Documents.RedactionCharacter EqualsValue { get { throw null; } }
        public static Azure.AI.Language.Documents.RedactionCharacter ExclamationPoint { get { throw null; } }
        public static Azure.AI.Language.Documents.RedactionCharacter Minus { get { throw null; } }
        public static Azure.AI.Language.Documents.RedactionCharacter NumberSign { get { throw null; } }
        public static Azure.AI.Language.Documents.RedactionCharacter PerCent { get { throw null; } }
        public static Azure.AI.Language.Documents.RedactionCharacter Plus { get { throw null; } }
        public static Azure.AI.Language.Documents.RedactionCharacter QuestionMark { get { throw null; } }
        public static Azure.AI.Language.Documents.RedactionCharacter Tilde { get { throw null; } }
        public static Azure.AI.Language.Documents.RedactionCharacter Underscore { get { throw null; } }
        public bool Equals(Azure.AI.Language.Documents.RedactionCharacter other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Documents.RedactionCharacter left, Azure.AI.Language.Documents.RedactionCharacter right) { throw null; }
        public static implicit operator Azure.AI.Language.Documents.RedactionCharacter (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Documents.RedactionCharacter left, Azure.AI.Language.Documents.RedactionCharacter right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RequestStatistics : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.RequestStatistics>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.RequestStatistics>
    {
        internal RequestStatistics() { }
        public int DocumentsCount { get { throw null; } }
        public int ErroneousDocumentsCount { get { throw null; } }
        public long TransactionsCount { get { throw null; } }
        public int ValidDocumentsCount { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.RequestStatistics System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.RequestStatistics>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.RequestStatistics>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.RequestStatistics System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.RequestStatistics>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.RequestStatistics>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.RequestStatistics>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ScriptCode : System.IEquatable<Azure.AI.Language.Documents.ScriptCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ScriptCode(string value) { throw null; }
        public static Azure.AI.Language.Documents.ScriptCode Arab { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Armn { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Beng { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Cans { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Cyrl { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Deva { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Ethi { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Geor { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Grek { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Gujr { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Guru { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Hang { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Hans { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Hant { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Hebr { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Jpan { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Khmr { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Knda { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Laoo { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Latn { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Mlym { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Mymr { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Orya { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Sinh { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Taml { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Telu { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Thaa { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Thai { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptCode Tibt { get { throw null; } }
        public bool Equals(Azure.AI.Language.Documents.ScriptCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Documents.ScriptCode left, Azure.AI.Language.Documents.ScriptCode right) { throw null; }
        public static implicit operator Azure.AI.Language.Documents.ScriptCode (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Documents.ScriptCode left, Azure.AI.Language.Documents.ScriptCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ScriptKind : System.IEquatable<Azure.AI.Language.Documents.ScriptKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ScriptKind(string value) { throw null; }
        public static Azure.AI.Language.Documents.ScriptKind Arabic { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Armenian { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Bangla { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Cyrillic { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Devanagari { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Ethiopic { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Georgian { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Greek { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Gujarati { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Gurmukhi { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Hangul { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind HanSimplified { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind HanTraditional { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Hebrew { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Japanese { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Kannada { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Khmer { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Lao { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Latin { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Malayalam { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Myanmar { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Odia { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Sinhala { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Tamil { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Telugu { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Thaana { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Thai { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind Tibetan { get { throw null; } }
        public static Azure.AI.Language.Documents.ScriptKind UnifiedCanadianAboriginalSyllabics { get { throw null; } }
        public bool Equals(Azure.AI.Language.Documents.ScriptKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Documents.ScriptKind left, Azure.AI.Language.Documents.ScriptKind right) { throw null; }
        public static implicit operator Azure.AI.Language.Documents.ScriptKind (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Documents.ScriptKind left, Azure.AI.Language.Documents.ScriptKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct StringIndexType : System.IEquatable<Azure.AI.Language.Documents.StringIndexType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public StringIndexType(string value) { throw null; }
        public static Azure.AI.Language.Documents.StringIndexType TextElementsV8 { get { throw null; } }
        public static Azure.AI.Language.Documents.StringIndexType UnicodeCodePoint { get { throw null; } }
        public static Azure.AI.Language.Documents.StringIndexType Utf16CodeUnit { get { throw null; } }
        public bool Equals(Azure.AI.Language.Documents.StringIndexType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Documents.StringIndexType left, Azure.AI.Language.Documents.StringIndexType right) { throw null; }
        public static implicit operator Azure.AI.Language.Documents.StringIndexType (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Documents.StringIndexType left, Azure.AI.Language.Documents.StringIndexType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SummaryContext : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.SummaryContext>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.SummaryContext>
    {
        internal SummaryContext() { }
        public int Length { get { throw null; } }
        public int Offset { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.SummaryContext System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.SummaryContext>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Documents.SummaryContext>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Documents.SummaryContext System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.SummaryContext>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.SummaryContext>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Documents.SummaryContext>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SummaryLengthBucket : System.IEquatable<Azure.AI.Language.Documents.SummaryLengthBucket>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SummaryLengthBucket(string value) { throw null; }
        public static Azure.AI.Language.Documents.SummaryLengthBucket Long { get { throw null; } }
        public static Azure.AI.Language.Documents.SummaryLengthBucket Medium { get { throw null; } }
        public static Azure.AI.Language.Documents.SummaryLengthBucket Short { get { throw null; } }
        public bool Equals(Azure.AI.Language.Documents.SummaryLengthBucket other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Documents.SummaryLengthBucket left, Azure.AI.Language.Documents.SummaryLengthBucket right) { throw null; }
        public static implicit operator Azure.AI.Language.Documents.SummaryLengthBucket (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Documents.SummaryLengthBucket left, Azure.AI.Language.Documents.SummaryLengthBucket right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WarningCode : System.IEquatable<Azure.AI.Language.Documents.WarningCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WarningCode(string value) { throw null; }
        public static Azure.AI.Language.Documents.WarningCode DocumentTruncated { get { throw null; } }
        public static Azure.AI.Language.Documents.WarningCode LongWordsInDocument { get { throw null; } }
        public bool Equals(Azure.AI.Language.Documents.WarningCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Documents.WarningCode left, Azure.AI.Language.Documents.WarningCode right) { throw null; }
        public static implicit operator Azure.AI.Language.Documents.WarningCode (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Documents.WarningCode left, Azure.AI.Language.Documents.WarningCode right) { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class AILanguageDocumentsClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Language.Documents.AnalyzeDocumentsClient, Azure.AI.Language.Documents.AnalyzeDocumentsClientOptions> AddAnalyzeDocumentsClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Language.Documents.AnalyzeDocumentsClient, Azure.AI.Language.Documents.AnalyzeDocumentsClientOptions> AddAnalyzeDocumentsClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
