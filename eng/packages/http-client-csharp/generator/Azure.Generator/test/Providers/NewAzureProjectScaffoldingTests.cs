// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Generator.Primitives;
using Azure.Generator.Tests.TestHelpers;
using NUnit.Framework;

namespace Azure.Generator.Tests.Providers
{
    public class NewAzureProjectScaffoldingTests
    {
        [SetUp]
        public void SetUp()
        {
            MockHelpers.LoadMockGenerator();
        }

        [Test]
        public void GetCiFileNameReturnsCiYml()
        {
            var scaffolding = new TestableNewAzureProjectScaffolding();
            Assert.AreEqual("ci.yml", scaffolding.TestGetCiFileName());
        }

        [Test]
        public void GetReadmeContentContainsPackageName()
        {
            var scaffolding = new TestableNewAzureProjectScaffolding();
            string content = scaffolding.TestGetReadmeContent("Azure.Test.Package");
            Assert.IsTrue(content.Contains("Azure.Test.Package"));
            Assert.IsTrue(content.Contains("client library for .NET"));
            Assert.IsTrue(content.Contains("Getting started"));
            Assert.IsTrue(content.Contains("Install the package"));
        }

        [Test]
        public void GetChangelogContentContainsReleaseHistory()
        {
            var scaffolding = new TestableNewAzureProjectScaffolding();
            string content = scaffolding.TestGetChangelogContent("Azure.Test.Package");
            Assert.IsTrue(content.Contains("# Release History"));
            Assert.IsTrue(content.Contains("## 1.0.0-beta.1 (Unreleased)"));
            Assert.IsTrue(content.Contains("### Features Added"));
        }

        [Test]
        public void GetCiYamlContentContainsPackageInfo()
        {
            var scaffolding = new TestableNewAzureProjectScaffolding();
            string content = scaffolding.TestGetCiYamlContent("Azure.Test.Package", "testservice");
            Assert.IsTrue(content.Contains("Azure.Test.Package"));
            Assert.IsTrue(content.Contains("AzureTestPackage"));
            Assert.IsTrue(content.Contains("testservice"));
            Assert.IsTrue(content.Contains("SDKType: client"));
            Assert.IsTrue(content.Contains("trigger:"));
        }

        [Test]
        public void GetDirectoryBuildPropsContentContainsMSBuildImport()
        {
            var scaffolding = new TestableNewAzureProjectScaffolding();
            string content = scaffolding.TestGetDirectoryBuildPropsContent();
            Assert.IsTrue(content.Contains("GetDirectoryNameOfFileAbove"));
            Assert.IsTrue(content.Contains("Directory.Build.props"));
            Assert.IsTrue(content.Contains("<Project"));
        }

        [Test]
        public void GetServiceDirectoryNameExtractsCorrectName()
        {
            string result = TestableNewAzureProjectScaffolding.TestGetServiceDirectoryName("/sdk/testservice/Azure.Test.Package");
            Assert.AreEqual("testservice", result);
        }

        [Test]
        public void GetCiYamlContentSafeNameRemovesDots()
        {
            var scaffolding = new TestableNewAzureProjectScaffolding();
            string content = scaffolding.TestGetCiYamlContent("Azure.Storage.Blobs", "storage");
            Assert.IsTrue(content.Contains("safeName: AzureStorageBlobs"));
        }

        /// <summary>
        /// Testable wrapper that exposes protected methods for testing.
        /// </summary>
        private class TestableNewAzureProjectScaffolding : NewAzureProjectScaffolding
        {
            public string TestGetCiFileName() => GetCiFileName();
            public string TestGetReadmeContent(string packageName) => GetReadmeContent(packageName);
            public string TestGetChangelogContent(string packageName) => GetChangelogContent(packageName);
            public string TestGetCiYamlContent(string packageName, string serviceDirectoryName) => GetCiYamlContent(packageName, serviceDirectoryName);
            public string TestGetDirectoryBuildPropsContent() => GetDirectoryBuildPropsContent();
            public static string TestGetServiceDirectoryName(string outputDir) => GetServiceDirectoryName(outputDir);
        }
    }
}
