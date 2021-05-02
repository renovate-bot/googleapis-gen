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

namespace Google.Cloud.Asset.V1P1Beta1.Snippets
{
    using Google.Api.Gax;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAssetServiceClientSnippets
    {
        /// <summary>Snippet for SearchAllResources</summary>
        public void SearchAllResourcesRequestObject()
        {
            // Snippet: SearchAllResources(SearchAllResourcesRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            SearchAllResourcesRequest request = new SearchAllResourcesRequest
            {
                Scope = "",
                Query = "",
                AssetTypes = { "", },
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<SearchAllResourcesResponse, StandardResourceMetadata> response = assetServiceClient.SearchAllResources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StandardResourceMetadata item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAllResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StandardResourceMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StandardResourceMetadata> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StandardResourceMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllResourcesAsync</summary>
        public async Task SearchAllResourcesRequestObjectAsync()
        {
            // Snippet: SearchAllResourcesAsync(SearchAllResourcesRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchAllResourcesRequest request = new SearchAllResourcesRequest
            {
                Scope = "",
                Query = "",
                AssetTypes = { "", },
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchAllResourcesResponse, StandardResourceMetadata> response = assetServiceClient.SearchAllResourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((StandardResourceMetadata item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAllResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StandardResourceMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StandardResourceMetadata> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StandardResourceMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllResources</summary>
        public void SearchAllResources()
        {
            // Snippet: SearchAllResources(string, string, IEnumerable<string>, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string scope = "";
            string query = "";
            IEnumerable<string> assetTypes = new string[] { "", };
            // Make the request
            PagedEnumerable<SearchAllResourcesResponse, StandardResourceMetadata> response = assetServiceClient.SearchAllResources(scope, query, assetTypes);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StandardResourceMetadata item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAllResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StandardResourceMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StandardResourceMetadata> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StandardResourceMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllResourcesAsync</summary>
        public async Task SearchAllResourcesAsync()
        {
            // Snippet: SearchAllResourcesAsync(string, string, IEnumerable<string>, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string scope = "";
            string query = "";
            IEnumerable<string> assetTypes = new string[] { "", };
            // Make the request
            PagedAsyncEnumerable<SearchAllResourcesResponse, StandardResourceMetadata> response = assetServiceClient.SearchAllResourcesAsync(scope, query, assetTypes);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((StandardResourceMetadata item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAllResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StandardResourceMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StandardResourceMetadata> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StandardResourceMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllIamPolicies</summary>
        public void SearchAllIamPoliciesRequestObject()
        {
            // Snippet: SearchAllIamPolicies(SearchAllIamPoliciesRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            SearchAllIamPoliciesRequest request = new SearchAllIamPoliciesRequest { Scope = "", Query = "", };
            // Make the request
            PagedEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> response = assetServiceClient.SearchAllIamPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IamPolicySearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAllIamPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IamPolicySearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IamPolicySearchResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IamPolicySearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllIamPoliciesAsync</summary>
        public async Task SearchAllIamPoliciesRequestObjectAsync()
        {
            // Snippet: SearchAllIamPoliciesAsync(SearchAllIamPoliciesRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchAllIamPoliciesRequest request = new SearchAllIamPoliciesRequest { Scope = "", Query = "", };
            // Make the request
            PagedAsyncEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> response = assetServiceClient.SearchAllIamPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IamPolicySearchResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAllIamPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IamPolicySearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IamPolicySearchResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IamPolicySearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllIamPolicies</summary>
        public void SearchAllIamPolicies()
        {
            // Snippet: SearchAllIamPolicies(string, string, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string scope = "";
            string query = "";
            // Make the request
            PagedEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> response = assetServiceClient.SearchAllIamPolicies(scope, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IamPolicySearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAllIamPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IamPolicySearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IamPolicySearchResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IamPolicySearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllIamPoliciesAsync</summary>
        public async Task SearchAllIamPoliciesAsync()
        {
            // Snippet: SearchAllIamPoliciesAsync(string, string, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string scope = "";
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> response = assetServiceClient.SearchAllIamPoliciesAsync(scope, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IamPolicySearchResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAllIamPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IamPolicySearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IamPolicySearchResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IamPolicySearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
