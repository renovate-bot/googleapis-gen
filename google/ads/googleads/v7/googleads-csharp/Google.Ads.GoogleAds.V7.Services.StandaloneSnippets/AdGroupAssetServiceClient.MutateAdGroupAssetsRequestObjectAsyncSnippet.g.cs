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

namespace Google.Ads.GoogleAds.V7.Services.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedAdGroupAssetServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for MutateAdGroupAssetsAsync</summary>
        public async Task MutateAdGroupAssetsRequestObjectAsync()
        {
            // Snippet: MutateAdGroupAssetsAsync(MutateAdGroupAssetsRequest, CallSettings)
            // Additional: MutateAdGroupAssetsAsync(MutateAdGroupAssetsRequest, CancellationToken)
            // Create client
            AdGroupAssetServiceClient adGroupAssetServiceClient = await AdGroupAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAdGroupAssetsRequest request = new MutateAdGroupAssetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateAdGroupAssetsResponse response = await adGroupAssetServiceClient.MutateAdGroupAssetsAsync(request);
            // End snippet
        }
    }
}
