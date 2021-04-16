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

namespace Google.Cloud.Websecurityscanner.V1Alpha.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedWebSecurityScannerClientStandaloneSnippets
    {
        /// <summary>Snippet for StopScanRunAsync</summary>
        public async Task StopScanRunResourceNamesAsync()
        {
            // Snippet: StopScanRunAsync(ScanRunName, CallSettings)
            // Additional: StopScanRunAsync(ScanRunName, CancellationToken)
            // Create client
            WebSecurityScannerClient webSecurityScannerClient = await WebSecurityScannerClient.CreateAsync();
            // Initialize request argument(s)
            ScanRunName name = ScanRunName.FromProjectScanConfigScanRun("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]");
            // Make the request
            ScanRun response = await webSecurityScannerClient.StopScanRunAsync(name);
            // End snippet
        }
    }
}
