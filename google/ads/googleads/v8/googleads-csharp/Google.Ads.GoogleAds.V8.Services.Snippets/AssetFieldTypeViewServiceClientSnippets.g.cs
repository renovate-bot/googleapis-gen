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
    using Google.Ads.GoogleAds.V8.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAssetFieldTypeViewServiceClientSnippets
    {
        /// <summary>Snippet for GetAssetFieldTypeView</summary>
        public void GetAssetFieldTypeViewRequestObject()
        {
            // Snippet: GetAssetFieldTypeView(GetAssetFieldTypeViewRequest, CallSettings)
            // Create client
            AssetFieldTypeViewServiceClient assetFieldTypeViewServiceClient = AssetFieldTypeViewServiceClient.Create();
            // Initialize request argument(s)
            GetAssetFieldTypeViewRequest request = new GetAssetFieldTypeViewRequest
            {
                ResourceNameAsAssetFieldTypeViewName = AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]"),
            };
            // Make the request
            AssetFieldTypeView response = assetFieldTypeViewServiceClient.GetAssetFieldTypeView(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssetFieldTypeViewAsync</summary>
        public async Task GetAssetFieldTypeViewRequestObjectAsync()
        {
            // Snippet: GetAssetFieldTypeViewAsync(GetAssetFieldTypeViewRequest, CallSettings)
            // Additional: GetAssetFieldTypeViewAsync(GetAssetFieldTypeViewRequest, CancellationToken)
            // Create client
            AssetFieldTypeViewServiceClient assetFieldTypeViewServiceClient = await AssetFieldTypeViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAssetFieldTypeViewRequest request = new GetAssetFieldTypeViewRequest
            {
                ResourceNameAsAssetFieldTypeViewName = AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]"),
            };
            // Make the request
            AssetFieldTypeView response = await assetFieldTypeViewServiceClient.GetAssetFieldTypeViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssetFieldTypeView</summary>
        public void GetAssetFieldTypeView()
        {
            // Snippet: GetAssetFieldTypeView(string, CallSettings)
            // Create client
            AssetFieldTypeViewServiceClient assetFieldTypeViewServiceClient = AssetFieldTypeViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/assetFieldTypeViews/[FIELD_TYPE]";
            // Make the request
            AssetFieldTypeView response = assetFieldTypeViewServiceClient.GetAssetFieldTypeView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAssetFieldTypeViewAsync</summary>
        public async Task GetAssetFieldTypeViewAsync()
        {
            // Snippet: GetAssetFieldTypeViewAsync(string, CallSettings)
            // Additional: GetAssetFieldTypeViewAsync(string, CancellationToken)
            // Create client
            AssetFieldTypeViewServiceClient assetFieldTypeViewServiceClient = await AssetFieldTypeViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/assetFieldTypeViews/[FIELD_TYPE]";
            // Make the request
            AssetFieldTypeView response = await assetFieldTypeViewServiceClient.GetAssetFieldTypeViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAssetFieldTypeView</summary>
        public void GetAssetFieldTypeViewResourceNames()
        {
            // Snippet: GetAssetFieldTypeView(AssetFieldTypeViewName, CallSettings)
            // Create client
            AssetFieldTypeViewServiceClient assetFieldTypeViewServiceClient = AssetFieldTypeViewServiceClient.Create();
            // Initialize request argument(s)
            AssetFieldTypeViewName resourceName = AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]");
            // Make the request
            AssetFieldTypeView response = assetFieldTypeViewServiceClient.GetAssetFieldTypeView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAssetFieldTypeViewAsync</summary>
        public async Task GetAssetFieldTypeViewResourceNamesAsync()
        {
            // Snippet: GetAssetFieldTypeViewAsync(AssetFieldTypeViewName, CallSettings)
            // Additional: GetAssetFieldTypeViewAsync(AssetFieldTypeViewName, CancellationToken)
            // Create client
            AssetFieldTypeViewServiceClient assetFieldTypeViewServiceClient = await AssetFieldTypeViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssetFieldTypeViewName resourceName = AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]");
            // Make the request
            AssetFieldTypeView response = await assetFieldTypeViewServiceClient.GetAssetFieldTypeViewAsync(resourceName);
            // End snippet
        }
    }
}
