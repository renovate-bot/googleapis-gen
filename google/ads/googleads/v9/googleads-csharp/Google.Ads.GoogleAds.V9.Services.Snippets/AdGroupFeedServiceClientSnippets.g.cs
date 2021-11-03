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
    public sealed class GeneratedAdGroupFeedServiceClientSnippets
    {
        /// <summary>Snippet for GetAdGroupFeed</summary>
        public void GetAdGroupFeedRequestObject()
        {
            // Snippet: GetAdGroupFeed(GetAdGroupFeedRequest, CallSettings)
            // Create client
            AdGroupFeedServiceClient adGroupFeedServiceClient = AdGroupFeedServiceClient.Create();
            // Initialize request argument(s)
            GetAdGroupFeedRequest request = new GetAdGroupFeedRequest
            {
                ResourceNameAsAdGroupFeedName = AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[FEED_ID]"),
            };
            // Make the request
            AdGroupFeed response = adGroupFeedServiceClient.GetAdGroupFeed(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupFeedAsync</summary>
        public async Task GetAdGroupFeedRequestObjectAsync()
        {
            // Snippet: GetAdGroupFeedAsync(GetAdGroupFeedRequest, CallSettings)
            // Additional: GetAdGroupFeedAsync(GetAdGroupFeedRequest, CancellationToken)
            // Create client
            AdGroupFeedServiceClient adGroupFeedServiceClient = await AdGroupFeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdGroupFeedRequest request = new GetAdGroupFeedRequest
            {
                ResourceNameAsAdGroupFeedName = AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[FEED_ID]"),
            };
            // Make the request
            AdGroupFeed response = await adGroupFeedServiceClient.GetAdGroupFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupFeed</summary>
        public void GetAdGroupFeed()
        {
            // Snippet: GetAdGroupFeed(string, CallSettings)
            // Create client
            AdGroupFeedServiceClient adGroupFeedServiceClient = AdGroupFeedServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupFeeds/[AD_GROUP_ID]~[FEED_ID]";
            // Make the request
            AdGroupFeed response = adGroupFeedServiceClient.GetAdGroupFeed(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupFeedAsync</summary>
        public async Task GetAdGroupFeedAsync()
        {
            // Snippet: GetAdGroupFeedAsync(string, CallSettings)
            // Additional: GetAdGroupFeedAsync(string, CancellationToken)
            // Create client
            AdGroupFeedServiceClient adGroupFeedServiceClient = await AdGroupFeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupFeeds/[AD_GROUP_ID]~[FEED_ID]";
            // Make the request
            AdGroupFeed response = await adGroupFeedServiceClient.GetAdGroupFeedAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupFeed</summary>
        public void GetAdGroupFeedResourceNames()
        {
            // Snippet: GetAdGroupFeed(AdGroupFeedName, CallSettings)
            // Create client
            AdGroupFeedServiceClient adGroupFeedServiceClient = AdGroupFeedServiceClient.Create();
            // Initialize request argument(s)
            AdGroupFeedName resourceName = AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[FEED_ID]");
            // Make the request
            AdGroupFeed response = adGroupFeedServiceClient.GetAdGroupFeed(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupFeedAsync</summary>
        public async Task GetAdGroupFeedResourceNamesAsync()
        {
            // Snippet: GetAdGroupFeedAsync(AdGroupFeedName, CallSettings)
            // Additional: GetAdGroupFeedAsync(AdGroupFeedName, CancellationToken)
            // Create client
            AdGroupFeedServiceClient adGroupFeedServiceClient = await AdGroupFeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdGroupFeedName resourceName = AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[FEED_ID]");
            // Make the request
            AdGroupFeed response = await adGroupFeedServiceClient.GetAdGroupFeedAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupFeeds</summary>
        public void MutateAdGroupFeedsRequestObject()
        {
            // Snippet: MutateAdGroupFeeds(MutateAdGroupFeedsRequest, CallSettings)
            // Create client
            AdGroupFeedServiceClient adGroupFeedServiceClient = AdGroupFeedServiceClient.Create();
            // Initialize request argument(s)
            MutateAdGroupFeedsRequest request = new MutateAdGroupFeedsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupFeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdGroupFeedsResponse response = adGroupFeedServiceClient.MutateAdGroupFeeds(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupFeedsAsync</summary>
        public async Task MutateAdGroupFeedsRequestObjectAsync()
        {
            // Snippet: MutateAdGroupFeedsAsync(MutateAdGroupFeedsRequest, CallSettings)
            // Additional: MutateAdGroupFeedsAsync(MutateAdGroupFeedsRequest, CancellationToken)
            // Create client
            AdGroupFeedServiceClient adGroupFeedServiceClient = await AdGroupFeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAdGroupFeedsRequest request = new MutateAdGroupFeedsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupFeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdGroupFeedsResponse response = await adGroupFeedServiceClient.MutateAdGroupFeedsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupFeeds</summary>
        public void MutateAdGroupFeeds()
        {
            // Snippet: MutateAdGroupFeeds(string, IEnumerable<AdGroupFeedOperation>, CallSettings)
            // Create client
            AdGroupFeedServiceClient adGroupFeedServiceClient = AdGroupFeedServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupFeedOperation> operations = new AdGroupFeedOperation[]
            {
                new AdGroupFeedOperation(),
            };
            // Make the request
            MutateAdGroupFeedsResponse response = adGroupFeedServiceClient.MutateAdGroupFeeds(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupFeedsAsync</summary>
        public async Task MutateAdGroupFeedsAsync()
        {
            // Snippet: MutateAdGroupFeedsAsync(string, IEnumerable<AdGroupFeedOperation>, CallSettings)
            // Additional: MutateAdGroupFeedsAsync(string, IEnumerable<AdGroupFeedOperation>, CancellationToken)
            // Create client
            AdGroupFeedServiceClient adGroupFeedServiceClient = await AdGroupFeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupFeedOperation> operations = new AdGroupFeedOperation[]
            {
                new AdGroupFeedOperation(),
            };
            // Make the request
            MutateAdGroupFeedsResponse response = await adGroupFeedServiceClient.MutateAdGroupFeedsAsync(customerId, operations);
            // End snippet
        }
    }
}
