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
    using Google.Ads.GoogleAds.V8.Enums;
    using Google.Ads.GoogleAds.V8.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCampaignFeedServiceClientSnippets
    {
        /// <summary>Snippet for GetCampaignFeed</summary>
        public void GetCampaignFeedRequestObject()
        {
            // Snippet: GetCampaignFeed(GetCampaignFeedRequest, CallSettings)
            // Create client
            CampaignFeedServiceClient campaignFeedServiceClient = CampaignFeedServiceClient.Create();
            // Initialize request argument(s)
            GetCampaignFeedRequest request = new GetCampaignFeedRequest
            {
                ResourceNameAsCampaignFeedName = CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[FEED_ID]"),
            };
            // Make the request
            CampaignFeed response = campaignFeedServiceClient.GetCampaignFeed(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignFeedAsync</summary>
        public async Task GetCampaignFeedRequestObjectAsync()
        {
            // Snippet: GetCampaignFeedAsync(GetCampaignFeedRequest, CallSettings)
            // Additional: GetCampaignFeedAsync(GetCampaignFeedRequest, CancellationToken)
            // Create client
            CampaignFeedServiceClient campaignFeedServiceClient = await CampaignFeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCampaignFeedRequest request = new GetCampaignFeedRequest
            {
                ResourceNameAsCampaignFeedName = CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[FEED_ID]"),
            };
            // Make the request
            CampaignFeed response = await campaignFeedServiceClient.GetCampaignFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignFeed</summary>
        public void GetCampaignFeed()
        {
            // Snippet: GetCampaignFeed(string, CallSettings)
            // Create client
            CampaignFeedServiceClient campaignFeedServiceClient = CampaignFeedServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaignFeeds/[CAMPAIGN_ID]~[FEED_ID]";
            // Make the request
            CampaignFeed response = campaignFeedServiceClient.GetCampaignFeed(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignFeedAsync</summary>
        public async Task GetCampaignFeedAsync()
        {
            // Snippet: GetCampaignFeedAsync(string, CallSettings)
            // Additional: GetCampaignFeedAsync(string, CancellationToken)
            // Create client
            CampaignFeedServiceClient campaignFeedServiceClient = await CampaignFeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaignFeeds/[CAMPAIGN_ID]~[FEED_ID]";
            // Make the request
            CampaignFeed response = await campaignFeedServiceClient.GetCampaignFeedAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignFeed</summary>
        public void GetCampaignFeedResourceNames()
        {
            // Snippet: GetCampaignFeed(CampaignFeedName, CallSettings)
            // Create client
            CampaignFeedServiceClient campaignFeedServiceClient = CampaignFeedServiceClient.Create();
            // Initialize request argument(s)
            CampaignFeedName resourceName = CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[FEED_ID]");
            // Make the request
            CampaignFeed response = campaignFeedServiceClient.GetCampaignFeed(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignFeedAsync</summary>
        public async Task GetCampaignFeedResourceNamesAsync()
        {
            // Snippet: GetCampaignFeedAsync(CampaignFeedName, CallSettings)
            // Additional: GetCampaignFeedAsync(CampaignFeedName, CancellationToken)
            // Create client
            CampaignFeedServiceClient campaignFeedServiceClient = await CampaignFeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            CampaignFeedName resourceName = CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[FEED_ID]");
            // Make the request
            CampaignFeed response = await campaignFeedServiceClient.GetCampaignFeedAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignFeeds</summary>
        public void MutateCampaignFeedsRequestObject()
        {
            // Snippet: MutateCampaignFeeds(MutateCampaignFeedsRequest, CallSettings)
            // Create client
            CampaignFeedServiceClient campaignFeedServiceClient = CampaignFeedServiceClient.Create();
            // Initialize request argument(s)
            MutateCampaignFeedsRequest request = new MutateCampaignFeedsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignFeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignFeedsResponse response = campaignFeedServiceClient.MutateCampaignFeeds(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignFeedsAsync</summary>
        public async Task MutateCampaignFeedsRequestObjectAsync()
        {
            // Snippet: MutateCampaignFeedsAsync(MutateCampaignFeedsRequest, CallSettings)
            // Additional: MutateCampaignFeedsAsync(MutateCampaignFeedsRequest, CancellationToken)
            // Create client
            CampaignFeedServiceClient campaignFeedServiceClient = await CampaignFeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCampaignFeedsRequest request = new MutateCampaignFeedsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignFeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignFeedsResponse response = await campaignFeedServiceClient.MutateCampaignFeedsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignFeeds</summary>
        public void MutateCampaignFeeds()
        {
            // Snippet: MutateCampaignFeeds(string, IEnumerable<CampaignFeedOperation>, CallSettings)
            // Create client
            CampaignFeedServiceClient campaignFeedServiceClient = CampaignFeedServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignFeedOperation> operations = new CampaignFeedOperation[]
            {
                new CampaignFeedOperation(),
            };
            // Make the request
            MutateCampaignFeedsResponse response = campaignFeedServiceClient.MutateCampaignFeeds(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignFeedsAsync</summary>
        public async Task MutateCampaignFeedsAsync()
        {
            // Snippet: MutateCampaignFeedsAsync(string, IEnumerable<CampaignFeedOperation>, CallSettings)
            // Additional: MutateCampaignFeedsAsync(string, IEnumerable<CampaignFeedOperation>, CancellationToken)
            // Create client
            CampaignFeedServiceClient campaignFeedServiceClient = await CampaignFeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignFeedOperation> operations = new CampaignFeedOperation[]
            {
                new CampaignFeedOperation(),
            };
            // Make the request
            MutateCampaignFeedsResponse response = await campaignFeedServiceClient.MutateCampaignFeedsAsync(customerId, operations);
            // End snippet
        }
    }
}
