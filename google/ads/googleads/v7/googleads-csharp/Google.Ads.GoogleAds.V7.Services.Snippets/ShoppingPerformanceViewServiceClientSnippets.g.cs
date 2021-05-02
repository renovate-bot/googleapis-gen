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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedShoppingPerformanceViewServiceClientSnippets
    {
        /// <summary>Snippet for GetShoppingPerformanceView</summary>
        public void GetShoppingPerformanceViewRequestObject()
        {
            // Snippet: GetShoppingPerformanceView(GetShoppingPerformanceViewRequest, CallSettings)
            // Create client
            ShoppingPerformanceViewServiceClient shoppingPerformanceViewServiceClient = ShoppingPerformanceViewServiceClient.Create();
            // Initialize request argument(s)
            GetShoppingPerformanceViewRequest request = new GetShoppingPerformanceViewRequest
            {
                ResourceNameAsShoppingPerformanceViewName = ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            // Make the request
            ShoppingPerformanceView response = shoppingPerformanceViewServiceClient.GetShoppingPerformanceView(request);
            // End snippet
        }

        /// <summary>Snippet for GetShoppingPerformanceViewAsync</summary>
        public async Task GetShoppingPerformanceViewRequestObjectAsync()
        {
            // Snippet: GetShoppingPerformanceViewAsync(GetShoppingPerformanceViewRequest, CallSettings)
            // Additional: GetShoppingPerformanceViewAsync(GetShoppingPerformanceViewRequest, CancellationToken)
            // Create client
            ShoppingPerformanceViewServiceClient shoppingPerformanceViewServiceClient = await ShoppingPerformanceViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetShoppingPerformanceViewRequest request = new GetShoppingPerformanceViewRequest
            {
                ResourceNameAsShoppingPerformanceViewName = ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            // Make the request
            ShoppingPerformanceView response = await shoppingPerformanceViewServiceClient.GetShoppingPerformanceViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetShoppingPerformanceView</summary>
        public void GetShoppingPerformanceView()
        {
            // Snippet: GetShoppingPerformanceView(string, CallSettings)
            // Create client
            ShoppingPerformanceViewServiceClient shoppingPerformanceViewServiceClient = ShoppingPerformanceViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/shoppingPerformanceView";
            // Make the request
            ShoppingPerformanceView response = shoppingPerformanceViewServiceClient.GetShoppingPerformanceView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetShoppingPerformanceViewAsync</summary>
        public async Task GetShoppingPerformanceViewAsync()
        {
            // Snippet: GetShoppingPerformanceViewAsync(string, CallSettings)
            // Additional: GetShoppingPerformanceViewAsync(string, CancellationToken)
            // Create client
            ShoppingPerformanceViewServiceClient shoppingPerformanceViewServiceClient = await ShoppingPerformanceViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/shoppingPerformanceView";
            // Make the request
            ShoppingPerformanceView response = await shoppingPerformanceViewServiceClient.GetShoppingPerformanceViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetShoppingPerformanceView</summary>
        public void GetShoppingPerformanceViewResourceNames()
        {
            // Snippet: GetShoppingPerformanceView(ShoppingPerformanceViewName, CallSettings)
            // Create client
            ShoppingPerformanceViewServiceClient shoppingPerformanceViewServiceClient = ShoppingPerformanceViewServiceClient.Create();
            // Initialize request argument(s)
            ShoppingPerformanceViewName resourceName = ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]");
            // Make the request
            ShoppingPerformanceView response = shoppingPerformanceViewServiceClient.GetShoppingPerformanceView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetShoppingPerformanceViewAsync</summary>
        public async Task GetShoppingPerformanceViewResourceNamesAsync()
        {
            // Snippet: GetShoppingPerformanceViewAsync(ShoppingPerformanceViewName, CallSettings)
            // Additional: GetShoppingPerformanceViewAsync(ShoppingPerformanceViewName, CancellationToken)
            // Create client
            ShoppingPerformanceViewServiceClient shoppingPerformanceViewServiceClient = await ShoppingPerformanceViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            ShoppingPerformanceViewName resourceName = ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]");
            // Make the request
            ShoppingPerformanceView response = await shoppingPerformanceViewServiceClient.GetShoppingPerformanceViewAsync(resourceName);
            // End snippet
        }
    }
}
