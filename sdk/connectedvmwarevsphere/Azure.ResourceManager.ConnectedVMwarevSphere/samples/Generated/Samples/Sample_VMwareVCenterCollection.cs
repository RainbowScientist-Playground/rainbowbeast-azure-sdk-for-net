// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Samples
{
    public partial class Sample_VMwareVCenterCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateVCenter()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/CreateVCenter.json
            // this example is just showing the usage of "VCenters_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VMwareVCenterResource
            VMwareVCenterCollection collection = resourceGroupResource.GetVMwareVCenters();

            // invoke the operation
            string vcenterName = "ContosoVCenter";
            VMwareVCenterData data = new VMwareVCenterData(new AzureLocation("East US"), "ContosoVMware.contoso.com")
            {
                ExtendedLocation = new ExtendedLocation
                {
                    Name = "/subscriptions/a5015e1c-867f-4533-8541-85cd470d0cfb/resourceGroups/demoRG/providers/Microsoft.ExtendedLocation/customLocations/contoso",
                },
                Port = 1234,
                Credentials = new VICredential
                {
                    Username = "tempuser",
                    Password = "<password>",
                },
            };
            ArmOperation<VMwareVCenterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, vcenterName, data);
            VMwareVCenterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VMwareVCenterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetVCenter()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/GetVCenter.json
            // this example is just showing the usage of "VCenters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VMwareVCenterResource
            VMwareVCenterCollection collection = resourceGroupResource.GetVMwareVCenters();

            // invoke the operation
            string vcenterName = "ContosoVCenter";
            VMwareVCenterResource result = await collection.GetAsync(vcenterName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VMwareVCenterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListVCentersByResourceGroup()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/ListVCentersByResourceGroup.json
            // this example is just showing the usage of "VCenters_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VMwareVCenterResource
            VMwareVCenterCollection collection = resourceGroupResource.GetVMwareVCenters();

            // invoke the operation and iterate over the result
            await foreach (VMwareVCenterResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VMwareVCenterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetVCenter()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/GetVCenter.json
            // this example is just showing the usage of "VCenters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VMwareVCenterResource
            VMwareVCenterCollection collection = resourceGroupResource.GetVMwareVCenters();

            // invoke the operation
            string vcenterName = "ContosoVCenter";
            bool result = await collection.ExistsAsync(vcenterName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetVCenter()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/stable/2023-12-01/examples/GetVCenter.json
            // this example is just showing the usage of "VCenters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VMwareVCenterResource
            VMwareVCenterCollection collection = resourceGroupResource.GetVMwareVCenters();

            // invoke the operation
            string vcenterName = "ContosoVCenter";
            NullableResponse<VMwareVCenterResource> response = await collection.GetIfExistsAsync(vcenterName);
            VMwareVCenterResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VMwareVCenterData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
