namespace Azure.AI.Speech.Transcription
{
    public static partial class AISpeechTranscriptionModelFactory
    {
        public static Azure.AI.Speech.Transcription.ChannelCombinedPhrases ChannelCombinedPhrases(int? channel = default(int?), string text = null) { throw null; }
        public static Azure.AI.Speech.Transcription.TranscribedPhrase TranscribedPhrase(int? channel = default(int?), int? speaker = default(int?), int offsetMilliseconds = 0, int durationMilliseconds = 0, string text = null, System.Collections.Generic.IEnumerable<Azure.AI.Speech.Transcription.TranscribedWord> words = null, string locale = null, float confidence = 0f) { throw null; }
        public static Azure.AI.Speech.Transcription.TranscribedWord TranscribedWord(string text = null, int offsetMilliseconds = 0, int durationMilliseconds = 0) { throw null; }
        public static Azure.AI.Speech.Transcription.TranscriptionResult TranscriptionResult(int durationMilliseconds = 0, System.Collections.Generic.IEnumerable<Azure.AI.Speech.Transcription.ChannelCombinedPhrases> combinedPhrases = null, System.Collections.Generic.IEnumerable<Azure.AI.Speech.Transcription.TranscribedPhrase> phrases = null) { throw null; }
    }
    public partial class ChannelCombinedPhrases : System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.ChannelCombinedPhrases>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.ChannelCombinedPhrases>
    {
        internal ChannelCombinedPhrases() { }
        public int? Channel { get { throw null; } }
        public string Text { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Speech.Transcription.ChannelCombinedPhrases System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.ChannelCombinedPhrases>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.ChannelCombinedPhrases>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Speech.Transcription.ChannelCombinedPhrases System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.ChannelCombinedPhrases>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.ChannelCombinedPhrases>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.ChannelCombinedPhrases>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProfanityFilterMode : System.IEquatable<Azure.AI.Speech.Transcription.ProfanityFilterMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProfanityFilterMode(string value) { throw null; }
        public static Azure.AI.Speech.Transcription.ProfanityFilterMode Masked { get { throw null; } }
        public static Azure.AI.Speech.Transcription.ProfanityFilterMode None { get { throw null; } }
        public static Azure.AI.Speech.Transcription.ProfanityFilterMode Removed { get { throw null; } }
        public static Azure.AI.Speech.Transcription.ProfanityFilterMode Tags { get { throw null; } }
        public bool Equals(Azure.AI.Speech.Transcription.ProfanityFilterMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Speech.Transcription.ProfanityFilterMode left, Azure.AI.Speech.Transcription.ProfanityFilterMode right) { throw null; }
        public static implicit operator Azure.AI.Speech.Transcription.ProfanityFilterMode (string value) { throw null; }
        public static bool operator !=(Azure.AI.Speech.Transcription.ProfanityFilterMode left, Azure.AI.Speech.Transcription.ProfanityFilterMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TranscribedPhrase : System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.TranscribedPhrase>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscribedPhrase>
    {
        internal TranscribedPhrase() { }
        public int? Channel { get { throw null; } }
        public float Confidence { get { throw null; } }
        public int DurationMilliseconds { get { throw null; } }
        public string Locale { get { throw null; } }
        public int OffsetMilliseconds { get { throw null; } }
        public int? Speaker { get { throw null; } }
        public string Text { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Speech.Transcription.TranscribedWord> Words { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Speech.Transcription.TranscribedPhrase System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.TranscribedPhrase>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.TranscribedPhrase>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Speech.Transcription.TranscribedPhrase System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscribedPhrase>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscribedPhrase>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscribedPhrase>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TranscribedWord : System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.TranscribedWord>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscribedWord>
    {
        internal TranscribedWord() { }
        public int DurationMilliseconds { get { throw null; } }
        public int OffsetMilliseconds { get { throw null; } }
        public string Text { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Speech.Transcription.TranscribedWord System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.TranscribedWord>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.TranscribedWord>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Speech.Transcription.TranscribedWord System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscribedWord>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscribedWord>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscribedWord>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TranscriptionClient
    {
        protected TranscriptionClient() { }
        public TranscriptionClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public TranscriptionClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.AI.Speech.Transcription.TranscriptionClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response Transcribe(Azure.Core.RequestContent content, string contentType, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Speech.Transcription.TranscriptionResult> Transcribe(System.IO.Stream audio, Azure.AI.Speech.Transcription.TranscriptionOptions definition = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> TranscribeAsync(Azure.Core.RequestContent content, string contentType, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Speech.Transcription.TranscriptionResult>> TranscribeAsync(System.IO.Stream audio, Azure.AI.Speech.Transcription.TranscriptionOptions definition = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class TranscriptionClientOptions : Azure.Core.ClientOptions
    {
        public TranscriptionClientOptions(Azure.AI.Speech.Transcription.TranscriptionClientOptions.ServiceVersion version = Azure.AI.Speech.Transcription.TranscriptionClientOptions.ServiceVersion.V2024_11_15) { }
        public enum ServiceVersion
        {
            V2024_11_15 = 1,
        }
    }
    public partial class TranscriptionDiarizationOptions : System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.TranscriptionDiarizationOptions>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscriptionDiarizationOptions>
    {
        public TranscriptionDiarizationOptions() { }
        public bool? Enabled { get { throw null; } set { } }
        public int? MaxSpeakers { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Speech.Transcription.TranscriptionDiarizationOptions System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.TranscriptionDiarizationOptions>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.TranscriptionDiarizationOptions>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Speech.Transcription.TranscriptionDiarizationOptions System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscriptionDiarizationOptions>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscriptionDiarizationOptions>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscriptionDiarizationOptions>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TranscriptionOptions : System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.TranscriptionOptions>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscriptionOptions>
    {
        public TranscriptionOptions() { }
        public System.Collections.Generic.IList<int> ActiveChannels { get { throw null; } }
        public Azure.AI.Speech.Transcription.TranscriptionDiarizationOptions DiarizationProperties { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Locales { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, System.Uri> Models { get { throw null; } }
        public Azure.AI.Speech.Transcription.ProfanityFilterMode? ProfanityFilterMode { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Speech.Transcription.TranscriptionOptions System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.TranscriptionOptions>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.TranscriptionOptions>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Speech.Transcription.TranscriptionOptions System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscriptionOptions>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscriptionOptions>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscriptionOptions>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TranscriptionResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.TranscriptionResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscriptionResult>
    {
        internal TranscriptionResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Speech.Transcription.ChannelCombinedPhrases> CombinedPhrases { get { throw null; } }
        public int DurationMilliseconds { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Speech.Transcription.TranscribedPhrase> Phrases { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Speech.Transcription.TranscriptionResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.TranscriptionResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Speech.Transcription.TranscriptionResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Speech.Transcription.TranscriptionResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscriptionResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscriptionResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Speech.Transcription.TranscriptionResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class AISpeechTranscriptionClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Speech.Transcription.TranscriptionClient, Azure.AI.Speech.Transcription.TranscriptionClientOptions> AddTranscriptionClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Speech.Transcription.TranscriptionClient, Azure.AI.Speech.Transcription.TranscriptionClientOptions> AddTranscriptionClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
