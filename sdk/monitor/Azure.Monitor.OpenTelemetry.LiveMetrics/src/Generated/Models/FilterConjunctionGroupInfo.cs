// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Monitor.OpenTelemetry.LiveMetrics;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    /// <summary> An AND-connected group of FilterInfo objects. </summary>
    internal partial class FilterConjunctionGroupInfo
    {
        /// <summary> Initializes a new instance of <see cref="FilterConjunctionGroupInfo"/>. </summary>
        /// <param name="filters"> An array of filters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filters"/> is null. </exception>
        internal FilterConjunctionGroupInfo(IEnumerable<FilterInfo> filters)
        {
            Argument.AssertNotNull(filters, nameof(filters));

            Filters = filters.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="FilterConjunctionGroupInfo"/>. </summary>
        /// <param name="filters"> An array of filters. </param>
        internal FilterConjunctionGroupInfo(IReadOnlyList<FilterInfo> filters)
        {
            Filters = filters;
        }

        /// <summary> An array of filters. </summary>
        public IReadOnlyList<FilterInfo> Filters { get; }
    }
}
