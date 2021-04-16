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
    using Google.Ads.GoogleAds.V6.Resources;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAdGroupSimulationServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetAdGroupSimulationAsync</summary>
        public async Task GetAdGroupSimulationRequestObjectAsync()
        {
            // Snippet: GetAdGroupSimulationAsync(GetAdGroupSimulationRequest, CallSettings)
            // Additional: GetAdGroupSimulationAsync(GetAdGroupSimulationRequest, CancellationToken)
            // Create client
            AdGroupSimulationServiceClient adGroupSimulationServiceClient = await AdGroupSimulationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdGroupSimulationRequest request = new GetAdGroupSimulationRequest
            {
                ResourceNameAsAdGroupSimulationName = AdGroupSimulationName.FromCustomerAdGroupTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            // Make the request
            AdGroupSimulation response = await adGroupSimulationServiceClient.GetAdGroupSimulationAsync(request);
            // End snippet
        }
    }
}
