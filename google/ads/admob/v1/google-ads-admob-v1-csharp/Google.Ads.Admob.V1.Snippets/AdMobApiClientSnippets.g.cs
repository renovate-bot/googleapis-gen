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

namespace Google.Ads.Admob.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAdMobApiClientSnippets
    {
        /// <summary>Snippet for GetPublisherAccount</summary>
        public void GetPublisherAccountRequestObject()
        {
            // Snippet: GetPublisherAccount(GetPublisherAccountRequest, CallSettings)
            // Create client
            AdMobApiClient adMobApiClient = AdMobApiClient.Create();
            // Initialize request argument(s)
            GetPublisherAccountRequest request = new GetPublisherAccountRequest { Name = "", };
            // Make the request
            PublisherAccount response = adMobApiClient.GetPublisherAccount(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherAccountAsync</summary>
        public async Task GetPublisherAccountRequestObjectAsync()
        {
            // Snippet: GetPublisherAccountAsync(GetPublisherAccountRequest, CallSettings)
            // Additional: GetPublisherAccountAsync(GetPublisherAccountRequest, CancellationToken)
            // Create client
            AdMobApiClient adMobApiClient = await AdMobApiClient.CreateAsync();
            // Initialize request argument(s)
            GetPublisherAccountRequest request = new GetPublisherAccountRequest { Name = "", };
            // Make the request
            PublisherAccount response = await adMobApiClient.GetPublisherAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherAccount</summary>
        public void GetPublisherAccount()
        {
            // Snippet: GetPublisherAccount(string, CallSettings)
            // Create client
            AdMobApiClient adMobApiClient = AdMobApiClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            PublisherAccount response = adMobApiClient.GetPublisherAccount(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublisherAccountAsync</summary>
        public async Task GetPublisherAccountAsync()
        {
            // Snippet: GetPublisherAccountAsync(string, CallSettings)
            // Additional: GetPublisherAccountAsync(string, CancellationToken)
            // Create client
            AdMobApiClient adMobApiClient = await AdMobApiClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            PublisherAccount response = await adMobApiClient.GetPublisherAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPublisherAccounts</summary>
        public void ListPublisherAccountsRequestObject()
        {
            // Snippet: ListPublisherAccounts(ListPublisherAccountsRequest, CallSettings)
            // Create client
            AdMobApiClient adMobApiClient = AdMobApiClient.Create();
            // Initialize request argument(s)
            ListPublisherAccountsRequest request = new ListPublisherAccountsRequest { };
            // Make the request
            PagedEnumerable<ListPublisherAccountsResponse, PublisherAccount> response = adMobApiClient.ListPublisherAccounts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PublisherAccount item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPublisherAccountsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublisherAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublisherAccount> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublisherAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublisherAccounts</summary>
        public async Task ListPublisherAccountsRequestObjectAsync()
        {
            // Snippet: ListPublisherAccountsAsync(ListPublisherAccountsRequest, CallSettings)
            // Create client
            AdMobApiClient adMobApiClient = await AdMobApiClient.CreateAsync();
            // Initialize request argument(s)
            ListPublisherAccountsRequest request = new ListPublisherAccountsRequest { };
            // Make the request
            PagedAsyncEnumerable<ListPublisherAccountsResponse, PublisherAccount> response = adMobApiClient.ListPublisherAccountsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PublisherAccount item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPublisherAccountsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublisherAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublisherAccount> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublisherAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GenerateNetworkReport</summary>
        public async Task GenerateNetworkReportRequestObject()
        {
            // Snippet: GenerateNetworkReport(GenerateNetworkReportRequest, CallSettings)
            // Create client
            AdMobApiClient adMobApiClient = AdMobApiClient.Create();
            // Initialize request argument(s)
            GenerateNetworkReportRequest request = new GenerateNetworkReportRequest
            {
                Parent = "",
                ReportSpec = new NetworkReportSpec(),
            };
            // Make the request, returning a streaming response
            AdMobApiClient.GenerateNetworkReportStream response = adMobApiClient.GenerateNetworkReport(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<GenerateNetworkReportResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                GenerateNetworkReportResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for GenerateMediationReport</summary>
        public async Task GenerateMediationReportRequestObject()
        {
            // Snippet: GenerateMediationReport(GenerateMediationReportRequest, CallSettings)
            // Create client
            AdMobApiClient adMobApiClient = AdMobApiClient.Create();
            // Initialize request argument(s)
            GenerateMediationReportRequest request = new GenerateMediationReportRequest
            {
                Parent = "",
                ReportSpec = new MediationReportSpec(),
            };
            // Make the request, returning a streaming response
            AdMobApiClient.GenerateMediationReportStream response = adMobApiClient.GenerateMediationReport(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<GenerateMediationReportResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                GenerateMediationReportResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }
    }
}
