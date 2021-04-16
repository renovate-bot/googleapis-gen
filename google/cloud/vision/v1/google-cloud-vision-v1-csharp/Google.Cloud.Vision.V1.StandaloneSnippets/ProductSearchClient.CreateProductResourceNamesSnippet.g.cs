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

namespace Google.Cloud.Vision.V1.Snippets
{
    using Google.Api.Gax.ResourceNames;

    public sealed partial class GeneratedProductSearchClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateProduct</summary>
        public void CreateProductResourceNames()
        {
            // Snippet: CreateProduct(LocationName, Product, string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Product product = new Product();
            string productId = "";
            // Make the request
            Product response = productSearchClient.CreateProduct(parent, product, productId);
            // End snippet
        }
    }
}
