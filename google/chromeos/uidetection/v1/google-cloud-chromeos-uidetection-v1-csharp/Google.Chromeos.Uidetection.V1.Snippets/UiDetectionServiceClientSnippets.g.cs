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

namespace Google.Chromeos.Uidetection.V1.Snippets
{
    using Google.Protobuf;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedUiDetectionServiceClientSnippets
    {
        /// <summary>Snippet for ExecuteDetection</summary>
        public void ExecuteDetectionRequestObject()
        {
            // Snippet: ExecuteDetection(UiDetectionRequest, CallSettings)
            // Create client
            UiDetectionServiceClient uiDetectionServiceClient = UiDetectionServiceClient.Create();
            // Initialize request argument(s)
            UiDetectionRequest request = new UiDetectionRequest
            {
                ImagePng = ByteString.Empty,
                Request = new DetectionRequest(),
            };
            // Make the request
            UiDetectionResponse response = uiDetectionServiceClient.ExecuteDetection(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteDetectionAsync</summary>
        public async Task ExecuteDetectionRequestObjectAsync()
        {
            // Snippet: ExecuteDetectionAsync(UiDetectionRequest, CallSettings)
            // Additional: ExecuteDetectionAsync(UiDetectionRequest, CancellationToken)
            // Create client
            UiDetectionServiceClient uiDetectionServiceClient = await UiDetectionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UiDetectionRequest request = new UiDetectionRequest
            {
                ImagePng = ByteString.Empty,
                Request = new DetectionRequest(),
            };
            // Make the request
            UiDetectionResponse response = await uiDetectionServiceClient.ExecuteDetectionAsync(request);
            // End snippet
        }
    }
}
