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
    using Google.Chromeos.Uidetection.V1;
    using Google.Protobuf;

    public sealed partial class GeneratedUiDetectionServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for ExecuteDetection</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ExecuteDetectionRequestObject()
        {
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
        }
    }
}
