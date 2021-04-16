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
    using System.Threading.Tasks;

    public sealed partial class GeneratedWebSecurityScannerClientStandaloneSnippets
    {
        /// <summary>Snippet for ListFindingTypeStatsAsync</summary>
        public async Task ListFindingTypeStatsResourceNamesAsync()
        {
            // Snippet: ListFindingTypeStatsAsync(ScanRunName, CallSettings)
            // Additional: ListFindingTypeStatsAsync(ScanRunName, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ScanRunName parent = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]");
            // Make the request
            ListFindingTypeStatsResponse response = await webSecurityScannerClient.ListFindingTypeStatsAsync(parent);
            // End snippet
        }
    }
}
