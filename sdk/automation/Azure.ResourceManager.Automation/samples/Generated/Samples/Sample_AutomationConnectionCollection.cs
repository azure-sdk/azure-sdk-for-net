// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Automation.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Automation.Samples
{
    public partial class Sample_AutomationConnectionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateConnection()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/createOrUpdateConnection.json
            // this example is just showing the usage of "Connection_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount28";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationConnectionResource
            AutomationConnectionCollection collection = automationAccount.GetAutomationConnections();

            // invoke the operation
            string connectionName = "mysConnection";
            AutomationConnectionCreateOrUpdateContent content = new AutomationConnectionCreateOrUpdateContent("mysConnection", new ConnectionTypeAssociationProperty
            {
                Name = "Azure",
            })
            {
                Description = "my description goes here",
                FieldDefinitionValues =
{
["AutomationCertificateName"] = "mysCertificateName",
["SubscriptionID"] = "subid"
},
            };
            ArmOperation<AutomationConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, connectionName, content);
            AutomationConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAConnection()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getConnection.json
            // this example is just showing the usage of "Connection_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount28";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationConnectionResource
            AutomationConnectionCollection collection = automationAccount.GetAutomationConnections();

            // invoke the operation
            string connectionName = "myConnection";
            AutomationConnectionResource result = await collection.GetAsync(connectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListConnectionsByAutomationAccountFirst100()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/listConnectionsByAutomationAccount_First100.json
            // this example is just showing the usage of "Connection_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount28";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationConnectionResource
            AutomationConnectionCollection collection = automationAccount.GetAutomationConnections();

            // invoke the operation and iterate over the result
            await foreach (AutomationConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomationConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListConnectionsByAutomationAccountNext100()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/listConnectionsByAutomationAccount_Next100.json
            // this example is just showing the usage of "Connection_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount28";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationConnectionResource
            AutomationConnectionCollection collection = automationAccount.GetAutomationConnections();

            // invoke the operation and iterate over the result
            await foreach (AutomationConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomationConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAConnection()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getConnection.json
            // this example is just showing the usage of "Connection_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount28";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationConnectionResource
            AutomationConnectionCollection collection = automationAccount.GetAutomationConnections();

            // invoke the operation
            string connectionName = "myConnection";
            bool result = await collection.ExistsAsync(connectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAConnection()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getConnection.json
            // this example is just showing the usage of "Connection_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount28";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationConnectionResource
            AutomationConnectionCollection collection = automationAccount.GetAutomationConnections();

            // invoke the operation
            string connectionName = "myConnection";
            NullableResponse<AutomationConnectionResource> response = await collection.GetIfExistsAsync(connectionName);
            AutomationConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomationConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
