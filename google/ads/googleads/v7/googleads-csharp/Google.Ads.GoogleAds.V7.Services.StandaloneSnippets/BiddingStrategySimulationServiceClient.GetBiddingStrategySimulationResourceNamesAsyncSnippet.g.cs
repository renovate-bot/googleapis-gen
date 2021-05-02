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
    using Google.Ads.GoogleAds.V7.Resources;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBiddingStrategySimulationServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetBiddingStrategySimulationAsync</summary>
        public async Task GetBiddingStrategySimulationResourceNamesAsync()
        {
            // Snippet: GetBiddingStrategySimulationAsync(BiddingStrategySimulationName, CallSettings)
            // Additional: GetBiddingStrategySimulationAsync(BiddingStrategySimulationName, CancellationToken)
            // Create client
            BiddingStrategySimulationServiceClient biddingStrategySimulationServiceClient = await BiddingStrategySimulationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BiddingStrategySimulationName resourceName = BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]");
            // Make the request
            BiddingStrategySimulation response = await biddingStrategySimulationServiceClient.GetBiddingStrategySimulationAsync(resourceName);
            // End snippet
        }
    }
}
