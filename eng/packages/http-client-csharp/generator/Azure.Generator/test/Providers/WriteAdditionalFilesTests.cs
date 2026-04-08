// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Generator.Tests.TestHelpers;
using NUnit.Framework;
using System.IO;
using System.Threading.Tasks;

namespace Azure.Generator.Tests.Providers
{
    public class WriteAdditionalFilesTests
    {
        [SetUp]
        public void SetUp()
        {
            MockHelpers.LoadMockGenerator();
        }

        [Test]
        public void GetCiFileNameReturnsCiYml()
        {
            var generator = new TestableAzureClientGenerator();
            Assert.AreEqual("ci.yml", generator.TestGetCiFileName());
        }

        [Test]
        public void GetReadmeContentContainsPackageName()
        {
            var generator = new TestableAzureClientGenerator();
            string content = generator.TestGetReadmeContent("Azure.Test.Package");
            Assert.IsTrue(content.Contains("Azure.Test.Package"));
            Assert.IsTrue(content.Contains("client library for .NET"));
            Assert.IsTrue(content.Contains("Getting started"));
            Assert.IsTrue(content.Contains("Install the package"));
        }

        [Test]
        public void GetReadmeContentUsesCorrectGrammar()
        {
            var generator = new TestableAzureClientGenerator();
            string content = generator.TestGetReadmeContent("Azure.Test.Package");
            Assert.IsTrue(content.Contains("a [Microsoft Azure subscription]"));
            Assert.IsFalse(content.Contains("an [Microsoft Azure subscription]"));
        }

        [Test]
        public void GetChangelogContentContainsReleaseHistory()
        {
            var generator = new TestableAzureClientGenerator();
            string content = generator.TestGetChangelogContent("Azure.Test.Package");
            Assert.IsTrue(content.Contains("# Release History"));
            Assert.IsTrue(content.Contains("## 1.0.0-beta.1 (Unreleased)"));
            Assert.IsTrue(content.Contains("### Features Added"));
        }

        [Test]
        public void GetCiYamlContentContainsPackageInfo()
        {
            var generator = new TestableAzureClientGenerator();
            string content = generator.TestGetCiYamlContent("Azure.Test.Package", "testservice");
            Assert.IsTrue(content.Contains("Azure.Test.Package"));
            Assert.IsTrue(content.Contains("AzureTestPackage"));
            Assert.IsTrue(content.Contains("testservice"));
            Assert.IsTrue(content.Contains("SDKType: client"));
            Assert.IsTrue(content.Contains("trigger:"));
        }

        [Test]
        public void GetDirectoryBuildPropsContentContainsMSBuildImport()
        {
            var generator = new TestableAzureClientGenerator();
            string content = generator.TestGetDirectoryBuildPropsContent();
            Assert.IsTrue(content.Contains("GetDirectoryNameOfFileAbove"));
            Assert.IsTrue(content.Contains("Directory.Build.props"));
            Assert.IsTrue(content.Contains("<Project"));
        }

        [Test]
        public void GetCiYamlContentSafeNameRemovesDots()
        {
            var generator = new TestableAzureClientGenerator();
            string content = generator.TestGetCiYamlContent("Azure.Storage.Blobs", "storage");
            Assert.IsTrue(content.Contains("safeName: AzureStorageBlobs"));
        }

        [Test]
        public async Task WriteAdditionalFilesCreatesExpectedFiles()
        {
            var generator = AzureClientGenerator.Instance;
            string tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName(), "testservice", "Azure.Test.Package");
            try
            {
                Directory.CreateDirectory(tempDir);
                await generator.WriteAdditionalFiles(tempDir);

                Assert.IsTrue(File.Exists(Path.Combine(tempDir, "README.md")));
                Assert.IsTrue(File.Exists(Path.Combine(tempDir, "CHANGELOG.md")));
                Assert.IsTrue(File.Exists(Path.Combine(tempDir, "Directory.Build.props")));

                // ci.yml should be in the parent (service) directory
                string serviceDir = Path.GetDirectoryName(tempDir)!;
                Assert.IsTrue(File.Exists(Path.Combine(serviceDir, "ci.yml")));
            }
            finally
            {
                string rootDir = Path.GetDirectoryName(Path.GetDirectoryName(tempDir)!)!;
                if (Directory.Exists(rootDir))
                {
                    Directory.Delete(rootDir, true);
                }
            }
        }

        [Test]
        public async Task WriteAdditionalFilesDoesNotOverwriteExisting()
        {
            var generator = AzureClientGenerator.Instance;
            string tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName(), "testservice", "Azure.Test.Package");
            try
            {
                Directory.CreateDirectory(tempDir);
                string readmePath = Path.Combine(tempDir, "README.md");
                string existingContent = "# My Custom README";
                File.WriteAllText(readmePath, existingContent);

                await generator.WriteAdditionalFiles(tempDir);

                Assert.AreEqual(existingContent, File.ReadAllText(readmePath));
            }
            finally
            {
                string rootDir = Path.GetDirectoryName(Path.GetDirectoryName(tempDir)!)!;
                if (Directory.Exists(rootDir))
                {
                    Directory.Delete(rootDir, true);
                }
            }
        }

        [Test]
        public async Task WriteAdditionalFilesHandlesTrailingSeparator()
        {
            var generator = AzureClientGenerator.Instance;
            string tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName(), "testservice", "Azure.Test.Package");
            try
            {
                Directory.CreateDirectory(tempDir);
                // Pass path with trailing separator
                await generator.WriteAdditionalFiles(tempDir + Path.DirectorySeparatorChar);

                Assert.IsTrue(File.Exists(Path.Combine(tempDir, "README.md")));

                // ci.yml should be in the correct parent directory, not in tempDir
                string serviceDir = Path.GetDirectoryName(tempDir)!;
                Assert.IsTrue(File.Exists(Path.Combine(serviceDir, "ci.yml")));
                Assert.IsFalse(File.Exists(Path.Combine(tempDir, "ci.yml")));
            }
            finally
            {
                string rootDir = Path.GetDirectoryName(Path.GetDirectoryName(tempDir)!)!;
                if (Directory.Exists(rootDir))
                {
                    Directory.Delete(rootDir, true);
                }
            }
        }

        /// <summary>
        /// Testable subclass that exposes protected virtual methods for content generation testing.
        /// </summary>
        private class TestableAzureClientGenerator : AzureClientGenerator
        {
            public TestableAzureClientGenerator() : base(CreateTestContext())
            {
            }

            public string TestGetCiFileName() => GetCiFileName();
            public string TestGetReadmeContent(string packageName) => GetReadmeContent(packageName);
            public string TestGetChangelogContent(string packageName) => GetChangelogContent(packageName);
            public string TestGetCiYamlContent(string packageName, string serviceDirectoryName) => GetCiYamlContent(packageName, serviceDirectoryName);
            public string TestGetDirectoryBuildPropsContent() => GetDirectoryBuildPropsContent();

            private static Microsoft.TypeSpec.Generator.GeneratorContext CreateTestContext()
            {
                var configFilePath = Path.Combine(System.AppContext.BaseDirectory, "TestHelpers");
                var loadMethod = typeof(Microsoft.TypeSpec.Generator.Configuration).GetMethod("Load", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
                var config = loadMethod!.Invoke(null, [configFilePath, null])!;
                return new Moq.Mock<Microsoft.TypeSpec.Generator.GeneratorContext>(config) { CallBase = true }.Object;
            }
        }
    }
}
