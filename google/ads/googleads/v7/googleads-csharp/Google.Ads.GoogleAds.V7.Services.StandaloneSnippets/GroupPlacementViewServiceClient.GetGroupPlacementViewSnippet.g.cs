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

namespace Google.Ads.GoogleAds.V7.Services.Snippets
{
    using Google.Ads.GoogleAds.V7.Resources;

    public sealed partial class GeneratedGroupPlacementViewServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetGroupPlacementView</summary>
        public void GetGroupPlacementView()
        {
            // Snippet: GetGroupPlacementView(string, CallSettings)
            // Create client
            GroupPlacementViewServiceClient groupPlacementViewServiceClient = GroupPlacementViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/groupPlacementViews/[AD_GROUP_ID]~[BASE64_PLACEMENT]";
            // Make the request
            GroupPlacementView response = groupPlacementViewServiceClient.GetGroupPlacementView(resourceName);
            // End snippet
        }
    }
}
