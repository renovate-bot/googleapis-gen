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
    public sealed class GeneratedAssetSetServiceClientSnippets
    {
        /// <summary>Snippet for MutateAssetSets</summary>
        public void MutateAssetSetsRequestObject()
        {
            // Snippet: MutateAssetSets(MutateAssetSetsRequest, CallSettings)
            // Create client
            AssetSetServiceClient assetSetServiceClient = AssetSetServiceClient.Create();
            // Initialize request argument(s)
            MutateAssetSetsRequest request = new MutateAssetSetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AssetSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAssetSetsResponse response = assetSetServiceClient.MutateAssetSets(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetSetsAsync</summary>
        public async Task MutateAssetSetsRequestObjectAsync()
        {
            // Snippet: MutateAssetSetsAsync(MutateAssetSetsRequest, CallSettings)
            // Additional: MutateAssetSetsAsync(MutateAssetSetsRequest, CancellationToken)
            // Create client
            AssetSetServiceClient assetSetServiceClient = await AssetSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAssetSetsRequest request = new MutateAssetSetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AssetSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAssetSetsResponse response = await assetSetServiceClient.MutateAssetSetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetSets</summary>
        public void MutateAssetSets()
        {
            // Snippet: MutateAssetSets(string, IEnumerable<AssetSetOperation>, CallSettings)
            // Create client
            AssetSetServiceClient assetSetServiceClient = AssetSetServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AssetSetOperation> operations = new AssetSetOperation[]
            {
                new AssetSetOperation(),
            };
            // Make the request
            MutateAssetSetsResponse response = assetSetServiceClient.MutateAssetSets(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetSetsAsync</summary>
        public async Task MutateAssetSetsAsync()
        {
            // Snippet: MutateAssetSetsAsync(string, IEnumerable<AssetSetOperation>, CallSettings)
            // Additional: MutateAssetSetsAsync(string, IEnumerable<AssetSetOperation>, CancellationToken)
            // Create client
            AssetSetServiceClient assetSetServiceClient = await AssetSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AssetSetOperation> operations = new AssetSetOperation[]
            {
                new AssetSetOperation(),
            };
            // Make the request
            MutateAssetSetsResponse response = await assetSetServiceClient.MutateAssetSetsAsync(customerId, operations);
            // End snippet
        }
    }
}
