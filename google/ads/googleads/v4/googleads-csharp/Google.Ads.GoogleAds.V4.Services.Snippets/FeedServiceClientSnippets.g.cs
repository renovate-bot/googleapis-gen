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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedFeedServiceClientSnippets
    {
        /// <summary>Snippet for GetFeed</summary>
        public void GetFeedRequestObject()
        {
            // Snippet: GetFeed(GetFeedRequest, CallSettings)
            // Create client
            FeedServiceClient feedServiceClient = FeedServiceClient.Create();
            // Initialize request argument(s)
            GetFeedRequest request = new GetFeedRequest
            {
                ResourceNameAsFeedName = FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
            };
            // Make the request
            Feed response = feedServiceClient.GetFeed(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedAsync</summary>
        public async Task GetFeedRequestObjectAsync()
        {
            // Snippet: GetFeedAsync(GetFeedRequest, CallSettings)
            // Additional: GetFeedAsync(GetFeedRequest, CancellationToken)
            // Create client
            FeedServiceClient feedServiceClient = await FeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeedRequest request = new GetFeedRequest
            {
                ResourceNameAsFeedName = FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
            };
            // Make the request
            Feed response = await feedServiceClient.GetFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeed</summary>
        public void GetFeed()
        {
            // Snippet: GetFeed(string, CallSettings)
            // Create client
            FeedServiceClient feedServiceClient = FeedServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/feeds/[FEED]";
            // Make the request
            Feed response = feedServiceClient.GetFeed(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedAsync</summary>
        public async Task GetFeedAsync()
        {
            // Snippet: GetFeedAsync(string, CallSettings)
            // Additional: GetFeedAsync(string, CancellationToken)
            // Create client
            FeedServiceClient feedServiceClient = await FeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/feeds/[FEED]";
            // Make the request
            Feed response = await feedServiceClient.GetFeedAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeed</summary>
        public void GetFeedResourceNames()
        {
            // Snippet: GetFeed(FeedName, CallSettings)
            // Create client
            FeedServiceClient feedServiceClient = FeedServiceClient.Create();
            // Initialize request argument(s)
            FeedName resourceName = FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]");
            // Make the request
            Feed response = feedServiceClient.GetFeed(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedAsync</summary>
        public async Task GetFeedResourceNamesAsync()
        {
            // Snippet: GetFeedAsync(FeedName, CallSettings)
            // Additional: GetFeedAsync(FeedName, CancellationToken)
            // Create client
            FeedServiceClient feedServiceClient = await FeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedName resourceName = FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]");
            // Make the request
            Feed response = await feedServiceClient.GetFeedAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateFeeds</summary>
        public void MutateFeedsRequestObject()
        {
            // Snippet: MutateFeeds(MutateFeedsRequest, CallSettings)
            // Create client
            FeedServiceClient feedServiceClient = FeedServiceClient.Create();
            // Initialize request argument(s)
            MutateFeedsRequest request = new MutateFeedsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new FeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateFeedsResponse response = feedServiceClient.MutateFeeds(request);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedsAsync</summary>
        public async Task MutateFeedsRequestObjectAsync()
        {
            // Snippet: MutateFeedsAsync(MutateFeedsRequest, CallSettings)
            // Additional: MutateFeedsAsync(MutateFeedsRequest, CancellationToken)
            // Create client
            FeedServiceClient feedServiceClient = await FeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateFeedsRequest request = new MutateFeedsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new FeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateFeedsResponse response = await feedServiceClient.MutateFeedsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateFeeds</summary>
        public void MutateFeeds()
        {
            // Snippet: MutateFeeds(string, IEnumerable<FeedOperation>, CallSettings)
            // Create client
            FeedServiceClient feedServiceClient = FeedServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<FeedOperation> operations = new FeedOperation[]
            {
                new FeedOperation(),
            };
            // Make the request
            MutateFeedsResponse response = feedServiceClient.MutateFeeds(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedsAsync</summary>
        public async Task MutateFeedsAsync()
        {
            // Snippet: MutateFeedsAsync(string, IEnumerable<FeedOperation>, CallSettings)
            // Additional: MutateFeedsAsync(string, IEnumerable<FeedOperation>, CancellationToken)
            // Create client
            FeedServiceClient feedServiceClient = await FeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<FeedOperation> operations = new FeedOperation[]
            {
                new FeedOperation(),
            };
            // Make the request
            MutateFeedsResponse response = await feedServiceClient.MutateFeedsAsync(customerId, operations);
            // End snippet
        }
    }
}
