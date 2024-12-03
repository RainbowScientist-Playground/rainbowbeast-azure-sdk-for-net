// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataMigration.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DataMigration.Samples
{
    public partial class Sample_ServiceServiceTaskResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_TasksGet()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/ServiceTasks_Get.json
            // this example is just showing the usage of "ServiceTasks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceServiceTaskResource created on azure
            // for more information of creating ServiceServiceTaskResource, please refer to the document of ServiceServiceTaskResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            string taskName = "DmsSdkTask";
            ResourceIdentifier serviceServiceTaskResourceId = ServiceServiceTaskResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName, taskName);
            ServiceServiceTaskResource serviceServiceTask = client.GetServiceServiceTaskResource(serviceServiceTaskResourceId);

            // invoke the operation
            ServiceServiceTaskResource result = await serviceServiceTask.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProjectTaskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_TasksDelete()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/ServiceTasks_Delete.json
            // this example is just showing the usage of "ServiceTasks_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceServiceTaskResource created on azure
            // for more information of creating ServiceServiceTaskResource, please refer to the document of ServiceServiceTaskResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            string taskName = "DmsSdkTask";
            ResourceIdentifier serviceServiceTaskResourceId = ServiceServiceTaskResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName, taskName);
            ServiceServiceTaskResource serviceServiceTask = client.GetServiceServiceTaskResource(serviceServiceTaskResourceId);

            // invoke the operation
            await serviceServiceTask.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_TasksUpdate()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/ServiceTasks_Update.json
            // this example is just showing the usage of "ServiceTasks_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceServiceTaskResource created on azure
            // for more information of creating ServiceServiceTaskResource, please refer to the document of ServiceServiceTaskResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            string taskName = "DmsSdkTask";
            ResourceIdentifier serviceServiceTaskResourceId = ServiceServiceTaskResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName, taskName);
            ServiceServiceTaskResource serviceServiceTask = client.GetServiceServiceTaskResource(serviceServiceTaskResourceId);

            // invoke the operation
            ProjectTaskData data = new ProjectTaskData
            {
                Properties = new CheckOciDriverTaskProperties
                {
                    InputServerVersion = "NA",
                },
            };
            ServiceServiceTaskResource result = await serviceServiceTask.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProjectTaskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Cancel_TasksCancel()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/ServiceTasks_Cancel.json
            // this example is just showing the usage of "ServiceTasks_Cancel" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceServiceTaskResource created on azure
            // for more information of creating ServiceServiceTaskResource, please refer to the document of ServiceServiceTaskResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            string taskName = "DmsSdkTask";
            ResourceIdentifier serviceServiceTaskResourceId = ServiceServiceTaskResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName, taskName);
            ServiceServiceTaskResource serviceServiceTask = client.GetServiceServiceTaskResource(serviceServiceTaskResourceId);

            // invoke the operation
            ServiceServiceTaskResource result = await serviceServiceTask.CancelAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProjectTaskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
