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
    public sealed class GeneratedAccessibleBiddingStrategyServiceClientSnippets
    {
        /// <summary>Snippet for GetAccessibleBiddingStrategy</summary>
        public void GetAccessibleBiddingStrategyRequestObject()
        {
            // Snippet: GetAccessibleBiddingStrategy(GetAccessibleBiddingStrategyRequest, CallSettings)
            // Create client
            AccessibleBiddingStrategyServiceClient accessibleBiddingStrategyServiceClient = AccessibleBiddingStrategyServiceClient.Create();
            // Initialize request argument(s)
            GetAccessibleBiddingStrategyRequest request = new GetAccessibleBiddingStrategyRequest
            {
                ResourceNameAsAccessibleBiddingStrategyName = AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
            };
            // Make the request
            AccessibleBiddingStrategy response = accessibleBiddingStrategyServiceClient.GetAccessibleBiddingStrategy(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessibleBiddingStrategyAsync</summary>
        public async Task GetAccessibleBiddingStrategyRequestObjectAsync()
        {
            // Snippet: GetAccessibleBiddingStrategyAsync(GetAccessibleBiddingStrategyRequest, CallSettings)
            // Additional: GetAccessibleBiddingStrategyAsync(GetAccessibleBiddingStrategyRequest, CancellationToken)
            // Create client
            AccessibleBiddingStrategyServiceClient accessibleBiddingStrategyServiceClient = await AccessibleBiddingStrategyServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAccessibleBiddingStrategyRequest request = new GetAccessibleBiddingStrategyRequest
            {
                ResourceNameAsAccessibleBiddingStrategyName = AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
            };
            // Make the request
            AccessibleBiddingStrategy response = await accessibleBiddingStrategyServiceClient.GetAccessibleBiddingStrategyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessibleBiddingStrategy</summary>
        public void GetAccessibleBiddingStrategy()
        {
            // Snippet: GetAccessibleBiddingStrategy(string, CallSettings)
            // Create client
            AccessibleBiddingStrategyServiceClient accessibleBiddingStrategyServiceClient = AccessibleBiddingStrategyServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/accessibleBiddingStrategies/[BIDDING_STRATEGY_ID]";
            // Make the request
            AccessibleBiddingStrategy response = accessibleBiddingStrategyServiceClient.GetAccessibleBiddingStrategy(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAccessibleBiddingStrategyAsync</summary>
        public async Task GetAccessibleBiddingStrategyAsync()
        {
            // Snippet: GetAccessibleBiddingStrategyAsync(string, CallSettings)
            // Additional: GetAccessibleBiddingStrategyAsync(string, CancellationToken)
            // Create client
            AccessibleBiddingStrategyServiceClient accessibleBiddingStrategyServiceClient = await AccessibleBiddingStrategyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/accessibleBiddingStrategies/[BIDDING_STRATEGY_ID]";
            // Make the request
            AccessibleBiddingStrategy response = await accessibleBiddingStrategyServiceClient.GetAccessibleBiddingStrategyAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAccessibleBiddingStrategy</summary>
        public void GetAccessibleBiddingStrategyResourceNames()
        {
            // Snippet: GetAccessibleBiddingStrategy(AccessibleBiddingStrategyName, CallSettings)
            // Create client
            AccessibleBiddingStrategyServiceClient accessibleBiddingStrategyServiceClient = AccessibleBiddingStrategyServiceClient.Create();
            // Initialize request argument(s)
            AccessibleBiddingStrategyName resourceName = AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]");
            // Make the request
            AccessibleBiddingStrategy response = accessibleBiddingStrategyServiceClient.GetAccessibleBiddingStrategy(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAccessibleBiddingStrategyAsync</summary>
        public async Task GetAccessibleBiddingStrategyResourceNamesAsync()
        {
            // Snippet: GetAccessibleBiddingStrategyAsync(AccessibleBiddingStrategyName, CallSettings)
            // Additional: GetAccessibleBiddingStrategyAsync(AccessibleBiddingStrategyName, CancellationToken)
            // Create client
            AccessibleBiddingStrategyServiceClient accessibleBiddingStrategyServiceClient = await AccessibleBiddingStrategyServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccessibleBiddingStrategyName resourceName = AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]");
            // Make the request
            AccessibleBiddingStrategy response = await accessibleBiddingStrategyServiceClient.GetAccessibleBiddingStrategyAsync(resourceName);
            // End snippet
        }
    }
}
