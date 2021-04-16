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
    using System.Threading.Tasks;

    public sealed partial class GeneratedKeywordPlanAdGroupKeywordServiceClientStandaloneSnippets
    {
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
    }
}
