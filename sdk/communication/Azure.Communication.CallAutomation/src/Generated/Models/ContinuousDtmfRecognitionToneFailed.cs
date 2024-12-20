// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The ContinuousDtmfRecognitionToneFailed. </summary>
    public partial class ContinuousDtmfRecognitionToneFailed
    {
        /// <summary> Initializes a new instance of <see cref="ContinuousDtmfRecognitionToneFailed"/>. </summary>
        internal ContinuousDtmfRecognitionToneFailed()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContinuousDtmfRecognitionToneFailed"/>. </summary>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code, sub-code and message. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        internal ContinuousDtmfRecognitionToneFailed(string callConnectionId, string serverCallId, string correlationId, ResultInformation resultInformation, string operationContext)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            ResultInformation = resultInformation;
            OperationContext = operationContext;
        }
    }
}
