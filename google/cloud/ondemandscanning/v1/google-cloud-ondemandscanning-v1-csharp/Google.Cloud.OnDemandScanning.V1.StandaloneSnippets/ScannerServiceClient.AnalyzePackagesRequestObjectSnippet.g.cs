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

namespace Google.Cloud.OnDemandScanning.V1.Snippets
{
    using CloudContainers.Workflow.Analysis.Vulnerability.Proto;
    using Google.Cloud.OnDemandScanning.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedScannerServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for AnalyzePackages</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void AnalyzePackagesRequestObject()
        {
            // Create client
            ScannerServiceClient scannerServiceClient = ScannerServiceClient.Create();
            // Initialize request argument(s)
            AnalyzePackagesRequest request = new AnalyzePackagesRequest
            {
                Parent = "",
                ResourceUri = "",
                Packages = { new PackageData(), },
            };
            // Make the request
            Operation<AnalyzePackagesResponse, AnalyzePackagesMetadata> response = scannerServiceClient.AnalyzePackages(request);

            // Poll until the returned long-running operation is complete
            Operation<AnalyzePackagesResponse, AnalyzePackagesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnalyzePackagesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnalyzePackagesResponse, AnalyzePackagesMetadata> retrievedResponse = scannerServiceClient.PollOnceAnalyzePackages(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnalyzePackagesResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
}
