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
    public sealed class GeneratedKeywordPlanCampaignServiceClientSnippets
    {
        /// <summary>Snippet for GetKeywordPlanCampaign</summary>
        public void GetKeywordPlanCampaignRequestObject()
        {
            // Snippet: GetKeywordPlanCampaign(GetKeywordPlanCampaignRequest, CallSettings)
            // Create client
            KeywordPlanCampaignServiceClient keywordPlanCampaignServiceClient = KeywordPlanCampaignServiceClient.Create();
            // Initialize request argument(s)
            GetKeywordPlanCampaignRequest request = new GetKeywordPlanCampaignRequest
            {
                ResourceNameAsKeywordPlanCampaignName = KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
            };
            // Make the request
            KeywordPlanCampaign response = keywordPlanCampaignServiceClient.GetKeywordPlanCampaign(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanCampaignAsync</summary>
        public async Task GetKeywordPlanCampaignRequestObjectAsync()
        {
            // Snippet: GetKeywordPlanCampaignAsync(GetKeywordPlanCampaignRequest, CallSettings)
            // Additional: GetKeywordPlanCampaignAsync(GetKeywordPlanCampaignRequest, CancellationToken)
            // Create client
            KeywordPlanCampaignServiceClient keywordPlanCampaignServiceClient = await KeywordPlanCampaignServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetKeywordPlanCampaignRequest request = new GetKeywordPlanCampaignRequest
            {
                ResourceNameAsKeywordPlanCampaignName = KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
            };
            // Make the request
            KeywordPlanCampaign response = await keywordPlanCampaignServiceClient.GetKeywordPlanCampaignAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanCampaign</summary>
        public void GetKeywordPlanCampaign()
        {
            // Snippet: GetKeywordPlanCampaign(string, CallSettings)
            // Create client
            KeywordPlanCampaignServiceClient keywordPlanCampaignServiceClient = KeywordPlanCampaignServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/keywordPlanCampaigns/[KEYWORD_PLAN_CAMPAIGN]";
            // Make the request
            KeywordPlanCampaign response = keywordPlanCampaignServiceClient.GetKeywordPlanCampaign(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanCampaignAsync</summary>
        public async Task GetKeywordPlanCampaignAsync()
        {
            // Snippet: GetKeywordPlanCampaignAsync(string, CallSettings)
            // Additional: GetKeywordPlanCampaignAsync(string, CancellationToken)
            // Create client
            KeywordPlanCampaignServiceClient keywordPlanCampaignServiceClient = await KeywordPlanCampaignServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/keywordPlanCampaigns/[KEYWORD_PLAN_CAMPAIGN]";
            // Make the request
            KeywordPlanCampaign response = await keywordPlanCampaignServiceClient.GetKeywordPlanCampaignAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanCampaign</summary>
        public void GetKeywordPlanCampaignResourceNames()
        {
            // Snippet: GetKeywordPlanCampaign(KeywordPlanCampaignName, CallSettings)
            // Create client
            KeywordPlanCampaignServiceClient keywordPlanCampaignServiceClient = KeywordPlanCampaignServiceClient.Create();
            // Initialize request argument(s)
            KeywordPlanCampaignName resourceName = KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]");
            // Make the request
            KeywordPlanCampaign response = keywordPlanCampaignServiceClient.GetKeywordPlanCampaign(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanCampaignAsync</summary>
        public async Task GetKeywordPlanCampaignResourceNamesAsync()
        {
            // Snippet: GetKeywordPlanCampaignAsync(KeywordPlanCampaignName, CallSettings)
            // Additional: GetKeywordPlanCampaignAsync(KeywordPlanCampaignName, CancellationToken)
            // Create client
            KeywordPlanCampaignServiceClient keywordPlanCampaignServiceClient = await KeywordPlanCampaignServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeywordPlanCampaignName resourceName = KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]");
            // Make the request
            KeywordPlanCampaign response = await keywordPlanCampaignServiceClient.GetKeywordPlanCampaignAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanCampaigns</summary>
        public void MutateKeywordPlanCampaignsRequestObject()
        {
            // Snippet: MutateKeywordPlanCampaigns(MutateKeywordPlanCampaignsRequest, CallSettings)
            // Create client
            KeywordPlanCampaignServiceClient keywordPlanCampaignServiceClient = KeywordPlanCampaignServiceClient.Create();
            // Initialize request argument(s)
            MutateKeywordPlanCampaignsRequest request = new MutateKeywordPlanCampaignsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new KeywordPlanCampaignOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateKeywordPlanCampaignsResponse response = keywordPlanCampaignServiceClient.MutateKeywordPlanCampaigns(request);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanCampaignsAsync</summary>
        public async Task MutateKeywordPlanCampaignsRequestObjectAsync()
        {
            // Snippet: MutateKeywordPlanCampaignsAsync(MutateKeywordPlanCampaignsRequest, CallSettings)
            // Additional: MutateKeywordPlanCampaignsAsync(MutateKeywordPlanCampaignsRequest, CancellationToken)
            // Create client
            KeywordPlanCampaignServiceClient keywordPlanCampaignServiceClient = await KeywordPlanCampaignServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateKeywordPlanCampaignsRequest request = new MutateKeywordPlanCampaignsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new KeywordPlanCampaignOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateKeywordPlanCampaignsResponse response = await keywordPlanCampaignServiceClient.MutateKeywordPlanCampaignsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanCampaigns</summary>
        public void MutateKeywordPlanCampaigns()
        {
            // Snippet: MutateKeywordPlanCampaigns(string, IEnumerable<KeywordPlanCampaignOperation>, CallSettings)
            // Create client
            KeywordPlanCampaignServiceClient keywordPlanCampaignServiceClient = KeywordPlanCampaignServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<KeywordPlanCampaignOperation> operations = new KeywordPlanCampaignOperation[]
            {
                new KeywordPlanCampaignOperation(),
            };
            // Make the request
            MutateKeywordPlanCampaignsResponse response = keywordPlanCampaignServiceClient.MutateKeywordPlanCampaigns(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanCampaignsAsync</summary>
        public async Task MutateKeywordPlanCampaignsAsync()
        {
            // Snippet: MutateKeywordPlanCampaignsAsync(string, IEnumerable<KeywordPlanCampaignOperation>, CallSettings)
            // Additional: MutateKeywordPlanCampaignsAsync(string, IEnumerable<KeywordPlanCampaignOperation>, CancellationToken)
            // Create client
            KeywordPlanCampaignServiceClient keywordPlanCampaignServiceClient = await KeywordPlanCampaignServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<KeywordPlanCampaignOperation> operations = new KeywordPlanCampaignOperation[]
            {
                new KeywordPlanCampaignOperation(),
            };
            // Make the request
            MutateKeywordPlanCampaignsResponse response = await keywordPlanCampaignServiceClient.MutateKeywordPlanCampaignsAsync(customerId, operations);
            // End snippet
        }
    }
}
