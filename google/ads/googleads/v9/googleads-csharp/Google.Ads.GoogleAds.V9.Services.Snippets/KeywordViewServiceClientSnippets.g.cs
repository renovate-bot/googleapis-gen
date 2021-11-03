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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedKeywordViewServiceClientSnippets
    {
        /// <summary>Snippet for GetKeywordView</summary>
        public void GetKeywordViewRequestObject()
        {
            // Snippet: GetKeywordView(GetKeywordViewRequest, CallSettings)
            // Create client
            KeywordViewServiceClient keywordViewServiceClient = KeywordViewServiceClient.Create();
            // Initialize request argument(s)
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceNameAsKeywordViewName = KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            KeywordView response = keywordViewServiceClient.GetKeywordView(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordViewAsync</summary>
        public async Task GetKeywordViewRequestObjectAsync()
        {
            // Snippet: GetKeywordViewAsync(GetKeywordViewRequest, CallSettings)
            // Additional: GetKeywordViewAsync(GetKeywordViewRequest, CancellationToken)
            // Create client
            KeywordViewServiceClient keywordViewServiceClient = await KeywordViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceNameAsKeywordViewName = KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            KeywordView response = await keywordViewServiceClient.GetKeywordViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordView</summary>
        public void GetKeywordView()
        {
            // Snippet: GetKeywordView(string, CallSettings)
            // Create client
            KeywordViewServiceClient keywordViewServiceClient = KeywordViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/keywordViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            KeywordView response = keywordViewServiceClient.GetKeywordView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordViewAsync</summary>
        public async Task GetKeywordViewAsync()
        {
            // Snippet: GetKeywordViewAsync(string, CallSettings)
            // Additional: GetKeywordViewAsync(string, CancellationToken)
            // Create client
            KeywordViewServiceClient keywordViewServiceClient = await KeywordViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/keywordViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            KeywordView response = await keywordViewServiceClient.GetKeywordViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordView</summary>
        public void GetKeywordViewResourceNames()
        {
            // Snippet: GetKeywordView(KeywordViewName, CallSettings)
            // Create client
            KeywordViewServiceClient keywordViewServiceClient = KeywordViewServiceClient.Create();
            // Initialize request argument(s)
            KeywordViewName resourceName = KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            KeywordView response = keywordViewServiceClient.GetKeywordView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordViewAsync</summary>
        public async Task GetKeywordViewResourceNamesAsync()
        {
            // Snippet: GetKeywordViewAsync(KeywordViewName, CallSettings)
            // Additional: GetKeywordViewAsync(KeywordViewName, CancellationToken)
            // Create client
            KeywordViewServiceClient keywordViewServiceClient = await KeywordViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeywordViewName resourceName = KeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            KeywordView response = await keywordViewServiceClient.GetKeywordViewAsync(resourceName);
            // End snippet
        }
    }
}
