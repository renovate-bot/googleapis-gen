// Copyright 2022 Google LLC
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

namespace Google.Cloud.Datastore.Admin.V1.Snippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using gcdav = Google.Cloud.Datastore.Admin.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedDatastoreAdminClientSnippets
    {
        /// <summary>Snippet for ExportEntities</summary>
        public void ExportEntitiesRequestObject()
        {
            // Snippet: ExportEntities(ExportEntitiesRequest, CallSettings)
            // Create client
            DatastoreAdminClient datastoreAdminClient = DatastoreAdminClient.Create();
            // Initialize request argument(s)
            ExportEntitiesRequest request = new ExportEntitiesRequest
            {
                ProjectId = "",
                Labels = { { "", "" }, },
                EntityFilter = new EntityFilter(),
                OutputUrlPrefix = "",
            };
            // Make the request
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> response = datastoreAdminClient.ExportEntities(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportEntitiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> retrievedResponse = datastoreAdminClient.PollOnceExportEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportEntitiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportEntitiesAsync</summary>
        public async Task ExportEntitiesRequestObjectAsync()
        {
            // Snippet: ExportEntitiesAsync(ExportEntitiesRequest, CallSettings)
            // Additional: ExportEntitiesAsync(ExportEntitiesRequest, CancellationToken)
            // Create client
            DatastoreAdminClient datastoreAdminClient = await DatastoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ExportEntitiesRequest request = new ExportEntitiesRequest
            {
                ProjectId = "",
                Labels = { { "", "" }, },
                EntityFilter = new EntityFilter(),
                OutputUrlPrefix = "",
            };
            // Make the request
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> response = await datastoreAdminClient.ExportEntitiesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportEntitiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> retrievedResponse = await datastoreAdminClient.PollOnceExportEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportEntitiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportEntities</summary>
        public void ExportEntities()
        {
            // Snippet: ExportEntities(string, IDictionary<string,string>, EntityFilter, string, CallSettings)
            // Create client
            DatastoreAdminClient datastoreAdminClient = DatastoreAdminClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            IDictionary<string, string> labels = new Dictionary<string, string> { { "", "" }, };
            EntityFilter entityFilter = new EntityFilter();
            string outputUrlPrefix = "";
            // Make the request
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> response = datastoreAdminClient.ExportEntities(projectId, labels, entityFilter, outputUrlPrefix);

            // Poll until the returned long-running operation is complete
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportEntitiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> retrievedResponse = datastoreAdminClient.PollOnceExportEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportEntitiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportEntitiesAsync</summary>
        public async Task ExportEntitiesAsync()
        {
            // Snippet: ExportEntitiesAsync(string, IDictionary<string,string>, EntityFilter, string, CallSettings)
            // Additional: ExportEntitiesAsync(string, IDictionary<string,string>, EntityFilter, string, CancellationToken)
            // Create client
            DatastoreAdminClient datastoreAdminClient = await DatastoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            IDictionary<string, string> labels = new Dictionary<string, string> { { "", "" }, };
            EntityFilter entityFilter = new EntityFilter();
            string outputUrlPrefix = "";
            // Make the request
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> response = await datastoreAdminClient.ExportEntitiesAsync(projectId, labels, entityFilter, outputUrlPrefix);

            // Poll until the returned long-running operation is complete
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportEntitiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> retrievedResponse = await datastoreAdminClient.PollOnceExportEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportEntitiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportEntities</summary>
        public void ImportEntitiesRequestObject()
        {
            // Snippet: ImportEntities(ImportEntitiesRequest, CallSettings)
            // Create client
            DatastoreAdminClient datastoreAdminClient = DatastoreAdminClient.Create();
            // Initialize request argument(s)
            ImportEntitiesRequest request = new ImportEntitiesRequest
            {
                ProjectId = "",
                Labels = { { "", "" }, },
                InputUrl = "",
                EntityFilter = new EntityFilter(),
            };
            // Make the request
            Operation<Empty, ImportEntitiesMetadata> response = datastoreAdminClient.ImportEntities(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportEntitiesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportEntitiesMetadata> retrievedResponse = datastoreAdminClient.PollOnceImportEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportEntitiesAsync</summary>
        public async Task ImportEntitiesRequestObjectAsync()
        {
            // Snippet: ImportEntitiesAsync(ImportEntitiesRequest, CallSettings)
            // Additional: ImportEntitiesAsync(ImportEntitiesRequest, CancellationToken)
            // Create client
            DatastoreAdminClient datastoreAdminClient = await DatastoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ImportEntitiesRequest request = new ImportEntitiesRequest
            {
                ProjectId = "",
                Labels = { { "", "" }, },
                InputUrl = "",
                EntityFilter = new EntityFilter(),
            };
            // Make the request
            Operation<Empty, ImportEntitiesMetadata> response = await datastoreAdminClient.ImportEntitiesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportEntitiesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportEntitiesMetadata> retrievedResponse = await datastoreAdminClient.PollOnceImportEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportEntities</summary>
        public void ImportEntities()
        {
            // Snippet: ImportEntities(string, IDictionary<string,string>, string, EntityFilter, CallSettings)
            // Create client
            DatastoreAdminClient datastoreAdminClient = DatastoreAdminClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            IDictionary<string, string> labels = new Dictionary<string, string> { { "", "" }, };
            string inputUrl = "";
            EntityFilter entityFilter = new EntityFilter();
            // Make the request
            Operation<Empty, ImportEntitiesMetadata> response = datastoreAdminClient.ImportEntities(projectId, labels, inputUrl, entityFilter);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportEntitiesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportEntitiesMetadata> retrievedResponse = datastoreAdminClient.PollOnceImportEntities(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportEntitiesAsync</summary>
        public async Task ImportEntitiesAsync()
        {
            // Snippet: ImportEntitiesAsync(string, IDictionary<string,string>, string, EntityFilter, CallSettings)
            // Additional: ImportEntitiesAsync(string, IDictionary<string,string>, string, EntityFilter, CancellationToken)
            // Create client
            DatastoreAdminClient datastoreAdminClient = await DatastoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            IDictionary<string, string> labels = new Dictionary<string, string> { { "", "" }, };
            string inputUrl = "";
            EntityFilter entityFilter = new EntityFilter();
            // Make the request
            Operation<Empty, ImportEntitiesMetadata> response = await datastoreAdminClient.ImportEntitiesAsync(projectId, labels, inputUrl, entityFilter);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportEntitiesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportEntitiesMetadata> retrievedResponse = await datastoreAdminClient.PollOnceImportEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndexRequestObject()
        {
            // Snippet: CreateIndex(CreateIndexRequest, CallSettings)
            // Create client
            DatastoreAdminClient datastoreAdminClient = DatastoreAdminClient.Create();
            // Initialize request argument(s)
            CreateIndexRequest request = new CreateIndexRequest
            {
                ProjectId = "",
                Index = new gcdav::Index(),
            };
            // Make the request
            Operation<gcdav::Index, IndexOperationMetadata> response = datastoreAdminClient.CreateIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdav::Index, IndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdav::Index, IndexOperationMetadata> retrievedResponse = datastoreAdminClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexRequestObjectAsync()
        {
            // Snippet: CreateIndexAsync(CreateIndexRequest, CallSettings)
            // Additional: CreateIndexAsync(CreateIndexRequest, CancellationToken)
            // Create client
            DatastoreAdminClient datastoreAdminClient = await DatastoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateIndexRequest request = new CreateIndexRequest
            {
                ProjectId = "",
                Index = new gcdav::Index(),
            };
            // Make the request
            Operation<gcdav::Index, IndexOperationMetadata> response = await datastoreAdminClient.CreateIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdav::Index, IndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdav::Index, IndexOperationMetadata> retrievedResponse = await datastoreAdminClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndexRequestObject()
        {
            // Snippet: DeleteIndex(DeleteIndexRequest, CallSettings)
            // Create client
            DatastoreAdminClient datastoreAdminClient = DatastoreAdminClient.Create();
            // Initialize request argument(s)
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                ProjectId = "",
                IndexId = "",
            };
            // Make the request
            Operation<gcdav::Index, IndexOperationMetadata> response = datastoreAdminClient.DeleteIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdav::Index, IndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdav::Index, IndexOperationMetadata> retrievedResponse = datastoreAdminClient.PollOnceDeleteIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexAsync</summary>
        public async Task DeleteIndexRequestObjectAsync()
        {
            // Snippet: DeleteIndexAsync(DeleteIndexRequest, CallSettings)
            // Additional: DeleteIndexAsync(DeleteIndexRequest, CancellationToken)
            // Create client
            DatastoreAdminClient datastoreAdminClient = await DatastoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                ProjectId = "",
                IndexId = "",
            };
            // Make the request
            Operation<gcdav::Index, IndexOperationMetadata> response = await datastoreAdminClient.DeleteIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdav::Index, IndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdav::Index, IndexOperationMetadata> retrievedResponse = await datastoreAdminClient.PollOnceDeleteIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndexRequestObject()
        {
            // Snippet: GetIndex(GetIndexRequest, CallSettings)
            // Create client
            DatastoreAdminClient datastoreAdminClient = DatastoreAdminClient.Create();
            // Initialize request argument(s)
            GetIndexRequest request = new GetIndexRequest
            {
                ProjectId = "",
                IndexId = "",
            };
            // Make the request
            gcdav::Index response = datastoreAdminClient.GetIndex(request);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexRequestObjectAsync()
        {
            // Snippet: GetIndexAsync(GetIndexRequest, CallSettings)
            // Additional: GetIndexAsync(GetIndexRequest, CancellationToken)
            // Create client
            DatastoreAdminClient datastoreAdminClient = await DatastoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetIndexRequest request = new GetIndexRequest
            {
                ProjectId = "",
                IndexId = "",
            };
            // Make the request
            gcdav::Index response = await datastoreAdminClient.GetIndexAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public void ListIndexesRequestObject()
        {
            // Snippet: ListIndexes(ListIndexesRequest, CallSettings)
            // Create client
            DatastoreAdminClient datastoreAdminClient = DatastoreAdminClient.Create();
            // Initialize request argument(s)
            ListIndexesRequest request = new ListIndexesRequest
            {
                ProjectId = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListIndexesResponse, gcdav::Index> response = datastoreAdminClient.ListIndexes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdav::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdav::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdav::Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdav::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexesAsync</summary>
        public async Task ListIndexesRequestObjectAsync()
        {
            // Snippet: ListIndexesAsync(ListIndexesRequest, CallSettings)
            // Create client
            DatastoreAdminClient datastoreAdminClient = await DatastoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListIndexesRequest request = new ListIndexesRequest
            {
                ProjectId = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListIndexesResponse, gcdav::Index> response = datastoreAdminClient.ListIndexesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdav::Index item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIndexesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdav::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdav::Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdav::Index item in singlePage)
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
