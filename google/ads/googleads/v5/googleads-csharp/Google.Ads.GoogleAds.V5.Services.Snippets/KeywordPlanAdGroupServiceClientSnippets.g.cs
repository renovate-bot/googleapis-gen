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
    public sealed class GeneratedKeywordPlanAdGroupServiceClientSnippets
    {
        /// <summary>Snippet for GetKeywordPlanAdGroup</summary>
        public void GetKeywordPlanAdGroupRequestObject()
        {
            // Snippet: GetKeywordPlanAdGroup(GetKeywordPlanAdGroupRequest, CallSettings)
            // Create client
            KeywordPlanAdGroupServiceClient keywordPlanAdGroupServiceClient = KeywordPlanAdGroupServiceClient.Create();
            // Initialize request argument(s)
            GetKeywordPlanAdGroupRequest request = new GetKeywordPlanAdGroupRequest
            {
                ResourceNameAsKeywordPlanAdGroupName = KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
            };
            // Make the request
            KeywordPlanAdGroup response = keywordPlanAdGroupServiceClient.GetKeywordPlanAdGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanAdGroupAsync</summary>
        public async Task GetKeywordPlanAdGroupRequestObjectAsync()
        {
            // Snippet: GetKeywordPlanAdGroupAsync(GetKeywordPlanAdGroupRequest, CallSettings)
            // Additional: GetKeywordPlanAdGroupAsync(GetKeywordPlanAdGroupRequest, CancellationToken)
            // Create client
            KeywordPlanAdGroupServiceClient keywordPlanAdGroupServiceClient = await KeywordPlanAdGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetKeywordPlanAdGroupRequest request = new GetKeywordPlanAdGroupRequest
            {
                ResourceNameAsKeywordPlanAdGroupName = KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
            };
            // Make the request
            KeywordPlanAdGroup response = await keywordPlanAdGroupServiceClient.GetKeywordPlanAdGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanAdGroup</summary>
        public void GetKeywordPlanAdGroup()
        {
            // Snippet: GetKeywordPlanAdGroup(string, CallSettings)
            // Create client
            KeywordPlanAdGroupServiceClient keywordPlanAdGroupServiceClient = KeywordPlanAdGroupServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/keywordPlanAdGroups/[KEYWORD_PLAN_AD_GROUP]";
            // Make the request
            KeywordPlanAdGroup response = keywordPlanAdGroupServiceClient.GetKeywordPlanAdGroup(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanAdGroupAsync</summary>
        public async Task GetKeywordPlanAdGroupAsync()
        {
            // Snippet: GetKeywordPlanAdGroupAsync(string, CallSettings)
            // Additional: GetKeywordPlanAdGroupAsync(string, CancellationToken)
            // Create client
            KeywordPlanAdGroupServiceClient keywordPlanAdGroupServiceClient = await KeywordPlanAdGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/keywordPlanAdGroups/[KEYWORD_PLAN_AD_GROUP]";
            // Make the request
            KeywordPlanAdGroup response = await keywordPlanAdGroupServiceClient.GetKeywordPlanAdGroupAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanAdGroup</summary>
        public void GetKeywordPlanAdGroupResourceNames()
        {
            // Snippet: GetKeywordPlanAdGroup(KeywordPlanAdGroupName, CallSettings)
            // Create client
            KeywordPlanAdGroupServiceClient keywordPlanAdGroupServiceClient = KeywordPlanAdGroupServiceClient.Create();
            // Initialize request argument(s)
            KeywordPlanAdGroupName resourceName = KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]");
            // Make the request
            KeywordPlanAdGroup response = keywordPlanAdGroupServiceClient.GetKeywordPlanAdGroup(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordPlanAdGroupAsync</summary>
        public async Task GetKeywordPlanAdGroupResourceNamesAsync()
        {
            // Snippet: GetKeywordPlanAdGroupAsync(KeywordPlanAdGroupName, CallSettings)
            // Additional: GetKeywordPlanAdGroupAsync(KeywordPlanAdGroupName, CancellationToken)
            // Create client
            KeywordPlanAdGroupServiceClient keywordPlanAdGroupServiceClient = await KeywordPlanAdGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeywordPlanAdGroupName resourceName = KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]");
            // Make the request
            KeywordPlanAdGroup response = await keywordPlanAdGroupServiceClient.GetKeywordPlanAdGroupAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanAdGroups</summary>
        public void MutateKeywordPlanAdGroupsRequestObject()
        {
            // Snippet: MutateKeywordPlanAdGroups(MutateKeywordPlanAdGroupsRequest, CallSettings)
            // Create client
            KeywordPlanAdGroupServiceClient keywordPlanAdGroupServiceClient = KeywordPlanAdGroupServiceClient.Create();
            // Initialize request argument(s)
            MutateKeywordPlanAdGroupsRequest request = new MutateKeywordPlanAdGroupsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new KeywordPlanAdGroupOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateKeywordPlanAdGroupsResponse response = keywordPlanAdGroupServiceClient.MutateKeywordPlanAdGroups(request);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanAdGroupsAsync</summary>
        public async Task MutateKeywordPlanAdGroupsRequestObjectAsync()
        {
            // Snippet: MutateKeywordPlanAdGroupsAsync(MutateKeywordPlanAdGroupsRequest, CallSettings)
            // Additional: MutateKeywordPlanAdGroupsAsync(MutateKeywordPlanAdGroupsRequest, CancellationToken)
            // Create client
            KeywordPlanAdGroupServiceClient keywordPlanAdGroupServiceClient = await KeywordPlanAdGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateKeywordPlanAdGroupsRequest request = new MutateKeywordPlanAdGroupsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new KeywordPlanAdGroupOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateKeywordPlanAdGroupsResponse response = await keywordPlanAdGroupServiceClient.MutateKeywordPlanAdGroupsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanAdGroups</summary>
        public void MutateKeywordPlanAdGroups()
        {
            // Snippet: MutateKeywordPlanAdGroups(string, IEnumerable<KeywordPlanAdGroupOperation>, CallSettings)
            // Create client
            KeywordPlanAdGroupServiceClient keywordPlanAdGroupServiceClient = KeywordPlanAdGroupServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<KeywordPlanAdGroupOperation> operations = new KeywordPlanAdGroupOperation[]
            {
                new KeywordPlanAdGroupOperation(),
            };
            // Make the request
            MutateKeywordPlanAdGroupsResponse response = keywordPlanAdGroupServiceClient.MutateKeywordPlanAdGroups(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateKeywordPlanAdGroupsAsync</summary>
        public async Task MutateKeywordPlanAdGroupsAsync()
        {
            // Snippet: MutateKeywordPlanAdGroupsAsync(string, IEnumerable<KeywordPlanAdGroupOperation>, CallSettings)
            // Additional: MutateKeywordPlanAdGroupsAsync(string, IEnumerable<KeywordPlanAdGroupOperation>, CancellationToken)
            // Create client
            KeywordPlanAdGroupServiceClient keywordPlanAdGroupServiceClient = await KeywordPlanAdGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<KeywordPlanAdGroupOperation> operations = new KeywordPlanAdGroupOperation[]
            {
                new KeywordPlanAdGroupOperation(),
            };
            // Make the request
            MutateKeywordPlanAdGroupsResponse response = await keywordPlanAdGroupServiceClient.MutateKeywordPlanAdGroupsAsync(customerId, operations);
            // End snippet
        }
    }
}
