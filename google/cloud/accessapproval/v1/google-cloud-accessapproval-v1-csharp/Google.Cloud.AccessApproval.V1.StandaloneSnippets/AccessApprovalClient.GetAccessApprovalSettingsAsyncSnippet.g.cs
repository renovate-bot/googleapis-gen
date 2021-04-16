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

namespace Google.Cloud.AccessApproval.V1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedAccessApprovalClientStandaloneSnippets
    {
        /// <summary>Snippet for GetAccessApprovalSettingsAsync</summary>
        public async Task GetAccessApprovalSettingsAsync()
        {
            // Snippet: GetAccessApprovalSettingsAsync(string, CallSettings)
            // Additional: GetAccessApprovalSettingsAsync(string, CancellationToken)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            AccessApprovalSettings response = await accessApprovalClient.GetAccessApprovalSettingsAsync(name);
            // End snippet
        }
    }
}
