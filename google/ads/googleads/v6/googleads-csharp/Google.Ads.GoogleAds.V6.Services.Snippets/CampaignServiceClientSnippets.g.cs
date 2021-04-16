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
    using Google.Ads.GoogleAds.V6.Enums;
    using Google.Ads.GoogleAds.V6.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCampaignServiceClientSnippets
    {
        /// <summary>Snippet for GetCampaign</summary>
        public void GetCampaignRequestObject()
        {
            // Snippet: GetCampaign(GetCampaignRequest, CallSettings)
            // Create client
            CampaignServiceClient campaignServiceClient = CampaignServiceClient.Create();
            // Initialize request argument(s)
            GetCampaignRequest request = new GetCampaignRequest
            {
                ResourceNameAsCampaignName = CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            // Make the request
            Campaign response = campaignServiceClient.GetCampaign(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignAsync</summary>
        public async Task GetCampaignRequestObjectAsync()
        {
            // Snippet: GetCampaignAsync(GetCampaignRequest, CallSettings)
            // Additional: GetCampaignAsync(GetCampaignRequest, CancellationToken)
            // Create client
            CampaignServiceClient campaignServiceClient = await CampaignServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCampaignRequest request = new GetCampaignRequest
            {
                ResourceNameAsCampaignName = CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            // Make the request
            Campaign response = await campaignServiceClient.GetCampaignAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaign</summary>
        public void GetCampaign()
        {
            // Snippet: GetCampaign(string, CallSettings)
            // Create client
            CampaignServiceClient campaignServiceClient = CampaignServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaigns/[CAMPAIGN_ID]";
            // Make the request
            Campaign response = campaignServiceClient.GetCampaign(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignAsync</summary>
        public async Task GetCampaignAsync()
        {
            // Snippet: GetCampaignAsync(string, CallSettings)
            // Additional: GetCampaignAsync(string, CancellationToken)
            // Create client
            CampaignServiceClient campaignServiceClient = await CampaignServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaigns/[CAMPAIGN_ID]";
            // Make the request
            Campaign response = await campaignServiceClient.GetCampaignAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaign</summary>
        public void GetCampaignResourceNames()
        {
            // Snippet: GetCampaign(CampaignName, CallSettings)
            // Create client
            CampaignServiceClient campaignServiceClient = CampaignServiceClient.Create();
            // Initialize request argument(s)
            CampaignName resourceName = CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]");
            // Make the request
            Campaign response = campaignServiceClient.GetCampaign(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignAsync</summary>
        public async Task GetCampaignResourceNamesAsync()
        {
            // Snippet: GetCampaignAsync(CampaignName, CallSettings)
            // Additional: GetCampaignAsync(CampaignName, CancellationToken)
            // Create client
            CampaignServiceClient campaignServiceClient = await CampaignServiceClient.CreateAsync();
            // Initialize request argument(s)
            CampaignName resourceName = CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]");
            // Make the request
            Campaign response = await campaignServiceClient.GetCampaignAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaigns</summary>
        public void MutateCampaignsRequestObject()
        {
            // Snippet: MutateCampaigns(MutateCampaignsRequest, CallSettings)
            // Create client
            CampaignServiceClient campaignServiceClient = CampaignServiceClient.Create();
            // Initialize request argument(s)
            MutateCampaignsRequest request = new MutateCampaignsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignsResponse response = campaignServiceClient.MutateCampaigns(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignsAsync</summary>
        public async Task MutateCampaignsRequestObjectAsync()
        {
            // Snippet: MutateCampaignsAsync(MutateCampaignsRequest, CallSettings)
            // Additional: MutateCampaignsAsync(MutateCampaignsRequest, CancellationToken)
            // Create client
            CampaignServiceClient campaignServiceClient = await CampaignServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCampaignsRequest request = new MutateCampaignsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignsResponse response = await campaignServiceClient.MutateCampaignsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaigns</summary>
        public void MutateCampaigns()
        {
            // Snippet: MutateCampaigns(string, IEnumerable<CampaignOperation>, CallSettings)
            // Create client
            CampaignServiceClient campaignServiceClient = CampaignServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignOperation> operations = new CampaignOperation[]
            {
                new CampaignOperation(),
            };
            // Make the request
            MutateCampaignsResponse response = campaignServiceClient.MutateCampaigns(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignsAsync</summary>
        public async Task MutateCampaignsAsync()
        {
            // Snippet: MutateCampaignsAsync(string, IEnumerable<CampaignOperation>, CallSettings)
            // Additional: MutateCampaignsAsync(string, IEnumerable<CampaignOperation>, CancellationToken)
            // Create client
            CampaignServiceClient campaignServiceClient = await CampaignServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignOperation> operations = new CampaignOperation[]
            {
                new CampaignOperation(),
            };
            // Make the request
            MutateCampaignsResponse response = await campaignServiceClient.MutateCampaignsAsync(customerId, operations);
            // End snippet
        }
    }
}
