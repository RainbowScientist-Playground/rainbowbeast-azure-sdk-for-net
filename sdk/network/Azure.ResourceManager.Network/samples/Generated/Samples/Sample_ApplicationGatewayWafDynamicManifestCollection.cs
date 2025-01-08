// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ApplicationGatewayWafDynamicManifestCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsWAFDefaultManifest()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/GetApplicationGatewayWafDynamicManifestsDefault.json
            // this example is just showing the usage of "ApplicationGatewayWafDynamicManifestsDefault_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ApplicationGatewayWafDynamicManifestResource
            AzureLocation location = new AzureLocation("westus");
            ApplicationGatewayWafDynamicManifestCollection collection = subscriptionResource.GetApplicationGatewayWafDynamicManifests(location);

            // invoke the operation
            ApplicationGatewayWafDynamicManifestResource result = await collection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApplicationGatewayWafDynamicManifestData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetsWAFManifests()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/GetApplicationGatewayWafDynamicManifests.json
            // this example is just showing the usage of "ApplicationGatewayWafDynamicManifests_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ApplicationGatewayWafDynamicManifestResource
            AzureLocation location = new AzureLocation("westus");
            ApplicationGatewayWafDynamicManifestCollection collection = subscriptionResource.GetApplicationGatewayWafDynamicManifests(location);

            // invoke the operation and iterate over the result
            await foreach (ApplicationGatewayWafDynamicManifestResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApplicationGatewayWafDynamicManifestData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetsWAFDefaultManifest()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/GetApplicationGatewayWafDynamicManifestsDefault.json
            // this example is just showing the usage of "ApplicationGatewayWafDynamicManifestsDefault_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ApplicationGatewayWafDynamicManifestResource
            AzureLocation location = new AzureLocation("westus");
            ApplicationGatewayWafDynamicManifestCollection collection = subscriptionResource.GetApplicationGatewayWafDynamicManifests(location);

            // invoke the operation
            bool result = await collection.ExistsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetsWAFDefaultManifest()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/GetApplicationGatewayWafDynamicManifestsDefault.json
            // this example is just showing the usage of "ApplicationGatewayWafDynamicManifestsDefault_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this ApplicationGatewayWafDynamicManifestResource
            AzureLocation location = new AzureLocation("westus");
            ApplicationGatewayWafDynamicManifestCollection collection = subscriptionResource.GetApplicationGatewayWafDynamicManifests(location);

            // invoke the operation
            NullableResponse<ApplicationGatewayWafDynamicManifestResource> response = await collection.GetIfExistsAsync();
            ApplicationGatewayWafDynamicManifestResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApplicationGatewayWafDynamicManifestData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
