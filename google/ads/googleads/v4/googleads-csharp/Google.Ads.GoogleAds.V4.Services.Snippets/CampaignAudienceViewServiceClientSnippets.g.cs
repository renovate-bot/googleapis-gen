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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCampaignAudienceViewServiceClientSnippets
    {
        /// <summary>Snippet for GetCampaignAudienceView</summary>
        public void GetCampaignAudienceViewRequestObject()
        {
            // Snippet: GetCampaignAudienceView(GetCampaignAudienceViewRequest, CallSettings)
            // Create client
            CampaignAudienceViewServiceClient campaignAudienceViewServiceClient = CampaignAudienceViewServiceClient.Create();
            // Initialize request argument(s)
            GetCampaignAudienceViewRequest request = new GetCampaignAudienceViewRequest
            {
                ResourceNameAsCampaignAudienceViewName = CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]"),
            };
            // Make the request
            CampaignAudienceView response = campaignAudienceViewServiceClient.GetCampaignAudienceView(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignAudienceViewAsync</summary>
        public async Task GetCampaignAudienceViewRequestObjectAsync()
        {
            // Snippet: GetCampaignAudienceViewAsync(GetCampaignAudienceViewRequest, CallSettings)
            // Additional: GetCampaignAudienceViewAsync(GetCampaignAudienceViewRequest, CancellationToken)
            // Create client
            CampaignAudienceViewServiceClient campaignAudienceViewServiceClient = await CampaignAudienceViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCampaignAudienceViewRequest request = new GetCampaignAudienceViewRequest
            {
                ResourceNameAsCampaignAudienceViewName = CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]"),
            };
            // Make the request
            CampaignAudienceView response = await campaignAudienceViewServiceClient.GetCampaignAudienceViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignAudienceView</summary>
        public void GetCampaignAudienceView()
        {
            // Snippet: GetCampaignAudienceView(string, CallSettings)
            // Create client
            CampaignAudienceViewServiceClient campaignAudienceViewServiceClient = CampaignAudienceViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/campaignAudienceViews/[CAMPAIGN_AUDIENCE_VIEW]";
            // Make the request
            CampaignAudienceView response = campaignAudienceViewServiceClient.GetCampaignAudienceView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignAudienceViewAsync</summary>
        public async Task GetCampaignAudienceViewAsync()
        {
            // Snippet: GetCampaignAudienceViewAsync(string, CallSettings)
            // Additional: GetCampaignAudienceViewAsync(string, CancellationToken)
            // Create client
            CampaignAudienceViewServiceClient campaignAudienceViewServiceClient = await CampaignAudienceViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/campaignAudienceViews/[CAMPAIGN_AUDIENCE_VIEW]";
            // Make the request
            CampaignAudienceView response = await campaignAudienceViewServiceClient.GetCampaignAudienceViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignAudienceView</summary>
        public void GetCampaignAudienceViewResourceNames()
        {
            // Snippet: GetCampaignAudienceView(CampaignAudienceViewName, CallSettings)
            // Create client
            CampaignAudienceViewServiceClient campaignAudienceViewServiceClient = CampaignAudienceViewServiceClient.Create();
            // Initialize request argument(s)
            CampaignAudienceViewName resourceName = CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]");
            // Make the request
            CampaignAudienceView response = campaignAudienceViewServiceClient.GetCampaignAudienceView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignAudienceViewAsync</summary>
        public async Task GetCampaignAudienceViewResourceNamesAsync()
        {
            // Snippet: GetCampaignAudienceViewAsync(CampaignAudienceViewName, CallSettings)
            // Additional: GetCampaignAudienceViewAsync(CampaignAudienceViewName, CancellationToken)
            // Create client
            CampaignAudienceViewServiceClient campaignAudienceViewServiceClient = await CampaignAudienceViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            CampaignAudienceViewName resourceName = CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]");
            // Make the request
            CampaignAudienceView response = await campaignAudienceViewServiceClient.GetCampaignAudienceViewAsync(resourceName);
            // End snippet
        }
    }
}
