namespace Azure.Developer.MicrosoftPlaywrightTesting
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AccessLevel : System.IEquatable<Azure.Developer.MicrosoftPlaywrightTesting.AccessLevel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AccessLevel(string value) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.AccessLevel Read { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.AccessLevel ReadAddCreateWrite { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.AccessLevel ReadWrite { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.AccessLevel Write { get { throw null; } }
        public bool Equals(Azure.Developer.MicrosoftPlaywrightTesting.AccessLevel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Developer.MicrosoftPlaywrightTesting.AccessLevel left, Azure.Developer.MicrosoftPlaywrightTesting.AccessLevel right) { throw null; }
        public static implicit operator Azure.Developer.MicrosoftPlaywrightTesting.AccessLevel (string value) { throw null; }
        public static bool operator !=(Azure.Developer.MicrosoftPlaywrightTesting.AccessLevel left, Azure.Developer.MicrosoftPlaywrightTesting.AccessLevel right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AccountTestRunStats : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.AccountTestRunStats>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.AccountTestRunStats>
    {
        internal AccountTestRunStats() { }
        public int All { get { throw null; } }
        public int CloudExecutionRuns { get { throw null; } }
        public int Failed { get { throw null; } }
        public int Flaky { get { throw null; } }
        public int Passed { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.AccountTestRunStats System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.AccountTestRunStats>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.AccountTestRunStats>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.AccountTestRunStats System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.AccountTestRunStats>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.AccountTestRunStats>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.AccountTestRunStats>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AttachmentKind : System.IEquatable<Azure.Developer.MicrosoftPlaywrightTesting.AttachmentKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AttachmentKind(string value) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.AttachmentKind Image { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.AttachmentKind Trace { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.AttachmentKind Video { get { throw null; } }
        public bool Equals(Azure.Developer.MicrosoftPlaywrightTesting.AttachmentKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Developer.MicrosoftPlaywrightTesting.AttachmentKind left, Azure.Developer.MicrosoftPlaywrightTesting.AttachmentKind right) { throw null; }
        public static implicit operator Azure.Developer.MicrosoftPlaywrightTesting.AttachmentKind (string value) { throw null; }
        public static bool operator !=(Azure.Developer.MicrosoftPlaywrightTesting.AttachmentKind left, Azure.Developer.MicrosoftPlaywrightTesting.AttachmentKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BrowserType : System.IEquatable<Azure.Developer.MicrosoftPlaywrightTesting.BrowserType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BrowserType(string value) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.BrowserType Chromium { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.BrowserType FireFox { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.BrowserType Webkit { get { throw null; } }
        public bool Equals(Azure.Developer.MicrosoftPlaywrightTesting.BrowserType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Developer.MicrosoftPlaywrightTesting.BrowserType left, Azure.Developer.MicrosoftPlaywrightTesting.BrowserType right) { throw null; }
        public static implicit operator Azure.Developer.MicrosoftPlaywrightTesting.BrowserType (string value) { throw null; }
        public static bool operator !=(Azure.Developer.MicrosoftPlaywrightTesting.BrowserType left, Azure.Developer.MicrosoftPlaywrightTesting.BrowserType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CiConfig : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.CiConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.CiConfig>
    {
        public CiConfig() { }
        public string Author { get { throw null; } set { } }
        public string Branch { get { throw null; } set { } }
        public Azure.Developer.MicrosoftPlaywrightTesting.CiProviderName? CiProviderName { get { throw null; } set { } }
        public string CommitId { get { throw null; } set { } }
        public System.Uri RevisionUrl { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.CiConfig System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.CiConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.CiConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.CiConfig System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.CiConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.CiConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.CiConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CiProviderName : System.IEquatable<Azure.Developer.MicrosoftPlaywrightTesting.CiProviderName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CiProviderName(string value) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.CiProviderName Ado { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.CiProviderName Default { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.CiProviderName GitHub { get { throw null; } }
        public bool Equals(Azure.Developer.MicrosoftPlaywrightTesting.CiProviderName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Developer.MicrosoftPlaywrightTesting.CiProviderName left, Azure.Developer.MicrosoftPlaywrightTesting.CiProviderName right) { throw null; }
        public static implicit operator Azure.Developer.MicrosoftPlaywrightTesting.CiProviderName (string value) { throw null; }
        public static bool operator !=(Azure.Developer.MicrosoftPlaywrightTesting.CiProviderName left, Azure.Developer.MicrosoftPlaywrightTesting.CiProviderName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CloudReportingSummary : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.CloudReportingSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.CloudReportingSummary>
    {
        internal CloudReportingSummary() { }
        public System.Collections.Generic.IReadOnlyList<string> Jobs { get { throw null; } }
        public int NumFailedTests { get { throw null; } }
        public int NumFlakyTests { get { throw null; } }
        public int NumPassedTests { get { throw null; } }
        public int NumSkippedTests { get { throw null; } }
        public int NumTotalTests { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Projects { get { throw null; } }
        public Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus ResultProcessingstatus { get { throw null; } }
        public Azure.Developer.MicrosoftPlaywrightTesting.TestStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.CloudReportingSummary System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.CloudReportingSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.CloudReportingSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.CloudReportingSummary System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.CloudReportingSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.CloudReportingSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.CloudReportingSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CloudRunSummary : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.CloudRunSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.CloudRunSummary>
    {
        internal CloudRunSummary() { }
        public int BillableTime { get { throw null; } }
        public bool BrowserQuotaExceeded { get { throw null; } }
        public System.DateTimeOffset EndTime { get { throw null; } }
        public int NumBrowserSessions { get { throw null; } }
        public System.DateTimeOffset StartTime { get { throw null; } }
        public Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus Status { get { throw null; } }
        public int TotalTime { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.CloudRunSummary System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.CloudRunSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.CloudRunSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.CloudRunSummary System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.CloudRunSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.CloudRunSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.CloudRunSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class DeveloperMicrosoftPlaywrightTestingModelFactory
    {
        public static Azure.Developer.MicrosoftPlaywrightTesting.AccountTestRunStats AccountTestRunStats(int passed = 0, int failed = 0, int flaky = 0, int all = 0, int cloudExecutionRuns = 0) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.CloudReportingSummary CloudReportingSummary(Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus resultProcessingstatus = default(Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus), int numTotalTests = 0, int numPassedTests = 0, int numFailedTests = 0, int numSkippedTests = 0, int numFlakyTests = 0, Azure.Developer.MicrosoftPlaywrightTesting.TestStatus status = default(Azure.Developer.MicrosoftPlaywrightTesting.TestStatus), System.Collections.Generic.IEnumerable<string> jobs = null, System.Collections.Generic.IEnumerable<string> projects = null, System.Collections.Generic.IEnumerable<string> tags = null) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.CloudRunSummary CloudRunSummary(Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus status = default(Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus), System.DateTimeOffset startTime = default(System.DateTimeOffset), System.DateTimeOffset endTime = default(System.DateTimeOffset), int billableTime = 0, int totalTime = 0, int numBrowserSessions = 0, bool browserQuotaExceeded = false) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.PreviousRetrySummary PreviousRetrySummary(string testExecutionId = null, int retryCount = 0, Azure.Developer.MicrosoftPlaywrightTesting.TestStatus status = default(Azure.Developer.MicrosoftPlaywrightTesting.TestStatus), System.TimeSpan duration = default(System.TimeSpan), System.DateTimeOffset startTime = default(System.DateTimeOffset), System.Collections.Generic.IEnumerable<Azure.Developer.MicrosoftPlaywrightTesting.AttachmentKind> attachmentsMetadata = null, string artifactsPath = null) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.ResultsStats ResultsStats(int passed = 0, int failed = 0, int flaky = 0, int skipped = 0, int all = 0) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestResult TestResult(Azure.Developer.MicrosoftPlaywrightTesting.TestStatus status = default(Azure.Developer.MicrosoftPlaywrightTesting.TestStatus), long durationInMs = (long)0, System.DateTimeOffset startTime = default(System.DateTimeOffset), System.Collections.Generic.IEnumerable<Azure.Developer.MicrosoftPlaywrightTesting.AttachmentKind> attachmentsMetadata = null) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestResultDetails TestResultDetails(string testExecutionId = null, string testId = null, string testCombinationId = null, string runId = null, string shardId = null, string accountId = null, string suiteId = null, string testTitle = null, string suiteTitle = null, string fileName = null, int lineNumber = 0, int retryCount = 0, Azure.Developer.MicrosoftPlaywrightTesting.TestStatus status = default(Azure.Developer.MicrosoftPlaywrightTesting.TestStatus), Azure.Developer.MicrosoftPlaywrightTesting.WebTestConfig webTestConfig = null, Azure.Developer.MicrosoftPlaywrightTesting.CiConfig ciConfig = null, Azure.Developer.MicrosoftPlaywrightTesting.TestResult result = null, System.Collections.Generic.IEnumerable<Azure.Developer.MicrosoftPlaywrightTesting.PreviousRetrySummary> previousRetries = null, System.Collections.Generic.IEnumerable<string> tags = null, System.Collections.Generic.IEnumerable<string> annotations = null, string artifactsPath = null) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestResultsUrl TestResultsUrl(System.Uri url = null, System.DateTimeOffset createdAt = default(System.DateTimeOffset), System.DateTimeOffset expiresAt = default(System.DateTimeOffset), Azure.Developer.MicrosoftPlaywrightTesting.AccessLevel accessLevel = default(Azure.Developer.MicrosoftPlaywrightTesting.AccessLevel)) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestRun TestRun(string testRunId = null, string displayName = null, System.DateTimeOffset startTime = default(System.DateTimeOffset), string creatorId = null, string creatorName = null, Azure.Developer.MicrosoftPlaywrightTesting.CloudRunSummary cloudRunSummary = null, Azure.Developer.MicrosoftPlaywrightTesting.CloudReportingSummary cloudReportSummary = null, Azure.Developer.MicrosoftPlaywrightTesting.CiConfig ciConfig = null, Azure.Developer.MicrosoftPlaywrightTesting.TestRunConfig testRunConfig = null, Azure.Developer.MicrosoftPlaywrightTesting.TestResultsUrl testResultsUrl = null, bool cloudRunEnabled = false, bool cloudReportingEnabled = false) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestRunsMetadata TestRunsMetadata(System.Collections.Generic.IEnumerable<string> branches = null) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.UpdateShardExecutionSummary UpdateShardExecutionSummary(System.DateTimeOffset startTime = default(System.DateTimeOffset), System.DateTimeOffset endTime = default(System.DateTimeOffset), Azure.Developer.MicrosoftPlaywrightTesting.UploadMetadata uploadMetadata = null) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OsType : System.IEquatable<Azure.Developer.MicrosoftPlaywrightTesting.OsType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OsType(string value) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.OsType Linux { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.OsType Mac { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.OsType Windows { get { throw null; } }
        public bool Equals(Azure.Developer.MicrosoftPlaywrightTesting.OsType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Developer.MicrosoftPlaywrightTesting.OsType left, Azure.Developer.MicrosoftPlaywrightTesting.OsType right) { throw null; }
        public static implicit operator Azure.Developer.MicrosoftPlaywrightTesting.OsType (string value) { throw null; }
        public static bool operator !=(Azure.Developer.MicrosoftPlaywrightTesting.OsType left, Azure.Developer.MicrosoftPlaywrightTesting.OsType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PreviousRetrySummary : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.PreviousRetrySummary>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.PreviousRetrySummary>
    {
        public PreviousRetrySummary(string testExecutionId, int retryCount, Azure.Developer.MicrosoftPlaywrightTesting.TestStatus status, System.TimeSpan duration, System.DateTimeOffset startTime, System.Collections.Generic.IEnumerable<Azure.Developer.MicrosoftPlaywrightTesting.AttachmentKind> attachmentsMetadata) { }
        public string ArtifactsPath { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Developer.MicrosoftPlaywrightTesting.AttachmentKind> AttachmentsMetadata { get { throw null; } }
        public System.TimeSpan Duration { get { throw null; } set { } }
        public int RetryCount { get { throw null; } set { } }
        public System.DateTimeOffset StartTime { get { throw null; } set { } }
        public Azure.Developer.MicrosoftPlaywrightTesting.TestStatus Status { get { throw null; } set { } }
        public string TestExecutionId { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.PreviousRetrySummary System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.PreviousRetrySummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.PreviousRetrySummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.PreviousRetrySummary System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.PreviousRetrySummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.PreviousRetrySummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.PreviousRetrySummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ReportingClient
    {
        protected ReportingClient() { }
        public ReportingClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public ReportingClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Developer.MicrosoftPlaywrightTesting.ReportingClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Developer.MicrosoftPlaywrightTesting.TestResults GetTestResultsClient(string apiVersion = "2025-02-24") { throw null; }
        public virtual Azure.Developer.MicrosoftPlaywrightTesting.TestRuns GetTestRunsClient(string apiVersion = "2025-02-24") { throw null; }
    }
    public partial class ReportingClientOptions : Azure.Core.ClientOptions
    {
        public ReportingClientOptions(Azure.Developer.MicrosoftPlaywrightTesting.ReportingClientOptions.ServiceVersion version = Azure.Developer.MicrosoftPlaywrightTesting.ReportingClientOptions.ServiceVersion.V2025_02_24) { }
        public enum ServiceVersion
        {
            V2025_02_24 = 1,
        }
    }
    public partial class ResultsStats : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.ResultsStats>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.ResultsStats>
    {
        internal ResultsStats() { }
        public int All { get { throw null; } }
        public int Failed { get { throw null; } }
        public int Flaky { get { throw null; } }
        public int Passed { get { throw null; } }
        public int Skipped { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.ResultsStats System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.ResultsStats>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.ResultsStats>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.ResultsStats System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.ResultsStats>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.ResultsStats>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.ResultsStats>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RunnerType : System.IEquatable<Azure.Developer.MicrosoftPlaywrightTesting.RunnerType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RunnerType(string value) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.RunnerType MsTest { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.RunnerType Nunit { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.RunnerType Playwright { get { throw null; } }
        public bool Equals(Azure.Developer.MicrosoftPlaywrightTesting.RunnerType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Developer.MicrosoftPlaywrightTesting.RunnerType left, Azure.Developer.MicrosoftPlaywrightTesting.RunnerType right) { throw null; }
        public static implicit operator Azure.Developer.MicrosoftPlaywrightTesting.RunnerType (string value) { throw null; }
        public static bool operator !=(Azure.Developer.MicrosoftPlaywrightTesting.RunnerType left, Azure.Developer.MicrosoftPlaywrightTesting.RunnerType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ShardDetails : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.ShardDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.ShardDetails>
    {
        public ShardDetails(int total) { }
        public int Total { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.ShardDetails System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.ShardDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.ShardDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.ShardDetails System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.ShardDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.ShardDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.ShardDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TestFramework : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestFramework>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestFramework>
    {
        public TestFramework(Azure.Developer.MicrosoftPlaywrightTesting.TestFrameworkName name, string version, Azure.Developer.MicrosoftPlaywrightTesting.RunnerType runnerType) { }
        public Azure.Developer.MicrosoftPlaywrightTesting.TestFrameworkName Name { get { throw null; } set { } }
        public Azure.Developer.MicrosoftPlaywrightTesting.RunnerType RunnerType { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.TestFramework System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestFramework>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestFramework>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.TestFramework System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestFramework>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestFramework>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestFramework>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TestFrameworkName : System.IEquatable<Azure.Developer.MicrosoftPlaywrightTesting.TestFrameworkName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TestFrameworkName(string value) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestFrameworkName Playwright { get { throw null; } }
        public bool Equals(Azure.Developer.MicrosoftPlaywrightTesting.TestFrameworkName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Developer.MicrosoftPlaywrightTesting.TestFrameworkName left, Azure.Developer.MicrosoftPlaywrightTesting.TestFrameworkName right) { throw null; }
        public static implicit operator Azure.Developer.MicrosoftPlaywrightTesting.TestFrameworkName (string value) { throw null; }
        public static bool operator !=(Azure.Developer.MicrosoftPlaywrightTesting.TestFrameworkName left, Azure.Developer.MicrosoftPlaywrightTesting.TestFrameworkName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TestResult : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResult>
    {
        internal TestResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Developer.MicrosoftPlaywrightTesting.AttachmentKind> AttachmentsMetadata { get { throw null; } }
        public long DurationInMs { get { throw null; } }
        public System.DateTimeOffset StartTime { get { throw null; } }
        public Azure.Developer.MicrosoftPlaywrightTesting.TestStatus Status { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.TestResult System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.TestResult System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TestResultDetails : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResultDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResultDetails>
    {
        public TestResultDetails(string testExecutionId, string testId, string testCombinationId, string runId, string shardId, string suiteId, string testTitle, string suiteTitle, string fileName, int lineNumber, int retryCount, Azure.Developer.MicrosoftPlaywrightTesting.TestStatus status) { }
        public string AccountId { get { throw null; } }
        public System.Collections.Generic.IList<string> Annotations { get { throw null; } }
        public string ArtifactsPath { get { throw null; } set { } }
        public Azure.Developer.MicrosoftPlaywrightTesting.CiConfig CiConfig { get { throw null; } set { } }
        public string FileName { get { throw null; } set { } }
        public int LineNumber { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Developer.MicrosoftPlaywrightTesting.PreviousRetrySummary> PreviousRetries { get { throw null; } }
        public Azure.Developer.MicrosoftPlaywrightTesting.TestResult Result { get { throw null; } }
        public int RetryCount { get { throw null; } set { } }
        public string RunId { get { throw null; } set { } }
        public string ShardId { get { throw null; } set { } }
        public Azure.Developer.MicrosoftPlaywrightTesting.TestStatus Status { get { throw null; } set { } }
        public string SuiteId { get { throw null; } set { } }
        public string SuiteTitle { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Tags { get { throw null; } }
        public string TestCombinationId { get { throw null; } set { } }
        public string TestExecutionId { get { throw null; } set { } }
        public string TestId { get { throw null; } set { } }
        public string TestTitle { get { throw null; } set { } }
        public Azure.Developer.MicrosoftPlaywrightTesting.WebTestConfig WebTestConfig { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.TestResultDetails System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResultDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResultDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.TestResultDetails System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResultDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResultDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResultDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TestResults
    {
        protected TestResults() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response ComputeResultsStats(string accountId, int? top, int? skip, int? maxpagesize, string filter, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.Developer.MicrosoftPlaywrightTesting.ResultsStats> ComputeResultsStats(string accountId, int? top = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ComputeResultsStatsAsync(string accountId, int? top, int? skip, int? maxpagesize, string filter, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Developer.MicrosoftPlaywrightTesting.ResultsStats>> ComputeResultsStatsAsync(string accountId, int? top = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetTestResultDetails(string accountId, int? maxCount, int? skip, int? maxpagesize, string filter, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.Developer.MicrosoftPlaywrightTesting.TestResultDetails> GetTestResultDetails(string accountId, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetTestResultDetailsAsync(string accountId, int? maxCount, int? skip, int? maxpagesize, string filter, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.Developer.MicrosoftPlaywrightTesting.TestResultDetails> GetTestResultDetailsAsync(string accountId, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UploadBatch(string accountId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UploadBatch(string accountId, System.Collections.Generic.IEnumerable<Azure.Developer.MicrosoftPlaywrightTesting.TestResultDetails> values, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UploadBatchAsync(string accountId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UploadBatchAsync(string accountId, System.Collections.Generic.IEnumerable<Azure.Developer.MicrosoftPlaywrightTesting.TestResultDetails> values, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class TestResultsUrl : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResultsUrl>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResultsUrl>
    {
        internal TestResultsUrl() { }
        public Azure.Developer.MicrosoftPlaywrightTesting.AccessLevel AccessLevel { get { throw null; } }
        public System.DateTimeOffset CreatedAt { get { throw null; } }
        public System.DateTimeOffset ExpiresAt { get { throw null; } }
        public System.Uri Url { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.TestResultsUrl System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResultsUrl>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResultsUrl>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.TestResultsUrl System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResultsUrl>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResultsUrl>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestResultsUrl>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TestRun : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRun>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRun>
    {
        public TestRun(System.DateTimeOffset startTime, bool cloudReportingEnabled) { }
        public Azure.Developer.MicrosoftPlaywrightTesting.CiConfig CiConfig { get { throw null; } set { } }
        public bool CloudReportingEnabled { get { throw null; } set { } }
        public Azure.Developer.MicrosoftPlaywrightTesting.CloudReportingSummary CloudReportSummary { get { throw null; } }
        public bool CloudRunEnabled { get { throw null; } }
        public Azure.Developer.MicrosoftPlaywrightTesting.CloudRunSummary CloudRunSummary { get { throw null; } }
        public string CreatorId { get { throw null; } }
        public string CreatorName { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public System.DateTimeOffset StartTime { get { throw null; } set { } }
        public Azure.Developer.MicrosoftPlaywrightTesting.TestResultsUrl TestResultsUrl { get { throw null; } }
        public Azure.Developer.MicrosoftPlaywrightTesting.TestRunConfig TestRunConfig { get { throw null; } set { } }
        public string TestRunId { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.TestRun System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRun>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRun>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.TestRun System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRun>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRun>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRun>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TestRunConfig : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRunConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRunConfig>
    {
        public TestRunConfig(System.TimeSpan timeoutInMs, Azure.Developer.MicrosoftPlaywrightTesting.TestSdkLanguage testSdkLanguage) { }
        public int? RepeatEach { get { throw null; } set { } }
        public string ReporterPackageVersion { get { throw null; } set { } }
        public int? RetryCount { get { throw null; } set { } }
        public Azure.Developer.MicrosoftPlaywrightTesting.ShardDetails ShardDetails { get { throw null; } set { } }
        public Azure.Developer.MicrosoftPlaywrightTesting.TestFramework TestFramework { get { throw null; } set { } }
        public Azure.Developer.MicrosoftPlaywrightTesting.TestSdkLanguage TestSdkLanguage { get { throw null; } set { } }
        public string TestType { get { throw null; } set { } }
        public System.TimeSpan TimeoutInMs { get { throw null; } set { } }
        public int? Workers { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.TestRunConfig System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRunConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRunConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.TestRunConfig System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRunConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRunConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRunConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TestRuns
    {
        protected TestRuns() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response ComputeAccountRunStats(string accountId, int? top, int? skip, int? maxpagesize, string filter, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.Developer.MicrosoftPlaywrightTesting.AccountTestRunStats> ComputeAccountRunStats(string accountId, int? top = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ComputeAccountRunStatsAsync(string accountId, int? top, int? skip, int? maxpagesize, string filter, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Developer.MicrosoftPlaywrightTesting.AccountTestRunStats>> ComputeAccountRunStatsAsync(string accountId, int? top = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response ComputeMetadata(string accountId, int? top, int? skip, int? maxpagesize, string filter, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.Developer.MicrosoftPlaywrightTesting.TestRunsMetadata> ComputeMetadata(string accountId, int? top = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ComputeMetadataAsync(string accountId, int? top, int? skip, int? maxpagesize, string filter, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Developer.MicrosoftPlaywrightTesting.TestRunsMetadata>> ComputeMetadataAsync(string accountId, int? top = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CreateArtifactsUploadBaseUrl(string accountId, string testRunId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.Developer.MicrosoftPlaywrightTesting.TestResultsUrl> CreateArtifactsUploadBaseUrl(string accountId, string testRunId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateArtifactsUploadBaseUrlAsync(string accountId, string testRunId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Developer.MicrosoftPlaywrightTesting.TestResultsUrl>> CreateArtifactsUploadBaseUrlAsync(string accountId, string testRunId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CreateOrUpdate(string accountId, string testRunId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateOrUpdateAsync(string accountId, string testRunId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetTestRun(string accountId, string testRunId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.Developer.MicrosoftPlaywrightTesting.TestRun> GetTestRun(string accountId, string testRunId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTestRunAsync(string accountId, string testRunId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Developer.MicrosoftPlaywrightTesting.TestRun>> GetTestRunAsync(string accountId, string testRunId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetTestRuns(string accountId, int? maxCount, int? skip, int? maxpagesize, string filter, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.Developer.MicrosoftPlaywrightTesting.TestRun> GetTestRuns(string accountId, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetTestRunsAsync(string accountId, int? maxCount, int? skip, int? maxpagesize, string filter, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.Developer.MicrosoftPlaywrightTesting.TestRun> GetTestRunsAsync(string accountId, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UpdateShardExecutionStatus(string accountId, string testRunId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdateShardExecutionStatus(string accountId, string testRunId, int shardId, Azure.Developer.MicrosoftPlaywrightTesting.UpdateShardExecutionSummary summary, int workers, bool? uploadCompleted = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateShardExecutionStatusAsync(string accountId, string testRunId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateShardExecutionStatusAsync(string accountId, string testRunId, int shardId, Azure.Developer.MicrosoftPlaywrightTesting.UpdateShardExecutionSummary summary, int workers, bool? uploadCompleted = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class TestRunsMetadata : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRunsMetadata>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRunsMetadata>
    {
        internal TestRunsMetadata() { }
        public System.Collections.Generic.IReadOnlyList<string> Branches { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.TestRunsMetadata System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRunsMetadata>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRunsMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.TestRunsMetadata System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRunsMetadata>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRunsMetadata>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.TestRunsMetadata>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TestRunStatus : System.IEquatable<Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TestRunStatus(string value) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus ClientComplete { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus Running { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus ServerComplete { get { throw null; } }
        public bool Equals(Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus left, Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus right) { throw null; }
        public static implicit operator Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus (string value) { throw null; }
        public static bool operator !=(Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus left, Azure.Developer.MicrosoftPlaywrightTesting.TestRunStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TestSdkLanguage : System.IEquatable<Azure.Developer.MicrosoftPlaywrightTesting.TestSdkLanguage>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TestSdkLanguage(string value) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestSdkLanguage CSharp { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestSdkLanguage JavaScript { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestSdkLanguage TypeScript { get { throw null; } }
        public bool Equals(Azure.Developer.MicrosoftPlaywrightTesting.TestSdkLanguage other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Developer.MicrosoftPlaywrightTesting.TestSdkLanguage left, Azure.Developer.MicrosoftPlaywrightTesting.TestSdkLanguage right) { throw null; }
        public static implicit operator Azure.Developer.MicrosoftPlaywrightTesting.TestSdkLanguage (string value) { throw null; }
        public static bool operator !=(Azure.Developer.MicrosoftPlaywrightTesting.TestSdkLanguage left, Azure.Developer.MicrosoftPlaywrightTesting.TestSdkLanguage right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TestStatus : System.IEquatable<Azure.Developer.MicrosoftPlaywrightTesting.TestStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TestStatus(string value) { throw null; }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestStatus Failed { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestStatus Interrupted { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestStatus Passed { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestStatus Skipped { get { throw null; } }
        public static Azure.Developer.MicrosoftPlaywrightTesting.TestStatus TimedOut { get { throw null; } }
        public bool Equals(Azure.Developer.MicrosoftPlaywrightTesting.TestStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Developer.MicrosoftPlaywrightTesting.TestStatus left, Azure.Developer.MicrosoftPlaywrightTesting.TestStatus right) { throw null; }
        public static implicit operator Azure.Developer.MicrosoftPlaywrightTesting.TestStatus (string value) { throw null; }
        public static bool operator !=(Azure.Developer.MicrosoftPlaywrightTesting.TestStatus left, Azure.Developer.MicrosoftPlaywrightTesting.TestStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UpdateShardExecutionSummary : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.UpdateShardExecutionSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.UpdateShardExecutionSummary>
    {
        public UpdateShardExecutionSummary(System.DateTimeOffset startTime, System.DateTimeOffset endTime) { }
        public System.DateTimeOffset EndTime { get { throw null; } }
        public System.DateTimeOffset StartTime { get { throw null; } }
        public Azure.Developer.MicrosoftPlaywrightTesting.UploadMetadata UploadMetadata { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.UpdateShardExecutionSummary System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.UpdateShardExecutionSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.UpdateShardExecutionSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.UpdateShardExecutionSummary System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.UpdateShardExecutionSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.UpdateShardExecutionSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.UpdateShardExecutionSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UploadMetadata : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.UploadMetadata>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.UploadMetadata>
    {
        public UploadMetadata(int testResultsCount, int totalAttachmentsCount, long totalAttachmentsSize) { }
        public int TestResultsCount { get { throw null; } }
        public int TotalAttachmentsCount { get { throw null; } }
        public long TotalAttachmentsSize { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.UploadMetadata System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.UploadMetadata>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.UploadMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.UploadMetadata System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.UploadMetadata>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.UploadMetadata>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.UploadMetadata>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WebTestConfig : System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.WebTestConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.WebTestConfig>
    {
        public WebTestConfig(string jobName, string projectName, Azure.Developer.MicrosoftPlaywrightTesting.BrowserType browserType, Azure.Developer.MicrosoftPlaywrightTesting.OsType os) { }
        public Azure.Developer.MicrosoftPlaywrightTesting.BrowserType BrowserType { get { throw null; } set { } }
        public string JobName { get { throw null; } set { } }
        public Azure.Developer.MicrosoftPlaywrightTesting.OsType Os { get { throw null; } set { } }
        public string ProjectName { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.WebTestConfig System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.WebTestConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Developer.MicrosoftPlaywrightTesting.WebTestConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Developer.MicrosoftPlaywrightTesting.WebTestConfig System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.WebTestConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.WebTestConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Developer.MicrosoftPlaywrightTesting.WebTestConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class DeveloperMicrosoftPlaywrightTestingClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Developer.MicrosoftPlaywrightTesting.ReportingClient, Azure.Developer.MicrosoftPlaywrightTesting.ReportingClientOptions> AddReportingClient<TBuilder>(this TBuilder builder, System.Uri endpoint) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithCredential { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Developer.MicrosoftPlaywrightTesting.ReportingClient, Azure.Developer.MicrosoftPlaywrightTesting.ReportingClientOptions> AddReportingClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
