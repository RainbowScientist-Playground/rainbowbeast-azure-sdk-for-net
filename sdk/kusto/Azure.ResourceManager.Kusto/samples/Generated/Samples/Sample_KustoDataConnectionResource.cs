// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Kusto.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Kusto.Samples
{
    public partial class Sample_KustoDataConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_KustoDataConnectionsCosmosDbGet()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2024-04-13/examples/KustoDataConnectionsCosmosDbGet.json
            // this example is just showing the usage of "DataConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoDataConnectionResource created on azure
            // for more information of creating KustoDataConnectionResource, please refer to the document of KustoDataConnectionResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase1";
            string dataConnectionName = "dataConnectionTest";
            ResourceIdentifier kustoDataConnectionResourceId = KustoDataConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName, dataConnectionName);
            KustoDataConnectionResource kustoDataConnection = client.GetKustoDataConnectionResource(kustoDataConnectionResourceId);

            // invoke the operation
            KustoDataConnectionResource result = await kustoDataConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoDataConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_KustoDataConnectionsEventGridGet()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2024-04-13/examples/KustoDataConnectionsEventGridGet.json
            // this example is just showing the usage of "DataConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoDataConnectionResource created on azure
            // for more information of creating KustoDataConnectionResource, please refer to the document of KustoDataConnectionResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase8";
            string dataConnectionName = "dataConnectionTest";
            ResourceIdentifier kustoDataConnectionResourceId = KustoDataConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName, dataConnectionName);
            KustoDataConnectionResource kustoDataConnection = client.GetKustoDataConnectionResource(kustoDataConnectionResourceId);

            // invoke the operation
            KustoDataConnectionResource result = await kustoDataConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoDataConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_KustoDataConnectionsGet()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2024-04-13/examples/KustoDataConnectionsGet.json
            // this example is just showing the usage of "DataConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoDataConnectionResource created on azure
            // for more information of creating KustoDataConnectionResource, please refer to the document of KustoDataConnectionResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase8";
            string dataConnectionName = "dataConnectionTest";
            ResourceIdentifier kustoDataConnectionResourceId = KustoDataConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName, dataConnectionName);
            KustoDataConnectionResource kustoDataConnection = client.GetKustoDataConnectionResource(kustoDataConnectionResourceId);

            // invoke the operation
            KustoDataConnectionResource result = await kustoDataConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoDataConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_KustoDataConnectionsDelete()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2024-04-13/examples/KustoDataConnectionsDelete.json
            // this example is just showing the usage of "DataConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoDataConnectionResource created on azure
            // for more information of creating KustoDataConnectionResource, please refer to the document of KustoDataConnectionResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase8";
            string dataConnectionName = "dataConnectionTest";
            ResourceIdentifier kustoDataConnectionResourceId = KustoDataConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName, dataConnectionName);
            KustoDataConnectionResource kustoDataConnection = client.GetKustoDataConnectionResource(kustoDataConnectionResourceId);

            // invoke the operation
            await kustoDataConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_KustoDataConnectionsCosmosDbUpdate()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2024-04-13/examples/KustoDataConnectionsCosmosDbUpdate.json
            // this example is just showing the usage of "DataConnections_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoDataConnectionResource created on azure
            // for more information of creating KustoDataConnectionResource, please refer to the document of KustoDataConnectionResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase1";
            string dataConnectionName = "dataConnectionTest";
            ResourceIdentifier kustoDataConnectionResourceId = KustoDataConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName, dataConnectionName);
            KustoDataConnectionResource kustoDataConnection = client.GetKustoDataConnectionResource(kustoDataConnectionResourceId);

            // invoke the operation
            KustoDataConnectionData data = new KustoCosmosDBDataConnection
            {
                TableName = "TestTable",
                MappingRuleName = "TestMapping",
                ManagedIdentityResourceId = new ResourceIdentifier("/subscriptions/12345678-1234-1234-1234-123456789098/resourceGroups/kustorptest/providers/Microsoft.ManagedIdentity/userAssignedIdentities/managedidentityTest1"),
                CosmosDBAccountResourceId = new ResourceIdentifier("/subscriptions/12345678-1234-1234-1234-123456789098/resourceGroups/kustorptest/providers/Microsoft.DocumentDb/databaseAccounts/cosmosDbAccountTest1"),
                CosmosDBDatabase = "cosmosDbDatabaseTest",
                CosmosDBContainer = "cosmosDbContainerTest",
                RetrievalStartOn = DateTimeOffset.Parse("2022-07-29T12:00:00.6554616Z"),
                Location = new AzureLocation("westus"),
            };
            ArmOperation<KustoDataConnectionResource> lro = await kustoDataConnection.UpdateAsync(WaitUntil.Completed, data);
            KustoDataConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoDataConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_KustoDataConnectionsEventGridUpdate()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2024-04-13/examples/KustoDataConnectionsEventGridUpdate.json
            // this example is just showing the usage of "DataConnections_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoDataConnectionResource created on azure
            // for more information of creating KustoDataConnectionResource, please refer to the document of KustoDataConnectionResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase8";
            string dataConnectionName = "dataConnectionTest";
            ResourceIdentifier kustoDataConnectionResourceId = KustoDataConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName, dataConnectionName);
            KustoDataConnectionResource kustoDataConnection = client.GetKustoDataConnectionResource(kustoDataConnectionResourceId);

            // invoke the operation
            KustoDataConnectionData data = new KustoEventGridDataConnection
            {
                StorageAccountResourceId = new ResourceIdentifier("/subscriptions/12345678-1234-1234-1234-123456789098/resourceGroups/kustorptest/providers/Microsoft.Storage/storageAccounts/teststorageaccount"),
                EventGridResourceId = new ResourceIdentifier("/subscriptions/12345678-1234-1234-1234-123456789098/resourceGroups/kustorptest/providers/Microsoft.Storage/storageAccounts/teststorageaccount/providers/Microsoft.EventGrid/eventSubscriptions/eventSubscriptionTest"),
                EventHubResourceId = new ResourceIdentifier("/subscriptions/12345678-1234-1234-1234-123456789098/resourceGroups/kustorptest/providers/Microsoft.EventHub/namespaces/eventhubTestns1/eventhubs/eventhubTest2"),
                ConsumerGroup = "$Default",
                TableName = "TestTable",
                MappingRuleName = "TestMapping",
                DataFormat = KustoEventGridDataFormat.MultiJson,
                IsFirstRecordIgnored = false,
                BlobStorageEventType = BlobStorageEventType.MicrosoftStorageBlobCreated,
                ManagedIdentityResourceId = new ResourceIdentifier("/subscriptions/12345678-1234-1234-1234-123456789098/resourceGroups/kustorptest/providers/Microsoft.ManagedIdentity/userAssignedIdentities/managedidentityTest1"),
                DatabaseRouting = KustoDatabaseRouting.Single,
                Location = new AzureLocation("westus"),
            };
            ArmOperation<KustoDataConnectionResource> lro = await kustoDataConnection.UpdateAsync(WaitUntil.Completed, data);
            KustoDataConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoDataConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_KustoDataConnectionsUpdate()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2024-04-13/examples/KustoDataConnectionsUpdate.json
            // this example is just showing the usage of "DataConnections_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoDataConnectionResource created on azure
            // for more information of creating KustoDataConnectionResource, please refer to the document of KustoDataConnectionResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string databaseName = "KustoDatabase8";
            string dataConnectionName = "dataConnectionTest";
            ResourceIdentifier kustoDataConnectionResourceId = KustoDataConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, databaseName, dataConnectionName);
            KustoDataConnectionResource kustoDataConnection = client.GetKustoDataConnectionResource(kustoDataConnectionResourceId);

            // invoke the operation
            KustoDataConnectionData data = new KustoEventHubDataConnection
            {
                EventHubResourceId = new ResourceIdentifier("/subscriptions/12345678-1234-1234-1234-123456789098/resourceGroups/kustorptest/providers/Microsoft.EventHub/namespaces/eventhubTestns1/eventhubs/eventhubTest1"),
                ConsumerGroup = "testConsumerGroup1",
                ManagedIdentityResourceId = new ResourceIdentifier("/subscriptions/12345678-1234-1234-1234-123456789098/resourceGroups/kustorptest/providers/Microsoft.ManagedIdentity/userAssignedIdentities/managedidentityTest1"),
                Location = new AzureLocation("westus"),
            };
            ArmOperation<KustoDataConnectionResource> lro = await kustoDataConnection.UpdateAsync(WaitUntil.Completed, data);
            KustoDataConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoDataConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
