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

namespace Google.Ads.GoogleAds.V5.Services.Snippets
{
    using Google.Ads.GoogleAds.V5.Enums;
    using Google.Ads.GoogleAds.V5.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAssetServiceClientSnippets
    {
        /// <summary>Snippet for GetAsset</summary>
        public void GetAssetRequestObject()
        {
            // Snippet: GetAsset(GetAssetRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            GetAssetRequest request = new GetAssetRequest
            {
                ResourceNameAsAssetName = AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
            };
            // Make the request
            Asset response = assetServiceClient.GetAsset(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssetAsync</summary>
        public async Task GetAssetRequestObjectAsync()
        {
            // Snippet: GetAssetAsync(GetAssetRequest, CallSettings)
            // Additional: GetAssetAsync(GetAssetRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAssetRequest request = new GetAssetRequest
            {
                ResourceNameAsAssetName = AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
            };
            // Make the request
            Asset response = await assetServiceClient.GetAssetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsset</summary>
        public void GetAsset()
        {
            // Snippet: GetAsset(string, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/assets/[ASSET]";
            // Make the request
            Asset response = assetServiceClient.GetAsset(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAssetAsync</summary>
        public async Task GetAssetAsync()
        {
            // Snippet: GetAssetAsync(string, CallSettings)
            // Additional: GetAssetAsync(string, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/assets/[ASSET]";
            // Make the request
            Asset response = await assetServiceClient.GetAssetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAsset</summary>
        public void GetAssetResourceNames()
        {
            // Snippet: GetAsset(AssetName, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            AssetName resourceName = AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]");
            // Make the request
            Asset response = assetServiceClient.GetAsset(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAssetAsync</summary>
        public async Task GetAssetResourceNamesAsync()
        {
            // Snippet: GetAssetAsync(AssetName, CallSettings)
            // Additional: GetAssetAsync(AssetName, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssetName resourceName = AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]");
            // Make the request
            Asset response = await assetServiceClient.GetAssetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAssets</summary>
        public void MutateAssetsRequestObject()
        {
            // Snippet: MutateAssets(MutateAssetsRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            MutateAssetsRequest request = new MutateAssetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AssetOperation(),
                },
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAssetsResponse response = assetServiceClient.MutateAssets(request);
            // End snippet
        }

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
            };
            // Make the request
            MutateAssetsResponse response = await assetServiceClient.MutateAssetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAssets</summary>
        public void MutateAssets()
        {
            // Snippet: MutateAssets(string, IEnumerable<AssetOperation>, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AssetOperation> operations = new AssetOperation[]
            {
                new AssetOperation(),
            };
            // Make the request
            MutateAssetsResponse response = assetServiceClient.MutateAssets(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetsAsync</summary>
        public async Task MutateAssetsAsync()
        {
            // Snippet: MutateAssetsAsync(string, IEnumerable<AssetOperation>, CallSettings)
            // Additional: MutateAssetsAsync(string, IEnumerable<AssetOperation>, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AssetOperation> operations = new AssetOperation[]
            {
                new AssetOperation(),
            };
            // Make the request
            MutateAssetsResponse response = await assetServiceClient.MutateAssetsAsync(customerId, operations);
            // End snippet
        }
    }
}
