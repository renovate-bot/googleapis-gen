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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedKeywordPlanAdGroupKeywordServiceClientSnippets
    {
        /// <summary>Snippet for GetKeywordPlanAdGroupKeyword</summary>
        public void GetKeywordPlanAdGroupKeywordRequestObject()
        {
            // Snippet: GetKeywordPlanAdGroupKeyword(GetKeywordPlanAdGroupKeywordRequest, CallSettings)
            // Create client
            KeywordPlanAdGroupKeywordServiceClient keywordPlanAdGroupKeywordServiceClient = KeywordPlanAdGroupKeywordServiceClient.Create();
            // Initialize request argument(s)
            GetKeywordPlanAdGroupKeywordRequest request = new GetKeywordPlanAdGroupKeywordRequest
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER_ID]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD_ID]"),
            };
            // Make the request
            KeywordPlanAdGroupKeyword response = keywordPlanAdGroupKeywordServiceClient.GetKeywordPlanAdGroupKeyword(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanAdGroupKeywordAsync</summary>
        public async Task GetKeywordPlanAdGroupKeywordRequestObjectAsync()
        {
            // Snippet: GetKeywordPlanAdGroupKeywordAsync(GetKeywordPlanAdGroupKeywordRequest, CallSettings)
            // Additional: GetKeywordPlanAdGroupKeywordAsync(GetKeywordPlanAdGroupKeywordRequest, CancellationToken)
            // Create client
            KeywordPlanAdGroupKeywordServiceClient keywordPlanAdGroupKeywordServiceClient = await KeywordPlanAdGroupKeywordServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetKeywordPlanAdGroupKeywordRequest request = new GetKeywordPlanAdGroupKeywordRequest
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER_ID]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD_ID]"),
            };
            // Make the request
            KeywordPlanAdGroupKeyword response = await keywordPlanAdGroupKeywordServiceClient.GetKeywordPlanAdGroupKeywordAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanAdGroupKeyword</summary>
        public void GetKeywordPlanAdGroupKeyword()
        {
            // Snippet: GetKeywordPlanAdGroupKeyword(string, CallSettings)
            // Create client
            KeywordPlanAdGroupKeywordServiceClient keywordPlanAdGroupKeywordServiceClient = KeywordPlanAdGroupKeywordServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/keywordPlanAdGroupKeywords/[KEYWORD_PLAN_AD_GROUP_KEYWORD_ID]";
            // Make the request
            KeywordPlanAdGroupKeyword response = keywordPlanAdGroupKeywordServiceClient.GetKeywordPlanAdGroupKeyword(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanAdGroupKeywordAsync</summary>
        public async Task GetKeywordPlanAdGroupKeywordAsync()
        {
            // Snippet: GetKeywordPlanAdGroupKeywordAsync(string, CallSettings)
            // Additional: GetKeywordPlanAdGroupKeywordAsync(string, CancellationToken)
            // Create client
            KeywordPlanAdGroupKeywordServiceClient keywordPlanAdGroupKeywordServiceClient = await KeywordPlanAdGroupKeywordServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/keywordPlanAdGroupKeywords/[KEYWORD_PLAN_AD_GROUP_KEYWORD_ID]";
            // Make the request
            KeywordPlanAdGroupKeyword response = await keywordPlanAdGroupKeywordServiceClient.GetKeywordPlanAdGroupKeywordAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanAdGroupKeyword</summary>
        public void GetKeywordPlanAdGroupKeywordResourceNames()
        {
            // Snippet: GetKeywordPlanAdGroupKeyword(KeywordPlanAdGroupKeywordName, CallSettings)
            // Create client
            KeywordPlanAdGroupKeywordServiceClient keywordPlanAdGroupKeywordServiceClient = KeywordPlanAdGroupKeywordServiceClient.Create();
            // Initialize request argument(s)
            KeywordPlanAdGroupKeywordName resourceName = KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER_ID]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD_ID]");
            // Make the request
            KeywordPlanAdGroupKeyword response = keywordPlanAdGroupKeywordServiceClient.GetKeywordPlanAdGroupKeyword(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanAdGroupKeywordAsync</summary>
        public async Task GetKeywordPlanAdGroupKeywordResourceNamesAsync()
        {
            // Snippet: GetKeywordPlanAdGroupKeywordAsync(KeywordPlanAdGroupKeywordName, CallSettings)
            // Additional: GetKeywordPlanAdGroupKeywordAsync(KeywordPlanAdGroupKeywordName, CancellationToken)
            // Create client
            KeywordPlanAdGroupKeywordServiceClient keywordPlanAdGroupKeywordServiceClient = await KeywordPlanAdGroupKeywordServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeywordPlanAdGroupKeywordName resourceName = KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER_ID]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD_ID]");
            // Make the request
            KeywordPlanAdGroupKeyword response = await keywordPlanAdGroupKeywordServiceClient.GetKeywordPlanAdGroupKeywordAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanAdGroupKeywords</summary>
        public void MutateKeywordPlanAdGroupKeywordsRequestObject()
        {
            // Snippet: MutateKeywordPlanAdGroupKeywords(MutateKeywordPlanAdGroupKeywordsRequest, CallSettings)
            // Create client
            KeywordPlanAdGroupKeywordServiceClient keywordPlanAdGroupKeywordServiceClient = KeywordPlanAdGroupKeywordServiceClient.Create();
            // Initialize request argument(s)
            MutateKeywordPlanAdGroupKeywordsRequest request = new MutateKeywordPlanAdGroupKeywordsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new KeywordPlanAdGroupKeywordOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateKeywordPlanAdGroupKeywordsResponse response = keywordPlanAdGroupKeywordServiceClient.MutateKeywordPlanAdGroupKeywords(request);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanAdGroupKeywordsAsync</summary>
        public async Task MutateKeywordPlanAdGroupKeywordsRequestObjectAsync()
        {
            // Snippet: MutateKeywordPlanAdGroupKeywordsAsync(MutateKeywordPlanAdGroupKeywordsRequest, CallSettings)
            // Additional: MutateKeywordPlanAdGroupKeywordsAsync(MutateKeywordPlanAdGroupKeywordsRequest, CancellationToken)
            // Create client
            KeywordPlanAdGroupKeywordServiceClient keywordPlanAdGroupKeywordServiceClient = await KeywordPlanAdGroupKeywordServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateKeywordPlanAdGroupKeywordsRequest request = new MutateKeywordPlanAdGroupKeywordsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new KeywordPlanAdGroupKeywordOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateKeywordPlanAdGroupKeywordsResponse response = await keywordPlanAdGroupKeywordServiceClient.MutateKeywordPlanAdGroupKeywordsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanAdGroupKeywords</summary>
        public void MutateKeywordPlanAdGroupKeywords()
        {
            // Snippet: MutateKeywordPlanAdGroupKeywords(string, IEnumerable<KeywordPlanAdGroupKeywordOperation>, CallSettings)
            // Create client
            KeywordPlanAdGroupKeywordServiceClient keywordPlanAdGroupKeywordServiceClient = KeywordPlanAdGroupKeywordServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<KeywordPlanAdGroupKeywordOperation> operations = new KeywordPlanAdGroupKeywordOperation[]
            {
                new KeywordPlanAdGroupKeywordOperation(),
            };
            // Make the request
            MutateKeywordPlanAdGroupKeywordsResponse response = keywordPlanAdGroupKeywordServiceClient.MutateKeywordPlanAdGroupKeywords(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanAdGroupKeywordsAsync</summary>
        public async Task MutateKeywordPlanAdGroupKeywordsAsync()
        {
            // Snippet: MutateKeywordPlanAdGroupKeywordsAsync(string, IEnumerable<KeywordPlanAdGroupKeywordOperation>, CallSettings)
            // Additional: MutateKeywordPlanAdGroupKeywordsAsync(string, IEnumerable<KeywordPlanAdGroupKeywordOperation>, CancellationToken)
            // Create client
            KeywordPlanAdGroupKeywordServiceClient keywordPlanAdGroupKeywordServiceClient = await KeywordPlanAdGroupKeywordServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<KeywordPlanAdGroupKeywordOperation> operations = new KeywordPlanAdGroupKeywordOperation[]
            {
                new KeywordPlanAdGroupKeywordOperation(),
            };
            // Make the request
            MutateKeywordPlanAdGroupKeywordsResponse response = await keywordPlanAdGroupKeywordServiceClient.MutateKeywordPlanAdGroupKeywordsAsync(customerId, operations);
            // End snippet
        }
    }
}
