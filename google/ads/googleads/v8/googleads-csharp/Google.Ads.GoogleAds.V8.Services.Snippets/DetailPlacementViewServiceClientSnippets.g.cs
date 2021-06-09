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
    public sealed class GeneratedDetailPlacementViewServiceClientSnippets
    {
        /// <summary>Snippet for GetDetailPlacementView</summary>
        public void GetDetailPlacementViewRequestObject()
        {
            // Snippet: GetDetailPlacementView(GetDetailPlacementViewRequest, CallSettings)
            // Create client
            DetailPlacementViewServiceClient detailPlacementViewServiceClient = DetailPlacementViewServiceClient.Create();
            // Initialize request argument(s)
            GetDetailPlacementViewRequest request = new GetDetailPlacementViewRequest
            {
                ResourceNameAsDetailPlacementViewName = DetailPlacementViewName.FromCustomerAdGroupBase64Placement("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[BASE64_PLACEMENT]"),
            };
            // Make the request
            DetailPlacementView response = detailPlacementViewServiceClient.GetDetailPlacementView(request);
            // End snippet
        }

        /// <summary>Snippet for GetDetailPlacementViewAsync</summary>
        public async Task GetDetailPlacementViewRequestObjectAsync()
        {
            // Snippet: GetDetailPlacementViewAsync(GetDetailPlacementViewRequest, CallSettings)
            // Additional: GetDetailPlacementViewAsync(GetDetailPlacementViewRequest, CancellationToken)
            // Create client
            DetailPlacementViewServiceClient detailPlacementViewServiceClient = await DetailPlacementViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDetailPlacementViewRequest request = new GetDetailPlacementViewRequest
            {
                ResourceNameAsDetailPlacementViewName = DetailPlacementViewName.FromCustomerAdGroupBase64Placement("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[BASE64_PLACEMENT]"),
            };
            // Make the request
            DetailPlacementView response = await detailPlacementViewServiceClient.GetDetailPlacementViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDetailPlacementView</summary>
        public void GetDetailPlacementView()
        {
            // Snippet: GetDetailPlacementView(string, CallSettings)
            // Create client
            DetailPlacementViewServiceClient detailPlacementViewServiceClient = DetailPlacementViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/detailPlacementViews/[AD_GROUP_ID]~[BASE64_PLACEMENT]";
            // Make the request
            DetailPlacementView response = detailPlacementViewServiceClient.GetDetailPlacementView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDetailPlacementViewAsync</summary>
        public async Task GetDetailPlacementViewAsync()
        {
            // Snippet: GetDetailPlacementViewAsync(string, CallSettings)
            // Additional: GetDetailPlacementViewAsync(string, CancellationToken)
            // Create client
            DetailPlacementViewServiceClient detailPlacementViewServiceClient = await DetailPlacementViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/detailPlacementViews/[AD_GROUP_ID]~[BASE64_PLACEMENT]";
            // Make the request
            DetailPlacementView response = await detailPlacementViewServiceClient.GetDetailPlacementViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDetailPlacementView</summary>
        public void GetDetailPlacementViewResourceNames()
        {
            // Snippet: GetDetailPlacementView(DetailPlacementViewName, CallSettings)
            // Create client
            DetailPlacementViewServiceClient detailPlacementViewServiceClient = DetailPlacementViewServiceClient.Create();
            // Initialize request argument(s)
            DetailPlacementViewName resourceName = DetailPlacementViewName.FromCustomerAdGroupBase64Placement("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[BASE64_PLACEMENT]");
            // Make the request
            DetailPlacementView response = detailPlacementViewServiceClient.GetDetailPlacementView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDetailPlacementViewAsync</summary>
        public async Task GetDetailPlacementViewResourceNamesAsync()
        {
            // Snippet: GetDetailPlacementViewAsync(DetailPlacementViewName, CallSettings)
            // Additional: GetDetailPlacementViewAsync(DetailPlacementViewName, CancellationToken)
            // Create client
            DetailPlacementViewServiceClient detailPlacementViewServiceClient = await DetailPlacementViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            DetailPlacementViewName resourceName = DetailPlacementViewName.FromCustomerAdGroupBase64Placement("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[BASE64_PLACEMENT]");
            // Make the request
            DetailPlacementView response = await detailPlacementViewServiceClient.GetDetailPlacementViewAsync(resourceName);
            // End snippet
        }
    }
}
