// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.MySql.Samples
{
    public partial class Sample_MySqlQueryTextCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_QueryTextsGet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/QueryTextsGet.json
            // this example is just showing the usage of "QueryTexts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlQueryTextResource
            MySqlQueryTextCollection collection = mySqlServer.GetMySqlQueryTexts();

            // invoke the operation
            string queryId = "1";
            MySqlQueryTextResource result = await collection.GetAsync(queryId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlQueryTextData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_QueryTextsListByServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/QueryTextsListByServer.json
            // this example is just showing the usage of "QueryTexts_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlQueryTextResource
            MySqlQueryTextCollection collection = mySqlServer.GetMySqlQueryTexts();

            // invoke the operation and iterate over the result
            IEnumerable<string> queryIds = new string[] { "1", "2" };
            await foreach (MySqlQueryTextResource item in collection.GetAllAsync(queryIds))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlQueryTextData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_QueryTextsGet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/QueryTextsGet.json
            // this example is just showing the usage of "QueryTexts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlQueryTextResource
            MySqlQueryTextCollection collection = mySqlServer.GetMySqlQueryTexts();

            // invoke the operation
            string queryId = "1";
            bool result = await collection.ExistsAsync(queryId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_QueryTextsGet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/QueryTextsGet.json
            // this example is just showing the usage of "QueryTexts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlQueryTextResource
            MySqlQueryTextCollection collection = mySqlServer.GetMySqlQueryTexts();

            // invoke the operation
            string queryId = "1";
            NullableResponse<MySqlQueryTextResource> response = await collection.GetIfExistsAsync(queryId);
            MySqlQueryTextResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlQueryTextData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
