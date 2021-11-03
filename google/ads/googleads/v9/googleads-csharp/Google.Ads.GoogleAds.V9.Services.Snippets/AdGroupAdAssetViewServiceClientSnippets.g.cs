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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAdGroupAdAssetViewServiceClientSnippets
    {
        /// <summary>Snippet for GetAdGroupAdAssetView</summary>
        public void GetAdGroupAdAssetViewRequestObject()
        {
            // Snippet: GetAdGroupAdAssetView(GetAdGroupAdAssetViewRequest, CallSettings)
            // Create client
            AdGroupAdAssetViewServiceClient adGroupAdAssetViewServiceClient = AdGroupAdAssetViewServiceClient.Create();
            // Initialize request argument(s)
            GetAdGroupAdAssetViewRequest request = new GetAdGroupAdAssetViewRequest
            {
                ResourceNameAsAdGroupAdAssetViewName = AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[AD_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            // Make the request
            AdGroupAdAssetView response = adGroupAdAssetViewServiceClient.GetAdGroupAdAssetView(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAdAssetViewAsync</summary>
        public async Task GetAdGroupAdAssetViewRequestObjectAsync()
        {
            // Snippet: GetAdGroupAdAssetViewAsync(GetAdGroupAdAssetViewRequest, CallSettings)
            // Additional: GetAdGroupAdAssetViewAsync(GetAdGroupAdAssetViewRequest, CancellationToken)
            // Create client
            AdGroupAdAssetViewServiceClient adGroupAdAssetViewServiceClient = await AdGroupAdAssetViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdGroupAdAssetViewRequest request = new GetAdGroupAdAssetViewRequest
            {
                ResourceNameAsAdGroupAdAssetViewName = AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[AD_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            // Make the request
            AdGroupAdAssetView response = await adGroupAdAssetViewServiceClient.GetAdGroupAdAssetViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAdAssetView</summary>
        public void GetAdGroupAdAssetView()
        {
            // Snippet: GetAdGroupAdAssetView(string, CallSettings)
            // Create client
            AdGroupAdAssetViewServiceClient adGroupAdAssetViewServiceClient = AdGroupAdAssetViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupAdAssetViews/[AD_GROUP_ID]~[AD_ID]~[ASSET_ID]~[FIELD_TYPE]";
            // Make the request
            AdGroupAdAssetView response = adGroupAdAssetViewServiceClient.GetAdGroupAdAssetView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAdAssetViewAsync</summary>
        public async Task GetAdGroupAdAssetViewAsync()
        {
            // Snippet: GetAdGroupAdAssetViewAsync(string, CallSettings)
            // Additional: GetAdGroupAdAssetViewAsync(string, CancellationToken)
            // Create client
            AdGroupAdAssetViewServiceClient adGroupAdAssetViewServiceClient = await AdGroupAdAssetViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupAdAssetViews/[AD_GROUP_ID]~[AD_ID]~[ASSET_ID]~[FIELD_TYPE]";
            // Make the request
            AdGroupAdAssetView response = await adGroupAdAssetViewServiceClient.GetAdGroupAdAssetViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAdAssetView</summary>
        public void GetAdGroupAdAssetViewResourceNames()
        {
            // Snippet: GetAdGroupAdAssetView(AdGroupAdAssetViewName, CallSettings)
            // Create client
            AdGroupAdAssetViewServiceClient adGroupAdAssetViewServiceClient = AdGroupAdAssetViewServiceClient.Create();
            // Initialize request argument(s)
            AdGroupAdAssetViewName resourceName = AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[AD_ID]", "[ASSET_ID]", "[FIELD_TYPE]");
            // Make the request
            AdGroupAdAssetView response = adGroupAdAssetViewServiceClient.GetAdGroupAdAssetView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAdAssetViewAsync</summary>
        public async Task GetAdGroupAdAssetViewResourceNamesAsync()
        {
            // Snippet: GetAdGroupAdAssetViewAsync(AdGroupAdAssetViewName, CallSettings)
            // Additional: GetAdGroupAdAssetViewAsync(AdGroupAdAssetViewName, CancellationToken)
            // Create client
            AdGroupAdAssetViewServiceClient adGroupAdAssetViewServiceClient = await AdGroupAdAssetViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdGroupAdAssetViewName resourceName = AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetFieldType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[AD_ID]", "[ASSET_ID]", "[FIELD_TYPE]");
            // Make the request
            AdGroupAdAssetView response = await adGroupAdAssetViewServiceClient.GetAdGroupAdAssetViewAsync(resourceName);
            // End snippet
        }
    }
}
