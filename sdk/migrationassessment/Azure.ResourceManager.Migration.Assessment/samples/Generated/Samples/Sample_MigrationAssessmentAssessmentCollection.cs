// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Migration.Assessment.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Migration.Assessment.Samples
{
    public partial class Sample_MigrationAssessmentAssessmentCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_AssessmentsOperationsCreateMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/AssessmentsOperations_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "AssessmentsOperations_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentGroupResource created on azure
            // for more information of creating MigrationAssessmentGroupResource, please refer to the document of MigrationAssessmentGroupResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "ayagrawrg";
            string projectName = "app18700project";
            string groupName = "kuchatur-test";
            ResourceIdentifier migrationAssessmentGroupResourceId = MigrationAssessmentGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, groupName);
            MigrationAssessmentGroupResource migrationAssessmentGroup = client.GetMigrationAssessmentGroupResource(migrationAssessmentGroupResourceId);

            // get the collection of this MigrationAssessmentAssessmentResource
            MigrationAssessmentAssessmentCollection collection = migrationAssessmentGroup.GetMigrationAssessmentAssessments();

            // invoke the operation
            string assessmentName = "asm1";
            MigrationAssessmentAssessmentData data = new MigrationAssessmentAssessmentData
            {
                ProvisioningState = MigrationAssessmentProvisioningState.Succeeded,
                EASubscriptionId = "kwsu",
                AzurePricingTier = AzurePricingTier.Standard,
                AzureStorageRedundancy = AzureStorageRedundancy.Unknown,
                ReservedInstance = AzureReservedInstance.None,
                AzureHybridUseBenefit = AzureHybridUseBenefit.Unknown,
                AzureDiskTypes = { AzureDiskType.Premium, AzureDiskType.StandardSsd },
                AzureVmFamilies = { AzureVmFamily.DSeries, AzureVmFamily.Lsv2Series, AzureVmFamily.MSeries, AzureVmFamily.Mdsv2Series, AzureVmFamily.Msv2Series, AzureVmFamily.Mv2Series },
                VmUptime = new VmUptime
                {
                    DaysPerMonth = 13,
                    HoursPerDay = 26,
                },
                AzureLocation = new AzureLocation("njxbwdtsxzhichsnk"),
                AzureOfferCode = AzureOfferCode.Unknown,
                Currency = AzureCurrency.Unknown,
                ScalingFactor = 24,
                Percentile = PercentileOfUtilization.Percentile50,
                TimeRange = AssessmentTimeRange.Day,
                PerfDataStartOn = DateTimeOffset.Parse("2023-09-26T09:36:48.491Z"),
                PerfDataEndOn = DateTimeOffset.Parse("2023-09-26T09:36:48.491Z"),
                DiscountPercentage = 6,
                SizingCriterion = AssessmentSizingCriterion.PerformanceBased,
            };
            ArmOperation<MigrationAssessmentAssessmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, assessmentName, data);
            MigrationAssessmentAssessmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MigrationAssessmentAssessmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_AssessmentsOperationsGetMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/AssessmentsOperations_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "AssessmentsOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentGroupResource created on azure
            // for more information of creating MigrationAssessmentGroupResource, please refer to the document of MigrationAssessmentGroupResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "ayagrawrg";
            string projectName = "app18700project";
            string groupName = "kuchatur-test";
            ResourceIdentifier migrationAssessmentGroupResourceId = MigrationAssessmentGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, groupName);
            MigrationAssessmentGroupResource migrationAssessmentGroup = client.GetMigrationAssessmentGroupResource(migrationAssessmentGroupResourceId);

            // get the collection of this MigrationAssessmentAssessmentResource
            MigrationAssessmentAssessmentCollection collection = migrationAssessmentGroup.GetMigrationAssessmentAssessments();

            // invoke the operation
            string assessmentName = "asm1";
            MigrationAssessmentAssessmentResource result = await collection.GetAsync(assessmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MigrationAssessmentAssessmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_AssessmentsOperationsListByGroupMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/AssessmentsOperations_ListByGroup_MaximumSet_Gen.json
            // this example is just showing the usage of "AssessmentsOperations_ListByGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentGroupResource created on azure
            // for more information of creating MigrationAssessmentGroupResource, please refer to the document of MigrationAssessmentGroupResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "ayagrawrg";
            string projectName = "app18700project";
            string groupName = "kuchatur-test";
            ResourceIdentifier migrationAssessmentGroupResourceId = MigrationAssessmentGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, groupName);
            MigrationAssessmentGroupResource migrationAssessmentGroup = client.GetMigrationAssessmentGroupResource(migrationAssessmentGroupResourceId);

            // get the collection of this MigrationAssessmentAssessmentResource
            MigrationAssessmentAssessmentCollection collection = migrationAssessmentGroup.GetMigrationAssessmentAssessments();

            // invoke the operation and iterate over the result
            await foreach (MigrationAssessmentAssessmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MigrationAssessmentAssessmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_AssessmentsOperationsGetMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/AssessmentsOperations_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "AssessmentsOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentGroupResource created on azure
            // for more information of creating MigrationAssessmentGroupResource, please refer to the document of MigrationAssessmentGroupResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "ayagrawrg";
            string projectName = "app18700project";
            string groupName = "kuchatur-test";
            ResourceIdentifier migrationAssessmentGroupResourceId = MigrationAssessmentGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, groupName);
            MigrationAssessmentGroupResource migrationAssessmentGroup = client.GetMigrationAssessmentGroupResource(migrationAssessmentGroupResourceId);

            // get the collection of this MigrationAssessmentAssessmentResource
            MigrationAssessmentAssessmentCollection collection = migrationAssessmentGroup.GetMigrationAssessmentAssessments();

            // invoke the operation
            string assessmentName = "asm1";
            bool result = await collection.ExistsAsync(assessmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_AssessmentsOperationsGetMaximumSetGen()
        {
            // Generated from example definition: specification/migrate/resource-manager/Microsoft.Migrate/AssessmentProjects/stable/2023-03-15/examples/AssessmentsOperations_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "AssessmentsOperations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MigrationAssessmentGroupResource created on azure
            // for more information of creating MigrationAssessmentGroupResource, please refer to the document of MigrationAssessmentGroupResource
            string subscriptionId = "4bd2aa0f-2bd2-4d67-91a8-5a4533d58600";
            string resourceGroupName = "ayagrawrg";
            string projectName = "app18700project";
            string groupName = "kuchatur-test";
            ResourceIdentifier migrationAssessmentGroupResourceId = MigrationAssessmentGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName, groupName);
            MigrationAssessmentGroupResource migrationAssessmentGroup = client.GetMigrationAssessmentGroupResource(migrationAssessmentGroupResourceId);

            // get the collection of this MigrationAssessmentAssessmentResource
            MigrationAssessmentAssessmentCollection collection = migrationAssessmentGroup.GetMigrationAssessmentAssessments();

            // invoke the operation
            string assessmentName = "asm1";
            NullableResponse<MigrationAssessmentAssessmentResource> response = await collection.GetIfExistsAsync(assessmentName);
            MigrationAssessmentAssessmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MigrationAssessmentAssessmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
