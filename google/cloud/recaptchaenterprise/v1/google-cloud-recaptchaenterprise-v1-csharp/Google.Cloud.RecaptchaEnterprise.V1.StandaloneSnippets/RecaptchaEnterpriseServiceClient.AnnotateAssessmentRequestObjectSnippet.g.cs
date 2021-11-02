// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.RecaptchaEnterprise.V1.Snippets
{
    using Google.Cloud.RecaptchaEnterprise.V1;
    using Google.Protobuf;

    public sealed partial class GeneratedRecaptchaEnterpriseServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for AnnotateAssessment</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void AnnotateAssessmentRequestObject()
        {
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified,
                Reasons =
                {
                    AnnotateAssessmentRequest.Types.Reason.Unspecified,
                },
                HashedAccountId = ByteString.Empty,
            };
            // Make the request
            AnnotateAssessmentResponse response = recaptchaEnterpriseServiceClient.AnnotateAssessment(request);
        }
    }
}
