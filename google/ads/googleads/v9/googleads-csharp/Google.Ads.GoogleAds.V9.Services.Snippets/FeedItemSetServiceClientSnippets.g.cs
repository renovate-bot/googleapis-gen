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

namespace Google.Ads.GoogleAds.V9.Services.Snippets
{
    using Google.Ads.GoogleAds.V9.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedFeedItemSetServiceClientSnippets
    {
        /// <summary>Snippet for GetFeedItemSet</summary>
        public void GetFeedItemSetRequestObject()
        {
            // Snippet: GetFeedItemSet(GetFeedItemSetRequest, CallSettings)
            // Create client
            FeedItemSetServiceClient feedItemSetServiceClient = FeedItemSetServiceClient.Create();
            // Initialize request argument(s)
            GetFeedItemSetRequest request = new GetFeedItemSetRequest
            {
                ResourceNameAsFeedItemSetName = FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
            };
            // Make the request
            FeedItemSet response = feedItemSetServiceClient.GetFeedItemSet(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemSetAsync</summary>
        public async Task GetFeedItemSetRequestObjectAsync()
        {
            // Snippet: GetFeedItemSetAsync(GetFeedItemSetRequest, CallSettings)
            // Additional: GetFeedItemSetAsync(GetFeedItemSetRequest, CancellationToken)
            // Create client
            FeedItemSetServiceClient feedItemSetServiceClient = await FeedItemSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeedItemSetRequest request = new GetFeedItemSetRequest
            {
                ResourceNameAsFeedItemSetName = FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
            };
            // Make the request
            FeedItemSet response = await feedItemSetServiceClient.GetFeedItemSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemSet</summary>
        public void GetFeedItemSet()
        {
            // Snippet: GetFeedItemSet(string, CallSettings)
            // Create client
            FeedItemSetServiceClient feedItemSetServiceClient = FeedItemSetServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/feedItemSets/[FEED_ID]~[FEED_ITEM_SET_ID]";
            // Make the request
            FeedItemSet response = feedItemSetServiceClient.GetFeedItemSet(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemSetAsync</summary>
        public async Task GetFeedItemSetAsync()
        {
            // Snippet: GetFeedItemSetAsync(string, CallSettings)
            // Additional: GetFeedItemSetAsync(string, CancellationToken)
            // Create client
            FeedItemSetServiceClient feedItemSetServiceClient = await FeedItemSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/feedItemSets/[FEED_ID]~[FEED_ITEM_SET_ID]";
            // Make the request
            FeedItemSet response = await feedItemSetServiceClient.GetFeedItemSetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemSet</summary>
        public void GetFeedItemSetResourceNames()
        {
            // Snippet: GetFeedItemSet(FeedItemSetName, CallSettings)
            // Create client
            FeedItemSetServiceClient feedItemSetServiceClient = FeedItemSetServiceClient.Create();
            // Initialize request argument(s)
            FeedItemSetName resourceName = FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]");
            // Make the request
            FeedItemSet response = feedItemSetServiceClient.GetFeedItemSet(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemSetAsync</summary>
        public async Task GetFeedItemSetResourceNamesAsync()
        {
            // Snippet: GetFeedItemSetAsync(FeedItemSetName, CallSettings)
            // Additional: GetFeedItemSetAsync(FeedItemSetName, CancellationToken)
            // Create client
            FeedItemSetServiceClient feedItemSetServiceClient = await FeedItemSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedItemSetName resourceName = FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]");
            // Make the request
            FeedItemSet response = await feedItemSetServiceClient.GetFeedItemSetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItemSets</summary>
        public void MutateFeedItemSetsRequestObject()
        {
            // Snippet: MutateFeedItemSets(MutateFeedItemSetsRequest, CallSettings)
            // Create client
            FeedItemSetServiceClient feedItemSetServiceClient = FeedItemSetServiceClient.Create();
            // Initialize request argument(s)
            MutateFeedItemSetsRequest request = new MutateFeedItemSetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new FeedItemSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateFeedItemSetsResponse response = feedItemSetServiceClient.MutateFeedItemSets(request);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItemSetsAsync</summary>
        public async Task MutateFeedItemSetsRequestObjectAsync()
        {
            // Snippet: MutateFeedItemSetsAsync(MutateFeedItemSetsRequest, CallSettings)
            // Additional: MutateFeedItemSetsAsync(MutateFeedItemSetsRequest, CancellationToken)
            // Create client
            FeedItemSetServiceClient feedItemSetServiceClient = await FeedItemSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateFeedItemSetsRequest request = new MutateFeedItemSetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new FeedItemSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateFeedItemSetsResponse response = await feedItemSetServiceClient.MutateFeedItemSetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItemSets</summary>
        public void MutateFeedItemSets()
        {
            // Snippet: MutateFeedItemSets(string, IEnumerable<FeedItemSetOperation>, CallSettings)
            // Create client
            FeedItemSetServiceClient feedItemSetServiceClient = FeedItemSetServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<FeedItemSetOperation> operations = new FeedItemSetOperation[]
            {
                new FeedItemSetOperation(),
            };
            // Make the request
            MutateFeedItemSetsResponse response = feedItemSetServiceClient.MutateFeedItemSets(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItemSetsAsync</summary>
        public async Task MutateFeedItemSetsAsync()
        {
            // Snippet: MutateFeedItemSetsAsync(string, IEnumerable<FeedItemSetOperation>, CallSettings)
            // Additional: MutateFeedItemSetsAsync(string, IEnumerable<FeedItemSetOperation>, CancellationToken)
            // Create client
            FeedItemSetServiceClient feedItemSetServiceClient = await FeedItemSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<FeedItemSetOperation> operations = new FeedItemSetOperation[]
            {
                new FeedItemSetOperation(),
            };
            // Make the request
            MutateFeedItemSetsResponse response = await feedItemSetServiceClient.MutateFeedItemSetsAsync(customerId, operations);
            // End snippet
        }
    }
}
