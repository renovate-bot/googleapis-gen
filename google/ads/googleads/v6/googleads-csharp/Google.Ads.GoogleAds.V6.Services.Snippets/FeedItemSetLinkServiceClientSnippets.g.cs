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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedFeedItemSetLinkServiceClientSnippets
    {
        /// <summary>Snippet for GetFeedItemSetLink</summary>
        public void GetFeedItemSetLinkRequestObject()
        {
            // Snippet: GetFeedItemSetLink(GetFeedItemSetLinkRequest, CallSettings)
            // Create client
            FeedItemSetLinkServiceClient feedItemSetLinkServiceClient = FeedItemSetLinkServiceClient.Create();
            // Initialize request argument(s)
            GetFeedItemSetLinkRequest request = new GetFeedItemSetLinkRequest
            {
                ResourceNameAsFeedItemSetLinkName = FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]"),
            };
            // Make the request
            FeedItemSetLink response = feedItemSetLinkServiceClient.GetFeedItemSetLink(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemSetLinkAsync</summary>
        public async Task GetFeedItemSetLinkRequestObjectAsync()
        {
            // Snippet: GetFeedItemSetLinkAsync(GetFeedItemSetLinkRequest, CallSettings)
            // Additional: GetFeedItemSetLinkAsync(GetFeedItemSetLinkRequest, CancellationToken)
            // Create client
            FeedItemSetLinkServiceClient feedItemSetLinkServiceClient = await FeedItemSetLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeedItemSetLinkRequest request = new GetFeedItemSetLinkRequest
            {
                ResourceNameAsFeedItemSetLinkName = FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]"),
            };
            // Make the request
            FeedItemSetLink response = await feedItemSetLinkServiceClient.GetFeedItemSetLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemSetLink</summary>
        public void GetFeedItemSetLink()
        {
            // Snippet: GetFeedItemSetLink(string, CallSettings)
            // Create client
            FeedItemSetLinkServiceClient feedItemSetLinkServiceClient = FeedItemSetLinkServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/feedItemSetLinks/[FEED_ID]~[FEED_ITEM_SET_ID]~[FEED_ITEM_ID]";
            // Make the request
            FeedItemSetLink response = feedItemSetLinkServiceClient.GetFeedItemSetLink(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemSetLinkAsync</summary>
        public async Task GetFeedItemSetLinkAsync()
        {
            // Snippet: GetFeedItemSetLinkAsync(string, CallSettings)
            // Additional: GetFeedItemSetLinkAsync(string, CancellationToken)
            // Create client
            FeedItemSetLinkServiceClient feedItemSetLinkServiceClient = await FeedItemSetLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/feedItemSetLinks/[FEED_ID]~[FEED_ITEM_SET_ID]~[FEED_ITEM_ID]";
            // Make the request
            FeedItemSetLink response = await feedItemSetLinkServiceClient.GetFeedItemSetLinkAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemSetLink</summary>
        public void GetFeedItemSetLinkResourceNames()
        {
            // Snippet: GetFeedItemSetLink(FeedItemSetLinkName, CallSettings)
            // Create client
            FeedItemSetLinkServiceClient feedItemSetLinkServiceClient = FeedItemSetLinkServiceClient.Create();
            // Initialize request argument(s)
            FeedItemSetLinkName resourceName = FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]");
            // Make the request
            FeedItemSetLink response = feedItemSetLinkServiceClient.GetFeedItemSetLink(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemSetLinkAsync</summary>
        public async Task GetFeedItemSetLinkResourceNamesAsync()
        {
            // Snippet: GetFeedItemSetLinkAsync(FeedItemSetLinkName, CallSettings)
            // Additional: GetFeedItemSetLinkAsync(FeedItemSetLinkName, CancellationToken)
            // Create client
            FeedItemSetLinkServiceClient feedItemSetLinkServiceClient = await FeedItemSetLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedItemSetLinkName resourceName = FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]");
            // Make the request
            FeedItemSetLink response = await feedItemSetLinkServiceClient.GetFeedItemSetLinkAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItemSetLinks</summary>
        public void MutateFeedItemSetLinksRequestObject()
        {
            // Snippet: MutateFeedItemSetLinks(MutateFeedItemSetLinksRequest, CallSettings)
            // Create client
            FeedItemSetLinkServiceClient feedItemSetLinkServiceClient = FeedItemSetLinkServiceClient.Create();
            // Initialize request argument(s)
            MutateFeedItemSetLinksRequest request = new MutateFeedItemSetLinksRequest
            {
                CustomerId = "",
                Operations =
                {
                    new FeedItemSetLinkOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateFeedItemSetLinksResponse response = feedItemSetLinkServiceClient.MutateFeedItemSetLinks(request);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItemSetLinksAsync</summary>
        public async Task MutateFeedItemSetLinksRequestObjectAsync()
        {
            // Snippet: MutateFeedItemSetLinksAsync(MutateFeedItemSetLinksRequest, CallSettings)
            // Additional: MutateFeedItemSetLinksAsync(MutateFeedItemSetLinksRequest, CancellationToken)
            // Create client
            FeedItemSetLinkServiceClient feedItemSetLinkServiceClient = await FeedItemSetLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateFeedItemSetLinksRequest request = new MutateFeedItemSetLinksRequest
            {
                CustomerId = "",
                Operations =
                {
                    new FeedItemSetLinkOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateFeedItemSetLinksResponse response = await feedItemSetLinkServiceClient.MutateFeedItemSetLinksAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItemSetLinks</summary>
        public void MutateFeedItemSetLinks()
        {
            // Snippet: MutateFeedItemSetLinks(string, IEnumerable<FeedItemSetLinkOperation>, CallSettings)
            // Create client
            FeedItemSetLinkServiceClient feedItemSetLinkServiceClient = FeedItemSetLinkServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<FeedItemSetLinkOperation> operations = new FeedItemSetLinkOperation[]
            {
                new FeedItemSetLinkOperation(),
            };
            // Make the request
            MutateFeedItemSetLinksResponse response = feedItemSetLinkServiceClient.MutateFeedItemSetLinks(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItemSetLinksAsync</summary>
        public async Task MutateFeedItemSetLinksAsync()
        {
            // Snippet: MutateFeedItemSetLinksAsync(string, IEnumerable<FeedItemSetLinkOperation>, CallSettings)
            // Additional: MutateFeedItemSetLinksAsync(string, IEnumerable<FeedItemSetLinkOperation>, CancellationToken)
            // Create client
            FeedItemSetLinkServiceClient feedItemSetLinkServiceClient = await FeedItemSetLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<FeedItemSetLinkOperation> operations = new FeedItemSetLinkOperation[]
            {
                new FeedItemSetLinkOperation(),
            };
            // Make the request
            MutateFeedItemSetLinksResponse response = await feedItemSetLinkServiceClient.MutateFeedItemSetLinksAsync(customerId, operations);
            // End snippet
        }
    }
}
