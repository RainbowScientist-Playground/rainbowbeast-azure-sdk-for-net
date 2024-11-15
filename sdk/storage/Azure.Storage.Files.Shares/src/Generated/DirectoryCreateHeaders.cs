// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Storage.Files.Shares.Models;

namespace Azure.Storage.Files.Shares
{
    internal partial class DirectoryCreateHeaders
    {
        private readonly Response _response;
        public DirectoryCreateHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Returns the date and time the share was last modified. Any operation that modifies the directory or its properties updates the last modified time. Operations on files do not affect the last modified time of the directory. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> Indicates the version of the File service used to execute the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> The value of this header is set to true if the contents of the request are successfully encrypted using the specified algorithm, and false otherwise. </summary>
        public bool? IsServerEncrypted => _response.Headers.TryGetValue("x-ms-request-server-encrypted", out bool? value) ? value : null;
        /// <summary> Key of the permission set for the directory. </summary>
        public string FilePermissionKey => _response.Headers.TryGetValue("x-ms-file-permission-key", out string value) ? value : null;
        /// <summary> Attributes set for the directory. </summary>
        public string FileAttributes => _response.Headers.TryGetValue("x-ms-file-attributes", out string value) ? value : null;
        /// <summary> Creation time for the directory. </summary>
        public DateTimeOffset? FileCreationTime => _response.Headers.TryGetValue("x-ms-file-creation-time", out DateTimeOffset? value) ? value : null;
        /// <summary> Last write time for the directory. </summary>
        public DateTimeOffset? FileLastWriteTime => _response.Headers.TryGetValue("x-ms-file-last-write-time", out DateTimeOffset? value) ? value : null;
        /// <summary> Change time for the directory. </summary>
        public DateTimeOffset? FileChangeTime => _response.Headers.TryGetValue("x-ms-file-change-time", out DateTimeOffset? value) ? value : null;
        /// <summary> The fileId of the directory. </summary>
        public string FileId => _response.Headers.TryGetValue("x-ms-file-id", out string value) ? value : null;
        /// <summary> The parent fileId of the directory. </summary>
        public string FileParentId => _response.Headers.TryGetValue("x-ms-file-parent-id", out string value) ? value : null;
        /// <summary> NFS only. The mode of the file or directory. </summary>
        public string FileMode => _response.Headers.TryGetValue("x-ms-mode", out string value) ? value : null;
        /// <summary> NFS only. The owner of the file or directory. </summary>
        public string Owner => _response.Headers.TryGetValue("x-ms-owner", out string value) ? value : null;
        /// <summary> NFS only. The owning group of the file or directory. </summary>
        public string Group => _response.Headers.TryGetValue("x-ms-group", out string value) ? value : null;
        /// <summary> NFS only. Type of the file or directory. </summary>
        public NfsFileType? NfsFileType => _response.Headers.TryGetValue("x-ms-file-file-type", out string value) ? new NfsFileType(value) : (NfsFileType?)null;
    }
}
