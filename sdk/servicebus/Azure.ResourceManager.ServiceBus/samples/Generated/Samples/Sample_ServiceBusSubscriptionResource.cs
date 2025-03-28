// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceBus.Samples
{
    public partial class Sample_ServiceBusSubscriptionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SubscriptionGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2024-01-01/examples/Subscriptions/SBSubscriptionGet.json
            // this example is just showing the usage of "Subscriptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusSubscriptionResource created on azure
            // for more information of creating ServiceBusSubscriptionResource, please refer to the document of ServiceBusSubscriptionResource
            string subscriptionId = "Subscriptionid";
            string resourceGroupName = "ResourceGroup";
            string namespaceName = "sdk-Namespace-1349";
            string topicName = "sdk-Topics-8740";
            string subscriptionName = "sdk-Subscriptions-2178";
            ResourceIdentifier serviceBusSubscriptionResourceId = ServiceBusSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName, subscriptionName);
            ServiceBusSubscriptionResource serviceBusSubscription = client.GetServiceBusSubscriptionResource(serviceBusSubscriptionResourceId);

            // invoke the operation
            ServiceBusSubscriptionResource result = await serviceBusSubscription.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_SubscriptionDelete()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2024-01-01/examples/Subscriptions/SBSubscriptionDelete.json
            // this example is just showing the usage of "Subscriptions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusSubscriptionResource created on azure
            // for more information of creating ServiceBusSubscriptionResource, please refer to the document of ServiceBusSubscriptionResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "ResourceGroup";
            string namespaceName = "sdk-Namespace-5882";
            string topicName = "sdk-Topics-1804";
            string subscriptionName = "sdk-Subscriptions-3670";
            ResourceIdentifier serviceBusSubscriptionResourceId = ServiceBusSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName, subscriptionName);
            ServiceBusSubscriptionResource serviceBusSubscription = client.GetServiceBusSubscriptionResource(serviceBusSubscriptionResourceId);

            // invoke the operation
            await serviceBusSubscription.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_SubscriptionCreate()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2024-01-01/examples/Subscriptions/SBSubscriptionCreate.json
            // this example is just showing the usage of "Subscriptions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusSubscriptionResource created on azure
            // for more information of creating ServiceBusSubscriptionResource, please refer to the document of ServiceBusSubscriptionResource
            string subscriptionId = "Subscriptionid";
            string resourceGroupName = "ResourceGroup";
            string namespaceName = "sdk-Namespace-1349";
            string topicName = "sdk-Topics-8740";
            string subscriptionName = "sdk-Subscriptions-2178";
            ResourceIdentifier serviceBusSubscriptionResourceId = ServiceBusSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName, subscriptionName);
            ServiceBusSubscriptionResource serviceBusSubscription = client.GetServiceBusSubscriptionResource(serviceBusSubscriptionResourceId);

            // invoke the operation
            ServiceBusSubscriptionData data = new ServiceBusSubscriptionData
            {
                EnableBatchedOperations = true,
            };
            ArmOperation<ServiceBusSubscriptionResource> lro = await serviceBusSubscription.UpdateAsync(WaitUntil.Completed, data);
            ServiceBusSubscriptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
