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

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAdGroupCriterionSimulationServiceClientSnippets
    {
        /// <summary>Snippet for GetAdGroupCriterionSimulation</summary>
        public void GetAdGroupCriterionSimulationRequestObject()
        {
            // Snippet: GetAdGroupCriterionSimulation(GetAdGroupCriterionSimulationRequest, CallSettings)
            // Create client
            AdGroupCriterionSimulationServiceClient adGroupCriterionSimulationServiceClient = AdGroupCriterionSimulationServiceClient.Create();
            // Initialize request argument(s)
            GetAdGroupCriterionSimulationRequest request = new GetAdGroupCriterionSimulationRequest
            {
                ResourceNameAsAdGroupCriterionSimulationName = AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            // Make the request
            AdGroupCriterionSimulation response = adGroupCriterionSimulationServiceClient.GetAdGroupCriterionSimulation(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupCriterionSimulationAsync</summary>
        public async Task GetAdGroupCriterionSimulationRequestObjectAsync()
        {
            // Snippet: GetAdGroupCriterionSimulationAsync(GetAdGroupCriterionSimulationRequest, CallSettings)
            // Additional: GetAdGroupCriterionSimulationAsync(GetAdGroupCriterionSimulationRequest, CancellationToken)
            // Create client
            AdGroupCriterionSimulationServiceClient adGroupCriterionSimulationServiceClient = await AdGroupCriterionSimulationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdGroupCriterionSimulationRequest request = new GetAdGroupCriterionSimulationRequest
            {
                ResourceNameAsAdGroupCriterionSimulationName = AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            // Make the request
            AdGroupCriterionSimulation response = await adGroupCriterionSimulationServiceClient.GetAdGroupCriterionSimulationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupCriterionSimulation</summary>
        public void GetAdGroupCriterionSimulation()
        {
            // Snippet: GetAdGroupCriterionSimulation(string, CallSettings)
            // Create client
            AdGroupCriterionSimulationServiceClient adGroupCriterionSimulationServiceClient = AdGroupCriterionSimulationServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupCriterionSimulations/[AD_GROUP_ID]~[CRITERION_ID]~[TYPE]~[MODIFICATION_METHOD]~[START_DATE]~[END_DATE]";
            // Make the request
            AdGroupCriterionSimulation response = adGroupCriterionSimulationServiceClient.GetAdGroupCriterionSimulation(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupCriterionSimulationAsync</summary>
        public async Task GetAdGroupCriterionSimulationAsync()
        {
            // Snippet: GetAdGroupCriterionSimulationAsync(string, CallSettings)
            // Additional: GetAdGroupCriterionSimulationAsync(string, CancellationToken)
            // Create client
            AdGroupCriterionSimulationServiceClient adGroupCriterionSimulationServiceClient = await AdGroupCriterionSimulationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupCriterionSimulations/[AD_GROUP_ID]~[CRITERION_ID]~[TYPE]~[MODIFICATION_METHOD]~[START_DATE]~[END_DATE]";
            // Make the request
            AdGroupCriterionSimulation response = await adGroupCriterionSimulationServiceClient.GetAdGroupCriterionSimulationAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupCriterionSimulation</summary>
        public void GetAdGroupCriterionSimulationResourceNames()
        {
            // Snippet: GetAdGroupCriterionSimulation(AdGroupCriterionSimulationName, CallSettings)
            // Create client
            AdGroupCriterionSimulationServiceClient adGroupCriterionSimulationServiceClient = AdGroupCriterionSimulationServiceClient.Create();
            // Initialize request argument(s)
            AdGroupCriterionSimulationName resourceName = AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]");
            // Make the request
            AdGroupCriterionSimulation response = adGroupCriterionSimulationServiceClient.GetAdGroupCriterionSimulation(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupCriterionSimulationAsync</summary>
        public async Task GetAdGroupCriterionSimulationResourceNamesAsync()
        {
            // Snippet: GetAdGroupCriterionSimulationAsync(AdGroupCriterionSimulationName, CallSettings)
            // Additional: GetAdGroupCriterionSimulationAsync(AdGroupCriterionSimulationName, CancellationToken)
            // Create client
            AdGroupCriterionSimulationServiceClient adGroupCriterionSimulationServiceClient = await AdGroupCriterionSimulationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdGroupCriterionSimulationName resourceName = AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]");
            // Make the request
            AdGroupCriterionSimulation response = await adGroupCriterionSimulationServiceClient.GetAdGroupCriterionSimulationAsync(resourceName);
            // End snippet
        }
    }
}
