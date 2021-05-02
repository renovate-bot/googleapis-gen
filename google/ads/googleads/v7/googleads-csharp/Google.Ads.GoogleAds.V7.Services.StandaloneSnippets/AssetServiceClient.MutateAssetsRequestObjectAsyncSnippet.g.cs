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
    using Google.Ads.GoogleAds.V7.Enums;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAssetServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for MutateAssetsAsync</summary>
        public async Task MutateAssetsRequestObjectAsync()
        {
            // Snippet: MutateAssetsAsync(MutateAssetsRequest, CallSettings)
            // Additional: MutateAssetsAsync(MutateAssetsRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAssetsRequest request = new MutateAssetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AssetOperation(),
                },
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
                ValidateOnly = false,
                PartialFailure = false,
            };
            // Make the request
            MutateAssetsResponse response = await assetServiceClient.MutateAssetsAsync(request);
            // End snippet
        }
    }
}
