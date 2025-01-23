// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> Security details for OpenApi managed_identity authentication. </summary>
    public partial class OpenApiManagedAuthDetails : OpenApiAuthDetails
    {
        /// <summary> Initializes a new instance of <see cref="OpenApiManagedAuthDetails"/>. </summary>
        /// <param name="securityScheme"> Connection auth security details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityScheme"/> is null. </exception>
        public OpenApiManagedAuthDetails(OpenApiManagedSecurityScheme securityScheme)
        {
            Argument.AssertNotNull(securityScheme, nameof(securityScheme));

            Type = OpenApiAuthType.ManagedIdentity;
            SecurityScheme = securityScheme;
        }

        /// <summary> Initializes a new instance of <see cref="OpenApiManagedAuthDetails"/>. </summary>
        /// <param name="type"> The type of authentication, must be anonymous/connection/managed_identity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="securityScheme"> Connection auth security details. </param>
        internal OpenApiManagedAuthDetails(OpenApiAuthType type, IDictionary<string, BinaryData> serializedAdditionalRawData, OpenApiManagedSecurityScheme securityScheme) : base(type, serializedAdditionalRawData)
        {
            SecurityScheme = securityScheme;
        }

        /// <summary> Initializes a new instance of <see cref="OpenApiManagedAuthDetails"/> for deserialization. </summary>
        internal OpenApiManagedAuthDetails()
        {
        }

        /// <summary> Connection auth security details. </summary>
        public OpenApiManagedSecurityScheme SecurityScheme { get; set; }
    }
}
