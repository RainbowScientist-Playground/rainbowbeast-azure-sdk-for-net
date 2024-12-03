// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.PolicyInsights.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.PolicyInsights.Samples
{
    public partial class Sample_PolicyMetadataCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetASinglePolicyMetadataResource()
        {
            // Generated from example definition: specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/examples/PolicyMetadata_GetResource.json
            // this example is just showing the usage of "PolicyMetadata_GetResource" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            TenantResource tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this PolicyMetadataResource
            PolicyMetadataCollection collection = tenantResource.GetAllPolicyMetadata();

            // invoke the operation
            string resourceName = "NIST_SP_800-53_R4_AC-2";
            PolicyMetadataResource result = await collection.GetAsync(resourceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyMetadataData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetCollectionOfPolicyMetadataResources()
        {
            // Generated from example definition: specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/examples/PolicyMetadata_List.json
            // this example is just showing the usage of "PolicyMetadata_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            TenantResource tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this PolicyMetadataResource
            PolicyMetadataCollection collection = tenantResource.GetAllPolicyMetadata();

            // invoke the operation and iterate over the result
            await foreach (SlimPolicyMetadata item in collection.GetAllAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetCollectionOfPolicyMetadataResourcesUsingTopQueryParameter()
        {
            // Generated from example definition: specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/examples/PolicyMetadata_List_WithTop.json
            // this example is just showing the usage of "PolicyMetadata_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            TenantResource tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this PolicyMetadataResource
            PolicyMetadataCollection collection = tenantResource.GetAllPolicyMetadata();

            // invoke the operation and iterate over the result
            await foreach (SlimPolicyMetadata item in collection.GetAllAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetASinglePolicyMetadataResource()
        {
            // Generated from example definition: specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/examples/PolicyMetadata_GetResource.json
            // this example is just showing the usage of "PolicyMetadata_GetResource" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            TenantResource tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this PolicyMetadataResource
            PolicyMetadataCollection collection = tenantResource.GetAllPolicyMetadata();

            // invoke the operation
            string resourceName = "NIST_SP_800-53_R4_AC-2";
            bool result = await collection.ExistsAsync(resourceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetASinglePolicyMetadataResource()
        {
            // Generated from example definition: specification/policyinsights/resource-manager/Microsoft.PolicyInsights/stable/2019-10-01/examples/PolicyMetadata_GetResource.json
            // this example is just showing the usage of "PolicyMetadata_GetResource" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            TenantResource tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this PolicyMetadataResource
            PolicyMetadataCollection collection = tenantResource.GetAllPolicyMetadata();

            // invoke the operation
            string resourceName = "NIST_SP_800-53_R4_AC-2";
            NullableResponse<PolicyMetadataResource> response = await collection.GetIfExistsAsync(resourceName);
            PolicyMetadataResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PolicyMetadataData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
