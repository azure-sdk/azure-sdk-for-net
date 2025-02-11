namespace Azure.AI.SpeechToText.FastTranscription
{
    public static partial class AISpeechToTextFastTranscriptionModelFactory
    {
        public static Azure.AI.SpeechToText.FastTranscription.ChannelCombinedPhrases ChannelCombinedPhrases(int? channel = default(int?), string text = null) { throw null; }
        public static Azure.AI.SpeechToText.FastTranscription.TimestampedWord TimestampedWord(string text = null, int offsetMilliseconds = 0, int durationMilliseconds = 0) { throw null; }
        public static Azure.AI.SpeechToText.FastTranscription.TranscribedPhrase TranscribedPhrase(int? channel = default(int?), int? speaker = default(int?), int offsetMilliseconds = 0, int durationMilliseconds = 0, string text = null, System.Collections.Generic.IEnumerable<Azure.AI.SpeechToText.FastTranscription.TimestampedWord> words = null, string locale = null, float confidence = 0f) { throw null; }
        public static Azure.AI.SpeechToText.FastTranscription.TranscribeResult TranscribeResult(int durationMilliseconds = 0, System.Collections.Generic.IEnumerable<Azure.AI.SpeechToText.FastTranscription.ChannelCombinedPhrases> combinedPhrases = null, System.Collections.Generic.IEnumerable<Azure.AI.SpeechToText.FastTranscription.TranscribedPhrase> phrases = null) { throw null; }
    }
    public partial class ChannelCombinedPhrases : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.ChannelCombinedPhrases>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.ChannelCombinedPhrases>
    {
        internal ChannelCombinedPhrases() { }
        public int? Channel { get { throw null; } }
        public string Text { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.FastTranscription.ChannelCombinedPhrases System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.ChannelCombinedPhrases>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.ChannelCombinedPhrases>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.FastTranscription.ChannelCombinedPhrases System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.ChannelCombinedPhrases>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.ChannelCombinedPhrases>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.ChannelCombinedPhrases>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ClientCustomizations
    {
        protected ClientCustomizations() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class FastTranscription
    {
        protected FastTranscription() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response Transcribe(Azure.Core.RequestContent content, string contentType, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.SpeechToText.FastTranscription.TranscribeResult> Transcribe(System.IO.Stream audio, Azure.AI.SpeechToText.FastTranscription.TranscribeMetadata definition = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> TranscribeAsync(Azure.Core.RequestContent content, string contentType, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.SpeechToText.FastTranscription.TranscribeResult>> TranscribeAsync(System.IO.Stream audio, Azure.AI.SpeechToText.FastTranscription.TranscribeMetadata definition = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProfanityFilterMode : System.IEquatable<Azure.AI.SpeechToText.FastTranscription.ProfanityFilterMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProfanityFilterMode(string value) { throw null; }
        public static Azure.AI.SpeechToText.FastTranscription.ProfanityFilterMode Masked { get { throw null; } }
        public static Azure.AI.SpeechToText.FastTranscription.ProfanityFilterMode None { get { throw null; } }
        public static Azure.AI.SpeechToText.FastTranscription.ProfanityFilterMode Removed { get { throw null; } }
        public static Azure.AI.SpeechToText.FastTranscription.ProfanityFilterMode Tags { get { throw null; } }
        public bool Equals(Azure.AI.SpeechToText.FastTranscription.ProfanityFilterMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.SpeechToText.FastTranscription.ProfanityFilterMode left, Azure.AI.SpeechToText.FastTranscription.ProfanityFilterMode right) { throw null; }
        public static implicit operator Azure.AI.SpeechToText.FastTranscription.ProfanityFilterMode (string value) { throw null; }
        public static bool operator !=(Azure.AI.SpeechToText.FastTranscription.ProfanityFilterMode left, Azure.AI.SpeechToText.FastTranscription.ProfanityFilterMode right) { throw null; }
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
        public SpeechToTextClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.AI.SpeechToText.FastTranscription.SpeechToTextClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.AI.SpeechToText.FastTranscription.ClientCustomizations GetClientCustomizationsClient() { throw null; }
        public virtual Azure.AI.SpeechToText.FastTranscription.FastTranscription GetFastTranscriptionClient(Azure.AI.SpeechToText.FastTranscription.ServiceApiVersions? serviceApiVersionsQueryParameter = default(Azure.AI.SpeechToText.FastTranscription.ServiceApiVersions?)) { throw null; }
    }
    public partial class SpeechToTextClientOptions : Azure.Core.ClientOptions
    {
        public SpeechToTextClientOptions(Azure.AI.SpeechToText.FastTranscription.SpeechToTextClientOptions.ServiceVersion version = Azure.AI.SpeechToText.FastTranscription.SpeechToTextClientOptions.ServiceVersion.V2024_11_15) { }
        public Azure.AI.SpeechToText.FastTranscription.ServiceApiVersions? ServiceApiVersionsQueryParameter { get { throw null; } set { } }
        public enum ServiceVersion
        {
            V2024_05_15_Preview = 1,
            V2024_11_15 = 2,
        }
    }
    public partial class TimestampedWord : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.TimestampedWord>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TimestampedWord>
    {
        internal TimestampedWord() { }
        public int DurationMilliseconds { get { throw null; } }
        public int OffsetMilliseconds { get { throw null; } }
        public string Text { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.FastTranscription.TimestampedWord System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.TimestampedWord>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.TimestampedWord>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.FastTranscription.TimestampedWord System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TimestampedWord>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TimestampedWord>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TimestampedWord>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TranscribeDiarizationProperties : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.TranscribeDiarizationProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribeDiarizationProperties>
    {
        public TranscribeDiarizationProperties() { }
        public bool? Enabled { get { throw null; } set { } }
        public int? MaxSpeakers { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.FastTranscription.TranscribeDiarizationProperties System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.TranscribeDiarizationProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.TranscribeDiarizationProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.FastTranscription.TranscribeDiarizationProperties System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribeDiarizationProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribeDiarizationProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribeDiarizationProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TranscribedPhrase : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.TranscribedPhrase>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribedPhrase>
    {
        internal TranscribedPhrase() { }
        public int? Channel { get { throw null; } }
        public float Confidence { get { throw null; } }
        public int DurationMilliseconds { get { throw null; } }
        public string Locale { get { throw null; } }
        public int OffsetMilliseconds { get { throw null; } }
        public int? Speaker { get { throw null; } }
        public string Text { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.SpeechToText.FastTranscription.TimestampedWord> Words { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.FastTranscription.TranscribedPhrase System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.TranscribedPhrase>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.TranscribedPhrase>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.FastTranscription.TranscribedPhrase System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribedPhrase>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribedPhrase>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribedPhrase>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TranscribeMetadata : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.TranscribeMetadata>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribeMetadata>
    {
        public TranscribeMetadata() { }
        public System.Collections.Generic.IList<int> Channels { get { throw null; } }
        public Azure.AI.SpeechToText.FastTranscription.TranscribeDiarizationProperties Diarization { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Locales { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, System.Uri> Models { get { throw null; } }
        public Azure.AI.SpeechToText.FastTranscription.ProfanityFilterMode? ProfanityFilterMode { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.FastTranscription.TranscribeMetadata System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.TranscribeMetadata>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.TranscribeMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.FastTranscription.TranscribeMetadata System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribeMetadata>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribeMetadata>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribeMetadata>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TranscribeResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.TranscribeResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribeResult>
    {
        internal TranscribeResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.SpeechToText.FastTranscription.ChannelCombinedPhrases> CombinedPhrases { get { throw null; } }
        public int DurationMilliseconds { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.SpeechToText.FastTranscription.TranscribedPhrase> Phrases { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.FastTranscription.TranscribeResult System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.TranscribeResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.SpeechToText.FastTranscription.TranscribeResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.SpeechToText.FastTranscription.TranscribeResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribeResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribeResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.SpeechToText.FastTranscription.TranscribeResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class AISpeechToTextFastTranscriptionClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.SpeechToText.FastTranscription.SpeechToTextClient, Azure.AI.SpeechToText.FastTranscription.SpeechToTextClientOptions> AddSpeechToTextClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.SpeechToText.FastTranscription.SpeechToTextClient, Azure.AI.SpeechToText.FastTranscription.SpeechToTextClientOptions> AddSpeechToTextClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
