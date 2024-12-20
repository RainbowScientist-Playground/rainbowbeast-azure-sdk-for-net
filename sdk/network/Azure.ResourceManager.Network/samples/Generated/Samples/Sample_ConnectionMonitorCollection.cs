// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ConnectionMonitorCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateConnectionMonitorV1()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkWatcherConnectionMonitorCreate.json
            // this example is just showing the usage of "ConnectionMonitors_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // get the collection of this ConnectionMonitorResource
            ConnectionMonitorCollection collection = networkWatcher.GetConnectionMonitors();

            // invoke the operation
            string connectionMonitorName = "cm1";
            ConnectionMonitorCreateOrUpdateContent content = new ConnectionMonitorCreateOrUpdateContent
            {
                Location = new AzureLocation("eastus"),
                Endpoints = {new ConnectionMonitorEndpoint("source")
{
ResourceId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Compute/virtualMachines/ct1"),
}, new ConnectionMonitorEndpoint("destination")
{
Address = "bing.com",
}},
                TestConfigurations = {new ConnectionMonitorTestConfiguration("tcp", ConnectionMonitorTestConfigurationProtocol.Tcp)
{
TestFrequencySec = 60,
TcpConfiguration = new ConnectionMonitorTcpConfiguration
{
Port = 80,
},
}},
                TestGroups = { new ConnectionMonitorTestGroup("tg", new string[] { "tcp" }, new string[] { "source" }, new string[] { "destination" }) },
            };
            ArmOperation<ConnectionMonitorResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, connectionMonitorName, content);
            ConnectionMonitorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectionMonitorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateConnectionMonitorV2()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkWatcherConnectionMonitorV2Create.json
            // this example is just showing the usage of "ConnectionMonitors_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // get the collection of this ConnectionMonitorResource
            ConnectionMonitorCollection collection = networkWatcher.GetConnectionMonitors();

            // invoke the operation
            string connectionMonitorName = "cm1";
            ConnectionMonitorCreateOrUpdateContent content = new ConnectionMonitorCreateOrUpdateContent
            {
                Endpoints = {new ConnectionMonitorEndpoint("vm1")
{
ResourceId = new ResourceIdentifier("/subscriptions/96e68903-0a56-4819-9987-8d08ad6a1f99/resourceGroups/NwRgIrinaCentralUSEUAP/providers/Microsoft.Compute/virtualMachines/vm1"),
}, new ConnectionMonitorEndpoint("CanaryWorkspaceVamshi")
{
ResourceId = new ResourceIdentifier("/subscriptions/96e68903-0a56-4819-9987-8d08ad6a1f99/resourceGroups/vasamudrRG/providers/Microsoft.OperationalInsights/workspaces/vasamudrWorkspace"),
Filter = new ConnectionMonitorEndpointFilter
{
FilterType = ConnectionMonitorEndpointFilterType.Include,
Items = {new ConnectionMonitorEndpointFilterItem
{
ItemType = ConnectionMonitorEndpointFilterItemType.AgentAddress,
Address = "npmuser",
}},
},
}, new ConnectionMonitorEndpoint("bing")
{
Address = "bing.com",
}, new ConnectionMonitorEndpoint("google")
{
Address = "google.com",
}},
                TestConfigurations = {new ConnectionMonitorTestConfiguration("testConfig1", ConnectionMonitorTestConfigurationProtocol.Tcp)
{
TestFrequencySec = 60,
TcpConfiguration = new ConnectionMonitorTcpConfiguration
{
Port = 80,
DisableTraceRoute = false,
},
}},
                TestGroups = {new ConnectionMonitorTestGroup("test1", new string[]{"testConfig1"}, new string[]{"vm1", "CanaryWorkspaceVamshi"}, new string[]{"bing", "google"})
{
Disable = false,
}},
                Outputs = { },
            };
            ArmOperation<ConnectionMonitorResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, connectionMonitorName, content);
            ConnectionMonitorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectionMonitorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateConnectionMonitorWithArcNetwork()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkWatcherConnectionMonitorCreateWithArcNetwork.json
            // this example is just showing the usage of "ConnectionMonitors_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // get the collection of this ConnectionMonitorResource
            ConnectionMonitorCollection collection = networkWatcher.GetConnectionMonitors();

            // invoke the operation
            string connectionMonitorName = "cm1";
            ConnectionMonitorCreateOrUpdateContent content = new ConnectionMonitorCreateOrUpdateContent
            {
                Endpoints = {new ConnectionMonitorEndpoint("vm1")
{
EndpointType = ConnectionMonitorEndpointType.AzureVm,
ResourceId = new ResourceIdentifier("/subscriptions/9cece3e3-0f7d-47ca-af0e-9772773f90b7/resourceGroups/testRG/providers/Microsoft.Compute/virtualMachines/TESTVM"),
}, new ConnectionMonitorEndpoint("bing")
{
EndpointType = ConnectionMonitorEndpointType.ExternalAddress,
Address = "bing.com",
}, new ConnectionMonitorEndpoint("google")
{
EndpointType = ConnectionMonitorEndpointType.ExternalAddress,
Address = "google.com",
}, new ConnectionMonitorEndpoint("ArcBasedNetwork")
{
EndpointType = ConnectionMonitorEndpointType.AzureArcNetwork,
Scope = new ConnectionMonitorEndpointScope
{
Include = {new ConnectionMonitorEndpointScopeItem
{
Address = "172.21.128.0/20",
}},
},
LocationDetailsRegion = "eastus",
SubscriptionId = Guid.Parse("9cece3e3-0f7d-47ca-af0e-9772773f90b7"),
}},
                TestConfigurations = {new ConnectionMonitorTestConfiguration("testConfig1", ConnectionMonitorTestConfigurationProtocol.Tcp)
{
TestFrequencySec = 60,
TcpConfiguration = new ConnectionMonitorTcpConfiguration
{
Port = 80,
DisableTraceRoute = false,
},
}},
                TestGroups = {new ConnectionMonitorTestGroup("test1", new string[]{"testConfig1"}, new string[]{"vm1", "ArcBasedNetwork"}, new string[]{"bing", "google"})
{
Disable = false,
}},
                Outputs = { },
            };
            ArmOperation<ConnectionMonitorResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, connectionMonitorName, content);
            ConnectionMonitorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectionMonitorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetConnectionMonitor()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkWatcherConnectionMonitorGet.json
            // this example is just showing the usage of "ConnectionMonitors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // get the collection of this ConnectionMonitorResource
            ConnectionMonitorCollection collection = networkWatcher.GetConnectionMonitors();

            // invoke the operation
            string connectionMonitorName = "cm1";
            ConnectionMonitorResource result = await collection.GetAsync(connectionMonitorName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectionMonitorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListConnectionMonitors()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkWatcherConnectionMonitorList.json
            // this example is just showing the usage of "ConnectionMonitors_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // get the collection of this ConnectionMonitorResource
            ConnectionMonitorCollection collection = networkWatcher.GetConnectionMonitors();

            // invoke the operation and iterate over the result
            await foreach (ConnectionMonitorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConnectionMonitorData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetConnectionMonitor()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkWatcherConnectionMonitorGet.json
            // this example is just showing the usage of "ConnectionMonitors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // get the collection of this ConnectionMonitorResource
            ConnectionMonitorCollection collection = networkWatcher.GetConnectionMonitors();

            // invoke the operation
            string connectionMonitorName = "cm1";
            bool result = await collection.ExistsAsync(connectionMonitorName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetConnectionMonitor()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkWatcherConnectionMonitorGet.json
            // this example is just showing the usage of "ConnectionMonitors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // get the collection of this ConnectionMonitorResource
            ConnectionMonitorCollection collection = networkWatcher.GetConnectionMonitors();

            // invoke the operation
            string connectionMonitorName = "cm1";
            NullableResponse<ConnectionMonitorResource> response = await collection.GetIfExistsAsync(connectionMonitorName);
            ConnectionMonitorResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConnectionMonitorData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
