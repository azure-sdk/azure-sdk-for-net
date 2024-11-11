namespace Azure.AI.Language.Authoring.Analyzetext
{
    public partial class AnalyzetextClient
    {
        protected AnalyzetextClient() { }
        public AnalyzetextClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public AnalyzetextClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.AI.Language.Authoring.Analyzetext.AnalyzetextClientOptions options) { }
        public AnalyzetextClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public AnalyzetextClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.AI.Language.Authoring.Analyzetext.AnalyzetextClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.AI.Language.Authoring.Analyzetext.TextAnalysisAuthoring GetTextAnalysisAuthoringClient(string apiVersion = "2024-11-15-preview") { throw null; }
    }
    public partial class AnalyzetextClientOptions : Azure.Core.ClientOptions
    {
        public AnalyzetextClientOptions(Azure.AI.Language.Authoring.Analyzetext.AnalyzetextClientOptions.ServiceVersion version = Azure.AI.Language.Authoring.Analyzetext.AnalyzetextClientOptions.ServiceVersion.V2024_11_15_Preview) { }
        public enum ServiceVersion
        {
            V2023_04_01 = 1,
            V2023_04_15_Preview = 2,
            V2024_11_15_Preview = 3,
        }
    }
    public partial class TextAnalysisAuthoring
    {
        protected TextAnalysisAuthoring() { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Operation AssignDeploymentResources(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation AssignDeploymentResources(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> AssignDeploymentResourcesAsync(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> AssignDeploymentResourcesAsync(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<System.BinaryData> CancelTrainingJob(Azure.WaitUntil waitUntil, string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Operation<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult> CancelTrainingJob(Azure.WaitUntil waitUntil, string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> CancelTrainingJobAsync(Azure.WaitUntil waitUntil, string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult>> CancelTrainingJobAsync(Azure.WaitUntil waitUntil, string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation CopyProject(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation CopyProject(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> CopyProjectAsync(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> CopyProjectAsync(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectConfig> CopyProjectAuthorization(string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind projectKind, string storageInputContainerName = null, bool? allowOverwrite = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CopyProjectAuthorization(string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectConfig>> CopyProjectAuthorizationAsync(string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind projectKind, string storageInputContainerName = null, bool? allowOverwrite = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CopyProjectAuthorizationAsync(string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation CreateOrUpdateExportedModel(Azure.WaitUntil waitUntil, string projectName, string exportedModelName, Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation CreateOrUpdateExportedModel(Azure.WaitUntil waitUntil, string projectName, string exportedModelName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> CreateOrUpdateExportedModelAsync(Azure.WaitUntil waitUntil, string projectName, string exportedModelName, Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> CreateOrUpdateExportedModelAsync(Azure.WaitUntil waitUntil, string projectName, string exportedModelName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateProject(string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateProjectAsync(string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation DeleteDeployment(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeleteDeploymentAsync(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation DeleteDeploymentFromResources(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.AI.Language.Authoring.Analyzetext.Models.DeleteDeploymentConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation DeleteDeploymentFromResources(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeleteDeploymentFromResourcesAsync(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.AI.Language.Authoring.Analyzetext.Models.DeleteDeploymentConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeleteDeploymentFromResourcesAsync(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation DeleteExportedModel(Azure.WaitUntil waitUntil, string projectName, string exportedModelName, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeleteExportedModelAsync(Azure.WaitUntil waitUntil, string projectName, string exportedModelName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation DeleteProject(Azure.WaitUntil waitUntil, string projectName, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeleteProjectAsync(Azure.WaitUntil waitUntil, string projectName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteTrainedModel(string projectName, string trainedModelLabel, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteTrainedModelAsync(string projectName, string trainedModelLabel, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation DeployProject(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.AI.Language.Authoring.Analyzetext.Models.CreateDeploymentConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation DeployProject(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeployProjectAsync(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.AI.Language.Authoring.Analyzetext.Models.CreateDeploymentConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeployProjectAsync(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobResult> EvaluateModel(Azure.WaitUntil waitUntil, string projectName, string trainedModelLabel, Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation<System.BinaryData> EvaluateModel(Azure.WaitUntil waitUntil, string projectName, string trainedModelLabel, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobResult>> EvaluateModelAsync(Azure.WaitUntil waitUntil, string projectName, string trainedModelLabel, Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> EvaluateModelAsync(Azure.WaitUntil waitUntil, string projectName, string trainedModelLabel, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation Export(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType stringIndexType, string assetKind = null, string trainedModelLabel = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation Export(Azure.WaitUntil waitUntil, string projectName, string stringIndexType, string assetKind = null, string trainedModelLabel = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> ExportAsync(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType stringIndexType, string assetKind = null, string trainedModelLabel = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> ExportAsync(Azure.WaitUntil waitUntil, string projectName, string stringIndexType, string assetKind = null, string trainedModelLabel = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetAssignDeploymentResourcesStatus(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesJobState> GetAssignDeploymentResourcesStatus(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetAssignDeploymentResourcesStatusAsync(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesJobState>> GetAssignDeploymentResourcesStatusAsync(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetAssignedResourceDeployments(int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentsMetadata> GetAssignedResourceDeployments(int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetAssignedResourceDeploymentsAsync(int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentsMetadata> GetAssignedResourceDeploymentsAsync(int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetCopyProjectStatus(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectJobState> GetCopyProjectStatus(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetCopyProjectStatusAsync(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectJobState>> GetCopyProjectStatusAsync(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetDeployment(string projectName, string deploymentName, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeployment> GetDeployment(string projectName, string deploymentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetDeploymentAsync(string projectName, string deploymentName, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeployment>> GetDeploymentAsync(string projectName, string deploymentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetDeploymentDeleteFromResourcesStatus(string projectName, string deploymentName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentDeleteFromResourcesJobState> GetDeploymentDeleteFromResourcesStatus(string projectName, string deploymentName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetDeploymentDeleteFromResourcesStatusAsync(string projectName, string deploymentName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentDeleteFromResourcesJobState>> GetDeploymentDeleteFromResourcesStatusAsync(string projectName, string deploymentName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetDeploymentResources(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedDeploymentResource> GetDeploymentResources(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetDeploymentResourcesAsync(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedDeploymentResource> GetDeploymentResourcesAsync(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetDeployments(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeployment> GetDeployments(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetDeploymentsAsync(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeployment> GetDeploymentsAsync(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetDeploymentStatus(string projectName, string deploymentName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentJobState> GetDeploymentStatus(string projectName, string deploymentName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetDeploymentStatusAsync(string projectName, string deploymentName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentJobState>> GetDeploymentStatusAsync(string projectName, string deploymentName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetEvaluationStatus(string projectName, string trainedModelLabel, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobState> GetEvaluationStatus(string projectName, string trainedModelLabel, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetEvaluationStatusAsync(string projectName, string trainedModelLabel, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobState>> GetEvaluationStatusAsync(string projectName, string trainedModelLabel, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetExportedModel(string projectName, string exportedModelName, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedTrainedModel> GetExportedModel(string projectName, string exportedModelName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetExportedModelAsync(string projectName, string exportedModelName, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedTrainedModel>> GetExportedModelAsync(string projectName, string exportedModelName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetExportedModelJobStatus(string projectName, string exportedModelName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelJobState> GetExportedModelJobStatus(string projectName, string exportedModelName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetExportedModelJobStatusAsync(string projectName, string exportedModelName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelJobState>> GetExportedModelJobStatusAsync(string projectName, string exportedModelName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetExportedModelManifest(string projectName, string exportedModelName, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelManifest> GetExportedModelManifest(string projectName, string exportedModelName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetExportedModelManifestAsync(string projectName, string exportedModelName, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelManifest>> GetExportedModelManifestAsync(string projectName, string exportedModelName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetExportedModels(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedTrainedModel> GetExportedModels(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetExportedModelsAsync(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedTrainedModel> GetExportedModelsAsync(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetExportStatus(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ExportProjectJobState> GetExportStatus(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetExportStatusAsync(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ExportProjectJobState>> GetExportStatusAsync(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetImportStatus(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ImportProjectJobState> GetImportStatus(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetImportStatusAsync(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ImportProjectJobState>> GetImportStatusAsync(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetLoadSnapshotStatus(string projectName, string trainedModelLabel, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.LoadSnapshotJobState> GetLoadSnapshotStatus(string projectName, string trainedModelLabel, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetLoadSnapshotStatusAsync(string projectName, string trainedModelLabel, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.LoadSnapshotJobState>> GetLoadSnapshotStatusAsync(string projectName, string trainedModelLabel, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult> GetModelEvaluationResults(string projectName, string trainedModelLabel, Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType stringIndexType, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetModelEvaluationResults(string projectName, string trainedModelLabel, string stringIndexType, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult> GetModelEvaluationResultsAsync(string projectName, string trainedModelLabel, Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType stringIndexType, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetModelEvaluationResultsAsync(string projectName, string trainedModelLabel, string stringIndexType, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetModelEvaluationSummary(string projectName, string trainedModelLabel, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary> GetModelEvaluationSummary(string projectName, string trainedModelLabel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetModelEvaluationSummaryAsync(string projectName, string trainedModelLabel, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary>> GetModelEvaluationSummaryAsync(string projectName, string trainedModelLabel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetProject(string projectName, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectMetadata> GetProject(string projectName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetProjectAsync(string projectName, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectMetadata>> GetProjectAsync(string projectName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetProjectDeletionStatus(string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeletionJobState> GetProjectDeletionStatus(string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetProjectDeletionStatusAsync(string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeletionJobState>> GetProjectDeletionStatusAsync(string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetProjects(int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectMetadata> GetProjects(int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetProjectsAsync(int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectMetadata> GetProjectsAsync(int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.Analyzetext.Models.SupportedLanguage> GetSupportedLanguages(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind? projectKind = default(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind?), int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetSupportedLanguages(string projectKind, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.Analyzetext.Models.SupportedLanguage> GetSupportedLanguagesAsync(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind? projectKind = default(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind?), int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetSupportedLanguagesAsync(string projectKind, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetSupportedPrebuiltEntities(Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.Analyzetext.Models.PrebuiltEntity> GetSupportedPrebuiltEntities(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetSupportedPrebuiltEntitiesAsync(Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.Analyzetext.Models.PrebuiltEntity> GetSupportedPrebuiltEntitiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetSwapDeploymentsStatus(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsJobState> GetSwapDeploymentsStatus(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetSwapDeploymentsStatusAsync(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsJobState>> GetSwapDeploymentsStatusAsync(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetTrainedModel(string projectName, string trainedModelLabel, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectTrainedModel> GetTrainedModel(string projectName, string trainedModelLabel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTrainedModelAsync(string projectName, string trainedModelLabel, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectTrainedModel>> GetTrainedModelAsync(string projectName, string trainedModelLabel, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetTrainedModels(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectTrainedModel> GetTrainedModels(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetTrainedModelsAsync(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectTrainedModel> GetTrainedModelsAsync(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingConfigVersion> GetTrainingConfigVersions(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind? projectKind = default(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind?), int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetTrainingConfigVersions(string projectKind, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingConfigVersion> GetTrainingConfigVersionsAsync(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind? projectKind = default(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind?), int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetTrainingConfigVersionsAsync(string projectKind, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetTrainingJobs(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.Pageable<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobState> GetTrainingJobs(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetTrainingJobsAsync(string projectName, int? maxCount, int? skip, int? maxpagesize, Azure.RequestContext context) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobState> GetTrainingJobsAsync(string projectName, int? maxCount = default(int?), int? skip = default(int?), int? maxpagesize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetTrainingStatus(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobState> GetTrainingStatus(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTrainingStatusAsync(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobState>> GetTrainingStatusAsync(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetUnassignDeploymentResourcesStatus(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesJobState> GetUnassignDeploymentResourcesStatus(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetUnassignDeploymentResourcesStatusAsync(string projectName, string jobId, Azure.RequestContext context) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesJobState>> GetUnassignDeploymentResourcesStatusAsync(string projectName, string jobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation Import(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProject body, string format = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation Import(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, string format = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> ImportAsync(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProject body, string format = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> ImportAsync(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, string format = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation LoadSnapshot(Azure.WaitUntil waitUntil, string projectName, string trainedModelLabel, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> LoadSnapshotAsync(Azure.WaitUntil waitUntil, string projectName, string trainedModelLabel, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation SwapDeployments(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation SwapDeployments(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> SwapDeploymentsAsync(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> SwapDeploymentsAsync(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult> Train(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation<System.BinaryData> Train(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult>> TrainAsync(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> TrainAsync(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation UnassignDeploymentResources(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Operation UnassignDeploymentResources(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> UnassignDeploymentResourcesAsync(Azure.WaitUntil waitUntil, string projectName, Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesConfig body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> UnassignDeploymentResourcesAsync(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
}
namespace Azure.AI.Language.Authoring.Analyzetext.Models
{
    public static partial class AILanguageAuthoringAnalyzetextModelFactory
    {
        public static Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesJobState AssignDeploymentResourcesJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus status = default(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.AssignedDeploymentResource AssignedDeploymentResource(string azureResourceId = null, string region = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentMetadata AssignedProjectDeploymentMetadata(string deploymentName = null, System.DateTimeOffset lastDeployedDateTime = default(System.DateTimeOffset), System.DateTimeOffset deploymentExpirationDate = default(System.DateTimeOffset)) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentsMetadata AssignedProjectDeploymentsMetadata(string projectName = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentMetadata> deploymentsMetadata = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix ConfusionMatrix(System.Collections.Generic.IReadOnlyDictionary<string, System.BinaryData> additionalProperties = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixCell ConfusionMatrixCell(float normalizedValue = 0f, float rawValue = 0f) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixRow ConfusionMatrixRow(System.Collections.Generic.IReadOnlyDictionary<string, System.BinaryData> additionalProperties = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectJobState CopyProjectJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus status = default(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.CreateDeploymentConfig CreateDeploymentConfig(string trainedModelLabel = null, System.Collections.Generic.IEnumerable<string> assignedResourceIds = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.CreateProjectConfig CreateProjectConfig(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind projectKind = default(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind), string storageInputContainerName = null, Azure.AI.Language.Authoring.Analyzetext.Models.ProjectSettings settings = null, string projectName = null, bool? multilingual = default(bool?), string description = null, string language = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionDocumentEvaluationResult CustomEntityRecognitionDocumentEvaluationResult(string location = null, string language = null, Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRecognitionEvaluationResult customEntityRecognitionResult = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionEvaluationSummary CustomEntityRecognitionEvaluationSummary(Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig evaluationOptions = null, Azure.AI.Language.Authoring.Analyzetext.Models.EntityRecognitionEvaluationSummary customEntityRecognitionEvaluation = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareDocumentEvaluationResult CustomHealthcareDocumentEvaluationResult(string location = null, string language = null, Azure.AI.Language.Authoring.Analyzetext.Models.DocumentHealthcareEvaluationResult customHealthcareResult = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareEvaluationSummary CustomHealthcareEvaluationSummary(Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig evaluationOptions = null, Azure.AI.Language.Authoring.Analyzetext.Models.EntityRecognitionEvaluationSummary customHealthcareEvaluation = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationDocumentEvaluationResult CustomMultiLabelClassificationDocumentEvaluationResult(string location = null, string language = null, Azure.AI.Language.Authoring.Analyzetext.Models.DocumentMultiLabelClassificationEvaluationResult customMultiLabelClassificationResult = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationEvaluationSummary CustomMultiLabelClassificationEvaluationSummary(Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig evaluationOptions = null, Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassificationEvaluationSummary customMultiLabelClassificationEvaluation = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationDocumentEvaluationResult CustomSingleLabelClassificationDocumentEvaluationResult(string location = null, string language = null, Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSingleLabelClassificationEvaluationResult customSingleLabelClassificationResult = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationEvaluationSummary CustomSingleLabelClassificationEvaluationSummary(Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig evaluationOptions = null, Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassificationEvaluationSummary customSingleLabelClassificationEvaluation = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentDocumentEvaluationResult CustomTextSentimentDocumentEvaluationResult(string location = null, string language = null, Azure.AI.Language.Authoring.Analyzetext.Models.DocumentTextSentimentEvaluationResult customTextSentimentResult = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentEvaluationSummary CustomTextSentimentEvaluationSummary(Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig evaluationOptions = null, Azure.AI.Language.Authoring.Analyzetext.Models.TextSentimentEvaluationSummary customTextSentimentEvaluation = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfo DataGenerationConnectionInfo(Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfoKind kind = default(Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfoKind), string resourceId = null, string deploymentName = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentDeleteFromResourcesJobState DeploymentDeleteFromResourcesJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus status = default(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentJobState DeploymentJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus status = default(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentResource DeploymentResource(string resourceId = null, string region = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityLabelEvaluationResult DocumentEntityLabelEvaluationResult(string category = null, int offset = 0, int length = 0) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRecognitionEvaluationResult DocumentEntityRecognitionEvaluationResult(System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRegionEvaluationResult> entities = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRegionEvaluationResult DocumentEntityRegionEvaluationResult(System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityLabelEvaluationResult> expectedEntities = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityLabelEvaluationResult> predictedEntities = null, int regionOffset = 0, int regionLength = 0) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult DocumentEvaluationResult(string projectKind = null, string location = null, string language = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.DocumentHealthcareEvaluationResult DocumentHealthcareEvaluationResult(System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRegionEvaluationResult> entities = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.DocumentMultiLabelClassificationEvaluationResult DocumentMultiLabelClassificationEvaluationResult(System.Collections.Generic.IEnumerable<string> expectedClasses = null, System.Collections.Generic.IEnumerable<string> predictedClasses = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSentimentLabelEvaluationResult DocumentSentimentLabelEvaluationResult(Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringSentiment category = default(Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringSentiment), int offset = 0, int length = 0) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSingleLabelClassificationEvaluationResult DocumentSingleLabelClassificationEvaluationResult(string expectedClass = null, string predictedClass = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.DocumentTextSentimentEvaluationResult DocumentTextSentimentEvaluationResult(System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSentimentLabelEvaluationResult> expectedSentimentSpans = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSentimentLabelEvaluationResult> predictedSentimentSpans = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.EntityEvaluationSummary EntityEvaluationSummary(double f1 = 0, double precision = 0, double recall = 0, int truePositiveCount = 0, int trueNegativeCount = 0, int falsePositiveCount = 0, int falseNegativeCount = 0) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.EntityRecognitionEvaluationSummary EntityRecognitionEvaluationSummary(Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix confusionMatrix = null, System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.Analyzetext.Models.EntityEvaluationSummary> entities = null, float microF1 = 0f, float microPrecision = 0f, float microRecall = 0f, float macroF1 = 0f, float macroPrecision = 0f, float macroRecall = 0f) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobResult EvaluationJobResult(Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig evaluationOptions = null, string modelLabel = null, string trainingConfigVersion = null, int percentComplete = 0) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobState EvaluationJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus status = default(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> errors = null, Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobResult result = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary EvaluationSummary(string projectKind = null, Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig evaluationOptions = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationDocument ExportedCustomAbstractiveSummarizationDocument(string summaryLocation = null, string location = null, string language = null, string dataset = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelJobState ExportedModelJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus status = default(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelManifest ExportedModelManifest(System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.ModelFile> modelFiles = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProject ExportedProject(string projectFileVersion = null, Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType stringIndexType = default(Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType), Azure.AI.Language.Authoring.Analyzetext.Models.CreateProjectConfig metadata = null, Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets assets = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ExportedTrainedModel ExportedTrainedModel(string exportedModelName = null, string modelId = null, System.DateTimeOffset lastTrainedDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastExportedModelDateTime = default(System.DateTimeOffset), System.DateTimeOffset modelExpirationDate = default(System.DateTimeOffset), string modelTrainingConfigVersion = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ExportProjectJobState ExportProjectJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus status = default(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> errors = null, string resultUrl = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ImportProjectJobState ImportProjectJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus status = default(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorModel InnerErrorModel(Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode code = default(Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode), string message = null, System.Collections.Generic.IReadOnlyDictionary<string, string> details = null, string target = null, Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorModel innererror = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.LoadSnapshotJobState LoadSnapshotJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus status = default(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ModelFile ModelFile(string name = null, System.Uri contentUri = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassEvaluationSummary MultiLabelClassEvaluationSummary(double f1 = 0, double precision = 0, double recall = 0, int truePositiveCount = 0, int trueNegativeCount = 0, int falsePositiveCount = 0, int falseNegativeCount = 0) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassificationEvaluationSummary MultiLabelClassificationEvaluationSummary(System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassEvaluationSummary> classes = null, float microF1 = 0f, float microPrecision = 0f, float microRecall = 0f, float macroF1 = 0f, float macroPrecision = 0f, float macroRecall = 0f) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.PrebuiltEntity PrebuiltEntity(string category = null, string description = null, string examples = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeletionJobState ProjectDeletionJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus status = default(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeployment ProjectDeployment(string deploymentName = null, string modelId = null, System.DateTimeOffset lastTrainedDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastDeployedDateTime = default(System.DateTimeOffset), System.DateTimeOffset deploymentExpirationDate = default(System.DateTimeOffset), string modelTrainingConfigVersion = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentResource> assignedResources = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ProjectMetadata ProjectMetadata(System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastModifiedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? lastTrainedDateTime = default(System.DateTimeOffset?), System.DateTimeOffset? lastDeployedDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind projectKind = default(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind), string storageInputContainerName = null, Azure.AI.Language.Authoring.Analyzetext.Models.ProjectSettings settings = null, string projectName = null, bool? multilingual = default(bool?), string description = null, string language = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ProjectTrainedModel ProjectTrainedModel(string label = null, string modelId = null, System.DateTimeOffset lastTrainedDateTime = default(System.DateTimeOffset), int lastTrainingDurationInSeconds = 0, System.DateTimeOffset modelExpirationDate = default(System.DateTimeOffset), string modelTrainingConfigVersion = null, bool hasSnapshot = false) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.SentimentEvaluationSummary SentimentEvaluationSummary(double f1 = 0, double precision = 0, double recall = 0, int truePositiveCount = 0, int trueNegativeCount = 0, int falsePositiveCount = 0, int falseNegativeCount = 0) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassEvaluationSummary SingleLabelClassEvaluationSummary(double f1 = 0, double precision = 0, double recall = 0, int truePositiveCount = 0, int trueNegativeCount = 0, int falsePositiveCount = 0, int falseNegativeCount = 0) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassificationEvaluationSummary SingleLabelClassificationEvaluationSummary(Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix confusionMatrix = null, System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassEvaluationSummary> classes = null, float microF1 = 0f, float microPrecision = 0f, float microRecall = 0f, float macroF1 = 0f, float macroPrecision = 0f, float macroRecall = 0f) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.SpanSentimentEvaluationSummary SpanSentimentEvaluationSummary(Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix confusionMatrix = null, System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.Analyzetext.Models.SentimentEvaluationSummary> sentiments = null, float microF1 = 0f, float microPrecision = 0f, float microRecall = 0f, float macroF1 = 0f, float macroPrecision = 0f, float macroRecall = 0f) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.SubTrainingJobState SubTrainingJobState(int percentComplete = 0, System.DateTimeOffset? startDateTime = default(System.DateTimeOffset?), System.DateTimeOffset? endDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus status = default(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus)) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.SupportedLanguage SupportedLanguage(string languageName = null, string languageCode = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsJobState SwapDeploymentsJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus status = default(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError TextAnalysisAuthoringError(Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode code = default(Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode), string message = null, string target = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> details = null, Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorModel innererror = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning TextAnalysisAuthoringWarning(string code = null, string message = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.TextSentimentEvaluationSummary TextSentimentEvaluationSummary(Azure.AI.Language.Authoring.Analyzetext.Models.SpanSentimentEvaluationSummary spanSentimentsEvaluation = null, float microF1 = 0f, float microPrecision = 0f, float microRecall = 0f, float macroF1 = 0f, float macroPrecision = 0f, float macroRecall = 0f) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.TrainingConfigVersion TrainingConfigVersion(string trainingConfigVersionProperty = null, System.DateTimeOffset modelExpirationDate = default(System.DateTimeOffset)) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobConfig TrainingJobConfig(string modelLabel = null, string trainingConfigVersion = null, Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig evaluationOptions = null, Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationSettings dataGenerationSettings = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult TrainingJobResult(string modelLabel = null, string trainingConfigVersion = null, Azure.AI.Language.Authoring.Analyzetext.Models.SubTrainingJobState trainingStatus = null, Azure.AI.Language.Authoring.Analyzetext.Models.SubTrainingJobState evaluationStatus = null, System.DateTimeOffset? estimatedEndDateTime = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobState TrainingJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus status = default(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> errors = null, Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult result = null) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesJobState UnassignDeploymentResourcesJobState(string jobId = null, System.DateTimeOffset createdDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastUpdatedDateTime = default(System.DateTimeOffset), System.DateTimeOffset? expirationDateTime = default(System.DateTimeOffset?), Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus status = default(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus), System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> warnings = null, System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> errors = null) { throw null; }
    }
    public partial class AssignDeploymentResourcesConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesConfig>
    {
        public AssignDeploymentResourcesConfig(System.Collections.Generic.IEnumerable<Azure.AI.Language.Authoring.Analyzetext.Models.ResourceMetadata> resourcesMetadata) { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ResourceMetadata> ResourcesMetadata { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AssignDeploymentResourcesJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesJobState>
    {
        internal AssignDeploymentResourcesJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignDeploymentResourcesJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AssignedDeploymentResource : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedDeploymentResource>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedDeploymentResource>
    {
        internal AssignedDeploymentResource() { }
        public string AzureResourceId { get { throw null; } }
        public string Region { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.AssignedDeploymentResource System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedDeploymentResource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedDeploymentResource>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.AssignedDeploymentResource System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedDeploymentResource>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedDeploymentResource>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedDeploymentResource>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AssignedProjectDeploymentMetadata : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentMetadata>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentMetadata>
    {
        internal AssignedProjectDeploymentMetadata() { }
        public System.DateTimeOffset DeploymentExpirationDate { get { throw null; } }
        public string DeploymentName { get { throw null; } }
        public System.DateTimeOffset LastDeployedDateTime { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentMetadata System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentMetadata>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentMetadata System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentMetadata>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentMetadata>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentMetadata>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AssignedProjectDeploymentsMetadata : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentsMetadata>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentsMetadata>
    {
        internal AssignedProjectDeploymentsMetadata() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentMetadata> DeploymentsMetadata { get { throw null; } }
        public string ProjectName { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentsMetadata System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentsMetadata>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentsMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentsMetadata System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentsMetadata>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentsMetadata>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.AssignedProjectDeploymentsMetadata>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CompositionSetting : System.IEquatable<Azure.AI.Language.Authoring.Analyzetext.Models.CompositionSetting>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CompositionSetting(string value) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.CompositionSetting CombineComponents { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.CompositionSetting SeparateComponents { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.Analyzetext.Models.CompositionSetting other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.Analyzetext.Models.CompositionSetting left, Azure.AI.Language.Authoring.Analyzetext.Models.CompositionSetting right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.Analyzetext.Models.CompositionSetting (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.Analyzetext.Models.CompositionSetting left, Azure.AI.Language.Authoring.Analyzetext.Models.CompositionSetting right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ConfusionMatrix : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix>
    {
        internal ConfusionMatrix() { }
        public System.Collections.Generic.IReadOnlyDictionary<string, System.BinaryData> AdditionalProperties { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConfusionMatrixCell : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixCell>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixCell>
    {
        internal ConfusionMatrixCell() { }
        public float NormalizedValue { get { throw null; } }
        public float RawValue { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixCell System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixCell>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixCell>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixCell System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixCell>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixCell>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixCell>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConfusionMatrixRow : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixRow>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixRow>
    {
        internal ConfusionMatrixRow() { }
        public System.Collections.Generic.IReadOnlyDictionary<string, System.BinaryData> AdditionalProperties { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixRow System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixRow>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixRow>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixRow System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixRow>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixRow>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrixRow>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CopyProjectConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectConfig>
    {
        public CopyProjectConfig(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind projectKind, string targetProjectName, string accessToken, System.DateTimeOffset expiresAt, string targetResourceId, string targetResourceRegion) { }
        public string AccessToken { get { throw null; } set { } }
        public System.DateTimeOffset ExpiresAt { get { throw null; } set { } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind ProjectKind { get { throw null; } set { } }
        public string TargetProjectName { get { throw null; } set { } }
        public string TargetResourceId { get { throw null; } set { } }
        public string TargetResourceRegion { get { throw null; } set { } }
        Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CopyProjectJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectJobState>
    {
        internal CopyProjectJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CopyProjectJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CreateDeploymentConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CreateDeploymentConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CreateDeploymentConfig>
    {
        public CreateDeploymentConfig(string trainedModelLabel) { }
        public System.Collections.Generic.IList<string> AssignedResourceIds { get { throw null; } }
        public string TrainedModelLabel { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.CreateDeploymentConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CreateDeploymentConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CreateDeploymentConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.CreateDeploymentConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CreateDeploymentConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CreateDeploymentConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CreateDeploymentConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CreateProjectConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CreateProjectConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CreateProjectConfig>
    {
        public CreateProjectConfig(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind projectKind, string storageInputContainerName, string projectName, string language) { }
        public string Description { get { throw null; } set { } }
        public string Language { get { throw null; } }
        public bool? Multilingual { get { throw null; } set { } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind ProjectKind { get { throw null; } }
        public string ProjectName { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.ProjectSettings Settings { get { throw null; } set { } }
        public string StorageInputContainerName { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.CreateProjectConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CreateProjectConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CreateProjectConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.CreateProjectConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CreateProjectConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CreateProjectConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CreateProjectConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomEntityRecognitionDocumentEvaluationResult : Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionDocumentEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionDocumentEvaluationResult>
    {
        internal CustomEntityRecognitionDocumentEvaluationResult() : base (default(string), default(string)) { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRecognitionEvaluationResult CustomEntityRecognitionResult { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionDocumentEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionDocumentEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionDocumentEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionDocumentEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionDocumentEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionDocumentEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionDocumentEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomEntityRecognitionEvaluationSummary : Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionEvaluationSummary>
    {
        internal CustomEntityRecognitionEvaluationSummary() : base (default(Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig)) { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.EntityRecognitionEvaluationSummary CustomEntityRecognitionEvaluation { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomEntityRecognitionEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomHealthcareDocumentEvaluationResult : Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareDocumentEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareDocumentEvaluationResult>
    {
        internal CustomHealthcareDocumentEvaluationResult() : base (default(string), default(string)) { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.DocumentHealthcareEvaluationResult CustomHealthcareResult { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareDocumentEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareDocumentEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareDocumentEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareDocumentEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareDocumentEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareDocumentEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareDocumentEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomHealthcareEvaluationSummary : Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareEvaluationSummary>
    {
        internal CustomHealthcareEvaluationSummary() : base (default(Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig)) { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.EntityRecognitionEvaluationSummary CustomHealthcareEvaluation { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomHealthcareEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomMultiLabelClassificationDocumentEvaluationResult : Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationDocumentEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationDocumentEvaluationResult>
    {
        internal CustomMultiLabelClassificationDocumentEvaluationResult() : base (default(string), default(string)) { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.DocumentMultiLabelClassificationEvaluationResult CustomMultiLabelClassificationResult { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationDocumentEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationDocumentEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationDocumentEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationDocumentEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationDocumentEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationDocumentEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationDocumentEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomMultiLabelClassificationEvaluationSummary : Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationEvaluationSummary>
    {
        internal CustomMultiLabelClassificationEvaluationSummary() : base (default(Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig)) { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassificationEvaluationSummary CustomMultiLabelClassificationEvaluation { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomMultiLabelClassificationEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomSingleLabelClassificationDocumentEvaluationResult : Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationDocumentEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationDocumentEvaluationResult>
    {
        internal CustomSingleLabelClassificationDocumentEvaluationResult() : base (default(string), default(string)) { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSingleLabelClassificationEvaluationResult CustomSingleLabelClassificationResult { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationDocumentEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationDocumentEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationDocumentEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationDocumentEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationDocumentEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationDocumentEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationDocumentEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomSingleLabelClassificationEvaluationSummary : Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationEvaluationSummary>
    {
        internal CustomSingleLabelClassificationEvaluationSummary() : base (default(Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig)) { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassificationEvaluationSummary CustomSingleLabelClassificationEvaluation { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomSingleLabelClassificationEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomTextSentimentDocumentEvaluationResult : Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentDocumentEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentDocumentEvaluationResult>
    {
        internal CustomTextSentimentDocumentEvaluationResult() : base (default(string), default(string)) { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.DocumentTextSentimentEvaluationResult CustomTextSentimentResult { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentDocumentEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentDocumentEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentDocumentEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentDocumentEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentDocumentEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentDocumentEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentDocumentEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CustomTextSentimentEvaluationSummary : Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentEvaluationSummary>
    {
        internal CustomTextSentimentEvaluationSummary() : base (default(Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig)) { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.TextSentimentEvaluationSummary CustomTextSentimentEvaluation { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.CustomTextSentimentEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DataGenerationConnectionInfo : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfo>
    {
        public DataGenerationConnectionInfo(string resourceId, string deploymentName) { }
        public string DeploymentName { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfoKind Kind { get { throw null; } }
        public string ResourceId { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfo System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfo System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DataGenerationConnectionInfoKind : System.IEquatable<Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfoKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DataGenerationConnectionInfoKind(string value) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfoKind AzureOpenAI { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfoKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfoKind left, Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfoKind right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfoKind (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfoKind left, Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfoKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DataGenerationSettings : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationSettings>
    {
        public DataGenerationSettings(bool enableDataGeneration, Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfo dataGenerationConnectionInfo) { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationConnectionInfo DataGenerationConnectionInfo { get { throw null; } }
        public bool EnableDataGeneration { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationSettings System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationSettings System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeleteDeploymentConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeleteDeploymentConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeleteDeploymentConfig>
    {
        public DeleteDeploymentConfig() { }
        public System.Collections.Generic.IList<string> AssignedResourceIds { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.DeleteDeploymentConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeleteDeploymentConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeleteDeploymentConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.DeleteDeploymentConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeleteDeploymentConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeleteDeploymentConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeleteDeploymentConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeploymentDeleteFromResourcesJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentDeleteFromResourcesJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentDeleteFromResourcesJobState>
    {
        internal DeploymentDeleteFromResourcesJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentDeleteFromResourcesJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentDeleteFromResourcesJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentDeleteFromResourcesJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentDeleteFromResourcesJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentDeleteFromResourcesJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentDeleteFromResourcesJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentDeleteFromResourcesJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeploymentJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentJobState>
    {
        internal DeploymentJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeploymentResource : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentResource>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentResource>
    {
        internal DeploymentResource() { }
        public string Region { get { throw null; } }
        public string ResourceId { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentResource System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentResource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentResource>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentResource System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentResource>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentResource>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentResource>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentEntityLabelEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityLabelEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityLabelEvaluationResult>
    {
        internal DocumentEntityLabelEvaluationResult() { }
        public string Category { get { throw null; } }
        public int Length { get { throw null; } }
        public int Offset { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityLabelEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityLabelEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityLabelEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityLabelEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityLabelEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityLabelEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityLabelEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentEntityRecognitionEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRecognitionEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRecognitionEvaluationResult>
    {
        internal DocumentEntityRecognitionEvaluationResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRegionEvaluationResult> Entities { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRecognitionEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRecognitionEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRecognitionEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRecognitionEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRecognitionEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRecognitionEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRecognitionEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentEntityRegionEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRegionEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRegionEvaluationResult>
    {
        internal DocumentEntityRegionEvaluationResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityLabelEvaluationResult> ExpectedEntities { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityLabelEvaluationResult> PredictedEntities { get { throw null; } }
        public int RegionLength { get { throw null; } }
        public int RegionOffset { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRegionEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRegionEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRegionEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRegionEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRegionEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRegionEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRegionEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class DocumentEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult>
    {
        protected DocumentEvaluationResult(string location, string language) { }
        public string Language { get { throw null; } }
        public string Location { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentHealthcareEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentHealthcareEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentHealthcareEvaluationResult>
    {
        internal DocumentHealthcareEvaluationResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentEntityRegionEvaluationResult> Entities { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentHealthcareEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentHealthcareEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentHealthcareEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentHealthcareEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentHealthcareEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentHealthcareEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentHealthcareEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentMultiLabelClassificationEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentMultiLabelClassificationEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentMultiLabelClassificationEvaluationResult>
    {
        internal DocumentMultiLabelClassificationEvaluationResult() { }
        public System.Collections.Generic.IReadOnlyList<string> ExpectedClasses { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> PredictedClasses { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentMultiLabelClassificationEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentMultiLabelClassificationEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentMultiLabelClassificationEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentMultiLabelClassificationEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentMultiLabelClassificationEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentMultiLabelClassificationEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentMultiLabelClassificationEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentSentimentLabelEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSentimentLabelEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSentimentLabelEvaluationResult>
    {
        internal DocumentSentimentLabelEvaluationResult() { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringSentiment Category { get { throw null; } }
        public int Length { get { throw null; } }
        public int Offset { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSentimentLabelEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSentimentLabelEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSentimentLabelEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSentimentLabelEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSentimentLabelEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSentimentLabelEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSentimentLabelEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentSingleLabelClassificationEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSingleLabelClassificationEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSingleLabelClassificationEvaluationResult>
    {
        internal DocumentSingleLabelClassificationEvaluationResult() { }
        public string ExpectedClass { get { throw null; } }
        public string PredictedClass { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSingleLabelClassificationEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSingleLabelClassificationEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSingleLabelClassificationEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSingleLabelClassificationEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSingleLabelClassificationEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSingleLabelClassificationEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSingleLabelClassificationEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DocumentTextSentimentEvaluationResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentTextSentimentEvaluationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentTextSentimentEvaluationResult>
    {
        internal DocumentTextSentimentEvaluationResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSentimentLabelEvaluationResult> ExpectedSentimentSpans { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentSentimentLabelEvaluationResult> PredictedSentimentSpans { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentTextSentimentEvaluationResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentTextSentimentEvaluationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentTextSentimentEvaluationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.DocumentTextSentimentEvaluationResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentTextSentimentEvaluationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentTextSentimentEvaluationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.DocumentTextSentimentEvaluationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EntityEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EntityEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EntityEvaluationSummary>
    {
        internal EntityEvaluationSummary() { }
        public double F1 { get { throw null; } }
        public int FalseNegativeCount { get { throw null; } }
        public int FalsePositiveCount { get { throw null; } }
        public double Precision { get { throw null; } }
        public double Recall { get { throw null; } }
        public int TrueNegativeCount { get { throw null; } }
        public int TruePositiveCount { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.EntityEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EntityEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EntityEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.EntityEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EntityEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EntityEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EntityEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EntityRecognitionEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EntityRecognitionEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EntityRecognitionEvaluationSummary>
    {
        internal EntityRecognitionEvaluationSummary() { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix ConfusionMatrix { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.Analyzetext.Models.EntityEvaluationSummary> Entities { get { throw null; } }
        public float MacroF1 { get { throw null; } }
        public float MacroPrecision { get { throw null; } }
        public float MacroRecall { get { throw null; } }
        public float MicroF1 { get { throw null; } }
        public float MicroPrecision { get { throw null; } }
        public float MicroRecall { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.EntityRecognitionEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EntityRecognitionEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EntityRecognitionEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.EntityRecognitionEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EntityRecognitionEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EntityRecognitionEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EntityRecognitionEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ErrorCode : System.IEquatable<Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ErrorCode(string value) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode AzureCognitiveSearchIndexLimitReached { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode AzureCognitiveSearchIndexNotFound { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode AzureCognitiveSearchNotFound { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode AzureCognitiveSearchThrottling { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode Conflict { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode Forbidden { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode InternalServerError { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode InvalidArgument { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode InvalidRequest { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode NotFound { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode OperationNotFound { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode ProjectNotFound { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode QuotaExceeded { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode ServiceUnavailable { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode Timeout { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode TooManyRequests { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode Unauthorized { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode Warning { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode left, Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode left, Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EvaluationConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig>
    {
        public EvaluationConfig() { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationKind? Kind { get { throw null; } set { } }
        public int? TestingSplitPercentage { get { throw null; } set { } }
        public int? TrainingSplitPercentage { get { throw null; } set { } }
        Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EvaluationJobResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobResult>
    {
        internal EvaluationJobResult() { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig EvaluationOptions { get { throw null; } }
        public string ModelLabel { get { throw null; } }
        public int PercentComplete { get { throw null; } }
        public string TrainingConfigVersion { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EvaluationJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobState>
    {
        internal EvaluationJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobResult Result { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EvaluationKind : System.IEquatable<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EvaluationKind(string value) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationKind Manual { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationKind Percentage { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationKind left, Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationKind right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationKind (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationKind left, Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class EvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary>
    {
        protected EvaluationSummary(Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig evaluationOptions) { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig EvaluationOptions { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedClass : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedClass>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedClass>
    {
        public ExportedClass() { }
        public string Category { get { throw null; } set { } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedClass System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedClass>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedClass>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedClass System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedClass>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedClass>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedClass>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCompositeEntity : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCompositeEntity>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCompositeEntity>
    {
        public ExportedCompositeEntity() { }
        public string Category { get { throw null; } set { } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.CompositionSetting? CompositionSetting { get { throw null; } set { } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityList List { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedPrebuiltEntity> Prebuilts { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCompositeEntity System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCompositeEntity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCompositeEntity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCompositeEntity System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCompositeEntity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCompositeEntity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCompositeEntity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomAbstractiveSummarizationDocument : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationDocument>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationDocument>
    {
        public ExportedCustomAbstractiveSummarizationDocument(string summaryLocation) { }
        public string Dataset { get { throw null; } set { } }
        public string Language { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        public string SummaryLocation { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationDocument System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationDocument>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationDocument>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationDocument System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationDocument>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationDocument>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationDocument>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomAbstractiveSummarizationProjectAssets : Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationProjectAssets>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationProjectAssets>
    {
        public ExportedCustomAbstractiveSummarizationProjectAssets() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationDocument> Documents { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationProjectAssets System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationProjectAssets>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationProjectAssets>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationProjectAssets System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationProjectAssets>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationProjectAssets>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomAbstractiveSummarizationProjectAssets>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomEntityRecognitionDocument : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionDocument>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionDocument>
    {
        public ExportedCustomEntityRecognitionDocument() { }
        public string Dataset { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityRegion> Entities { get { throw null; } }
        public string Language { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionDocument System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionDocument>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionDocument>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionDocument System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionDocument>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionDocument>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionDocument>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomEntityRecognitionProjectAssets : Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionProjectAssets>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionProjectAssets>
    {
        public ExportedCustomEntityRecognitionProjectAssets() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionDocument> Documents { get { throw null; } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntity> Entities { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionProjectAssets System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionProjectAssets>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionProjectAssets>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionProjectAssets System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionProjectAssets>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionProjectAssets>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomEntityRecognitionProjectAssets>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomHealthcareDocument : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareDocument>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareDocument>
    {
        public ExportedCustomHealthcareDocument() { }
        public string Dataset { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityRegion> Entities { get { throw null; } }
        public string Language { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareDocument System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareDocument>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareDocument>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareDocument System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareDocument>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareDocument>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareDocument>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomHealthcareProjectAssets : Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareProjectAssets>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareProjectAssets>
    {
        public ExportedCustomHealthcareProjectAssets() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareDocument> Documents { get { throw null; } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCompositeEntity> Entities { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareProjectAssets System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareProjectAssets>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareProjectAssets>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareProjectAssets System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareProjectAssets>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareProjectAssets>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomHealthcareProjectAssets>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomMultiLabelClassificationDocument : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationDocument>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationDocument>
    {
        public ExportedCustomMultiLabelClassificationDocument() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentClass> Classes { get { throw null; } }
        public string Dataset { get { throw null; } set { } }
        public string Language { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationDocument System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationDocument>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationDocument>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationDocument System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationDocument>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationDocument>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationDocument>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomMultiLabelClassificationProjectAssets : Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationProjectAssets>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationProjectAssets>
    {
        public ExportedCustomMultiLabelClassificationProjectAssets() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedClass> Classes { get { throw null; } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationDocument> Documents { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationProjectAssets System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationProjectAssets>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationProjectAssets>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationProjectAssets System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationProjectAssets>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationProjectAssets>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomMultiLabelClassificationProjectAssets>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomSingleLabelClassificationDocument : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationDocument>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationDocument>
    {
        public ExportedCustomSingleLabelClassificationDocument() { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentClass Class { get { throw null; } set { } }
        public string Dataset { get { throw null; } set { } }
        public string Language { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationDocument System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationDocument>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationDocument>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationDocument System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationDocument>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationDocument>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationDocument>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomSingleLabelClassificationProjectAssets : Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationProjectAssets>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationProjectAssets>
    {
        public ExportedCustomSingleLabelClassificationProjectAssets() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedClass> Classes { get { throw null; } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationDocument> Documents { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationProjectAssets System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationProjectAssets>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationProjectAssets>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationProjectAssets System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationProjectAssets>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationProjectAssets>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomSingleLabelClassificationProjectAssets>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomTextSentimentDocument : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentDocument>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentDocument>
    {
        public ExportedCustomTextSentimentDocument() { }
        public string Dataset { get { throw null; } set { } }
        public string Language { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentSentimentLabel> SentimentSpans { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentDocument System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentDocument>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentDocument>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentDocument System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentDocument>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentDocument>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentDocument>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedCustomTextSentimentProjectAssets : Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets, System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentProjectAssets>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentProjectAssets>
    {
        public ExportedCustomTextSentimentProjectAssets() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentDocument> Documents { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentProjectAssets System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentProjectAssets>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentProjectAssets>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentProjectAssets System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentProjectAssets>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentProjectAssets>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedCustomTextSentimentProjectAssets>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedDocumentClass : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentClass>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentClass>
    {
        public ExportedDocumentClass() { }
        public string Category { get { throw null; } set { } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentClass System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentClass>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentClass>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentClass System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentClass>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentClass>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentClass>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedDocumentEntityLabel : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityLabel>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityLabel>
    {
        public ExportedDocumentEntityLabel() { }
        public string Category { get { throw null; } set { } }
        public int? Length { get { throw null; } set { } }
        public int? Offset { get { throw null; } set { } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityLabel System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityLabel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityLabel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityLabel System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityLabel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityLabel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityLabel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedDocumentEntityRegion : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityRegion>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityRegion>
    {
        public ExportedDocumentEntityRegion() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityLabel> Labels { get { throw null; } }
        public int? RegionLength { get { throw null; } set { } }
        public int? RegionOffset { get { throw null; } set { } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityRegion System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityRegion>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityRegion>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityRegion System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityRegion>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityRegion>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentEntityRegion>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedDocumentSentimentLabel : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentSentimentLabel>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentSentimentLabel>
    {
        public ExportedDocumentSentimentLabel() { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringSentiment? Category { get { throw null; } set { } }
        public int? Length { get { throw null; } set { } }
        public int? Offset { get { throw null; } set { } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentSentimentLabel System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentSentimentLabel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentSentimentLabel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentSentimentLabel System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentSentimentLabel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentSentimentLabel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedDocumentSentimentLabel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedEntity : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntity>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntity>
    {
        public ExportedEntity() { }
        public string Category { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntity System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntity System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedEntityList : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityList>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityList>
    {
        public ExportedEntityList() { }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntitySublist> Sublists { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityList System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityList>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityList>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityList System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityList>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityList>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityList>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedEntityListSynonym : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityListSynonym>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityListSynonym>
    {
        public ExportedEntityListSynonym() { }
        public string Language { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Values { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityListSynonym System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityListSynonym>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityListSynonym>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityListSynonym System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityListSynonym>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityListSynonym>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityListSynonym>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedEntitySublist : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntitySublist>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntitySublist>
    {
        public ExportedEntitySublist() { }
        public string ListKey { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntityListSynonym> Synonyms { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntitySublist System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntitySublist>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntitySublist>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntitySublist System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntitySublist>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntitySublist>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedEntitySublist>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedModelConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelConfig>
    {
        public ExportedModelConfig(string trainedModelLabel) { }
        public string TrainedModelLabel { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedModelJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelJobState>
    {
        internal ExportedModelJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedModelManifest : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelManifest>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelManifest>
    {
        internal ExportedModelManifest() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.ModelFile> ModelFiles { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelManifest System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelManifest>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelManifest>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelManifest System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelManifest>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelManifest>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedModelManifest>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedPrebuiltEntity : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedPrebuiltEntity>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedPrebuiltEntity>
    {
        public ExportedPrebuiltEntity(string category) { }
        public string Category { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedPrebuiltEntity System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedPrebuiltEntity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedPrebuiltEntity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedPrebuiltEntity System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedPrebuiltEntity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedPrebuiltEntity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedPrebuiltEntity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedProject : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProject>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProject>
    {
        public ExportedProject(string projectFileVersion, Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType stringIndexType, Azure.AI.Language.Authoring.Analyzetext.Models.CreateProjectConfig metadata) { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets Assets { get { throw null; } set { } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.CreateProjectConfig Metadata { get { throw null; } }
        public string ProjectFileVersion { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType StringIndexType { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProject System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProject>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProject>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProject System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProject>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProject>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProject>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class ExportedProjectAssets : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets>
    {
        protected ExportedProjectAssets() { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedProjectAssets>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportedTrainedModel : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedTrainedModel>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedTrainedModel>
    {
        internal ExportedTrainedModel() { }
        public string ExportedModelName { get { throw null; } }
        public System.DateTimeOffset LastExportedModelDateTime { get { throw null; } }
        public System.DateTimeOffset LastTrainedDateTime { get { throw null; } }
        public System.DateTimeOffset ModelExpirationDate { get { throw null; } }
        public string ModelId { get { throw null; } }
        public string ModelTrainingConfigVersion { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedTrainedModel System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedTrainedModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedTrainedModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportedTrainedModel System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedTrainedModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedTrainedModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportedTrainedModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExportProjectJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportProjectJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportProjectJobState>
    {
        internal ExportProjectJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public string ResultUrl { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportProjectJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportProjectJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportProjectJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ExportProjectJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportProjectJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportProjectJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ExportProjectJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ImportProjectJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ImportProjectJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ImportProjectJobState>
    {
        internal ImportProjectJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ImportProjectJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ImportProjectJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ImportProjectJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ImportProjectJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ImportProjectJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ImportProjectJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ImportProjectJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct InnerErrorCode : System.IEquatable<Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public InnerErrorCode(string value) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode AzureCognitiveSearchNotFound { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode AzureCognitiveSearchThrottling { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode EmptyRequest { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode ExtractionFailure { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode InvalidCountryHint { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode InvalidDocument { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode InvalidDocumentBatch { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode InvalidParameterValue { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode InvalidRequest { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode InvalidRequestBodyFormat { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode KnowledgeBaseNotFound { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode MissingInputDocuments { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode ModelVersionIncorrect { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode UnsupportedLanguageCode { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode left, Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode left, Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class InnerErrorModel : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorModel>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorModel>
    {
        internal InnerErrorModel() { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorCode Code { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Details { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorModel Innererror { get { throw null; } }
        public string Message { get { throw null; } }
        public string Target { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorModel System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorModel System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct JobStatus : System.IEquatable<Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public JobStatus(string value) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Cancelled { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Cancelling { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Failed { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus NotStarted { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus PartiallyCompleted { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Running { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Succeeded { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus left, Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus left, Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LoadSnapshotJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.LoadSnapshotJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.LoadSnapshotJobState>
    {
        internal LoadSnapshotJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.LoadSnapshotJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.LoadSnapshotJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.LoadSnapshotJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.LoadSnapshotJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.LoadSnapshotJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.LoadSnapshotJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.LoadSnapshotJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ModelFile : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ModelFile>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ModelFile>
    {
        internal ModelFile() { }
        public System.Uri ContentUri { get { throw null; } }
        public string Name { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ModelFile System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ModelFile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ModelFile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ModelFile System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ModelFile>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ModelFile>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ModelFile>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MultiLabelClassEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassEvaluationSummary>
    {
        internal MultiLabelClassEvaluationSummary() { }
        public double F1 { get { throw null; } }
        public int FalseNegativeCount { get { throw null; } }
        public int FalsePositiveCount { get { throw null; } }
        public double Precision { get { throw null; } }
        public double Recall { get { throw null; } }
        public int TrueNegativeCount { get { throw null; } }
        public int TruePositiveCount { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MultiLabelClassificationEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassificationEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassificationEvaluationSummary>
    {
        internal MultiLabelClassificationEvaluationSummary() { }
        public System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassEvaluationSummary> Classes { get { throw null; } }
        public float MacroF1 { get { throw null; } }
        public float MacroPrecision { get { throw null; } }
        public float MacroRecall { get { throw null; } }
        public float MicroF1 { get { throw null; } }
        public float MicroPrecision { get { throw null; } }
        public float MicroRecall { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassificationEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassificationEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassificationEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassificationEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassificationEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassificationEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.MultiLabelClassificationEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PrebuiltEntity : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.PrebuiltEntity>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.PrebuiltEntity>
    {
        internal PrebuiltEntity() { }
        public string Category { get { throw null; } }
        public string Description { get { throw null; } }
        public string Examples { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.PrebuiltEntity System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.PrebuiltEntity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.PrebuiltEntity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.PrebuiltEntity System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.PrebuiltEntity>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.PrebuiltEntity>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.PrebuiltEntity>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProjectDeletionJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeletionJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeletionJobState>
    {
        internal ProjectDeletionJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeletionJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeletionJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeletionJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeletionJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeletionJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeletionJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeletionJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProjectDeployment : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeployment>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeployment>
    {
        internal ProjectDeployment() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.DeploymentResource> AssignedResources { get { throw null; } }
        public System.DateTimeOffset DeploymentExpirationDate { get { throw null; } }
        public string DeploymentName { get { throw null; } }
        public System.DateTimeOffset LastDeployedDateTime { get { throw null; } }
        public System.DateTimeOffset LastTrainedDateTime { get { throw null; } }
        public string ModelId { get { throw null; } }
        public string ModelTrainingConfigVersion { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeployment System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeployment>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeployment>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeployment System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeployment>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeployment>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectDeployment>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProjectKind : System.IEquatable<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProjectKind(string value) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind CustomAbstractiveSummarization { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind CustomEntityRecognition { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind CustomHealthcare { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind CustomMultiLabelClassification { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind CustomSingleLabelClassification { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind CustomTextSentiment { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind left, Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind left, Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ProjectMetadata : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectMetadata>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectMetadata>
    {
        internal ProjectMetadata() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public string Description { get { throw null; } }
        public string Language { get { throw null; } }
        public System.DateTimeOffset? LastDeployedDateTime { get { throw null; } }
        public System.DateTimeOffset LastModifiedDateTime { get { throw null; } }
        public System.DateTimeOffset? LastTrainedDateTime { get { throw null; } }
        public bool? Multilingual { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.ProjectKind ProjectKind { get { throw null; } }
        public string ProjectName { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.ProjectSettings Settings { get { throw null; } }
        public string StorageInputContainerName { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ProjectMetadata System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectMetadata>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ProjectMetadata System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectMetadata>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectMetadata>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectMetadata>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProjectSettings : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectSettings>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectSettings>
    {
        public ProjectSettings() { }
        public string AmlProjectPath { get { throw null; } set { } }
        public float? ConfidenceThreshold { get { throw null; } set { } }
        public int? GptPredictiveLookahead { get { throw null; } set { } }
        public bool? IsLabelingLocked { get { throw null; } set { } }
        public bool? RunGptPredictions { get { throw null; } set { } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ProjectSettings System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ProjectSettings System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectSettings>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectSettings>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectSettings>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProjectTrainedModel : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectTrainedModel>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectTrainedModel>
    {
        internal ProjectTrainedModel() { }
        public bool HasSnapshot { get { throw null; } }
        public string Label { get { throw null; } }
        public System.DateTimeOffset LastTrainedDateTime { get { throw null; } }
        public int LastTrainingDurationInSeconds { get { throw null; } }
        public System.DateTimeOffset ModelExpirationDate { get { throw null; } }
        public string ModelId { get { throw null; } }
        public string ModelTrainingConfigVersion { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ProjectTrainedModel System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectTrainedModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectTrainedModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ProjectTrainedModel System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectTrainedModel>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectTrainedModel>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ProjectTrainedModel>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceMetadata : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ResourceMetadata>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ResourceMetadata>
    {
        public ResourceMetadata(string azureResourceId, string customDomain, string region) { }
        public string AzureResourceId { get { throw null; } }
        public string CustomDomain { get { throw null; } }
        public string Region { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.ResourceMetadata System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ResourceMetadata>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.ResourceMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.ResourceMetadata System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ResourceMetadata>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ResourceMetadata>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.ResourceMetadata>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SentimentEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SentimentEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SentimentEvaluationSummary>
    {
        internal SentimentEvaluationSummary() { }
        public double F1 { get { throw null; } }
        public int FalseNegativeCount { get { throw null; } }
        public int FalsePositiveCount { get { throw null; } }
        public double Precision { get { throw null; } }
        public double Recall { get { throw null; } }
        public int TrueNegativeCount { get { throw null; } }
        public int TruePositiveCount { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.SentimentEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SentimentEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SentimentEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.SentimentEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SentimentEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SentimentEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SentimentEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SingleLabelClassEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassEvaluationSummary>
    {
        internal SingleLabelClassEvaluationSummary() { }
        public double F1 { get { throw null; } }
        public int FalseNegativeCount { get { throw null; } }
        public int FalsePositiveCount { get { throw null; } }
        public double Precision { get { throw null; } }
        public double Recall { get { throw null; } }
        public int TrueNegativeCount { get { throw null; } }
        public int TruePositiveCount { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SingleLabelClassificationEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassificationEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassificationEvaluationSummary>
    {
        internal SingleLabelClassificationEvaluationSummary() { }
        public System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassEvaluationSummary> Classes { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix ConfusionMatrix { get { throw null; } }
        public float MacroF1 { get { throw null; } }
        public float MacroPrecision { get { throw null; } }
        public float MacroRecall { get { throw null; } }
        public float MicroF1 { get { throw null; } }
        public float MicroPrecision { get { throw null; } }
        public float MicroRecall { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassificationEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassificationEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassificationEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassificationEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassificationEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassificationEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SingleLabelClassificationEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SpanSentimentEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SpanSentimentEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SpanSentimentEvaluationSummary>
    {
        internal SpanSentimentEvaluationSummary() { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.ConfusionMatrix ConfusionMatrix { get { throw null; } }
        public float MacroF1 { get { throw null; } }
        public float MacroPrecision { get { throw null; } }
        public float MacroRecall { get { throw null; } }
        public float MicroF1 { get { throw null; } }
        public float MicroPrecision { get { throw null; } }
        public float MicroRecall { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, Azure.AI.Language.Authoring.Analyzetext.Models.SentimentEvaluationSummary> Sentiments { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.SpanSentimentEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SpanSentimentEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SpanSentimentEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.SpanSentimentEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SpanSentimentEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SpanSentimentEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SpanSentimentEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct StringIndexType : System.IEquatable<Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public StringIndexType(string value) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType Utf16CodeUnit { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType left, Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType left, Azure.AI.Language.Authoring.Analyzetext.Models.StringIndexType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SubTrainingJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SubTrainingJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SubTrainingJobState>
    {
        internal SubTrainingJobState() { }
        public System.DateTimeOffset? EndDateTime { get { throw null; } }
        public int PercentComplete { get { throw null; } }
        public System.DateTimeOffset? StartDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Status { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.SubTrainingJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SubTrainingJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SubTrainingJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.SubTrainingJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SubTrainingJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SubTrainingJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SubTrainingJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SupportedLanguage : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SupportedLanguage>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SupportedLanguage>
    {
        internal SupportedLanguage() { }
        public string LanguageCode { get { throw null; } }
        public string LanguageName { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.SupportedLanguage System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SupportedLanguage>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SupportedLanguage>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.SupportedLanguage System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SupportedLanguage>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SupportedLanguage>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SupportedLanguage>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SwapDeploymentsConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsConfig>
    {
        public SwapDeploymentsConfig(string firstDeploymentName, string secondDeploymentName) { }
        public string FirstDeploymentName { get { throw null; } }
        public string SecondDeploymentName { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SwapDeploymentsJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsJobState>
    {
        internal SwapDeploymentsJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.SwapDeploymentsJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TextAnalysisAuthoringError : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError>
    {
        internal TextAnalysisAuthoringError() { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.ErrorCode Code { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> Details { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.InnerErrorModel Innererror { get { throw null; } }
        public string Message { get { throw null; } }
        public string Target { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TextAnalysisAuthoringSentiment : System.IEquatable<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringSentiment>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TextAnalysisAuthoringSentiment(string value) { throw null; }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringSentiment Negative { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringSentiment Neutral { get { throw null; } }
        public static Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringSentiment Positive { get { throw null; } }
        public bool Equals(Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringSentiment other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringSentiment left, Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringSentiment right) { throw null; }
        public static implicit operator Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringSentiment (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringSentiment left, Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringSentiment right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TextAnalysisAuthoringWarning : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning>
    {
        internal TextAnalysisAuthoringWarning() { }
        public string Code { get { throw null; } }
        public string Message { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TextSentimentEvaluationSummary : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextSentimentEvaluationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextSentimentEvaluationSummary>
    {
        internal TextSentimentEvaluationSummary() { }
        public float MacroF1 { get { throw null; } }
        public float MacroPrecision { get { throw null; } }
        public float MacroRecall { get { throw null; } }
        public float MicroF1 { get { throw null; } }
        public float MicroPrecision { get { throw null; } }
        public float MicroRecall { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.SpanSentimentEvaluationSummary SpanSentimentsEvaluation { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.TextSentimentEvaluationSummary System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextSentimentEvaluationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextSentimentEvaluationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.TextSentimentEvaluationSummary System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextSentimentEvaluationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextSentimentEvaluationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TextSentimentEvaluationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrainingConfigVersion : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingConfigVersion>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingConfigVersion>
    {
        internal TrainingConfigVersion() { }
        public System.DateTimeOffset ModelExpirationDate { get { throw null; } }
        public string TrainingConfigVersionProperty { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.TrainingConfigVersion System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingConfigVersion>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingConfigVersion>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.TrainingConfigVersion System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingConfigVersion>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingConfigVersion>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingConfigVersion>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrainingJobConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobConfig>
    {
        public TrainingJobConfig(string modelLabel, string trainingConfigVersion) { }
        public Azure.AI.Language.Authoring.Analyzetext.Models.DataGenerationSettings DataGenerationSettings { get { throw null; } set { } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.EvaluationConfig EvaluationOptions { get { throw null; } set { } }
        public string ModelLabel { get { throw null; } }
        public string TrainingConfigVersion { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrainingJobResult : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult>
    {
        internal TrainingJobResult() { }
        public System.DateTimeOffset? EstimatedEndDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.SubTrainingJobState EvaluationStatus { get { throw null; } }
        public string ModelLabel { get { throw null; } }
        public string TrainingConfigVersion { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.SubTrainingJobState TrainingStatus { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrainingJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobState>
    {
        internal TrainingJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobResult Result { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.TrainingJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UnassignDeploymentResourcesConfig : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesConfig>
    {
        public UnassignDeploymentResourcesConfig(System.Collections.Generic.IEnumerable<string> assignedResourceIds) { }
        public System.Collections.Generic.IList<string> AssignedResourceIds { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesConfig System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesConfig System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesConfig>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesConfig>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesConfig>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UnassignDeploymentResourcesJobState : System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesJobState>, System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesJobState>
    {
        internal UnassignDeploymentResourcesJobState() { }
        public System.DateTimeOffset CreatedDateTime { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringError> Errors { get { throw null; } }
        public System.DateTimeOffset? ExpirationDateTime { get { throw null; } }
        public string JobId { get { throw null; } }
        public System.DateTimeOffset LastUpdatedDateTime { get { throw null; } }
        public Azure.AI.Language.Authoring.Analyzetext.Models.JobStatus Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.Authoring.Analyzetext.Models.TextAnalysisAuthoringWarning> Warnings { get { throw null; } }
        Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesJobState System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesJobState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesJobState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesJobState System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesJobState>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesJobState>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.AI.Language.Authoring.Analyzetext.Models.UnassignDeploymentResourcesJobState>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class AILanguageAuthoringAnalyzetextClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Language.Authoring.Analyzetext.AnalyzetextClient, Azure.AI.Language.Authoring.Analyzetext.AnalyzetextClientOptions> AddAnalyzetextClient<TBuilder>(this TBuilder builder, System.Uri endpoint) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithCredential { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Language.Authoring.Analyzetext.AnalyzetextClient, Azure.AI.Language.Authoring.Analyzetext.AnalyzetextClientOptions> AddAnalyzetextClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Language.Authoring.Analyzetext.AnalyzetextClient, Azure.AI.Language.Authoring.Analyzetext.AnalyzetextClientOptions> AddAnalyzetextClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
