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
    using Google.Ads.GoogleAds.V7.Enums;
    using Google.Ads.GoogleAds.V7.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCampaignBidModifierServiceClientSnippets
    {
        /// <summary>Snippet for GetCampaignBidModifier</summary>
        public void GetCampaignBidModifierRequestObject()
        {
            // Snippet: GetCampaignBidModifier(GetCampaignBidModifierRequest, CallSettings)
            // Create client
            CampaignBidModifierServiceClient campaignBidModifierServiceClient = CampaignBidModifierServiceClient.Create();
            // Initialize request argument(s)
            GetCampaignBidModifierRequest request = new GetCampaignBidModifierRequest
            {
                ResourceNameAsCampaignBidModifierName = CampaignBidModifierName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            CampaignBidModifier response = campaignBidModifierServiceClient.GetCampaignBidModifier(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignBidModifierAsync</summary>
        public async Task GetCampaignBidModifierRequestObjectAsync()
        {
            // Snippet: GetCampaignBidModifierAsync(GetCampaignBidModifierRequest, CallSettings)
            // Additional: GetCampaignBidModifierAsync(GetCampaignBidModifierRequest, CancellationToken)
            // Create client
            CampaignBidModifierServiceClient campaignBidModifierServiceClient = await CampaignBidModifierServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCampaignBidModifierRequest request = new GetCampaignBidModifierRequest
            {
                ResourceNameAsCampaignBidModifierName = CampaignBidModifierName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            CampaignBidModifier response = await campaignBidModifierServiceClient.GetCampaignBidModifierAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignBidModifier</summary>
        public void GetCampaignBidModifier()
        {
            // Snippet: GetCampaignBidModifier(string, CallSettings)
            // Create client
            CampaignBidModifierServiceClient campaignBidModifierServiceClient = CampaignBidModifierServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaignBidModifiers/[CAMPAIGN_ID]~[CRITERION_ID]";
            // Make the request
            CampaignBidModifier response = campaignBidModifierServiceClient.GetCampaignBidModifier(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignBidModifierAsync</summary>
        public async Task GetCampaignBidModifierAsync()
        {
            // Snippet: GetCampaignBidModifierAsync(string, CallSettings)
            // Additional: GetCampaignBidModifierAsync(string, CancellationToken)
            // Create client
            CampaignBidModifierServiceClient campaignBidModifierServiceClient = await CampaignBidModifierServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaignBidModifiers/[CAMPAIGN_ID]~[CRITERION_ID]";
            // Make the request
            CampaignBidModifier response = await campaignBidModifierServiceClient.GetCampaignBidModifierAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignBidModifier</summary>
        public void GetCampaignBidModifierResourceNames()
        {
            // Snippet: GetCampaignBidModifier(CampaignBidModifierName, CallSettings)
            // Create client
            CampaignBidModifierServiceClient campaignBidModifierServiceClient = CampaignBidModifierServiceClient.Create();
            // Initialize request argument(s)
            CampaignBidModifierName resourceName = CampaignBidModifierName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]");
            // Make the request
            CampaignBidModifier response = campaignBidModifierServiceClient.GetCampaignBidModifier(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignBidModifierAsync</summary>
        public async Task GetCampaignBidModifierResourceNamesAsync()
        {
            // Snippet: GetCampaignBidModifierAsync(CampaignBidModifierName, CallSettings)
            // Additional: GetCampaignBidModifierAsync(CampaignBidModifierName, CancellationToken)
            // Create client
            CampaignBidModifierServiceClient campaignBidModifierServiceClient = await CampaignBidModifierServiceClient.CreateAsync();
            // Initialize request argument(s)
            CampaignBidModifierName resourceName = CampaignBidModifierName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]");
            // Make the request
            CampaignBidModifier response = await campaignBidModifierServiceClient.GetCampaignBidModifierAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignBidModifiers</summary>
        public void MutateCampaignBidModifiersRequestObject()
        {
            // Snippet: MutateCampaignBidModifiers(MutateCampaignBidModifiersRequest, CallSettings)
            // Create client
            CampaignBidModifierServiceClient campaignBidModifierServiceClient = CampaignBidModifierServiceClient.Create();
            // Initialize request argument(s)
            MutateCampaignBidModifiersRequest request = new MutateCampaignBidModifiersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignBidModifierOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignBidModifiersResponse response = campaignBidModifierServiceClient.MutateCampaignBidModifiers(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignBidModifiersAsync</summary>
        public async Task MutateCampaignBidModifiersRequestObjectAsync()
        {
            // Snippet: MutateCampaignBidModifiersAsync(MutateCampaignBidModifiersRequest, CallSettings)
            // Additional: MutateCampaignBidModifiersAsync(MutateCampaignBidModifiersRequest, CancellationToken)
            // Create client
            CampaignBidModifierServiceClient campaignBidModifierServiceClient = await CampaignBidModifierServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCampaignBidModifiersRequest request = new MutateCampaignBidModifiersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignBidModifierOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignBidModifiersResponse response = await campaignBidModifierServiceClient.MutateCampaignBidModifiersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignBidModifiers</summary>
        public void MutateCampaignBidModifiers()
        {
            // Snippet: MutateCampaignBidModifiers(string, IEnumerable<CampaignBidModifierOperation>, CallSettings)
            // Create client
            CampaignBidModifierServiceClient campaignBidModifierServiceClient = CampaignBidModifierServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignBidModifierOperation> operations = new CampaignBidModifierOperation[]
            {
                new CampaignBidModifierOperation(),
            };
            // Make the request
            MutateCampaignBidModifiersResponse response = campaignBidModifierServiceClient.MutateCampaignBidModifiers(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignBidModifiersAsync</summary>
        public async Task MutateCampaignBidModifiersAsync()
        {
            // Snippet: MutateCampaignBidModifiersAsync(string, IEnumerable<CampaignBidModifierOperation>, CallSettings)
            // Additional: MutateCampaignBidModifiersAsync(string, IEnumerable<CampaignBidModifierOperation>, CancellationToken)
            // Create client
            CampaignBidModifierServiceClient campaignBidModifierServiceClient = await CampaignBidModifierServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignBidModifierOperation> operations = new CampaignBidModifierOperation[]
            {
                new CampaignBidModifierOperation(),
            };
            // Make the request
            MutateCampaignBidModifiersResponse response = await campaignBidModifierServiceClient.MutateCampaignBidModifiersAsync(customerId, operations);
            // End snippet
        }
    }
}
