// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.OperationalInsights.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.OperationalInsights.Samples
{
    public partial class Sample_OperationalInsightsDataSourceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_DataSourcesCreate()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/DataSourcesCreate.json
            // this example is just showing the usage of "DataSources_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "OIAutoRest5123";
            string workspaceName = "AzTest9724";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsDataSourceResource
            OperationalInsightsDataSourceCollection collection = operationalInsightsWorkspace.GetOperationalInsightsDataSources();

            // invoke the operation
            string dataSourceName = "AzTestDS774";
            OperationalInsightsDataSourceData data = new OperationalInsightsDataSourceData(BinaryData.FromObjectAsJson(new
            {
                LinkedResourceId = "/subscriptions/00000000-0000-0000-0000-00000000000/providers/microsoft.insights/eventtypes/management",
            }), OperationalInsightsDataSourceKind.AzureActivityLog);
            ArmOperation<OperationalInsightsDataSourceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataSourceName, data);
            OperationalInsightsDataSourceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsDataSourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_DataSourcesGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/DataSourcesGet.json
            // this example is just showing the usage of "DataSources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "OIAutoRest5123";
            string workspaceName = "AzTest9724";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsDataSourceResource
            OperationalInsightsDataSourceCollection collection = operationalInsightsWorkspace.GetOperationalInsightsDataSources();

            // invoke the operation
            string dataSourceName = "AzTestDS774";
            OperationalInsightsDataSourceResource result = await collection.GetAsync(dataSourceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsDataSourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_DataSourcesListByWorkspace()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/DataSourcesListByWorkspace.json
            // this example is just showing the usage of "DataSources_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "OIAutoRest5123";
            string workspaceName = "AzTest9724";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsDataSourceResource
            OperationalInsightsDataSourceCollection collection = operationalInsightsWorkspace.GetOperationalInsightsDataSources();

            // invoke the operation and iterate over the result
            string filter = "kind='WindowsEvent'";
            await foreach (OperationalInsightsDataSourceResource item in collection.GetAllAsync(filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OperationalInsightsDataSourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_DataSourcesGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/DataSourcesGet.json
            // this example is just showing the usage of "DataSources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "OIAutoRest5123";
            string workspaceName = "AzTest9724";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsDataSourceResource
            OperationalInsightsDataSourceCollection collection = operationalInsightsWorkspace.GetOperationalInsightsDataSources();

            // invoke the operation
            string dataSourceName = "AzTestDS774";
            bool result = await collection.ExistsAsync(dataSourceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_DataSourcesGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2020-08-01/examples/DataSourcesGet.json
            // this example is just showing the usage of "DataSources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this OperationalInsightsWorkspaceResource created on azure
            // for more information of creating OperationalInsightsWorkspaceResource, please refer to the document of OperationalInsightsWorkspaceResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "OIAutoRest5123";
            string workspaceName = "AzTest9724";
            ResourceIdentifier operationalInsightsWorkspaceResourceId = OperationalInsightsWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            OperationalInsightsWorkspaceResource operationalInsightsWorkspace = client.GetOperationalInsightsWorkspaceResource(operationalInsightsWorkspaceResourceId);

            // get the collection of this OperationalInsightsDataSourceResource
            OperationalInsightsDataSourceCollection collection = operationalInsightsWorkspace.GetOperationalInsightsDataSources();

            // invoke the operation
            string dataSourceName = "AzTestDS774";
            NullableResponse<OperationalInsightsDataSourceResource> response = await collection.GetIfExistsAsync(dataSourceName);
            OperationalInsightsDataSourceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OperationalInsightsDataSourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
