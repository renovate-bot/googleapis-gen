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

namespace Google.Ads.GoogleAds.V5.Services.Snippets
{
    using Google.Ads.GoogleAds.V5.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedKeywordPlanCampaignKeywordServiceClientSnippets
    {
        /// <summary>Snippet for GetKeywordPlanCampaignKeyword</summary>
        public void GetKeywordPlanCampaignKeywordRequestObject()
        {
            // Snippet: GetKeywordPlanCampaignKeyword(GetKeywordPlanCampaignKeywordRequest, CallSettings)
            // Create client
            KeywordPlanCampaignKeywordServiceClient keywordPlanCampaignKeywordServiceClient = KeywordPlanCampaignKeywordServiceClient.Create();
            // Initialize request argument(s)
            GetKeywordPlanCampaignKeywordRequest request = new GetKeywordPlanCampaignKeywordRequest
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]"),
            };
            // Make the request
            KeywordPlanCampaignKeyword response = keywordPlanCampaignKeywordServiceClient.GetKeywordPlanCampaignKeyword(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanCampaignKeywordAsync</summary>
        public async Task GetKeywordPlanCampaignKeywordRequestObjectAsync()
        {
            // Snippet: GetKeywordPlanCampaignKeywordAsync(GetKeywordPlanCampaignKeywordRequest, CallSettings)
            // Additional: GetKeywordPlanCampaignKeywordAsync(GetKeywordPlanCampaignKeywordRequest, CancellationToken)
            // Create client
            KeywordPlanCampaignKeywordServiceClient keywordPlanCampaignKeywordServiceClient = await KeywordPlanCampaignKeywordServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetKeywordPlanCampaignKeywordRequest request = new GetKeywordPlanCampaignKeywordRequest
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]"),
            };
            // Make the request
            KeywordPlanCampaignKeyword response = await keywordPlanCampaignKeywordServiceClient.GetKeywordPlanCampaignKeywordAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanCampaignKeyword</summary>
        public void GetKeywordPlanCampaignKeyword()
        {
            // Snippet: GetKeywordPlanCampaignKeyword(string, CallSettings)
            // Create client
            KeywordPlanCampaignKeywordServiceClient keywordPlanCampaignKeywordServiceClient = KeywordPlanCampaignKeywordServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/keywordPlanCampaignKeywords/[KEYWORD_PLAN_CAMPAIGN_KEYWORD]";
            // Make the request
            KeywordPlanCampaignKeyword response = keywordPlanCampaignKeywordServiceClient.GetKeywordPlanCampaignKeyword(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanCampaignKeywordAsync</summary>
        public async Task GetKeywordPlanCampaignKeywordAsync()
        {
            // Snippet: GetKeywordPlanCampaignKeywordAsync(string, CallSettings)
            // Additional: GetKeywordPlanCampaignKeywordAsync(string, CancellationToken)
            // Create client
            KeywordPlanCampaignKeywordServiceClient keywordPlanCampaignKeywordServiceClient = await KeywordPlanCampaignKeywordServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/keywordPlanCampaignKeywords/[KEYWORD_PLAN_CAMPAIGN_KEYWORD]";
            // Make the request
            KeywordPlanCampaignKeyword response = await keywordPlanCampaignKeywordServiceClient.GetKeywordPlanCampaignKeywordAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanCampaignKeyword</summary>
        public void GetKeywordPlanCampaignKeywordResourceNames()
        {
            // Snippet: GetKeywordPlanCampaignKeyword(KeywordPlanCampaignKeywordName, CallSettings)
            // Create client
            KeywordPlanCampaignKeywordServiceClient keywordPlanCampaignKeywordServiceClient = KeywordPlanCampaignKeywordServiceClient.Create();
            // Initialize request argument(s)
            KeywordPlanCampaignKeywordName resourceName = KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]");
            // Make the request
            KeywordPlanCampaignKeyword response = keywordPlanCampaignKeywordServiceClient.GetKeywordPlanCampaignKeyword(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanCampaignKeywordAsync</summary>
        public async Task GetKeywordPlanCampaignKeywordResourceNamesAsync()
        {
            // Snippet: GetKeywordPlanCampaignKeywordAsync(KeywordPlanCampaignKeywordName, CallSettings)
            // Additional: GetKeywordPlanCampaignKeywordAsync(KeywordPlanCampaignKeywordName, CancellationToken)
            // Create client
            KeywordPlanCampaignKeywordServiceClient keywordPlanCampaignKeywordServiceClient = await KeywordPlanCampaignKeywordServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeywordPlanCampaignKeywordName resourceName = KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]");
            // Make the request
            KeywordPlanCampaignKeyword response = await keywordPlanCampaignKeywordServiceClient.GetKeywordPlanCampaignKeywordAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanCampaignKeywords</summary>
        public void MutateKeywordPlanCampaignKeywordsRequestObject()
        {
            // Snippet: MutateKeywordPlanCampaignKeywords(MutateKeywordPlanCampaignKeywordsRequest, CallSettings)
            // Create client
            KeywordPlanCampaignKeywordServiceClient keywordPlanCampaignKeywordServiceClient = KeywordPlanCampaignKeywordServiceClient.Create();
            // Initialize request argument(s)
            MutateKeywordPlanCampaignKeywordsRequest request = new MutateKeywordPlanCampaignKeywordsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new KeywordPlanCampaignKeywordOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateKeywordPlanCampaignKeywordsResponse response = keywordPlanCampaignKeywordServiceClient.MutateKeywordPlanCampaignKeywords(request);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanCampaignKeywordsAsync</summary>
        public async Task MutateKeywordPlanCampaignKeywordsRequestObjectAsync()
        {
            // Snippet: MutateKeywordPlanCampaignKeywordsAsync(MutateKeywordPlanCampaignKeywordsRequest, CallSettings)
            // Additional: MutateKeywordPlanCampaignKeywordsAsync(MutateKeywordPlanCampaignKeywordsRequest, CancellationToken)
            // Create client
            KeywordPlanCampaignKeywordServiceClient keywordPlanCampaignKeywordServiceClient = await KeywordPlanCampaignKeywordServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateKeywordPlanCampaignKeywordsRequest request = new MutateKeywordPlanCampaignKeywordsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new KeywordPlanCampaignKeywordOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateKeywordPlanCampaignKeywordsResponse response = await keywordPlanCampaignKeywordServiceClient.MutateKeywordPlanCampaignKeywordsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanCampaignKeywords</summary>
        public void MutateKeywordPlanCampaignKeywords()
        {
            // Snippet: MutateKeywordPlanCampaignKeywords(string, IEnumerable<KeywordPlanCampaignKeywordOperation>, CallSettings)
            // Create client
            KeywordPlanCampaignKeywordServiceClient keywordPlanCampaignKeywordServiceClient = KeywordPlanCampaignKeywordServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<KeywordPlanCampaignKeywordOperation> operations = new KeywordPlanCampaignKeywordOperation[]
            {
                new KeywordPlanCampaignKeywordOperation(),
            };
            // Make the request
            MutateKeywordPlanCampaignKeywordsResponse response = keywordPlanCampaignKeywordServiceClient.MutateKeywordPlanCampaignKeywords(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanCampaignKeywordsAsync</summary>
        public async Task MutateKeywordPlanCampaignKeywordsAsync()
        {
            // Snippet: MutateKeywordPlanCampaignKeywordsAsync(string, IEnumerable<KeywordPlanCampaignKeywordOperation>, CallSettings)
            // Additional: MutateKeywordPlanCampaignKeywordsAsync(string, IEnumerable<KeywordPlanCampaignKeywordOperation>, CancellationToken)
            // Create client
            KeywordPlanCampaignKeywordServiceClient keywordPlanCampaignKeywordServiceClient = await KeywordPlanCampaignKeywordServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<KeywordPlanCampaignKeywordOperation> operations = new KeywordPlanCampaignKeywordOperation[]
            {
                new KeywordPlanCampaignKeywordOperation(),
            };
            // Make the request
            MutateKeywordPlanCampaignKeywordsResponse response = await keywordPlanCampaignKeywordServiceClient.MutateKeywordPlanCampaignKeywordsAsync(customerId, operations);
            // End snippet
        }
    }
}
