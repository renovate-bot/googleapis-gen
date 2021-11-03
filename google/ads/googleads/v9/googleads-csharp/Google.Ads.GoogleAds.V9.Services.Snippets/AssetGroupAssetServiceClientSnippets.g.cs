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
    using Google.Ads.GoogleAds.V9.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAssetGroupAssetServiceClientSnippets
    {
        /// <summary>Snippet for GetAssetGroupAsset</summary>
        public void GetAssetGroupAssetRequestObject()
        {
            // Snippet: GetAssetGroupAsset(GetAssetGroupAssetRequest, CallSettings)
            // Create client
            AssetGroupAssetServiceClient assetGroupAssetServiceClient = AssetGroupAssetServiceClient.Create();
            // Initialize request argument(s)
            GetAssetGroupAssetRequest request = new GetAssetGroupAssetRequest
            {
                ResourceNameAsAssetGroupAssetName = AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            // Make the request
            AssetGroupAsset response = assetGroupAssetServiceClient.GetAssetGroupAsset(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssetGroupAssetAsync</summary>
        public async Task GetAssetGroupAssetRequestObjectAsync()
        {
            // Snippet: GetAssetGroupAssetAsync(GetAssetGroupAssetRequest, CallSettings)
            // Additional: GetAssetGroupAssetAsync(GetAssetGroupAssetRequest, CancellationToken)
            // Create client
            AssetGroupAssetServiceClient assetGroupAssetServiceClient = await AssetGroupAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAssetGroupAssetRequest request = new GetAssetGroupAssetRequest
            {
                ResourceNameAsAssetGroupAssetName = AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            // Make the request
            AssetGroupAsset response = await assetGroupAssetServiceClient.GetAssetGroupAssetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssetGroupAsset</summary>
        public void GetAssetGroupAsset()
        {
            // Snippet: GetAssetGroupAsset(string, CallSettings)
            // Create client
            AssetGroupAssetServiceClient assetGroupAssetServiceClient = AssetGroupAssetServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/assetGroupAssets/[ASSET_GROUP_ID]~[ASSET_ID]~[FIELD_TYPE]";
            // Make the request
            AssetGroupAsset response = assetGroupAssetServiceClient.GetAssetGroupAsset(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAssetGroupAssetAsync</summary>
        public async Task GetAssetGroupAssetAsync()
        {
            // Snippet: GetAssetGroupAssetAsync(string, CallSettings)
            // Additional: GetAssetGroupAssetAsync(string, CancellationToken)
            // Create client
            AssetGroupAssetServiceClient assetGroupAssetServiceClient = await AssetGroupAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/assetGroupAssets/[ASSET_GROUP_ID]~[ASSET_ID]~[FIELD_TYPE]";
            // Make the request
            AssetGroupAsset response = await assetGroupAssetServiceClient.GetAssetGroupAssetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAssetGroupAsset</summary>
        public void GetAssetGroupAssetResourceNames()
        {
            // Snippet: GetAssetGroupAsset(AssetGroupAssetName, CallSettings)
            // Create client
            AssetGroupAssetServiceClient assetGroupAssetServiceClient = AssetGroupAssetServiceClient.Create();
            // Initialize request argument(s)
            AssetGroupAssetName resourceName = AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]");
            // Make the request
            AssetGroupAsset response = assetGroupAssetServiceClient.GetAssetGroupAsset(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAssetGroupAssetAsync</summary>
        public async Task GetAssetGroupAssetResourceNamesAsync()
        {
            // Snippet: GetAssetGroupAssetAsync(AssetGroupAssetName, CallSettings)
            // Additional: GetAssetGroupAssetAsync(AssetGroupAssetName, CancellationToken)
            // Create client
            AssetGroupAssetServiceClient assetGroupAssetServiceClient = await AssetGroupAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssetGroupAssetName resourceName = AssetGroupAssetName.FromCustomerAssetGroupAssetFieldType("[CUSTOMER_ID]", "[ASSET_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]");
            // Make the request
            AssetGroupAsset response = await assetGroupAssetServiceClient.GetAssetGroupAssetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetGroupAssets</summary>
        public void MutateAssetGroupAssetsRequestObject()
        {
            // Snippet: MutateAssetGroupAssets(MutateAssetGroupAssetsRequest, CallSettings)
            // Create client
            AssetGroupAssetServiceClient assetGroupAssetServiceClient = AssetGroupAssetServiceClient.Create();
            // Initialize request argument(s)
            MutateAssetGroupAssetsRequest request = new MutateAssetGroupAssetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AssetGroupAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateAssetGroupAssetsResponse response = assetGroupAssetServiceClient.MutateAssetGroupAssets(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetGroupAssetsAsync</summary>
        public async Task MutateAssetGroupAssetsRequestObjectAsync()
        {
            // Snippet: MutateAssetGroupAssetsAsync(MutateAssetGroupAssetsRequest, CallSettings)
            // Additional: MutateAssetGroupAssetsAsync(MutateAssetGroupAssetsRequest, CancellationToken)
            // Create client
            AssetGroupAssetServiceClient assetGroupAssetServiceClient = await AssetGroupAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAssetGroupAssetsRequest request = new MutateAssetGroupAssetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AssetGroupAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateAssetGroupAssetsResponse response = await assetGroupAssetServiceClient.MutateAssetGroupAssetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetGroupAssets</summary>
        public void MutateAssetGroupAssets()
        {
            // Snippet: MutateAssetGroupAssets(string, IEnumerable<AssetGroupAssetOperation>, CallSettings)
            // Create client
            AssetGroupAssetServiceClient assetGroupAssetServiceClient = AssetGroupAssetServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AssetGroupAssetOperation> operations = new AssetGroupAssetOperation[]
            {
                new AssetGroupAssetOperation(),
            };
            // Make the request
            MutateAssetGroupAssetsResponse response = assetGroupAssetServiceClient.MutateAssetGroupAssets(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetGroupAssetsAsync</summary>
        public async Task MutateAssetGroupAssetsAsync()
        {
            // Snippet: MutateAssetGroupAssetsAsync(string, IEnumerable<AssetGroupAssetOperation>, CallSettings)
            // Additional: MutateAssetGroupAssetsAsync(string, IEnumerable<AssetGroupAssetOperation>, CancellationToken)
            // Create client
            AssetGroupAssetServiceClient assetGroupAssetServiceClient = await AssetGroupAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AssetGroupAssetOperation> operations = new AssetGroupAssetOperation[]
            {
                new AssetGroupAssetOperation(),
            };
            // Make the request
            MutateAssetGroupAssetsResponse response = await assetGroupAssetServiceClient.MutateAssetGroupAssetsAsync(customerId, operations);
            // End snippet
        }
    }
}
