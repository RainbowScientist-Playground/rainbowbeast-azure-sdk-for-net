// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring.Models
{
    /// <summary> Unknown version of EvaluationSummary. </summary>
    internal partial class UnknownEvaluationSummary : EvaluationSummary
    {
        /// <summary> Initializes a new instance of <see cref="UnknownEvaluationSummary"/>. </summary>
        /// <param name="projectKind"> Represents the project type that the evaluation ran on. </param>
        /// <param name="evaluationOptions"> Represents the options used running the evaluation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownEvaluationSummary(ProjectKind projectKind, EvaluationDetails evaluationOptions, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(projectKind, evaluationOptions, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownEvaluationSummary"/> for deserialization. </summary>
        internal UnknownEvaluationSummary()
        {
        }
    }
}
