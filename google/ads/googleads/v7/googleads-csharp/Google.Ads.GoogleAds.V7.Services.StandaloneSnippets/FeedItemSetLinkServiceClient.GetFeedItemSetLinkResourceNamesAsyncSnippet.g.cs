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

namespace Google.Ads.GoogleAds.V7.Services.Snippets
{
    using Google.Ads.GoogleAds.V7.Resources;
    using System.Threading.Tasks;

    public sealed partial class GeneratedFeedItemSetLinkServiceClientStandaloneSnippets
    {
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
    }
}
