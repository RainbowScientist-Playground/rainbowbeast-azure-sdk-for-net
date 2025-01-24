// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Threading.Tasks;
using NUnit.Framework;
using Azure.Core;
using Azure.Identity;
using Azure.Storage.Files.Shares;
using Azure.Storage.Sas;

namespace Azure.Storage.DataMovement.Files.Shares.Samples
{
    /// <summary>
    /// Basic Azure File Share Storage samples.
    /// </summary>
    public class Sample01b_HelloWorldAsync : SampleTest
    {
        public Random _rand = new Random();

        [Test]
        public async Task ResourceConstructionDemonstration()
        {
            // Create a temporary Lorem Ipsum file on disk that we can upload
            string sourceLocalPath = CreateTempFile(SampleFileContent);
            string connectionString = ConnectionString;
            string containerName = Randomize("sample-container");

            // Create a client that can authenticate with a connection string
            ShareClient shareClient = new ShareClient(connectionString, containerName);
            await shareClient.CreateIfNotExistsAsync();
            try
            {
                {
                    TokenCredential tokenCredential = new DefaultAzureCredential();

                    TransferManager transferManager = new TransferManager();

                    // Get shares provider with credential
                    #region Snippet:MakeProvider_TokenCredential_Shares
                    ShareFilesStorageResourceProvider shares = new(tokenCredential);
                    #endregion

                    // Construct simple share file resources for data movement
                    #region Snippet:ResourceConstruction_Shares
                    StorageResource directory = shares.FromDirectory(
                        new Uri("http://myaccount.files.core.windows.net/share/path/to/directory"));
                    StorageResource rootDirectory = shares.FromDirectory(
                        new Uri("http://myaccount.files.core.windows.net/share"));
                    StorageResource file = shares.FromFile(
                        new Uri("http://myaccount.files.core.windows.net/share/path/to/file.txt"));
                    #endregion
                }
                {
                    ShareDirectoryClient directoryClient = shareClient.GetRootDirectoryClient();
                    ShareFileClient fileClient = directoryClient.GetFileClient("example.txt");
                    #region Snippet:ResourceConstruction_FromClients_Shares
                    StorageResource shareDirectoryResource = ShareFilesStorageResourceProvider.FromClient(directoryClient);
                    StorageResource shareFileResource = ShareFilesStorageResourceProvider.FromClient(fileClient);
                    #endregion
                }
                {
                    StorageSharedKeyCredential sharedKeyCredential = new(StorageAccountName, StorageAccountKey);
                    // Get shares provider with credential
                    AzureSasCredential GenerateSas(Uri uri, bool readOnly)
                    {
                        // Quick sample demonstrating minimal steps
                        // Construct your SAS according to your needs
                        ShareUriBuilder pathUri = new(uri);
                        ShareSasBuilder sas = new(ShareSasPermissions.All, DateTimeOffset.Now.AddHours(1))
                        {
                            ShareName = pathUri.ShareName,
                            FilePath = pathUri.DirectoryOrFilePath,
                        };
                        return new AzureSasCredential(sas.ToSasQueryParameters(sharedKeyCredential).ToString());
                    }
                    ShareFilesStorageResourceProvider shares = new(GenerateSas);
                }
            }
            finally
            {
                await shareClient.DeleteIfExistsAsync();
            }
        }

        [Test]
        public async Task Upload()
        {
            // Create a temporary Lorem Ipsum file on disk that we can upload
            string sourceLocalFile = CreateTempFile(SampleFileContent);
            string sourceLocalDirectory = CreateTempDirectoryPath();
            string connectionString = ConnectionString;
            string shareName = Randomize("sample-share");

            // Create a client that can authenticate with a connection string
            ShareClient share = new(connectionString, shareName);
            await share.CreateIfNotExistsAsync();
            try
            {
                ShareFilesStorageResourceProvider shares = new(new StorageSharedKeyCredential(StorageAccountName, StorageAccountKey));

                // Get a reference to a destination share file/directory
                Uri destinationFolderUri = share.GetDirectoryClient("sample-directory").Uri;
                Uri destinationFileUri = share.GetRootDirectoryClient().GetFileClient("sample-file").Uri;
                TransferManager transferManager = new TransferManager(new TransferManagerOptions());

                // Create simple transfer single share file upload job
                #region Snippet:SimplefileUpload_Shares
                TransferOperation fileTransfer = await transferManager.StartTransferAsync(
                    sourceResource: LocalFilesStorageResourceProvider.FromFile(sourceLocalFile),
                    destinationResource: shares.FromFile(destinationFileUri));
                await fileTransfer.WaitForCompletionAsync();
                #endregion

                // Create simple transfer single share directory upload job
                #region Snippet:SimpleDirectoryUpload_Shares
                TransferOperation folderTransfer = await transferManager.StartTransferAsync(
                    sourceResource: LocalFilesStorageResourceProvider.FromDirectory(sourceLocalDirectory),
                    destinationResource: shares.FromDirectory(destinationFolderUri));
                await folderTransfer.WaitForCompletionAsync();
                #endregion
            }
            finally
            {
                await share.DeleteIfExistsAsync();
            }
        }

        [Test]
        public async Task Download()
        {
            // Create a temporary Lorem Ipsum file on disk that we can upload
            string destinationLocalFile = CreateTempFile(SampleFileContent);
            string destinationLocalDirectory = CreateTempDirectoryPath();
            string connectionString = ConnectionString;
            string shareName = Randomize("sample-share");

            // Create a client that can authenticate with a connection string
            ShareClient share = new(connectionString, shareName);
            await share.CreateIfNotExistsAsync();
            try
            {
                ShareFilesStorageResourceProvider shares = new(new StorageSharedKeyCredential(StorageAccountName, StorageAccountKey));

                // Get a reference to a destination share file/directory
                Uri sourceDirectoryUri = share.GetDirectoryClient("sample-directory").Uri;
                Uri sourceFileUri = share.GetRootDirectoryClient().GetFileClient("sample-file").Uri;
                TransferManager transferManager = new TransferManager(new TransferManagerOptions());

                // Create simple transfer single share file upload job
                #region Snippet:SimpleFileDownload_Shares
                TransferOperation fileTransfer = await transferManager.StartTransferAsync(
                    sourceResource: shares.FromFile(sourceFileUri),
                    destinationResource: LocalFilesStorageResourceProvider.FromFile(destinationLocalFile));
                await fileTransfer.WaitForCompletionAsync();
                #endregion

                // Create simple transfer single share directory upload job
                #region Snippet:SimpleDirectoryDownload_Shares
                TransferOperation directoryTransfer = await transferManager.StartTransferAsync(
                    sourceResource: shares.FromDirectory(sourceDirectoryUri),
                    destinationResource: LocalFilesStorageResourceProvider.FromDirectory(destinationLocalDirectory));
                await directoryTransfer.WaitForCompletionAsync();
                #endregion
            }
            finally
            {
                await share.DeleteIfExistsAsync();
            }
        }

        [Test]
        public async Task Copy()
        {
            string connectionString = ConnectionString;
            string shareName = Randomize("sample-share");

            // Create a client that can authenticate with a connection string
            ShareClient share = new(connectionString, shareName);
            await share.CreateIfNotExistsAsync();
            try
            {
                ShareFilesStorageResourceProvider shares = new(new StorageSharedKeyCredential(StorageAccountName, StorageAccountKey));

                // Get a reference to a destination share files/directories
                Uri sourceDirectoryUri = share.GetDirectoryClient("sample-directory-1").Uri;
                Uri destinationDirectoryUri = share.GetDirectoryClient("sample-directory-2").Uri;
                Uri sourceFileUri = share.GetRootDirectoryClient().GetFileClient("sample-file-1").Uri;
                Uri destinationFileUri = share.GetRootDirectoryClient().GetFileClient("sample-file-2").Uri;
                TransferManager transferManager = new TransferManager(new TransferManagerOptions());

                // Create simple transfer single share file upload job
                #region Snippet:s2sCopyFile_Shares
                TransferOperation fileTransfer = await transferManager.StartTransferAsync(
                    sourceResource: shares.FromFile(sourceFileUri),
                    destinationResource: shares.FromFile(destinationFileUri));
                await fileTransfer.WaitForCompletionAsync();
                #endregion

                // Create simple transfer single share directory upload job
                #region Snippet:s2sCopyDirectory_Shares
                TransferOperation directoryTransfer = await transferManager.StartTransferAsync(
                    sourceResource: shares.FromDirectory(sourceDirectoryUri),
                    destinationResource: shares.FromDirectory(destinationDirectoryUri));
                await directoryTransfer.WaitForCompletionAsync();
                #endregion
            }
            finally
            {
                await share.DeleteIfExistsAsync();
            }
        }

        public async Task<string> CreateFileShareTestDirectory(ShareClient client, int depth = 0, string basePath = default)
        {
            basePath = basePath ?? Path.GetTempFileName();

            var dirPath = string.IsNullOrEmpty(basePath) ? Path.GetTempFileName() : $"{basePath}/{Path.GetTempFileName()}";

            await CreateShareFiles(client, dirPath, 5);

            if (depth > 0)
            {
                await CreateFileShareTestDirectory(client, depth - 1, dirPath);
            }

            return dirPath;
        }

        public async Task CreateShareFiles(ShareClient client, string dirPath = default, int count = 1)
        {
            var buff = new byte[1000];

            for (int i = 0; i < count; i++)
            {
                _rand.NextBytes(buff);
                await client.GetDirectoryClient(dirPath ?? "")
                    .GetFileClient($"{Path.GetTempFileName()}.txt")
                    .UploadAsync(new MemoryStream(buff));
            }
        }

        public string CreateLocalTestDirectory(int depth = 0, string basePath = default)
        {
            basePath = basePath ?? Path.GetTempPath();

            var dirPath = Path.Combine(basePath, Path.GetTempFileName());

            Directory.CreateDirectory(dirPath);

            CreateLocalTestFiles(dirPath, 5);

            if (depth > 0)
            {
                CreateLocalTestDirectory(depth - 1, dirPath);
            }

            return dirPath;
        }

        public void CreateLocalTestFiles(string dirPath, int count = 1)
        {
            var buff = new byte[1000];

            for (int i = 0; i < count; i++)
            {
                var filePath = Path.Combine(dirPath, Path.GetTempFileName() + ".txt");

                _rand.NextBytes(buff);

                File.WriteAllText(filePath, Convert.ToBase64String(buff));
            }
        }

        public struct StoredCredentials
        {
            public StorageResourceContainer SourceContainer { get; set; }
            public StorageResourceContainer DestinationContainer { get; set; }

            public StoredCredentials(
                StorageResourceContainer sourceContainer,
                StorageResourceContainer destinationContainer)
            {
                SourceContainer = sourceContainer;
                DestinationContainer = destinationContainer;
            }
        }
    }
}
