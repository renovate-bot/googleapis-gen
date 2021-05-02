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
    public sealed class GeneratedProductBiddingCategoryConstantServiceClientSnippets
    {
        /// <summary>Snippet for GetProductBiddingCategoryConstant</summary>
        public void GetProductBiddingCategoryConstantRequestObject()
        {
            // Snippet: GetProductBiddingCategoryConstant(GetProductBiddingCategoryConstantRequest, CallSettings)
            // Create client
            ProductBiddingCategoryConstantServiceClient productBiddingCategoryConstantServiceClient = ProductBiddingCategoryConstantServiceClient.Create();
            // Initialize request argument(s)
            GetProductBiddingCategoryConstantRequest request = new GetProductBiddingCategoryConstantRequest
            {
                ResourceNameAsProductBiddingCategoryConstantName = ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
            };
            // Make the request
            ProductBiddingCategoryConstant response = productBiddingCategoryConstantServiceClient.GetProductBiddingCategoryConstant(request);
            // End snippet
        }

        /// <summary>Snippet for GetProductBiddingCategoryConstantAsync</summary>
        public async Task GetProductBiddingCategoryConstantRequestObjectAsync()
        {
            // Snippet: GetProductBiddingCategoryConstantAsync(GetProductBiddingCategoryConstantRequest, CallSettings)
            // Additional: GetProductBiddingCategoryConstantAsync(GetProductBiddingCategoryConstantRequest, CancellationToken)
            // Create client
            ProductBiddingCategoryConstantServiceClient productBiddingCategoryConstantServiceClient = await ProductBiddingCategoryConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProductBiddingCategoryConstantRequest request = new GetProductBiddingCategoryConstantRequest
            {
                ResourceNameAsProductBiddingCategoryConstantName = ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
            };
            // Make the request
            ProductBiddingCategoryConstant response = await productBiddingCategoryConstantServiceClient.GetProductBiddingCategoryConstantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProductBiddingCategoryConstant</summary>
        public void GetProductBiddingCategoryConstant()
        {
            // Snippet: GetProductBiddingCategoryConstant(string, CallSettings)
            // Create client
            ProductBiddingCategoryConstantServiceClient productBiddingCategoryConstantServiceClient = ProductBiddingCategoryConstantServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "productBiddingCategoryConstants/[COUNTRY_CODE]~[LEVEL]~[ID]";
            // Make the request
            ProductBiddingCategoryConstant response = productBiddingCategoryConstantServiceClient.GetProductBiddingCategoryConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetProductBiddingCategoryConstantAsync</summary>
        public async Task GetProductBiddingCategoryConstantAsync()
        {
            // Snippet: GetProductBiddingCategoryConstantAsync(string, CallSettings)
            // Additional: GetProductBiddingCategoryConstantAsync(string, CancellationToken)
            // Create client
            ProductBiddingCategoryConstantServiceClient productBiddingCategoryConstantServiceClient = await ProductBiddingCategoryConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "productBiddingCategoryConstants/[COUNTRY_CODE]~[LEVEL]~[ID]";
            // Make the request
            ProductBiddingCategoryConstant response = await productBiddingCategoryConstantServiceClient.GetProductBiddingCategoryConstantAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetProductBiddingCategoryConstant</summary>
        public void GetProductBiddingCategoryConstantResourceNames()
        {
            // Snippet: GetProductBiddingCategoryConstant(ProductBiddingCategoryConstantName, CallSettings)
            // Create client
            ProductBiddingCategoryConstantServiceClient productBiddingCategoryConstantServiceClient = ProductBiddingCategoryConstantServiceClient.Create();
            // Initialize request argument(s)
            ProductBiddingCategoryConstantName resourceName = ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]");
            // Make the request
            ProductBiddingCategoryConstant response = productBiddingCategoryConstantServiceClient.GetProductBiddingCategoryConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetProductBiddingCategoryConstantAsync</summary>
        public async Task GetProductBiddingCategoryConstantResourceNamesAsync()
        {
            // Snippet: GetProductBiddingCategoryConstantAsync(ProductBiddingCategoryConstantName, CallSettings)
            // Additional: GetProductBiddingCategoryConstantAsync(ProductBiddingCategoryConstantName, CancellationToken)
            // Create client
            ProductBiddingCategoryConstantServiceClient productBiddingCategoryConstantServiceClient = await ProductBiddingCategoryConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductBiddingCategoryConstantName resourceName = ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]");
            // Make the request
            ProductBiddingCategoryConstant response = await productBiddingCategoryConstantServiceClient.GetProductBiddingCategoryConstantAsync(resourceName);
            // End snippet
        }
    }
}
