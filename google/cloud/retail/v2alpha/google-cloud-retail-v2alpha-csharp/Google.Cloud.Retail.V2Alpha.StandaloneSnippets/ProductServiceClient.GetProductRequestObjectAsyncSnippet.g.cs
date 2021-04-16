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

namespace Google.Cloud.Retail.V2Alpha.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedProductServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetProductAsync</summary>
        public async Task GetProductRequestObjectAsync()
        {
            // Snippet: GetProductAsync(GetProductRequest, CallSettings)
            // Additional: GetProductAsync(GetProductRequest, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            // Make the request
            Product response = await productServiceClient.GetProductAsync(request);
            // End snippet
        }
    }
}
