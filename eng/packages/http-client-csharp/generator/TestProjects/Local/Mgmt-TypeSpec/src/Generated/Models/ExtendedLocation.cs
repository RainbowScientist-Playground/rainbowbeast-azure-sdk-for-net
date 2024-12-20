// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using MgmtTypeSpec;

namespace MgmtTypeSpec.Models
{
    /// <summary> The complex type of the extended location. </summary>
    public partial class ExtendedLocation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        /// <summary> Initializes a new instance of <see cref="ExtendedLocation"/>. </summary>
        /// <param name="name"> The name of the extended location. </param>
        /// <param name="type"> The type of the extended location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ExtendedLocation(string name, ExtendedLocationType @type)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Type = @type;
        }

        internal ExtendedLocation(string name, ExtendedLocationType @type, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Name = name;
            Type = @type;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> The name of the extended location. </summary>
        public string Name { get; set; }

        /// <summary> The type of the extended location. </summary>
        public ExtendedLocationType Type { get; set; }
    }
}
