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
    public sealed class GeneratedCombinedAudienceServiceClientSnippets
    {
        /// <summary>Snippet for GetCombinedAudience</summary>
        public void GetCombinedAudienceRequestObject()
        {
            // Snippet: GetCombinedAudience(GetCombinedAudienceRequest, CallSettings)
            // Create client
            CombinedAudienceServiceClient combinedAudienceServiceClient = CombinedAudienceServiceClient.Create();
            // Initialize request argument(s)
            GetCombinedAudienceRequest request = new GetCombinedAudienceRequest
            {
                ResourceNameAsCombinedAudienceName = CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
            };
            // Make the request
            CombinedAudience response = combinedAudienceServiceClient.GetCombinedAudience(request);
            // End snippet
        }

        /// <summary>Snippet for GetCombinedAudienceAsync</summary>
        public async Task GetCombinedAudienceRequestObjectAsync()
        {
            // Snippet: GetCombinedAudienceAsync(GetCombinedAudienceRequest, CallSettings)
            // Additional: GetCombinedAudienceAsync(GetCombinedAudienceRequest, CancellationToken)
            // Create client
            CombinedAudienceServiceClient combinedAudienceServiceClient = await CombinedAudienceServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCombinedAudienceRequest request = new GetCombinedAudienceRequest
            {
                ResourceNameAsCombinedAudienceName = CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]"),
            };
            // Make the request
            CombinedAudience response = await combinedAudienceServiceClient.GetCombinedAudienceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCombinedAudience</summary>
        public void GetCombinedAudience()
        {
            // Snippet: GetCombinedAudience(string, CallSettings)
            // Create client
            CombinedAudienceServiceClient combinedAudienceServiceClient = CombinedAudienceServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/combinedAudiences/[COMBINED_AUDIENCE_ID]";
            // Make the request
            CombinedAudience response = combinedAudienceServiceClient.GetCombinedAudience(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCombinedAudienceAsync</summary>
        public async Task GetCombinedAudienceAsync()
        {
            // Snippet: GetCombinedAudienceAsync(string, CallSettings)
            // Additional: GetCombinedAudienceAsync(string, CancellationToken)
            // Create client
            CombinedAudienceServiceClient combinedAudienceServiceClient = await CombinedAudienceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/combinedAudiences/[COMBINED_AUDIENCE_ID]";
            // Make the request
            CombinedAudience response = await combinedAudienceServiceClient.GetCombinedAudienceAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCombinedAudience</summary>
        public void GetCombinedAudienceResourceNames()
        {
            // Snippet: GetCombinedAudience(CombinedAudienceName, CallSettings)
            // Create client
            CombinedAudienceServiceClient combinedAudienceServiceClient = CombinedAudienceServiceClient.Create();
            // Initialize request argument(s)
            CombinedAudienceName resourceName = CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]");
            // Make the request
            CombinedAudience response = combinedAudienceServiceClient.GetCombinedAudience(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCombinedAudienceAsync</summary>
        public async Task GetCombinedAudienceResourceNamesAsync()
        {
            // Snippet: GetCombinedAudienceAsync(CombinedAudienceName, CallSettings)
            // Additional: GetCombinedAudienceAsync(CombinedAudienceName, CancellationToken)
            // Create client
            CombinedAudienceServiceClient combinedAudienceServiceClient = await CombinedAudienceServiceClient.CreateAsync();
            // Initialize request argument(s)
            CombinedAudienceName resourceName = CombinedAudienceName.FromCustomerCombinedAudience("[CUSTOMER_ID]", "[COMBINED_AUDIENCE_ID]");
            // Make the request
            CombinedAudience response = await combinedAudienceServiceClient.GetCombinedAudienceAsync(resourceName);
            // End snippet
        }
    }
}
