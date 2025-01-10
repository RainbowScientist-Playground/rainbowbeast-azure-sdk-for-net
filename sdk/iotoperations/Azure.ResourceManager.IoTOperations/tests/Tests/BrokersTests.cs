// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.IoTOperations.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.IoTOperations.Tests
{
    public class BrokersTests : IoTOperationsManagementClientBase
    {
        public BrokersTests(bool isAsync)
            : base(isAsync) //, RecordedTestMode.Record
        { }

        [SetUp]
        public async Task ClearAndInitialize()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                await InitializeClients();
            }
        }

        [TestCase]
        [RecordedTest]
        public async Task TestBrokers()
        {
            // Get Brokers
            BrokerResourceCollection brokerResourceCollection =
                await GetBrokerResourceCollectionAsync(ResourceGroup);

            BrokerResource brokerResource = await brokerResourceCollection.GetAsync(BrokersName);

            Assert.IsNotNull(brokerResource);
            Assert.IsNotNull(brokerResource.Data);
            Assert.AreEqual(brokerResource.Data.Name, BrokersName);

            // Cant update Broker
        }

        private BrokerResourceData CreateBrokerResourceData(
            BrokerResource brokerResource,
            string memoryProfile
        )
        {
            return new BrokerResourceData(brokerResource.Data.ExtendedLocation)
            {
                Properties = new BrokerProperties()
                {
                    Advanced = brokerResource.Data.Properties.Advanced,
                    Cardinality = brokerResource.Data.Properties.Cardinality,
                    Diagnostics = brokerResource.Data.Properties.Diagnostics,
                    DiskBackedMessageBuffer = brokerResource
                        .Data
                        .Properties
                        .DiskBackedMessageBuffer,
                    GenerateResourceLimits = brokerResource.Data.Properties.GenerateResourceLimits,
                    MemoryProfile = new BrokerMemoryProfile(memoryProfile),
                },
            };
        }
    }
}
