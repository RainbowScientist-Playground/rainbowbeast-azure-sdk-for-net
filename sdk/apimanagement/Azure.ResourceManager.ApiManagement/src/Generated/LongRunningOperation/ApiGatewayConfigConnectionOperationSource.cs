// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement
{
    internal class ApiGatewayConfigConnectionOperationSource : IOperationSource<ApiGatewayConfigConnectionResource>
    {
        private readonly ArmClient _client;

        internal ApiGatewayConfigConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        ApiGatewayConfigConnectionResource IOperationSource<ApiGatewayConfigConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ApiGatewayConfigConnectionData.DeserializeApiGatewayConfigConnectionData(document.RootElement);
            return new ApiGatewayConfigConnectionResource(_client, data);
        }

        async ValueTask<ApiGatewayConfigConnectionResource> IOperationSource<ApiGatewayConfigConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ApiGatewayConfigConnectionData.DeserializeApiGatewayConfigConnectionData(document.RootElement);
            return new ApiGatewayConfigConnectionResource(_client, data);
        }
    }
}
