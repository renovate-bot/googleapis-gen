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

namespace Google.Ads.GoogleAds.V5.Services.Snippets
{
    using Google.Ads.GoogleAds.V5.Resources;
    using System.Threading.Tasks;

    public sealed partial class GeneratedManagedPlacementViewServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetManagedPlacementViewAsync</summary>
        public async Task GetManagedPlacementViewResourceNamesAsync()
        {
            // Snippet: GetManagedPlacementViewAsync(ManagedPlacementViewName, CallSettings)
            // Additional: GetManagedPlacementViewAsync(ManagedPlacementViewName, CancellationToken)
            // Create client
            ManagedPlacementViewServiceClient managedPlacementViewServiceClient = await ManagedPlacementViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            ManagedPlacementViewName resourceName = ManagedPlacementViewName.FromCustomerManagedPlacementView("[CUSTOMER]", "[MANAGED_PLACEMENT_VIEW]");
            // Make the request
            ManagedPlacementView response = await managedPlacementViewServiceClient.GetManagedPlacementViewAsync(resourceName);
            // End snippet
        }
    }
}
