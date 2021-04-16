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

namespace Google.Analytics.Data.V1Alpha.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedAlphaAnalyticsDataClientStandaloneSnippets
    {
        /// <summary>Snippet for GetMetadataAsync</summary>
        public async Task GetMetadataResourceNamesAsync()
        {
            // Snippet: GetMetadataAsync(MetadataName, CallSettings)
            // Additional: GetMetadataAsync(MetadataName, CancellationToken)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = await AlphaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            MetadataName name = MetadataName.FromProperty("[PROPERTY]");
            // Make the request
            Metadata response = await alphaAnalyticsDataClient.GetMetadataAsync(name);
            // End snippet
        }
    }
}
