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
    public sealed class GeneratedCampaignBudgetServiceClientSnippets
    {
        /// <summary>Snippet for GetCampaignBudget</summary>
        public void GetCampaignBudgetRequestObject()
        {
            // Snippet: GetCampaignBudget(GetCampaignBudgetRequest, CallSettings)
            // Create client
            CampaignBudgetServiceClient campaignBudgetServiceClient = CampaignBudgetServiceClient.Create();
            // Initialize request argument(s)
            GetCampaignBudgetRequest request = new GetCampaignBudgetRequest
            {
                ResourceNameAsCampaignBudgetName = CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER]", "[CAMPAIGN_BUDGET]"),
            };
            // Make the request
            CampaignBudget response = campaignBudgetServiceClient.GetCampaignBudget(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignBudgetAsync</summary>
        public async Task GetCampaignBudgetRequestObjectAsync()
        {
            // Snippet: GetCampaignBudgetAsync(GetCampaignBudgetRequest, CallSettings)
            // Additional: GetCampaignBudgetAsync(GetCampaignBudgetRequest, CancellationToken)
            // Create client
            CampaignBudgetServiceClient campaignBudgetServiceClient = await CampaignBudgetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCampaignBudgetRequest request = new GetCampaignBudgetRequest
            {
                ResourceNameAsCampaignBudgetName = CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER]", "[CAMPAIGN_BUDGET]"),
            };
            // Make the request
            CampaignBudget response = await campaignBudgetServiceClient.GetCampaignBudgetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignBudget</summary>
        public void GetCampaignBudget()
        {
            // Snippet: GetCampaignBudget(string, CallSettings)
            // Create client
            CampaignBudgetServiceClient campaignBudgetServiceClient = CampaignBudgetServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/campaignBudgets/[CAMPAIGN_BUDGET]";
            // Make the request
            CampaignBudget response = campaignBudgetServiceClient.GetCampaignBudget(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignBudgetAsync</summary>
        public async Task GetCampaignBudgetAsync()
        {
            // Snippet: GetCampaignBudgetAsync(string, CallSettings)
            // Additional: GetCampaignBudgetAsync(string, CancellationToken)
            // Create client
            CampaignBudgetServiceClient campaignBudgetServiceClient = await CampaignBudgetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/campaignBudgets/[CAMPAIGN_BUDGET]";
            // Make the request
            CampaignBudget response = await campaignBudgetServiceClient.GetCampaignBudgetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignBudget</summary>
        public void GetCampaignBudgetResourceNames()
        {
            // Snippet: GetCampaignBudget(CampaignBudgetName, CallSettings)
            // Create client
            CampaignBudgetServiceClient campaignBudgetServiceClient = CampaignBudgetServiceClient.Create();
            // Initialize request argument(s)
            CampaignBudgetName resourceName = CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER]", "[CAMPAIGN_BUDGET]");
            // Make the request
            CampaignBudget response = campaignBudgetServiceClient.GetCampaignBudget(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignBudgetAsync</summary>
        public async Task GetCampaignBudgetResourceNamesAsync()
        {
            // Snippet: GetCampaignBudgetAsync(CampaignBudgetName, CallSettings)
            // Additional: GetCampaignBudgetAsync(CampaignBudgetName, CancellationToken)
            // Create client
            CampaignBudgetServiceClient campaignBudgetServiceClient = await CampaignBudgetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CampaignBudgetName resourceName = CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER]", "[CAMPAIGN_BUDGET]");
            // Make the request
            CampaignBudget response = await campaignBudgetServiceClient.GetCampaignBudgetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignBudgets</summary>
        public void MutateCampaignBudgetsRequestObject()
        {
            // Snippet: MutateCampaignBudgets(MutateCampaignBudgetsRequest, CallSettings)
            // Create client
            CampaignBudgetServiceClient campaignBudgetServiceClient = CampaignBudgetServiceClient.Create();
            // Initialize request argument(s)
            MutateCampaignBudgetsRequest request = new MutateCampaignBudgetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignBudgetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateCampaignBudgetsResponse response = campaignBudgetServiceClient.MutateCampaignBudgets(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignBudgetsAsync</summary>
        public async Task MutateCampaignBudgetsRequestObjectAsync()
        {
            // Snippet: MutateCampaignBudgetsAsync(MutateCampaignBudgetsRequest, CallSettings)
            // Additional: MutateCampaignBudgetsAsync(MutateCampaignBudgetsRequest, CancellationToken)
            // Create client
            CampaignBudgetServiceClient campaignBudgetServiceClient = await CampaignBudgetServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCampaignBudgetsRequest request = new MutateCampaignBudgetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignBudgetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateCampaignBudgetsResponse response = await campaignBudgetServiceClient.MutateCampaignBudgetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignBudgets</summary>
        public void MutateCampaignBudgets()
        {
            // Snippet: MutateCampaignBudgets(string, IEnumerable<CampaignBudgetOperation>, CallSettings)
            // Create client
            CampaignBudgetServiceClient campaignBudgetServiceClient = CampaignBudgetServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignBudgetOperation> operations = new CampaignBudgetOperation[]
            {
                new CampaignBudgetOperation(),
            };
            // Make the request
            MutateCampaignBudgetsResponse response = campaignBudgetServiceClient.MutateCampaignBudgets(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignBudgetsAsync</summary>
        public async Task MutateCampaignBudgetsAsync()
        {
            // Snippet: MutateCampaignBudgetsAsync(string, IEnumerable<CampaignBudgetOperation>, CallSettings)
            // Additional: MutateCampaignBudgetsAsync(string, IEnumerable<CampaignBudgetOperation>, CancellationToken)
            // Create client
            CampaignBudgetServiceClient campaignBudgetServiceClient = await CampaignBudgetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignBudgetOperation> operations = new CampaignBudgetOperation[]
            {
                new CampaignBudgetOperation(),
            };
            // Make the request
            MutateCampaignBudgetsResponse response = await campaignBudgetServiceClient.MutateCampaignBudgetsAsync(customerId, operations);
            // End snippet
        }
    }
}
