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
    using System.Threading.Tasks;

    public sealed partial class GeneratedFeedItemSetLinkServiceClientStandaloneSnippets
    {
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
    }
}
