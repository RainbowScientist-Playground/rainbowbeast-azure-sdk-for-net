// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Resources.Samples
{
    public partial class Sample_ResourceProviderResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetProvider()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2022-09-01/examples/GetProvider.json
            // this example is just showing the usage of "Providers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceProviderResource created on azure
            // for more information of creating ResourceProviderResource, please refer to the document of ResourceProviderResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceProviderNamespace = "Microsoft.TestRP1";
            ResourceIdentifier resourceProviderResourceId = ResourceProviderResource.CreateResourceIdentifier(subscriptionId, resourceProviderNamespace);
            ResourceProviderResource resourceProvider = client.GetResourceProviderResource(resourceProviderResourceId);

            // invoke the operation
            ResourceProviderResource result = await resourceProvider.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceProviderData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ProviderPermissions_GetProviderResourceTypes()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2022-09-01/examples/GetProviderPermissions.json
            // this example is just showing the usage of "Providers_ProviderPermissions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceProviderResource created on azure
            // for more information of creating ResourceProviderResource, please refer to the document of ResourceProviderResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceProviderNamespace = "Microsoft.TestRP";
            ResourceIdentifier resourceProviderResourceId = ResourceProviderResource.CreateResourceIdentifier(subscriptionId, resourceProviderNamespace);
            ResourceProviderResource resourceProvider = client.GetResourceProviderResource(resourceProviderResourceId);

            // invoke the operation and iterate over the result
            await foreach (ProviderPermission item in resourceProvider.ProviderPermissionsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetProviderResourceTypes_GetProviderResourceTypes()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2022-09-01/examples/GetProviderResourceTypes.json
            // this example is just showing the usage of "ProviderResourceTypes_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceProviderResource created on azure
            // for more information of creating ResourceProviderResource, please refer to the document of ResourceProviderResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceProviderNamespace = "Microsoft.TestRP";
            ResourceIdentifier resourceProviderResourceId = ResourceProviderResource.CreateResourceIdentifier(subscriptionId, resourceProviderNamespace);
            ResourceProviderResource resourceProvider = client.GetResourceProviderResource(resourceProviderResourceId);

            // invoke the operation and iterate over the result
            await foreach (ProviderResourceType item in resourceProvider.GetProviderResourceTypesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
