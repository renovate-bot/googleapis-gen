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
    using Google.Ads.GoogleAds.V5.Enums;
    using Google.Ads.GoogleAds.V5.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedFeedItemServiceClientSnippets
    {
        /// <summary>Snippet for GetFeedItem</summary>
        public void GetFeedItemRequestObject()
        {
            // Snippet: GetFeedItem(GetFeedItemRequest, CallSettings)
            // Create client
            FeedItemServiceClient feedItemServiceClient = FeedItemServiceClient.Create();
            // Initialize request argument(s)
            GetFeedItemRequest request = new GetFeedItemRequest
            {
                ResourceNameAsFeedItemName = FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
            };
            // Make the request
            FeedItem response = feedItemServiceClient.GetFeedItem(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemAsync</summary>
        public async Task GetFeedItemRequestObjectAsync()
        {
            // Snippet: GetFeedItemAsync(GetFeedItemRequest, CallSettings)
            // Additional: GetFeedItemAsync(GetFeedItemRequest, CancellationToken)
            // Create client
            FeedItemServiceClient feedItemServiceClient = await FeedItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeedItemRequest request = new GetFeedItemRequest
            {
                ResourceNameAsFeedItemName = FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
            };
            // Make the request
            FeedItem response = await feedItemServiceClient.GetFeedItemAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItem</summary>
        public void GetFeedItem()
        {
            // Snippet: GetFeedItem(string, CallSettings)
            // Create client
            FeedItemServiceClient feedItemServiceClient = FeedItemServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/feedItems/[FEED_ITEM]";
            // Make the request
            FeedItem response = feedItemServiceClient.GetFeedItem(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemAsync</summary>
        public async Task GetFeedItemAsync()
        {
            // Snippet: GetFeedItemAsync(string, CallSettings)
            // Additional: GetFeedItemAsync(string, CancellationToken)
            // Create client
            FeedItemServiceClient feedItemServiceClient = await FeedItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/feedItems/[FEED_ITEM]";
            // Make the request
            FeedItem response = await feedItemServiceClient.GetFeedItemAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItem</summary>
        public void GetFeedItemResourceNames()
        {
            // Snippet: GetFeedItem(FeedItemName, CallSettings)
            // Create client
            FeedItemServiceClient feedItemServiceClient = FeedItemServiceClient.Create();
            // Initialize request argument(s)
            FeedItemName resourceName = FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]");
            // Make the request
            FeedItem response = feedItemServiceClient.GetFeedItem(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemAsync</summary>
        public async Task GetFeedItemResourceNamesAsync()
        {
            // Snippet: GetFeedItemAsync(FeedItemName, CallSettings)
            // Additional: GetFeedItemAsync(FeedItemName, CancellationToken)
            // Create client
            FeedItemServiceClient feedItemServiceClient = await FeedItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedItemName resourceName = FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]");
            // Make the request
            FeedItem response = await feedItemServiceClient.GetFeedItemAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItems</summary>
        public void MutateFeedItemsRequestObject()
        {
            // Snippet: MutateFeedItems(MutateFeedItemsRequest, CallSettings)
            // Create client
            FeedItemServiceClient feedItemServiceClient = FeedItemServiceClient.Create();
            // Initialize request argument(s)
            MutateFeedItemsRequest request = new MutateFeedItemsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new FeedItemOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateFeedItemsResponse response = feedItemServiceClient.MutateFeedItems(request);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItemsAsync</summary>
        public async Task MutateFeedItemsRequestObjectAsync()
        {
            // Snippet: MutateFeedItemsAsync(MutateFeedItemsRequest, CallSettings)
            // Additional: MutateFeedItemsAsync(MutateFeedItemsRequest, CancellationToken)
            // Create client
            FeedItemServiceClient feedItemServiceClient = await FeedItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateFeedItemsRequest request = new MutateFeedItemsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new FeedItemOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateFeedItemsResponse response = await feedItemServiceClient.MutateFeedItemsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItems</summary>
        public void MutateFeedItems()
        {
            // Snippet: MutateFeedItems(string, IEnumerable<FeedItemOperation>, CallSettings)
            // Create client
            FeedItemServiceClient feedItemServiceClient = FeedItemServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<FeedItemOperation> operations = new FeedItemOperation[]
            {
                new FeedItemOperation(),
            };
            // Make the request
            MutateFeedItemsResponse response = feedItemServiceClient.MutateFeedItems(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItemsAsync</summary>
        public async Task MutateFeedItemsAsync()
        {
            // Snippet: MutateFeedItemsAsync(string, IEnumerable<FeedItemOperation>, CallSettings)
            // Additional: MutateFeedItemsAsync(string, IEnumerable<FeedItemOperation>, CancellationToken)
            // Create client
            FeedItemServiceClient feedItemServiceClient = await FeedItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<FeedItemOperation> operations = new FeedItemOperation[]
            {
                new FeedItemOperation(),
            };
            // Make the request
            MutateFeedItemsResponse response = await feedItemServiceClient.MutateFeedItemsAsync(customerId, operations);
            // End snippet
        }
    }
}
