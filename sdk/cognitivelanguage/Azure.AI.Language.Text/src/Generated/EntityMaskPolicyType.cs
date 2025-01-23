// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> Represents the policy of redacting PII with the entity type. </summary>
    public partial class EntityMaskPolicyType : BaseRedactionPolicy
    {
        /// <summary> Initializes a new instance of <see cref="EntityMaskPolicyType"/>. </summary>
        public EntityMaskPolicyType()
        {
            PolicyKind = RedactionPolicyKind.EntityMask;
        }

        /// <summary> Initializes a new instance of <see cref="EntityMaskPolicyType"/>. </summary>
        /// <param name="policyKind"> The entity RedactionPolicy object kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EntityMaskPolicyType(RedactionPolicyKind policyKind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(policyKind, serializedAdditionalRawData)
        {
        }
    }
}
