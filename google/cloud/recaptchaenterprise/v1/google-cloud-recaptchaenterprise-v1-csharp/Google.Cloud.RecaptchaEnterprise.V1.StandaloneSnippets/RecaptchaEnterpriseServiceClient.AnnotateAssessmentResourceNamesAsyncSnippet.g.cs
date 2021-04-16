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
    using System.Threading.Tasks;

    public sealed partial class GeneratedRecaptchaEnterpriseServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for AnnotateAssessmentAsync</summary>
        public async Task AnnotateAssessmentResourceNamesAsync()
        {
            // Snippet: AnnotateAssessmentAsync(AssessmentName, AnnotateAssessmentRequest.Types.Annotation, CallSettings)
            // Additional: AnnotateAssessmentAsync(AssessmentName, AnnotateAssessmentRequest.Types.Annotation, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssessmentName name = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]");
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            // Make the request
            AnnotateAssessmentResponse response = await recaptchaEnterpriseServiceClient.AnnotateAssessmentAsync(name, annotation);
            // End snippet
        }
    }
}
