namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class Annotation : Azure.Health.Insights.ClinicalMatching.Element, System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Annotation>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Annotation>
    {
        public Annotation(string text) { }
        public string AuthorString { get { throw null; } set { } }
        public string Text { get { throw null; } }
        public string Time { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.Annotation System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Annotation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Annotation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.Annotation System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Annotation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Annotation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Annotation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AreaGeometry : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.AreaGeometry>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.AreaGeometry>
    {
        public AreaGeometry(Azure.Health.Insights.ClinicalMatching.GeoJsonGeometryType type, System.Collections.Generic.IEnumerable<float> coordinates) { }
        public System.Collections.Generic.IList<float> Coordinates { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.GeoJsonGeometryType Type { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.AreaGeometry System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.AreaGeometry>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.AreaGeometry>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.AreaGeometry System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.AreaGeometry>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.AreaGeometry>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.AreaGeometry>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AreaProperties : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.AreaProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.AreaProperties>
    {
        public AreaProperties(Azure.Health.Insights.ClinicalMatching.GeoJsonPropertiesSubType subType, double radius) { }
        public double Radius { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.GeoJsonPropertiesSubType SubType { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.AreaProperties System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.AreaProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.AreaProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.AreaProperties System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.AreaProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.AreaProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.AreaProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ClinicalCodedElement : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalCodedElement>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalCodedElement>
    {
        internal ClinicalCodedElement() { }
        public string Code { get { throw null; } }
        public string Name { get { throw null; } }
        public string System { get { throw null; } }
        public string Value { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.ClinicalCodedElement System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalCodedElement>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalCodedElement>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.ClinicalCodedElement System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalCodedElement>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalCodedElement>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalCodedElement>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ClinicalDocumentType : System.IEquatable<Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ClinicalDocumentType(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType Consultation { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType DischargeSummary { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType HistoryAndPhysical { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType Laboratory { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType PathologyReport { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType Procedure { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType Progress { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType RadiologyReport { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType left, Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType left, Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ClinicalMatchingClient
    {
        protected ClinicalMatchingClient() { }
        public ClinicalMatchingClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public ClinicalMatchingClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.Health.Insights.ClinicalMatching.ClinicalMatchingClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Operation<System.BinaryData> MatchTrials(Azure.WaitUntil waitUntil, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceResult> MatchTrials(Azure.WaitUntil waitUntil, Azure.Health.Insights.ClinicalMatching.TrialMatcherData trialMatcherData, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> MatchTrialsAsync(Azure.WaitUntil waitUntil, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceResult>> MatchTrialsAsync(Azure.WaitUntil waitUntil, Azure.Health.Insights.ClinicalMatching.TrialMatcherData trialMatcherData, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ClinicalMatchingClientOptions : Azure.Core.ClientOptions
    {
        public ClinicalMatchingClientOptions(Azure.Health.Insights.ClinicalMatching.ClinicalMatchingClientOptions.ServiceVersion version = Azure.Health.Insights.ClinicalMatching.ClinicalMatchingClientOptions.ServiceVersion.V2023_09_01_Preview) { }
        public enum ServiceVersion
        {
            V2023_09_01_Preview = 1,
        }
    }
    public partial class ClinicalNoteEvidence : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalNoteEvidence>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalNoteEvidence>
    {
        internal ClinicalNoteEvidence() { }
        public string Id { get { throw null; } }
        public int Length { get { throw null; } }
        public int Offset { get { throw null; } }
        public string Text { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.ClinicalNoteEvidence System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalNoteEvidence>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalNoteEvidence>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.ClinicalNoteEvidence System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalNoteEvidence>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalNoteEvidence>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalNoteEvidence>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ClinicalTrialMetadata : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialMetadata>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialMetadata>
    {
        internal ClinicalTrialMetadata() { }
        public System.Collections.Generic.IReadOnlyList<string> Conditions { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Health.Insights.ClinicalMatching.ContactDetails> Contacts { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Health.Insights.ClinicalMatching.ClinicalTrialResearchFacility> Facilities { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase> Phases { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.ClinicalTrialRecruitmentStatus? RecruitmentStatus { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Sponsors { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.ClinicalTrialStudyType? StudyType { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.ClinicalTrialMetadata System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialMetadata>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.ClinicalTrialMetadata System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialMetadata>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialMetadata>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialMetadata>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ClinicalTrialPhase : System.IEquatable<Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ClinicalTrialPhase(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase EarlyPhase1 { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase NotApplicable { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase Phase1 { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase Phase2 { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase Phase3 { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase Phase4 { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase left, Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase left, Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ClinicalTrialPurpose : System.IEquatable<Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ClinicalTrialPurpose(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose BasicScience { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose DeviceFeasibility { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose Diagnostic { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose HealthServicesResearch { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose NotApplicable { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose Other { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose Prevention { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose Screening { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose SupportiveCare { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose Treatment { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose left, Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose left, Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ClinicalTrialRecruitmentStatus : System.IEquatable<Azure.Health.Insights.ClinicalMatching.ClinicalTrialRecruitmentStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ClinicalTrialRecruitmentStatus(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialRecruitmentStatus EnrollingByInvitation { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialRecruitmentStatus NotYetRecruiting { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialRecruitmentStatus Recruiting { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialRecruitmentStatus UnknownStatus { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.ClinicalTrialRecruitmentStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.ClinicalTrialRecruitmentStatus left, Azure.Health.Insights.ClinicalMatching.ClinicalTrialRecruitmentStatus right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.ClinicalTrialRecruitmentStatus (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.ClinicalTrialRecruitmentStatus left, Azure.Health.Insights.ClinicalMatching.ClinicalTrialRecruitmentStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ClinicalTrialRegistryFilter : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialRegistryFilter>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialRegistryFilter>
    {
        public ClinicalTrialRegistryFilter() { }
        public System.Collections.Generic.IList<string> Conditions { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.GeographicArea> FacilityAreas { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.GeographicLocation> FacilityLocations { get { throw null; } }
        public System.Collections.Generic.IList<string> FacilityNames { get { throw null; } }
        public System.Collections.Generic.IList<string> Ids { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase> Phases { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.ClinicalTrialPurpose> Purposes { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.ClinicalTrialRecruitmentStatus> RecruitmentStatuses { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.ClinicalTrialSource> Sources { get { throw null; } }
        public System.Collections.Generic.IList<string> Sponsors { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.ClinicalTrialStudyType> StudyTypes { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.ClinicalTrialRegistryFilter System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialRegistryFilter>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialRegistryFilter>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.ClinicalTrialRegistryFilter System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialRegistryFilter>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialRegistryFilter>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialRegistryFilter>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ClinicalTrialResearchFacility : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialResearchFacility>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialResearchFacility>
    {
        internal ClinicalTrialResearchFacility() { }
        public string City { get { throw null; } }
        public string CountryOrRegion { get { throw null; } }
        public string Name { get { throw null; } }
        public string State { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.ClinicalTrialResearchFacility System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialResearchFacility>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialResearchFacility>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.ClinicalTrialResearchFacility System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialResearchFacility>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialResearchFacility>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrialResearchFacility>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ClinicalTrials : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrials>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrials>
    {
        public ClinicalTrials() { }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.ResearchStudy> CustomTrials { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.ClinicalTrialRegistryFilter> RegistryFilters { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.ClinicalTrials System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrials>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrials>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.ClinicalTrials System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrials>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrials>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ClinicalTrials>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ClinicalTrialSource : System.IEquatable<Azure.Health.Insights.ClinicalMatching.ClinicalTrialSource>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ClinicalTrialSource(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialSource ClinicaltrialsGov { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialSource Custom { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.ClinicalTrialSource other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.ClinicalTrialSource left, Azure.Health.Insights.ClinicalMatching.ClinicalTrialSource right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.ClinicalTrialSource (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.ClinicalTrialSource left, Azure.Health.Insights.ClinicalMatching.ClinicalTrialSource right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ClinicalTrialStudyType : System.IEquatable<Azure.Health.Insights.ClinicalMatching.ClinicalTrialStudyType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ClinicalTrialStudyType(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialStudyType ExpandedAccess { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialStudyType Interventional { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialStudyType Observational { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialStudyType PatientRegistries { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.ClinicalTrialStudyType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.ClinicalTrialStudyType left, Azure.Health.Insights.ClinicalMatching.ClinicalTrialStudyType right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.ClinicalTrialStudyType (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.ClinicalTrialStudyType left, Azure.Health.Insights.ClinicalMatching.ClinicalTrialStudyType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CodeableConcept : Azure.Health.Insights.ClinicalMatching.Element, System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.CodeableConcept>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.CodeableConcept>
    {
        public CodeableConcept() { }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.Coding> Coding { get { throw null; } }
        public string Text { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.CodeableConcept System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.CodeableConcept>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.CodeableConcept>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.CodeableConcept System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.CodeableConcept>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.CodeableConcept>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.CodeableConcept>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Coding : Azure.Health.Insights.ClinicalMatching.Element, System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Coding>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Coding>
    {
        public Coding() { }
        public string Code { get { throw null; } set { } }
        public string Display { get { throw null; } set { } }
        public string System { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.Coding System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Coding>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Coding>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.Coding System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Coding>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Coding>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Coding>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContactDetail : Azure.Health.Insights.ClinicalMatching.Element, System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ContactDetail>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ContactDetail>
    {
        public ContactDetail() { }
        public string Name { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.ContactPoint> Telecom { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.ContactDetail System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ContactDetail>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ContactDetail>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.ContactDetail System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ContactDetail>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ContactDetail>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ContactDetail>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContactDetails : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ContactDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ContactDetails>
    {
        internal ContactDetails() { }
        public string Email { get { throw null; } }
        public string Name { get { throw null; } }
        public string Phone { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.ContactDetails System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ContactDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ContactDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.ContactDetails System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ContactDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ContactDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ContactDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContactPoint : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ContactPoint>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ContactPoint>
    {
        public ContactPoint() { }
        public Azure.Health.Insights.ClinicalMatching.Period Period { get { throw null; } set { } }
        public int? Rank { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.ContactPointSystem? System { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.ContactPointUse? Use { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.ContactPoint System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ContactPoint>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ContactPoint>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.ContactPoint System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ContactPoint>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ContactPoint>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ContactPoint>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContactPointSystem : System.IEquatable<Azure.Health.Insights.ClinicalMatching.ContactPointSystem>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContactPointSystem(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ContactPointSystem Email { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ContactPointSystem Fax { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ContactPointSystem Other { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ContactPointSystem Pager { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ContactPointSystem Phone { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ContactPointSystem Sms { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ContactPointSystem Url { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.ContactPointSystem other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.ContactPointSystem left, Azure.Health.Insights.ClinicalMatching.ContactPointSystem right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.ContactPointSystem (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.ContactPointSystem left, Azure.Health.Insights.ClinicalMatching.ContactPointSystem right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContactPointUse : System.IEquatable<Azure.Health.Insights.ClinicalMatching.ContactPointUse>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContactPointUse(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ContactPointUse Home { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ContactPointUse Mobile { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ContactPointUse Old { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ContactPointUse Temp { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ContactPointUse Work { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.ContactPointUse other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.ContactPointUse left, Azure.Health.Insights.ClinicalMatching.ContactPointUse right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.ContactPointUse (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.ContactPointUse left, Azure.Health.Insights.ClinicalMatching.ContactPointUse right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DocumentAdministrativeMetadata : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.DocumentAdministrativeMetadata>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DocumentAdministrativeMetadata>
    {
        public DocumentAdministrativeMetadata() { }
        public string EncounterId { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.OrderedProcedure> OrderedProcedures { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.DocumentAdministrativeMetadata System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.DocumentAdministrativeMetadata>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.DocumentAdministrativeMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.DocumentAdministrativeMetadata System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DocumentAdministrativeMetadata>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DocumentAdministrativeMetadata>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DocumentAdministrativeMetadata>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentAuthor : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.DocumentAuthor>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DocumentAuthor>
    {
        public DocumentAuthor() { }
        public string FullName { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.DocumentAuthor System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.DocumentAuthor>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.DocumentAuthor>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.DocumentAuthor System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DocumentAuthor>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DocumentAuthor>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DocumentAuthor>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentContent : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.DocumentContent>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DocumentContent>
    {
        public DocumentContent(Azure.Health.Insights.ClinicalMatching.DocumentContentSourceType sourceType, string value) { }
        public Azure.Health.Insights.ClinicalMatching.DocumentContentSourceType SourceType { get { throw null; } }
        public string Value { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.DocumentContent System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.DocumentContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.DocumentContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.DocumentContent System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DocumentContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DocumentContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DocumentContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DocumentContentSourceType : System.IEquatable<Azure.Health.Insights.ClinicalMatching.DocumentContentSourceType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DocumentContentSourceType(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.DocumentContentSourceType Inline { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.DocumentContentSourceType Reference { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.DocumentContentSourceType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.DocumentContentSourceType left, Azure.Health.Insights.ClinicalMatching.DocumentContentSourceType right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.DocumentContentSourceType (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.DocumentContentSourceType left, Azure.Health.Insights.ClinicalMatching.DocumentContentSourceType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DocumentType : System.IEquatable<Azure.Health.Insights.ClinicalMatching.DocumentType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DocumentType(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.DocumentType Dicom { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.DocumentType FhirBundle { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.DocumentType GenomicSequencing { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.DocumentType Note { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.DocumentType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.DocumentType left, Azure.Health.Insights.ClinicalMatching.DocumentType right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.DocumentType (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.DocumentType left, Azure.Health.Insights.ClinicalMatching.DocumentType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class DomainResource : Azure.Health.Insights.ClinicalMatching.Resource, System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.DomainResource>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DomainResource>
    {
        protected DomainResource(string resourceType) : base (default(string)) { }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.Resource> Contained { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.Extension> Extension { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.Extension> ModifierExtension { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.Narrative Text { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.DomainResource System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.DomainResource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.DomainResource>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.DomainResource System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DomainResource>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DomainResource>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.DomainResource>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Element : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Element>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Element>
    {
        internal Element() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Health.Insights.ClinicalMatching.Extension> Extension { get { throw null; } }
        public string Id { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.Element System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Element>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Element>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.Element System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Element>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Element>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Element>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Encounter : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Encounter>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Encounter>
    {
        public Encounter(string id) { }
        public Azure.Health.Insights.ClinicalMatching.EncounterClass? Class { get { throw null; } set { } }
        public string Id { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.TimePeriod Period { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.Encounter System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Encounter>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Encounter>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.Encounter System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Encounter>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Encounter>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Encounter>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EncounterClass : System.IEquatable<Azure.Health.Insights.ClinicalMatching.EncounterClass>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EncounterClass(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.EncounterClass Ambulatory { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.EncounterClass Emergency { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.EncounterClass HealthHome { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.EncounterClass InPatient { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.EncounterClass Observation { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.EncounterClass Virtual { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.EncounterClass other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.EncounterClass left, Azure.Health.Insights.ClinicalMatching.EncounterClass right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.EncounterClass (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.EncounterClass left, Azure.Health.Insights.ClinicalMatching.EncounterClass right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ExtendedClinicalCodedElement : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ExtendedClinicalCodedElement>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ExtendedClinicalCodedElement>
    {
        internal ExtendedClinicalCodedElement() { }
        public string Category { get { throw null; } }
        public string Code { get { throw null; } }
        public string Name { get { throw null; } }
        public string SemanticType { get { throw null; } }
        public string System { get { throw null; } }
        public string Value { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.ExtendedClinicalCodedElement System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ExtendedClinicalCodedElement>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ExtendedClinicalCodedElement>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.ExtendedClinicalCodedElement System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ExtendedClinicalCodedElement>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ExtendedClinicalCodedElement>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ExtendedClinicalCodedElement>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Extension : Azure.Health.Insights.ClinicalMatching.Element, System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Extension>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Extension>
    {
        public Extension(string url) { }
        public string Url { get { throw null; } }
        public bool? ValueBoolean { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.CodeableConcept ValueCodeableConcept { get { throw null; } set { } }
        public string ValueDateTime { get { throw null; } set { } }
        public int? ValueInteger { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.Period ValuePeriod { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.Quantity ValueQuantity { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.Range ValueRange { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.Ratio ValueRatio { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.Reference ValueReference { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.SampledData ValueSampledData { get { throw null; } set { } }
        public string ValueString { get { throw null; } set { } }
        public System.TimeSpan? ValueTime { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.Extension System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Extension>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Extension>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.Extension System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Extension>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Extension>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Extension>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GeographicArea : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.GeographicArea>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.GeographicArea>
    {
        public GeographicArea(Azure.Health.Insights.ClinicalMatching.GeoJsonType type, Azure.Health.Insights.ClinicalMatching.AreaGeometry geometry, Azure.Health.Insights.ClinicalMatching.AreaProperties properties) { }
        public Azure.Health.Insights.ClinicalMatching.AreaGeometry Geometry { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.AreaProperties Properties { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.GeoJsonType Type { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.GeographicArea System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.GeographicArea>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.GeographicArea>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.GeographicArea System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.GeographicArea>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.GeographicArea>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.GeographicArea>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GeographicLocation : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.GeographicLocation>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.GeographicLocation>
    {
        public GeographicLocation(string countryOrRegion) { }
        public string City { get { throw null; } set { } }
        public string CountryOrRegion { get { throw null; } }
        public string State { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.GeographicLocation System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.GeographicLocation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.GeographicLocation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.GeographicLocation System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.GeographicLocation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.GeographicLocation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.GeographicLocation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct GeoJsonGeometryType : System.IEquatable<Azure.Health.Insights.ClinicalMatching.GeoJsonGeometryType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public GeoJsonGeometryType(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.GeoJsonGeometryType Point { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.GeoJsonGeometryType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.GeoJsonGeometryType left, Azure.Health.Insights.ClinicalMatching.GeoJsonGeometryType right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.GeoJsonGeometryType (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.GeoJsonGeometryType left, Azure.Health.Insights.ClinicalMatching.GeoJsonGeometryType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct GeoJsonPropertiesSubType : System.IEquatable<Azure.Health.Insights.ClinicalMatching.GeoJsonPropertiesSubType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public GeoJsonPropertiesSubType(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.GeoJsonPropertiesSubType Circle { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.GeoJsonPropertiesSubType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.GeoJsonPropertiesSubType left, Azure.Health.Insights.ClinicalMatching.GeoJsonPropertiesSubType right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.GeoJsonPropertiesSubType (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.GeoJsonPropertiesSubType left, Azure.Health.Insights.ClinicalMatching.GeoJsonPropertiesSubType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct GeoJsonType : System.IEquatable<Azure.Health.Insights.ClinicalMatching.GeoJsonType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public GeoJsonType(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.GeoJsonType Feature { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.GeoJsonType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.GeoJsonType left, Azure.Health.Insights.ClinicalMatching.GeoJsonType right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.GeoJsonType (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.GeoJsonType left, Azure.Health.Insights.ClinicalMatching.GeoJsonType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class HealthInsightsClinicalMatchingModelFactory
    {
        public static Azure.Health.Insights.ClinicalMatching.Annotation Annotation(string id = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null, string authorString = null, string time = null, string text = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalCodedElement ClinicalCodedElement(string system = null, string code = null, string name = null, string value = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalNoteEvidence ClinicalNoteEvidence(string id = null, string text = null, int offset = 0, int length = 0) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialMetadata ClinicalTrialMetadata(System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.ClinicalTrialPhase> phases = null, Azure.Health.Insights.ClinicalMatching.ClinicalTrialStudyType? studyType = default(Azure.Health.Insights.ClinicalMatching.ClinicalTrialStudyType?), Azure.Health.Insights.ClinicalMatching.ClinicalTrialRecruitmentStatus? recruitmentStatus = default(Azure.Health.Insights.ClinicalMatching.ClinicalTrialRecruitmentStatus?), System.Collections.Generic.IEnumerable<string> conditions = null, System.Collections.Generic.IEnumerable<string> sponsors = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.ContactDetails> contacts = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.ClinicalTrialResearchFacility> facilities = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ClinicalTrialResearchFacility ClinicalTrialResearchFacility(string name = null, string city = null, string state = null, string countryOrRegion = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.CodeableConcept CodeableConcept(string id = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Coding> coding = null, string text = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.Coding Coding(string id = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null, string system = null, string version = null, string code = null, string display = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ContactDetail ContactDetail(string id = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null, string name = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.ContactPoint> telecom = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ContactDetails ContactDetails(string name = null, string email = null, string phone = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.DomainResource DomainResource(string resourceType = null, string id = null, Azure.Health.Insights.ClinicalMatching.Meta meta = null, string implicitRules = null, string language = null, System.Collections.Generic.IDictionary<string, System.BinaryData> additionalProperties = null, Azure.Health.Insights.ClinicalMatching.Narrative text = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Resource> contained = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> modifierExtension = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.Element Element(string id = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.Encounter Encounter(string id = null, Azure.Health.Insights.ClinicalMatching.TimePeriod period = null, Azure.Health.Insights.ClinicalMatching.EncounterClass? @class = default(Azure.Health.Insights.ClinicalMatching.EncounterClass?)) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ExtendedClinicalCodedElement ExtendedClinicalCodedElement(string system = null, string code = null, string name = null, string value = null, string semanticType = null, string category = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.Extension Extension(string id = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null, string url = null, Azure.Health.Insights.ClinicalMatching.Quantity valueQuantity = null, Azure.Health.Insights.ClinicalMatching.CodeableConcept valueCodeableConcept = null, string valueString = null, bool? valueBoolean = default(bool?), int? valueInteger = default(int?), Azure.Health.Insights.ClinicalMatching.Range valueRange = null, Azure.Health.Insights.ClinicalMatching.Ratio valueRatio = null, Azure.Health.Insights.ClinicalMatching.SampledData valueSampledData = null, System.TimeSpan? valueTime = default(System.TimeSpan?), string valueDateTime = null, Azure.Health.Insights.ClinicalMatching.Period valuePeriod = null, Azure.Health.Insights.ClinicalMatching.Reference valueReference = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.GeographicLocation GeographicLocation(string city = null, string state = null, string countryOrRegion = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.Identifier Identifier(string id = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null, string use = null, Azure.Health.Insights.ClinicalMatching.CodeableConcept type = null, string system = null, string value = null, Azure.Health.Insights.ClinicalMatching.Period period = null, Azure.Health.Insights.ClinicalMatching.Reference assigner = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.Narrative Narrative(string id = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null, string status = null, string div = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.PatientDocument PatientDocument(Azure.Health.Insights.ClinicalMatching.DocumentType type = default(Azure.Health.Insights.ClinicalMatching.DocumentType), Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType? clinicalType = default(Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType?), string id = null, string language = null, System.DateTimeOffset? createdDateTime = default(System.DateTimeOffset?), System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.DocumentAuthor> authors = null, Azure.Health.Insights.ClinicalMatching.SpecialtyType? specialtyType = default(Azure.Health.Insights.ClinicalMatching.SpecialtyType?), Azure.Health.Insights.ClinicalMatching.DocumentAdministrativeMetadata administrativeMetadata = null, Azure.Health.Insights.ClinicalMatching.DocumentContent content = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.PatientRecord PatientRecord(string id = null, Azure.Health.Insights.ClinicalMatching.PatientInfo info = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Encounter> encounters = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.PatientDocument> patientDocuments = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.Period Period(string id = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null, string start = null, string end = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.Quantity Quantity(string id = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null, double? value = default(double?), string comparator = null, string unit = null, string system = null, string code = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.Range Range(string id = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null, Azure.Health.Insights.ClinicalMatching.Quantity low = null, Azure.Health.Insights.ClinicalMatching.Quantity high = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.Ratio Ratio(string id = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null, Azure.Health.Insights.ClinicalMatching.Quantity numerator = null, Azure.Health.Insights.ClinicalMatching.Quantity denominator = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.Reference Reference(string id = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null, string referenceProperty = null, string type = null, Azure.Health.Insights.ClinicalMatching.Identifier identifier = null, string display = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ResearchStudy ResearchStudy(string id = null, Azure.Health.Insights.ClinicalMatching.Meta meta = null, string implicitRules = null, string language = null, System.Collections.Generic.IDictionary<string, System.BinaryData> additionalProperties = null, Azure.Health.Insights.ClinicalMatching.Narrative text = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Resource> contained = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> modifierExtension = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Identifier> identifier = null, string title = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Reference> protocol = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Reference> partOf = null, Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType status = default(Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType), Azure.Health.Insights.ClinicalMatching.CodeableConcept primaryPurposeType = null, Azure.Health.Insights.ClinicalMatching.CodeableConcept phase = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.CodeableConcept> category = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.CodeableConcept> focus = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.CodeableConcept> condition = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.ContactDetail> contact = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.CodeableConcept> keyword = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.CodeableConcept> location = null, string description = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Reference> enrollment = null, Azure.Health.Insights.ClinicalMatching.Period period = null, Azure.Health.Insights.ClinicalMatching.Reference sponsor = null, Azure.Health.Insights.ClinicalMatching.Reference principalInvestigator = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Reference> site = null, Azure.Health.Insights.ClinicalMatching.CodeableConcept reasonStopped = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Annotation> note = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.ResearchStudyArm> arm = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.ResearchStudyObjective> objective = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ResearchStudyArm ResearchStudyArm(string name = null, Azure.Health.Insights.ClinicalMatching.CodeableConcept type = null, string description = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ResearchStudyObjective ResearchStudyObjective(string name = null, Azure.Health.Insights.ClinicalMatching.CodeableConcept type = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.Resource Resource(string resourceType = null, string id = null, Azure.Health.Insights.ClinicalMatching.Meta meta = null, string implicitRules = null, string language = null, System.Collections.Generic.IDictionary<string, System.BinaryData> additionalProperties = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.SampledData SampledData(string id = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.Extension> extension = null, Azure.Health.Insights.ClinicalMatching.Quantity origin = null, double period = 0, double? factor = default(double?), double? lowerLimit = default(double?), double? upperLimit = default(double?), int dimensions = 0, string data = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.TrialMatcherInference TrialMatcherInference(Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceType type = default(Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceType), string value = null, string description = null, float? confidenceScore = default(float?), System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceEvidence> evidence = null, string clinicalTrialId = null, Azure.Health.Insights.ClinicalMatching.ClinicalTrialSource? source = default(Azure.Health.Insights.ClinicalMatching.ClinicalTrialSource?), Azure.Health.Insights.ClinicalMatching.ClinicalTrialMetadata metadata = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceEvidence TrialMatcherInferenceEvidence(string eligibilityCriteriaEvidence = null, Azure.Health.Insights.ClinicalMatching.ClinicalNoteEvidence patientDataEvidence = null, Azure.Health.Insights.ClinicalMatching.ClinicalCodedElement patientInfoEvidence = null, float? importance = default(float?)) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceResult TrialMatcherInferenceResult(System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.TrialMatcherPatientResult> patientResults = null, string modelVersion = null, System.DateTimeOffset? knowledgeGraphLastUpdateDate = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.TrialMatcherModelConfiguration TrialMatcherModelConfiguration(bool? verbose = default(bool?), bool? includeEvidence = default(bool?), Azure.Health.Insights.ClinicalMatching.ClinicalTrials clinicalTrials = null) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.TrialMatcherPatientResult TrialMatcherPatientResult(string patientId = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.TrialMatcherInference> inferences = null, System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.ExtendedClinicalCodedElement> neededClinicalInfo = null) { throw null; }
    }
    public partial class Identifier : Azure.Health.Insights.ClinicalMatching.Element, System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Identifier>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Identifier>
    {
        public Identifier() { }
        public Azure.Health.Insights.ClinicalMatching.Reference Assigner { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.Period Period { get { throw null; } set { } }
        public string System { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.CodeableConcept Type { get { throw null; } set { } }
        public string Use { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.Identifier System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Identifier>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Identifier>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.Identifier System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Identifier>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Identifier>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Identifier>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Meta : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Meta>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Meta>
    {
        public Meta() { }
        public string LastUpdated { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Profile { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.Coding> Security { get { throw null; } }
        public string Source { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.Coding> Tag { get { throw null; } }
        public string VersionId { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.Meta System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Meta>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Meta>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.Meta System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Meta>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Meta>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Meta>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Narrative : Azure.Health.Insights.ClinicalMatching.Element, System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Narrative>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Narrative>
    {
        public Narrative(string status, string div) { }
        public string Div { get { throw null; } }
        public string Status { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.Narrative System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Narrative>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Narrative>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.Narrative System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Narrative>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Narrative>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Narrative>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OrderedProcedure : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.OrderedProcedure>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.OrderedProcedure>
    {
        public OrderedProcedure() { }
        public Azure.Health.Insights.ClinicalMatching.CodeableConcept Code { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.Extension> Extension { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.OrderedProcedure System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.OrderedProcedure>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.OrderedProcedure>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.OrderedProcedure System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.OrderedProcedure>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.OrderedProcedure>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.OrderedProcedure>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PatientDocument : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.PatientDocument>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.PatientDocument>
    {
        public PatientDocument(Azure.Health.Insights.ClinicalMatching.DocumentType type, string id, Azure.Health.Insights.ClinicalMatching.DocumentContent content) { }
        public Azure.Health.Insights.ClinicalMatching.DocumentAdministrativeMetadata AdministrativeMetadata { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.DocumentAuthor> Authors { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.ClinicalDocumentType? ClinicalType { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.DocumentContent Content { get { throw null; } }
        public System.DateTimeOffset? CreatedDateTime { get { throw null; } set { } }
        public string Id { get { throw null; } }
        public string Language { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.SpecialtyType? SpecialtyType { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.DocumentType Type { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.PatientDocument System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.PatientDocument>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.PatientDocument>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.PatientDocument System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.PatientDocument>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.PatientDocument>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.PatientDocument>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PatientInfo : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.PatientInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.PatientInfo>
    {
        public PatientInfo() { }
        public System.DateTimeOffset? BirthDate { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.Resource> ClinicalInfo { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.PatientInfoSex? Sex { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.PatientInfo System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.PatientInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.PatientInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.PatientInfo System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.PatientInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.PatientInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.PatientInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PatientInfoSex : System.IEquatable<Azure.Health.Insights.ClinicalMatching.PatientInfoSex>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PatientInfoSex(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.PatientInfoSex Female { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.PatientInfoSex Male { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.PatientInfoSex Unspecified { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.PatientInfoSex other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.PatientInfoSex left, Azure.Health.Insights.ClinicalMatching.PatientInfoSex right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.PatientInfoSex (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.PatientInfoSex left, Azure.Health.Insights.ClinicalMatching.PatientInfoSex right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PatientRecord : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.PatientRecord>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.PatientRecord>
    {
        public PatientRecord(string id) { }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.Encounter> Encounters { get { throw null; } }
        public string Id { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.PatientInfo Info { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.PatientDocument> PatientDocuments { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.PatientRecord System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.PatientRecord>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.PatientRecord>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.PatientRecord System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.PatientRecord>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.PatientRecord>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.PatientRecord>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Period : Azure.Health.Insights.ClinicalMatching.Element, System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Period>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Period>
    {
        public Period() { }
        public string End { get { throw null; } set { } }
        public string Start { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.Period System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Period>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Period>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.Period System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Period>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Period>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Period>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Quantity : Azure.Health.Insights.ClinicalMatching.Element, System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Quantity>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Quantity>
    {
        public Quantity() { }
        public string Code { get { throw null; } set { } }
        public string Comparator { get { throw null; } set { } }
        public string System { get { throw null; } set { } }
        public string Unit { get { throw null; } set { } }
        public double? Value { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.Quantity System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Quantity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Quantity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.Quantity System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Quantity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Quantity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Quantity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Range : Azure.Health.Insights.ClinicalMatching.Element, System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Range>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Range>
    {
        public Range() { }
        public Azure.Health.Insights.ClinicalMatching.Quantity High { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.Quantity Low { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.Range System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Range>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Range>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.Range System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Range>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Range>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Range>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Ratio : Azure.Health.Insights.ClinicalMatching.Element, System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Ratio>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Ratio>
    {
        public Ratio() { }
        public Azure.Health.Insights.ClinicalMatching.Quantity Denominator { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.Quantity Numerator { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.Ratio System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Ratio>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Ratio>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.Ratio System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Ratio>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Ratio>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Ratio>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Reference : Azure.Health.Insights.ClinicalMatching.Element, System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Reference>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Reference>
    {
        public Reference() { }
        public string Display { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.Identifier Identifier { get { throw null; } set { } }
        public string ReferenceProperty { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.Reference System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Reference>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Reference>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.Reference System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Reference>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Reference>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Reference>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResearchStudy : Azure.Health.Insights.ClinicalMatching.DomainResource, System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ResearchStudy>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ResearchStudy>
    {
        public ResearchStudy(Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType status) : base (default(string)) { }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.ResearchStudyArm> Arm { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.CodeableConcept> Category { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.CodeableConcept> Condition { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.ContactDetail> Contact { get { throw null; } }
        public string Description { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.Reference> Enrollment { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.CodeableConcept> Focus { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.Identifier> Identifier { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.CodeableConcept> Keyword { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.CodeableConcept> Location { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.Annotation> Note { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.ResearchStudyObjective> Objective { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.Reference> PartOf { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.Period Period { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.CodeableConcept Phase { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.CodeableConcept PrimaryPurposeType { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.Reference PrincipalInvestigator { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.Reference> Protocol { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.CodeableConcept ReasonStopped { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.Reference> Site { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.Reference Sponsor { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType Status { get { throw null; } }
        public string Title { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.ResearchStudy System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ResearchStudy>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ResearchStudy>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.ResearchStudy System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ResearchStudy>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ResearchStudy>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ResearchStudy>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResearchStudyArm : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ResearchStudyArm>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ResearchStudyArm>
    {
        public ResearchStudyArm(string name) { }
        public string Description { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.CodeableConcept Type { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.ResearchStudyArm System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ResearchStudyArm>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ResearchStudyArm>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.ResearchStudyArm System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ResearchStudyArm>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ResearchStudyArm>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ResearchStudyArm>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResearchStudyObjective : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ResearchStudyObjective>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ResearchStudyObjective>
    {
        public ResearchStudyObjective(string name) { }
        public string Name { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.CodeableConcept Type { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.ResearchStudyObjective System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ResearchStudyObjective>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.ResearchStudyObjective>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.ResearchStudyObjective System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ResearchStudyObjective>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ResearchStudyObjective>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.ResearchStudyObjective>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResearchStudyStatusCodeType : System.IEquatable<Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResearchStudyStatusCodeType(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType Active { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType AdministrativelyCompleted { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType Approved { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType ClosedToAccrual { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType ClosedToAccrualAndIntervention { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType Completed { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType Disapproved { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType InReview { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType TemporarilyClosedToAccrual { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType TemporarilyClosedToAccrualAndIntervention { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType Withdrawn { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType left, Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType left, Azure.Health.Insights.ClinicalMatching.ResearchStudyStatusCodeType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Resource : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Resource>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Resource>
    {
        public Resource(string resourceType) { }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> AdditionalProperties { get { throw null; } }
        public string Id { get { throw null; } set { } }
        public string ImplicitRules { get { throw null; } set { } }
        public string Language { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.Meta Meta { get { throw null; } set { } }
        public string ResourceType { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.Resource System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Resource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.Resource>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.Resource System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Resource>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Resource>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.Resource>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SampledData : Azure.Health.Insights.ClinicalMatching.Element, System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.SampledData>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.SampledData>
    {
        public SampledData(Azure.Health.Insights.ClinicalMatching.Quantity origin, double period, int dimensions) { }
        public string Data { get { throw null; } set { } }
        public int Dimensions { get { throw null; } }
        public double? Factor { get { throw null; } set { } }
        public double? LowerLimit { get { throw null; } set { } }
        public Azure.Health.Insights.ClinicalMatching.Quantity Origin { get { throw null; } }
        public double Period { get { throw null; } }
        public double? UpperLimit { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.SampledData System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.SampledData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.SampledData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.SampledData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.SampledData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.SampledData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.SampledData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SpecialtyType : System.IEquatable<Azure.Health.Insights.ClinicalMatching.SpecialtyType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SpecialtyType(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.SpecialtyType Pathology { get { throw null; } }
        public static Azure.Health.Insights.ClinicalMatching.SpecialtyType Radiology { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.SpecialtyType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.SpecialtyType left, Azure.Health.Insights.ClinicalMatching.SpecialtyType right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.SpecialtyType (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.SpecialtyType left, Azure.Health.Insights.ClinicalMatching.SpecialtyType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TimePeriod : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TimePeriod>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TimePeriod>
    {
        public TimePeriod() { }
        public System.DateTimeOffset? End { get { throw null; } set { } }
        public System.DateTimeOffset? Start { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.TimePeriod System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TimePeriod>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TimePeriod>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.TimePeriod System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TimePeriod>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TimePeriod>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TimePeriod>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrialMatcherData : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherData>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherData>
    {
        public TrialMatcherData(System.Collections.Generic.IEnumerable<Azure.Health.Insights.ClinicalMatching.PatientRecord> patients) { }
        public Azure.Health.Insights.ClinicalMatching.TrialMatcherModelConfiguration Configuration { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.Health.Insights.ClinicalMatching.PatientRecord> Patients { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.TrialMatcherData System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.TrialMatcherData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrialMatcherInference : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInference>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInference>
    {
        internal TrialMatcherInference() { }
        public string ClinicalTrialId { get { throw null; } }
        public float? ConfidenceScore { get { throw null; } }
        public string Description { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceEvidence> Evidence { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.ClinicalTrialMetadata Metadata { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.ClinicalTrialSource? Source { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceType Type { get { throw null; } }
        public string Value { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.TrialMatcherInference System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInference>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInference>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.TrialMatcherInference System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInference>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInference>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInference>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrialMatcherInferenceEvidence : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceEvidence>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceEvidence>
    {
        internal TrialMatcherInferenceEvidence() { }
        public string EligibilityCriteriaEvidence { get { throw null; } }
        public float? Importance { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.ClinicalNoteEvidence PatientDataEvidence { get { throw null; } }
        public Azure.Health.Insights.ClinicalMatching.ClinicalCodedElement PatientInfoEvidence { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceEvidence System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceEvidence>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceEvidence>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceEvidence System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceEvidence>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceEvidence>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceEvidence>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrialMatcherInferenceResult : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceResult>
    {
        internal TrialMatcherInferenceResult() { }
        public System.DateTimeOffset? KnowledgeGraphLastUpdateDate { get { throw null; } }
        public string ModelVersion { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Health.Insights.ClinicalMatching.TrialMatcherPatientResult> PatientResults { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceResult System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceResult System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TrialMatcherInferenceType : System.IEquatable<Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TrialMatcherInferenceType(string value) { throw null; }
        public static Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceType TrialEligibility { get { throw null; } }
        public bool Equals(Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceType left, Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceType right) { throw null; }
        public static implicit operator Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceType (string value) { throw null; }
        public static bool operator !=(Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceType left, Azure.Health.Insights.ClinicalMatching.TrialMatcherInferenceType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TrialMatcherModelConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherModelConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherModelConfiguration>
    {
        public TrialMatcherModelConfiguration(Azure.Health.Insights.ClinicalMatching.ClinicalTrials clinicalTrials) { }
        public Azure.Health.Insights.ClinicalMatching.ClinicalTrials ClinicalTrials { get { throw null; } }
        public bool? IncludeEvidence { get { throw null; } set { } }
        public bool? Verbose { get { throw null; } set { } }
        Azure.Health.Insights.ClinicalMatching.TrialMatcherModelConfiguration System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherModelConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherModelConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.TrialMatcherModelConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherModelConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherModelConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherModelConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrialMatcherPatientResult : System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherPatientResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherPatientResult>
    {
        internal TrialMatcherPatientResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Health.Insights.ClinicalMatching.TrialMatcherInference> Inferences { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Health.Insights.ClinicalMatching.ExtendedClinicalCodedElement> NeededClinicalInfo { get { throw null; } }
        public string PatientId { get { throw null; } }
        Azure.Health.Insights.ClinicalMatching.TrialMatcherPatientResult System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherPatientResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherPatientResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Health.Insights.ClinicalMatching.TrialMatcherPatientResult System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherPatientResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherPatientResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Health.Insights.ClinicalMatching.TrialMatcherPatientResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class HealthInsightsClinicalMatchingClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Health.Insights.ClinicalMatching.ClinicalMatchingClient, Azure.Health.Insights.ClinicalMatching.ClinicalMatchingClientOptions> AddClinicalMatchingClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Health.Insights.ClinicalMatching.ClinicalMatchingClient, Azure.Health.Insights.ClinicalMatching.ClinicalMatchingClientOptions> AddClinicalMatchingClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
