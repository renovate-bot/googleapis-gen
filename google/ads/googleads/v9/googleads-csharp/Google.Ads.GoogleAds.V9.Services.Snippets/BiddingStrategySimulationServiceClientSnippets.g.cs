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
    using Google.Ads.GoogleAds.V9.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedBiddingStrategySimulationServiceClientSnippets
    {
        /// <summary>Snippet for GetBiddingStrategySimulation</summary>
        public void GetBiddingStrategySimulationRequestObject()
        {
            // Snippet: GetBiddingStrategySimulation(GetBiddingStrategySimulationRequest, CallSettings)
            // Create client
            BiddingStrategySimulationServiceClient biddingStrategySimulationServiceClient = BiddingStrategySimulationServiceClient.Create();
            // Initialize request argument(s)
            GetBiddingStrategySimulationRequest request = new GetBiddingStrategySimulationRequest
            {
                ResourceNameAsBiddingStrategySimulationName = BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            // Make the request
            BiddingStrategySimulation response = biddingStrategySimulationServiceClient.GetBiddingStrategySimulation(request);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingStrategySimulationAsync</summary>
        public async Task GetBiddingStrategySimulationRequestObjectAsync()
        {
            // Snippet: GetBiddingStrategySimulationAsync(GetBiddingStrategySimulationRequest, CallSettings)
            // Additional: GetBiddingStrategySimulationAsync(GetBiddingStrategySimulationRequest, CancellationToken)
            // Create client
            BiddingStrategySimulationServiceClient biddingStrategySimulationServiceClient = await BiddingStrategySimulationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBiddingStrategySimulationRequest request = new GetBiddingStrategySimulationRequest
            {
                ResourceNameAsBiddingStrategySimulationName = BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            // Make the request
            BiddingStrategySimulation response = await biddingStrategySimulationServiceClient.GetBiddingStrategySimulationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingStrategySimulation</summary>
        public void GetBiddingStrategySimulation()
        {
            // Snippet: GetBiddingStrategySimulation(string, CallSettings)
            // Create client
            BiddingStrategySimulationServiceClient biddingStrategySimulationServiceClient = BiddingStrategySimulationServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/biddingStrategySimulations/[BIDDING_STRATEGY_ID]~[TYPE]~[MODIFICATION_METHOD]~[START_DATE]~[END_DATE]";
            // Make the request
            BiddingStrategySimulation response = biddingStrategySimulationServiceClient.GetBiddingStrategySimulation(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingStrategySimulationAsync</summary>
        public async Task GetBiddingStrategySimulationAsync()
        {
            // Snippet: GetBiddingStrategySimulationAsync(string, CallSettings)
            // Additional: GetBiddingStrategySimulationAsync(string, CancellationToken)
            // Create client
            BiddingStrategySimulationServiceClient biddingStrategySimulationServiceClient = await BiddingStrategySimulationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/biddingStrategySimulations/[BIDDING_STRATEGY_ID]~[TYPE]~[MODIFICATION_METHOD]~[START_DATE]~[END_DATE]";
            // Make the request
            BiddingStrategySimulation response = await biddingStrategySimulationServiceClient.GetBiddingStrategySimulationAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingStrategySimulation</summary>
        public void GetBiddingStrategySimulationResourceNames()
        {
            // Snippet: GetBiddingStrategySimulation(BiddingStrategySimulationName, CallSettings)
            // Create client
            BiddingStrategySimulationServiceClient biddingStrategySimulationServiceClient = BiddingStrategySimulationServiceClient.Create();
            // Initialize request argument(s)
            BiddingStrategySimulationName resourceName = BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]");
            // Make the request
            BiddingStrategySimulation response = biddingStrategySimulationServiceClient.GetBiddingStrategySimulation(resourceName);
            // End snippet
        }

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
