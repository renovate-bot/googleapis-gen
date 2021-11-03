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
    public sealed class GeneratedAssetGroupListingGroupFilterServiceClientSnippets
    {
        /// <summary>Snippet for MutateAssetGroupListingGroupFilters</summary>
        public void MutateAssetGroupListingGroupFiltersRequestObject()
        {
            // Snippet: MutateAssetGroupListingGroupFilters(MutateAssetGroupListingGroupFiltersRequest, CallSettings)
            // Create client
            AssetGroupListingGroupFilterServiceClient assetGroupListingGroupFilterServiceClient = AssetGroupListingGroupFilterServiceClient.Create();
            // Initialize request argument(s)
            MutateAssetGroupListingGroupFiltersRequest request = new MutateAssetGroupListingGroupFiltersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AssetGroupListingGroupFilterOperation(),
                },
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAssetGroupListingGroupFiltersResponse response = assetGroupListingGroupFilterServiceClient.MutateAssetGroupListingGroupFilters(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetGroupListingGroupFiltersAsync</summary>
        public async Task MutateAssetGroupListingGroupFiltersRequestObjectAsync()
        {
            // Snippet: MutateAssetGroupListingGroupFiltersAsync(MutateAssetGroupListingGroupFiltersRequest, CallSettings)
            // Additional: MutateAssetGroupListingGroupFiltersAsync(MutateAssetGroupListingGroupFiltersRequest, CancellationToken)
            // Create client
            AssetGroupListingGroupFilterServiceClient assetGroupListingGroupFilterServiceClient = await AssetGroupListingGroupFilterServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAssetGroupListingGroupFiltersRequest request = new MutateAssetGroupListingGroupFiltersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AssetGroupListingGroupFilterOperation(),
                },
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAssetGroupListingGroupFiltersResponse response = await assetGroupListingGroupFilterServiceClient.MutateAssetGroupListingGroupFiltersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetGroupListingGroupFilters</summary>
        public void MutateAssetGroupListingGroupFilters()
        {
            // Snippet: MutateAssetGroupListingGroupFilters(string, IEnumerable<AssetGroupListingGroupFilterOperation>, CallSettings)
            // Create client
            AssetGroupListingGroupFilterServiceClient assetGroupListingGroupFilterServiceClient = AssetGroupListingGroupFilterServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AssetGroupListingGroupFilterOperation> operations = new AssetGroupListingGroupFilterOperation[]
            {
                new AssetGroupListingGroupFilterOperation(),
            };
            // Make the request
            MutateAssetGroupListingGroupFiltersResponse response = assetGroupListingGroupFilterServiceClient.MutateAssetGroupListingGroupFilters(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetGroupListingGroupFiltersAsync</summary>
        public async Task MutateAssetGroupListingGroupFiltersAsync()
        {
            // Snippet: MutateAssetGroupListingGroupFiltersAsync(string, IEnumerable<AssetGroupListingGroupFilterOperation>, CallSettings)
            // Additional: MutateAssetGroupListingGroupFiltersAsync(string, IEnumerable<AssetGroupListingGroupFilterOperation>, CancellationToken)
            // Create client
            AssetGroupListingGroupFilterServiceClient assetGroupListingGroupFilterServiceClient = await AssetGroupListingGroupFilterServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AssetGroupListingGroupFilterOperation> operations = new AssetGroupListingGroupFilterOperation[]
            {
                new AssetGroupListingGroupFilterOperation(),
            };
            // Make the request
            MutateAssetGroupListingGroupFiltersResponse response = await assetGroupListingGroupFilterServiceClient.MutateAssetGroupListingGroupFiltersAsync(customerId, operations);
            // End snippet
        }
    }
}
