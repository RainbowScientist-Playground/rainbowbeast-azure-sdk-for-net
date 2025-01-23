// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Media.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Media.Samples
{
    public partial class Sample_StreamingLocatorResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAStreamingLocatorByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-locators-get-by-name.json
            // this example is just showing the usage of "StreamingLocators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingLocatorResource created on azure
            // for more information of creating StreamingLocatorResource, please refer to the document of StreamingLocatorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingLocatorName = "clearStreamingLocator";
            ResourceIdentifier streamingLocatorResourceId = StreamingLocatorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingLocatorName);
            StreamingLocatorResource streamingLocator = client.GetStreamingLocatorResource(streamingLocatorResourceId);

            // invoke the operation
            StreamingLocatorResource result = await streamingLocator.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingLocatorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAStreamingLocator()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-locators-delete.json
            // this example is just showing the usage of "StreamingLocators_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingLocatorResource created on azure
            // for more information of creating StreamingLocatorResource, please refer to the document of StreamingLocatorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingLocatorName = "clearStreamingLocator";
            ResourceIdentifier streamingLocatorResourceId = StreamingLocatorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingLocatorName);
            StreamingLocatorResource streamingLocator = client.GetStreamingLocatorResource(streamingLocatorResourceId);

            // invoke the operation
            await streamingLocator.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatesAStreamingLocatorWithClearStreaming()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-locators-create-clear.json
            // this example is just showing the usage of "StreamingLocators_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingLocatorResource created on azure
            // for more information of creating StreamingLocatorResource, please refer to the document of StreamingLocatorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingLocatorName = "UserCreatedClearStreamingLocator";
            ResourceIdentifier streamingLocatorResourceId = StreamingLocatorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingLocatorName);
            StreamingLocatorResource streamingLocator = client.GetStreamingLocatorResource(streamingLocatorResourceId);

            // invoke the operation
            StreamingLocatorData data = new StreamingLocatorData
            {
                AssetName = "ClimbingMountRainier",
                StreamingPolicyName = "clearStreamingPolicy",
            };
            ArmOperation<StreamingLocatorResource> lro = await streamingLocator.UpdateAsync(WaitUntil.Completed, data);
            StreamingLocatorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingLocatorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatesAStreamingLocatorWithSecureStreaming()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-locators-create-secure.json
            // this example is just showing the usage of "StreamingLocators_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingLocatorResource created on azure
            // for more information of creating StreamingLocatorResource, please refer to the document of StreamingLocatorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingLocatorName = "UserCreatedSecureStreamingLocator";
            ResourceIdentifier streamingLocatorResourceId = StreamingLocatorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingLocatorName);
            StreamingLocatorResource streamingLocator = client.GetStreamingLocatorResource(streamingLocatorResourceId);

            // invoke the operation
            StreamingLocatorData data = new StreamingLocatorData
            {
                AssetName = "ClimbingMountRainier",
                StartOn = DateTimeOffset.Parse("2018-03-01T00:00:00Z"),
                EndOn = DateTimeOffset.Parse("2028-12-31T23:59:59.9999999Z"),
                StreamingPolicyName = "UserCreatedSecureStreamingPolicy",
            };
            ArmOperation<StreamingLocatorResource> lro = await streamingLocator.UpdateAsync(WaitUntil.Completed, data);
            StreamingLocatorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingLocatorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatesAStreamingLocatorWithUserDefinedContentKeys()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-locators-create-secure-userDefinedContentKeys.json
            // this example is just showing the usage of "StreamingLocators_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingLocatorResource created on azure
            // for more information of creating StreamingLocatorResource, please refer to the document of StreamingLocatorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingLocatorName = "UserCreatedSecureStreamingLocatorWithUserDefinedContentKeys";
            ResourceIdentifier streamingLocatorResourceId = StreamingLocatorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingLocatorName);
            StreamingLocatorResource streamingLocator = client.GetStreamingLocatorResource(streamingLocatorResourceId);

            // invoke the operation
            StreamingLocatorData data = new StreamingLocatorData
            {
                AssetName = "ClimbingMountRainier",
                StreamingLocatorId = Guid.Parse("90000000-0000-0000-0000-00000000000A"),
                StreamingPolicyName = "secureStreamingPolicy",
                ContentKeys = {new StreamingLocatorContentKey(Guid.Parse("60000000-0000-0000-0000-000000000001"))
{
LabelReferenceInStreamingPolicy = "aesDefaultKey",
Value = "1UqLohAfWsEGkULYxHjYZg==",
}, new StreamingLocatorContentKey(Guid.Parse("60000000-0000-0000-0000-000000000004"))
{
LabelReferenceInStreamingPolicy = "cencDefaultKey",
Value = "4UqLohAfWsEGkULYxHjYZg==",
}, new StreamingLocatorContentKey(Guid.Parse("60000000-0000-0000-0000-000000000007"))
{
LabelReferenceInStreamingPolicy = "cbcsDefaultKey",
Value = "7UqLohAfWsEGkULYxHjYZg==",
}},
            };
            ArmOperation<StreamingLocatorResource> lro = await streamingLocator.UpdateAsync(WaitUntil.Completed, data);
            StreamingLocatorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingLocatorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetContentKeys_ListContentKeys()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-locators-list-content-keys.json
            // this example is just showing the usage of "StreamingLocators_ListContentKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingLocatorResource created on azure
            // for more information of creating StreamingLocatorResource, please refer to the document of StreamingLocatorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingLocatorName = "secureStreamingLocator";
            ResourceIdentifier streamingLocatorResourceId = StreamingLocatorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingLocatorName);
            StreamingLocatorResource streamingLocator = client.GetStreamingLocatorResource(streamingLocatorResourceId);

            // invoke the operation and iterate over the result
            await foreach (StreamingLocatorContentKey item in streamingLocator.GetContentKeysAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetStreamingPaths_ListPathsWhichHasStreamingPathsAndDownloadPaths()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-locators-list-paths-streaming-and-download.json
            // this example is just showing the usage of "StreamingLocators_ListPaths" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingLocatorResource created on azure
            // for more information of creating StreamingLocatorResource, please refer to the document of StreamingLocatorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingLocatorName = "clearStreamingLocator";
            ResourceIdentifier streamingLocatorResourceId = StreamingLocatorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingLocatorName);
            StreamingLocatorResource streamingLocator = client.GetStreamingLocatorResource(streamingLocatorResourceId);

            // invoke the operation
            StreamingPathsResult result = await streamingLocator.GetStreamingPathsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetStreamingPaths_ListPathsWhichHasStreamingPathsOnly()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-locators-list-paths-streaming-only.json
            // this example is just showing the usage of "StreamingLocators_ListPaths" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingLocatorResource created on azure
            // for more information of creating StreamingLocatorResource, please refer to the document of StreamingLocatorResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingLocatorName = "secureStreamingLocator";
            ResourceIdentifier streamingLocatorResourceId = StreamingLocatorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingLocatorName);
            StreamingLocatorResource streamingLocator = client.GetStreamingLocatorResource(streamingLocatorResourceId);

            // invoke the operation
            StreamingPathsResult result = await streamingLocator.GetStreamingPathsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
