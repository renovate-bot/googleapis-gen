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
    public sealed class GeneratedAssetGroupServiceClientSnippets
    {
        /// <summary>Snippet for GetAssetGroup</summary>
        public void GetAssetGroupRequestObject()
        {
            // Snippet: GetAssetGroup(GetAssetGroupRequest, CallSettings)
            // Create client
            AssetGroupServiceClient assetGroupServiceClient = AssetGroupServiceClient.Create();
            // Initialize request argument(s)
            GetAssetGroupRequest request = new GetAssetGroupRequest
            {
                ResourceNameAsAssetGroupName = AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
            };
            // Make the request
            AssetGroup response = assetGroupServiceClient.GetAssetGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssetGroupAsync</summary>
        public async Task GetAssetGroupRequestObjectAsync()
        {
            // Snippet: GetAssetGroupAsync(GetAssetGroupRequest, CallSettings)
            // Additional: GetAssetGroupAsync(GetAssetGroupRequest, CancellationToken)
            // Create client
            AssetGroupServiceClient assetGroupServiceClient = await AssetGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAssetGroupRequest request = new GetAssetGroupRequest
            {
                ResourceNameAsAssetGroupName = AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]"),
            };
            // Make the request
            AssetGroup response = await assetGroupServiceClient.GetAssetGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssetGroup</summary>
        public void GetAssetGroup()
        {
            // Snippet: GetAssetGroup(string, CallSettings)
            // Create client
            AssetGroupServiceClient assetGroupServiceClient = AssetGroupServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/assetGroups/[ASSET_GROUP_ID]";
            // Make the request
            AssetGroup response = assetGroupServiceClient.GetAssetGroup(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAssetGroupAsync</summary>
        public async Task GetAssetGroupAsync()
        {
            // Snippet: GetAssetGroupAsync(string, CallSettings)
            // Additional: GetAssetGroupAsync(string, CancellationToken)
            // Create client
            AssetGroupServiceClient assetGroupServiceClient = await AssetGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/assetGroups/[ASSET_GROUP_ID]";
            // Make the request
            AssetGroup response = await assetGroupServiceClient.GetAssetGroupAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAssetGroup</summary>
        public void GetAssetGroupResourceNames()
        {
            // Snippet: GetAssetGroup(AssetGroupName, CallSettings)
            // Create client
            AssetGroupServiceClient assetGroupServiceClient = AssetGroupServiceClient.Create();
            // Initialize request argument(s)
            AssetGroupName resourceName = AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]");
            // Make the request
            AssetGroup response = assetGroupServiceClient.GetAssetGroup(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAssetGroupAsync</summary>
        public async Task GetAssetGroupResourceNamesAsync()
        {
            // Snippet: GetAssetGroupAsync(AssetGroupName, CallSettings)
            // Additional: GetAssetGroupAsync(AssetGroupName, CancellationToken)
            // Create client
            AssetGroupServiceClient assetGroupServiceClient = await AssetGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssetGroupName resourceName = AssetGroupName.FromCustomerAssetGroup("[CUSTOMER_ID]", "[ASSET_GROUP_ID]");
            // Make the request
            AssetGroup response = await assetGroupServiceClient.GetAssetGroupAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetGroups</summary>
        public void MutateAssetGroupsRequestObject()
        {
            // Snippet: MutateAssetGroups(MutateAssetGroupsRequest, CallSettings)
            // Create client
            AssetGroupServiceClient assetGroupServiceClient = AssetGroupServiceClient.Create();
            // Initialize request argument(s)
            MutateAssetGroupsRequest request = new MutateAssetGroupsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AssetGroupOperation(),
                },
                ValidateOnly = false,
            };
            // Make the request
            MutateAssetGroupsResponse response = assetGroupServiceClient.MutateAssetGroups(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetGroupsAsync</summary>
        public async Task MutateAssetGroupsRequestObjectAsync()
        {
            // Snippet: MutateAssetGroupsAsync(MutateAssetGroupsRequest, CallSettings)
            // Additional: MutateAssetGroupsAsync(MutateAssetGroupsRequest, CancellationToken)
            // Create client
            AssetGroupServiceClient assetGroupServiceClient = await AssetGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAssetGroupsRequest request = new MutateAssetGroupsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AssetGroupOperation(),
                },
                ValidateOnly = false,
            };
            // Make the request
            MutateAssetGroupsResponse response = await assetGroupServiceClient.MutateAssetGroupsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetGroups</summary>
        public void MutateAssetGroups()
        {
            // Snippet: MutateAssetGroups(string, IEnumerable<AssetGroupOperation>, CallSettings)
            // Create client
            AssetGroupServiceClient assetGroupServiceClient = AssetGroupServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AssetGroupOperation> operations = new AssetGroupOperation[]
            {
                new AssetGroupOperation(),
            };
            // Make the request
            MutateAssetGroupsResponse response = assetGroupServiceClient.MutateAssetGroups(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAssetGroupsAsync</summary>
        public async Task MutateAssetGroupsAsync()
        {
            // Snippet: MutateAssetGroupsAsync(string, IEnumerable<AssetGroupOperation>, CallSettings)
            // Additional: MutateAssetGroupsAsync(string, IEnumerable<AssetGroupOperation>, CancellationToken)
            // Create client
            AssetGroupServiceClient assetGroupServiceClient = await AssetGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AssetGroupOperation> operations = new AssetGroupOperation[]
            {
                new AssetGroupOperation(),
            };
            // Make the request
            MutateAssetGroupsResponse response = await assetGroupServiceClient.MutateAssetGroupsAsync(customerId, operations);
            // End snippet
        }
    }
}
