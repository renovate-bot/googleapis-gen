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

namespace Google.Ads.GoogleAds.V8.Services.Snippets
{
    using Google.Ads.GoogleAds.V8.Enums;
    using Google.Ads.GoogleAds.V8.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomerAssetServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomerAsset</summary>
        public void GetCustomerAssetRequestObject()
        {
            // Snippet: GetCustomerAsset(GetCustomerAssetRequest, CallSettings)
            // Create client
            CustomerAssetServiceClient customerAssetServiceClient = CustomerAssetServiceClient.Create();
            // Initialize request argument(s)
            GetCustomerAssetRequest request = new GetCustomerAssetRequest
            {
                ResourceNameAsCustomerAssetName = CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            // Make the request
            CustomerAsset response = customerAssetServiceClient.GetCustomerAsset(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerAssetAsync</summary>
        public async Task GetCustomerAssetRequestObjectAsync()
        {
            // Snippet: GetCustomerAssetAsync(GetCustomerAssetRequest, CallSettings)
            // Additional: GetCustomerAssetAsync(GetCustomerAssetRequest, CancellationToken)
            // Create client
            CustomerAssetServiceClient customerAssetServiceClient = await CustomerAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomerAssetRequest request = new GetCustomerAssetRequest
            {
                ResourceNameAsCustomerAssetName = CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            // Make the request
            CustomerAsset response = await customerAssetServiceClient.GetCustomerAssetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerAsset</summary>
        public void GetCustomerAsset()
        {
            // Snippet: GetCustomerAsset(string, CallSettings)
            // Create client
            CustomerAssetServiceClient customerAssetServiceClient = CustomerAssetServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerAssets/[ASSET_ID]~[FIELD_TYPE]";
            // Make the request
            CustomerAsset response = customerAssetServiceClient.GetCustomerAsset(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerAssetAsync</summary>
        public async Task GetCustomerAssetAsync()
        {
            // Snippet: GetCustomerAssetAsync(string, CallSettings)
            // Additional: GetCustomerAssetAsync(string, CancellationToken)
            // Create client
            CustomerAssetServiceClient customerAssetServiceClient = await CustomerAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerAssets/[ASSET_ID]~[FIELD_TYPE]";
            // Make the request
            CustomerAsset response = await customerAssetServiceClient.GetCustomerAssetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerAsset</summary>
        public void GetCustomerAssetResourceNames()
        {
            // Snippet: GetCustomerAsset(CustomerAssetName, CallSettings)
            // Create client
            CustomerAssetServiceClient customerAssetServiceClient = CustomerAssetServiceClient.Create();
            // Initialize request argument(s)
            CustomerAssetName resourceName = CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]");
            // Make the request
            CustomerAsset response = customerAssetServiceClient.GetCustomerAsset(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerAssetAsync</summary>
        public async Task GetCustomerAssetResourceNamesAsync()
        {
            // Snippet: GetCustomerAssetAsync(CustomerAssetName, CallSettings)
            // Additional: GetCustomerAssetAsync(CustomerAssetName, CancellationToken)
            // Create client
            CustomerAssetServiceClient customerAssetServiceClient = await CustomerAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomerAssetName resourceName = CustomerAssetName.FromCustomerAssetFieldType("[CUSTOMER_ID]", "[ASSET_ID]", "[FIELD_TYPE]");
            // Make the request
            CustomerAsset response = await customerAssetServiceClient.GetCustomerAssetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerAssets</summary>
        public void MutateCustomerAssetsRequestObject()
        {
            // Snippet: MutateCustomerAssets(MutateCustomerAssetsRequest, CallSettings)
            // Create client
            CustomerAssetServiceClient customerAssetServiceClient = CustomerAssetServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomerAssetsRequest request = new MutateCustomerAssetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomerAssetsResponse response = customerAssetServiceClient.MutateCustomerAssets(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerAssetsAsync</summary>
        public async Task MutateCustomerAssetsRequestObjectAsync()
        {
            // Snippet: MutateCustomerAssetsAsync(MutateCustomerAssetsRequest, CallSettings)
            // Additional: MutateCustomerAssetsAsync(MutateCustomerAssetsRequest, CancellationToken)
            // Create client
            CustomerAssetServiceClient customerAssetServiceClient = await CustomerAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomerAssetsRequest request = new MutateCustomerAssetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomerAssetsResponse response = await customerAssetServiceClient.MutateCustomerAssetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerAssets</summary>
        public void MutateCustomerAssets()
        {
            // Snippet: MutateCustomerAssets(string, IEnumerable<CustomerAssetOperation>, CallSettings)
            // Create client
            CustomerAssetServiceClient customerAssetServiceClient = CustomerAssetServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerAssetOperation> operations = new CustomerAssetOperation[]
            {
                new CustomerAssetOperation(),
            };
            // Make the request
            MutateCustomerAssetsResponse response = customerAssetServiceClient.MutateCustomerAssets(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerAssetsAsync</summary>
        public async Task MutateCustomerAssetsAsync()
        {
            // Snippet: MutateCustomerAssetsAsync(string, IEnumerable<CustomerAssetOperation>, CallSettings)
            // Additional: MutateCustomerAssetsAsync(string, IEnumerable<CustomerAssetOperation>, CancellationToken)
            // Create client
            CustomerAssetServiceClient customerAssetServiceClient = await CustomerAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerAssetOperation> operations = new CustomerAssetOperation[]
            {
                new CustomerAssetOperation(),
            };
            // Make the request
            MutateCustomerAssetsResponse response = await customerAssetServiceClient.MutateCustomerAssetsAsync(customerId, operations);
            // End snippet
        }
    }
}
