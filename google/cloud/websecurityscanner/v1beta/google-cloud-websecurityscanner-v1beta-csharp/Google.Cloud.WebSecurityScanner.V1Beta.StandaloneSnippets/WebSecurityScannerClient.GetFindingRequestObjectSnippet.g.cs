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

namespace Google.Cloud.WebSecurityScanner.V1Beta.Snippets
{
    using Google.Cloud.WebSecurityScanner.V1Beta;

    public sealed partial class GeneratedWebSecurityScannerClientStandaloneSnippets
    {
        /// <summary>Snippet for GetFinding</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetFindingRequestObject()
        {
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = WebSecurityScannerClient.Create();
            // Initialize request argument(s)
            GetFindingRequest request = new GetFindingRequest
            {
                FindingName = FindingName.FromProjectScanConfigScanRunFinding("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]", "[FINDING]"),
            };
            // Make the request
            Finding response = webSecurityScannerClient.GetFinding(request);
        }
    }
}
