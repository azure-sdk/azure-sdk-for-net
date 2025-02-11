namespace Azure.AI.SpeechToText.BatchTranscription
{
    public static partial class AISpeechToTextBatchTranscriptionModelFactory
    {
        public static Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription AsynchronousTranscription(Azure.AI.SpeechToText.BatchTranscription.TranscriptionLinks links = null, Azure.AI.SpeechToText.BatchTranscription.TranscriptionProperties properties = null, System.Uri self = null, Azure.AI.SpeechToText.BatchTranscription.EntityReference model = null, Azure.AI.SpeechToText.BatchTranscription.EntityReference dataset = null, System.Collections.Generic.IEnumerable<System.Uri> contentUrls = null, System.Uri contentContainerUrl = null, string locale = null, string displayName = null, string description = null, System.Collections.Generic.IDictionary<string, string> customProperties = null, System.DateTimeOffset? lastActionDateTime = default(System.DateTimeOffset?), Azure.AI.SpeechToText.BatchTranscription.ApiStatus? status = default(Azure.AI.SpeechToText.BatchTranscription.ApiStatus?), System.DateTimeOffset? createdDateTime = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.AI.SpeechToText.BatchTranscription.EntityError EntityError(string code = null, string message = null) { throw null; }
        public static Azure.AI.SpeechToText.BatchTranscription.FileLinks FileLinks(System.Uri contentUrl = null) { throw null; }
        public static Azure.AI.SpeechToText.BatchTranscription.FileProperties FileProperties(int durationMilliseconds = 0, int size = 0) { throw null; }
        public static Azure.AI.SpeechToText.BatchTranscription.PageableFile PageableFile(System.Collections.Generic.IEnumerable<Azure.AI.SpeechToText.BatchTranscription.TranscriptionFile> values = null, System.Uri nextLink = null) { throw null; }
        public static Azure.AI.SpeechToText.BatchTranscription.PageableTranscription PageableTranscription(System.Collections.Generic.IEnumerable<Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription> values = null, System.Uri nextLink = null) { throw null; }
        public static Azure.AI.SpeechToText.BatchTranscription.TranscriptionFile TranscriptionFile(System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), Azure.AI.SpeechToText.BatchTranscription.FileKind kind = default(Azure.AI.SpeechToText.BatchTranscription.FileKind), Azure.AI.SpeechToText.BatchTranscription.FileLinks links = null, string name = null, Azure.AI.SpeechToText.BatchTranscription.FileProperties properties = null, System.Uri self = null) { throw null; }
        public static Azure.AI.SpeechToText.BatchTranscription.TranscriptionLinks TranscriptionLinks(System.Uri files = null) { throw null; }
        public static Azure.AI.SpeechToText.BatchTranscription.TranscriptionProperties TranscriptionProperties(bool? wordLevelTimestampsEnabled = default(bool?), bool? displayFormWordLevelTimestampsEnabled = default(bool?), int? durationMilliseconds = default(int?), System.Collections.Generic.IEnumerable<int> channels = null, System.Uri destinationContainerUrl = null, Azure.AI.SpeechToText.BatchTranscription.PunctuationMode? punctuationMode = default(Azure.AI.SpeechToText.BatchTranscription.PunctuationMode?), Azure.AI.SpeechToText.BatchTranscription.ProfanityFilterMode? profanityFilterMode = default(Azure.AI.SpeechToText.BatchTranscription.ProfanityFilterMode?), int timeToLiveHours = 0, Azure.AI.SpeechToText.BatchTranscription.EntityError error = null, Azure.AI.SpeechToText.BatchTranscription.DiarizationProperties diarization = null, Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationProperties languageIdentification = null) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ApiStatus : System.IEquatable<Azure.AI.SpeechToText.BatchTranscription.ApiStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ApiStatus(string value) { throw null; }
        public static Azure.AI.SpeechToText.BatchTranscription.ApiStatus Failed { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.ApiStatus NotStarted { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.ApiStatus Running { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.ApiStatus Succeeded { get { throw null; } }
        public bool Equals(Azure.AI.SpeechToText.BatchTranscription.ApiStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.SpeechToText.BatchTranscription.ApiStatus left, Azure.AI.SpeechToText.BatchTranscription.ApiStatus right) { throw null; }
        public static implicit operator Azure.AI.SpeechToText.BatchTranscription.ApiStatus (string value) { throw null; }
        public static bool operator !=(Azure.AI.SpeechToText.BatchTranscription.ApiStatus left, Azure.AI.SpeechToText.BatchTranscription.ApiStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AsynchronousTranscription : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription>
    {
        public AsynchronousTranscription(Azure.AI.SpeechToText.BatchTranscription.TranscriptionProperties properties, string locale, string displayName) { }
        public System.Uri ContentContainerUrl { get { throw null; } set { } }
        public System.Collections.Generic.IList<System.Uri> ContentUrls { get { throw null; } }
        public System.DateTimeOffset? CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> CustomProperties { get { throw null; } }
        public Azure.AI.SpeechToText.BatchTranscription.EntityReference Dataset { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public System.DateTimeOffset? LastActionDateTime { get { throw null; } }
        public Azure.AI.SpeechToText.BatchTranscription.TranscriptionLinks Links { get { throw null; } set { } }
        public string Locale { get { throw null; } set { } }
        public Azure.AI.SpeechToText.BatchTranscription.EntityReference Model { get { throw null; } set { } }
        public Azure.AI.SpeechToText.BatchTranscription.TranscriptionProperties Properties { get { throw null; } set { } }
        public System.Uri Self { get { throw null; } }
        public Azure.AI.SpeechToText.BatchTranscription.ApiStatus? Status { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BatchTranscription
    {
        protected BatchTranscription() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response DeleteTranscription(string id, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteTranscriptionAsync(string id, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetTranscription(string id, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription> GetTranscription(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTranscriptionAsync(string id, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription>> GetTranscriptionAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetTranscriptionFiles(string id, int? skip, int? top, int? sasLifetimeMinutes, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.SpeechToText.BatchTranscription.PageableFile> GetTranscriptionFiles(string id, int? skip = default(int?), int? top = default(int?), int? sasLifetimeMinutes = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTranscriptionFilesAsync(string id, int? skip, int? top, int? sasLifetimeMinutes, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.SpeechToText.BatchTranscription.PageableFile>> GetTranscriptionFilesAsync(string id, int? skip = default(int?), int? top = default(int?), int? sasLifetimeMinutes = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetTranscriptions(int? skip, int? top, string filter, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.SpeechToText.BatchTranscription.PageableTranscription> GetTranscriptions(int? skip = default(int?), int? top = default(int?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTranscriptionsAsync(int? skip, int? top, string filter, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.SpeechToText.BatchTranscription.PageableTranscription>> GetTranscriptionsAsync(int? skip = default(int?), int? top = default(int?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response PatchTranscription(string id, Azure.Core.RequestContent content, Azure.Core.ContentType contentType, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PatchTranscriptionAsync(string id, Azure.Core.RequestContent content, Azure.Core.ContentType contentType, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription> SubmitTranscription(Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription transcription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response SubmitTranscription(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription>> SubmitTranscriptionAsync(Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription transcription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SubmitTranscriptionAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
    public partial class ClientCustomizations
    {
        protected ClientCustomizations() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class DiarizationProperties : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.DiarizationProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.DiarizationProperties>
    {
        public DiarizationProperties(bool enabled, int maxSpeakers) { }
        public bool Enabled { get { throw null; } set { } }
        public int MaxSpeakers { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.DiarizationProperties System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.DiarizationProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.DiarizationProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.DiarizationProperties System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.DiarizationProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.DiarizationProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.DiarizationProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EntityError : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.EntityError>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.EntityError>
    {
        public EntityError() { }
        public string Code { get { throw null; } }
        public string Message { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.EntityError System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.EntityError>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.EntityError>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.EntityError System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.EntityError>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.EntityError>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.EntityError>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EntityReference : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.EntityReference>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.EntityReference>
    {
        public EntityReference(System.Uri self) { }
        public System.Uri Self { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.EntityReference System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.EntityReference>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.EntityReference>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.EntityReference System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.EntityReference>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.EntityReference>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.EntityReference>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct FileKind : System.IEquatable<Azure.AI.SpeechToText.BatchTranscription.FileKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public FileKind(string value) { throw null; }
        public static Azure.AI.SpeechToText.BatchTranscription.FileKind AcousticDataArchive { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.FileKind AcousticDataTranscriptionV2 { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.FileKind Audio { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.FileKind DatasetReport { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.FileKind EvaluationDetails { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.FileKind LanguageData { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.FileKind ModelReport { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.FileKind OutputFormattingData { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.FileKind PronunciationData { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.FileKind Transcription { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.FileKind TranscriptionReport { get { throw null; } }
        public bool Equals(Azure.AI.SpeechToText.BatchTranscription.FileKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.SpeechToText.BatchTranscription.FileKind left, Azure.AI.SpeechToText.BatchTranscription.FileKind right) { throw null; }
        public static implicit operator Azure.AI.SpeechToText.BatchTranscription.FileKind (string value) { throw null; }
        public static bool operator !=(Azure.AI.SpeechToText.BatchTranscription.FileKind left, Azure.AI.SpeechToText.BatchTranscription.FileKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class FileLinks : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.FileLinks>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.FileLinks>
    {
        internal FileLinks() { }
        public System.Uri ContentUrl { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.FileLinks System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.FileLinks>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.FileLinks>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.FileLinks System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.FileLinks>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.FileLinks>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.FileLinks>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FileProperties : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.FileProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.FileProperties>
    {
        internal FileProperties() { }
        public int DurationMilliseconds { get { throw null; } }
        public int Size { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.FileProperties System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.FileProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.FileProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.FileProperties System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.FileProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.FileProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.FileProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LanguageIdentificationMode : System.IEquatable<Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LanguageIdentificationMode(string value) { throw null; }
        public static Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationMode Continuous { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationMode Single { get { throw null; } }
        public bool Equals(Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationMode left, Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationMode right) { throw null; }
        public static implicit operator Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationMode (string value) { throw null; }
        public static bool operator !=(Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationMode left, Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LanguageIdentificationProperties : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationProperties>
    {
        public LanguageIdentificationProperties(System.Collections.Generic.IEnumerable<string> candidateLocales) { }
        public System.Collections.Generic.IList<string> CandidateLocales { get { throw null; } }
        public Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationMode? Mode { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.AI.SpeechToText.BatchTranscription.EntityReference> SpeechModelMapping { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationProperties System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationProperties System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PageableFile : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.PageableFile>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.PageableFile>
    {
        internal PageableFile() { }
        public System.Uri NextLink { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.SpeechToText.BatchTranscription.TranscriptionFile> Values { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.PageableFile System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.PageableFile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.PageableFile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.PageableFile System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.PageableFile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.PageableFile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.PageableFile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PageableTranscription : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.PageableTranscription>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.PageableTranscription>
    {
        internal PageableTranscription() { }
        public System.Uri NextLink { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.SpeechToText.BatchTranscription.AsynchronousTranscription> Values { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.PageableTranscription System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.PageableTranscription>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.PageableTranscription>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.PageableTranscription System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.PageableTranscription>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.PageableTranscription>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.PageableTranscription>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProfanityFilterMode : System.IEquatable<Azure.AI.SpeechToText.BatchTranscription.ProfanityFilterMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProfanityFilterMode(string value) { throw null; }
        public static Azure.AI.SpeechToText.BatchTranscription.ProfanityFilterMode Masked { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.ProfanityFilterMode None { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.ProfanityFilterMode Removed { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.ProfanityFilterMode Tags { get { throw null; } }
        public bool Equals(Azure.AI.SpeechToText.BatchTranscription.ProfanityFilterMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.SpeechToText.BatchTranscription.ProfanityFilterMode left, Azure.AI.SpeechToText.BatchTranscription.ProfanityFilterMode right) { throw null; }
        public static implicit operator Azure.AI.SpeechToText.BatchTranscription.ProfanityFilterMode (string value) { throw null; }
        public static bool operator !=(Azure.AI.SpeechToText.BatchTranscription.ProfanityFilterMode left, Azure.AI.SpeechToText.BatchTranscription.ProfanityFilterMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PunctuationMode : System.IEquatable<Azure.AI.SpeechToText.BatchTranscription.PunctuationMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PunctuationMode(string value) { throw null; }
        public static Azure.AI.SpeechToText.BatchTranscription.PunctuationMode Automatic { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.PunctuationMode Dictated { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.PunctuationMode DictatedAndAutomatic { get { throw null; } }
        public static Azure.AI.SpeechToText.BatchTranscription.PunctuationMode None { get { throw null; } }
        public bool Equals(Azure.AI.SpeechToText.BatchTranscription.PunctuationMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.SpeechToText.BatchTranscription.PunctuationMode left, Azure.AI.SpeechToText.BatchTranscription.PunctuationMode right) { throw null; }
        public static implicit operator Azure.AI.SpeechToText.BatchTranscription.PunctuationMode (string value) { throw null; }
        public static bool operator !=(Azure.AI.SpeechToText.BatchTranscription.PunctuationMode left, Azure.AI.SpeechToText.BatchTranscription.PunctuationMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum ServiceApiVersions
    {
        V20241115 = 0,
    }
    public partial class SpeechToTextClient
    {
        protected SpeechToTextClient() { }
        public SpeechToTextClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public SpeechToTextClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.AI.SpeechToText.BatchTranscription.SpeechToTextClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.AI.SpeechToText.BatchTranscription.BatchTranscription GetBatchTranscriptionClient(Azure.AI.SpeechToText.BatchTranscription.ServiceApiVersions? serviceApiVersionsQueryParameter = default(Azure.AI.SpeechToText.BatchTranscription.ServiceApiVersions?)) { throw null; }
        public virtual Azure.AI.SpeechToText.BatchTranscription.ClientCustomizations GetClientCustomizationsClient() { throw null; }
    }
    public partial class SpeechToTextClientOptions : Azure.Core.ClientOptions
    {
        public SpeechToTextClientOptions(Azure.AI.SpeechToText.BatchTranscription.SpeechToTextClientOptions.ServiceVersion version = Azure.AI.SpeechToText.BatchTranscription.SpeechToTextClientOptions.ServiceVersion.V2024_11_15) { }
        public Azure.AI.SpeechToText.BatchTranscription.ServiceApiVersions? ServiceApiVersionsQueryParameter { get { throw null; } set { } }
        public enum ServiceVersion
        {
            V2024_05_15_Preview = 1,
            V2024_11_15 = 2,
        }
    }
    public partial class TranscriptionFile : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionFile>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionFile>
    {
        internal TranscriptionFile() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public Azure.AI.SpeechToText.BatchTranscription.FileKind Kind { get { throw null; } }
        public Azure.AI.SpeechToText.BatchTranscription.FileLinks Links { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.AI.SpeechToText.BatchTranscription.FileProperties Properties { get { throw null; } }
        public System.Uri Self { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.TranscriptionFile System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionFile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionFile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.TranscriptionFile System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionFile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionFile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionFile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TranscriptionLinks : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionLinks>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionLinks>
    {
        public TranscriptionLinks() { }
        public System.Uri Files { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.TranscriptionLinks System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionLinks>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionLinks>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.TranscriptionLinks System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionLinks>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionLinks>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionLinks>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TranscriptionProperties : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionProperties>
    {
        public TranscriptionProperties(int timeToLiveHours) { }
        public System.Collections.Generic.IList<int> Channels { get { throw null; } }
        public System.Uri DestinationContainerUrl { get { throw null; } set { } }
        public Azure.AI.SpeechToText.BatchTranscription.DiarizationProperties Diarization { get { throw null; } set { } }
        public bool? DisplayFormWordLevelTimestampsEnabled { get { throw null; } set { } }
        public int? DurationMilliseconds { get { throw null; } }
        public Azure.AI.SpeechToText.BatchTranscription.EntityError Error { get { throw null; } set { } }
        public Azure.AI.SpeechToText.BatchTranscription.LanguageIdentificationProperties LanguageIdentification { get { throw null; } set { } }
        public Azure.AI.SpeechToText.BatchTranscription.ProfanityFilterMode? ProfanityFilterMode { get { throw null; } set { } }
        public Azure.AI.SpeechToText.BatchTranscription.PunctuationMode? PunctuationMode { get { throw null; } set { } }
        public int TimeToLiveHours { get { throw null; } set { } }
        public bool? WordLevelTimestampsEnabled { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.TranscriptionProperties System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.BatchTranscription.TranscriptionProperties System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.BatchTranscription.TranscriptionProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class AISpeechToTextBatchTranscriptionClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.SpeechToText.BatchTranscription.SpeechToTextClient, Azure.AI.SpeechToText.BatchTranscription.SpeechToTextClientOptions> AddSpeechToTextClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.SpeechToText.BatchTranscription.SpeechToTextClient, Azure.AI.SpeechToText.BatchTranscription.SpeechToTextClientOptions> AddSpeechToTextClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
