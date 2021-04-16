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

namespace Google.Ads.GoogleAds.V6.Services.Snippets
{
    using Google.Ads.GoogleAds.V6.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedGroupPlacementViewServiceClientSnippets
    {
        /// <summary>Snippet for GetGroupPlacementView</summary>
        public void GetGroupPlacementViewRequestObject()
        {
            // Snippet: GetGroupPlacementView(GetGroupPlacementViewRequest, CallSettings)
            // Create client
            GroupPlacementViewServiceClient groupPlacementViewServiceClient = GroupPlacementViewServiceClient.Create();
            // Initialize request argument(s)
            GetGroupPlacementViewRequest request = new GetGroupPlacementViewRequest
            {
                ResourceNameAsGroupPlacementViewName = GroupPlacementViewName.FromCustomerAdGroupBase64Placement("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[BASE64_PLACEMENT]"),
            };
            // Make the request
            GroupPlacementView response = groupPlacementViewServiceClient.GetGroupPlacementView(request);
            // End snippet
        }

        /// <summary>Snippet for GetGroupPlacementViewAsync</summary>
        public async Task GetGroupPlacementViewRequestObjectAsync()
        {
            // Snippet: GetGroupPlacementViewAsync(GetGroupPlacementViewRequest, CallSettings)
            // Additional: GetGroupPlacementViewAsync(GetGroupPlacementViewRequest, CancellationToken)
            // Create client
            GroupPlacementViewServiceClient groupPlacementViewServiceClient = await GroupPlacementViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGroupPlacementViewRequest request = new GetGroupPlacementViewRequest
            {
                ResourceNameAsGroupPlacementViewName = GroupPlacementViewName.FromCustomerAdGroupBase64Placement("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[BASE64_PLACEMENT]"),
            };
            // Make the request
            GroupPlacementView response = await groupPlacementViewServiceClient.GetGroupPlacementViewAsync(request);
            // End snippet
        }

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

        /// <summary>Snippet for GetGroupPlacementViewAsync</summary>
        public async Task GetGroupPlacementViewAsync()
        {
            // Snippet: GetGroupPlacementViewAsync(string, CallSettings)
            // Additional: GetGroupPlacementViewAsync(string, CancellationToken)
            // Create client
            GroupPlacementViewServiceClient groupPlacementViewServiceClient = await GroupPlacementViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/groupPlacementViews/[AD_GROUP_ID]~[BASE64_PLACEMENT]";
            // Make the request
            GroupPlacementView response = await groupPlacementViewServiceClient.GetGroupPlacementViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetGroupPlacementView</summary>
        public void GetGroupPlacementViewResourceNames()
        {
            // Snippet: GetGroupPlacementView(GroupPlacementViewName, CallSettings)
            // Create client
            GroupPlacementViewServiceClient groupPlacementViewServiceClient = GroupPlacementViewServiceClient.Create();
            // Initialize request argument(s)
            GroupPlacementViewName resourceName = GroupPlacementViewName.FromCustomerAdGroupBase64Placement("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[BASE64_PLACEMENT]");
            // Make the request
            GroupPlacementView response = groupPlacementViewServiceClient.GetGroupPlacementView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetGroupPlacementViewAsync</summary>
        public async Task GetGroupPlacementViewResourceNamesAsync()
        {
            // Snippet: GetGroupPlacementViewAsync(GroupPlacementViewName, CallSettings)
            // Additional: GetGroupPlacementViewAsync(GroupPlacementViewName, CancellationToken)
            // Create client
            GroupPlacementViewServiceClient groupPlacementViewServiceClient = await GroupPlacementViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GroupPlacementViewName resourceName = GroupPlacementViewName.FromCustomerAdGroupBase64Placement("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[BASE64_PLACEMENT]");
            // Make the request
            GroupPlacementView response = await groupPlacementViewServiceClient.GetGroupPlacementViewAsync(resourceName);
            // End snippet
        }
    }
}
