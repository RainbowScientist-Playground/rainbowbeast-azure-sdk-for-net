namespace Azure.Storage.DataMovement.Files.Shares
{
    public partial class ShareDirectoryClientTransferOptions
    {
        public ShareDirectoryClientTransferOptions() { }
        public Azure.Storage.DataMovement.Files.Shares.ShareFileStorageResourceOptions ShareDirectoryOptions { get { throw null; } set { } }
        public Azure.Storage.DataMovement.TransferOptions TransferOptions { get { throw null; } set { } }
    }
    public partial class ShareFilesStorageResourceProvider : Azure.Storage.DataMovement.StorageResourceProvider
    {
        public ShareFilesStorageResourceProvider(Azure.AzureSasCredential credential) { }
        public ShareFilesStorageResourceProvider(Azure.Core.TokenCredential credential) { }
        public ShareFilesStorageResourceProvider(Azure.Storage.DataMovement.Files.Shares.ShareFilesStorageResourceProvider.GetAzureSasCredential getAzureSasCredentialAsync) { }
        public ShareFilesStorageResourceProvider(Azure.Storage.DataMovement.Files.Shares.ShareFilesStorageResourceProvider.GetStorageSharedKeyCredential getStorageSharedKeyCredentialAsync) { }
        public ShareFilesStorageResourceProvider(Azure.Storage.DataMovement.Files.Shares.ShareFilesStorageResourceProvider.GetTokenCredential getTokenCredentialAsync) { }
        public ShareFilesStorageResourceProvider(Azure.Storage.StorageSharedKeyCredential credential) { }
        protected override string ProviderId { get { throw null; } }
        public static Azure.Storage.DataMovement.StorageResource FromClient(Azure.Storage.Files.Shares.ShareDirectoryClient client, Azure.Storage.DataMovement.Files.Shares.ShareFileStorageResourceOptions options = null) { throw null; }
        public static Azure.Storage.DataMovement.StorageResource FromClient(Azure.Storage.Files.Shares.ShareFileClient client, Azure.Storage.DataMovement.Files.Shares.ShareFileStorageResourceOptions options = null) { throw null; }
        protected override System.Threading.Tasks.Task<Azure.Storage.DataMovement.StorageResource> FromDestinationAsync(Azure.Storage.DataMovement.TransferProperties properties, System.Threading.CancellationToken cancellationToken) { throw null; }
        public Azure.Storage.DataMovement.StorageResource FromDirectory(System.Uri directoryUri, Azure.Storage.DataMovement.Files.Shares.ShareFileStorageResourceOptions options = null) { throw null; }
        public Azure.Storage.DataMovement.StorageResource FromFile(System.Uri fileUri, Azure.Storage.DataMovement.Files.Shares.ShareFileStorageResourceOptions options = null) { throw null; }
        protected override System.Threading.Tasks.Task<Azure.Storage.DataMovement.StorageResource> FromSourceAsync(Azure.Storage.DataMovement.TransferProperties properties, System.Threading.CancellationToken cancellationToken) { throw null; }
        public delegate Azure.AzureSasCredential GetAzureSasCredential(System.Uri uri, bool readOnly);
        public delegate Azure.Storage.StorageSharedKeyCredential GetStorageSharedKeyCredential(System.Uri uri, bool readOnly);
        public delegate Azure.Core.TokenCredential GetTokenCredential(System.Uri uri, bool readOnly);
    }
    public partial class ShareFileStorageResourceOptions
    {
        public ShareFileStorageResourceOptions() { }
        public string CacheControl { get { throw null; } set { } }
        public string ContentDisposition { get { throw null; } set { } }
        public string[] ContentEncoding { get { throw null; } set { } }
        public string[] ContentLanguage { get { throw null; } set { } }
        public string ContentType { get { throw null; } set { } }
        public Azure.Storage.Files.Shares.Models.ShareFileRequestConditions DestinationConditions { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> DirectoryMetadata { get { throw null; } set { } }
        public Azure.Storage.Files.Shares.Models.NtfsFileAttributes? FileAttributes { get { throw null; } set { } }
        public System.DateTimeOffset? FileChangedOn { get { throw null; } set { } }
        public System.DateTimeOffset? FileCreatedOn { get { throw null; } set { } }
        public System.DateTimeOffset? FileLastWrittenOn { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> FileMetadata { get { throw null; } set { } }
        public bool? FilePermissions { get { throw null; } set { } }
        public Azure.Storage.Files.Shares.Models.ShareFileRequestConditions SourceConditions { get { throw null; } set { } }
    }
}
namespace Azure.Storage.Files.Shares
{
    public static partial class ShareDirectoryClientExtensions
    {
        public static System.Threading.Tasks.Task<Azure.Storage.DataMovement.TransferOperation> DownloadToDirectoryAsync(this Azure.Storage.Files.Shares.ShareDirectoryClient client, Azure.WaitUntil waitUntil, string localDirectoryPath, Azure.Storage.DataMovement.Files.Shares.ShareDirectoryClientTransferOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Storage.DataMovement.TransferOperation> UploadDirectoryAsync(this Azure.Storage.Files.Shares.ShareDirectoryClient client, Azure.WaitUntil waitUntil, string localDirectoryPath, Azure.Storage.DataMovement.Files.Shares.ShareDirectoryClientTransferOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
