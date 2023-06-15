namespace Azure.AI.AnomalyDetector
{
    public partial class AlignPolicy
    {
        public AlignPolicy() { }
        public Azure.AI.AnomalyDetector.MultivariateAlignMode? AlignMode { get { throw null; } set { } }
        public Azure.AI.AnomalyDetector.MultivariateFillNaMethod? FillNAMethod { get { throw null; } set { } }
        public float? PaddingValue { get { throw null; } set { } }
    }
    public partial class AnomalyDetectorClient
    {
        protected AnomalyDetectorClient() { }
        public AnomalyDetectorClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public AnomalyDetectorClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.AI.AnomalyDetector.AnomalyDetectorClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response DeleteMultivariateModel(string modelId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteMultivariateModelAsync(string modelId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.AnomalyDetector.MultivariateDetectionResult> DetectMultivariateBatchAnomaly(string modelId, Azure.AI.AnomalyDetector.MultivariateBatchDetectionSettings options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DetectMultivariateBatchAnomaly(string modelId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.AnomalyDetector.MultivariateDetectionResult>> DetectMultivariateBatchAnomalyAsync(string modelId, Azure.AI.AnomalyDetector.MultivariateBatchDetectionSettings options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DetectMultivariateBatchAnomalyAsync(string modelId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.AnomalyDetector.MultivariateLastDetectionResult> DetectMultivariateLastAnomaly(string modelId, Azure.AI.AnomalyDetector.MultivariateLastDetectionSettings options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DetectMultivariateLastAnomaly(string modelId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.AnomalyDetector.MultivariateLastDetectionResult>> DetectMultivariateLastAnomalyAsync(string modelId, Azure.AI.AnomalyDetector.MultivariateLastDetectionSettings options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DetectMultivariateLastAnomalyAsync(string modelId, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.AnomalyDetector.UnivariateChangePointDetectionResult> DetectUnivariateChangePoint(Azure.AI.AnomalyDetector.UnivariateChangePointDetectionOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DetectUnivariateChangePoint(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.AnomalyDetector.UnivariateChangePointDetectionResult>> DetectUnivariateChangePointAsync(Azure.AI.AnomalyDetector.UnivariateChangePointDetectionOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DetectUnivariateChangePointAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DetectUnivariateEntireSeries(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DetectUnivariateEntireSeriesAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.AnomalyDetector.UnivariateLastDetectionResult> DetectUnivariateLastPoint(Azure.AI.AnomalyDetector.UnivariateDetectionOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DetectUnivariateLastPoint(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.AnomalyDetector.UnivariateLastDetectionResult>> DetectUnivariateLastPointAsync(Azure.AI.AnomalyDetector.UnivariateDetectionOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DetectUnivariateLastPointAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetMultivariateBatchDetectionResult(System.Guid resultId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.AnomalyDetector.MultivariateDetectionResult> GetMultivariateBatchDetectionResult(System.Guid resultId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetMultivariateBatchDetectionResultAsync(System.Guid resultId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.AnomalyDetector.MultivariateDetectionResult>> GetMultivariateBatchDetectionResultAsync(System.Guid resultId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetMultivariateModel(string modelId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.AnomalyDetector.MultivariateModel> GetMultivariateModel(string modelId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetMultivariateModelAsync(string modelId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.AnomalyDetector.MultivariateModel>> GetMultivariateModelAsync(string modelId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetMultivariateModels(int? skip, int? maxCount, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.AnomalyDetector.MultivariateModel> GetMultivariateModels(int? skip = default(int?), int? maxCount = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetMultivariateModelsAsync(int? skip, int? maxCount, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.AnomalyDetector.MultivariateModel> GetMultivariateModelsAsync(int? skip = default(int?), int? maxCount = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.AnomalyDetector.MultivariateModel> TrainMultivariateModel(Azure.AI.AnomalyDetector.MultivariateModelDetails modelInfo, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response TrainMultivariateModel(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.AnomalyDetector.MultivariateModel>> TrainMultivariateModelAsync(Azure.AI.AnomalyDetector.MultivariateModelDetails modelInfo, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> TrainMultivariateModelAsync(Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
    public partial class AnomalyDetectorClientOptions : Azure.Core.ClientOptions
    {
        public AnomalyDetectorClientOptions(Azure.AI.AnomalyDetector.AnomalyDetectorClientOptions.ServiceVersion version = Azure.AI.AnomalyDetector.AnomalyDetectorClientOptions.ServiceVersion.V1_1) { }
        public enum ServiceVersion
        {
            V1_1 = 1,
        }
    }
    public static partial class AnomalyDetectorModelFactory
    {
        public static Azure.AI.AnomalyDetector.AnomalyInterpretation AnomalyInterpretation(string variable = null, float? contributionScore = default(float?), Azure.AI.AnomalyDetector.CorrelationChanges correlationChanges = null) { throw null; }
        public static Azure.AI.AnomalyDetector.AnomalyState AnomalyState(System.DateTimeOffset timestamp = default(System.DateTimeOffset), Azure.AI.AnomalyDetector.DataPointDetails value = null, System.Collections.Generic.IEnumerable<Azure.AI.AnomalyDetector.ErrorResponse> errors = null) { throw null; }
        public static Azure.AI.AnomalyDetector.CorrelationChanges CorrelationChanges(System.Collections.Generic.IEnumerable<string> changedVariables = null) { throw null; }
        public static Azure.AI.AnomalyDetector.DataPointDetails DataPointDetails(bool isAnomaly = false, float severity = 0f, float score = 0f, System.Collections.Generic.IEnumerable<Azure.AI.AnomalyDetector.AnomalyInterpretation> interpretations = null) { throw null; }
        public static Azure.AI.AnomalyDetector.MultivariateBatchDetectionResultSummary MultivariateBatchDetectionResultSummary(Azure.AI.AnomalyDetector.MultivariateBatchDetectionStatus status = default(Azure.AI.AnomalyDetector.MultivariateBatchDetectionStatus), System.Collections.Generic.IEnumerable<Azure.AI.AnomalyDetector.ErrorResponse> errors = null, System.Collections.Generic.IEnumerable<Azure.AI.AnomalyDetector.MultivariateVariableState> variableStates = null, Azure.AI.AnomalyDetector.MultivariateBatchDetectionSettings setupInfo = null) { throw null; }
        public static Azure.AI.AnomalyDetector.MultivariateDetectionResult MultivariateDetectionResult(System.Guid resultId = default(System.Guid), Azure.AI.AnomalyDetector.MultivariateBatchDetectionResultSummary summary = null, System.Collections.Generic.IEnumerable<Azure.AI.AnomalyDetector.AnomalyState> results = null) { throw null; }
        public static Azure.AI.AnomalyDetector.MultivariateLastDetectionResult MultivariateLastDetectionResult(System.Collections.Generic.IEnumerable<Azure.AI.AnomalyDetector.MultivariateVariableState> variableStates = null, System.Collections.Generic.IEnumerable<Azure.AI.AnomalyDetector.AnomalyState> results = null) { throw null; }
        public static Azure.AI.AnomalyDetector.MultivariateModel MultivariateModel(System.Guid modelId = default(System.Guid), System.DateTimeOffset createdTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedTime = default(System.DateTimeOffset), Azure.AI.AnomalyDetector.MultivariateModelDetails modelInfo = null) { throw null; }
        public static Azure.AI.AnomalyDetector.MultivariateModelDetails MultivariateModelDetails(System.Uri dataSourceUri = null, Azure.AI.AnomalyDetector.MultivariateDataSchema? dataSchema = default(Azure.AI.AnomalyDetector.MultivariateDataSchema?), System.DateTimeOffset startsOn = default(System.DateTimeOffset), System.DateTimeOffset endsOn = default(System.DateTimeOffset), string displayName = null, int? slidingWindow = default(int?), Azure.AI.AnomalyDetector.AlignPolicy alignPolicy = null, Azure.AI.AnomalyDetector.MultivariateModelStatus? status = default(Azure.AI.AnomalyDetector.MultivariateModelStatus?), System.Collections.Generic.IEnumerable<Azure.AI.AnomalyDetector.ErrorResponse> errors = null, Azure.AI.AnomalyDetector.MultivariateDiagnosticDetails diagnosticsInfo = null) { throw null; }
        public static Azure.AI.AnomalyDetector.UnivariateChangePointDetectionResult UnivariateChangePointDetectionResult(int? period = default(int?), System.Collections.Generic.IEnumerable<bool> isChangePoint = null, System.Collections.Generic.IEnumerable<float> confidenceScores = null) { throw null; }
        public static Azure.AI.AnomalyDetector.UnivariateLastDetectionResult UnivariateLastDetectionResult(int period = 0, int suggestedWindow = 0, float expectedValue = 0f, float upperMargin = 0f, float lowerMargin = 0f, bool isAnomaly = false, bool isNegativeAnomaly = false, bool isPositiveAnomaly = false, float? severity = default(float?)) { throw null; }
    }
    public partial class AnomalyInterpretation
    {
        internal AnomalyInterpretation() { }
        public float? ContributionScore { get { throw null; } }
        public Azure.AI.AnomalyDetector.CorrelationChanges CorrelationChanges { get { throw null; } }
        public string Variable { get { throw null; } }
    }
    public partial class AnomalyState
    {
        internal AnomalyState() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.AnomalyDetector.ErrorResponse> Errors { get { throw null; } }
        public System.DateTimeOffset Timestamp { get { throw null; } }
        public Azure.AI.AnomalyDetector.DataPointDetails Value { get { throw null; } }
    }
    public partial class CorrelationChanges
    {
        internal CorrelationChanges() { }
        public System.Collections.Generic.IReadOnlyList<string> ChangedVariables { get { throw null; } }
    }
    public partial class DataPointDetails
    {
        internal DataPointDetails() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.AnomalyDetector.AnomalyInterpretation> Interpretations { get { throw null; } }
        public bool IsAnomaly { get { throw null; } }
        public float Score { get { throw null; } }
        public float Severity { get { throw null; } }
    }
    public partial class ErrorResponse
    {
        public ErrorResponse(Azure.ResponseError error) { }
        public Azure.ResponseError Error { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ImputeMode : System.IEquatable<Azure.AI.AnomalyDetector.ImputeMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ImputeMode(string value) { throw null; }
        public static Azure.AI.AnomalyDetector.ImputeMode Auto { get { throw null; } }
        public static Azure.AI.AnomalyDetector.ImputeMode Fixed { get { throw null; } }
        public static Azure.AI.AnomalyDetector.ImputeMode Linear { get { throw null; } }
        public static Azure.AI.AnomalyDetector.ImputeMode NotFill { get { throw null; } }
        public static Azure.AI.AnomalyDetector.ImputeMode Previous { get { throw null; } }
        public static Azure.AI.AnomalyDetector.ImputeMode Zero { get { throw null; } }
        public bool Equals(Azure.AI.AnomalyDetector.ImputeMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.AnomalyDetector.ImputeMode left, Azure.AI.AnomalyDetector.ImputeMode right) { throw null; }
        public static implicit operator Azure.AI.AnomalyDetector.ImputeMode (string value) { throw null; }
        public static bool operator !=(Azure.AI.AnomalyDetector.ImputeMode left, Azure.AI.AnomalyDetector.ImputeMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MultivariateAlignMode : System.IEquatable<Azure.AI.AnomalyDetector.MultivariateAlignMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MultivariateAlignMode(string value) { throw null; }
        public static Azure.AI.AnomalyDetector.MultivariateAlignMode Inner { get { throw null; } }
        public static Azure.AI.AnomalyDetector.MultivariateAlignMode Outer { get { throw null; } }
        public bool Equals(Azure.AI.AnomalyDetector.MultivariateAlignMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.AnomalyDetector.MultivariateAlignMode left, Azure.AI.AnomalyDetector.MultivariateAlignMode right) { throw null; }
        public static implicit operator Azure.AI.AnomalyDetector.MultivariateAlignMode (string value) { throw null; }
        public static bool operator !=(Azure.AI.AnomalyDetector.MultivariateAlignMode left, Azure.AI.AnomalyDetector.MultivariateAlignMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MultivariateBatchDetectionResultSummary
    {
        internal MultivariateBatchDetectionResultSummary() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.AnomalyDetector.ErrorResponse> Errors { get { throw null; } }
        public Azure.AI.AnomalyDetector.MultivariateBatchDetectionSettings SetupInfo { get { throw null; } }
        public Azure.AI.AnomalyDetector.MultivariateBatchDetectionStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.AnomalyDetector.MultivariateVariableState> VariableStates { get { throw null; } }
    }
    public partial class MultivariateBatchDetectionSettings
    {
        public MultivariateBatchDetectionSettings(System.Uri dataSource, System.DateTimeOffset startTime, System.DateTimeOffset endTime) { }
        public System.Uri DataSource { get { throw null; } set { } }
        public System.DateTimeOffset EndTime { get { throw null; } set { } }
        public System.DateTimeOffset StartTime { get { throw null; } set { } }
        public int? TopContributorCount { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MultivariateBatchDetectionStatus : System.IEquatable<Azure.AI.AnomalyDetector.MultivariateBatchDetectionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MultivariateBatchDetectionStatus(string value) { throw null; }
        public static Azure.AI.AnomalyDetector.MultivariateBatchDetectionStatus Created { get { throw null; } }
        public static Azure.AI.AnomalyDetector.MultivariateBatchDetectionStatus Failed { get { throw null; } }
        public static Azure.AI.AnomalyDetector.MultivariateBatchDetectionStatus Ready { get { throw null; } }
        public static Azure.AI.AnomalyDetector.MultivariateBatchDetectionStatus Running { get { throw null; } }
        public bool Equals(Azure.AI.AnomalyDetector.MultivariateBatchDetectionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.AnomalyDetector.MultivariateBatchDetectionStatus left, Azure.AI.AnomalyDetector.MultivariateBatchDetectionStatus right) { throw null; }
        public static implicit operator Azure.AI.AnomalyDetector.MultivariateBatchDetectionStatus (string value) { throw null; }
        public static bool operator !=(Azure.AI.AnomalyDetector.MultivariateBatchDetectionStatus left, Azure.AI.AnomalyDetector.MultivariateBatchDetectionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MultivariateDataSchema : System.IEquatable<Azure.AI.AnomalyDetector.MultivariateDataSchema>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MultivariateDataSchema(string value) { throw null; }
        public static Azure.AI.AnomalyDetector.MultivariateDataSchema MultiTable { get { throw null; } }
        public static Azure.AI.AnomalyDetector.MultivariateDataSchema OneTable { get { throw null; } }
        public bool Equals(Azure.AI.AnomalyDetector.MultivariateDataSchema other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.AnomalyDetector.MultivariateDataSchema left, Azure.AI.AnomalyDetector.MultivariateDataSchema right) { throw null; }
        public static implicit operator Azure.AI.AnomalyDetector.MultivariateDataSchema (string value) { throw null; }
        public static bool operator !=(Azure.AI.AnomalyDetector.MultivariateDataSchema left, Azure.AI.AnomalyDetector.MultivariateDataSchema right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MultivariateDetectionResult
    {
        internal MultivariateDetectionResult() { }
        public System.Guid ResultId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.AnomalyDetector.AnomalyState> Results { get { throw null; } }
        public Azure.AI.AnomalyDetector.MultivariateBatchDetectionResultSummary Summary { get { throw null; } }
    }
    public partial class MultivariateDiagnosticDetails
    {
        public MultivariateDiagnosticDetails() { }
        public Azure.AI.AnomalyDetector.MultivariateModelState ModelState { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.AnomalyDetector.MultivariateVariableState> VariableStates { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MultivariateFillNaMethod : System.IEquatable<Azure.AI.AnomalyDetector.MultivariateFillNaMethod>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MultivariateFillNaMethod(string value) { throw null; }
        public static Azure.AI.AnomalyDetector.MultivariateFillNaMethod Fixed { get { throw null; } }
        public static Azure.AI.AnomalyDetector.MultivariateFillNaMethod Linear { get { throw null; } }
        public static Azure.AI.AnomalyDetector.MultivariateFillNaMethod Previous { get { throw null; } }
        public static Azure.AI.AnomalyDetector.MultivariateFillNaMethod Subsequent { get { throw null; } }
        public static Azure.AI.AnomalyDetector.MultivariateFillNaMethod Zero { get { throw null; } }
        public bool Equals(Azure.AI.AnomalyDetector.MultivariateFillNaMethod other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.AnomalyDetector.MultivariateFillNaMethod left, Azure.AI.AnomalyDetector.MultivariateFillNaMethod right) { throw null; }
        public static implicit operator Azure.AI.AnomalyDetector.MultivariateFillNaMethod (string value) { throw null; }
        public static bool operator !=(Azure.AI.AnomalyDetector.MultivariateFillNaMethod left, Azure.AI.AnomalyDetector.MultivariateFillNaMethod right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MultivariateLastDetectionResult
    {
        internal MultivariateLastDetectionResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.AnomalyDetector.AnomalyState> Results { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.AnomalyDetector.MultivariateVariableState> VariableStates { get { throw null; } }
    }
    public partial class MultivariateLastDetectionSettings
    {
        public MultivariateLastDetectionSettings(System.Collections.Generic.IEnumerable<Azure.AI.AnomalyDetector.MultivariateVariableValue> variables) { }
        public int? TopContributorCount { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.AnomalyDetector.MultivariateVariableValue> Variables { get { throw null; } }
    }
    public partial class MultivariateModel
    {
        internal MultivariateModel() { }
        public System.DateTimeOffset CreatedTime { get { throw null; } }
        public System.DateTimeOffset LastUpdatedTime { get { throw null; } }
        public System.Guid ModelId { get { throw null; } }
        public Azure.AI.AnomalyDetector.MultivariateModelDetails ModelInfo { get { throw null; } }
    }
    public partial class MultivariateModelDetails
    {
        public MultivariateModelDetails(System.Uri dataSourceUri, System.DateTimeOffset startsOn, System.DateTimeOffset endsOn) { }
        public Azure.AI.AnomalyDetector.AlignPolicy AlignPolicy { get { throw null; } set { } }
        public Azure.AI.AnomalyDetector.MultivariateDataSchema? DataSchema { get { throw null; } set { } }
        public System.Uri DataSourceUri { get { throw null; } set { } }
        public Azure.AI.AnomalyDetector.MultivariateDiagnosticDetails DiagnosticsInfo { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public System.DateTimeOffset EndsOn { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.AnomalyDetector.ErrorResponse> Errors { get { throw null; } }
        public int? SlidingWindow { get { throw null; } set { } }
        public System.DateTimeOffset StartsOn { get { throw null; } set { } }
        public Azure.AI.AnomalyDetector.MultivariateModelStatus? Status { get { throw null; } }
    }
    public partial class MultivariateModelState
    {
        public MultivariateModelState() { }
        public System.Collections.Generic.IList<int> EpochIds { get { throw null; } }
        public System.Collections.Generic.IList<System.TimeSpan> LatenciesInSeconds { get { throw null; } }
        public System.Collections.Generic.IList<float> TrainLosses { get { throw null; } }
        public System.Collections.Generic.IList<float> ValidationLosses { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MultivariateModelStatus : System.IEquatable<Azure.AI.AnomalyDetector.MultivariateModelStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MultivariateModelStatus(string value) { throw null; }
        public static Azure.AI.AnomalyDetector.MultivariateModelStatus Created { get { throw null; } }
        public static Azure.AI.AnomalyDetector.MultivariateModelStatus Failed { get { throw null; } }
        public static Azure.AI.AnomalyDetector.MultivariateModelStatus Ready { get { throw null; } }
        public static Azure.AI.AnomalyDetector.MultivariateModelStatus Running { get { throw null; } }
        public bool Equals(Azure.AI.AnomalyDetector.MultivariateModelStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.AnomalyDetector.MultivariateModelStatus left, Azure.AI.AnomalyDetector.MultivariateModelStatus right) { throw null; }
        public static implicit operator Azure.AI.AnomalyDetector.MultivariateModelStatus (string value) { throw null; }
        public static bool operator !=(Azure.AI.AnomalyDetector.MultivariateModelStatus left, Azure.AI.AnomalyDetector.MultivariateModelStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MultivariateVariableState
    {
        public MultivariateVariableState(string variable) { }
        public int? EffectiveCount { get { throw null; } set { } }
        public float? FilledNARatio { get { throw null; } set { } }
        public System.DateTimeOffset? FirstTimestamp { get { throw null; } set { } }
        public System.DateTimeOffset? LastTimestamp { get { throw null; } set { } }
        public string Variable { get { throw null; } set { } }
    }
    public partial class MultivariateVariableValue
    {
        public MultivariateVariableValue(string variable, System.Collections.Generic.IEnumerable<System.DateTimeOffset> timestamps, System.Collections.Generic.IEnumerable<float> values) { }
        public System.Collections.Generic.IList<System.DateTimeOffset> Timestamps { get { throw null; } }
        public System.Collections.Generic.IList<float> Values { get { throw null; } }
        public string Variable { get { throw null; } }
    }
    public partial class UnivariateChangePointDetectionOptions
    {
        public UnivariateChangePointDetectionOptions(System.Collections.Generic.IEnumerable<Azure.AI.AnomalyDetector.UnivariateTimeSeriesPoint> series, Azure.AI.AnomalyDetector.UnivariateTimeGranularity granularity) { }
        public int? CustomInterval { get { throw null; } set { } }
        public Azure.AI.AnomalyDetector.UnivariateTimeGranularity Granularity { get { throw null; } }
        public int? Period { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.AnomalyDetector.UnivariateTimeSeriesPoint> Series { get { throw null; } }
        public int? StableTrendWindow { get { throw null; } set { } }
        public float? Threshold { get { throw null; } set { } }
    }
    public partial class UnivariateChangePointDetectionResult
    {
        internal UnivariateChangePointDetectionResult() { }
        public System.Collections.Generic.IReadOnlyList<float> ConfidenceScores { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<bool> IsChangePoint { get { throw null; } }
        public int? Period { get { throw null; } }
    }
    public partial class UnivariateDetectionOptions
    {
        public UnivariateDetectionOptions(System.Collections.Generic.IEnumerable<Azure.AI.AnomalyDetector.UnivariateTimeSeriesPoint> series) { }
        public int? CustomInterval { get { throw null; } set { } }
        public Azure.AI.AnomalyDetector.UnivariateTimeGranularity? Granularity { get { throw null; } set { } }
        public float? ImputeFixedValue { get { throw null; } set { } }
        public Azure.AI.AnomalyDetector.ImputeMode? ImputeMode { get { throw null; } set { } }
        public float? MaxAnomalyRatio { get { throw null; } set { } }
        public int? Period { get { throw null; } set { } }
        public int? Sensitivity { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.AnomalyDetector.UnivariateTimeSeriesPoint> Series { get { throw null; } }
    }
    public partial class UnivariateLastDetectionResult
    {
        internal UnivariateLastDetectionResult() { }
        public float ExpectedValue { get { throw null; } }
        public bool IsAnomaly { get { throw null; } }
        public bool IsNegativeAnomaly { get { throw null; } }
        public bool IsPositiveAnomaly { get { throw null; } }
        public float LowerMargin { get { throw null; } }
        public int Period { get { throw null; } }
        public float? Severity { get { throw null; } }
        public int SuggestedWindow { get { throw null; } }
        public float UpperMargin { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UnivariateTimeGranularity : System.IEquatable<Azure.AI.AnomalyDetector.UnivariateTimeGranularity>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UnivariateTimeGranularity(string value) { throw null; }
        public static Azure.AI.AnomalyDetector.UnivariateTimeGranularity Daily { get { throw null; } }
        public static Azure.AI.AnomalyDetector.UnivariateTimeGranularity Hourly { get { throw null; } }
        public static Azure.AI.AnomalyDetector.UnivariateTimeGranularity Monthly { get { throw null; } }
        public static Azure.AI.AnomalyDetector.UnivariateTimeGranularity None { get { throw null; } }
        public static Azure.AI.AnomalyDetector.UnivariateTimeGranularity PerMicrosecond { get { throw null; } }
        public static Azure.AI.AnomalyDetector.UnivariateTimeGranularity PerMinute { get { throw null; } }
        public static Azure.AI.AnomalyDetector.UnivariateTimeGranularity PerSecond { get { throw null; } }
        public static Azure.AI.AnomalyDetector.UnivariateTimeGranularity Weekly { get { throw null; } }
        public static Azure.AI.AnomalyDetector.UnivariateTimeGranularity Yearly { get { throw null; } }
        public bool Equals(Azure.AI.AnomalyDetector.UnivariateTimeGranularity other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.AnomalyDetector.UnivariateTimeGranularity left, Azure.AI.AnomalyDetector.UnivariateTimeGranularity right) { throw null; }
        public static implicit operator Azure.AI.AnomalyDetector.UnivariateTimeGranularity (string value) { throw null; }
        public static bool operator !=(Azure.AI.AnomalyDetector.UnivariateTimeGranularity left, Azure.AI.AnomalyDetector.UnivariateTimeGranularity right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UnivariateTimeSeriesPoint
    {
        public UnivariateTimeSeriesPoint(float value) { }
        public System.DateTimeOffset? Timestamp { get { throw null; } set { } }
        public float Value { get { throw null; } }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class AnomalyDetectorClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.AnomalyDetector.AnomalyDetectorClient, Azure.AI.AnomalyDetector.AnomalyDetectorClientOptions> AddAnomalyDetectorClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.AnomalyDetector.AnomalyDetectorClient, Azure.AI.AnomalyDetector.AnomalyDetectorClientOptions> AddAnomalyDetectorClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
