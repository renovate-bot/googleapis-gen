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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedBiddingStrategyServiceClientSnippets
    {
        /// <summary>Snippet for GetBiddingStrategy</summary>
        public void GetBiddingStrategyRequestObject()
        {
            // Snippet: GetBiddingStrategy(GetBiddingStrategyRequest, CallSettings)
            // Create client
            BiddingStrategyServiceClient biddingStrategyServiceClient = BiddingStrategyServiceClient.Create();
            // Initialize request argument(s)
            GetBiddingStrategyRequest request = new GetBiddingStrategyRequest
            {
                ResourceNameAsBiddingStrategyName = BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
            };
            // Make the request
            BiddingStrategy response = biddingStrategyServiceClient.GetBiddingStrategy(request);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingStrategyAsync</summary>
        public async Task GetBiddingStrategyRequestObjectAsync()
        {
            // Snippet: GetBiddingStrategyAsync(GetBiddingStrategyRequest, CallSettings)
            // Additional: GetBiddingStrategyAsync(GetBiddingStrategyRequest, CancellationToken)
            // Create client
            BiddingStrategyServiceClient biddingStrategyServiceClient = await BiddingStrategyServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBiddingStrategyRequest request = new GetBiddingStrategyRequest
            {
                ResourceNameAsBiddingStrategyName = BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
            };
            // Make the request
            BiddingStrategy response = await biddingStrategyServiceClient.GetBiddingStrategyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingStrategy</summary>
        public void GetBiddingStrategy()
        {
            // Snippet: GetBiddingStrategy(string, CallSettings)
            // Create client
            BiddingStrategyServiceClient biddingStrategyServiceClient = BiddingStrategyServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/biddingStrategies/[BIDDING_STRATEGY]";
            // Make the request
            BiddingStrategy response = biddingStrategyServiceClient.GetBiddingStrategy(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingStrategyAsync</summary>
        public async Task GetBiddingStrategyAsync()
        {
            // Snippet: GetBiddingStrategyAsync(string, CallSettings)
            // Additional: GetBiddingStrategyAsync(string, CancellationToken)
            // Create client
            BiddingStrategyServiceClient biddingStrategyServiceClient = await BiddingStrategyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/biddingStrategies/[BIDDING_STRATEGY]";
            // Make the request
            BiddingStrategy response = await biddingStrategyServiceClient.GetBiddingStrategyAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingStrategy</summary>
        public void GetBiddingStrategyResourceNames()
        {
            // Snippet: GetBiddingStrategy(BiddingStrategyName, CallSettings)
            // Create client
            BiddingStrategyServiceClient biddingStrategyServiceClient = BiddingStrategyServiceClient.Create();
            // Initialize request argument(s)
            BiddingStrategyName resourceName = BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]");
            // Make the request
            BiddingStrategy response = biddingStrategyServiceClient.GetBiddingStrategy(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingStrategyAsync</summary>
        public async Task GetBiddingStrategyResourceNamesAsync()
        {
            // Snippet: GetBiddingStrategyAsync(BiddingStrategyName, CallSettings)
            // Additional: GetBiddingStrategyAsync(BiddingStrategyName, CancellationToken)
            // Create client
            BiddingStrategyServiceClient biddingStrategyServiceClient = await BiddingStrategyServiceClient.CreateAsync();
            // Initialize request argument(s)
            BiddingStrategyName resourceName = BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]");
            // Make the request
            BiddingStrategy response = await biddingStrategyServiceClient.GetBiddingStrategyAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateBiddingStrategies</summary>
        public void MutateBiddingStrategiesRequestObject()
        {
            // Snippet: MutateBiddingStrategies(MutateBiddingStrategiesRequest, CallSettings)
            // Create client
            BiddingStrategyServiceClient biddingStrategyServiceClient = BiddingStrategyServiceClient.Create();
            // Initialize request argument(s)
            MutateBiddingStrategiesRequest request = new MutateBiddingStrategiesRequest
            {
                CustomerId = "",
                Operations =
                {
                    new BiddingStrategyOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateBiddingStrategiesResponse response = biddingStrategyServiceClient.MutateBiddingStrategies(request);
            // End snippet
        }

        /// <summary>Snippet for MutateBiddingStrategiesAsync</summary>
        public async Task MutateBiddingStrategiesRequestObjectAsync()
        {
            // Snippet: MutateBiddingStrategiesAsync(MutateBiddingStrategiesRequest, CallSettings)
            // Additional: MutateBiddingStrategiesAsync(MutateBiddingStrategiesRequest, CancellationToken)
            // Create client
            BiddingStrategyServiceClient biddingStrategyServiceClient = await BiddingStrategyServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateBiddingStrategiesRequest request = new MutateBiddingStrategiesRequest
            {
                CustomerId = "",
                Operations =
                {
                    new BiddingStrategyOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateBiddingStrategiesResponse response = await biddingStrategyServiceClient.MutateBiddingStrategiesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateBiddingStrategies</summary>
        public void MutateBiddingStrategies()
        {
            // Snippet: MutateBiddingStrategies(string, IEnumerable<BiddingStrategyOperation>, CallSettings)
            // Create client
            BiddingStrategyServiceClient biddingStrategyServiceClient = BiddingStrategyServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<BiddingStrategyOperation> operations = new BiddingStrategyOperation[]
            {
                new BiddingStrategyOperation(),
            };
            // Make the request
            MutateBiddingStrategiesResponse response = biddingStrategyServiceClient.MutateBiddingStrategies(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateBiddingStrategiesAsync</summary>
        public async Task MutateBiddingStrategiesAsync()
        {
            // Snippet: MutateBiddingStrategiesAsync(string, IEnumerable<BiddingStrategyOperation>, CallSettings)
            // Additional: MutateBiddingStrategiesAsync(string, IEnumerable<BiddingStrategyOperation>, CancellationToken)
            // Create client
            BiddingStrategyServiceClient biddingStrategyServiceClient = await BiddingStrategyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<BiddingStrategyOperation> operations = new BiddingStrategyOperation[]
            {
                new BiddingStrategyOperation(),
            };
            // Make the request
            MutateBiddingStrategiesResponse response = await biddingStrategyServiceClient.MutateBiddingStrategiesAsync(customerId, operations);
            // End snippet
        }
    }
}
