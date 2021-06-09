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
    using Google.Ads.GoogleAds.V8.Services;

    public sealed partial class GeneratedKeywordPlanAdGroupKeywordServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetKeywordPlanAdGroupKeyword</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetKeywordPlanAdGroupKeywordRequestObject()
        {
            // Create client
            KeywordPlanAdGroupKeywordServiceClient keywordPlanAdGroupKeywordServiceClient = KeywordPlanAdGroupKeywordServiceClient.Create();
            // Initialize request argument(s)
            GetKeywordPlanAdGroupKeywordRequest request = new GetKeywordPlanAdGroupKeywordRequest
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER_ID]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD_ID]"),
            };
            // Make the request
            KeywordPlanAdGroupKeyword response = keywordPlanAdGroupKeywordServiceClient.GetKeywordPlanAdGroupKeyword(request);
        }
    }
}
