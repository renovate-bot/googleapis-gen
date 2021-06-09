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
    public sealed class GeneratedDetailedDemographicServiceClientSnippets
    {
        /// <summary>Snippet for GetDetailedDemographic</summary>
        public void GetDetailedDemographicRequestObject()
        {
            // Snippet: GetDetailedDemographic(GetDetailedDemographicRequest, CallSettings)
            // Create client
            DetailedDemographicServiceClient detailedDemographicServiceClient = DetailedDemographicServiceClient.Create();
            // Initialize request argument(s)
            GetDetailedDemographicRequest request = new GetDetailedDemographicRequest
            {
                ResourceNameAsDetailedDemographicName = DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
            };
            // Make the request
            DetailedDemographic response = detailedDemographicServiceClient.GetDetailedDemographic(request);
            // End snippet
        }

        /// <summary>Snippet for GetDetailedDemographicAsync</summary>
        public async Task GetDetailedDemographicRequestObjectAsync()
        {
            // Snippet: GetDetailedDemographicAsync(GetDetailedDemographicRequest, CallSettings)
            // Additional: GetDetailedDemographicAsync(GetDetailedDemographicRequest, CancellationToken)
            // Create client
            DetailedDemographicServiceClient detailedDemographicServiceClient = await DetailedDemographicServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDetailedDemographicRequest request = new GetDetailedDemographicRequest
            {
                ResourceNameAsDetailedDemographicName = DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]"),
            };
            // Make the request
            DetailedDemographic response = await detailedDemographicServiceClient.GetDetailedDemographicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDetailedDemographic</summary>
        public void GetDetailedDemographic()
        {
            // Snippet: GetDetailedDemographic(string, CallSettings)
            // Create client
            DetailedDemographicServiceClient detailedDemographicServiceClient = DetailedDemographicServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/detailedDemographics/[DETAILED_DEMOGRAPHIC_ID]";
            // Make the request
            DetailedDemographic response = detailedDemographicServiceClient.GetDetailedDemographic(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDetailedDemographicAsync</summary>
        public async Task GetDetailedDemographicAsync()
        {
            // Snippet: GetDetailedDemographicAsync(string, CallSettings)
            // Additional: GetDetailedDemographicAsync(string, CancellationToken)
            // Create client
            DetailedDemographicServiceClient detailedDemographicServiceClient = await DetailedDemographicServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/detailedDemographics/[DETAILED_DEMOGRAPHIC_ID]";
            // Make the request
            DetailedDemographic response = await detailedDemographicServiceClient.GetDetailedDemographicAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDetailedDemographic</summary>
        public void GetDetailedDemographicResourceNames()
        {
            // Snippet: GetDetailedDemographic(DetailedDemographicName, CallSettings)
            // Create client
            DetailedDemographicServiceClient detailedDemographicServiceClient = DetailedDemographicServiceClient.Create();
            // Initialize request argument(s)
            DetailedDemographicName resourceName = DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]");
            // Make the request
            DetailedDemographic response = detailedDemographicServiceClient.GetDetailedDemographic(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDetailedDemographicAsync</summary>
        public async Task GetDetailedDemographicResourceNamesAsync()
        {
            // Snippet: GetDetailedDemographicAsync(DetailedDemographicName, CallSettings)
            // Additional: GetDetailedDemographicAsync(DetailedDemographicName, CancellationToken)
            // Create client
            DetailedDemographicServiceClient detailedDemographicServiceClient = await DetailedDemographicServiceClient.CreateAsync();
            // Initialize request argument(s)
            DetailedDemographicName resourceName = DetailedDemographicName.FromCustomerDetailedDemographic("[CUSTOMER_ID]", "[DETAILED_DEMOGRAPHIC_ID]");
            // Make the request
            DetailedDemographic response = await detailedDemographicServiceClient.GetDetailedDemographicAsync(resourceName);
            // End snippet
        }
    }
}
