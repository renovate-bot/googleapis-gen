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
    public sealed class GeneratedProductGroupViewServiceClientSnippets
    {
        /// <summary>Snippet for GetProductGroupView</summary>
        public void GetProductGroupViewRequestObject()
        {
            // Snippet: GetProductGroupView(GetProductGroupViewRequest, CallSettings)
            // Create client
            ProductGroupViewServiceClient productGroupViewServiceClient = ProductGroupViewServiceClient.Create();
            // Initialize request argument(s)
            GetProductGroupViewRequest request = new GetProductGroupViewRequest
            {
                ResourceNameAsProductGroupViewName = ProductGroupViewName.FromCustomerAdgroupCriterion("[CUSTOMER_ID]", "[ADGROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            ProductGroupView response = productGroupViewServiceClient.GetProductGroupView(request);
            // End snippet
        }

        /// <summary>Snippet for GetProductGroupViewAsync</summary>
        public async Task GetProductGroupViewRequestObjectAsync()
        {
            // Snippet: GetProductGroupViewAsync(GetProductGroupViewRequest, CallSettings)
            // Additional: GetProductGroupViewAsync(GetProductGroupViewRequest, CancellationToken)
            // Create client
            ProductGroupViewServiceClient productGroupViewServiceClient = await ProductGroupViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProductGroupViewRequest request = new GetProductGroupViewRequest
            {
                ResourceNameAsProductGroupViewName = ProductGroupViewName.FromCustomerAdgroupCriterion("[CUSTOMER_ID]", "[ADGROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            ProductGroupView response = await productGroupViewServiceClient.GetProductGroupViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProductGroupView</summary>
        public void GetProductGroupView()
        {
            // Snippet: GetProductGroupView(string, CallSettings)
            // Create client
            ProductGroupViewServiceClient productGroupViewServiceClient = ProductGroupViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/productGroupViews/[ADGROUP_ID]~[CRITERION_ID]";
            // Make the request
            ProductGroupView response = productGroupViewServiceClient.GetProductGroupView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetProductGroupViewAsync</summary>
        public async Task GetProductGroupViewAsync()
        {
            // Snippet: GetProductGroupViewAsync(string, CallSettings)
            // Additional: GetProductGroupViewAsync(string, CancellationToken)
            // Create client
            ProductGroupViewServiceClient productGroupViewServiceClient = await ProductGroupViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/productGroupViews/[ADGROUP_ID]~[CRITERION_ID]";
            // Make the request
            ProductGroupView response = await productGroupViewServiceClient.GetProductGroupViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetProductGroupView</summary>
        public void GetProductGroupViewResourceNames()
        {
            // Snippet: GetProductGroupView(ProductGroupViewName, CallSettings)
            // Create client
            ProductGroupViewServiceClient productGroupViewServiceClient = ProductGroupViewServiceClient.Create();
            // Initialize request argument(s)
            ProductGroupViewName resourceName = ProductGroupViewName.FromCustomerAdgroupCriterion("[CUSTOMER_ID]", "[ADGROUP_ID]", "[CRITERION_ID]");
            // Make the request
            ProductGroupView response = productGroupViewServiceClient.GetProductGroupView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetProductGroupViewAsync</summary>
        public async Task GetProductGroupViewResourceNamesAsync()
        {
            // Snippet: GetProductGroupViewAsync(ProductGroupViewName, CallSettings)
            // Additional: GetProductGroupViewAsync(ProductGroupViewName, CancellationToken)
            // Create client
            ProductGroupViewServiceClient productGroupViewServiceClient = await ProductGroupViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductGroupViewName resourceName = ProductGroupViewName.FromCustomerAdgroupCriterion("[CUSTOMER_ID]", "[ADGROUP_ID]", "[CRITERION_ID]");
            // Make the request
            ProductGroupView response = await productGroupViewServiceClient.GetProductGroupViewAsync(resourceName);
            // End snippet
        }
    }
}
