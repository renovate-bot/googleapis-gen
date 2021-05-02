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
    public sealed class GeneratedCampaignCriterionServiceClientSnippets
    {
        /// <summary>Snippet for GetCampaignCriterion</summary>
        public void GetCampaignCriterionRequestObject()
        {
            // Snippet: GetCampaignCriterion(GetCampaignCriterionRequest, CallSettings)
            // Create client
            CampaignCriterionServiceClient campaignCriterionServiceClient = CampaignCriterionServiceClient.Create();
            // Initialize request argument(s)
            GetCampaignCriterionRequest request = new GetCampaignCriterionRequest
            {
                ResourceNameAsCampaignCriterionName = CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            CampaignCriterion response = campaignCriterionServiceClient.GetCampaignCriterion(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignCriterionAsync</summary>
        public async Task GetCampaignCriterionRequestObjectAsync()
        {
            // Snippet: GetCampaignCriterionAsync(GetCampaignCriterionRequest, CallSettings)
            // Additional: GetCampaignCriterionAsync(GetCampaignCriterionRequest, CancellationToken)
            // Create client
            CampaignCriterionServiceClient campaignCriterionServiceClient = await CampaignCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCampaignCriterionRequest request = new GetCampaignCriterionRequest
            {
                ResourceNameAsCampaignCriterionName = CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            CampaignCriterion response = await campaignCriterionServiceClient.GetCampaignCriterionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignCriterion</summary>
        public void GetCampaignCriterion()
        {
            // Snippet: GetCampaignCriterion(string, CallSettings)
            // Create client
            CampaignCriterionServiceClient campaignCriterionServiceClient = CampaignCriterionServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaignCriteria/[CAMPAIGN_ID]~[CRITERION_ID]";
            // Make the request
            CampaignCriterion response = campaignCriterionServiceClient.GetCampaignCriterion(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignCriterionAsync</summary>
        public async Task GetCampaignCriterionAsync()
        {
            // Snippet: GetCampaignCriterionAsync(string, CallSettings)
            // Additional: GetCampaignCriterionAsync(string, CancellationToken)
            // Create client
            CampaignCriterionServiceClient campaignCriterionServiceClient = await CampaignCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaignCriteria/[CAMPAIGN_ID]~[CRITERION_ID]";
            // Make the request
            CampaignCriterion response = await campaignCriterionServiceClient.GetCampaignCriterionAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignCriterion</summary>
        public void GetCampaignCriterionResourceNames()
        {
            // Snippet: GetCampaignCriterion(CampaignCriterionName, CallSettings)
            // Create client
            CampaignCriterionServiceClient campaignCriterionServiceClient = CampaignCriterionServiceClient.Create();
            // Initialize request argument(s)
            CampaignCriterionName resourceName = CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]");
            // Make the request
            CampaignCriterion response = campaignCriterionServiceClient.GetCampaignCriterion(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignCriterionAsync</summary>
        public async Task GetCampaignCriterionResourceNamesAsync()
        {
            // Snippet: GetCampaignCriterionAsync(CampaignCriterionName, CallSettings)
            // Additional: GetCampaignCriterionAsync(CampaignCriterionName, CancellationToken)
            // Create client
            CampaignCriterionServiceClient campaignCriterionServiceClient = await CampaignCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CampaignCriterionName resourceName = CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]");
            // Make the request
            CampaignCriterion response = await campaignCriterionServiceClient.GetCampaignCriterionAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignCriteria</summary>
        public void MutateCampaignCriteriaRequestObject()
        {
            // Snippet: MutateCampaignCriteria(MutateCampaignCriteriaRequest, CallSettings)
            // Create client
            CampaignCriterionServiceClient campaignCriterionServiceClient = CampaignCriterionServiceClient.Create();
            // Initialize request argument(s)
            MutateCampaignCriteriaRequest request = new MutateCampaignCriteriaRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignCriteriaResponse response = campaignCriterionServiceClient.MutateCampaignCriteria(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignCriteriaAsync</summary>
        public async Task MutateCampaignCriteriaRequestObjectAsync()
        {
            // Snippet: MutateCampaignCriteriaAsync(MutateCampaignCriteriaRequest, CallSettings)
            // Additional: MutateCampaignCriteriaAsync(MutateCampaignCriteriaRequest, CancellationToken)
            // Create client
            CampaignCriterionServiceClient campaignCriterionServiceClient = await CampaignCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCampaignCriteriaRequest request = new MutateCampaignCriteriaRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignCriteriaResponse response = await campaignCriterionServiceClient.MutateCampaignCriteriaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignCriteria</summary>
        public void MutateCampaignCriteria()
        {
            // Snippet: MutateCampaignCriteria(string, IEnumerable<CampaignCriterionOperation>, CallSettings)
            // Create client
            CampaignCriterionServiceClient campaignCriterionServiceClient = CampaignCriterionServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignCriterionOperation> operations = new CampaignCriterionOperation[]
            {
                new CampaignCriterionOperation(),
            };
            // Make the request
            MutateCampaignCriteriaResponse response = campaignCriterionServiceClient.MutateCampaignCriteria(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignCriteriaAsync</summary>
        public async Task MutateCampaignCriteriaAsync()
        {
            // Snippet: MutateCampaignCriteriaAsync(string, IEnumerable<CampaignCriterionOperation>, CallSettings)
            // Additional: MutateCampaignCriteriaAsync(string, IEnumerable<CampaignCriterionOperation>, CancellationToken)
            // Create client
            CampaignCriterionServiceClient campaignCriterionServiceClient = await CampaignCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignCriterionOperation> operations = new CampaignCriterionOperation[]
            {
                new CampaignCriterionOperation(),
            };
            // Make the request
            MutateCampaignCriteriaResponse response = await campaignCriterionServiceClient.MutateCampaignCriteriaAsync(customerId, operations);
            // End snippet
        }
    }
}
