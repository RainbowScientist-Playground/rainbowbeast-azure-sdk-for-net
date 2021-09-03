// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Scanning
{
    /// <summary> The PurviewClassificationRule service client. </summary>
    public partial class PurviewClassificationRuleClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get; }
        private readonly string[] AuthorizationScopes = { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private Uri endpoint;
        private string classificationRuleName;
        private readonly string apiVersion;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Initializes a new instance of PurviewClassificationRuleClient for mocking. </summary>
        protected PurviewClassificationRuleClient()
        {
        }

        /// <summary> Initializes a new instance of PurviewClassificationRuleClient. </summary>
        /// <param name="endpoint"> The scanning endpoint of your purview account. Example: https://{accountName}.scan.purview.azure.com. </param>
        /// <param name="classificationRuleName"> The String to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public PurviewClassificationRuleClient(Uri endpoint, string classificationRuleName, TokenCredential credential, PurviewScanningServiceClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (classificationRuleName == null)
            {
                throw new ArgumentNullException(nameof(classificationRuleName));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new PurviewScanningServiceClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            var authPolicy = new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes);
            Pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            this.endpoint = endpoint;
            this.classificationRuleName = classificationRuleName;
            apiVersion = options.Version;
        }

        /// <summary> Get a classification rule. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetPropertiesAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetPropertiesRequest(options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewClassificationRuleClient.GetProperties");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a classification rule. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetProperties(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetPropertiesRequest(options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewClassificationRuleClient.GetProperties");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetProperties"/> and <see cref="GetPropertiesAsync"/> operations. </summary>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetPropertiesRequest(RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/classificationrules/", false);
            uri.AppendPath(classificationRuleName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Creates or Updates a classification rule. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>id</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term></term>
        ///   </item>
        ///   <item>
        ///     <term>name</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term></term>
        ///   </item>
        ///   <item>
        ///     <term>kind</term>
        ///     <term>&quot;System&quot; | &quot;Custom&quot;</term>
        ///     <term>Yes</term>
        ///     <term></term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateOrUpdateAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateCreateOrUpdateRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewClassificationRuleClient.CreateOrUpdate");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                        case 201:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or Updates a classification rule. </summary>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Name</term>
        ///     <term>Type</term>
        ///     <term>Required</term>
        ///     <term>Description</term>
        ///   </listheader>
        ///   <item>
        ///     <term>id</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term></term>
        ///   </item>
        ///   <item>
        ///     <term>name</term>
        ///     <term>string</term>
        ///     <term></term>
        ///     <term></term>
        ///   </item>
        ///   <item>
        ///     <term>kind</term>
        ///     <term>&quot;System&quot; | &quot;Custom&quot;</term>
        ///     <term>Yes</term>
        ///     <term></term>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response CreateOrUpdate(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateCreateOrUpdateRequest(content, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewClassificationRuleClient.CreateOrUpdate");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                        case 201:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="CreateOrUpdate"/> and <see cref="CreateOrUpdateAsync"/> operations. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateCreateOrUpdateRequest(RequestContent content, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/classificationrules/", false);
            uri.AppendPath(classificationRuleName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Deletes a classification rule. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> DeleteAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateDeleteRequest(options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewClassificationRuleClient.Delete");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        case 204:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a classification rule. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Delete(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateDeleteRequest(options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewClassificationRuleClient.Delete");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        case 204:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="Delete"/> and <see cref="DeleteAsync"/> operations. </summary>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateDeleteRequest(RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/classificationrules/", false);
            uri.AppendPath(classificationRuleName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists the rule versions of a classification rule. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetVersionsAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetVersionsRequest(options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewClassificationRuleClient.GetVersions");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the rule versions of a classification rule. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetVersions(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetVersionsRequest(options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewClassificationRuleClient.GetVersions");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 200:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="GetVersions"/> and <see cref="GetVersionsAsync"/> operations. </summary>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateGetVersionsRequest(RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/classificationrules/", false);
            uri.AppendPath(classificationRuleName, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Sets Classification Action on a specific classification rule version. </summary>
        /// <param name="classificationRuleVersion"> The Integer to use. </param>
        /// <param name="action"> The ClassificationAction to use. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> TagVersionAsync(int classificationRuleVersion, string action, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateTagVersionRequest(classificationRuleVersion, action, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewClassificationRuleClient.TagVersion");
            scope.Start();
            try
            {
                await Pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 202:
                            return message.Response;
                        default:
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets Classification Action on a specific classification rule version. </summary>
        /// <param name="classificationRuleVersion"> The Integer to use. </param>
        /// <param name="action"> The ClassificationAction to use. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response TagVersion(int classificationRuleVersion, string action, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateTagVersionRequest(classificationRuleVersion, action, options);
            RequestOptions.Apply(options, message);
            using var scope = _clientDiagnostics.CreateScope("PurviewClassificationRuleClient.TagVersion");
            scope.Start();
            try
            {
                Pipeline.Send(message, options.CancellationToken);
                if (options.StatusOption == ResponseStatusOption.Default)
                {
                    switch (message.Response.Status)
                    {
                        case 202:
                            return message.Response;
                        default:
                            throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                    }
                }
                else
                {
                    return message.Response;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create Request for <see cref="TagVersion"/> and <see cref="TagVersionAsync"/> operations. </summary>
        /// <param name="classificationRuleVersion"> The Integer to use. </param>
        /// <param name="action"> The ClassificationAction to use. </param>
        /// <param name="options"> The request options. </param>
        private HttpMessage CreateTagVersionRequest(int classificationRuleVersion, string action, RequestOptions options = null)
        {
            var message = Pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/classificationrules/", false);
            uri.AppendPath(classificationRuleName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(classificationRuleVersion, true);
            uri.AppendPath("/:tag", false);
            uri.AppendQuery("action", action, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }
    }
}
