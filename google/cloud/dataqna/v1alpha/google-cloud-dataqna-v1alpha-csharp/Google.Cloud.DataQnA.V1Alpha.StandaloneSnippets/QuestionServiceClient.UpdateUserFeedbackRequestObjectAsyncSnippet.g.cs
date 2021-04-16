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

namespace Google.Cloud.DataQnA.V1Alpha.Snippets
{
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedQuestionServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for UpdateUserFeedbackAsync</summary>
        public async Task UpdateUserFeedbackRequestObjectAsync()
        {
            // Snippet: UpdateUserFeedbackAsync(UpdateUserFeedbackRequest, CallSettings)
            // Additional: UpdateUserFeedbackAsync(UpdateUserFeedbackRequest, CancellationToken)
            // Create client
            QuestionServiceClient questionServiceClient = await QuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUserFeedbackRequest request = new UpdateUserFeedbackRequest
            {
                UserFeedback = new UserFeedback(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UserFeedback response = await questionServiceClient.UpdateUserFeedbackAsync(request);
            // End snippet
        }
    }
}
