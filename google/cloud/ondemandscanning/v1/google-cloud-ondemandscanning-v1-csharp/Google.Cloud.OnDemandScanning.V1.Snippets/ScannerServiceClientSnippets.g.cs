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

namespace Google.Cloud.OnDemandScanning.V1.Snippets
{
    using CloudContainers.Workflow.Analysis.Vulnerability.Proto;
    using Google.Api.Gax;
    using Google.LongRunning;
    using Grafeas.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedScannerServiceClientSnippets
    {
        /// <summary>Snippet for AnalyzePackages</summary>
        public void AnalyzePackagesRequestObject()
        {
            // Snippet: AnalyzePackages(AnalyzePackagesRequest, CallSettings)
            // Create client
            ScannerServiceClient scannerServiceClient = ScannerServiceClient.Create();
            // Initialize request argument(s)
            AnalyzePackagesRequest request = new AnalyzePackagesRequest
            {
                Parent = "",
                ResourceUri = "",
                Packages = { new PackageData(), },
            };
            // Make the request
            Operation<AnalyzePackagesResponse, AnalyzePackagesMetadata> response = scannerServiceClient.AnalyzePackages(request);

            // Poll until the returned long-running operation is complete
            Operation<AnalyzePackagesResponse, AnalyzePackagesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnalyzePackagesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnalyzePackagesResponse, AnalyzePackagesMetadata> retrievedResponse = scannerServiceClient.PollOnceAnalyzePackages(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnalyzePackagesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AnalyzePackagesAsync</summary>
        public async Task AnalyzePackagesRequestObjectAsync()
        {
            // Snippet: AnalyzePackagesAsync(AnalyzePackagesRequest, CallSettings)
            // Additional: AnalyzePackagesAsync(AnalyzePackagesRequest, CancellationToken)
            // Create client
            ScannerServiceClient scannerServiceClient = await ScannerServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzePackagesRequest request = new AnalyzePackagesRequest
            {
                Parent = "",
                ResourceUri = "",
                Packages = { new PackageData(), },
            };
            // Make the request
            Operation<AnalyzePackagesResponse, AnalyzePackagesMetadata> response = await scannerServiceClient.AnalyzePackagesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AnalyzePackagesResponse, AnalyzePackagesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnalyzePackagesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnalyzePackagesResponse, AnalyzePackagesMetadata> retrievedResponse = await scannerServiceClient.PollOnceAnalyzePackagesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnalyzePackagesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AnalyzePackages</summary>
        public void AnalyzePackages()
        {
            // Snippet: AnalyzePackages(string, CallSettings)
            // Create client
            ScannerServiceClient scannerServiceClient = ScannerServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            Operation<AnalyzePackagesResponse, AnalyzePackagesMetadata> response = scannerServiceClient.AnalyzePackages(parent);

            // Poll until the returned long-running operation is complete
            Operation<AnalyzePackagesResponse, AnalyzePackagesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnalyzePackagesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnalyzePackagesResponse, AnalyzePackagesMetadata> retrievedResponse = scannerServiceClient.PollOnceAnalyzePackages(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnalyzePackagesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AnalyzePackagesAsync</summary>
        public async Task AnalyzePackagesAsync()
        {
            // Snippet: AnalyzePackagesAsync(string, CallSettings)
            // Additional: AnalyzePackagesAsync(string, CancellationToken)
            // Create client
            ScannerServiceClient scannerServiceClient = await ScannerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            Operation<AnalyzePackagesResponse, AnalyzePackagesMetadata> response = await scannerServiceClient.AnalyzePackagesAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<AnalyzePackagesResponse, AnalyzePackagesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnalyzePackagesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnalyzePackagesResponse, AnalyzePackagesMetadata> retrievedResponse = await scannerServiceClient.PollOnceAnalyzePackagesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnalyzePackagesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilities</summary>
        public void ListVulnerabilitiesRequestObject()
        {
            // Snippet: ListVulnerabilities(ListVulnerabilitiesRequest, CallSettings)
            // Create client
            ScannerServiceClient scannerServiceClient = ScannerServiceClient.Create();
            // Initialize request argument(s)
            ListVulnerabilitiesRequest request = new ListVulnerabilitiesRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListVulnerabilitiesResponse, Occurrence> response = scannerServiceClient.ListVulnerabilities(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Occurrence item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVulnerabilitiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilitiesAsync</summary>
        public async Task ListVulnerabilitiesRequestObjectAsync()
        {
            // Snippet: ListVulnerabilitiesAsync(ListVulnerabilitiesRequest, CallSettings)
            // Create client
            ScannerServiceClient scannerServiceClient = await ScannerServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListVulnerabilitiesRequest request = new ListVulnerabilitiesRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListVulnerabilitiesResponse, Occurrence> response = scannerServiceClient.ListVulnerabilitiesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Occurrence item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVulnerabilitiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilities</summary>
        public void ListVulnerabilities()
        {
            // Snippet: ListVulnerabilities(string, string, int?, CallSettings)
            // Create client
            ScannerServiceClient scannerServiceClient = ScannerServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListVulnerabilitiesResponse, Occurrence> response = scannerServiceClient.ListVulnerabilities(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Occurrence item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVulnerabilitiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilitiesAsync</summary>
        public async Task ListVulnerabilitiesAsync()
        {
            // Snippet: ListVulnerabilitiesAsync(string, string, int?, CallSettings)
            // Create client
            ScannerServiceClient scannerServiceClient = await ScannerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListVulnerabilitiesResponse, Occurrence> response = scannerServiceClient.ListVulnerabilitiesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Occurrence item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVulnerabilitiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
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
