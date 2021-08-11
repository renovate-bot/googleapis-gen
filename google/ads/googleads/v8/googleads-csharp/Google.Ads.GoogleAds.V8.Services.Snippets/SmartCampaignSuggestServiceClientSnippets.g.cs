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
    public sealed class GeneratedSmartCampaignSuggestServiceClientSnippets
    {
        /// <summary>Snippet for SuggestSmartCampaignBudgetOptions</summary>
        public void SuggestSmartCampaignBudgetOptionsRequestObject()
        {
            // Snippet: SuggestSmartCampaignBudgetOptions(SuggestSmartCampaignBudgetOptionsRequest, CallSettings)
            // Create client
            SmartCampaignSuggestServiceClient smartCampaignSuggestServiceClient = SmartCampaignSuggestServiceClient.Create();
            // Initialize request argument(s)
            SuggestSmartCampaignBudgetOptionsRequest request = new SuggestSmartCampaignBudgetOptionsRequest
            {
                CustomerId = "",
                CampaignAsCampaignName = CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            // Make the request
            SuggestSmartCampaignBudgetOptionsResponse response = smartCampaignSuggestServiceClient.SuggestSmartCampaignBudgetOptions(request);
            // End snippet
        }

        /// <summary>Snippet for SuggestSmartCampaignBudgetOptionsAsync</summary>
        public async Task SuggestSmartCampaignBudgetOptionsRequestObjectAsync()
        {
            // Snippet: SuggestSmartCampaignBudgetOptionsAsync(SuggestSmartCampaignBudgetOptionsRequest, CallSettings)
            // Additional: SuggestSmartCampaignBudgetOptionsAsync(SuggestSmartCampaignBudgetOptionsRequest, CancellationToken)
            // Create client
            SmartCampaignSuggestServiceClient smartCampaignSuggestServiceClient = await SmartCampaignSuggestServiceClient.CreateAsync();
            // Initialize request argument(s)
            SuggestSmartCampaignBudgetOptionsRequest request = new SuggestSmartCampaignBudgetOptionsRequest
            {
                CustomerId = "",
                CampaignAsCampaignName = CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            // Make the request
            SuggestSmartCampaignBudgetOptionsResponse response = await smartCampaignSuggestServiceClient.SuggestSmartCampaignBudgetOptionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SuggestSmartCampaignAd</summary>
        public void SuggestSmartCampaignAdRequestObject()
        {
            // Snippet: SuggestSmartCampaignAd(SuggestSmartCampaignAdRequest, CallSettings)
            // Create client
            SmartCampaignSuggestServiceClient smartCampaignSuggestServiceClient = SmartCampaignSuggestServiceClient.Create();
            // Initialize request argument(s)
            SuggestSmartCampaignAdRequest request = new SuggestSmartCampaignAdRequest
            {
                CustomerId = "",
                SuggestionInfo = new SmartCampaignSuggestionInfo(),
            };
            // Make the request
            SuggestSmartCampaignAdResponse response = smartCampaignSuggestServiceClient.SuggestSmartCampaignAd(request);
            // End snippet
        }

        /// <summary>Snippet for SuggestSmartCampaignAdAsync</summary>
        public async Task SuggestSmartCampaignAdRequestObjectAsync()
        {
            // Snippet: SuggestSmartCampaignAdAsync(SuggestSmartCampaignAdRequest, CallSettings)
            // Additional: SuggestSmartCampaignAdAsync(SuggestSmartCampaignAdRequest, CancellationToken)
            // Create client
            SmartCampaignSuggestServiceClient smartCampaignSuggestServiceClient = await SmartCampaignSuggestServiceClient.CreateAsync();
            // Initialize request argument(s)
            SuggestSmartCampaignAdRequest request = new SuggestSmartCampaignAdRequest
            {
                CustomerId = "",
                SuggestionInfo = new SmartCampaignSuggestionInfo(),
            };
            // Make the request
            SuggestSmartCampaignAdResponse response = await smartCampaignSuggestServiceClient.SuggestSmartCampaignAdAsync(request);
            // End snippet
        }
    }
}
