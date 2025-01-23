// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_SiteSlotDiagnosticCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAppDiagnosticCategory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/Diagnostics_GetSiteDiagnosticCategory.json
            // this example is just showing the usage of "Diagnostics_GetSiteDiagnosticCategorySlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "Production";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDiagnosticResource
            SiteSlotDiagnosticCollection collection = webSiteSlot.GetSiteSlotDiagnostics();

            // invoke the operation
            string diagnosticCategory = "availability";
            SiteSlotDiagnosticResource result = await collection.GetAsync(diagnosticCategory);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiagnosticCategoryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAppSlotDiagnosticCategory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/Diagnostics_GetSiteDiagnosticCategorySlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDiagnosticCategorySlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDiagnosticResource
            SiteSlotDiagnosticCollection collection = webSiteSlot.GetSiteSlotDiagnostics();

            // invoke the operation
            string diagnosticCategory = "availability";
            SiteSlotDiagnosticResource result = await collection.GetAsync(diagnosticCategory);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiagnosticCategoryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAppDiagnosticCategories()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/Diagnostics_ListSiteDiagnosticCategories.json
            // this example is just showing the usage of "Diagnostics_ListSiteDiagnosticCategoriesSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "Production";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDiagnosticResource
            SiteSlotDiagnosticCollection collection = webSiteSlot.GetSiteSlotDiagnostics();

            // invoke the operation and iterate over the result
            await foreach (SiteSlotDiagnosticResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiagnosticCategoryData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAppSlotDiagnosticCategories()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/Diagnostics_ListSiteDiagnosticCategoriesSlot.json
            // this example is just showing the usage of "Diagnostics_ListSiteDiagnosticCategoriesSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDiagnosticResource
            SiteSlotDiagnosticCollection collection = webSiteSlot.GetSiteSlotDiagnostics();

            // invoke the operation and iterate over the result
            await foreach (SiteSlotDiagnosticResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiagnosticCategoryData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAppDiagnosticCategory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/Diagnostics_GetSiteDiagnosticCategory.json
            // this example is just showing the usage of "Diagnostics_GetSiteDiagnosticCategorySlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "Production";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDiagnosticResource
            SiteSlotDiagnosticCollection collection = webSiteSlot.GetSiteSlotDiagnostics();

            // invoke the operation
            string diagnosticCategory = "availability";
            bool result = await collection.ExistsAsync(diagnosticCategory);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAppSlotDiagnosticCategory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/Diagnostics_GetSiteDiagnosticCategorySlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDiagnosticCategorySlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDiagnosticResource
            SiteSlotDiagnosticCollection collection = webSiteSlot.GetSiteSlotDiagnostics();

            // invoke the operation
            string diagnosticCategory = "availability";
            bool result = await collection.ExistsAsync(diagnosticCategory);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAppDiagnosticCategory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/Diagnostics_GetSiteDiagnosticCategory.json
            // this example is just showing the usage of "Diagnostics_GetSiteDiagnosticCategorySlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "Production";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDiagnosticResource
            SiteSlotDiagnosticCollection collection = webSiteSlot.GetSiteSlotDiagnostics();

            // invoke the operation
            string diagnosticCategory = "availability";
            NullableResponse<SiteSlotDiagnosticResource> response = await collection.GetIfExistsAsync(diagnosticCategory);
            SiteSlotDiagnosticResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiagnosticCategoryData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAppSlotDiagnosticCategory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/Diagnostics_GetSiteDiagnosticCategorySlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDiagnosticCategorySlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteSlotResource created on azure
            // for more information of creating WebSiteSlotResource, please refer to the document of WebSiteSlotResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            ResourceIdentifier webSiteSlotResourceId = WebSiteSlotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot);
            WebSiteSlotResource webSiteSlot = client.GetWebSiteSlotResource(webSiteSlotResourceId);

            // get the collection of this SiteSlotDiagnosticResource
            SiteSlotDiagnosticCollection collection = webSiteSlot.GetSiteSlotDiagnostics();

            // invoke the operation
            string diagnosticCategory = "availability";
            NullableResponse<SiteSlotDiagnosticResource> response = await collection.GetIfExistsAsync(diagnosticCategory);
            SiteSlotDiagnosticResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiagnosticCategoryData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
