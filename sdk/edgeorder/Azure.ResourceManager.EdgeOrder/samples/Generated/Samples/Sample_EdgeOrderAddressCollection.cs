// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EdgeOrder.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.EdgeOrder.Samples
{
    public partial class Sample_EdgeOrderAddressCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAddress()
        {
            // Generated from example definition: specification/edgeorder/resource-manager/Microsoft.EdgeOrder/stable/2021-12-01/examples/CreateAddress.json
            // this example is just showing the usage of "CreateAddress" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fa68082f-8ff7-4a25-95c7-ce9da541242f";
            string resourceGroupName = "TestRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this EdgeOrderAddressResource
            EdgeOrderAddressCollection collection = resourceGroupResource.GetEdgeOrderAddresses();

            // invoke the operation
            string addressName = "TestMSAddressName";
            EdgeOrderAddressData data = new EdgeOrderAddressData(new AzureLocation("westus"), new EdgeOrderAddressContactDetails("Petr Cech", "1234567890", new string[] { "testemail@microsoft.com" })
            {
                PhoneExtension = "",
            })
            {
                ShippingAddress = new EdgeOrderShippingAddress("16 TOWNSEND ST", "US")
                {
                    StreetAddress2 = "UNIT 1",
                    City = "San Francisco",
                    StateOrProvince = "CA",
                    PostalCode = "94107",
                    CompanyName = "Microsoft",
                    AddressType = EdgeOrderAddressType.None,
                },
            };
            ArmOperation<EdgeOrderAddressResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, addressName, data);
            EdgeOrderAddressResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EdgeOrderAddressData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAddressByName()
        {
            // Generated from example definition: specification/edgeorder/resource-manager/Microsoft.EdgeOrder/stable/2021-12-01/examples/GetAddressByName.json
            // this example is just showing the usage of "GetAddressByName" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fa68082f-8ff7-4a25-95c7-ce9da541242f";
            string resourceGroupName = "TestRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this EdgeOrderAddressResource
            EdgeOrderAddressCollection collection = resourceGroupResource.GetEdgeOrderAddresses();

            // invoke the operation
            string addressName = "TestMSAddressName";
            EdgeOrderAddressResource result = await collection.GetAsync(addressName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EdgeOrderAddressData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAddressesAtResourceGroupLevel()
        {
            // Generated from example definition: specification/edgeorder/resource-manager/Microsoft.EdgeOrder/stable/2021-12-01/examples/ListAddressesAtResourceGroupLevel.json
            // this example is just showing the usage of "ListAddressesAtResourceGroupLevel" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fa68082f-8ff7-4a25-95c7-ce9da541242f";
            string resourceGroupName = "TestRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this EdgeOrderAddressResource
            EdgeOrderAddressCollection collection = resourceGroupResource.GetEdgeOrderAddresses();

            // invoke the operation and iterate over the result
            await foreach (EdgeOrderAddressResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EdgeOrderAddressData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAddressByName()
        {
            // Generated from example definition: specification/edgeorder/resource-manager/Microsoft.EdgeOrder/stable/2021-12-01/examples/GetAddressByName.json
            // this example is just showing the usage of "GetAddressByName" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fa68082f-8ff7-4a25-95c7-ce9da541242f";
            string resourceGroupName = "TestRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this EdgeOrderAddressResource
            EdgeOrderAddressCollection collection = resourceGroupResource.GetEdgeOrderAddresses();

            // invoke the operation
            string addressName = "TestMSAddressName";
            bool result = await collection.ExistsAsync(addressName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAddressByName()
        {
            // Generated from example definition: specification/edgeorder/resource-manager/Microsoft.EdgeOrder/stable/2021-12-01/examples/GetAddressByName.json
            // this example is just showing the usage of "GetAddressByName" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fa68082f-8ff7-4a25-95c7-ce9da541242f";
            string resourceGroupName = "TestRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this EdgeOrderAddressResource
            EdgeOrderAddressCollection collection = resourceGroupResource.GetEdgeOrderAddresses();

            // invoke the operation
            string addressName = "TestMSAddressName";
            NullableResponse<EdgeOrderAddressResource> response = await collection.GetIfExistsAsync(addressName);
            EdgeOrderAddressResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EdgeOrderAddressData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
