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

namespace Google.Ads.GoogleAds.V4.Services.Snippets
{
    public sealed partial class GeneratedKeywordPlanAdGroupServiceClientStandaloneSnippets
    {
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
    }
}
