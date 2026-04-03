// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using Azure.Generator.Primitives;
using Microsoft.TypeSpec.Generator;
using Microsoft.TypeSpec.Generator.Primitives;

namespace Azure.Generator.Management.Primitives
{
    internal class NewManagementProjectScaffolding : NewAzureProjectScaffolding
    {
        protected override IReadOnlyList<CSharpProjectCompileInclude> BuildCompileIncludes()
            => Array.Empty<CSharpProjectCompileInclude>();

        /// <inheritdoc/>
        protected override string GetSourceProjectFileContent()
        {
            // Write additional scaffolding files for management packages
            WriteManagementAdditionalFiles();

            return base.GetSourceProjectFileContent();
        }

        private void WriteManagementAdditionalFiles()
        {
            string outputDir = CodeModelGenerator.Instance.Configuration.OutputDirectory;
            string packageName = CodeModelGenerator.Instance.Configuration.PackageName;

            WriteFileIfNotExists(Path.Combine(outputDir, "README.md"), GetManagementReadmeContent(packageName));
            WriteFileIfNotExists(Path.Combine(outputDir, "CHANGELOG.md"), GetManagementChangelogContent());
            WriteFileIfNotExists(Path.Combine(outputDir, "Directory.Build.props"), GetManagementDirectoryBuildPropsContent());

            // ci.mgmt.yml goes to the service directory (parent of the package directory)
            string serviceDirectory = Path.GetDirectoryName(outputDir)!;
            string ciFilePath = Path.Combine(serviceDirectory, "ci.mgmt.yml");
            if (!File.Exists(ciFilePath))
            {
                string serviceDirectoryName = Path.GetFileName(serviceDirectory);
                string safeName = packageName.Replace(".", "");
                string content = GetManagementCiYamlContent(packageName, serviceDirectoryName, safeName);
                WriteFileIfNotExists(ciFilePath, content);
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

        internal static string GetManagementReadmeContent(string packageName)
        {
            return $"""
                # {packageName} management client library for .NET

                This library follows the [new Azure SDK guidelines](https://azure.github.io/azure-sdk/general_introduction.html), and provides many core capabilities:

                    - Support MSAL.NET, Azure.Identity is out of box for supporting MSAL.NET.
                    - Support [OpenTelemetry](https://opentelemetry.io/) for distributed tracing.
                    - HTTP pipeline with custom policies.
                    - Better error-handling.
                    - Support uniform telemetry across all languages.

                ## Getting started

                ### Install the package

                Install the Microsoft Azure management library for .NET with [NuGet](https://www.nuget.org/):

                ```dotnetcli
                dotnet add package {packageName} --prerelease
                ```

                ### Prerequisites

                - You must have an [Microsoft Azure subscription](https://azure.microsoft.com/free/dotnet/).

                ### Authenticate the Client

                To create an authenticated client and start interacting with Microsoft Azure resources, see the [quickstart guide here](https://github.com/Azure/azure-sdk-for-net/blob/main/doc/dev/mgmt_quickstart.md).

                ## Key concepts

                Key concepts of the Microsoft Azure SDK for .NET can be found [here](https://azure.github.io/azure-sdk/dotnet_introduction.html).

                ## Documentation

                Documentation is available to help you learn how to use this package:

                - [Quickstart](https://github.com/Azure/azure-sdk-for-net/blob/main/doc/dev/mgmt_quickstart.md).
                - [API References](https://docs.microsoft.com/dotnet/api/?view=azure-dotnet).
                - [Authentication](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/identity/Azure.Identity/README.md).

                ## Examples

                Code samples for using the management library for .NET can be found in the following locations:
                - [.NET Management Library Code Samples](https://aka.ms/azuresdk-net-mgmt-samples)

                ## Troubleshooting

                - File an issue via [GitHub Issues](https://github.com/Azure/azure-sdk-for-net/issues).
                - Check [previous questions](https://stackoverflow.com/questions/tagged/azure+.net) or ask new ones on Stack Overflow using Azure and .NET tags.

                ## Next steps

                For more information about Microsoft Azure SDK, see [this website](https://azure.github.io/azure-sdk/).

                ## Contributing

                For details on contributing to this repository, see the [contributing guide](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/resourcemanager/Azure.ResourceManager/docs/CONTRIBUTING.md).

                This project welcomes contributions and suggestions. Most contributions require you to agree to a Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us the rights to use your contribution. For details, visit <https://cla.microsoft.com>.

                When you submit a pull request, a CLA-bot will automatically determine whether you need to provide a CLA and decorate the PR appropriately (for example, label, comment). Follow the instructions provided by the bot. You'll only need to do this action once across all repositories using our CLA.

                This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information, see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any other questions or comments.
                """;
        }

        internal static string GetManagementChangelogContent()
        {
            return """
                # Release History

                ## 1.0.0-beta.1 (Unreleased)

                ### Features Added

                ### Breaking Changes

                ### Bugs Fixed

                ### Other Changes
                """;
        }

        internal static string GetManagementCiYamlContent(string packageName, string serviceDirectoryName, string safeName)
        {
            return $"""
                # NOTE: Please refer to https://aka.ms/azsdk/engsys/ci-yaml before editing this file.

                trigger: none
                extends:
                  template: /eng/pipelines/templates/stages/archetype-sdk-client.yml
                  parameters:
                    SDKType: mgmtclient
                    ServiceDirectory: {serviceDirectoryName}
                    LimitForPullRequest: true
                    Artifacts:
                    - name: {packageName}
                      safeName: {safeName}
                """;
        }

        internal static string GetManagementDirectoryBuildPropsContent()
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
}
