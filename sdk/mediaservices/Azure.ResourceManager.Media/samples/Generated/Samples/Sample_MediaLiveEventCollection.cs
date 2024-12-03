// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Media.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Media.Samples
{
    public partial class Sample_MediaLiveEventCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateALiveEvent()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Streaming/stable/2022-08-01/examples/liveevent-create.json
            // this example is just showing the usage of "LiveEvents_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "0a6ec948-5a62-437d-b9df-934dc7c1b722";
            string resourceGroupName = "mediaresources";
            string accountName = "slitestmedia10";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaLiveEventResource
            MediaLiveEventCollection collection = mediaServicesAccount.GetMediaLiveEvents();

            // invoke the operation
            string liveEventName = "myLiveEvent1";
            MediaLiveEventData data = new MediaLiveEventData(new AzureLocation("West US"))
            {
                Description = "test event 1",
                Input = new LiveEventInput(LiveEventInputProtocol.Rtmp)
                {
                    IPAllowedIPs = {new IPRange
{
Name = "AllowAll",
Address = IPAddress.Parse("0.0.0.0"),
SubnetPrefixLength = 0,
}},
                    KeyFrameIntervalDuration = XmlConvert.ToTimeSpan("PT6S"),
                },
                Preview = new LiveEventPreview
                {
                    IPAllowedIPs = {new IPRange
{
Name = "AllowAll",
Address = IPAddress.Parse("0.0.0.0"),
SubnetPrefixLength = 0,
}},
                },
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            ArmOperation<MediaLiveEventResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, liveEventName, data);
            MediaLiveEventResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaLiveEventData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetALiveEventByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Streaming/stable/2022-08-01/examples/liveevent-list-by-name.json
            // this example is just showing the usage of "LiveEvents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "0a6ec948-5a62-437d-b9df-934dc7c1b722";
            string resourceGroupName = "mediaresources";
            string accountName = "slitestmedia10";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaLiveEventResource
            MediaLiveEventCollection collection = mediaServicesAccount.GetMediaLiveEvents();

            // invoke the operation
            string liveEventName = "myLiveEvent1";
            MediaLiveEventResource result = await collection.GetAsync(liveEventName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaLiveEventData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAllLiveEvents()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Streaming/stable/2022-08-01/examples/liveevent-list-all.json
            // this example is just showing the usage of "LiveEvents_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "0a6ec948-5a62-437d-b9df-934dc7c1b722";
            string resourceGroupName = "mediaresources";
            string accountName = "slitestmedia10";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaLiveEventResource
            MediaLiveEventCollection collection = mediaServicesAccount.GetMediaLiveEvents();

            // invoke the operation and iterate over the result
            await foreach (MediaLiveEventResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaLiveEventData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetALiveEventByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Streaming/stable/2022-08-01/examples/liveevent-list-by-name.json
            // this example is just showing the usage of "LiveEvents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "0a6ec948-5a62-437d-b9df-934dc7c1b722";
            string resourceGroupName = "mediaresources";
            string accountName = "slitestmedia10";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaLiveEventResource
            MediaLiveEventCollection collection = mediaServicesAccount.GetMediaLiveEvents();

            // invoke the operation
            string liveEventName = "myLiveEvent1";
            bool result = await collection.ExistsAsync(liveEventName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetALiveEventByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Streaming/stable/2022-08-01/examples/liveevent-list-by-name.json
            // this example is just showing the usage of "LiveEvents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "0a6ec948-5a62-437d-b9df-934dc7c1b722";
            string resourceGroupName = "mediaresources";
            string accountName = "slitestmedia10";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaLiveEventResource
            MediaLiveEventCollection collection = mediaServicesAccount.GetMediaLiveEvents();

            // invoke the operation
            string liveEventName = "myLiveEvent1";
            NullableResponse<MediaLiveEventResource> response = await collection.GetIfExistsAsync(liveEventName);
            MediaLiveEventResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaLiveEventData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
