// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring.Models
{
    /// <summary> Represents the evaluation summary for a custom health care project. </summary>
    public partial class CustomHealthcareEvaluationSummary : EvaluationSummary
    {
        /// <summary> Initializes a new instance of <see cref="CustomHealthcareEvaluationSummary"/>. </summary>
        /// <param name="evaluationOptions"> Represents the options used running the evaluation. </param>
        /// <param name="customHealthcareEvaluation"> Contains the data related to health care evaluation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="evaluationOptions"/> or <paramref name="customHealthcareEvaluation"/> is null. </exception>
        internal CustomHealthcareEvaluationSummary(EvaluationDetails evaluationOptions, EntityRecognitionEvaluationSummary customHealthcareEvaluation) : base(evaluationOptions)
        {
            Argument.AssertNotNull(evaluationOptions, nameof(evaluationOptions));
            Argument.AssertNotNull(customHealthcareEvaluation, nameof(customHealthcareEvaluation));

            ProjectKind = ProjectKind.CustomHealthcare;
            CustomHealthcareEvaluation = customHealthcareEvaluation;
        }

        /// <summary> Initializes a new instance of <see cref="CustomHealthcareEvaluationSummary"/>. </summary>
        /// <param name="projectKind"> Represents the project type that the evaluation ran on. </param>
        /// <param name="evaluationOptions"> Represents the options used running the evaluation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="customHealthcareEvaluation"> Contains the data related to health care evaluation. </param>
        internal CustomHealthcareEvaluationSummary(ProjectKind projectKind, EvaluationDetails evaluationOptions, IDictionary<string, BinaryData> serializedAdditionalRawData, EntityRecognitionEvaluationSummary customHealthcareEvaluation) : base(projectKind, evaluationOptions, serializedAdditionalRawData)
        {
            CustomHealthcareEvaluation = customHealthcareEvaluation;
        }

        /// <summary> Initializes a new instance of <see cref="CustomHealthcareEvaluationSummary"/> for deserialization. </summary>
        internal CustomHealthcareEvaluationSummary()
        {
        }

        /// <summary> Contains the data related to health care evaluation. </summary>
        public EntityRecognitionEvaluationSummary CustomHealthcareEvaluation { get; }
    }
}
