// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Hci.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Hci.Samples
{
    public partial class Sample_HciClusterSecuritySettingResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetSecuritySettings()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/StackHCI/stable/2024-04-01/examples/GetSecuritySettings.json
            // this example is just showing the usage of "SecuritySettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HciClusterSecuritySettingResource created on azure
            // for more information of creating HciClusterSecuritySettingResource, please refer to the document of HciClusterSecuritySettingResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "test-rg";
            string clusterName = "myCluster";
            string securitySettingsName = "default";
            ResourceIdentifier hciClusterSecuritySettingResourceId = HciClusterSecuritySettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, securitySettingsName);
            HciClusterSecuritySettingResource hciClusterSecuritySetting = client.GetHciClusterSecuritySettingResource(hciClusterSecuritySettingResourceId);

            // invoke the operation
            HciClusterSecuritySettingResource result = await hciClusterSecuritySetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HciClusterSecuritySettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteSecuritySettings()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/StackHCI/stable/2024-04-01/examples/DeleteSecuritySettings.json
            // this example is just showing the usage of "SecuritySettings_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HciClusterSecuritySettingResource created on azure
            // for more information of creating HciClusterSecuritySettingResource, please refer to the document of HciClusterSecuritySettingResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "test-rg";
            string clusterName = "myCluster";
            string securitySettingsName = "default";
            ResourceIdentifier hciClusterSecuritySettingResourceId = HciClusterSecuritySettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, securitySettingsName);
            HciClusterSecuritySettingResource hciClusterSecuritySetting = client.GetHciClusterSecuritySettingResource(hciClusterSecuritySettingResourceId);

            // invoke the operation
            await hciClusterSecuritySetting.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateSecuritySettings()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/StackHCI/stable/2024-04-01/examples/PutSecuritySettings.json
            // this example is just showing the usage of "SecuritySettings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HciClusterSecuritySettingResource created on azure
            // for more information of creating HciClusterSecuritySettingResource, please refer to the document of HciClusterSecuritySettingResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "test-rg";
            string clusterName = "myCluster";
            string securitySettingsName = "default";
            ResourceIdentifier hciClusterSecuritySettingResourceId = HciClusterSecuritySettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, securitySettingsName);
            HciClusterSecuritySettingResource hciClusterSecuritySetting = client.GetHciClusterSecuritySettingResource(hciClusterSecuritySettingResourceId);

            // invoke the operation
            HciClusterSecuritySettingData data = new HciClusterSecuritySettingData
            {
                SecuredCoreComplianceAssignment = HciClusterComplianceAssignmentType.Audit,
                WdacComplianceAssignment = HciClusterComplianceAssignmentType.ApplyAndAutoCorrect,
                SmbEncryptionForIntraClusterTrafficComplianceAssignment = HciClusterComplianceAssignmentType.Audit,
            };
            ArmOperation<HciClusterSecuritySettingResource> lro = await hciClusterSecuritySetting.UpdateAsync(WaitUntil.Completed, data);
            HciClusterSecuritySettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HciClusterSecuritySettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
