// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DevTestLabs.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DevTestLabs.Samples
{
    public partial class Sample_DevTestLabCustomImageResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CustomImagesGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/CustomImages_Get.json
            // this example is just showing the usage of "CustomImages_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabCustomImageResource created on azure
            // for more information of creating DevTestLabCustomImageResource, please refer to the document of DevTestLabCustomImageResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string name = "{customImageName}";
            ResourceIdentifier devTestLabCustomImageResourceId = DevTestLabCustomImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, name);
            DevTestLabCustomImageResource devTestLabCustomImage = client.GetDevTestLabCustomImageResource(devTestLabCustomImageResourceId);

            // invoke the operation
            DevTestLabCustomImageResource result = await devTestLabCustomImage.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabCustomImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_CustomImagesDelete()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/CustomImages_Delete.json
            // this example is just showing the usage of "CustomImages_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabCustomImageResource created on azure
            // for more information of creating DevTestLabCustomImageResource, please refer to the document of DevTestLabCustomImageResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string name = "{customImageName}";
            ResourceIdentifier devTestLabCustomImageResourceId = DevTestLabCustomImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, name);
            DevTestLabCustomImageResource devTestLabCustomImage = client.GetDevTestLabCustomImageResource(devTestLabCustomImageResourceId);

            // invoke the operation
            await devTestLabCustomImage.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CustomImagesUpdate()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/CustomImages_Update.json
            // this example is just showing the usage of "CustomImages_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabCustomImageResource created on azure
            // for more information of creating DevTestLabCustomImageResource, please refer to the document of DevTestLabCustomImageResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string name = "{customImageName}";
            ResourceIdentifier devTestLabCustomImageResourceId = DevTestLabCustomImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, name);
            DevTestLabCustomImageResource devTestLabCustomImage = client.GetDevTestLabCustomImageResource(devTestLabCustomImageResourceId);

            // invoke the operation
            DevTestLabCustomImagePatch patch = new DevTestLabCustomImagePatch
            {
                Tags =
{
["tagName1"] = "tagValue2"
},
            };
            DevTestLabCustomImageResource result = await devTestLabCustomImage.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabCustomImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
