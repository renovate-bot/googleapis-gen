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

namespace Google.Cloud.Talent.V4Beta1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedProfileServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for SearchProfilesAsync</summary>
        public async Task SearchProfilesRequestObjectAsync()
        {
            // Snippet: SearchProfilesAsync(SearchProfilesRequest, CallSettings)
            // Additional: SearchProfilesAsync(SearchProfilesRequest, CancellationToken)
            // Create client
            ProfileServiceClient profileServiceClient = await ProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchProfilesRequest request = new SearchProfilesRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                RequestMetadata = new RequestMetadata(),
                ProfileQuery = new ProfileQuery(),
                PageSize = 0,
                PageToken = "",
                Offset = 0,
                DisableSpellCheck = false,
                OrderBy = "",
                CaseSensitiveSort = false,
                HistogramQueries =
                {
                    new HistogramQuery(),
                },
                ResultSetId = "",
                StrictKeywordsSearch = false,
            };
            // Make the request
            SearchProfilesResponse response = await profileServiceClient.SearchProfilesAsync(request);
            // End snippet
        }
    }
}
