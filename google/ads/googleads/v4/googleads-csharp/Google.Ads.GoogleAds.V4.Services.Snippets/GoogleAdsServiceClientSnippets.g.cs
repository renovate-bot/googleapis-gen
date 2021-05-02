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

namespace Google.Ads.GoogleAds.V4.Services.Snippets
{
    using Google.Ads.GoogleAds.V4.Enums;
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedGoogleAdsServiceClientSnippets
    {
        /// <summary>Snippet for Search</summary>
        public void SearchRequestObject()
        {
            // Snippet: Search(SearchGoogleAdsRequest, CallSettings)
            // Create client
            GoogleAdsServiceClient googleAdsServiceClient = GoogleAdsServiceClient.Create();
            // Initialize request argument(s)
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest
            {
                CustomerId = "",
                Query = "",
                ValidateOnly = false,
                ReturnTotalResultsCount = false,
                SummaryRowSetting = SummaryRowSettingEnum.Types.SummaryRowSetting.Unspecified,
            };
            // Make the request
            PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> response = googleAdsServiceClient.Search(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GoogleAdsRow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchGoogleAdsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleAdsRow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleAdsRow> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleAdsRow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAsync</summary>
        public async Task SearchRequestObjectAsync()
        {
            // Snippet: SearchAsync(SearchGoogleAdsRequest, CallSettings)
            // Create client
            GoogleAdsServiceClient googleAdsServiceClient = await GoogleAdsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest
            {
                CustomerId = "",
                Query = "",
                ValidateOnly = false,
                ReturnTotalResultsCount = false,
                SummaryRowSetting = SummaryRowSettingEnum.Types.SummaryRowSetting.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> response = googleAdsServiceClient.SearchAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GoogleAdsRow item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchGoogleAdsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleAdsRow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleAdsRow> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleAdsRow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Search</summary>
        public void Search()
        {
            // Snippet: Search(string, string, string, int?, CallSettings)
            // Create client
            GoogleAdsServiceClient googleAdsServiceClient = GoogleAdsServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            string query = "";
            // Make the request
            PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> response = googleAdsServiceClient.Search(customerId, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GoogleAdsRow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchGoogleAdsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleAdsRow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleAdsRow> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleAdsRow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAsync</summary>
        public async Task SearchAsync()
        {
            // Snippet: SearchAsync(string, string, string, int?, CallSettings)
            // Create client
            GoogleAdsServiceClient googleAdsServiceClient = await GoogleAdsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> response = googleAdsServiceClient.SearchAsync(customerId, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GoogleAdsRow item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchGoogleAdsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleAdsRow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleAdsRow> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleAdsRow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchStream</summary>
        public async Task SearchStreamRequestObject()
        {
            // Snippet: SearchStream(SearchGoogleAdsStreamRequest, CallSettings)
            // Create client
            GoogleAdsServiceClient googleAdsServiceClient = GoogleAdsServiceClient.Create();
            // Initialize request argument(s)
            SearchGoogleAdsStreamRequest request = new SearchGoogleAdsStreamRequest
            {
                CustomerId = "",
                Query = "",
                SummaryRowSetting = SummaryRowSettingEnum.Types.SummaryRowSetting.Unspecified,
            };
            // Make the request, returning a streaming response
            GoogleAdsServiceClient.SearchStreamStream response = googleAdsServiceClient.SearchStream(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<SearchGoogleAdsStreamResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                SearchGoogleAdsStreamResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for SearchStream</summary>
        public async Task SearchStream()
        {
            // Snippet: SearchStream(string, string, CallSettings)
            // Create client
            GoogleAdsServiceClient googleAdsServiceClient = GoogleAdsServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            string query = "";
            // Make the request, returning a streaming response
            GoogleAdsServiceClient.SearchStreamStream response = googleAdsServiceClient.SearchStream(customerId, query);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<SearchGoogleAdsStreamResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                SearchGoogleAdsStreamResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for Mutate</summary>
        public void MutateRequestObject()
        {
            // Snippet: Mutate(MutateGoogleAdsRequest, CallSettings)
            // Create client
            GoogleAdsServiceClient googleAdsServiceClient = GoogleAdsServiceClient.Create();
            // Initialize request argument(s)
            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest
            {
                CustomerId = "",
                MutateOperations =
                {
                    new MutateOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateGoogleAdsResponse response = googleAdsServiceClient.Mutate(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAsync</summary>
        public async Task MutateRequestObjectAsync()
        {
            // Snippet: MutateAsync(MutateGoogleAdsRequest, CallSettings)
            // Additional: MutateAsync(MutateGoogleAdsRequest, CancellationToken)
            // Create client
            GoogleAdsServiceClient googleAdsServiceClient = await GoogleAdsServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest
            {
                CustomerId = "",
                MutateOperations =
                {
                    new MutateOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateGoogleAdsResponse response = await googleAdsServiceClient.MutateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Mutate</summary>
        public void Mutate()
        {
            // Snippet: Mutate(string, IEnumerable<MutateOperation>, CallSettings)
            // Create client
            GoogleAdsServiceClient googleAdsServiceClient = GoogleAdsServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<MutateOperation> mutateOperations = new MutateOperation[]
            {
                new MutateOperation(),
            };
            // Make the request
            MutateGoogleAdsResponse response = googleAdsServiceClient.Mutate(customerId, mutateOperations);
            // End snippet
        }

        /// <summary>Snippet for MutateAsync</summary>
        public async Task MutateAsync()
        {
            // Snippet: MutateAsync(string, IEnumerable<MutateOperation>, CallSettings)
            // Additional: MutateAsync(string, IEnumerable<MutateOperation>, CancellationToken)
            // Create client
            GoogleAdsServiceClient googleAdsServiceClient = await GoogleAdsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<MutateOperation> mutateOperations = new MutateOperation[]
            {
                new MutateOperation(),
            };
            // Make the request
            MutateGoogleAdsResponse response = await googleAdsServiceClient.MutateAsync(customerId, mutateOperations);
            // End snippet
        }
    }
}
