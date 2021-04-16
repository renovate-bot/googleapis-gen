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

namespace Google.Ads.GoogleAds.V4.Services.Snippets
{
    using Google.Ads.GoogleAds.V4.Resources;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGroupPlacementViewServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetGroupPlacementViewAsync</summary>
        public async Task GetGroupPlacementViewAsync()
        {
            // Snippet: GetGroupPlacementViewAsync(string, CallSettings)
            // Additional: GetGroupPlacementViewAsync(string, CancellationToken)
            // Create client
            GroupPlacementViewServiceClient groupPlacementViewServiceClient = await GroupPlacementViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/groupPlacementViews/[GROUP_PLACEMENT_VIEW]";
            // Make the request
            GroupPlacementView response = await groupPlacementViewServiceClient.GetGroupPlacementViewAsync(resourceName);
            // End snippet
        }
    }
}
