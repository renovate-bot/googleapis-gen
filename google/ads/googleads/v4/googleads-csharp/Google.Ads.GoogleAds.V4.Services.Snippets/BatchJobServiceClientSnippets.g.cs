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
    using Google.Ads.GoogleAds.V4.Resources;
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedBatchJobServiceClientSnippets
    {
        /// <summary>Snippet for MutateBatchJob</summary>
        public void MutateBatchJobRequestObject()
        {
            // Snippet: MutateBatchJob(MutateBatchJobRequest, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            MutateBatchJobRequest request = new MutateBatchJobRequest
            {
                CustomerId = "",
                Operation = new BatchJobOperation(),
            };
            // Make the request
            MutateBatchJobResponse response = batchJobServiceClient.MutateBatchJob(request);
            // End snippet
        }

        /// <summary>Snippet for MutateBatchJobAsync</summary>
        public async Task MutateBatchJobRequestObjectAsync()
        {
            // Snippet: MutateBatchJobAsync(MutateBatchJobRequest, CallSettings)
            // Additional: MutateBatchJobAsync(MutateBatchJobRequest, CancellationToken)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateBatchJobRequest request = new MutateBatchJobRequest
            {
                CustomerId = "",
                Operation = new BatchJobOperation(),
            };
            // Make the request
            MutateBatchJobResponse response = await batchJobServiceClient.MutateBatchJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateBatchJob</summary>
        public void MutateBatchJob()
        {
            // Snippet: MutateBatchJob(string, BatchJobOperation, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            BatchJobOperation operation = new BatchJobOperation();
            // Make the request
            MutateBatchJobResponse response = batchJobServiceClient.MutateBatchJob(customerId, operation);
            // End snippet
        }

        /// <summary>Snippet for MutateBatchJobAsync</summary>
        public async Task MutateBatchJobAsync()
        {
            // Snippet: MutateBatchJobAsync(string, BatchJobOperation, CallSettings)
            // Additional: MutateBatchJobAsync(string, BatchJobOperation, CancellationToken)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            BatchJobOperation operation = new BatchJobOperation();
            // Make the request
            MutateBatchJobResponse response = await batchJobServiceClient.MutateBatchJobAsync(customerId, operation);
            // End snippet
        }

        /// <summary>Snippet for GetBatchJob</summary>
        public void GetBatchJobRequestObject()
        {
            // Snippet: GetBatchJob(GetBatchJobRequest, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            GetBatchJobRequest request = new GetBatchJobRequest
            {
                ResourceNameAsBatchJobName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]"),
            };
            // Make the request
            BatchJob response = batchJobServiceClient.GetBatchJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetBatchJobAsync</summary>
        public async Task GetBatchJobRequestObjectAsync()
        {
            // Snippet: GetBatchJobAsync(GetBatchJobRequest, CallSettings)
            // Additional: GetBatchJobAsync(GetBatchJobRequest, CancellationToken)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBatchJobRequest request = new GetBatchJobRequest
            {
                ResourceNameAsBatchJobName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]"),
            };
            // Make the request
            BatchJob response = await batchJobServiceClient.GetBatchJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBatchJob</summary>
        public void GetBatchJob()
        {
            // Snippet: GetBatchJob(string, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/batchJobs/[BATCH_JOB]";
            // Make the request
            BatchJob response = batchJobServiceClient.GetBatchJob(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBatchJobAsync</summary>
        public async Task GetBatchJobAsync()
        {
            // Snippet: GetBatchJobAsync(string, CallSettings)
            // Additional: GetBatchJobAsync(string, CancellationToken)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/batchJobs/[BATCH_JOB]";
            // Make the request
            BatchJob response = await batchJobServiceClient.GetBatchJobAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBatchJob</summary>
        public void GetBatchJobResourceNames()
        {
            // Snippet: GetBatchJob(BatchJobName, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            BatchJobName resourceName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]");
            // Make the request
            BatchJob response = batchJobServiceClient.GetBatchJob(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBatchJobAsync</summary>
        public async Task GetBatchJobResourceNamesAsync()
        {
            // Snippet: GetBatchJobAsync(BatchJobName, CallSettings)
            // Additional: GetBatchJobAsync(BatchJobName, CancellationToken)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchJobName resourceName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]");
            // Make the request
            BatchJob response = await batchJobServiceClient.GetBatchJobAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for ListBatchJobResults</summary>
        public void ListBatchJobResultsRequestObject()
        {
            // Snippet: ListBatchJobResults(ListBatchJobResultsRequest, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            ListBatchJobResultsRequest request = new ListBatchJobResultsRequest
            {
                ResourceNameAsBatchJobName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]"),
            };
            // Make the request
            PagedEnumerable<ListBatchJobResultsResponse, BatchJobResult> response = batchJobServiceClient.ListBatchJobResults(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BatchJobResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBatchJobResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BatchJobResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BatchJobResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BatchJobResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBatchJobResults</summary>
        public async Task ListBatchJobResultsRequestObjectAsync()
        {
            // Snippet: ListBatchJobResultsAsync(ListBatchJobResultsRequest, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListBatchJobResultsRequest request = new ListBatchJobResultsRequest
            {
                ResourceNameAsBatchJobName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListBatchJobResultsResponse, BatchJobResult> response = batchJobServiceClient.ListBatchJobResultsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BatchJobResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBatchJobResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BatchJobResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BatchJobResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BatchJobResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBatchJobResults</summary>
        public void ListBatchJobResults()
        {
            // Snippet: ListBatchJobResults(string, string, int?, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/batchJobs/[BATCH_JOB]";
            // Make the request
            PagedEnumerable<ListBatchJobResultsResponse, BatchJobResult> response = batchJobServiceClient.ListBatchJobResults(resourceName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BatchJobResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBatchJobResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BatchJobResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BatchJobResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BatchJobResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBatchJobResults</summary>
        public async Task ListBatchJobResultsAsync()
        {
            // Snippet: ListBatchJobResultsAsync(string, string, int?, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/batchJobs/[BATCH_JOB]";
            // Make the request
            PagedAsyncEnumerable<ListBatchJobResultsResponse, BatchJobResult> response = batchJobServiceClient.ListBatchJobResultsAsync(resourceName);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BatchJobResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBatchJobResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BatchJobResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BatchJobResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BatchJobResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBatchJobResults</summary>
        public void ListBatchJobResultsResourceNames()
        {
            // Snippet: ListBatchJobResults(BatchJobName, string, int?, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            BatchJobName resourceName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]");
            // Make the request
            PagedEnumerable<ListBatchJobResultsResponse, BatchJobResult> response = batchJobServiceClient.ListBatchJobResults(resourceName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BatchJobResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBatchJobResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BatchJobResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BatchJobResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BatchJobResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBatchJobResults</summary>
        public async Task ListBatchJobResultsResourceNamesAsync()
        {
            // Snippet: ListBatchJobResultsAsync(BatchJobName, string, int?, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchJobName resourceName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]");
            // Make the request
            PagedAsyncEnumerable<ListBatchJobResultsResponse, BatchJobResult> response = batchJobServiceClient.ListBatchJobResultsAsync(resourceName);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BatchJobResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBatchJobResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BatchJobResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BatchJobResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BatchJobResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RunBatchJob</summary>
        public void RunBatchJobRequestObject()
        {
            // Snippet: RunBatchJob(RunBatchJobRequest, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            RunBatchJobRequest request = new RunBatchJobRequest
            {
                ResourceNameAsBatchJobName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]"),
            };
            // Make the request
            Operation<Empty, BatchJob.Types.BatchJobMetadata> response = batchJobServiceClient.RunBatchJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, BatchJob.Types.BatchJobMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, BatchJob.Types.BatchJobMetadata> retrievedResponse = batchJobServiceClient.PollOnceRunBatchJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunBatchJobAsync</summary>
        public async Task RunBatchJobRequestObjectAsync()
        {
            // Snippet: RunBatchJobAsync(RunBatchJobRequest, CallSettings)
            // Additional: RunBatchJobAsync(RunBatchJobRequest, CancellationToken)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunBatchJobRequest request = new RunBatchJobRequest
            {
                ResourceNameAsBatchJobName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]"),
            };
            // Make the request
            Operation<Empty, BatchJob.Types.BatchJobMetadata> response = await batchJobServiceClient.RunBatchJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, BatchJob.Types.BatchJobMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, BatchJob.Types.BatchJobMetadata> retrievedResponse = await batchJobServiceClient.PollOnceRunBatchJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunBatchJob</summary>
        public void RunBatchJob()
        {
            // Snippet: RunBatchJob(string, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/batchJobs/[BATCH_JOB]";
            // Make the request
            Operation<Empty, BatchJob.Types.BatchJobMetadata> response = batchJobServiceClient.RunBatchJob(resourceName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, BatchJob.Types.BatchJobMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, BatchJob.Types.BatchJobMetadata> retrievedResponse = batchJobServiceClient.PollOnceRunBatchJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunBatchJobAsync</summary>
        public async Task RunBatchJobAsync()
        {
            // Snippet: RunBatchJobAsync(string, CallSettings)
            // Additional: RunBatchJobAsync(string, CancellationToken)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/batchJobs/[BATCH_JOB]";
            // Make the request
            Operation<Empty, BatchJob.Types.BatchJobMetadata> response = await batchJobServiceClient.RunBatchJobAsync(resourceName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, BatchJob.Types.BatchJobMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, BatchJob.Types.BatchJobMetadata> retrievedResponse = await batchJobServiceClient.PollOnceRunBatchJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunBatchJob</summary>
        public void RunBatchJobResourceNames()
        {
            // Snippet: RunBatchJob(BatchJobName, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            BatchJobName resourceName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]");
            // Make the request
            Operation<Empty, BatchJob.Types.BatchJobMetadata> response = batchJobServiceClient.RunBatchJob(resourceName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, BatchJob.Types.BatchJobMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, BatchJob.Types.BatchJobMetadata> retrievedResponse = batchJobServiceClient.PollOnceRunBatchJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunBatchJobAsync</summary>
        public async Task RunBatchJobResourceNamesAsync()
        {
            // Snippet: RunBatchJobAsync(BatchJobName, CallSettings)
            // Additional: RunBatchJobAsync(BatchJobName, CancellationToken)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchJobName resourceName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]");
            // Make the request
            Operation<Empty, BatchJob.Types.BatchJobMetadata> response = await batchJobServiceClient.RunBatchJobAsync(resourceName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, BatchJob.Types.BatchJobMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, BatchJob.Types.BatchJobMetadata> retrievedResponse = await batchJobServiceClient.PollOnceRunBatchJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddBatchJobOperations</summary>
        public void AddBatchJobOperationsRequestObject()
        {
            // Snippet: AddBatchJobOperations(AddBatchJobOperationsRequest, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            AddBatchJobOperationsRequest request = new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]"),
                SequenceToken = "",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            // Make the request
            AddBatchJobOperationsResponse response = batchJobServiceClient.AddBatchJobOperations(request);
            // End snippet
        }

        /// <summary>Snippet for AddBatchJobOperationsAsync</summary>
        public async Task AddBatchJobOperationsRequestObjectAsync()
        {
            // Snippet: AddBatchJobOperationsAsync(AddBatchJobOperationsRequest, CallSettings)
            // Additional: AddBatchJobOperationsAsync(AddBatchJobOperationsRequest, CancellationToken)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddBatchJobOperationsRequest request = new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]"),
                SequenceToken = "",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            // Make the request
            AddBatchJobOperationsResponse response = await batchJobServiceClient.AddBatchJobOperationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddBatchJobOperations</summary>
        public void AddBatchJobOperations1()
        {
            // Snippet: AddBatchJobOperations(string, string, IEnumerable<MutateOperation>, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/batchJobs/[BATCH_JOB]";
            string sequenceToken = "";
            IEnumerable<MutateOperation> mutateOperations = new MutateOperation[]
            {
                new MutateOperation(),
            };
            // Make the request
            AddBatchJobOperationsResponse response = batchJobServiceClient.AddBatchJobOperations(resourceName, sequenceToken, mutateOperations);
            // End snippet
        }

        /// <summary>Snippet for AddBatchJobOperationsAsync</summary>
        public async Task AddBatchJobOperations1Async()
        {
            // Snippet: AddBatchJobOperationsAsync(string, string, IEnumerable<MutateOperation>, CallSettings)
            // Additional: AddBatchJobOperationsAsync(string, string, IEnumerable<MutateOperation>, CancellationToken)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/batchJobs/[BATCH_JOB]";
            string sequenceToken = "";
            IEnumerable<MutateOperation> mutateOperations = new MutateOperation[]
            {
                new MutateOperation(),
            };
            // Make the request
            AddBatchJobOperationsResponse response = await batchJobServiceClient.AddBatchJobOperationsAsync(resourceName, sequenceToken, mutateOperations);
            // End snippet
        }

        /// <summary>Snippet for AddBatchJobOperations</summary>
        public void AddBatchJobOperations1ResourceNames()
        {
            // Snippet: AddBatchJobOperations(BatchJobName, string, IEnumerable<MutateOperation>, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            BatchJobName resourceName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]");
            string sequenceToken = "";
            IEnumerable<MutateOperation> mutateOperations = new MutateOperation[]
            {
                new MutateOperation(),
            };
            // Make the request
            AddBatchJobOperationsResponse response = batchJobServiceClient.AddBatchJobOperations(resourceName, sequenceToken, mutateOperations);
            // End snippet
        }

        /// <summary>Snippet for AddBatchJobOperationsAsync</summary>
        public async Task AddBatchJobOperations1ResourceNamesAsync()
        {
            // Snippet: AddBatchJobOperationsAsync(BatchJobName, string, IEnumerable<MutateOperation>, CallSettings)
            // Additional: AddBatchJobOperationsAsync(BatchJobName, string, IEnumerable<MutateOperation>, CancellationToken)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchJobName resourceName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]");
            string sequenceToken = "";
            IEnumerable<MutateOperation> mutateOperations = new MutateOperation[]
            {
                new MutateOperation(),
            };
            // Make the request
            AddBatchJobOperationsResponse response = await batchJobServiceClient.AddBatchJobOperationsAsync(resourceName, sequenceToken, mutateOperations);
            // End snippet
        }

        /// <summary>Snippet for AddBatchJobOperations</summary>
        public void AddBatchJobOperations2()
        {
            // Snippet: AddBatchJobOperations(string, IEnumerable<MutateOperation>, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/batchJobs/[BATCH_JOB]";
            IEnumerable<MutateOperation> mutateOperations = new MutateOperation[]
            {
                new MutateOperation(),
            };
            // Make the request
            AddBatchJobOperationsResponse response = batchJobServiceClient.AddBatchJobOperations(resourceName, mutateOperations);
            // End snippet
        }

        /// <summary>Snippet for AddBatchJobOperationsAsync</summary>
        public async Task AddBatchJobOperations2Async()
        {
            // Snippet: AddBatchJobOperationsAsync(string, IEnumerable<MutateOperation>, CallSettings)
            // Additional: AddBatchJobOperationsAsync(string, IEnumerable<MutateOperation>, CancellationToken)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/batchJobs/[BATCH_JOB]";
            IEnumerable<MutateOperation> mutateOperations = new MutateOperation[]
            {
                new MutateOperation(),
            };
            // Make the request
            AddBatchJobOperationsResponse response = await batchJobServiceClient.AddBatchJobOperationsAsync(resourceName, mutateOperations);
            // End snippet
        }

        /// <summary>Snippet for AddBatchJobOperations</summary>
        public void AddBatchJobOperations2ResourceNames()
        {
            // Snippet: AddBatchJobOperations(BatchJobName, IEnumerable<MutateOperation>, CallSettings)
            // Create client
            BatchJobServiceClient batchJobServiceClient = BatchJobServiceClient.Create();
            // Initialize request argument(s)
            BatchJobName resourceName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]");
            IEnumerable<MutateOperation> mutateOperations = new MutateOperation[]
            {
                new MutateOperation(),
            };
            // Make the request
            AddBatchJobOperationsResponse response = batchJobServiceClient.AddBatchJobOperations(resourceName, mutateOperations);
            // End snippet
        }

        /// <summary>Snippet for AddBatchJobOperationsAsync</summary>
        public async Task AddBatchJobOperations2ResourceNamesAsync()
        {
            // Snippet: AddBatchJobOperationsAsync(BatchJobName, IEnumerable<MutateOperation>, CallSettings)
            // Additional: AddBatchJobOperationsAsync(BatchJobName, IEnumerable<MutateOperation>, CancellationToken)
            // Create client
            BatchJobServiceClient batchJobServiceClient = await BatchJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchJobName resourceName = BatchJobName.FromCustomerBatchJob("[CUSTOMER]", "[BATCH_JOB]");
            IEnumerable<MutateOperation> mutateOperations = new MutateOperation[]
            {
                new MutateOperation(),
            };
            // Make the request
            AddBatchJobOperationsResponse response = await batchJobServiceClient.AddBatchJobOperationsAsync(resourceName, mutateOperations);
            // End snippet
        }
    }
}
