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
    using Google.Ads.GoogleAds.V7.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAdGroupAssetServiceClientSnippets
    {
        /// <summary>Snippet for GetAdGroupAsset</summary>
        public void GetAdGroupAssetRequestObject()
        {
            // Snippet: GetAdGroupAsset(GetAdGroupAssetRequest, CallSettings)
            // Create client
            AdGroupAssetServiceClient adGroupAssetServiceClient = AdGroupAssetServiceClient.Create();
            // Initialize request argument(s)
            GetAdGroupAssetRequest request = new GetAdGroupAssetRequest
            {
                ResourceNameAsAdGroupAssetName = AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            // Make the request
            AdGroupAsset response = adGroupAssetServiceClient.GetAdGroupAsset(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAssetAsync</summary>
        public async Task GetAdGroupAssetRequestObjectAsync()
        {
            // Snippet: GetAdGroupAssetAsync(GetAdGroupAssetRequest, CallSettings)
            // Additional: GetAdGroupAssetAsync(GetAdGroupAssetRequest, CancellationToken)
            // Create client
            AdGroupAssetServiceClient adGroupAssetServiceClient = await AdGroupAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdGroupAssetRequest request = new GetAdGroupAssetRequest
            {
                ResourceNameAsAdGroupAssetName = AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            // Make the request
            AdGroupAsset response = await adGroupAssetServiceClient.GetAdGroupAssetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAsset</summary>
        public void GetAdGroupAsset()
        {
            // Snippet: GetAdGroupAsset(string, CallSettings)
            // Create client
            AdGroupAssetServiceClient adGroupAssetServiceClient = AdGroupAssetServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupAssets/[AD_GROUP_ID]~[ASSET_ID]~[FIELD_TYPE]";
            // Make the request
            AdGroupAsset response = adGroupAssetServiceClient.GetAdGroupAsset(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAssetAsync</summary>
        public async Task GetAdGroupAssetAsync()
        {
            // Snippet: GetAdGroupAssetAsync(string, CallSettings)
            // Additional: GetAdGroupAssetAsync(string, CancellationToken)
            // Create client
            AdGroupAssetServiceClient adGroupAssetServiceClient = await AdGroupAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupAssets/[AD_GROUP_ID]~[ASSET_ID]~[FIELD_TYPE]";
            // Make the request
            AdGroupAsset response = await adGroupAssetServiceClient.GetAdGroupAssetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAsset</summary>
        public void GetAdGroupAssetResourceNames()
        {
            // Snippet: GetAdGroupAsset(AdGroupAssetName, CallSettings)
            // Create client
            AdGroupAssetServiceClient adGroupAssetServiceClient = AdGroupAssetServiceClient.Create();
            // Initialize request argument(s)
            AdGroupAssetName resourceName = AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]");
            // Make the request
            AdGroupAsset response = adGroupAssetServiceClient.GetAdGroupAsset(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAssetAsync</summary>
        public async Task GetAdGroupAssetResourceNamesAsync()
        {
            // Snippet: GetAdGroupAssetAsync(AdGroupAssetName, CallSettings)
            // Additional: GetAdGroupAssetAsync(AdGroupAssetName, CancellationToken)
            // Create client
            AdGroupAssetServiceClient adGroupAssetServiceClient = await AdGroupAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdGroupAssetName resourceName = AdGroupAssetName.FromCustomerAdGroupAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[ASSET_ID]", "[FIELD_TYPE]");
            // Make the request
            AdGroupAsset response = await adGroupAssetServiceClient.GetAdGroupAssetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupAssets</summary>
        public void MutateAdGroupAssetsRequestObject()
        {
            // Snippet: MutateAdGroupAssets(MutateAdGroupAssetsRequest, CallSettings)
            // Create client
            AdGroupAssetServiceClient adGroupAssetServiceClient = AdGroupAssetServiceClient.Create();
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
            MutateAdGroupAssetsResponse response = adGroupAssetServiceClient.MutateAdGroupAssets(request);
            // End snippet
        }

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

        /// <summary>Snippet for MutateAdGroupAssets</summary>
        public void MutateAdGroupAssets()
        {
            // Snippet: MutateAdGroupAssets(string, IEnumerable<AdGroupAssetOperation>, CallSettings)
            // Create client
            AdGroupAssetServiceClient adGroupAssetServiceClient = AdGroupAssetServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupAssetOperation> operations = new AdGroupAssetOperation[]
            {
                new AdGroupAssetOperation(),
            };
            // Make the request
            MutateAdGroupAssetsResponse response = adGroupAssetServiceClient.MutateAdGroupAssets(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupAssetsAsync</summary>
        public async Task MutateAdGroupAssetsAsync()
        {
            // Snippet: MutateAdGroupAssetsAsync(string, IEnumerable<AdGroupAssetOperation>, CallSettings)
            // Additional: MutateAdGroupAssetsAsync(string, IEnumerable<AdGroupAssetOperation>, CancellationToken)
            // Create client
            AdGroupAssetServiceClient adGroupAssetServiceClient = await AdGroupAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupAssetOperation> operations = new AdGroupAssetOperation[]
            {
                new AdGroupAssetOperation(),
            };
            // Make the request
            MutateAdGroupAssetsResponse response = await adGroupAssetServiceClient.MutateAdGroupAssetsAsync(customerId, operations);
            // End snippet
        }
    }
}
