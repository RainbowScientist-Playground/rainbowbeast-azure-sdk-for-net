// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiPolicyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetApiPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetApiPolicy.json
            // this example is just showing the usage of "ApiPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiPolicyResource created on azure
            // for more information of creating ApiPolicyResource, please refer to the document of ApiPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b59475ff190048040001";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier apiPolicyResourceId = ApiPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, policyId);
            ApiPolicyResource apiPolicy = client.GetApiPolicyResource(apiPolicyResourceId);

            // invoke the operation
            ApiPolicyResource result = await apiPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteApiPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementDeleteApiPolicy.json
            // this example is just showing the usage of "ApiPolicy_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiPolicyResource created on azure
            // for more information of creating ApiPolicyResource, please refer to the document of ApiPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "loggerId";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier apiPolicyResourceId = ApiPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, policyId);
            ApiPolicyResource apiPolicy = client.GetApiPolicyResource(apiPolicyResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiPolicy.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementCreateApiPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateApiPolicy.json
            // this example is just showing the usage of "ApiPolicy_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiPolicyResource created on azure
            // for more information of creating ApiPolicyResource, please refer to the document of ApiPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b57e7e8880006a040001";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier apiPolicyResourceId = ApiPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, policyId);
            ApiPolicyResource apiPolicy = client.GetApiPolicyResource(apiPolicyResourceId);

            // invoke the operation
            PolicyContractData data = new PolicyContractData
            {
                Value = "<policies> <inbound /> <backend>    <forward-request />  </backend>  <outbound /></policies>",
                Format = PolicyContentFormat.Xml,
            };
            ETag? ifMatch = new ETag("*");
            ArmOperation<ApiPolicyResource> lro = await apiPolicy.UpdateAsync(WaitUntil.Completed, data, ifMatch: ifMatch);
            ApiPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementCreateApiPolicyNonXmlEncoded()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateApiPolicyNonXmlEncoded.json
            // this example is just showing the usage of "ApiPolicy_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiPolicyResource created on azure
            // for more information of creating ApiPolicyResource, please refer to the document of ApiPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b57e7e8880006a040001";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier apiPolicyResourceId = ApiPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, policyId);
            ApiPolicyResource apiPolicy = client.GetApiPolicyResource(apiPolicyResourceId);

            // invoke the operation
            PolicyContractData data = new PolicyContractData
            {
                Value = "<policies>\r\n     <inbound>\r\n     <base />\r\n  <set-header name=\"newvalue\" exists-action=\"override\">\r\n   <value>\"@(context.Request.Headers.FirstOrDefault(h => h.Ke==\"Via\"))\" </value>\r\n    </set-header>\r\n  </inbound>\r\n      </policies>",
                Format = PolicyContentFormat.RawXml,
            };
            ETag? ifMatch = new ETag("*");
            ArmOperation<ApiPolicyResource> lro = await apiPolicy.UpdateAsync(WaitUntil.Completed, data, ifMatch: ifMatch);
            ApiPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadApiPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementHeadApiPolicy.json
            // this example is just showing the usage of "ApiPolicy_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiPolicyResource created on azure
            // for more information of creating ApiPolicyResource, please refer to the document of ApiPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d1f7558aa04f15146d9d8a";
            PolicyName policyId = PolicyName.Policy;
            ResourceIdentifier apiPolicyResourceId = ApiPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, policyId);
            ApiPolicyResource apiPolicy = client.GetApiPolicyResource(apiPolicyResourceId);

            // invoke the operation
            bool result = await apiPolicy.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
