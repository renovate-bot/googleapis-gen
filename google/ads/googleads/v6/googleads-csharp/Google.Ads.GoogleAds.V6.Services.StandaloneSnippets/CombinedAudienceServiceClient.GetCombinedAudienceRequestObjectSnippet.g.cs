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

    public sealed partial class GeneratedCombinedAudienceServiceClientStandaloneSnippets
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
    }
}
