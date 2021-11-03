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
    using Google.Ads.GoogleAds.V9.Enums;
    using Google.Ads.GoogleAds.V9.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedFeedItemTargetServiceClientSnippets
    {
        /// <summary>Snippet for GetFeedItemTarget</summary>
        public void GetFeedItemTargetRequestObject()
        {
            // Snippet: GetFeedItemTarget(GetFeedItemTargetRequest, CallSettings)
            // Create client
            FeedItemTargetServiceClient feedItemTargetServiceClient = FeedItemTargetServiceClient.Create();
            // Initialize request argument(s)
            GetFeedItemTargetRequest request = new GetFeedItemTargetRequest
            {
                ResourceNameAsFeedItemTargetName = FeedItemTargetName.FromCustomerFeedFeedItemFeedItemTargetTypeFeedItemTarget("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]", "[FEED_ITEM_TARGET_TYPE]", "[FEED_ITEM_TARGET_ID]"),
            };
            // Make the request
            FeedItemTarget response = feedItemTargetServiceClient.GetFeedItemTarget(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemTargetAsync</summary>
        public async Task GetFeedItemTargetRequestObjectAsync()
        {
            // Snippet: GetFeedItemTargetAsync(GetFeedItemTargetRequest, CallSettings)
            // Additional: GetFeedItemTargetAsync(GetFeedItemTargetRequest, CancellationToken)
            // Create client
            FeedItemTargetServiceClient feedItemTargetServiceClient = await FeedItemTargetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeedItemTargetRequest request = new GetFeedItemTargetRequest
            {
                ResourceNameAsFeedItemTargetName = FeedItemTargetName.FromCustomerFeedFeedItemFeedItemTargetTypeFeedItemTarget("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]", "[FEED_ITEM_TARGET_TYPE]", "[FEED_ITEM_TARGET_ID]"),
            };
            // Make the request
            FeedItemTarget response = await feedItemTargetServiceClient.GetFeedItemTargetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemTarget</summary>
        public void GetFeedItemTarget()
        {
            // Snippet: GetFeedItemTarget(string, CallSettings)
            // Create client
            FeedItemTargetServiceClient feedItemTargetServiceClient = FeedItemTargetServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/feedItemTargets/[FEED_ID]~[FEED_ITEM_ID]~[FEED_ITEM_TARGET_TYPE]~[FEED_ITEM_TARGET_ID]";
            // Make the request
            FeedItemTarget response = feedItemTargetServiceClient.GetFeedItemTarget(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemTargetAsync</summary>
        public async Task GetFeedItemTargetAsync()
        {
            // Snippet: GetFeedItemTargetAsync(string, CallSettings)
            // Additional: GetFeedItemTargetAsync(string, CancellationToken)
            // Create client
            FeedItemTargetServiceClient feedItemTargetServiceClient = await FeedItemTargetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/feedItemTargets/[FEED_ID]~[FEED_ITEM_ID]~[FEED_ITEM_TARGET_TYPE]~[FEED_ITEM_TARGET_ID]";
            // Make the request
            FeedItemTarget response = await feedItemTargetServiceClient.GetFeedItemTargetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemTarget</summary>
        public void GetFeedItemTargetResourceNames()
        {
            // Snippet: GetFeedItemTarget(FeedItemTargetName, CallSettings)
            // Create client
            FeedItemTargetServiceClient feedItemTargetServiceClient = FeedItemTargetServiceClient.Create();
            // Initialize request argument(s)
            FeedItemTargetName resourceName = FeedItemTargetName.FromCustomerFeedFeedItemFeedItemTargetTypeFeedItemTarget("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]", "[FEED_ITEM_TARGET_TYPE]", "[FEED_ITEM_TARGET_ID]");
            // Make the request
            FeedItemTarget response = feedItemTargetServiceClient.GetFeedItemTarget(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedItemTargetAsync</summary>
        public async Task GetFeedItemTargetResourceNamesAsync()
        {
            // Snippet: GetFeedItemTargetAsync(FeedItemTargetName, CallSettings)
            // Additional: GetFeedItemTargetAsync(FeedItemTargetName, CancellationToken)
            // Create client
            FeedItemTargetServiceClient feedItemTargetServiceClient = await FeedItemTargetServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedItemTargetName resourceName = FeedItemTargetName.FromCustomerFeedFeedItemFeedItemTargetTypeFeedItemTarget("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]", "[FEED_ITEM_TARGET_TYPE]", "[FEED_ITEM_TARGET_ID]");
            // Make the request
            FeedItemTarget response = await feedItemTargetServiceClient.GetFeedItemTargetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItemTargets</summary>
        public void MutateFeedItemTargetsRequestObject()
        {
            // Snippet: MutateFeedItemTargets(MutateFeedItemTargetsRequest, CallSettings)
            // Create client
            FeedItemTargetServiceClient feedItemTargetServiceClient = FeedItemTargetServiceClient.Create();
            // Initialize request argument(s)
            MutateFeedItemTargetsRequest request = new MutateFeedItemTargetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new FeedItemTargetOperation(),
                },
                ValidateOnly = false,
                PartialFailure = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateFeedItemTargetsResponse response = feedItemTargetServiceClient.MutateFeedItemTargets(request);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItemTargetsAsync</summary>
        public async Task MutateFeedItemTargetsRequestObjectAsync()
        {
            // Snippet: MutateFeedItemTargetsAsync(MutateFeedItemTargetsRequest, CallSettings)
            // Additional: MutateFeedItemTargetsAsync(MutateFeedItemTargetsRequest, CancellationToken)
            // Create client
            FeedItemTargetServiceClient feedItemTargetServiceClient = await FeedItemTargetServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateFeedItemTargetsRequest request = new MutateFeedItemTargetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new FeedItemTargetOperation(),
                },
                ValidateOnly = false,
                PartialFailure = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateFeedItemTargetsResponse response = await feedItemTargetServiceClient.MutateFeedItemTargetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItemTargets</summary>
        public void MutateFeedItemTargets()
        {
            // Snippet: MutateFeedItemTargets(string, IEnumerable<FeedItemTargetOperation>, CallSettings)
            // Create client
            FeedItemTargetServiceClient feedItemTargetServiceClient = FeedItemTargetServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<FeedItemTargetOperation> operations = new FeedItemTargetOperation[]
            {
                new FeedItemTargetOperation(),
            };
            // Make the request
            MutateFeedItemTargetsResponse response = feedItemTargetServiceClient.MutateFeedItemTargets(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedItemTargetsAsync</summary>
        public async Task MutateFeedItemTargetsAsync()
        {
            // Snippet: MutateFeedItemTargetsAsync(string, IEnumerable<FeedItemTargetOperation>, CallSettings)
            // Additional: MutateFeedItemTargetsAsync(string, IEnumerable<FeedItemTargetOperation>, CancellationToken)
            // Create client
            FeedItemTargetServiceClient feedItemTargetServiceClient = await FeedItemTargetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<FeedItemTargetOperation> operations = new FeedItemTargetOperation[]
            {
                new FeedItemTargetOperation(),
            };
            // Make the request
            MutateFeedItemTargetsResponse response = await feedItemTargetServiceClient.MutateFeedItemTargetsAsync(customerId, operations);
            // End snippet
        }
    }
}
