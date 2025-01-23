// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Monitor.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Monitor.Samples
{
    public partial class Sample_ActivityLogAlertResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnActivityLogAlertRule()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2020-10-01/examples/ActivityLogAlertRule_Get.json
            // this example is just showing the usage of "ActivityLogAlerts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ActivityLogAlertResource created on azure
            // for more information of creating ActivityLogAlertResource, please refer to the document of ActivityLogAlertResource
            string subscriptionId = "187f412d-1758-44d9-b052-169e2564721d";
            string resourceGroupName = "MyResourceGroup";
            string activityLogAlertName = "SampleActivityLogAlertRule";
            ResourceIdentifier activityLogAlertResourceId = ActivityLogAlertResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, activityLogAlertName);
            ActivityLogAlertResource activityLogAlert = client.GetActivityLogAlertResource(activityLogAlertResourceId);

            // invoke the operation
            ActivityLogAlertResource result = await activityLogAlert.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ActivityLogAlertData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAnActivityLogAlertRule()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2020-10-01/examples/ActivityLogAlertRule_Delete.json
            // this example is just showing the usage of "ActivityLogAlerts_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ActivityLogAlertResource created on azure
            // for more information of creating ActivityLogAlertResource, please refer to the document of ActivityLogAlertResource
            string subscriptionId = "187f412d-1758-44d9-b052-169e2564721d";
            string resourceGroupName = "MyResourceGroup";
            string activityLogAlertName = "SampleActivityLogAlertRule";
            ResourceIdentifier activityLogAlertResourceId = ActivityLogAlertResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, activityLogAlertName);
            ActivityLogAlertResource activityLogAlert = client.GetActivityLogAlertResource(activityLogAlertResourceId);

            // invoke the operation
            await activityLogAlert.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchAnActivityLogAlertRule()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2020-10-01/examples/ActivityLogAlertRule_Update.json
            // this example is just showing the usage of "ActivityLogAlerts_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ActivityLogAlertResource created on azure
            // for more information of creating ActivityLogAlertResource, please refer to the document of ActivityLogAlertResource
            string subscriptionId = "187f412d-1758-44d9-b052-169e2564721d";
            string resourceGroupName = "MyResourceGroup";
            string activityLogAlertName = "SampleActivityLogAlertRule";
            ResourceIdentifier activityLogAlertResourceId = ActivityLogAlertResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, activityLogAlertName);
            ActivityLogAlertResource activityLogAlert = client.GetActivityLogAlertResource(activityLogAlertResourceId);

            // invoke the operation
            ActivityLogAlertPatch patch = new ActivityLogAlertPatch
            {
                Tags =
{
["key1"] = "value1",
["key2"] = "value2"
},
                IsEnabled = false,
            };
            ActivityLogAlertResource result = await activityLogAlert.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ActivityLogAlertData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
