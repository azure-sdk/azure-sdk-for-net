// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.StorageMover.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.StorageMover.Tests.Scenario
{
    public class EndpointTests : StorageMoverManagementTestBase
    {
        public EndpointTests(bool isAsync)
            : base(isAsync) //, RecordedTestMode.Record)
        {
        }

        [Test]
        [RecordedTest]
        public async Task CreateUpdateGetDeleteTest()
        {
            ResourceGroupResource resourceGroup = await GetResourceGroupAsync(ResourceGroupName);
            StorageMoverCollection storageMovers = resourceGroup.GetStorageMovers();
            StorageMoverEndpointCollection endpoints = (await storageMovers.GetAsync(StorageMoverName)).Value.GetStorageMoverEndpoints();

            string cEndpointName = Recording.GenerateAssetName("conendpoint-");
            string nfsEndpointName = Recording.GenerateAssetName("nfsendpoint-");
            string smbEndpointName = Recording.GenerateAssetName("smbendpoint-");
            string fsEndpointName = Recording.GenerateAssetName("fsendpoint-");
            string accountResourceId = DefaultSubscription.Id.ToString() + "/resourceGroups/" + ResourceGroupName +
                "/providers/Microsoft.Storage/storageAccounts/" + StorageAccountName;

            // Create and get a container endpoint
            AzureStorageBlobContainerEndpointProperties containerEndpointProperties =
                new AzureStorageBlobContainerEndpointProperties(accountResourceId, ContainerName);
            StorageMoverEndpointData data = new StorageMoverEndpointData(containerEndpointProperties);
            data.Properties.Description = "New container endpoint";
            StorageMoverEndpointResource cEndpoint = (await endpoints.CreateOrUpdateAsync(WaitUntil.Completed, cEndpointName, data)).Value;
            Assert.AreEqual(cEndpoint.Data.Name, cEndpointName);
            Assert.AreEqual("AzureStorageBlobContainer", cEndpoint.Data.Properties.EndpointType.ToString());

            StorageMoverEndpointResource cEndpoint2 = (await cEndpoint.GetAsync()).Value;
            Assert.AreEqual(cEndpoint2.Data.Name, cEndpointName);
            Assert.AreEqual(cEndpoint2.Data.Properties.EndpointType.ToString(), "AzureStorageBlobContainer");

            cEndpoint = (await endpoints.GetAsync(cEndpointName)).Value;
            Assert.AreEqual(cEndpoint.Data.Name, cEndpointName);
            Assert.AreEqual("AzureStorageBlobContainer", cEndpoint.Data.Properties.EndpointType.ToString());

            // Create and get a NFS endpoint
            NfsMountEndpointProperties nfsMountEndpointProperties = new NfsMountEndpointProperties("10.0.0.1", "/");
            data = new StorageMoverEndpointData(nfsMountEndpointProperties);
            data.Properties.Description = "New NFS endpoint";
            StorageMoverEndpointResource nfsEndpoint = (await endpoints.CreateOrUpdateAsync(WaitUntil.Completed, nfsEndpointName, data)).Value;
            Assert.AreEqual(nfsEndpoint.Data.Name, nfsEndpointName);
            Assert.AreEqual("NfsMount", nfsEndpoint.Data.Properties.EndpointType.ToString());
            Assert.AreEqual(((NfsMountEndpointProperties)nfsEndpoint.Data.Properties).Export, "/");
            Assert.AreEqual(((NfsMountEndpointProperties)nfsEndpoint.Data.Properties).Host, "10.0.0.1");

            nfsEndpoint = (await endpoints.GetAsync(nfsEndpointName)).Value;
            Assert.AreEqual(nfsEndpoint.Data.Name, nfsEndpointName);
            Assert.AreEqual("NfsMount", nfsEndpoint.Data.Properties.EndpointType.ToString());
            Assert.AreEqual(((NfsMountEndpointProperties)nfsEndpoint.Data.Properties).Export, "/");
            Assert.AreEqual(((NfsMountEndpointProperties)nfsEndpoint.Data.Properties).Host, "10.0.0.1");

            // Create, get, update and delete a SMB endpoint
            SmbMountEndpointProperties smbMountEndpointProperties = new SmbMountEndpointProperties("10.0.0.1", "testshare");
            AzureKeyVaultSmbCredentials credentials = new AzureKeyVaultSmbCredentials
            {
                UsernameUriString = "https://examples-azureKeyVault.vault.azure.net/secrets/examples-username",
                PasswordUriString = "https://examples-azureKeyVault.vault.azure.net/secrets/examples-password",
            };
            data = new StorageMoverEndpointData(smbMountEndpointProperties);
            smbMountEndpointProperties.Credentials = credentials;
            data.Properties.Description = "New Smb mount endpoint";
            StorageMoverEndpointResource smbEndpoint = (await endpoints.CreateOrUpdateAsync(WaitUntil.Completed, smbEndpointName, data)).Value;
            Assert.AreEqual(smbEndpoint.Data.Name, smbEndpointName);
            Assert.AreEqual(smbEndpoint.Data.Properties.EndpointType.ToString(), "SmbMount");
            Assert.AreEqual(((SmbMountEndpointProperties)smbEndpoint.Data.Properties).Credentials.UsernameUriString, "https://examples-azureKeyVault.vault.azure.net/secrets/examples-username");
            Assert.AreEqual(((SmbMountEndpointProperties)smbEndpoint.Data.Properties).Credentials.PasswordUriString, "https://examples-azureKeyVault.vault.azure.net/secrets/examples-password");
            Assert.AreEqual(((SmbMountEndpointProperties)smbEndpoint.Data.Properties).Host, "10.0.0.1");
            Assert.AreEqual(((SmbMountEndpointProperties)smbEndpoint.Data.Properties).ShareName, "testshare");

            smbEndpoint = (await endpoints.GetAsync(smbEndpointName)).Value;
            Assert.AreEqual(smbEndpoint.Data.Name, smbEndpointName);
            Assert.AreEqual(smbEndpoint.Data.Properties.EndpointType.ToString(), "SmbMount");
            Assert.AreEqual(((SmbMountEndpointProperties)smbEndpoint.Data.Properties).Credentials.UsernameUriString, "https://examples-azureKeyVault.vault.azure.net/secrets/examples-username");
            Assert.AreEqual(((SmbMountEndpointProperties)smbEndpoint.Data.Properties).Credentials.PasswordUriString, "https://examples-azureKeyVault.vault.azure.net/secrets/examples-password");
            Assert.AreEqual(((SmbMountEndpointProperties)smbEndpoint.Data.Properties).Host, "10.0.0.1");
            Assert.AreEqual(((SmbMountEndpointProperties)smbEndpoint.Data.Properties).ShareName, "testshare");

            credentials.UsernameUriString = "";
            credentials.PasswordUriString = "";
            SmbMountEndpointUpdateProperties updateProperties = new SmbMountEndpointUpdateProperties
            {
                Credentials = credentials,
                Description = "Update endpoint",
            };
            StorageMoverEndpointPatch patch = new StorageMoverEndpointPatch
            {
                Properties = updateProperties,
            };
            patch.Properties = updateProperties;
            smbEndpoint = (await smbEndpoint.UpdateAsync(patch)).Value;
            Assert.AreEqual(smbEndpoint.Data.Name, smbEndpointName);
            Assert.AreEqual(smbEndpoint.Data.Properties.EndpointType.ToString(), "SmbMount");
            Assert.AreEqual(((SmbMountEndpointProperties)smbEndpoint.Data.Properties).Credentials.PasswordUriString, "");
            Assert.AreEqual(((SmbMountEndpointProperties)smbEndpoint.Data.Properties).Credentials.UsernameUriString, "");
            Assert.AreEqual(((SmbMountEndpointProperties)smbEndpoint.Data.Properties).Host, "10.0.0.1");
            Assert.AreEqual(((SmbMountEndpointProperties)smbEndpoint.Data.Properties).ShareName, "testshare");

            await smbEndpoint.DeleteAsync(WaitUntil.Completed);

            // Create and get a file share endpoint
            AzureStorageSmbFileShareEndpointProperties fileShareEndpointProperties = new AzureStorageSmbFileShareEndpointProperties(new Core.ResourceIdentifier(accountResourceId), "testfileshare");
            data = new StorageMoverEndpointData(fileShareEndpointProperties);
            data.Properties.Description = "new file share endpoint";
            StorageMoverEndpointResource fsEndpoint = (await endpoints.CreateOrUpdateAsync(WaitUntil.Completed, fsEndpointName, data)).Value;
            Assert.AreEqual(fsEndpoint.Data.Name, fsEndpointName);
            Assert.AreEqual(fsEndpoint.Data.Properties.EndpointType.ToString(), "AzureStorageSmbFileShare");
            Assert.AreEqual(((AzureStorageSmbFileShareEndpointProperties)fsEndpoint.Data.Properties).FileShareName, "testfileshare");
            Assert.AreEqual(((AzureStorageSmbFileShareEndpointProperties)fsEndpoint.Data.Properties).Description, "new file share endpoint");

            fsEndpoint = (await endpoints.GetAsync(fsEndpointName)).Value;
            Assert.AreEqual(fsEndpoint.Data.Name, fsEndpointName);
            Assert.AreEqual(fsEndpoint.Data.Properties.EndpointType.ToString(), "AzureStorageSmbFileShare");
            Assert.AreEqual(((AzureStorageSmbFileShareEndpointProperties)fsEndpoint.Data.Properties).FileShareName, "testfileshare");
            Assert.AreEqual(((AzureStorageSmbFileShareEndpointProperties)fsEndpoint.Data.Properties).Description, "new file share endpoint");

            int counter = 0;
            await foreach (StorageMoverEndpointResource _ in endpoints.GetAllAsync())
            {
                counter++;
            }
            Assert.Greater(counter, 1);

            Assert.IsTrue(await endpoints.ExistsAsync(cEndpointName));
            Assert.IsFalse(await endpoints.ExistsAsync(cEndpointName + "111"));
            Assert.IsFalse(await endpoints.ExistsAsync(smbEndpointName));
        }

        [Test]
        [RecordedTest]
        public async Task MultiCloudConnectorEndpointCreateGetDeleteTest()
        {
            ResourceGroupResource resourceGroup = await GetResourceGroupAsync(ResourceGroupName);
            StorageMoverCollection storageMovers = resourceGroup.GetStorageMovers();
            StorageMoverEndpointCollection endpoints = (await storageMovers.GetAsync(StorageMoverName)).Value.GetStorageMoverEndpoints();

            string endpointName = Recording.GenerateAssetName("mcc-");

            // Create Azure Multi-Cloud Connector endpoint
            AzureMultiCloudConnectorEndpointProperties mccProperties =
                new AzureMultiCloudConnectorEndpointProperties(new ResourceIdentifier(MultiCloudConnectorId), new ResourceIdentifier(AwsS3BucketId));
            mccProperties.Description = "Test multi-cloud connector endpoint";

            StorageMoverEndpointData data = new StorageMoverEndpointData(mccProperties);
            StorageMoverEndpointResource endpoint = (await endpoints.CreateOrUpdateAsync(WaitUntil.Completed, endpointName, data)).Value;
            Assert.AreEqual(endpointName, endpoint.Data.Name);
            Assert.AreEqual("AzureMultiCloudConnector", endpoint.Data.Properties.EndpointType.ToString());

            // Get and verify properties
            endpoint = (await endpoints.GetAsync(endpointName)).Value;
            Assert.AreEqual(endpointName, endpoint.Data.Name);
            AzureMultiCloudConnectorEndpointProperties retrievedProps = (AzureMultiCloudConnectorEndpointProperties)endpoint.Data.Properties;
            Assert.AreEqual("Test multi-cloud connector endpoint", retrievedProps.Description);
            Assert.IsNotNull(retrievedProps.MultiCloudConnectorId);
            Assert.IsNotNull(retrievedProps.AwsS3BucketId);

            // Delete endpoint
            await endpoint.DeleteAsync(WaitUntil.Completed);
            Assert.IsFalse(await endpoints.ExistsAsync(endpointName));
        }

        [Test]
        [RecordedTest]
        public async Task NfsFileShareEndpointCreateGetDeleteTest()
        {
            ResourceGroupResource resourceGroup = await GetResourceGroupAsync(ResourceGroupName);
            StorageMoverCollection storageMovers = resourceGroup.GetStorageMovers();
            StorageMoverEndpointCollection endpoints = (await storageMovers.GetAsync(StorageMoverName)).Value.GetStorageMoverEndpoints();

            string endpointName = Recording.GenerateAssetName("nfsfs-");
            string accountResourceId = DefaultSubscription.Id.ToString() + "/resourceGroups/" + ResourceGroupName +
                "/providers/Microsoft.Storage/storageAccounts/" + StorageAccountName;

            // Create NFS file share endpoint
            AzureStorageNfsFileShareEndpointProperties nfsFileShareProps =
                new AzureStorageNfsFileShareEndpointProperties(new ResourceIdentifier(accountResourceId), "testnfsfileshare");
            nfsFileShareProps.Description = "Test NFS file share endpoint";

            StorageMoverEndpointData data = new StorageMoverEndpointData(nfsFileShareProps);
            StorageMoverEndpointResource endpoint = (await endpoints.CreateOrUpdateAsync(WaitUntil.Completed, endpointName, data)).Value;
            Assert.AreEqual(endpointName, endpoint.Data.Name);
            Assert.AreEqual("AzureStorageNfsFileShare", endpoint.Data.Properties.EndpointType.ToString());

            // Get and verify properties
            endpoint = (await endpoints.GetAsync(endpointName)).Value;
            Assert.AreEqual(endpointName, endpoint.Data.Name);
            AzureStorageNfsFileShareEndpointProperties retrievedProps = (AzureStorageNfsFileShareEndpointProperties)endpoint.Data.Properties;
            Assert.AreEqual("testnfsfileshare", retrievedProps.FileShareName);
            Assert.AreEqual("Test NFS file share endpoint", retrievedProps.Description);
            Assert.IsNotNull(retrievedProps.StorageAccountResourceId);

            // Delete endpoint
            await endpoint.DeleteAsync(WaitUntil.Completed);
            Assert.IsFalse(await endpoints.ExistsAsync(endpointName));
        }
    }
}
