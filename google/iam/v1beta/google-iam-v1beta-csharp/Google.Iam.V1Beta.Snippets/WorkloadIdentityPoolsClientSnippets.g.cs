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

namespace Google.Iam.V1Beta.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedWorkloadIdentityPoolsClientSnippets
    {
        /// <summary>Snippet for ListWorkloadIdentityPools</summary>
        public void ListWorkloadIdentityPoolsRequestObject()
        {
            // Snippet: ListWorkloadIdentityPools(ListWorkloadIdentityPoolsRequest, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            ListWorkloadIdentityPoolsRequest request = new ListWorkloadIdentityPoolsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool> response = workloadIdentityPoolsClient.ListWorkloadIdentityPools(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkloadIdentityPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkloadIdentityPoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkloadIdentityPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkloadIdentityPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkloadIdentityPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadIdentityPoolsAsync</summary>
        public async Task ListWorkloadIdentityPoolsRequestObjectAsync()
        {
            // Snippet: ListWorkloadIdentityPoolsAsync(ListWorkloadIdentityPoolsRequest, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            ListWorkloadIdentityPoolsRequest request = new ListWorkloadIdentityPoolsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool> response = workloadIdentityPoolsClient.ListWorkloadIdentityPoolsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkloadIdentityPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkloadIdentityPoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkloadIdentityPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkloadIdentityPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkloadIdentityPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadIdentityPools</summary>
        public void ListWorkloadIdentityPools()
        {
            // Snippet: ListWorkloadIdentityPools(string, string, int?, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool> response = workloadIdentityPoolsClient.ListWorkloadIdentityPools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkloadIdentityPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkloadIdentityPoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkloadIdentityPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkloadIdentityPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkloadIdentityPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadIdentityPoolsAsync</summary>
        public async Task ListWorkloadIdentityPoolsAsync()
        {
            // Snippet: ListWorkloadIdentityPoolsAsync(string, string, int?, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool> response = workloadIdentityPoolsClient.ListWorkloadIdentityPoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkloadIdentityPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkloadIdentityPoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkloadIdentityPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkloadIdentityPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkloadIdentityPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadIdentityPools</summary>
        public void ListWorkloadIdentityPoolsResourceNames()
        {
            // Snippet: ListWorkloadIdentityPools(ProjectName, string, int?, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool> response = workloadIdentityPoolsClient.ListWorkloadIdentityPools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkloadIdentityPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkloadIdentityPoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkloadIdentityPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkloadIdentityPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkloadIdentityPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadIdentityPoolsAsync</summary>
        public async Task ListWorkloadIdentityPoolsResourceNamesAsync()
        {
            // Snippet: ListWorkloadIdentityPoolsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListWorkloadIdentityPoolsResponse, WorkloadIdentityPool> response = workloadIdentityPoolsClient.ListWorkloadIdentityPoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkloadIdentityPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkloadIdentityPoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkloadIdentityPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkloadIdentityPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkloadIdentityPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadIdentityPool</summary>
        public void GetWorkloadIdentityPoolRequestObject()
        {
            // Snippet: GetWorkloadIdentityPool(GetWorkloadIdentityPoolRequest, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            GetWorkloadIdentityPoolRequest request = new GetWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
            };
            // Make the request
            WorkloadIdentityPool response = workloadIdentityPoolsClient.GetWorkloadIdentityPool(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadIdentityPoolAsync</summary>
        public async Task GetWorkloadIdentityPoolRequestObjectAsync()
        {
            // Snippet: GetWorkloadIdentityPoolAsync(GetWorkloadIdentityPoolRequest, CallSettings)
            // Additional: GetWorkloadIdentityPoolAsync(GetWorkloadIdentityPoolRequest, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkloadIdentityPoolRequest request = new GetWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
            };
            // Make the request
            WorkloadIdentityPool response = await workloadIdentityPoolsClient.GetWorkloadIdentityPoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadIdentityPool</summary>
        public void GetWorkloadIdentityPool()
        {
            // Snippet: GetWorkloadIdentityPool(string, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]";
            // Make the request
            WorkloadIdentityPool response = workloadIdentityPoolsClient.GetWorkloadIdentityPool(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadIdentityPoolAsync</summary>
        public async Task GetWorkloadIdentityPoolAsync()
        {
            // Snippet: GetWorkloadIdentityPoolAsync(string, CallSettings)
            // Additional: GetWorkloadIdentityPoolAsync(string, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]";
            // Make the request
            WorkloadIdentityPool response = await workloadIdentityPoolsClient.GetWorkloadIdentityPoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadIdentityPool</summary>
        public void GetWorkloadIdentityPoolResourceNames()
        {
            // Snippet: GetWorkloadIdentityPool(WorkloadIdentityPoolName, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            WorkloadIdentityPoolName name = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]");
            // Make the request
            WorkloadIdentityPool response = workloadIdentityPoolsClient.GetWorkloadIdentityPool(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadIdentityPoolAsync</summary>
        public async Task GetWorkloadIdentityPoolResourceNamesAsync()
        {
            // Snippet: GetWorkloadIdentityPoolAsync(WorkloadIdentityPoolName, CallSettings)
            // Additional: GetWorkloadIdentityPoolAsync(WorkloadIdentityPoolName, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadIdentityPoolName name = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]");
            // Make the request
            WorkloadIdentityPool response = await workloadIdentityPoolsClient.GetWorkloadIdentityPoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadIdentityPool</summary>
        public void CreateWorkloadIdentityPoolRequestObject()
        {
            // Snippet: CreateWorkloadIdentityPool(CreateWorkloadIdentityPoolRequest, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            CreateWorkloadIdentityPoolRequest request = new CreateWorkloadIdentityPoolRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                WorkloadIdentityPool = new WorkloadIdentityPool(),
                WorkloadIdentityPoolId = "",
            };
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = workloadIdentityPoolsClient.CreateWorkloadIdentityPool(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceCreateWorkloadIdentityPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadIdentityPoolAsync</summary>
        public async Task CreateWorkloadIdentityPoolRequestObjectAsync()
        {
            // Snippet: CreateWorkloadIdentityPoolAsync(CreateWorkloadIdentityPoolRequest, CallSettings)
            // Additional: CreateWorkloadIdentityPoolAsync(CreateWorkloadIdentityPoolRequest, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            CreateWorkloadIdentityPoolRequest request = new CreateWorkloadIdentityPoolRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                WorkloadIdentityPool = new WorkloadIdentityPool(),
                WorkloadIdentityPoolId = "",
            };
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = await workloadIdentityPoolsClient.CreateWorkloadIdentityPoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceCreateWorkloadIdentityPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadIdentityPool</summary>
        public void CreateWorkloadIdentityPool()
        {
            // Snippet: CreateWorkloadIdentityPool(string, WorkloadIdentityPool, string, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            WorkloadIdentityPool workloadIdentityPool = new WorkloadIdentityPool();
            string workloadIdentityPoolId = "";
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = workloadIdentityPoolsClient.CreateWorkloadIdentityPool(parent, workloadIdentityPool, workloadIdentityPoolId);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceCreateWorkloadIdentityPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadIdentityPoolAsync</summary>
        public async Task CreateWorkloadIdentityPoolAsync()
        {
            // Snippet: CreateWorkloadIdentityPoolAsync(string, WorkloadIdentityPool, string, CallSettings)
            // Additional: CreateWorkloadIdentityPoolAsync(string, WorkloadIdentityPool, string, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            WorkloadIdentityPool workloadIdentityPool = new WorkloadIdentityPool();
            string workloadIdentityPoolId = "";
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = await workloadIdentityPoolsClient.CreateWorkloadIdentityPoolAsync(parent, workloadIdentityPool, workloadIdentityPoolId);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceCreateWorkloadIdentityPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadIdentityPool</summary>
        public void CreateWorkloadIdentityPoolResourceNames()
        {
            // Snippet: CreateWorkloadIdentityPool(ProjectName, WorkloadIdentityPool, string, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            WorkloadIdentityPool workloadIdentityPool = new WorkloadIdentityPool();
            string workloadIdentityPoolId = "";
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = workloadIdentityPoolsClient.CreateWorkloadIdentityPool(parent, workloadIdentityPool, workloadIdentityPoolId);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceCreateWorkloadIdentityPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadIdentityPoolAsync</summary>
        public async Task CreateWorkloadIdentityPoolResourceNamesAsync()
        {
            // Snippet: CreateWorkloadIdentityPoolAsync(ProjectName, WorkloadIdentityPool, string, CallSettings)
            // Additional: CreateWorkloadIdentityPoolAsync(ProjectName, WorkloadIdentityPool, string, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            WorkloadIdentityPool workloadIdentityPool = new WorkloadIdentityPool();
            string workloadIdentityPoolId = "";
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = await workloadIdentityPoolsClient.CreateWorkloadIdentityPoolAsync(parent, workloadIdentityPool, workloadIdentityPoolId);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceCreateWorkloadIdentityPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkloadIdentityPool</summary>
        public void UpdateWorkloadIdentityPoolRequestObject()
        {
            // Snippet: UpdateWorkloadIdentityPool(UpdateWorkloadIdentityPoolRequest, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            UpdateWorkloadIdentityPoolRequest request = new UpdateWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPool = new WorkloadIdentityPool(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = workloadIdentityPoolsClient.UpdateWorkloadIdentityPool(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceUpdateWorkloadIdentityPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkloadIdentityPoolAsync</summary>
        public async Task UpdateWorkloadIdentityPoolRequestObjectAsync()
        {
            // Snippet: UpdateWorkloadIdentityPoolAsync(UpdateWorkloadIdentityPoolRequest, CallSettings)
            // Additional: UpdateWorkloadIdentityPoolAsync(UpdateWorkloadIdentityPoolRequest, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWorkloadIdentityPoolRequest request = new UpdateWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPool = new WorkloadIdentityPool(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = await workloadIdentityPoolsClient.UpdateWorkloadIdentityPoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceUpdateWorkloadIdentityPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkloadIdentityPool</summary>
        public void UpdateWorkloadIdentityPool()
        {
            // Snippet: UpdateWorkloadIdentityPool(WorkloadIdentityPool, FieldMask, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            WorkloadIdentityPool workloadIdentityPool = new WorkloadIdentityPool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = workloadIdentityPoolsClient.UpdateWorkloadIdentityPool(workloadIdentityPool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceUpdateWorkloadIdentityPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkloadIdentityPoolAsync</summary>
        public async Task UpdateWorkloadIdentityPoolAsync()
        {
            // Snippet: UpdateWorkloadIdentityPoolAsync(WorkloadIdentityPool, FieldMask, CallSettings)
            // Additional: UpdateWorkloadIdentityPoolAsync(WorkloadIdentityPool, FieldMask, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadIdentityPool workloadIdentityPool = new WorkloadIdentityPool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = await workloadIdentityPoolsClient.UpdateWorkloadIdentityPoolAsync(workloadIdentityPool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceUpdateWorkloadIdentityPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadIdentityPool</summary>
        public void DeleteWorkloadIdentityPoolRequestObject()
        {
            // Snippet: DeleteWorkloadIdentityPool(DeleteWorkloadIdentityPoolRequest, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            DeleteWorkloadIdentityPoolRequest request = new DeleteWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
            };
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = workloadIdentityPoolsClient.DeleteWorkloadIdentityPool(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceDeleteWorkloadIdentityPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadIdentityPoolAsync</summary>
        public async Task DeleteWorkloadIdentityPoolRequestObjectAsync()
        {
            // Snippet: DeleteWorkloadIdentityPoolAsync(DeleteWorkloadIdentityPoolRequest, CallSettings)
            // Additional: DeleteWorkloadIdentityPoolAsync(DeleteWorkloadIdentityPoolRequest, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWorkloadIdentityPoolRequest request = new DeleteWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
            };
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = await workloadIdentityPoolsClient.DeleteWorkloadIdentityPoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceDeleteWorkloadIdentityPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadIdentityPool</summary>
        public void DeleteWorkloadIdentityPool()
        {
            // Snippet: DeleteWorkloadIdentityPool(string, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]";
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = workloadIdentityPoolsClient.DeleteWorkloadIdentityPool(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceDeleteWorkloadIdentityPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadIdentityPoolAsync</summary>
        public async Task DeleteWorkloadIdentityPoolAsync()
        {
            // Snippet: DeleteWorkloadIdentityPoolAsync(string, CallSettings)
            // Additional: DeleteWorkloadIdentityPoolAsync(string, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]";
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = await workloadIdentityPoolsClient.DeleteWorkloadIdentityPoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceDeleteWorkloadIdentityPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadIdentityPool</summary>
        public void DeleteWorkloadIdentityPoolResourceNames()
        {
            // Snippet: DeleteWorkloadIdentityPool(WorkloadIdentityPoolName, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            WorkloadIdentityPoolName name = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]");
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = workloadIdentityPoolsClient.DeleteWorkloadIdentityPool(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceDeleteWorkloadIdentityPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadIdentityPoolAsync</summary>
        public async Task DeleteWorkloadIdentityPoolResourceNamesAsync()
        {
            // Snippet: DeleteWorkloadIdentityPoolAsync(WorkloadIdentityPoolName, CallSettings)
            // Additional: DeleteWorkloadIdentityPoolAsync(WorkloadIdentityPoolName, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadIdentityPoolName name = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]");
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = await workloadIdentityPoolsClient.DeleteWorkloadIdentityPoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceDeleteWorkloadIdentityPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteWorkloadIdentityPool</summary>
        public void UndeleteWorkloadIdentityPoolRequestObject()
        {
            // Snippet: UndeleteWorkloadIdentityPool(UndeleteWorkloadIdentityPoolRequest, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            UndeleteWorkloadIdentityPoolRequest request = new UndeleteWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
            };
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = workloadIdentityPoolsClient.UndeleteWorkloadIdentityPool(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceUndeleteWorkloadIdentityPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteWorkloadIdentityPoolAsync</summary>
        public async Task UndeleteWorkloadIdentityPoolRequestObjectAsync()
        {
            // Snippet: UndeleteWorkloadIdentityPoolAsync(UndeleteWorkloadIdentityPoolRequest, CallSettings)
            // Additional: UndeleteWorkloadIdentityPoolAsync(UndeleteWorkloadIdentityPoolRequest, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteWorkloadIdentityPoolRequest request = new UndeleteWorkloadIdentityPoolRequest
            {
                WorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
            };
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = await workloadIdentityPoolsClient.UndeleteWorkloadIdentityPoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceUndeleteWorkloadIdentityPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteWorkloadIdentityPool</summary>
        public void UndeleteWorkloadIdentityPool()
        {
            // Snippet: UndeleteWorkloadIdentityPool(string, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]";
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = workloadIdentityPoolsClient.UndeleteWorkloadIdentityPool(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceUndeleteWorkloadIdentityPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteWorkloadIdentityPoolAsync</summary>
        public async Task UndeleteWorkloadIdentityPoolAsync()
        {
            // Snippet: UndeleteWorkloadIdentityPoolAsync(string, CallSettings)
            // Additional: UndeleteWorkloadIdentityPoolAsync(string, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]";
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = await workloadIdentityPoolsClient.UndeleteWorkloadIdentityPoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceUndeleteWorkloadIdentityPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteWorkloadIdentityPool</summary>
        public void UndeleteWorkloadIdentityPoolResourceNames()
        {
            // Snippet: UndeleteWorkloadIdentityPool(WorkloadIdentityPoolName, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            WorkloadIdentityPoolName name = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]");
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = workloadIdentityPoolsClient.UndeleteWorkloadIdentityPool(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceUndeleteWorkloadIdentityPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteWorkloadIdentityPoolAsync</summary>
        public async Task UndeleteWorkloadIdentityPoolResourceNamesAsync()
        {
            // Snippet: UndeleteWorkloadIdentityPoolAsync(WorkloadIdentityPoolName, CallSettings)
            // Additional: UndeleteWorkloadIdentityPoolAsync(WorkloadIdentityPoolName, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadIdentityPoolName name = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]");
            // Make the request
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> response = await workloadIdentityPoolsClient.UndeleteWorkloadIdentityPoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceUndeleteWorkloadIdentityPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadIdentityPoolProviders</summary>
        public void ListWorkloadIdentityPoolProvidersRequestObject()
        {
            // Snippet: ListWorkloadIdentityPoolProviders(ListWorkloadIdentityPoolProvidersRequest, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            ListWorkloadIdentityPoolProvidersRequest request = new ListWorkloadIdentityPoolProvidersRequest
            {
                ParentAsWorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider> response = workloadIdentityPoolsClient.ListWorkloadIdentityPoolProviders(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkloadIdentityPoolProvider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkloadIdentityPoolProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkloadIdentityPoolProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkloadIdentityPoolProvider> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkloadIdentityPoolProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadIdentityPoolProvidersAsync</summary>
        public async Task ListWorkloadIdentityPoolProvidersRequestObjectAsync()
        {
            // Snippet: ListWorkloadIdentityPoolProvidersAsync(ListWorkloadIdentityPoolProvidersRequest, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            ListWorkloadIdentityPoolProvidersRequest request = new ListWorkloadIdentityPoolProvidersRequest
            {
                ParentAsWorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider> response = workloadIdentityPoolsClient.ListWorkloadIdentityPoolProvidersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkloadIdentityPoolProvider item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkloadIdentityPoolProvidersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkloadIdentityPoolProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkloadIdentityPoolProvider> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkloadIdentityPoolProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadIdentityPoolProviders</summary>
        public void ListWorkloadIdentityPoolProviders()
        {
            // Snippet: ListWorkloadIdentityPoolProviders(string, string, int?, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]";
            // Make the request
            PagedEnumerable<ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider> response = workloadIdentityPoolsClient.ListWorkloadIdentityPoolProviders(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkloadIdentityPoolProvider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkloadIdentityPoolProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkloadIdentityPoolProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkloadIdentityPoolProvider> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkloadIdentityPoolProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadIdentityPoolProvidersAsync</summary>
        public async Task ListWorkloadIdentityPoolProvidersAsync()
        {
            // Snippet: ListWorkloadIdentityPoolProvidersAsync(string, string, int?, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]";
            // Make the request
            PagedAsyncEnumerable<ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider> response = workloadIdentityPoolsClient.ListWorkloadIdentityPoolProvidersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkloadIdentityPoolProvider item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkloadIdentityPoolProvidersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkloadIdentityPoolProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkloadIdentityPoolProvider> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkloadIdentityPoolProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadIdentityPoolProviders</summary>
        public void ListWorkloadIdentityPoolProvidersResourceNames()
        {
            // Snippet: ListWorkloadIdentityPoolProviders(WorkloadIdentityPoolName, string, int?, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            WorkloadIdentityPoolName parent = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]");
            // Make the request
            PagedEnumerable<ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider> response = workloadIdentityPoolsClient.ListWorkloadIdentityPoolProviders(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkloadIdentityPoolProvider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkloadIdentityPoolProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkloadIdentityPoolProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkloadIdentityPoolProvider> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkloadIdentityPoolProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadIdentityPoolProvidersAsync</summary>
        public async Task ListWorkloadIdentityPoolProvidersResourceNamesAsync()
        {
            // Snippet: ListWorkloadIdentityPoolProvidersAsync(WorkloadIdentityPoolName, string, int?, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadIdentityPoolName parent = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]");
            // Make the request
            PagedAsyncEnumerable<ListWorkloadIdentityPoolProvidersResponse, WorkloadIdentityPoolProvider> response = workloadIdentityPoolsClient.ListWorkloadIdentityPoolProvidersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkloadIdentityPoolProvider item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkloadIdentityPoolProvidersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkloadIdentityPoolProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkloadIdentityPoolProvider> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkloadIdentityPoolProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadIdentityPoolProvider</summary>
        public void GetWorkloadIdentityPoolProviderRequestObject()
        {
            // Snippet: GetWorkloadIdentityPoolProvider(GetWorkloadIdentityPoolProviderRequest, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            GetWorkloadIdentityPoolProviderRequest request = new GetWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
            };
            // Make the request
            WorkloadIdentityPoolProvider response = workloadIdentityPoolsClient.GetWorkloadIdentityPoolProvider(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadIdentityPoolProviderAsync</summary>
        public async Task GetWorkloadIdentityPoolProviderRequestObjectAsync()
        {
            // Snippet: GetWorkloadIdentityPoolProviderAsync(GetWorkloadIdentityPoolProviderRequest, CallSettings)
            // Additional: GetWorkloadIdentityPoolProviderAsync(GetWorkloadIdentityPoolProviderRequest, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkloadIdentityPoolProviderRequest request = new GetWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
            };
            // Make the request
            WorkloadIdentityPoolProvider response = await workloadIdentityPoolsClient.GetWorkloadIdentityPoolProviderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadIdentityPoolProvider</summary>
        public void GetWorkloadIdentityPoolProvider()
        {
            // Snippet: GetWorkloadIdentityPoolProvider(string, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]/providers/[WORKLOAD_IDENTITY_POOL_PROVIDER]";
            // Make the request
            WorkloadIdentityPoolProvider response = workloadIdentityPoolsClient.GetWorkloadIdentityPoolProvider(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadIdentityPoolProviderAsync</summary>
        public async Task GetWorkloadIdentityPoolProviderAsync()
        {
            // Snippet: GetWorkloadIdentityPoolProviderAsync(string, CallSettings)
            // Additional: GetWorkloadIdentityPoolProviderAsync(string, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]/providers/[WORKLOAD_IDENTITY_POOL_PROVIDER]";
            // Make the request
            WorkloadIdentityPoolProvider response = await workloadIdentityPoolsClient.GetWorkloadIdentityPoolProviderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadIdentityPoolProvider</summary>
        public void GetWorkloadIdentityPoolProviderResourceNames()
        {
            // Snippet: GetWorkloadIdentityPoolProvider(WorkloadIdentityPoolProviderName, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            WorkloadIdentityPoolProviderName name = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]");
            // Make the request
            WorkloadIdentityPoolProvider response = workloadIdentityPoolsClient.GetWorkloadIdentityPoolProvider(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadIdentityPoolProviderAsync</summary>
        public async Task GetWorkloadIdentityPoolProviderResourceNamesAsync()
        {
            // Snippet: GetWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProviderName, CallSettings)
            // Additional: GetWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProviderName, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadIdentityPoolProviderName name = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]");
            // Make the request
            WorkloadIdentityPoolProvider response = await workloadIdentityPoolsClient.GetWorkloadIdentityPoolProviderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadIdentityPoolProvider</summary>
        public void CreateWorkloadIdentityPoolProviderRequestObject()
        {
            // Snippet: CreateWorkloadIdentityPoolProvider(CreateWorkloadIdentityPoolProviderRequest, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            CreateWorkloadIdentityPoolProviderRequest request = new CreateWorkloadIdentityPoolProviderRequest
            {
                ParentAsWorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
                WorkloadIdentityPoolProvider = new WorkloadIdentityPoolProvider(),
                WorkloadIdentityPoolProviderId = "",
            };
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = workloadIdentityPoolsClient.CreateWorkloadIdentityPoolProvider(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceCreateWorkloadIdentityPoolProvider(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadIdentityPoolProviderAsync</summary>
        public async Task CreateWorkloadIdentityPoolProviderRequestObjectAsync()
        {
            // Snippet: CreateWorkloadIdentityPoolProviderAsync(CreateWorkloadIdentityPoolProviderRequest, CallSettings)
            // Additional: CreateWorkloadIdentityPoolProviderAsync(CreateWorkloadIdentityPoolProviderRequest, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            CreateWorkloadIdentityPoolProviderRequest request = new CreateWorkloadIdentityPoolProviderRequest
            {
                ParentAsWorkloadIdentityPoolName = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]"),
                WorkloadIdentityPoolProvider = new WorkloadIdentityPoolProvider(),
                WorkloadIdentityPoolProviderId = "",
            };
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = await workloadIdentityPoolsClient.CreateWorkloadIdentityPoolProviderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceCreateWorkloadIdentityPoolProviderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadIdentityPoolProvider</summary>
        public void CreateWorkloadIdentityPoolProvider()
        {
            // Snippet: CreateWorkloadIdentityPoolProvider(string, WorkloadIdentityPoolProvider, string, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]";
            WorkloadIdentityPoolProvider workloadIdentityPoolProvider = new WorkloadIdentityPoolProvider();
            string workloadIdentityPoolProviderId = "";
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = workloadIdentityPoolsClient.CreateWorkloadIdentityPoolProvider(parent, workloadIdentityPoolProvider, workloadIdentityPoolProviderId);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceCreateWorkloadIdentityPoolProvider(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadIdentityPoolProviderAsync</summary>
        public async Task CreateWorkloadIdentityPoolProviderAsync()
        {
            // Snippet: CreateWorkloadIdentityPoolProviderAsync(string, WorkloadIdentityPoolProvider, string, CallSettings)
            // Additional: CreateWorkloadIdentityPoolProviderAsync(string, WorkloadIdentityPoolProvider, string, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]";
            WorkloadIdentityPoolProvider workloadIdentityPoolProvider = new WorkloadIdentityPoolProvider();
            string workloadIdentityPoolProviderId = "";
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = await workloadIdentityPoolsClient.CreateWorkloadIdentityPoolProviderAsync(parent, workloadIdentityPoolProvider, workloadIdentityPoolProviderId);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceCreateWorkloadIdentityPoolProviderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadIdentityPoolProvider</summary>
        public void CreateWorkloadIdentityPoolProviderResourceNames()
        {
            // Snippet: CreateWorkloadIdentityPoolProvider(WorkloadIdentityPoolName, WorkloadIdentityPoolProvider, string, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            WorkloadIdentityPoolName parent = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]");
            WorkloadIdentityPoolProvider workloadIdentityPoolProvider = new WorkloadIdentityPoolProvider();
            string workloadIdentityPoolProviderId = "";
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = workloadIdentityPoolsClient.CreateWorkloadIdentityPoolProvider(parent, workloadIdentityPoolProvider, workloadIdentityPoolProviderId);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceCreateWorkloadIdentityPoolProvider(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadIdentityPoolProviderAsync</summary>
        public async Task CreateWorkloadIdentityPoolProviderResourceNamesAsync()
        {
            // Snippet: CreateWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolName, WorkloadIdentityPoolProvider, string, CallSettings)
            // Additional: CreateWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolName, WorkloadIdentityPoolProvider, string, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadIdentityPoolName parent = WorkloadIdentityPoolName.FromProjectLocationWorkloadIdentityPool("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]");
            WorkloadIdentityPoolProvider workloadIdentityPoolProvider = new WorkloadIdentityPoolProvider();
            string workloadIdentityPoolProviderId = "";
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = await workloadIdentityPoolsClient.CreateWorkloadIdentityPoolProviderAsync(parent, workloadIdentityPoolProvider, workloadIdentityPoolProviderId);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceCreateWorkloadIdentityPoolProviderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkloadIdentityPoolProvider</summary>
        public void UpdateWorkloadIdentityPoolProviderRequestObject()
        {
            // Snippet: UpdateWorkloadIdentityPoolProvider(UpdateWorkloadIdentityPoolProviderRequest, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            UpdateWorkloadIdentityPoolProviderRequest request = new UpdateWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProvider = new WorkloadIdentityPoolProvider(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = workloadIdentityPoolsClient.UpdateWorkloadIdentityPoolProvider(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceUpdateWorkloadIdentityPoolProvider(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkloadIdentityPoolProviderAsync</summary>
        public async Task UpdateWorkloadIdentityPoolProviderRequestObjectAsync()
        {
            // Snippet: UpdateWorkloadIdentityPoolProviderAsync(UpdateWorkloadIdentityPoolProviderRequest, CallSettings)
            // Additional: UpdateWorkloadIdentityPoolProviderAsync(UpdateWorkloadIdentityPoolProviderRequest, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWorkloadIdentityPoolProviderRequest request = new UpdateWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProvider = new WorkloadIdentityPoolProvider(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = await workloadIdentityPoolsClient.UpdateWorkloadIdentityPoolProviderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceUpdateWorkloadIdentityPoolProviderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkloadIdentityPoolProvider</summary>
        public void UpdateWorkloadIdentityPoolProvider()
        {
            // Snippet: UpdateWorkloadIdentityPoolProvider(WorkloadIdentityPoolProvider, FieldMask, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            WorkloadIdentityPoolProvider workloadIdentityPoolProvider = new WorkloadIdentityPoolProvider();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = workloadIdentityPoolsClient.UpdateWorkloadIdentityPoolProvider(workloadIdentityPoolProvider, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceUpdateWorkloadIdentityPoolProvider(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkloadIdentityPoolProviderAsync</summary>
        public async Task UpdateWorkloadIdentityPoolProviderAsync()
        {
            // Snippet: UpdateWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProvider, FieldMask, CallSettings)
            // Additional: UpdateWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProvider, FieldMask, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadIdentityPoolProvider workloadIdentityPoolProvider = new WorkloadIdentityPoolProvider();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = await workloadIdentityPoolsClient.UpdateWorkloadIdentityPoolProviderAsync(workloadIdentityPoolProvider, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceUpdateWorkloadIdentityPoolProviderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadIdentityPoolProvider</summary>
        public void DeleteWorkloadIdentityPoolProviderRequestObject()
        {
            // Snippet: DeleteWorkloadIdentityPoolProvider(DeleteWorkloadIdentityPoolProviderRequest, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            DeleteWorkloadIdentityPoolProviderRequest request = new DeleteWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
            };
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = workloadIdentityPoolsClient.DeleteWorkloadIdentityPoolProvider(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceDeleteWorkloadIdentityPoolProvider(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadIdentityPoolProviderAsync</summary>
        public async Task DeleteWorkloadIdentityPoolProviderRequestObjectAsync()
        {
            // Snippet: DeleteWorkloadIdentityPoolProviderAsync(DeleteWorkloadIdentityPoolProviderRequest, CallSettings)
            // Additional: DeleteWorkloadIdentityPoolProviderAsync(DeleteWorkloadIdentityPoolProviderRequest, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWorkloadIdentityPoolProviderRequest request = new DeleteWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
            };
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = await workloadIdentityPoolsClient.DeleteWorkloadIdentityPoolProviderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceDeleteWorkloadIdentityPoolProviderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadIdentityPoolProvider</summary>
        public void DeleteWorkloadIdentityPoolProvider()
        {
            // Snippet: DeleteWorkloadIdentityPoolProvider(string, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]/providers/[WORKLOAD_IDENTITY_POOL_PROVIDER]";
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = workloadIdentityPoolsClient.DeleteWorkloadIdentityPoolProvider(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceDeleteWorkloadIdentityPoolProvider(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadIdentityPoolProviderAsync</summary>
        public async Task DeleteWorkloadIdentityPoolProviderAsync()
        {
            // Snippet: DeleteWorkloadIdentityPoolProviderAsync(string, CallSettings)
            // Additional: DeleteWorkloadIdentityPoolProviderAsync(string, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]/providers/[WORKLOAD_IDENTITY_POOL_PROVIDER]";
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = await workloadIdentityPoolsClient.DeleteWorkloadIdentityPoolProviderAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceDeleteWorkloadIdentityPoolProviderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadIdentityPoolProvider</summary>
        public void DeleteWorkloadIdentityPoolProviderResourceNames()
        {
            // Snippet: DeleteWorkloadIdentityPoolProvider(WorkloadIdentityPoolProviderName, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            WorkloadIdentityPoolProviderName name = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]");
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = workloadIdentityPoolsClient.DeleteWorkloadIdentityPoolProvider(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceDeleteWorkloadIdentityPoolProvider(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadIdentityPoolProviderAsync</summary>
        public async Task DeleteWorkloadIdentityPoolProviderResourceNamesAsync()
        {
            // Snippet: DeleteWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProviderName, CallSettings)
            // Additional: DeleteWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProviderName, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadIdentityPoolProviderName name = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]");
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = await workloadIdentityPoolsClient.DeleteWorkloadIdentityPoolProviderAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceDeleteWorkloadIdentityPoolProviderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteWorkloadIdentityPoolProvider</summary>
        public void UndeleteWorkloadIdentityPoolProviderRequestObject()
        {
            // Snippet: UndeleteWorkloadIdentityPoolProvider(UndeleteWorkloadIdentityPoolProviderRequest, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            UndeleteWorkloadIdentityPoolProviderRequest request = new UndeleteWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
            };
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = workloadIdentityPoolsClient.UndeleteWorkloadIdentityPoolProvider(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceUndeleteWorkloadIdentityPoolProvider(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteWorkloadIdentityPoolProviderAsync</summary>
        public async Task UndeleteWorkloadIdentityPoolProviderRequestObjectAsync()
        {
            // Snippet: UndeleteWorkloadIdentityPoolProviderAsync(UndeleteWorkloadIdentityPoolProviderRequest, CallSettings)
            // Additional: UndeleteWorkloadIdentityPoolProviderAsync(UndeleteWorkloadIdentityPoolProviderRequest, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteWorkloadIdentityPoolProviderRequest request = new UndeleteWorkloadIdentityPoolProviderRequest
            {
                WorkloadIdentityPoolProviderName = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]"),
            };
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = await workloadIdentityPoolsClient.UndeleteWorkloadIdentityPoolProviderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceUndeleteWorkloadIdentityPoolProviderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteWorkloadIdentityPoolProvider</summary>
        public void UndeleteWorkloadIdentityPoolProvider()
        {
            // Snippet: UndeleteWorkloadIdentityPoolProvider(string, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]/providers/[WORKLOAD_IDENTITY_POOL_PROVIDER]";
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = workloadIdentityPoolsClient.UndeleteWorkloadIdentityPoolProvider(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceUndeleteWorkloadIdentityPoolProvider(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteWorkloadIdentityPoolProviderAsync</summary>
        public async Task UndeleteWorkloadIdentityPoolProviderAsync()
        {
            // Snippet: UndeleteWorkloadIdentityPoolProviderAsync(string, CallSettings)
            // Additional: UndeleteWorkloadIdentityPoolProviderAsync(string, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workloadIdentityPools/[WORKLOAD_IDENTITY_POOL]/providers/[WORKLOAD_IDENTITY_POOL_PROVIDER]";
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = await workloadIdentityPoolsClient.UndeleteWorkloadIdentityPoolProviderAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceUndeleteWorkloadIdentityPoolProviderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteWorkloadIdentityPoolProvider</summary>
        public void UndeleteWorkloadIdentityPoolProviderResourceNames()
        {
            // Snippet: UndeleteWorkloadIdentityPoolProvider(WorkloadIdentityPoolProviderName, CallSettings)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = WorkloadIdentityPoolsClient.Create();
            // Initialize request argument(s)
            WorkloadIdentityPoolProviderName name = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]");
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = workloadIdentityPoolsClient.UndeleteWorkloadIdentityPoolProvider(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = workloadIdentityPoolsClient.PollOnceUndeleteWorkloadIdentityPoolProvider(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteWorkloadIdentityPoolProviderAsync</summary>
        public async Task UndeleteWorkloadIdentityPoolProviderResourceNamesAsync()
        {
            // Snippet: UndeleteWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProviderName, CallSettings)
            // Additional: UndeleteWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProviderName, CancellationToken)
            // Create client
            WorkloadIdentityPoolsClient workloadIdentityPoolsClient = await WorkloadIdentityPoolsClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadIdentityPoolProviderName name = WorkloadIdentityPoolProviderName.FromProjectLocationWorkloadIdentityPoolWorkloadIdentityPoolProvider("[PROJECT]", "[LOCATION]", "[WORKLOAD_IDENTITY_POOL]", "[WORKLOAD_IDENTITY_POOL_PROVIDER]");
            // Make the request
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> response = await workloadIdentityPoolsClient.UndeleteWorkloadIdentityPoolProviderAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkloadIdentityPoolProvider result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata> retrievedResponse = await workloadIdentityPoolsClient.PollOnceUndeleteWorkloadIdentityPoolProviderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkloadIdentityPoolProvider retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
