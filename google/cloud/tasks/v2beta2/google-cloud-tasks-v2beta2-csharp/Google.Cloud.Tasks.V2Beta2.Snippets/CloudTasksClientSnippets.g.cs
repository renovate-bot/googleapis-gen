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

namespace Google.Cloud.Tasks.V2Beta2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using gctv = Google.Cloud.Tasks.V2Beta2;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCloudTasksClientSnippets
    {
        /// <summary>Snippet for ListQueues</summary>
        public void ListQueuesRequestObject()
        {
            // Snippet: ListQueues(ListQueuesRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            ListQueuesRequest request = new ListQueuesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListQueuesResponse, Queue> response = cloudTasksClient.ListQueues(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Queue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQueuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Queue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueues</summary>
        public async Task ListQueuesRequestObjectAsync()
        {
            // Snippet: ListQueuesAsync(ListQueuesRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            ListQueuesRequest request = new ListQueuesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListQueuesResponse, Queue> response = cloudTasksClient.ListQueuesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Queue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQueuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Queue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueues</summary>
        public void ListQueues()
        {
            // Snippet: ListQueues(string, string, int?, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListQueuesResponse, Queue> response = cloudTasksClient.ListQueues(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Queue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQueuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Queue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueues</summary>
        public async Task ListQueuesAsync()
        {
            // Snippet: ListQueuesAsync(string, string, int?, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListQueuesResponse, Queue> response = cloudTasksClient.ListQueuesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Queue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQueuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Queue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueues</summary>
        public void ListQueuesResourceNames()
        {
            // Snippet: ListQueues(LocationName, string, int?, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListQueuesResponse, Queue> response = cloudTasksClient.ListQueues(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Queue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQueuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Queue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQueues</summary>
        public async Task ListQueuesResourceNamesAsync()
        {
            // Snippet: ListQueuesAsync(LocationName, string, int?, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListQueuesResponse, Queue> response = cloudTasksClient.ListQueuesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Queue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQueuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Queue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Queue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Queue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetQueue</summary>
        public void GetQueueRequestObject()
        {
            // Snippet: GetQueue(GetQueueRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            Queue response = cloudTasksClient.GetQueue(request);
            // End snippet
        }

        /// <summary>Snippet for GetQueueAsync</summary>
        public async Task GetQueueRequestObjectAsync()
        {
            // Snippet: GetQueueAsync(GetQueueRequest, CallSettings)
            // Additional: GetQueueAsync(GetQueueRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            GetQueueRequest request = new GetQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            Queue response = await cloudTasksClient.GetQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetQueue</summary>
        public void GetQueue()
        {
            // Snippet: GetQueue(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = cloudTasksClient.GetQueue(name);
            // End snippet
        }

        /// <summary>Snippet for GetQueueAsync</summary>
        public async Task GetQueueAsync()
        {
            // Snippet: GetQueueAsync(string, CallSettings)
            // Additional: GetQueueAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = await cloudTasksClient.GetQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetQueue</summary>
        public void GetQueueResourceNames()
        {
            // Snippet: GetQueue(QueueName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName name = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = cloudTasksClient.GetQueue(name);
            // End snippet
        }

        /// <summary>Snippet for GetQueueAsync</summary>
        public async Task GetQueueResourceNamesAsync()
        {
            // Snippet: GetQueueAsync(QueueName, CallSettings)
            // Additional: GetQueueAsync(QueueName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName name = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = await cloudTasksClient.GetQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateQueue</summary>
        public void CreateQueueRequestObject()
        {
            // Snippet: CreateQueue(CreateQueueRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new Queue(),
            };
            // Make the request
            Queue response = cloudTasksClient.CreateQueue(request);
            // End snippet
        }

        /// <summary>Snippet for CreateQueueAsync</summary>
        public async Task CreateQueueRequestObjectAsync()
        {
            // Snippet: CreateQueueAsync(CreateQueueRequest, CallSettings)
            // Additional: CreateQueueAsync(CreateQueueRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            CreateQueueRequest request = new CreateQueueRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queue = new Queue(),
            };
            // Make the request
            Queue response = await cloudTasksClient.CreateQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateQueue</summary>
        public void CreateQueue()
        {
            // Snippet: CreateQueue(string, Queue, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Queue queue = new Queue();
            // Make the request
            Queue response = cloudTasksClient.CreateQueue(parent, queue);
            // End snippet
        }

        /// <summary>Snippet for CreateQueueAsync</summary>
        public async Task CreateQueueAsync()
        {
            // Snippet: CreateQueueAsync(string, Queue, CallSettings)
            // Additional: CreateQueueAsync(string, Queue, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Queue queue = new Queue();
            // Make the request
            Queue response = await cloudTasksClient.CreateQueueAsync(parent, queue);
            // End snippet
        }

        /// <summary>Snippet for CreateQueue</summary>
        public void CreateQueueResourceNames()
        {
            // Snippet: CreateQueue(LocationName, Queue, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Queue queue = new Queue();
            // Make the request
            Queue response = cloudTasksClient.CreateQueue(parent, queue);
            // End snippet
        }

        /// <summary>Snippet for CreateQueueAsync</summary>
        public async Task CreateQueueResourceNamesAsync()
        {
            // Snippet: CreateQueueAsync(LocationName, Queue, CallSettings)
            // Additional: CreateQueueAsync(LocationName, Queue, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Queue queue = new Queue();
            // Make the request
            Queue response = await cloudTasksClient.CreateQueueAsync(parent, queue);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueue</summary>
        public void UpdateQueueRequestObject()
        {
            // Snippet: UpdateQueue(UpdateQueueRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new Queue(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Queue response = cloudTasksClient.UpdateQueue(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueueAsync</summary>
        public async Task UpdateQueueRequestObjectAsync()
        {
            // Snippet: UpdateQueueAsync(UpdateQueueRequest, CallSettings)
            // Additional: UpdateQueueAsync(UpdateQueueRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            UpdateQueueRequest request = new UpdateQueueRequest
            {
                Queue = new Queue(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Queue response = await cloudTasksClient.UpdateQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueue</summary>
        public void UpdateQueue()
        {
            // Snippet: UpdateQueue(Queue, FieldMask, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            Queue queue = new Queue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Queue response = cloudTasksClient.UpdateQueue(queue, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateQueueAsync</summary>
        public async Task UpdateQueueAsync()
        {
            // Snippet: UpdateQueueAsync(Queue, FieldMask, CallSettings)
            // Additional: UpdateQueueAsync(Queue, FieldMask, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            Queue queue = new Queue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Queue response = await cloudTasksClient.UpdateQueueAsync(queue, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueue</summary>
        public void DeleteQueueRequestObject()
        {
            // Snippet: DeleteQueue(DeleteQueueRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            cloudTasksClient.DeleteQueue(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueueAsync</summary>
        public async Task DeleteQueueRequestObjectAsync()
        {
            // Snippet: DeleteQueueAsync(DeleteQueueRequest, CallSettings)
            // Additional: DeleteQueueAsync(DeleteQueueRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteQueueRequest request = new DeleteQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            await cloudTasksClient.DeleteQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueue</summary>
        public void DeleteQueue()
        {
            // Snippet: DeleteQueue(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            cloudTasksClient.DeleteQueue(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueueAsync</summary>
        public async Task DeleteQueueAsync()
        {
            // Snippet: DeleteQueueAsync(string, CallSettings)
            // Additional: DeleteQueueAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            await cloudTasksClient.DeleteQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueue</summary>
        public void DeleteQueueResourceNames()
        {
            // Snippet: DeleteQueue(QueueName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName name = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            cloudTasksClient.DeleteQueue(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteQueueAsync</summary>
        public async Task DeleteQueueResourceNamesAsync()
        {
            // Snippet: DeleteQueueAsync(QueueName, CallSettings)
            // Additional: DeleteQueueAsync(QueueName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName name = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            await cloudTasksClient.DeleteQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueue</summary>
        public void PurgeQueueRequestObject()
        {
            // Snippet: PurgeQueue(PurgeQueueRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            Queue response = cloudTasksClient.PurgeQueue(request);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueueAsync</summary>
        public async Task PurgeQueueRequestObjectAsync()
        {
            // Snippet: PurgeQueueAsync(PurgeQueueRequest, CallSettings)
            // Additional: PurgeQueueAsync(PurgeQueueRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            PurgeQueueRequest request = new PurgeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            Queue response = await cloudTasksClient.PurgeQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueue</summary>
        public void PurgeQueue()
        {
            // Snippet: PurgeQueue(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = cloudTasksClient.PurgeQueue(name);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueueAsync</summary>
        public async Task PurgeQueueAsync()
        {
            // Snippet: PurgeQueueAsync(string, CallSettings)
            // Additional: PurgeQueueAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = await cloudTasksClient.PurgeQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueue</summary>
        public void PurgeQueueResourceNames()
        {
            // Snippet: PurgeQueue(QueueName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName name = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = cloudTasksClient.PurgeQueue(name);
            // End snippet
        }

        /// <summary>Snippet for PurgeQueueAsync</summary>
        public async Task PurgeQueueResourceNamesAsync()
        {
            // Snippet: PurgeQueueAsync(QueueName, CallSettings)
            // Additional: PurgeQueueAsync(QueueName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName name = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = await cloudTasksClient.PurgeQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseQueue</summary>
        public void PauseQueueRequestObject()
        {
            // Snippet: PauseQueue(PauseQueueRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            Queue response = cloudTasksClient.PauseQueue(request);
            // End snippet
        }

        /// <summary>Snippet for PauseQueueAsync</summary>
        public async Task PauseQueueRequestObjectAsync()
        {
            // Snippet: PauseQueueAsync(PauseQueueRequest, CallSettings)
            // Additional: PauseQueueAsync(PauseQueueRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            PauseQueueRequest request = new PauseQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            Queue response = await cloudTasksClient.PauseQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PauseQueue</summary>
        public void PauseQueue()
        {
            // Snippet: PauseQueue(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = cloudTasksClient.PauseQueue(name);
            // End snippet
        }

        /// <summary>Snippet for PauseQueueAsync</summary>
        public async Task PauseQueueAsync()
        {
            // Snippet: PauseQueueAsync(string, CallSettings)
            // Additional: PauseQueueAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = await cloudTasksClient.PauseQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseQueue</summary>
        public void PauseQueueResourceNames()
        {
            // Snippet: PauseQueue(QueueName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName name = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = cloudTasksClient.PauseQueue(name);
            // End snippet
        }

        /// <summary>Snippet for PauseQueueAsync</summary>
        public async Task PauseQueueResourceNamesAsync()
        {
            // Snippet: PauseQueueAsync(QueueName, CallSettings)
            // Additional: PauseQueueAsync(QueueName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName name = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = await cloudTasksClient.PauseQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueue</summary>
        public void ResumeQueueRequestObject()
        {
            // Snippet: ResumeQueue(ResumeQueueRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            Queue response = cloudTasksClient.ResumeQueue(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueueAsync</summary>
        public async Task ResumeQueueRequestObjectAsync()
        {
            // Snippet: ResumeQueueAsync(ResumeQueueRequest, CallSettings)
            // Additional: ResumeQueueAsync(ResumeQueueRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            ResumeQueueRequest request = new ResumeQueueRequest
            {
                QueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
            };
            // Make the request
            Queue response = await cloudTasksClient.ResumeQueueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueue</summary>
        public void ResumeQueue()
        {
            // Snippet: ResumeQueue(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = cloudTasksClient.ResumeQueue(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueueAsync</summary>
        public async Task ResumeQueueAsync()
        {
            // Snippet: ResumeQueueAsync(string, CallSettings)
            // Additional: ResumeQueueAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            Queue response = await cloudTasksClient.ResumeQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueue</summary>
        public void ResumeQueueResourceNames()
        {
            // Snippet: ResumeQueue(QueueName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName name = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = cloudTasksClient.ResumeQueue(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeQueueAsync</summary>
        public async Task ResumeQueueResourceNamesAsync()
        {
            // Snippet: ResumeQueueAsync(QueueName, CallSettings)
            // Additional: ResumeQueueAsync(QueueName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName name = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            Queue response = await cloudTasksClient.ResumeQueueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = cloudTasksClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await cloudTasksClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = cloudTasksClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await cloudTasksClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = cloudTasksClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await cloudTasksClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = cloudTasksClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await cloudTasksClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = cloudTasksClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await cloudTasksClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = cloudTasksClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await cloudTasksClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = cloudTasksClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await cloudTasksClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = cloudTasksClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await cloudTasksClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = cloudTasksClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await cloudTasksClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasksRequestObject()
        {
            // Snippet: ListTasks(ListTasksRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gctv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public async Task ListTasksRequestObjectAsync()
        {
            // Snippet: ListTasksAsync(ListTasksRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gctv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasks()
        {
            // Snippet: ListTasks(string, string, int?, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            PagedEnumerable<ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gctv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public async Task ListTasksAsync()
        {
            // Snippet: ListTasksAsync(string, string, int?, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            // Make the request
            PagedAsyncEnumerable<ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gctv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasksResourceNames()
        {
            // Snippet: ListTasks(QueueName, string, int?, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName parent = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            PagedEnumerable<ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gctv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public async Task ListTasksResourceNamesAsync()
        {
            // Snippet: ListTasksAsync(QueueName, string, int?, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName parent = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            // Make the request
            PagedAsyncEnumerable<ListTasksResponse, gctv::Task> response = cloudTasksClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gctv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gctv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gctv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gctv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTaskRequestObject()
        {
            // Snippet: GetTask(GetTaskRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = cloudTasksClient.GetTask(request);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskRequestObjectAsync()
        {
            // Snippet: GetTaskAsync(GetTaskRequest, CallSettings)
            // Additional: GetTaskAsync(GetTaskRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = await cloudTasksClient.GetTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTask()
        {
            // Snippet: GetTask(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            // Make the request
            gctv::Task response = cloudTasksClient.GetTask(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskAsync()
        {
            // Snippet: GetTaskAsync(string, CallSettings)
            // Additional: GetTaskAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            // Make the request
            gctv::Task response = await cloudTasksClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTaskResourceNames()
        {
            // Snippet: GetTask(TaskName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            gctv::Task response = cloudTasksClient.GetTask(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskResourceNamesAsync()
        {
            // Snippet: GetTaskAsync(TaskName, CallSettings)
            // Additional: GetTaskAsync(TaskName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            gctv::Task response = await cloudTasksClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTask</summary>
        public void CreateTaskRequestObject()
        {
            // Snippet: CreateTask(CreateTaskRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new gctv::Task(),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = cloudTasksClient.CreateTask(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTaskAsync</summary>
        public async Task CreateTaskRequestObjectAsync()
        {
            // Snippet: CreateTaskAsync(CreateTaskRequest, CallSettings)
            // Additional: CreateTaskAsync(CreateTaskRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                Task = new gctv::Task(),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = await cloudTasksClient.CreateTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTask</summary>
        public void CreateTask()
        {
            // Snippet: CreateTask(string, Task, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            gctv::Task task = new gctv::Task();
            // Make the request
            gctv::Task response = cloudTasksClient.CreateTask(parent, task);
            // End snippet
        }

        /// <summary>Snippet for CreateTaskAsync</summary>
        public async Task CreateTaskAsync()
        {
            // Snippet: CreateTaskAsync(string, Task, CallSettings)
            // Additional: CreateTaskAsync(string, Task, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            gctv::Task task = new gctv::Task();
            // Make the request
            gctv::Task response = await cloudTasksClient.CreateTaskAsync(parent, task);
            // End snippet
        }

        /// <summary>Snippet for CreateTask</summary>
        public void CreateTaskResourceNames()
        {
            // Snippet: CreateTask(QueueName, Task, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName parent = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            gctv::Task task = new gctv::Task();
            // Make the request
            gctv::Task response = cloudTasksClient.CreateTask(parent, task);
            // End snippet
        }

        /// <summary>Snippet for CreateTaskAsync</summary>
        public async Task CreateTaskResourceNamesAsync()
        {
            // Snippet: CreateTaskAsync(QueueName, Task, CallSettings)
            // Additional: CreateTaskAsync(QueueName, Task, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName parent = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            gctv::Task task = new gctv::Task();
            // Make the request
            gctv::Task response = await cloudTasksClient.CreateTaskAsync(parent, task);
            // End snippet
        }

        /// <summary>Snippet for DeleteTask</summary>
        public void DeleteTaskRequestObject()
        {
            // Snippet: DeleteTask(DeleteTaskRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            // Make the request
            cloudTasksClient.DeleteTask(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaskAsync</summary>
        public async Task DeleteTaskRequestObjectAsync()
        {
            // Snippet: DeleteTaskAsync(DeleteTaskRequest, CallSettings)
            // Additional: DeleteTaskAsync(DeleteTaskRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
            };
            // Make the request
            await cloudTasksClient.DeleteTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTask</summary>
        public void DeleteTask()
        {
            // Snippet: DeleteTask(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            // Make the request
            cloudTasksClient.DeleteTask(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaskAsync</summary>
        public async Task DeleteTaskAsync()
        {
            // Snippet: DeleteTaskAsync(string, CallSettings)
            // Additional: DeleteTaskAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            // Make the request
            await cloudTasksClient.DeleteTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTask</summary>
        public void DeleteTaskResourceNames()
        {
            // Snippet: DeleteTask(TaskName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            cloudTasksClient.DeleteTask(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaskAsync</summary>
        public async Task DeleteTaskResourceNamesAsync()
        {
            // Snippet: DeleteTaskAsync(TaskName, CallSettings)
            // Additional: DeleteTaskAsync(TaskName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            await cloudTasksClient.DeleteTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LeaseTasks</summary>
        public void LeaseTasksRequestObject()
        {
            // Snippet: LeaseTasks(LeaseTasksRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            LeaseTasksRequest request = new LeaseTasksRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                MaxTasks = 0,
                LeaseDuration = new Duration(),
                ResponseView = gctv::Task.Types.View.Unspecified,
                Filter = "",
            };
            // Make the request
            LeaseTasksResponse response = cloudTasksClient.LeaseTasks(request);
            // End snippet
        }

        /// <summary>Snippet for LeaseTasksAsync</summary>
        public async Task LeaseTasksRequestObjectAsync()
        {
            // Snippet: LeaseTasksAsync(LeaseTasksRequest, CallSettings)
            // Additional: LeaseTasksAsync(LeaseTasksRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            LeaseTasksRequest request = new LeaseTasksRequest
            {
                ParentAsQueueName = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]"),
                MaxTasks = 0,
                LeaseDuration = new Duration(),
                ResponseView = gctv::Task.Types.View.Unspecified,
                Filter = "",
            };
            // Make the request
            LeaseTasksResponse response = await cloudTasksClient.LeaseTasksAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LeaseTasks</summary>
        public void LeaseTasks()
        {
            // Snippet: LeaseTasks(string, Duration, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            Duration leaseDuration = new Duration();
            // Make the request
            LeaseTasksResponse response = cloudTasksClient.LeaseTasks(parent, leaseDuration);
            // End snippet
        }

        /// <summary>Snippet for LeaseTasksAsync</summary>
        public async Task LeaseTasksAsync()
        {
            // Snippet: LeaseTasksAsync(string, Duration, CallSettings)
            // Additional: LeaseTasksAsync(string, Duration, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]";
            Duration leaseDuration = new Duration();
            // Make the request
            LeaseTasksResponse response = await cloudTasksClient.LeaseTasksAsync(parent, leaseDuration);
            // End snippet
        }

        /// <summary>Snippet for LeaseTasks</summary>
        public void LeaseTasksResourceNames()
        {
            // Snippet: LeaseTasks(QueueName, Duration, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            QueueName parent = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            Duration leaseDuration = new Duration();
            // Make the request
            LeaseTasksResponse response = cloudTasksClient.LeaseTasks(parent, leaseDuration);
            // End snippet
        }

        /// <summary>Snippet for LeaseTasksAsync</summary>
        public async Task LeaseTasksResourceNamesAsync()
        {
            // Snippet: LeaseTasksAsync(QueueName, Duration, CallSettings)
            // Additional: LeaseTasksAsync(QueueName, Duration, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            QueueName parent = QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            Duration leaseDuration = new Duration();
            // Make the request
            LeaseTasksResponse response = await cloudTasksClient.LeaseTasksAsync(parent, leaseDuration);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeTask</summary>
        public void AcknowledgeTaskRequestObject()
        {
            // Snippet: AcknowledgeTask(AcknowledgeTaskRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            AcknowledgeTaskRequest request = new AcknowledgeTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ScheduleTime = new Timestamp(),
            };
            // Make the request
            cloudTasksClient.AcknowledgeTask(request);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeTaskAsync</summary>
        public async Task AcknowledgeTaskRequestObjectAsync()
        {
            // Snippet: AcknowledgeTaskAsync(AcknowledgeTaskRequest, CallSettings)
            // Additional: AcknowledgeTaskAsync(AcknowledgeTaskRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            AcknowledgeTaskRequest request = new AcknowledgeTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ScheduleTime = new Timestamp(),
            };
            // Make the request
            await cloudTasksClient.AcknowledgeTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeTask</summary>
        public void AcknowledgeTask()
        {
            // Snippet: AcknowledgeTask(string, Timestamp, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            cloudTasksClient.AcknowledgeTask(name, scheduleTime);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeTaskAsync</summary>
        public async Task AcknowledgeTaskAsync()
        {
            // Snippet: AcknowledgeTaskAsync(string, Timestamp, CallSettings)
            // Additional: AcknowledgeTaskAsync(string, Timestamp, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            await cloudTasksClient.AcknowledgeTaskAsync(name, scheduleTime);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeTask</summary>
        public void AcknowledgeTaskResourceNames()
        {
            // Snippet: AcknowledgeTask(TaskName, Timestamp, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            cloudTasksClient.AcknowledgeTask(name, scheduleTime);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeTaskAsync</summary>
        public async Task AcknowledgeTaskResourceNamesAsync()
        {
            // Snippet: AcknowledgeTaskAsync(TaskName, Timestamp, CallSettings)
            // Additional: AcknowledgeTaskAsync(TaskName, Timestamp, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            await cloudTasksClient.AcknowledgeTaskAsync(name, scheduleTime);
            // End snippet
        }

        /// <summary>Snippet for RenewLease</summary>
        public void RenewLeaseRequestObject()
        {
            // Snippet: RenewLease(RenewLeaseRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            RenewLeaseRequest request = new RenewLeaseRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ScheduleTime = new Timestamp(),
                LeaseDuration = new Duration(),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = cloudTasksClient.RenewLease(request);
            // End snippet
        }

        /// <summary>Snippet for RenewLeaseAsync</summary>
        public async Task RenewLeaseRequestObjectAsync()
        {
            // Snippet: RenewLeaseAsync(RenewLeaseRequest, CallSettings)
            // Additional: RenewLeaseAsync(RenewLeaseRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            RenewLeaseRequest request = new RenewLeaseRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ScheduleTime = new Timestamp(),
                LeaseDuration = new Duration(),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = await cloudTasksClient.RenewLeaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RenewLease</summary>
        public void RenewLease()
        {
            // Snippet: RenewLease(string, Timestamp, Duration, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            Timestamp scheduleTime = new Timestamp();
            Duration leaseDuration = new Duration();
            // Make the request
            gctv::Task response = cloudTasksClient.RenewLease(name, scheduleTime, leaseDuration);
            // End snippet
        }

        /// <summary>Snippet for RenewLeaseAsync</summary>
        public async Task RenewLeaseAsync()
        {
            // Snippet: RenewLeaseAsync(string, Timestamp, Duration, CallSettings)
            // Additional: RenewLeaseAsync(string, Timestamp, Duration, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            Timestamp scheduleTime = new Timestamp();
            Duration leaseDuration = new Duration();
            // Make the request
            gctv::Task response = await cloudTasksClient.RenewLeaseAsync(name, scheduleTime, leaseDuration);
            // End snippet
        }

        /// <summary>Snippet for RenewLease</summary>
        public void RenewLeaseResourceNames()
        {
            // Snippet: RenewLease(TaskName, Timestamp, Duration, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            Timestamp scheduleTime = new Timestamp();
            Duration leaseDuration = new Duration();
            // Make the request
            gctv::Task response = cloudTasksClient.RenewLease(name, scheduleTime, leaseDuration);
            // End snippet
        }

        /// <summary>Snippet for RenewLeaseAsync</summary>
        public async Task RenewLeaseResourceNamesAsync()
        {
            // Snippet: RenewLeaseAsync(TaskName, Timestamp, Duration, CallSettings)
            // Additional: RenewLeaseAsync(TaskName, Timestamp, Duration, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            Timestamp scheduleTime = new Timestamp();
            Duration leaseDuration = new Duration();
            // Make the request
            gctv::Task response = await cloudTasksClient.RenewLeaseAsync(name, scheduleTime, leaseDuration);
            // End snippet
        }

        /// <summary>Snippet for CancelLease</summary>
        public void CancelLeaseRequestObject()
        {
            // Snippet: CancelLease(CancelLeaseRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            CancelLeaseRequest request = new CancelLeaseRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ScheduleTime = new Timestamp(),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = cloudTasksClient.CancelLease(request);
            // End snippet
        }

        /// <summary>Snippet for CancelLeaseAsync</summary>
        public async Task CancelLeaseRequestObjectAsync()
        {
            // Snippet: CancelLeaseAsync(CancelLeaseRequest, CallSettings)
            // Additional: CancelLeaseAsync(CancelLeaseRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            CancelLeaseRequest request = new CancelLeaseRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ScheduleTime = new Timestamp(),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = await cloudTasksClient.CancelLeaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelLease</summary>
        public void CancelLease()
        {
            // Snippet: CancelLease(string, Timestamp, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            gctv::Task response = cloudTasksClient.CancelLease(name, scheduleTime);
            // End snippet
        }

        /// <summary>Snippet for CancelLeaseAsync</summary>
        public async Task CancelLeaseAsync()
        {
            // Snippet: CancelLeaseAsync(string, Timestamp, CallSettings)
            // Additional: CancelLeaseAsync(string, Timestamp, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            gctv::Task response = await cloudTasksClient.CancelLeaseAsync(name, scheduleTime);
            // End snippet
        }

        /// <summary>Snippet for CancelLease</summary>
        public void CancelLeaseResourceNames()
        {
            // Snippet: CancelLease(TaskName, Timestamp, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            gctv::Task response = cloudTasksClient.CancelLease(name, scheduleTime);
            // End snippet
        }

        /// <summary>Snippet for CancelLeaseAsync</summary>
        public async Task CancelLeaseResourceNamesAsync()
        {
            // Snippet: CancelLeaseAsync(TaskName, Timestamp, CallSettings)
            // Additional: CancelLeaseAsync(TaskName, Timestamp, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            gctv::Task response = await cloudTasksClient.CancelLeaseAsync(name, scheduleTime);
            // End snippet
        }

        /// <summary>Snippet for RunTask</summary>
        public void RunTaskRequestObject()
        {
            // Snippet: RunTask(RunTaskRequest, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = cloudTasksClient.RunTask(request);
            // End snippet
        }

        /// <summary>Snippet for RunTaskAsync</summary>
        public async Task RunTaskRequestObjectAsync()
        {
            // Snippet: RunTaskAsync(RunTaskRequest, CallSettings)
            // Additional: RunTaskAsync(RunTaskRequest, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            RunTaskRequest request = new RunTaskRequest
            {
                TaskName = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]"),
                ResponseView = gctv::Task.Types.View.Unspecified,
            };
            // Make the request
            gctv::Task response = await cloudTasksClient.RunTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RunTask</summary>
        public void RunTask()
        {
            // Snippet: RunTask(string, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            // Make the request
            gctv::Task response = cloudTasksClient.RunTask(name);
            // End snippet
        }

        /// <summary>Snippet for RunTaskAsync</summary>
        public async Task RunTaskAsync()
        {
            // Snippet: RunTaskAsync(string, CallSettings)
            // Additional: RunTaskAsync(string, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/queues/[QUEUE]/tasks/[TASK]";
            // Make the request
            gctv::Task response = await cloudTasksClient.RunTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RunTask</summary>
        public void RunTaskResourceNames()
        {
            // Snippet: RunTask(TaskName, CallSettings)
            // Create client
            CloudTasksClient cloudTasksClient = CloudTasksClient.Create();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            gctv::Task response = cloudTasksClient.RunTask(name);
            // End snippet
        }

        /// <summary>Snippet for RunTaskAsync</summary>
        public async Task RunTaskResourceNamesAsync()
        {
            // Snippet: RunTaskAsync(TaskName, CallSettings)
            // Additional: RunTaskAsync(TaskName, CancellationToken)
            // Create client
            CloudTasksClient cloudTasksClient = await CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationQueueTask("[PROJECT]", "[LOCATION]", "[QUEUE]", "[TASK]");
            // Make the request
            gctv::Task response = await cloudTasksClient.RunTaskAsync(name);
            // End snippet
        }
    }
}
