// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Generator.Visitors;
using Microsoft.CodeAnalysis;
using Microsoft.TypeSpec.Generator;
using Microsoft.TypeSpec.Generator.ClientModel;
using System;
using System.ComponentModel.Composition;
using System.IO;
using System.Threading.Tasks;
using Azure.Core.Expressions.DataFactory;
using Azure.Generator.Providers;

namespace Azure.Generator;

/// <summary>
/// The Azure client generator to generate the Azure client SDK.
/// </summary>
[Export(typeof(CodeModelGenerator))]
[ExportMetadata(GeneratorMetadataName, nameof(AzureClientGenerator))]
public class AzureClientGenerator : ScmCodeModelGenerator
{
    private static AzureClientGenerator? _instance;
    internal static new AzureClientGenerator Instance => _instance ?? throw new InvalidOperationException("AzureClientGenerator is not loaded.");

    /// <inheritdoc/>
    public override AzureTypeFactory TypeFactory { get; }

    private AzureOutputLibrary? _azureOutputLibrary;
    /// <inheritdoc/>
    public override AzureOutputLibrary OutputLibrary => _azureOutputLibrary ??= new();

    internal RawRequestUriBuilderExtensionsDefinition RawRequestUriBuilderExtensionsDefinition { get; } = new();

    internal RequestHeaderExtensionsDefinition RequestHeaderExtensionsDefinition { get; } = new();

    internal bool HasDataFactoryElement => _hasDataFactoryElement ??= BuildHasDataFactoryElement();
    private bool? _hasDataFactoryElement;
    internal const string DataFactoryElementIdentity = "Azure.Core.Expressions.DataFactoryElement";

    private bool BuildHasDataFactoryElement()
    {
        foreach (var model in InputLibrary.InputNamespace.Models)
        {
            foreach (var property in model.Properties)
            {
                if (property.Type.External?.Identity == DataFactoryElementIdentity)
                {
                    return true;
                }
            }
        }
        return false;
    }

    /// <summary>
    /// Constructs the Azure client generator used to generate the Azure client SDK.
    /// </summary>
    /// <param name="context"></param>
    [ImportingConstructor]
    public AzureClientGenerator(GeneratorContext context) : base(context)
    {
        TypeFactory = new AzureTypeFactory();
        _instance = this;
    }

    /// <summary>
    /// Customize the generation output for Azure client SDK.
    /// </summary>
    protected override void Configure()
    {
        base.Configure();

        // Use Azure-specific configuration schema settings
        ConfigurationSchema.SectionName = "AzureClients";
        ConfigurationSchema.OptionsRef = "azureOptions";
        ConfigurationSchema.GenerateNuGetTargets = false;

        // Include Azure.Core
        AddMetadataReference(MetadataReference.CreateFromFile(typeof(Response).Assembly.Location));
        if (HasDataFactoryElement)
        {
            AddMetadataReference(MetadataReference.CreateFromFile(typeof(DataFactoryElement<>).Assembly.Location));
        }

        var sharedSourceDirectory = Path.Combine(Path.GetDirectoryName(typeof(AzureClientGenerator).Assembly.Location)!, "Shared", "Core");
        AddSharedSourceDirectory(sharedSourceDirectory);

        // Visitors that do any renaming must be added first so that any visitors relying on custom code view will have the CustomCodeView set.
        AddVisitor(new ModelFactoryRenamerVisitor());

        // Rest of the visitors can be added in any order.
        AddVisitor(new NamespaceVisitor());
        AddVisitor(new DistributedTracingVisitor());
        AddVisitor(new PipelinePropertyVisitor());
        AddVisitor(new LroVisitor());
        AddVisitor(new MatchConditionsHeadersVisitor());
        AddVisitor(new ClientRequestIdHeaderVisitor());
        AddVisitor(new SystemTextJsonConverterVisitor());
        AddVisitor(new MultiPartFormDataVisitor());
        AddVisitor(new InvokeDelimitedMethodVisitor());
        AddVisitor(new XmlSerializableVisitor());
        AddVisitor(new ClientSettingsVisitor());
    }

    /// <summary>
    /// Writes additional scaffolding files (README.md, CHANGELOG.md, ci.yml, Directory.Build.props)
    /// when generating a new project. Files are only written if they don't already exist, preventing
    /// overwriting of customized content.
    /// </summary>
    /// <param name="outputPath">The output directory path for the generated project.</param>
    public override async Task WriteAdditionalFiles(string outputPath)
    {
        await base.WriteAdditionalFiles(outputPath);

        string packageName = Configuration.PackageName;

        WriteFileIfNotExists(Path.Combine(outputPath, "README.md"), GetReadmeContent(packageName));
        WriteFileIfNotExists(Path.Combine(outputPath, "CHANGELOG.md"), GetChangelogContent(packageName));
        WriteFileIfNotExists(Path.Combine(outputPath, "Directory.Build.props"), GetDirectoryBuildPropsContent());

        // ci.yml goes to the service directory (parent of the package directory)
        string normalizedOutputPath = outputPath.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
        string? serviceDirectory = Path.GetDirectoryName(normalizedOutputPath);
        if (!string.IsNullOrEmpty(serviceDirectory))
        {
            string ciFilePath = Path.Combine(serviceDirectory, GetCiFileName());
            if (!File.Exists(ciFilePath))
            {
                string serviceDirectoryName = Path.GetFileName(serviceDirectory);
                WriteFileIfNotExists(ciFilePath, GetCiYamlContent(packageName, serviceDirectoryName));
            }
        }
    }

    private static void WriteFileIfNotExists(string filePath, string content)
    {
        if (!File.Exists(filePath))
        {
            string? directory = Path.GetDirectoryName(filePath);
            if (directory != null && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            File.WriteAllText(filePath, content);
        }
    }

    /// <summary>
    /// Gets the file name for the CI YAML file.
    /// </summary>
    /// <returns>The CI YAML file name. Default is "ci.yml" for data plane packages.</returns>
    protected virtual string GetCiFileName() => "ci.yml";

    /// <summary>
    /// Gets the content for the README.md file.
    /// </summary>
    /// <param name="packageName">The name of the package.</param>
    /// <returns>The README.md content.</returns>
    protected virtual string GetReadmeContent(string packageName)
    {
        return $"""
            # {packageName} client library for .NET

            {packageName} is a client library for developing .NET applications with rich experience.

            ## Getting started

            ### Install the package

            Install the client library for .NET with [NuGet](https://www.nuget.org/):

            ```dotnetcli
            dotnet add package {packageName} --prerelease
            ```

            ### Prerequisites

            - You must have a [Microsoft Azure subscription](https://azure.microsoft.com/free/dotnet/).

            ## Key concepts

            ## Examples

            ## Troubleshooting

            ## Next steps

            ## Contributing

            This project welcomes contributions and suggestions. Most contributions require you to agree to a Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us the rights to use your contribution. For details, visit <https://cla.microsoft.com>.

            When you submit a pull request, a CLA-bot will automatically determine whether you need to provide a CLA and decorate the PR appropriately (for example, label, comment). Follow the instructions provided by the bot. You'll only need to do this action once across all repositories using our CLA.

            This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information, see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any other questions or comments.
            """;
    }

    /// <summary>
    /// Gets the content for the CHANGELOG.md file.
    /// </summary>
    /// <param name="packageName">The name of the package.</param>
    /// <returns>The CHANGELOG.md content.</returns>
    protected virtual string GetChangelogContent(string packageName)
    {
        return $"""
            # Release History

            ## 1.0.0-beta.1 (Unreleased)

            ### Features Added

            ### Breaking Changes

            ### Bugs Fixed

            ### Other Changes
            """;
    }

    /// <summary>
    /// Gets the content for the ci.yml file.
    /// </summary>
    /// <param name="packageName">The name of the package.</param>
    /// <param name="serviceDirectoryName">The service directory name.</param>
    /// <returns>The CI YAML content.</returns>
    protected virtual string GetCiYamlContent(string packageName, string serviceDirectoryName)
    {
        string safeName = packageName.Replace(".", "");
        return $"""
            # NOTE: Please refer to https://aka.ms/azsdk/engsys/ci-yaml before editing this file.

            trigger:
              branches:
                include:
                - main
                - hotfix/*
                - release/*
              paths:
                include:
                - sdk/{serviceDirectoryName}/ci.yml
                - sdk/{serviceDirectoryName}/{packageName}/
                - sdk/{serviceDirectoryName}/service.projects

            extends:
              template: /eng/pipelines/templates/stages/archetype-sdk-client.yml
              parameters:
                SDKType: client
                ServiceDirectory: {serviceDirectoryName}
                ArtifactName: packages
                Artifacts:
                - name: {packageName}
                  safeName: {safeName}
            """;
    }

    /// <summary>
    /// Gets the content for the Directory.Build.props file.
    /// </summary>
    /// <returns>The Directory.Build.props content.</returns>
    protected virtual string GetDirectoryBuildPropsContent()
    {
        return """
            <Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
              <!--
                Add any shared properties you want for the projects under this package directory that need to be set before the auto imported Directory.Build.props
              -->
              <Import Project="$([MSBuild]::GetDirectoryNameOfFileAbove($(MSBuildThisFileDirectory).., Directory.Build.props))\Directory.Build.props" />
            </Project>
            """;
    }
}