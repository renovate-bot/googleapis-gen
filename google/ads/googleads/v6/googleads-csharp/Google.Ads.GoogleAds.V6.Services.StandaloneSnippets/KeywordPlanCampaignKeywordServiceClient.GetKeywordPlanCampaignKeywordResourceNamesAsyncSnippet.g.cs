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

    public sealed partial class GeneratedKeywordPlanCampaignKeywordServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetKeywordPlanCampaignKeywordAsync</summary>
        public async Task GetKeywordPlanCampaignKeywordResourceNamesAsync()
        {
            // Snippet: GetKeywordPlanCampaignKeywordAsync(KeywordPlanCampaignKeywordName, CallSettings)
            // Additional: GetKeywordPlanCampaignKeywordAsync(KeywordPlanCampaignKeywordName, CancellationToken)
            // Create client
            KeywordPlanCampaignKeywordServiceClient keywordPlanCampaignKeywordServiceClient = await KeywordPlanCampaignKeywordServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeywordPlanCampaignKeywordName resourceName = KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER_ID]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD_ID]");
            // Make the request
            KeywordPlanCampaignKeyword response = await keywordPlanCampaignKeywordServiceClient.GetKeywordPlanCampaignKeywordAsync(resourceName);
            // End snippet
        }
    }
}
