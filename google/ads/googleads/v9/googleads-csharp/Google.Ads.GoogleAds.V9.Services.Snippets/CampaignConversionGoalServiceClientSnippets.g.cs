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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCampaignConversionGoalServiceClientSnippets
    {
        /// <summary>Snippet for MutateCampaignConversionGoals</summary>
        public void MutateCampaignConversionGoalsRequestObject()
        {
            // Snippet: MutateCampaignConversionGoals(MutateCampaignConversionGoalsRequest, CallSettings)
            // Create client
            CampaignConversionGoalServiceClient campaignConversionGoalServiceClient = CampaignConversionGoalServiceClient.Create();
            // Initialize request argument(s)
            MutateCampaignConversionGoalsRequest request = new MutateCampaignConversionGoalsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignConversionGoalOperation(),
                },
                ValidateOnly = false,
            };
            // Make the request
            MutateCampaignConversionGoalsResponse response = campaignConversionGoalServiceClient.MutateCampaignConversionGoals(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignConversionGoalsAsync</summary>
        public async Task MutateCampaignConversionGoalsRequestObjectAsync()
        {
            // Snippet: MutateCampaignConversionGoalsAsync(MutateCampaignConversionGoalsRequest, CallSettings)
            // Additional: MutateCampaignConversionGoalsAsync(MutateCampaignConversionGoalsRequest, CancellationToken)
            // Create client
            CampaignConversionGoalServiceClient campaignConversionGoalServiceClient = await CampaignConversionGoalServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCampaignConversionGoalsRequest request = new MutateCampaignConversionGoalsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignConversionGoalOperation(),
                },
                ValidateOnly = false,
            };
            // Make the request
            MutateCampaignConversionGoalsResponse response = await campaignConversionGoalServiceClient.MutateCampaignConversionGoalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignConversionGoals</summary>
        public void MutateCampaignConversionGoals()
        {
            // Snippet: MutateCampaignConversionGoals(string, IEnumerable<CampaignConversionGoalOperation>, CallSettings)
            // Create client
            CampaignConversionGoalServiceClient campaignConversionGoalServiceClient = CampaignConversionGoalServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignConversionGoalOperation> operations = new CampaignConversionGoalOperation[]
            {
                new CampaignConversionGoalOperation(),
            };
            // Make the request
            MutateCampaignConversionGoalsResponse response = campaignConversionGoalServiceClient.MutateCampaignConversionGoals(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignConversionGoalsAsync</summary>
        public async Task MutateCampaignConversionGoalsAsync()
        {
            // Snippet: MutateCampaignConversionGoalsAsync(string, IEnumerable<CampaignConversionGoalOperation>, CallSettings)
            // Additional: MutateCampaignConversionGoalsAsync(string, IEnumerable<CampaignConversionGoalOperation>, CancellationToken)
            // Create client
            CampaignConversionGoalServiceClient campaignConversionGoalServiceClient = await CampaignConversionGoalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignConversionGoalOperation> operations = new CampaignConversionGoalOperation[]
            {
                new CampaignConversionGoalOperation(),
            };
            // Make the request
            MutateCampaignConversionGoalsResponse response = await campaignConversionGoalServiceClient.MutateCampaignConversionGoalsAsync(customerId, operations);
            // End snippet
        }
    }
}
