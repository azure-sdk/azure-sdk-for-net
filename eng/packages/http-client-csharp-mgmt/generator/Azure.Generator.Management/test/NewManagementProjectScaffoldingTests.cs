// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Generator.Management.Primitives;
using Azure.Generator.Management.Tests.TestHelpers;
using NUnit.Framework;

namespace Azure.Generator.Management.Tests
{
    public class NewManagementProjectScaffoldingTests
    {
        [SetUp]
        public void SetUp()
        {
            ManagementMockHelpers.LoadMockPlugin();
        }

        [Test]
        public void GetManagementReadmeContentContainsPackageName()
        {
            string content = NewManagementProjectScaffolding.GetManagementReadmeContent("Azure.ResourceManager.Test");
            Assert.IsTrue(content.Contains("Azure.ResourceManager.Test"));
            Assert.IsTrue(content.Contains("management client library for .NET"));
            Assert.IsTrue(content.Contains("Getting started"));
            Assert.IsTrue(content.Contains("Authenticate the Client"));
            Assert.IsTrue(content.Contains("mgmt_quickstart.md"));
        }

        [Test]
        public void GetManagementChangelogContentContainsReleaseHistory()
        {
            string content = NewManagementProjectScaffolding.GetManagementChangelogContent();
            Assert.IsTrue(content.Contains("# Release History"));
            Assert.IsTrue(content.Contains("## 1.0.0-beta.1 (Unreleased)"));
            Assert.IsTrue(content.Contains("### Features Added"));
        }

        [Test]
        public void GetManagementCiYamlContentContainsMgmtSettings()
        {
            string content = NewManagementProjectScaffolding.GetManagementCiYamlContent("Azure.ResourceManager.Test", "testservice", "AzureResourceManagerTest");
            Assert.IsTrue(content.Contains("Azure.ResourceManager.Test"));
            Assert.IsTrue(content.Contains("AzureResourceManagerTest"));
            Assert.IsTrue(content.Contains("testservice"));
            Assert.IsTrue(content.Contains("SDKType: mgmtclient"));
            Assert.IsTrue(content.Contains("trigger: none"));
            Assert.IsTrue(content.Contains("LimitForPullRequest: true"));
        }

        [Test]
        public void GetManagementDirectoryBuildPropsContentContainsMSBuildImport()
        {
            string content = NewManagementProjectScaffolding.GetManagementDirectoryBuildPropsContent();
            Assert.IsTrue(content.Contains("GetDirectoryNameOfFileAbove"));
            Assert.IsTrue(content.Contains("Directory.Build.props"));
            Assert.IsTrue(content.Contains("<Project"));
        }

        [Test]
        public void ManagementReadmeIsDifferentFromDataPlane()
        {
            string mgmtContent = NewManagementProjectScaffolding.GetManagementReadmeContent("Azure.ResourceManager.Test");
            Assert.IsTrue(mgmtContent.Contains("management client library"));
            Assert.IsTrue(mgmtContent.Contains("mgmt_quickstart.md"));
        }

        [Test]
        public void ManagementCiYamlHasNoTriggerBranches()
        {
            string content = NewManagementProjectScaffolding.GetManagementCiYamlContent("Azure.ResourceManager.Test", "testservice", "AzureResourceManagerTest");
            Assert.IsTrue(content.Contains("trigger: none"));
            Assert.IsFalse(content.Contains("branches:"));
        }
    }
}
