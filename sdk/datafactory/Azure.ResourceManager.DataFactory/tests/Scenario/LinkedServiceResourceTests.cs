﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Storage;
using NUnit.Framework;

namespace Azure.ResourceManager.DataFactory.Tests
{
    internal class LinkedServiceResourceTests : DataFactoryManagementTestBase
    {
        private string _accessKey;
        private StorageAccountResource _storageAccount;
        private ResourceGroupResource _resourceGroup;
        private DataFactoryResource _dataFactory;
        public LinkedServiceResourceTests(bool isAsync) : base(isAsync)
        {
        }

        [SetUp]
        public async Task TestSetUp()
        {
            SubscriptionResource subscription = await Client.GetDefaultSubscriptionAsync();
            _resourceGroup = await CreateResourceGroup(subscription, "DataFactory-RG-", AzureLocation.WestUS2);
            _dataFactory = await CreateDataFactory(_resourceGroup);
            _storageAccount = await GetStorageAccountAsync(_resourceGroup);
            var key = await _storageAccount.GetKeysAsync().FirstOrDefaultAsync(_ => true);
            _accessKey = key.Value;
        }

        [TearDown]
        public async Task TestTearDown()
        {
            // Delete Storage Account ASAP.
            var list = await _resourceGroup.GetStorageAccounts().GetAllAsync().ToEnumerableAsync();
            foreach (var storageAccount in list)
            {
                await storageAccount.DeleteAsync(WaitUntil.Completed);
            }
        }

        [Test]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            string linkedServiceName = Recording.GenerateAssetName("LinkedService");
            var linkedService = await CreateLinkedService(_dataFactory, linkedServiceName, _accessKey, _storageAccount.Id.Name);
            Assert.IsNotNull(linkedService);
            Assert.AreEqual(linkedServiceName, linkedService.Data.Name);
        }

        [Test]
        [RecordedTest]
        public async Task Exist()
        {
            string linkedServiceName = Recording.GenerateAssetName("LinkedService");
            await CreateLinkedService(_dataFactory, linkedServiceName, _accessKey, _storageAccount.Id.Name);
            bool flag = await _dataFactory.GetFactoryLinkedServices().ExistsAsync(linkedServiceName);
            Assert.IsTrue(flag);
        }

        [Test]
        [RecordedTest]
        public async Task Get()
        {
            string linkedServiceName = Recording.GenerateAssetName("LinkedService");
            await CreateLinkedService(_dataFactory, linkedServiceName, _accessKey, _storageAccount.Id.Name);
            var linkedService = await _dataFactory.GetFactoryLinkedServices().GetAsync(linkedServiceName);
            Assert.IsNotNull(linkedService);
            Assert.AreEqual(linkedServiceName, linkedService.Value.Data.Name);
        }

        [Test]
        [RecordedTest]
        public async Task GetAll()
        {
            string linkedServiceName = Recording.GenerateAssetName("LinkedService");
            await CreateLinkedService(_dataFactory, linkedServiceName, _accessKey, _storageAccount.Id.Name);
            var list = await _dataFactory.GetFactoryLinkedServices().GetAllAsync().ToEnumerableAsync();
            Assert.IsNotEmpty(list);
            Assert.AreEqual(1, list.Count);
        }

        [Test]
        [RecordedTest]
        public async Task Delete()
        {
            string linkedServiceName = Recording.GenerateAssetName("LinkedService");
            var linkedService = await CreateLinkedService(_dataFactory, linkedServiceName, _accessKey, _storageAccount.Id.Name);
            bool flag = await _dataFactory.GetFactoryLinkedServices().ExistsAsync(linkedServiceName);
            Assert.IsTrue(flag);

            await linkedService.DeleteAsync(WaitUntil.Completed);
            flag = await _dataFactory.GetFactoryLinkedServices().ExistsAsync(linkedServiceName);
            Assert.IsFalse(flag);
        }
    }
}
