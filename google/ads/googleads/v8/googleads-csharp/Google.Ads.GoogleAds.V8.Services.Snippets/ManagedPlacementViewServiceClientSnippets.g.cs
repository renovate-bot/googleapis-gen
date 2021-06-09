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

namespace Google.Ads.GoogleAds.V8.Services.Snippets
{
    using Google.Ads.GoogleAds.V8.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedManagedPlacementViewServiceClientSnippets
    {
        /// <summary>Snippet for GetManagedPlacementView</summary>
        public void GetManagedPlacementViewRequestObject()
        {
            // Snippet: GetManagedPlacementView(GetManagedPlacementViewRequest, CallSettings)
            // Create client
            ManagedPlacementViewServiceClient managedPlacementViewServiceClient = ManagedPlacementViewServiceClient.Create();
            // Initialize request argument(s)
            GetManagedPlacementViewRequest request = new GetManagedPlacementViewRequest
            {
                ResourceNameAsManagedPlacementViewName = ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            ManagedPlacementView response = managedPlacementViewServiceClient.GetManagedPlacementView(request);
            // End snippet
        }

        /// <summary>Snippet for GetManagedPlacementViewAsync</summary>
        public async Task GetManagedPlacementViewRequestObjectAsync()
        {
            // Snippet: GetManagedPlacementViewAsync(GetManagedPlacementViewRequest, CallSettings)
            // Additional: GetManagedPlacementViewAsync(GetManagedPlacementViewRequest, CancellationToken)
            // Create client
            ManagedPlacementViewServiceClient managedPlacementViewServiceClient = await ManagedPlacementViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetManagedPlacementViewRequest request = new GetManagedPlacementViewRequest
            {
                ResourceNameAsManagedPlacementViewName = ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            ManagedPlacementView response = await managedPlacementViewServiceClient.GetManagedPlacementViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetManagedPlacementView</summary>
        public void GetManagedPlacementView()
        {
            // Snippet: GetManagedPlacementView(string, CallSettings)
            // Create client
            ManagedPlacementViewServiceClient managedPlacementViewServiceClient = ManagedPlacementViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/managedPlacementViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            ManagedPlacementView response = managedPlacementViewServiceClient.GetManagedPlacementView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetManagedPlacementViewAsync</summary>
        public async Task GetManagedPlacementViewAsync()
        {
            // Snippet: GetManagedPlacementViewAsync(string, CallSettings)
            // Additional: GetManagedPlacementViewAsync(string, CancellationToken)
            // Create client
            ManagedPlacementViewServiceClient managedPlacementViewServiceClient = await ManagedPlacementViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/managedPlacementViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            ManagedPlacementView response = await managedPlacementViewServiceClient.GetManagedPlacementViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetManagedPlacementView</summary>
        public void GetManagedPlacementViewResourceNames()
        {
            // Snippet: GetManagedPlacementView(ManagedPlacementViewName, CallSettings)
            // Create client
            ManagedPlacementViewServiceClient managedPlacementViewServiceClient = ManagedPlacementViewServiceClient.Create();
            // Initialize request argument(s)
            ManagedPlacementViewName resourceName = ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            ManagedPlacementView response = managedPlacementViewServiceClient.GetManagedPlacementView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetManagedPlacementViewAsync</summary>
        public async Task GetManagedPlacementViewResourceNamesAsync()
        {
            // Snippet: GetManagedPlacementViewAsync(ManagedPlacementViewName, CallSettings)
            // Additional: GetManagedPlacementViewAsync(ManagedPlacementViewName, CancellationToken)
            // Create client
            ManagedPlacementViewServiceClient managedPlacementViewServiceClient = await ManagedPlacementViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            ManagedPlacementViewName resourceName = ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            ManagedPlacementView response = await managedPlacementViewServiceClient.GetManagedPlacementViewAsync(resourceName);
            // End snippet
        }
    }
}
