// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Search.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Search.Samples
{
    public partial class Sample_SearchPrivateEndpointConnectionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PrivateEndpointConnectionUpdate()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/preview/2024-06-01-preview/examples/UpdatePrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // get the collection of this SearchPrivateEndpointConnectionResource
            SearchPrivateEndpointConnectionCollection collection = searchService.GetSearchPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "testEndpoint.50bf4fbe-d7c1-4b48-a642-4f5892642546";
            SearchPrivateEndpointConnectionData data = new SearchPrivateEndpointConnectionData
            {
                Properties = new SearchServicePrivateEndpointConnectionProperties
                {
                    ConnectionState = new SearchServicePrivateLinkServiceConnectionState
                    {
                        Status = SearchServicePrivateLinkServiceConnectionStatus.Rejected,
                        Description = "Rejected for some reason.",
                    },
                },
            };
            ArmOperation<SearchPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            SearchPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SearchPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PrivateEndpointConnectionGet()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/preview/2024-06-01-preview/examples/GetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // get the collection of this SearchPrivateEndpointConnectionResource
            SearchPrivateEndpointConnectionCollection collection = searchService.GetSearchPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "testEndpoint.50bf4fbe-d7c1-4b48-a642-4f5892642546";
            SearchPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SearchPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListPrivateEndpointConnectionsByService()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/preview/2024-06-01-preview/examples/ListPrivateEndpointConnectionsByService.json
            // this example is just showing the usage of "PrivateEndpointConnections_ListByService" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // get the collection of this SearchPrivateEndpointConnectionResource
            SearchPrivateEndpointConnectionCollection collection = searchService.GetSearchPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (SearchPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SearchPrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_PrivateEndpointConnectionGet()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/preview/2024-06-01-preview/examples/GetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // get the collection of this SearchPrivateEndpointConnectionResource
            SearchPrivateEndpointConnectionCollection collection = searchService.GetSearchPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "testEndpoint.50bf4fbe-d7c1-4b48-a642-4f5892642546";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_PrivateEndpointConnectionGet()
        {
            // Generated from example definition: specification/search/resource-manager/Microsoft.Search/preview/2024-06-01-preview/examples/GetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SearchServiceResource created on azure
            // for more information of creating SearchServiceResource, please refer to the document of SearchServiceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string searchServiceName = "mysearchservice";
            ResourceIdentifier searchServiceResourceId = SearchServiceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, searchServiceName);
            SearchServiceResource searchService = client.GetSearchServiceResource(searchServiceResourceId);

            // get the collection of this SearchPrivateEndpointConnectionResource
            SearchPrivateEndpointConnectionCollection collection = searchService.GetSearchPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "testEndpoint.50bf4fbe-d7c1-4b48-a642-4f5892642546";
            NullableResponse<SearchPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            SearchPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SearchPrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
