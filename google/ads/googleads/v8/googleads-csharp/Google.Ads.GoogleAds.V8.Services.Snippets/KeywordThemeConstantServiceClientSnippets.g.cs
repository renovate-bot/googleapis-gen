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
    public sealed class GeneratedKeywordThemeConstantServiceClientSnippets
    {
        /// <summary>Snippet for GetKeywordThemeConstant</summary>
        public void GetKeywordThemeConstantRequestObject()
        {
            // Snippet: GetKeywordThemeConstant(GetKeywordThemeConstantRequest, CallSettings)
            // Create client
            KeywordThemeConstantServiceClient keywordThemeConstantServiceClient = KeywordThemeConstantServiceClient.Create();
            // Initialize request argument(s)
            GetKeywordThemeConstantRequest request = new GetKeywordThemeConstantRequest
            {
                ResourceNameAsKeywordThemeConstantName = KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]"),
            };
            // Make the request
            KeywordThemeConstant response = keywordThemeConstantServiceClient.GetKeywordThemeConstant(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordThemeConstantAsync</summary>
        public async Task GetKeywordThemeConstantRequestObjectAsync()
        {
            // Snippet: GetKeywordThemeConstantAsync(GetKeywordThemeConstantRequest, CallSettings)
            // Additional: GetKeywordThemeConstantAsync(GetKeywordThemeConstantRequest, CancellationToken)
            // Create client
            KeywordThemeConstantServiceClient keywordThemeConstantServiceClient = await KeywordThemeConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetKeywordThemeConstantRequest request = new GetKeywordThemeConstantRequest
            {
                ResourceNameAsKeywordThemeConstantName = KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]"),
            };
            // Make the request
            KeywordThemeConstant response = await keywordThemeConstantServiceClient.GetKeywordThemeConstantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordThemeConstant</summary>
        public void GetKeywordThemeConstant()
        {
            // Snippet: GetKeywordThemeConstant(string, CallSettings)
            // Create client
            KeywordThemeConstantServiceClient keywordThemeConstantServiceClient = KeywordThemeConstantServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "keywordThemeConstants/[EXPRESS_CATEGORY_ID]~[EXPRESS_SUB_CATEGORY_ID]";
            // Make the request
            KeywordThemeConstant response = keywordThemeConstantServiceClient.GetKeywordThemeConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordThemeConstantAsync</summary>
        public async Task GetKeywordThemeConstantAsync()
        {
            // Snippet: GetKeywordThemeConstantAsync(string, CallSettings)
            // Additional: GetKeywordThemeConstantAsync(string, CancellationToken)
            // Create client
            KeywordThemeConstantServiceClient keywordThemeConstantServiceClient = await KeywordThemeConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "keywordThemeConstants/[EXPRESS_CATEGORY_ID]~[EXPRESS_SUB_CATEGORY_ID]";
            // Make the request
            KeywordThemeConstant response = await keywordThemeConstantServiceClient.GetKeywordThemeConstantAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordThemeConstant</summary>
        public void GetKeywordThemeConstantResourceNames()
        {
            // Snippet: GetKeywordThemeConstant(KeywordThemeConstantName, CallSettings)
            // Create client
            KeywordThemeConstantServiceClient keywordThemeConstantServiceClient = KeywordThemeConstantServiceClient.Create();
            // Initialize request argument(s)
            KeywordThemeConstantName resourceName = KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]");
            // Make the request
            KeywordThemeConstant response = keywordThemeConstantServiceClient.GetKeywordThemeConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetKeywordThemeConstantAsync</summary>
        public async Task GetKeywordThemeConstantResourceNamesAsync()
        {
            // Snippet: GetKeywordThemeConstantAsync(KeywordThemeConstantName, CallSettings)
            // Additional: GetKeywordThemeConstantAsync(KeywordThemeConstantName, CancellationToken)
            // Create client
            KeywordThemeConstantServiceClient keywordThemeConstantServiceClient = await KeywordThemeConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeywordThemeConstantName resourceName = KeywordThemeConstantName.FromExpressCategoryExpressSubCategory("[EXPRESS_CATEGORY_ID]", "[EXPRESS_SUB_CATEGORY_ID]");
            // Make the request
            KeywordThemeConstant response = await keywordThemeConstantServiceClient.GetKeywordThemeConstantAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for SuggestKeywordThemeConstants</summary>
        public void SuggestKeywordThemeConstantsRequestObject()
        {
            // Snippet: SuggestKeywordThemeConstants(SuggestKeywordThemeConstantsRequest, CallSettings)
            // Create client
            KeywordThemeConstantServiceClient keywordThemeConstantServiceClient = KeywordThemeConstantServiceClient.Create();
            // Initialize request argument(s)
            SuggestKeywordThemeConstantsRequest request = new SuggestKeywordThemeConstantsRequest
            {
                QueryText = "",
                CountryCode = "",
                LanguageCode = "",
            };
            // Make the request
            SuggestKeywordThemeConstantsResponse response = keywordThemeConstantServiceClient.SuggestKeywordThemeConstants(request);
            // End snippet
        }

        /// <summary>Snippet for SuggestKeywordThemeConstantsAsync</summary>
        public async Task SuggestKeywordThemeConstantsRequestObjectAsync()
        {
            // Snippet: SuggestKeywordThemeConstantsAsync(SuggestKeywordThemeConstantsRequest, CallSettings)
            // Additional: SuggestKeywordThemeConstantsAsync(SuggestKeywordThemeConstantsRequest, CancellationToken)
            // Create client
            KeywordThemeConstantServiceClient keywordThemeConstantServiceClient = await KeywordThemeConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            SuggestKeywordThemeConstantsRequest request = new SuggestKeywordThemeConstantsRequest
            {
                QueryText = "",
                CountryCode = "",
                LanguageCode = "",
            };
            // Make the request
            SuggestKeywordThemeConstantsResponse response = await keywordThemeConstantServiceClient.SuggestKeywordThemeConstantsAsync(request);
            // End snippet
        }
    }
}
