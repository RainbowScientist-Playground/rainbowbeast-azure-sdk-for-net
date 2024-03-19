// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Monitor.OpenTelemetry.LiveMetrics;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    /// <summary> A filter set on UX. </summary>
    internal partial class FilterInfo
    {
        /// <summary> Initializes a new instance of <see cref="FilterInfo"/>. </summary>
        /// <param name="fieldName"> dimension name of the filter. </param>
        /// <param name="predicate"> Operator of the filter. </param>
        /// <param name="comparand"> Comparand of the filter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fieldName"/> or <paramref name="comparand"/> is null. </exception>
        internal FilterInfo(string fieldName, PredicateType predicate, string comparand)
        {
            Argument.AssertNotNull(fieldName, nameof(fieldName));
            Argument.AssertNotNull(comparand, nameof(comparand));

            FieldName = fieldName;
            Predicate = predicate;
            Comparand = comparand;
        }

        /// <summary> dimension name of the filter. </summary>
        public string FieldName { get; }
        /// <summary> Operator of the filter. </summary>
        public PredicateType Predicate { get; }
        /// <summary> Comparand of the filter. </summary>
        public string Comparand { get; }
    }
}
