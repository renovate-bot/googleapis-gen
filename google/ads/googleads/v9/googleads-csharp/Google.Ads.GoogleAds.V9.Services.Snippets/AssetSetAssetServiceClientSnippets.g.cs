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
    using Google.Ads.GoogleAds.V9.Enums;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAssetSetAssetServiceClientSnippets
    {
        /// <summary>Snippet for MutateAssetSetAssets</summary>
        public void MutateAssetSetAssetsRequestObject()
        {
            // Snippet: MutateAssetSetAssets(MutateAssetSetAssetsRequest, CallSettings)
            // Create client
            AssetSetAssetServiceClient assetSetAssetServiceClient = AssetSetAssetServiceClient.Create();
            // Initialize request argument(s)
            MutateAssetSetAssetsRequest request = new MutateAssetSetAssetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AssetSetAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAssetSetAssetsResponse response = assetSetAssetServiceClient.MutateAssetSetAssets(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetSetAssetsAsync</summary>
        public async Task MutateAssetSetAssetsRequestObjectAsync()
        {
            // Snippet: MutateAssetSetAssetsAsync(MutateAssetSetAssetsRequest, CallSettings)
            // Additional: MutateAssetSetAssetsAsync(MutateAssetSetAssetsRequest, CancellationToken)
            // Create client
            AssetSetAssetServiceClient assetSetAssetServiceClient = await AssetSetAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAssetSetAssetsRequest request = new MutateAssetSetAssetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AssetSetAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAssetSetAssetsResponse response = await assetSetAssetServiceClient.MutateAssetSetAssetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetSetAssets</summary>
        public void MutateAssetSetAssets()
        {
            // Snippet: MutateAssetSetAssets(string, IEnumerable<AssetSetAssetOperation>, CallSettings)
            // Create client
            AssetSetAssetServiceClient assetSetAssetServiceClient = AssetSetAssetServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AssetSetAssetOperation> operations = new AssetSetAssetOperation[]
            {
                new AssetSetAssetOperation(),
            };
            // Make the request
            MutateAssetSetAssetsResponse response = assetSetAssetServiceClient.MutateAssetSetAssets(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetSetAssetsAsync</summary>
        public async Task MutateAssetSetAssetsAsync()
        {
            // Snippet: MutateAssetSetAssetsAsync(string, IEnumerable<AssetSetAssetOperation>, CallSettings)
            // Additional: MutateAssetSetAssetsAsync(string, IEnumerable<AssetSetAssetOperation>, CancellationToken)
            // Create client
            AssetSetAssetServiceClient assetSetAssetServiceClient = await AssetSetAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AssetSetAssetOperation> operations = new AssetSetAssetOperation[]
            {
                new AssetSetAssetOperation(),
            };
            // Make the request
            MutateAssetSetAssetsResponse response = await assetSetAssetServiceClient.MutateAssetSetAssetsAsync(customerId, operations);
            // End snippet
        }
    }
}
