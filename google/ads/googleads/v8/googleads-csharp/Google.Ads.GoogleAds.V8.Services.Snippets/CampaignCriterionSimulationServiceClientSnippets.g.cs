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
    using Google.Ads.GoogleAds.V8.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCampaignCriterionSimulationServiceClientSnippets
    {
        /// <summary>Snippet for GetCampaignCriterionSimulation</summary>
        public void GetCampaignCriterionSimulationRequestObject()
        {
            // Snippet: GetCampaignCriterionSimulation(GetCampaignCriterionSimulationRequest, CallSettings)
            // Create client
            CampaignCriterionSimulationServiceClient campaignCriterionSimulationServiceClient = CampaignCriterionSimulationServiceClient.Create();
            // Initialize request argument(s)
            GetCampaignCriterionSimulationRequest request = new GetCampaignCriterionSimulationRequest
            {
                ResourceNameAsCampaignCriterionSimulationName = CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            // Make the request
            CampaignCriterionSimulation response = campaignCriterionSimulationServiceClient.GetCampaignCriterionSimulation(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignCriterionSimulationAsync</summary>
        public async Task GetCampaignCriterionSimulationRequestObjectAsync()
        {
            // Snippet: GetCampaignCriterionSimulationAsync(GetCampaignCriterionSimulationRequest, CallSettings)
            // Additional: GetCampaignCriterionSimulationAsync(GetCampaignCriterionSimulationRequest, CancellationToken)
            // Create client
            CampaignCriterionSimulationServiceClient campaignCriterionSimulationServiceClient = await CampaignCriterionSimulationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCampaignCriterionSimulationRequest request = new GetCampaignCriterionSimulationRequest
            {
                ResourceNameAsCampaignCriterionSimulationName = CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            // Make the request
            CampaignCriterionSimulation response = await campaignCriterionSimulationServiceClient.GetCampaignCriterionSimulationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignCriterionSimulation</summary>
        public void GetCampaignCriterionSimulation()
        {
            // Snippet: GetCampaignCriterionSimulation(string, CallSettings)
            // Create client
            CampaignCriterionSimulationServiceClient campaignCriterionSimulationServiceClient = CampaignCriterionSimulationServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaignCriterionSimulations/[CAMPAIGN_ID]~[CRITERION_ID]~[TYPE]~[MODIFICATION_METHOD]~[START_DATE]~[END_DATE]";
            // Make the request
            CampaignCriterionSimulation response = campaignCriterionSimulationServiceClient.GetCampaignCriterionSimulation(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignCriterionSimulationAsync</summary>
        public async Task GetCampaignCriterionSimulationAsync()
        {
            // Snippet: GetCampaignCriterionSimulationAsync(string, CallSettings)
            // Additional: GetCampaignCriterionSimulationAsync(string, CancellationToken)
            // Create client
            CampaignCriterionSimulationServiceClient campaignCriterionSimulationServiceClient = await CampaignCriterionSimulationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaignCriterionSimulations/[CAMPAIGN_ID]~[CRITERION_ID]~[TYPE]~[MODIFICATION_METHOD]~[START_DATE]~[END_DATE]";
            // Make the request
            CampaignCriterionSimulation response = await campaignCriterionSimulationServiceClient.GetCampaignCriterionSimulationAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignCriterionSimulation</summary>
        public void GetCampaignCriterionSimulationResourceNames()
        {
            // Snippet: GetCampaignCriterionSimulation(CampaignCriterionSimulationName, CallSettings)
            // Create client
            CampaignCriterionSimulationServiceClient campaignCriterionSimulationServiceClient = CampaignCriterionSimulationServiceClient.Create();
            // Initialize request argument(s)
            CampaignCriterionSimulationName resourceName = CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]");
            // Make the request
            CampaignCriterionSimulation response = campaignCriterionSimulationServiceClient.GetCampaignCriterionSimulation(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignCriterionSimulationAsync</summary>
        public async Task GetCampaignCriterionSimulationResourceNamesAsync()
        {
            // Snippet: GetCampaignCriterionSimulationAsync(CampaignCriterionSimulationName, CallSettings)
            // Additional: GetCampaignCriterionSimulationAsync(CampaignCriterionSimulationName, CancellationToken)
            // Create client
            CampaignCriterionSimulationServiceClient campaignCriterionSimulationServiceClient = await CampaignCriterionSimulationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CampaignCriterionSimulationName resourceName = CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]");
            // Make the request
            CampaignCriterionSimulation response = await campaignCriterionSimulationServiceClient.GetCampaignCriterionSimulationAsync(resourceName);
            // End snippet
        }
    }
}
