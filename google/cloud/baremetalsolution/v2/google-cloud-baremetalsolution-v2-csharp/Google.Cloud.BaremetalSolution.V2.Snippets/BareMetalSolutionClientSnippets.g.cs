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

namespace Google.Cloud.BaremetalSolution.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedBareMetalSolutionClientSnippets
    {
        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = bareMetalSolutionClient.ListInstances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesRequestObjectAsync()
        {
            // Snippet: ListInstancesAsync(ListInstancesRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = bareMetalSolutionClient.ListInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstances()
        {
            // Snippet: ListInstances(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = bareMetalSolutionClient.ListInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesAsync()
        {
            // Snippet: ListInstancesAsync(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = bareMetalSolutionClient.ListInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesResourceNames()
        {
            // Snippet: ListInstances(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = bareMetalSolutionClient.ListInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesResourceNamesAsync()
        {
            // Snippet: ListInstancesAsync(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = bareMetalSolutionClient.ListInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceRequestObject()
        {
            // Snippet: GetInstance(GetInstanceRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = bareMetalSolutionClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest, CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = await bareMetalSolutionClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = bareMetalSolutionClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string, CallSettings)
            // Additional: GetInstanceAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = await bareMetalSolutionClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceResourceNames()
        {
            // Snippet: GetInstance(InstanceName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = bareMetalSolutionClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceResourceNamesAsync()
        {
            // Snippet: GetInstanceAsync(InstanceName, CallSettings)
            // Additional: GetInstanceAsync(InstanceName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = await bareMetalSolutionClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResetInstance</summary>
        public void ResetInstanceRequestObject()
        {
            // Snippet: ResetInstance(ResetInstanceRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ResetInstanceRequest request = new ResetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Operation<ResetInstanceResponse, OperationMetadata> response = bareMetalSolutionClient.ResetInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<ResetInstanceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ResetInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResetInstanceResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceResetInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResetInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetInstanceAsync</summary>
        public async Task ResetInstanceRequestObjectAsync()
        {
            // Snippet: ResetInstanceAsync(ResetInstanceRequest, CallSettings)
            // Additional: ResetInstanceAsync(ResetInstanceRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ResetInstanceRequest request = new ResetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Operation<ResetInstanceResponse, OperationMetadata> response = await bareMetalSolutionClient.ResetInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ResetInstanceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResetInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResetInstanceResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceResetInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResetInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetInstance</summary>
        public void ResetInstance()
        {
            // Snippet: ResetInstance(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<ResetInstanceResponse, OperationMetadata> response = bareMetalSolutionClient.ResetInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<ResetInstanceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ResetInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResetInstanceResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceResetInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResetInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetInstanceAsync</summary>
        public async Task ResetInstanceAsync()
        {
            // Snippet: ResetInstanceAsync(string, CallSettings)
            // Additional: ResetInstanceAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<ResetInstanceResponse, OperationMetadata> response = await bareMetalSolutionClient.ResetInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ResetInstanceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResetInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResetInstanceResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceResetInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResetInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetInstance</summary>
        public void ResetInstanceResourceNames()
        {
            // Snippet: ResetInstance(InstanceName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<ResetInstanceResponse, OperationMetadata> response = bareMetalSolutionClient.ResetInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<ResetInstanceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ResetInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResetInstanceResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceResetInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResetInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetInstanceAsync</summary>
        public async Task ResetInstanceResourceNamesAsync()
        {
            // Snippet: ResetInstanceAsync(InstanceName, CallSettings)
            // Additional: ResetInstanceAsync(InstanceName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<ResetInstanceResponse, OperationMetadata> response = await bareMetalSolutionClient.ResetInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ResetInstanceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResetInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResetInstanceResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceResetInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResetInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListVolumes</summary>
        public void ListVolumesRequestObject()
        {
            // Snippet: ListVolumes(ListVolumesRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListVolumesRequest request = new ListVolumesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListVolumesResponse, Volume> response = bareMetalSolutionClient.ListVolumes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Volume item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Volume item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Volume> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Volume item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumesAsync</summary>
        public async Task ListVolumesRequestObjectAsync()
        {
            // Snippet: ListVolumesAsync(ListVolumesRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListVolumesRequest request = new ListVolumesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListVolumesResponse, Volume> response = bareMetalSolutionClient.ListVolumesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Volume item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Volume item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Volume> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Volume item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumes</summary>
        public void ListVolumes()
        {
            // Snippet: ListVolumes(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListVolumesResponse, Volume> response = bareMetalSolutionClient.ListVolumes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Volume item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Volume item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Volume> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Volume item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumesAsync</summary>
        public async Task ListVolumesAsync()
        {
            // Snippet: ListVolumesAsync(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListVolumesResponse, Volume> response = bareMetalSolutionClient.ListVolumesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Volume item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Volume item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Volume> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Volume item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumes</summary>
        public void ListVolumesResourceNames()
        {
            // Snippet: ListVolumes(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListVolumesResponse, Volume> response = bareMetalSolutionClient.ListVolumes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Volume item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Volume item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Volume> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Volume item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumesAsync</summary>
        public async Task ListVolumesResourceNamesAsync()
        {
            // Snippet: ListVolumesAsync(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListVolumesResponse, Volume> response = bareMetalSolutionClient.ListVolumesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Volume item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Volume item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Volume> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Volume item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetVolume</summary>
        public void GetVolumeRequestObject()
        {
            // Snippet: GetVolume(GetVolumeRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            Volume response = bareMetalSolutionClient.GetVolume(request);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeAsync</summary>
        public async Task GetVolumeRequestObjectAsync()
        {
            // Snippet: GetVolumeAsync(GetVolumeRequest, CallSettings)
            // Additional: GetVolumeAsync(GetVolumeRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            Volume response = await bareMetalSolutionClient.GetVolumeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVolume</summary>
        public void GetVolume()
        {
            // Snippet: GetVolume(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            Volume response = bareMetalSolutionClient.GetVolume(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeAsync</summary>
        public async Task GetVolumeAsync()
        {
            // Snippet: GetVolumeAsync(string, CallSettings)
            // Additional: GetVolumeAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            Volume response = await bareMetalSolutionClient.GetVolumeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolume</summary>
        public void GetVolumeResourceNames()
        {
            // Snippet: GetVolume(VolumeName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeName name = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            Volume response = bareMetalSolutionClient.GetVolume(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeAsync</summary>
        public async Task GetVolumeResourceNamesAsync()
        {
            // Snippet: GetVolumeAsync(VolumeName, CallSettings)
            // Additional: GetVolumeAsync(VolumeName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName name = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            Volume response = await bareMetalSolutionClient.GetVolumeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateVolume</summary>
        public void UpdateVolumeRequestObject()
        {
            // Snippet: UpdateVolume(UpdateVolumeRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            UpdateVolumeRequest request = new UpdateVolumeRequest
            {
                Volume = new Volume(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Volume, OperationMetadata> response = bareMetalSolutionClient.UpdateVolume(request);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceUpdateVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVolumeAsync</summary>
        public async Task UpdateVolumeRequestObjectAsync()
        {
            // Snippet: UpdateVolumeAsync(UpdateVolumeRequest, CallSettings)
            // Additional: UpdateVolumeAsync(UpdateVolumeRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            UpdateVolumeRequest request = new UpdateVolumeRequest
            {
                Volume = new Volume(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Volume, OperationMetadata> response = await bareMetalSolutionClient.UpdateVolumeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceUpdateVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVolume</summary>
        public void UpdateVolume()
        {
            // Snippet: UpdateVolume(Volume, FieldMask, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            Volume volume = new Volume();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Volume, OperationMetadata> response = bareMetalSolutionClient.UpdateVolume(volume, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceUpdateVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVolumeAsync</summary>
        public async Task UpdateVolumeAsync()
        {
            // Snippet: UpdateVolumeAsync(Volume, FieldMask, CallSettings)
            // Additional: UpdateVolumeAsync(Volume, FieldMask, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            Volume volume = new Volume();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Volume, OperationMetadata> response = await bareMetalSolutionClient.UpdateVolumeAsync(volume, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceUpdateVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListNetworks</summary>
        public void ListNetworksRequestObject()
        {
            // Snippet: ListNetworks(ListNetworksRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListNetworksRequest request = new ListNetworksRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListNetworksResponse, Network> response = bareMetalSolutionClient.ListNetworks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Network item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworksAsync</summary>
        public async Task ListNetworksRequestObjectAsync()
        {
            // Snippet: ListNetworksAsync(ListNetworksRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworksRequest request = new ListNetworksRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListNetworksResponse, Network> response = bareMetalSolutionClient.ListNetworksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Network item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworks</summary>
        public void ListNetworks()
        {
            // Snippet: ListNetworks(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListNetworksResponse, Network> response = bareMetalSolutionClient.ListNetworks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Network item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworksAsync</summary>
        public async Task ListNetworksAsync()
        {
            // Snippet: ListNetworksAsync(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListNetworksResponse, Network> response = bareMetalSolutionClient.ListNetworksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Network item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworks</summary>
        public void ListNetworksResourceNames()
        {
            // Snippet: ListNetworks(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNetworksResponse, Network> response = bareMetalSolutionClient.ListNetworks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Network item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworksAsync</summary>
        public async Task ListNetworksResourceNamesAsync()
        {
            // Snippet: ListNetworksAsync(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNetworksResponse, Network> response = bareMetalSolutionClient.ListNetworksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Network item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNetwork</summary>
        public void GetNetworkRequestObject()
        {
            // Snippet: GetNetwork(GetNetworkRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            // Make the request
            Network response = bareMetalSolutionClient.GetNetwork(request);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkAsync</summary>
        public async Task GetNetworkRequestObjectAsync()
        {
            // Snippet: GetNetworkAsync(GetNetworkRequest, CallSettings)
            // Additional: GetNetworkAsync(GetNetworkRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            // Make the request
            Network response = await bareMetalSolutionClient.GetNetworkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNetwork</summary>
        public void GetNetwork()
        {
            // Snippet: GetNetwork(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networks/[NETWORK]";
            // Make the request
            Network response = bareMetalSolutionClient.GetNetwork(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkAsync</summary>
        public async Task GetNetworkAsync()
        {
            // Snippet: GetNetworkAsync(string, CallSettings)
            // Additional: GetNetworkAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networks/[NETWORK]";
            // Make the request
            Network response = await bareMetalSolutionClient.GetNetworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetwork</summary>
        public void GetNetworkResourceNames()
        {
            // Snippet: GetNetwork(NetworkName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            NetworkName name = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]");
            // Make the request
            Network response = bareMetalSolutionClient.GetNetwork(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkAsync</summary>
        public async Task GetNetworkResourceNamesAsync()
        {
            // Snippet: GetNetworkAsync(NetworkName, CallSettings)
            // Additional: GetNetworkAsync(NetworkName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName name = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]");
            // Make the request
            Network response = await bareMetalSolutionClient.GetNetworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotSchedulePolicies</summary>
        public void ListSnapshotSchedulePoliciesRequestObject()
        {
            // Snippet: ListSnapshotSchedulePolicies(ListSnapshotSchedulePoliciesRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListSnapshotSchedulePoliciesRequest request = new ListSnapshotSchedulePoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy> response = bareMetalSolutionClient.ListSnapshotSchedulePolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SnapshotSchedulePolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSnapshotSchedulePoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SnapshotSchedulePolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SnapshotSchedulePolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SnapshotSchedulePolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotSchedulePoliciesAsync</summary>
        public async Task ListSnapshotSchedulePoliciesRequestObjectAsync()
        {
            // Snippet: ListSnapshotSchedulePoliciesAsync(ListSnapshotSchedulePoliciesRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListSnapshotSchedulePoliciesRequest request = new ListSnapshotSchedulePoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy> response = bareMetalSolutionClient.ListSnapshotSchedulePoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SnapshotSchedulePolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSnapshotSchedulePoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SnapshotSchedulePolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SnapshotSchedulePolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SnapshotSchedulePolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotSchedulePolicies</summary>
        public void ListSnapshotSchedulePolicies()
        {
            // Snippet: ListSnapshotSchedulePolicies(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy> response = bareMetalSolutionClient.ListSnapshotSchedulePolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SnapshotSchedulePolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSnapshotSchedulePoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SnapshotSchedulePolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SnapshotSchedulePolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SnapshotSchedulePolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotSchedulePoliciesAsync</summary>
        public async Task ListSnapshotSchedulePoliciesAsync()
        {
            // Snippet: ListSnapshotSchedulePoliciesAsync(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy> response = bareMetalSolutionClient.ListSnapshotSchedulePoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SnapshotSchedulePolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSnapshotSchedulePoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SnapshotSchedulePolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SnapshotSchedulePolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SnapshotSchedulePolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotSchedulePolicies</summary>
        public void ListSnapshotSchedulePoliciesResourceNames()
        {
            // Snippet: ListSnapshotSchedulePolicies(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy> response = bareMetalSolutionClient.ListSnapshotSchedulePolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SnapshotSchedulePolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSnapshotSchedulePoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SnapshotSchedulePolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SnapshotSchedulePolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SnapshotSchedulePolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotSchedulePoliciesAsync</summary>
        public async Task ListSnapshotSchedulePoliciesResourceNamesAsync()
        {
            // Snippet: ListSnapshotSchedulePoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy> response = bareMetalSolutionClient.ListSnapshotSchedulePoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SnapshotSchedulePolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSnapshotSchedulePoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SnapshotSchedulePolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SnapshotSchedulePolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SnapshotSchedulePolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotSchedulePolicy</summary>
        public void GetSnapshotSchedulePolicyRequestObject()
        {
            // Snippet: GetSnapshotSchedulePolicy(GetSnapshotSchedulePolicyRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            GetSnapshotSchedulePolicyRequest request = new GetSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            // Make the request
            SnapshotSchedulePolicy response = bareMetalSolutionClient.GetSnapshotSchedulePolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotSchedulePolicyAsync</summary>
        public async Task GetSnapshotSchedulePolicyRequestObjectAsync()
        {
            // Snippet: GetSnapshotSchedulePolicyAsync(GetSnapshotSchedulePolicyRequest, CallSettings)
            // Additional: GetSnapshotSchedulePolicyAsync(GetSnapshotSchedulePolicyRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            GetSnapshotSchedulePolicyRequest request = new GetSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            // Make the request
            SnapshotSchedulePolicy response = await bareMetalSolutionClient.GetSnapshotSchedulePolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotSchedulePolicy</summary>
        public void GetSnapshotSchedulePolicy()
        {
            // Snippet: GetSnapshotSchedulePolicy(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/snapshotSchedulePolicies/[SNAPSHOT_SCHEDULE_POLICY]";
            // Make the request
            SnapshotSchedulePolicy response = bareMetalSolutionClient.GetSnapshotSchedulePolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotSchedulePolicyAsync</summary>
        public async Task GetSnapshotSchedulePolicyAsync()
        {
            // Snippet: GetSnapshotSchedulePolicyAsync(string, CallSettings)
            // Additional: GetSnapshotSchedulePolicyAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/snapshotSchedulePolicies/[SNAPSHOT_SCHEDULE_POLICY]";
            // Make the request
            SnapshotSchedulePolicy response = await bareMetalSolutionClient.GetSnapshotSchedulePolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotSchedulePolicy</summary>
        public void GetSnapshotSchedulePolicyResourceNames()
        {
            // Snippet: GetSnapshotSchedulePolicy(SnapshotSchedulePolicyName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            SnapshotSchedulePolicyName name = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]");
            // Make the request
            SnapshotSchedulePolicy response = bareMetalSolutionClient.GetSnapshotSchedulePolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotSchedulePolicyAsync</summary>
        public async Task GetSnapshotSchedulePolicyResourceNamesAsync()
        {
            // Snippet: GetSnapshotSchedulePolicyAsync(SnapshotSchedulePolicyName, CallSettings)
            // Additional: GetSnapshotSchedulePolicyAsync(SnapshotSchedulePolicyName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotSchedulePolicyName name = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]");
            // Make the request
            SnapshotSchedulePolicy response = await bareMetalSolutionClient.GetSnapshotSchedulePolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotSchedulePolicy</summary>
        public void CreateSnapshotSchedulePolicyRequestObject()
        {
            // Snippet: CreateSnapshotSchedulePolicy(CreateSnapshotSchedulePolicyRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            CreateSnapshotSchedulePolicyRequest request = new CreateSnapshotSchedulePolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SnapshotSchedulePolicy = new SnapshotSchedulePolicy(),
                SnapshotSchedulePolicyId = "",
            };
            // Make the request
            SnapshotSchedulePolicy response = bareMetalSolutionClient.CreateSnapshotSchedulePolicy(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotSchedulePolicyAsync</summary>
        public async Task CreateSnapshotSchedulePolicyRequestObjectAsync()
        {
            // Snippet: CreateSnapshotSchedulePolicyAsync(CreateSnapshotSchedulePolicyRequest, CallSettings)
            // Additional: CreateSnapshotSchedulePolicyAsync(CreateSnapshotSchedulePolicyRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            CreateSnapshotSchedulePolicyRequest request = new CreateSnapshotSchedulePolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SnapshotSchedulePolicy = new SnapshotSchedulePolicy(),
                SnapshotSchedulePolicyId = "",
            };
            // Make the request
            SnapshotSchedulePolicy response = await bareMetalSolutionClient.CreateSnapshotSchedulePolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotSchedulePolicy</summary>
        public void CreateSnapshotSchedulePolicy()
        {
            // Snippet: CreateSnapshotSchedulePolicy(string, SnapshotSchedulePolicy, string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SnapshotSchedulePolicy snapshotSchedulePolicy = new SnapshotSchedulePolicy();
            string snapshotSchedulePolicyId = "";
            // Make the request
            SnapshotSchedulePolicy response = bareMetalSolutionClient.CreateSnapshotSchedulePolicy(parent, snapshotSchedulePolicy, snapshotSchedulePolicyId);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotSchedulePolicyAsync</summary>
        public async Task CreateSnapshotSchedulePolicyAsync()
        {
            // Snippet: CreateSnapshotSchedulePolicyAsync(string, SnapshotSchedulePolicy, string, CallSettings)
            // Additional: CreateSnapshotSchedulePolicyAsync(string, SnapshotSchedulePolicy, string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SnapshotSchedulePolicy snapshotSchedulePolicy = new SnapshotSchedulePolicy();
            string snapshotSchedulePolicyId = "";
            // Make the request
            SnapshotSchedulePolicy response = await bareMetalSolutionClient.CreateSnapshotSchedulePolicyAsync(parent, snapshotSchedulePolicy, snapshotSchedulePolicyId);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotSchedulePolicy</summary>
        public void CreateSnapshotSchedulePolicyResourceNames()
        {
            // Snippet: CreateSnapshotSchedulePolicy(LocationName, SnapshotSchedulePolicy, string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SnapshotSchedulePolicy snapshotSchedulePolicy = new SnapshotSchedulePolicy();
            string snapshotSchedulePolicyId = "";
            // Make the request
            SnapshotSchedulePolicy response = bareMetalSolutionClient.CreateSnapshotSchedulePolicy(parent, snapshotSchedulePolicy, snapshotSchedulePolicyId);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotSchedulePolicyAsync</summary>
        public async Task CreateSnapshotSchedulePolicyResourceNamesAsync()
        {
            // Snippet: CreateSnapshotSchedulePolicyAsync(LocationName, SnapshotSchedulePolicy, string, CallSettings)
            // Additional: CreateSnapshotSchedulePolicyAsync(LocationName, SnapshotSchedulePolicy, string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SnapshotSchedulePolicy snapshotSchedulePolicy = new SnapshotSchedulePolicy();
            string snapshotSchedulePolicyId = "";
            // Make the request
            SnapshotSchedulePolicy response = await bareMetalSolutionClient.CreateSnapshotSchedulePolicyAsync(parent, snapshotSchedulePolicy, snapshotSchedulePolicyId);
            // End snippet
        }

        /// <summary>Snippet for UpdateSnapshotSchedulePolicy</summary>
        public void UpdateSnapshotSchedulePolicyRequestObject()
        {
            // Snippet: UpdateSnapshotSchedulePolicy(UpdateSnapshotSchedulePolicyRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            UpdateSnapshotSchedulePolicyRequest request = new UpdateSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicy = new SnapshotSchedulePolicy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SnapshotSchedulePolicy response = bareMetalSolutionClient.UpdateSnapshotSchedulePolicy(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSnapshotSchedulePolicyAsync</summary>
        public async Task UpdateSnapshotSchedulePolicyRequestObjectAsync()
        {
            // Snippet: UpdateSnapshotSchedulePolicyAsync(UpdateSnapshotSchedulePolicyRequest, CallSettings)
            // Additional: UpdateSnapshotSchedulePolicyAsync(UpdateSnapshotSchedulePolicyRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSnapshotSchedulePolicyRequest request = new UpdateSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicy = new SnapshotSchedulePolicy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SnapshotSchedulePolicy response = await bareMetalSolutionClient.UpdateSnapshotSchedulePolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSnapshotSchedulePolicy</summary>
        public void UpdateSnapshotSchedulePolicy()
        {
            // Snippet: UpdateSnapshotSchedulePolicy(SnapshotSchedulePolicy, FieldMask, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            SnapshotSchedulePolicy snapshotSchedulePolicy = new SnapshotSchedulePolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SnapshotSchedulePolicy response = bareMetalSolutionClient.UpdateSnapshotSchedulePolicy(snapshotSchedulePolicy, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSnapshotSchedulePolicyAsync</summary>
        public async Task UpdateSnapshotSchedulePolicyAsync()
        {
            // Snippet: UpdateSnapshotSchedulePolicyAsync(SnapshotSchedulePolicy, FieldMask, CallSettings)
            // Additional: UpdateSnapshotSchedulePolicyAsync(SnapshotSchedulePolicy, FieldMask, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotSchedulePolicy snapshotSchedulePolicy = new SnapshotSchedulePolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SnapshotSchedulePolicy response = await bareMetalSolutionClient.UpdateSnapshotSchedulePolicyAsync(snapshotSchedulePolicy, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotSchedulePolicy</summary>
        public void DeleteSnapshotSchedulePolicyRequestObject()
        {
            // Snippet: DeleteSnapshotSchedulePolicy(DeleteSnapshotSchedulePolicyRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            DeleteSnapshotSchedulePolicyRequest request = new DeleteSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            // Make the request
            bareMetalSolutionClient.DeleteSnapshotSchedulePolicy(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotSchedulePolicyAsync</summary>
        public async Task DeleteSnapshotSchedulePolicyRequestObjectAsync()
        {
            // Snippet: DeleteSnapshotSchedulePolicyAsync(DeleteSnapshotSchedulePolicyRequest, CallSettings)
            // Additional: DeleteSnapshotSchedulePolicyAsync(DeleteSnapshotSchedulePolicyRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSnapshotSchedulePolicyRequest request = new DeleteSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]"),
            };
            // Make the request
            await bareMetalSolutionClient.DeleteSnapshotSchedulePolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotSchedulePolicy</summary>
        public void DeleteSnapshotSchedulePolicy()
        {
            // Snippet: DeleteSnapshotSchedulePolicy(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/snapshotSchedulePolicies/[SNAPSHOT_SCHEDULE_POLICY]";
            // Make the request
            bareMetalSolutionClient.DeleteSnapshotSchedulePolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotSchedulePolicyAsync</summary>
        public async Task DeleteSnapshotSchedulePolicyAsync()
        {
            // Snippet: DeleteSnapshotSchedulePolicyAsync(string, CallSettings)
            // Additional: DeleteSnapshotSchedulePolicyAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/snapshotSchedulePolicies/[SNAPSHOT_SCHEDULE_POLICY]";
            // Make the request
            await bareMetalSolutionClient.DeleteSnapshotSchedulePolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotSchedulePolicy</summary>
        public void DeleteSnapshotSchedulePolicyResourceNames()
        {
            // Snippet: DeleteSnapshotSchedulePolicy(SnapshotSchedulePolicyName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            SnapshotSchedulePolicyName name = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]");
            // Make the request
            bareMetalSolutionClient.DeleteSnapshotSchedulePolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotSchedulePolicyAsync</summary>
        public async Task DeleteSnapshotSchedulePolicyResourceNamesAsync()
        {
            // Snippet: DeleteSnapshotSchedulePolicyAsync(SnapshotSchedulePolicyName, CallSettings)
            // Additional: DeleteSnapshotSchedulePolicyAsync(SnapshotSchedulePolicyName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotSchedulePolicyName name = SnapshotSchedulePolicyName.FromProjectLocationSnapshotSchedulePolicy("[PROJECT]", "[LOCATION]", "[SNAPSHOT_SCHEDULE_POLICY]");
            // Make the request
            await bareMetalSolutionClient.DeleteSnapshotSchedulePolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateVolumeSnapshot</summary>
        public void CreateVolumeSnapshotRequestObject()
        {
            // Snippet: CreateVolumeSnapshot(CreateVolumeSnapshotRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            CreateVolumeSnapshotRequest request = new CreateVolumeSnapshotRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                VolumeSnapshot = new VolumeSnapshot(),
            };
            // Make the request
            VolumeSnapshot response = bareMetalSolutionClient.CreateVolumeSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for CreateVolumeSnapshotAsync</summary>
        public async Task CreateVolumeSnapshotRequestObjectAsync()
        {
            // Snippet: CreateVolumeSnapshotAsync(CreateVolumeSnapshotRequest, CallSettings)
            // Additional: CreateVolumeSnapshotAsync(CreateVolumeSnapshotRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            CreateVolumeSnapshotRequest request = new CreateVolumeSnapshotRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                VolumeSnapshot = new VolumeSnapshot(),
            };
            // Make the request
            VolumeSnapshot response = await bareMetalSolutionClient.CreateVolumeSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateVolumeSnapshot</summary>
        public void CreateVolumeSnapshot()
        {
            // Snippet: CreateVolumeSnapshot(string, VolumeSnapshot, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            VolumeSnapshot volumeSnapshot = new VolumeSnapshot();
            // Make the request
            VolumeSnapshot response = bareMetalSolutionClient.CreateVolumeSnapshot(parent, volumeSnapshot);
            // End snippet
        }

        /// <summary>Snippet for CreateVolumeSnapshotAsync</summary>
        public async Task CreateVolumeSnapshotAsync()
        {
            // Snippet: CreateVolumeSnapshotAsync(string, VolumeSnapshot, CallSettings)
            // Additional: CreateVolumeSnapshotAsync(string, VolumeSnapshot, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            VolumeSnapshot volumeSnapshot = new VolumeSnapshot();
            // Make the request
            VolumeSnapshot response = await bareMetalSolutionClient.CreateVolumeSnapshotAsync(parent, volumeSnapshot);
            // End snippet
        }

        /// <summary>Snippet for CreateVolumeSnapshot</summary>
        public void CreateVolumeSnapshotResourceNames()
        {
            // Snippet: CreateVolumeSnapshot(VolumeName, VolumeSnapshot, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            VolumeSnapshot volumeSnapshot = new VolumeSnapshot();
            // Make the request
            VolumeSnapshot response = bareMetalSolutionClient.CreateVolumeSnapshot(parent, volumeSnapshot);
            // End snippet
        }

        /// <summary>Snippet for CreateVolumeSnapshotAsync</summary>
        public async Task CreateVolumeSnapshotResourceNamesAsync()
        {
            // Snippet: CreateVolumeSnapshotAsync(VolumeName, VolumeSnapshot, CallSettings)
            // Additional: CreateVolumeSnapshotAsync(VolumeName, VolumeSnapshot, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            VolumeSnapshot volumeSnapshot = new VolumeSnapshot();
            // Make the request
            VolumeSnapshot response = await bareMetalSolutionClient.CreateVolumeSnapshotAsync(parent, volumeSnapshot);
            // End snippet
        }

        /// <summary>Snippet for RestoreVolumeSnapshot</summary>
        public void RestoreVolumeSnapshotRequestObject()
        {
            // Snippet: RestoreVolumeSnapshot(RestoreVolumeSnapshotRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            RestoreVolumeSnapshotRequest request = new RestoreVolumeSnapshotRequest
            {
                VolumeSnapshotAsVolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            Operation<VolumeSnapshot, OperationMetadata> response = bareMetalSolutionClient.RestoreVolumeSnapshot(request);

            // Poll until the returned long-running operation is complete
            Operation<VolumeSnapshot, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VolumeSnapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VolumeSnapshot, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceRestoreVolumeSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VolumeSnapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreVolumeSnapshotAsync</summary>
        public async Task RestoreVolumeSnapshotRequestObjectAsync()
        {
            // Snippet: RestoreVolumeSnapshotAsync(RestoreVolumeSnapshotRequest, CallSettings)
            // Additional: RestoreVolumeSnapshotAsync(RestoreVolumeSnapshotRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            RestoreVolumeSnapshotRequest request = new RestoreVolumeSnapshotRequest
            {
                VolumeSnapshotAsVolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            Operation<VolumeSnapshot, OperationMetadata> response = await bareMetalSolutionClient.RestoreVolumeSnapshotAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<VolumeSnapshot, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VolumeSnapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VolumeSnapshot, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceRestoreVolumeSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VolumeSnapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreVolumeSnapshot</summary>
        public void RestoreVolumeSnapshot()
        {
            // Snippet: RestoreVolumeSnapshot(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string volumeSnapshot = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            Operation<VolumeSnapshot, OperationMetadata> response = bareMetalSolutionClient.RestoreVolumeSnapshot(volumeSnapshot);

            // Poll until the returned long-running operation is complete
            Operation<VolumeSnapshot, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VolumeSnapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VolumeSnapshot, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceRestoreVolumeSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VolumeSnapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreVolumeSnapshotAsync</summary>
        public async Task RestoreVolumeSnapshotAsync()
        {
            // Snippet: RestoreVolumeSnapshotAsync(string, CallSettings)
            // Additional: RestoreVolumeSnapshotAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string volumeSnapshot = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            Operation<VolumeSnapshot, OperationMetadata> response = await bareMetalSolutionClient.RestoreVolumeSnapshotAsync(volumeSnapshot);

            // Poll until the returned long-running operation is complete
            Operation<VolumeSnapshot, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VolumeSnapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VolumeSnapshot, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceRestoreVolumeSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VolumeSnapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreVolumeSnapshot</summary>
        public void RestoreVolumeSnapshotResourceNames()
        {
            // Snippet: RestoreVolumeSnapshot(VolumeSnapshotName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeSnapshotName volumeSnapshot = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            Operation<VolumeSnapshot, OperationMetadata> response = bareMetalSolutionClient.RestoreVolumeSnapshot(volumeSnapshot);

            // Poll until the returned long-running operation is complete
            Operation<VolumeSnapshot, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VolumeSnapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VolumeSnapshot, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceRestoreVolumeSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VolumeSnapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreVolumeSnapshotAsync</summary>
        public async Task RestoreVolumeSnapshotResourceNamesAsync()
        {
            // Snippet: RestoreVolumeSnapshotAsync(VolumeSnapshotName, CallSettings)
            // Additional: RestoreVolumeSnapshotAsync(VolumeSnapshotName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeSnapshotName volumeSnapshot = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            Operation<VolumeSnapshot, OperationMetadata> response = await bareMetalSolutionClient.RestoreVolumeSnapshotAsync(volumeSnapshot);

            // Poll until the returned long-running operation is complete
            Operation<VolumeSnapshot, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VolumeSnapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VolumeSnapshot, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceRestoreVolumeSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VolumeSnapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVolumeSnapshot</summary>
        public void DeleteVolumeSnapshotRequestObject()
        {
            // Snippet: DeleteVolumeSnapshot(DeleteVolumeSnapshotRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            DeleteVolumeSnapshotRequest request = new DeleteVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            bareMetalSolutionClient.DeleteVolumeSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteVolumeSnapshotAsync</summary>
        public async Task DeleteVolumeSnapshotRequestObjectAsync()
        {
            // Snippet: DeleteVolumeSnapshotAsync(DeleteVolumeSnapshotRequest, CallSettings)
            // Additional: DeleteVolumeSnapshotAsync(DeleteVolumeSnapshotRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            DeleteVolumeSnapshotRequest request = new DeleteVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            await bareMetalSolutionClient.DeleteVolumeSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteVolumeSnapshot</summary>
        public void DeleteVolumeSnapshot()
        {
            // Snippet: DeleteVolumeSnapshot(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            bareMetalSolutionClient.DeleteVolumeSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteVolumeSnapshotAsync</summary>
        public async Task DeleteVolumeSnapshotAsync()
        {
            // Snippet: DeleteVolumeSnapshotAsync(string, CallSettings)
            // Additional: DeleteVolumeSnapshotAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            await bareMetalSolutionClient.DeleteVolumeSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteVolumeSnapshot</summary>
        public void DeleteVolumeSnapshotResourceNames()
        {
            // Snippet: DeleteVolumeSnapshot(VolumeSnapshotName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeSnapshotName name = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            bareMetalSolutionClient.DeleteVolumeSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteVolumeSnapshotAsync</summary>
        public async Task DeleteVolumeSnapshotResourceNamesAsync()
        {
            // Snippet: DeleteVolumeSnapshotAsync(VolumeSnapshotName, CallSettings)
            // Additional: DeleteVolumeSnapshotAsync(VolumeSnapshotName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeSnapshotName name = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            await bareMetalSolutionClient.DeleteVolumeSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeSnapshot</summary>
        public void GetVolumeSnapshotRequestObject()
        {
            // Snippet: GetVolumeSnapshot(GetVolumeSnapshotRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            GetVolumeSnapshotRequest request = new GetVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            VolumeSnapshot response = bareMetalSolutionClient.GetVolumeSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeSnapshotAsync</summary>
        public async Task GetVolumeSnapshotRequestObjectAsync()
        {
            // Snippet: GetVolumeSnapshotAsync(GetVolumeSnapshotRequest, CallSettings)
            // Additional: GetVolumeSnapshotAsync(GetVolumeSnapshotRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            GetVolumeSnapshotRequest request = new GetVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            VolumeSnapshot response = await bareMetalSolutionClient.GetVolumeSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeSnapshot</summary>
        public void GetVolumeSnapshot()
        {
            // Snippet: GetVolumeSnapshot(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            VolumeSnapshot response = bareMetalSolutionClient.GetVolumeSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeSnapshotAsync</summary>
        public async Task GetVolumeSnapshotAsync()
        {
            // Snippet: GetVolumeSnapshotAsync(string, CallSettings)
            // Additional: GetVolumeSnapshotAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            VolumeSnapshot response = await bareMetalSolutionClient.GetVolumeSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeSnapshot</summary>
        public void GetVolumeSnapshotResourceNames()
        {
            // Snippet: GetVolumeSnapshot(VolumeSnapshotName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeSnapshotName name = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            VolumeSnapshot response = bareMetalSolutionClient.GetVolumeSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeSnapshotAsync</summary>
        public async Task GetVolumeSnapshotResourceNamesAsync()
        {
            // Snippet: GetVolumeSnapshotAsync(VolumeSnapshotName, CallSettings)
            // Additional: GetVolumeSnapshotAsync(VolumeSnapshotName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeSnapshotName name = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            VolumeSnapshot response = await bareMetalSolutionClient.GetVolumeSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListVolumeSnapshots</summary>
        public void ListVolumeSnapshotsRequestObject()
        {
            // Snippet: ListVolumeSnapshots(ListVolumeSnapshotsRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListVolumeSnapshotsRequest request = new ListVolumeSnapshotsRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            PagedEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> response = bareMetalSolutionClient.ListVolumeSnapshots(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VolumeSnapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumeSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeSnapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeSnapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeSnapshotsAsync</summary>
        public async Task ListVolumeSnapshotsRequestObjectAsync()
        {
            // Snippet: ListVolumeSnapshotsAsync(ListVolumeSnapshotsRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListVolumeSnapshotsRequest request = new ListVolumeSnapshotsRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> response = bareMetalSolutionClient.ListVolumeSnapshotsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VolumeSnapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumeSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeSnapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeSnapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeSnapshots</summary>
        public void ListVolumeSnapshots()
        {
            // Snippet: ListVolumeSnapshots(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            PagedEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> response = bareMetalSolutionClient.ListVolumeSnapshots(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VolumeSnapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumeSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeSnapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeSnapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeSnapshotsAsync</summary>
        public async Task ListVolumeSnapshotsAsync()
        {
            // Snippet: ListVolumeSnapshotsAsync(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            PagedAsyncEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> response = bareMetalSolutionClient.ListVolumeSnapshotsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VolumeSnapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumeSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeSnapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeSnapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeSnapshots</summary>
        public void ListVolumeSnapshotsResourceNames()
        {
            // Snippet: ListVolumeSnapshots(VolumeName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            PagedEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> response = bareMetalSolutionClient.ListVolumeSnapshots(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VolumeSnapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumeSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeSnapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeSnapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeSnapshotsAsync</summary>
        public async Task ListVolumeSnapshotsResourceNamesAsync()
        {
            // Snippet: ListVolumeSnapshotsAsync(VolumeName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            PagedAsyncEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> response = bareMetalSolutionClient.ListVolumeSnapshotsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VolumeSnapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumeSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeSnapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeSnapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetLun</summary>
        public void GetLunRequestObject()
        {
            // Snippet: GetLun(GetLunRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            // Make the request
            Lun response = bareMetalSolutionClient.GetLun(request);
            // End snippet
        }

        /// <summary>Snippet for GetLunAsync</summary>
        public async Task GetLunRequestObjectAsync()
        {
            // Snippet: GetLunAsync(GetLunRequest, CallSettings)
            // Additional: GetLunAsync(GetLunRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            // Make the request
            Lun response = await bareMetalSolutionClient.GetLunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLun</summary>
        public void GetLun()
        {
            // Snippet: GetLun(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/luns/[LUN]";
            // Make the request
            Lun response = bareMetalSolutionClient.GetLun(name);
            // End snippet
        }

        /// <summary>Snippet for GetLunAsync</summary>
        public async Task GetLunAsync()
        {
            // Snippet: GetLunAsync(string, CallSettings)
            // Additional: GetLunAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/luns/[LUN]";
            // Make the request
            Lun response = await bareMetalSolutionClient.GetLunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLun</summary>
        public void GetLunResourceNames()
        {
            // Snippet: GetLun(LunName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LunName name = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]");
            // Make the request
            Lun response = bareMetalSolutionClient.GetLun(name);
            // End snippet
        }

        /// <summary>Snippet for GetLunAsync</summary>
        public async Task GetLunResourceNamesAsync()
        {
            // Snippet: GetLunAsync(LunName, CallSettings)
            // Additional: GetLunAsync(LunName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LunName name = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]");
            // Make the request
            Lun response = await bareMetalSolutionClient.GetLunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLuns</summary>
        public void ListLunsRequestObject()
        {
            // Snippet: ListLuns(ListLunsRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListLunsRequest request = new ListLunsRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            PagedEnumerable<ListLunsResponse, Lun> response = bareMetalSolutionClient.ListLuns(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Lun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLunsAsync</summary>
        public async Task ListLunsRequestObjectAsync()
        {
            // Snippet: ListLunsAsync(ListLunsRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListLunsRequest request = new ListLunsRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListLunsResponse, Lun> response = bareMetalSolutionClient.ListLunsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Lun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLuns</summary>
        public void ListLuns()
        {
            // Snippet: ListLuns(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            PagedEnumerable<ListLunsResponse, Lun> response = bareMetalSolutionClient.ListLuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Lun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLunsAsync</summary>
        public async Task ListLunsAsync()
        {
            // Snippet: ListLunsAsync(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            PagedAsyncEnumerable<ListLunsResponse, Lun> response = bareMetalSolutionClient.ListLunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Lun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLuns</summary>
        public void ListLunsResourceNames()
        {
            // Snippet: ListLuns(VolumeName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            PagedEnumerable<ListLunsResponse, Lun> response = bareMetalSolutionClient.ListLuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Lun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLunsAsync</summary>
        public async Task ListLunsResourceNamesAsync()
        {
            // Snippet: ListLunsAsync(VolumeName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            PagedAsyncEnumerable<ListLunsResponse, Lun> response = bareMetalSolutionClient.ListLunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Lun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lun item in singlePage)
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
