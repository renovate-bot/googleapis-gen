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

namespace Google.Cloud.PubSubLite.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAdminServiceClientSnippets
    {
        /// <summary>Snippet for CreateTopic</summary>
        public void CreateTopicRequestObject()
        {
            // Snippet: CreateTopic(CreateTopicRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            CreateTopicRequest request = new CreateTopicRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Topic = new Topic(),
                TopicId = "",
            };
            // Make the request
            Topic response = adminServiceClient.CreateTopic(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTopicAsync</summary>
        public async Task CreateTopicRequestObjectAsync()
        {
            // Snippet: CreateTopicAsync(CreateTopicRequest, CallSettings)
            // Additional: CreateTopicAsync(CreateTopicRequest, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTopicRequest request = new CreateTopicRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Topic = new Topic(),
                TopicId = "",
            };
            // Make the request
            Topic response = await adminServiceClient.CreateTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTopic</summary>
        public void CreateTopic()
        {
            // Snippet: CreateTopic(string, Topic, string, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Topic topic = new Topic();
            string topicId = "";
            // Make the request
            Topic response = adminServiceClient.CreateTopic(parent, topic, topicId);
            // End snippet
        }

        /// <summary>Snippet for CreateTopicAsync</summary>
        public async Task CreateTopicAsync()
        {
            // Snippet: CreateTopicAsync(string, Topic, string, CallSettings)
            // Additional: CreateTopicAsync(string, Topic, string, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Topic topic = new Topic();
            string topicId = "";
            // Make the request
            Topic response = await adminServiceClient.CreateTopicAsync(parent, topic, topicId);
            // End snippet
        }

        /// <summary>Snippet for CreateTopic</summary>
        public void CreateTopicResourceNames()
        {
            // Snippet: CreateTopic(LocationName, Topic, string, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Topic topic = new Topic();
            string topicId = "";
            // Make the request
            Topic response = adminServiceClient.CreateTopic(parent, topic, topicId);
            // End snippet
        }

        /// <summary>Snippet for CreateTopicAsync</summary>
        public async Task CreateTopicResourceNamesAsync()
        {
            // Snippet: CreateTopicAsync(LocationName, Topic, string, CallSettings)
            // Additional: CreateTopicAsync(LocationName, Topic, string, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Topic topic = new Topic();
            string topicId = "";
            // Make the request
            Topic response = await adminServiceClient.CreateTopicAsync(parent, topic, topicId);
            // End snippet
        }

        /// <summary>Snippet for GetTopic</summary>
        public void GetTopicRequestObject()
        {
            // Snippet: GetTopic(GetTopicRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            GetTopicRequest request = new GetTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            // Make the request
            Topic response = adminServiceClient.GetTopic(request);
            // End snippet
        }

        /// <summary>Snippet for GetTopicAsync</summary>
        public async Task GetTopicRequestObjectAsync()
        {
            // Snippet: GetTopicAsync(GetTopicRequest, CallSettings)
            // Additional: GetTopicAsync(GetTopicRequest, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTopicRequest request = new GetTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            // Make the request
            Topic response = await adminServiceClient.GetTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTopic</summary>
        public void GetTopic()
        {
            // Snippet: GetTopic(string, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/topics/[TOPIC]";
            // Make the request
            Topic response = adminServiceClient.GetTopic(name);
            // End snippet
        }

        /// <summary>Snippet for GetTopicAsync</summary>
        public async Task GetTopicAsync()
        {
            // Snippet: GetTopicAsync(string, CallSettings)
            // Additional: GetTopicAsync(string, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/topics/[TOPIC]";
            // Make the request
            Topic response = await adminServiceClient.GetTopicAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTopic</summary>
        public void GetTopicResourceNames()
        {
            // Snippet: GetTopic(TopicName, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            TopicName name = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]");
            // Make the request
            Topic response = adminServiceClient.GetTopic(name);
            // End snippet
        }

        /// <summary>Snippet for GetTopicAsync</summary>
        public async Task GetTopicResourceNamesAsync()
        {
            // Snippet: GetTopicAsync(TopicName, CallSettings)
            // Additional: GetTopicAsync(TopicName, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            TopicName name = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]");
            // Make the request
            Topic response = await adminServiceClient.GetTopicAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTopicPartitions</summary>
        public void GetTopicPartitionsRequestObject()
        {
            // Snippet: GetTopicPartitions(GetTopicPartitionsRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            GetTopicPartitionsRequest request = new GetTopicPartitionsRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            // Make the request
            TopicPartitions response = adminServiceClient.GetTopicPartitions(request);
            // End snippet
        }

        /// <summary>Snippet for GetTopicPartitionsAsync</summary>
        public async Task GetTopicPartitionsRequestObjectAsync()
        {
            // Snippet: GetTopicPartitionsAsync(GetTopicPartitionsRequest, CallSettings)
            // Additional: GetTopicPartitionsAsync(GetTopicPartitionsRequest, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTopicPartitionsRequest request = new GetTopicPartitionsRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            // Make the request
            TopicPartitions response = await adminServiceClient.GetTopicPartitionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTopicPartitions</summary>
        public void GetTopicPartitions()
        {
            // Snippet: GetTopicPartitions(string, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/topics/[TOPIC]";
            // Make the request
            TopicPartitions response = adminServiceClient.GetTopicPartitions(name);
            // End snippet
        }

        /// <summary>Snippet for GetTopicPartitionsAsync</summary>
        public async Task GetTopicPartitionsAsync()
        {
            // Snippet: GetTopicPartitionsAsync(string, CallSettings)
            // Additional: GetTopicPartitionsAsync(string, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/topics/[TOPIC]";
            // Make the request
            TopicPartitions response = await adminServiceClient.GetTopicPartitionsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTopicPartitions</summary>
        public void GetTopicPartitionsResourceNames()
        {
            // Snippet: GetTopicPartitions(TopicName, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            TopicName name = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]");
            // Make the request
            TopicPartitions response = adminServiceClient.GetTopicPartitions(name);
            // End snippet
        }

        /// <summary>Snippet for GetTopicPartitionsAsync</summary>
        public async Task GetTopicPartitionsResourceNamesAsync()
        {
            // Snippet: GetTopicPartitionsAsync(TopicName, CallSettings)
            // Additional: GetTopicPartitionsAsync(TopicName, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            TopicName name = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]");
            // Make the request
            TopicPartitions response = await adminServiceClient.GetTopicPartitionsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTopics</summary>
        public void ListTopicsRequestObject()
        {
            // Snippet: ListTopics(ListTopicsRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            ListTopicsRequest request = new ListTopicsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListTopicsResponse, Topic> response = adminServiceClient.ListTopics(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Topic item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicsAsync</summary>
        public async Task ListTopicsRequestObjectAsync()
        {
            // Snippet: ListTopicsAsync(ListTopicsRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTopicsRequest request = new ListTopicsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTopicsResponse, Topic> response = adminServiceClient.ListTopicsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Topic item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopics</summary>
        public void ListTopics()
        {
            // Snippet: ListTopics(string, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTopicsResponse, Topic> response = adminServiceClient.ListTopics(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Topic item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicsAsync</summary>
        public async Task ListTopicsAsync()
        {
            // Snippet: ListTopicsAsync(string, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTopicsResponse, Topic> response = adminServiceClient.ListTopicsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Topic item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopics</summary>
        public void ListTopicsResourceNames()
        {
            // Snippet: ListTopics(LocationName, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTopicsResponse, Topic> response = adminServiceClient.ListTopics(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Topic item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicsAsync</summary>
        public async Task ListTopicsResourceNamesAsync()
        {
            // Snippet: ListTopicsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTopicsResponse, Topic> response = adminServiceClient.ListTopicsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Topic item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateTopic</summary>
        public void UpdateTopicRequestObject()
        {
            // Snippet: UpdateTopic(UpdateTopicRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Topic response = adminServiceClient.UpdateTopic(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTopicAsync</summary>
        public async Task UpdateTopicRequestObjectAsync()
        {
            // Snippet: UpdateTopicAsync(UpdateTopicRequest, CallSettings)
            // Additional: UpdateTopicAsync(UpdateTopicRequest, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                Topic = new Topic(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Topic response = await adminServiceClient.UpdateTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTopic</summary>
        public void UpdateTopic()
        {
            // Snippet: UpdateTopic(Topic, FieldMask, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            Topic topic = new Topic();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Topic response = adminServiceClient.UpdateTopic(topic, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTopicAsync</summary>
        public async Task UpdateTopicAsync()
        {
            // Snippet: UpdateTopicAsync(Topic, FieldMask, CallSettings)
            // Additional: UpdateTopicAsync(Topic, FieldMask, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            Topic topic = new Topic();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Topic response = await adminServiceClient.UpdateTopicAsync(topic, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopic</summary>
        public void DeleteTopicRequestObject()
        {
            // Snippet: DeleteTopic(DeleteTopicRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            // Make the request
            adminServiceClient.DeleteTopic(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopicAsync</summary>
        public async Task DeleteTopicRequestObjectAsync()
        {
            // Snippet: DeleteTopicAsync(DeleteTopicRequest, CallSettings)
            // Additional: DeleteTopicAsync(DeleteTopicRequest, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            // Make the request
            await adminServiceClient.DeleteTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopic</summary>
        public void DeleteTopic()
        {
            // Snippet: DeleteTopic(string, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/topics/[TOPIC]";
            // Make the request
            adminServiceClient.DeleteTopic(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopicAsync</summary>
        public async Task DeleteTopicAsync()
        {
            // Snippet: DeleteTopicAsync(string, CallSettings)
            // Additional: DeleteTopicAsync(string, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/topics/[TOPIC]";
            // Make the request
            await adminServiceClient.DeleteTopicAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopic</summary>
        public void DeleteTopicResourceNames()
        {
            // Snippet: DeleteTopic(TopicName, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            TopicName name = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]");
            // Make the request
            adminServiceClient.DeleteTopic(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopicAsync</summary>
        public async Task DeleteTopicResourceNamesAsync()
        {
            // Snippet: DeleteTopicAsync(TopicName, CallSettings)
            // Additional: DeleteTopicAsync(TopicName, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            TopicName name = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]");
            // Make the request
            await adminServiceClient.DeleteTopicAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptions</summary>
        public void ListTopicSubscriptionsRequestObject()
        {
            // Snippet: ListTopicSubscriptions(ListTopicSubscriptionsRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            // Make the request
            PagedEnumerable<ListTopicSubscriptionsResponse, string> response = adminServiceClient.ListTopicSubscriptions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptionsAsync</summary>
        public async Task ListTopicSubscriptionsRequestObjectAsync()
        {
            // Snippet: ListTopicSubscriptionsAsync(ListTopicSubscriptionsRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                TopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> response = adminServiceClient.ListTopicSubscriptionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptions</summary>
        public void ListTopicSubscriptions()
        {
            // Snippet: ListTopicSubscriptions(string, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/topics/[TOPIC]";
            // Make the request
            PagedEnumerable<ListTopicSubscriptionsResponse, string> response = adminServiceClient.ListTopicSubscriptions(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptionsAsync</summary>
        public async Task ListTopicSubscriptionsAsync()
        {
            // Snippet: ListTopicSubscriptionsAsync(string, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/topics/[TOPIC]";
            // Make the request
            PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> response = adminServiceClient.ListTopicSubscriptionsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptions</summary>
        public void ListTopicSubscriptionsResourceNames()
        {
            // Snippet: ListTopicSubscriptions(TopicName, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            TopicName name = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]");
            // Make the request
            PagedEnumerable<ListTopicSubscriptionsResponse, string> response = adminServiceClient.ListTopicSubscriptions(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicSubscriptionsAsync</summary>
        public async Task ListTopicSubscriptionsResourceNamesAsync()
        {
            // Snippet: ListTopicSubscriptionsAsync(TopicName, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            TopicName name = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]");
            // Make the request
            PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> response = adminServiceClient.ListTopicSubscriptionsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateSubscription</summary>
        public void CreateSubscriptionRequestObject()
        {
            // Snippet: CreateSubscription(CreateSubscriptionRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Subscription = new Subscription(),
                SubscriptionId = "",
                SkipBacklog = false,
            };
            // Make the request
            Subscription response = adminServiceClient.CreateSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionRequestObjectAsync()
        {
            // Snippet: CreateSubscriptionAsync(CreateSubscriptionRequest, CallSettings)
            // Additional: CreateSubscriptionAsync(CreateSubscriptionRequest, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Subscription = new Subscription(),
                SubscriptionId = "",
                SkipBacklog = false,
            };
            // Make the request
            Subscription response = await adminServiceClient.CreateSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscription</summary>
        public void CreateSubscription()
        {
            // Snippet: CreateSubscription(string, Subscription, string, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Subscription subscription = new Subscription();
            string subscriptionId = "";
            // Make the request
            Subscription response = adminServiceClient.CreateSubscription(parent, subscription, subscriptionId);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionAsync()
        {
            // Snippet: CreateSubscriptionAsync(string, Subscription, string, CallSettings)
            // Additional: CreateSubscriptionAsync(string, Subscription, string, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Subscription subscription = new Subscription();
            string subscriptionId = "";
            // Make the request
            Subscription response = await adminServiceClient.CreateSubscriptionAsync(parent, subscription, subscriptionId);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscription</summary>
        public void CreateSubscriptionResourceNames()
        {
            // Snippet: CreateSubscription(LocationName, Subscription, string, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Subscription subscription = new Subscription();
            string subscriptionId = "";
            // Make the request
            Subscription response = adminServiceClient.CreateSubscription(parent, subscription, subscriptionId);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionResourceNamesAsync()
        {
            // Snippet: CreateSubscriptionAsync(LocationName, Subscription, string, CallSettings)
            // Additional: CreateSubscriptionAsync(LocationName, Subscription, string, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Subscription subscription = new Subscription();
            string subscriptionId = "";
            // Make the request
            Subscription response = await adminServiceClient.CreateSubscriptionAsync(parent, subscription, subscriptionId);
            // End snippet
        }

        /// <summary>Snippet for GetSubscription</summary>
        public void GetSubscriptionRequestObject()
        {
            // Snippet: GetSubscription(GetSubscriptionRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            // Make the request
            Subscription response = adminServiceClient.GetSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for GetSubscriptionAsync</summary>
        public async Task GetSubscriptionRequestObjectAsync()
        {
            // Snippet: GetSubscriptionAsync(GetSubscriptionRequest, CallSettings)
            // Additional: GetSubscriptionAsync(GetSubscriptionRequest, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSubscriptionRequest request = new GetSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            // Make the request
            Subscription response = await adminServiceClient.GetSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSubscription</summary>
        public void GetSubscription()
        {
            // Snippet: GetSubscription(string, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/subscriptions/[SUBSCRIPTION]";
            // Make the request
            Subscription response = adminServiceClient.GetSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for GetSubscriptionAsync</summary>
        public async Task GetSubscriptionAsync()
        {
            // Snippet: GetSubscriptionAsync(string, CallSettings)
            // Additional: GetSubscriptionAsync(string, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/subscriptions/[SUBSCRIPTION]";
            // Make the request
            Subscription response = await adminServiceClient.GetSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSubscription</summary>
        public void GetSubscriptionResourceNames()
        {
            // Snippet: GetSubscription(SubscriptionName, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            SubscriptionName name = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]");
            // Make the request
            Subscription response = adminServiceClient.GetSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for GetSubscriptionAsync</summary>
        public async Task GetSubscriptionResourceNamesAsync()
        {
            // Snippet: GetSubscriptionAsync(SubscriptionName, CallSettings)
            // Additional: GetSubscriptionAsync(SubscriptionName, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName name = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]");
            // Make the request
            Subscription response = await adminServiceClient.GetSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptions</summary>
        public void ListSubscriptionsRequestObject()
        {
            // Snippet: ListSubscriptions(ListSubscriptionsRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response = adminServiceClient.ListSubscriptions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptionsAsync</summary>
        public async Task ListSubscriptionsRequestObjectAsync()
        {
            // Snippet: ListSubscriptionsAsync(ListSubscriptionsRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response = adminServiceClient.ListSubscriptionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subscription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptions</summary>
        public void ListSubscriptions()
        {
            // Snippet: ListSubscriptions(string, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response = adminServiceClient.ListSubscriptions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptionsAsync</summary>
        public async Task ListSubscriptionsAsync()
        {
            // Snippet: ListSubscriptionsAsync(string, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response = adminServiceClient.ListSubscriptionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subscription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptions</summary>
        public void ListSubscriptionsResourceNames()
        {
            // Snippet: ListSubscriptions(LocationName, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response = adminServiceClient.ListSubscriptions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptionsAsync</summary>
        public async Task ListSubscriptionsResourceNamesAsync()
        {
            // Snippet: ListSubscriptionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response = adminServiceClient.ListSubscriptionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subscription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscription</summary>
        public void UpdateSubscriptionRequestObject()
        {
            // Snippet: UpdateSubscription(UpdateSubscriptionRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Subscription response = adminServiceClient.UpdateSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscriptionAsync</summary>
        public async Task UpdateSubscriptionRequestObjectAsync()
        {
            // Snippet: UpdateSubscriptionAsync(UpdateSubscriptionRequest, CallSettings)
            // Additional: UpdateSubscriptionAsync(UpdateSubscriptionRequest, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Subscription response = await adminServiceClient.UpdateSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscription</summary>
        public void UpdateSubscription()
        {
            // Snippet: UpdateSubscription(Subscription, FieldMask, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            Subscription subscription = new Subscription();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Subscription response = adminServiceClient.UpdateSubscription(subscription, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscriptionAsync</summary>
        public async Task UpdateSubscriptionAsync()
        {
            // Snippet: UpdateSubscriptionAsync(Subscription, FieldMask, CallSettings)
            // Additional: UpdateSubscriptionAsync(Subscription, FieldMask, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            Subscription subscription = new Subscription();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Subscription response = await adminServiceClient.UpdateSubscriptionAsync(subscription, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscriptionRequestObject()
        {
            // Snippet: DeleteSubscription(DeleteSubscriptionRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            // Make the request
            adminServiceClient.DeleteSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionRequestObjectAsync()
        {
            // Snippet: DeleteSubscriptionAsync(DeleteSubscriptionRequest, CallSettings)
            // Additional: DeleteSubscriptionAsync(DeleteSubscriptionRequest, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]"),
            };
            // Make the request
            await adminServiceClient.DeleteSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscription()
        {
            // Snippet: DeleteSubscription(string, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/subscriptions/[SUBSCRIPTION]";
            // Make the request
            adminServiceClient.DeleteSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionAsync()
        {
            // Snippet: DeleteSubscriptionAsync(string, CallSettings)
            // Additional: DeleteSubscriptionAsync(string, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/subscriptions/[SUBSCRIPTION]";
            // Make the request
            await adminServiceClient.DeleteSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscriptionResourceNames()
        {
            // Snippet: DeleteSubscription(SubscriptionName, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            SubscriptionName name = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]");
            // Make the request
            adminServiceClient.DeleteSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionResourceNamesAsync()
        {
            // Snippet: DeleteSubscriptionAsync(SubscriptionName, CallSettings)
            // Additional: DeleteSubscriptionAsync(SubscriptionName, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName name = SubscriptionName.FromProjectLocationSubscription("[PROJECT]", "[LOCATION]", "[SUBSCRIPTION]");
            // Make the request
            await adminServiceClient.DeleteSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateReservation</summary>
        public void CreateReservationRequestObject()
        {
            // Snippet: CreateReservation(CreateReservationRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Reservation = new Reservation(),
                ReservationId = "",
            };
            // Make the request
            Reservation response = adminServiceClient.CreateReservation(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReservationAsync</summary>
        public async Task CreateReservationRequestObjectAsync()
        {
            // Snippet: CreateReservationAsync(CreateReservationRequest, CallSettings)
            // Additional: CreateReservationAsync(CreateReservationRequest, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Reservation = new Reservation(),
                ReservationId = "",
            };
            // Make the request
            Reservation response = await adminServiceClient.CreateReservationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReservation</summary>
        public void CreateReservation()
        {
            // Snippet: CreateReservation(string, Reservation, string, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Reservation reservation = new Reservation();
            string reservationId = "";
            // Make the request
            Reservation response = adminServiceClient.CreateReservation(parent, reservation, reservationId);
            // End snippet
        }

        /// <summary>Snippet for CreateReservationAsync</summary>
        public async Task CreateReservationAsync()
        {
            // Snippet: CreateReservationAsync(string, Reservation, string, CallSettings)
            // Additional: CreateReservationAsync(string, Reservation, string, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Reservation reservation = new Reservation();
            string reservationId = "";
            // Make the request
            Reservation response = await adminServiceClient.CreateReservationAsync(parent, reservation, reservationId);
            // End snippet
        }

        /// <summary>Snippet for CreateReservation</summary>
        public void CreateReservationResourceNames()
        {
            // Snippet: CreateReservation(LocationName, Reservation, string, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Reservation reservation = new Reservation();
            string reservationId = "";
            // Make the request
            Reservation response = adminServiceClient.CreateReservation(parent, reservation, reservationId);
            // End snippet
        }

        /// <summary>Snippet for CreateReservationAsync</summary>
        public async Task CreateReservationResourceNamesAsync()
        {
            // Snippet: CreateReservationAsync(LocationName, Reservation, string, CallSettings)
            // Additional: CreateReservationAsync(LocationName, Reservation, string, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Reservation reservation = new Reservation();
            string reservationId = "";
            // Make the request
            Reservation response = await adminServiceClient.CreateReservationAsync(parent, reservation, reservationId);
            // End snippet
        }

        /// <summary>Snippet for GetReservation</summary>
        public void GetReservationRequestObject()
        {
            // Snippet: GetReservation(GetReservationRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            // Make the request
            Reservation response = adminServiceClient.GetReservation(request);
            // End snippet
        }

        /// <summary>Snippet for GetReservationAsync</summary>
        public async Task GetReservationRequestObjectAsync()
        {
            // Snippet: GetReservationAsync(GetReservationRequest, CallSettings)
            // Additional: GetReservationAsync(GetReservationRequest, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            // Make the request
            Reservation response = await adminServiceClient.GetReservationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReservation</summary>
        public void GetReservation()
        {
            // Snippet: GetReservation(string, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            // Make the request
            Reservation response = adminServiceClient.GetReservation(name);
            // End snippet
        }

        /// <summary>Snippet for GetReservationAsync</summary>
        public async Task GetReservationAsync()
        {
            // Snippet: GetReservationAsync(string, CallSettings)
            // Additional: GetReservationAsync(string, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            // Make the request
            Reservation response = await adminServiceClient.GetReservationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReservation</summary>
        public void GetReservationResourceNames()
        {
            // Snippet: GetReservation(ReservationName, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            ReservationName name = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            // Make the request
            Reservation response = adminServiceClient.GetReservation(name);
            // End snippet
        }

        /// <summary>Snippet for GetReservationAsync</summary>
        public async Task GetReservationResourceNamesAsync()
        {
            // Snippet: GetReservationAsync(ReservationName, CallSettings)
            // Additional: GetReservationAsync(ReservationName, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReservationName name = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            // Make the request
            Reservation response = await adminServiceClient.GetReservationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListReservations</summary>
        public void ListReservationsRequestObject()
        {
            // Snippet: ListReservations(ListReservationsRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            ListReservationsRequest request = new ListReservationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListReservationsResponse, Reservation> response = adminServiceClient.ListReservations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Reservation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReservationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReservationsAsync</summary>
        public async Task ListReservationsRequestObjectAsync()
        {
            // Snippet: ListReservationsAsync(ListReservationsRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListReservationsRequest request = new ListReservationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListReservationsResponse, Reservation> response = adminServiceClient.ListReservationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Reservation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReservationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReservations</summary>
        public void ListReservations()
        {
            // Snippet: ListReservations(string, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListReservationsResponse, Reservation> response = adminServiceClient.ListReservations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Reservation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReservationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReservationsAsync</summary>
        public async Task ListReservationsAsync()
        {
            // Snippet: ListReservationsAsync(string, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListReservationsResponse, Reservation> response = adminServiceClient.ListReservationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Reservation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReservationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReservations</summary>
        public void ListReservationsResourceNames()
        {
            // Snippet: ListReservations(LocationName, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListReservationsResponse, Reservation> response = adminServiceClient.ListReservations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Reservation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReservationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReservationsAsync</summary>
        public async Task ListReservationsResourceNamesAsync()
        {
            // Snippet: ListReservationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListReservationsResponse, Reservation> response = adminServiceClient.ListReservationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Reservation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReservationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateReservation</summary>
        public void UpdateReservationRequestObject()
        {
            // Snippet: UpdateReservation(UpdateReservationRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateReservationRequest request = new UpdateReservationRequest
            {
                Reservation = new Reservation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Reservation response = adminServiceClient.UpdateReservation(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateReservationAsync</summary>
        public async Task UpdateReservationRequestObjectAsync()
        {
            // Snippet: UpdateReservationAsync(UpdateReservationRequest, CallSettings)
            // Additional: UpdateReservationAsync(UpdateReservationRequest, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateReservationRequest request = new UpdateReservationRequest
            {
                Reservation = new Reservation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Reservation response = await adminServiceClient.UpdateReservationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateReservation</summary>
        public void UpdateReservation()
        {
            // Snippet: UpdateReservation(Reservation, FieldMask, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            Reservation reservation = new Reservation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Reservation response = adminServiceClient.UpdateReservation(reservation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateReservationAsync</summary>
        public async Task UpdateReservationAsync()
        {
            // Snippet: UpdateReservationAsync(Reservation, FieldMask, CallSettings)
            // Additional: UpdateReservationAsync(Reservation, FieldMask, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            Reservation reservation = new Reservation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Reservation response = await adminServiceClient.UpdateReservationAsync(reservation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteReservation</summary>
        public void DeleteReservationRequestObject()
        {
            // Snippet: DeleteReservation(DeleteReservationRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            // Make the request
            adminServiceClient.DeleteReservation(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReservationAsync</summary>
        public async Task DeleteReservationRequestObjectAsync()
        {
            // Snippet: DeleteReservationAsync(DeleteReservationRequest, CallSettings)
            // Additional: DeleteReservationAsync(DeleteReservationRequest, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            // Make the request
            await adminServiceClient.DeleteReservationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReservation</summary>
        public void DeleteReservation()
        {
            // Snippet: DeleteReservation(string, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            // Make the request
            adminServiceClient.DeleteReservation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReservationAsync</summary>
        public async Task DeleteReservationAsync()
        {
            // Snippet: DeleteReservationAsync(string, CallSettings)
            // Additional: DeleteReservationAsync(string, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            // Make the request
            await adminServiceClient.DeleteReservationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReservation</summary>
        public void DeleteReservationResourceNames()
        {
            // Snippet: DeleteReservation(ReservationName, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            ReservationName name = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            // Make the request
            adminServiceClient.DeleteReservation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReservationAsync</summary>
        public async Task DeleteReservationResourceNamesAsync()
        {
            // Snippet: DeleteReservationAsync(ReservationName, CallSettings)
            // Additional: DeleteReservationAsync(ReservationName, CancellationToken)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReservationName name = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            // Make the request
            await adminServiceClient.DeleteReservationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListReservationTopics</summary>
        public void ListReservationTopicsRequestObject()
        {
            // Snippet: ListReservationTopics(ListReservationTopicsRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            ListReservationTopicsRequest request = new ListReservationTopicsRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            // Make the request
            PagedEnumerable<ListReservationTopicsResponse, string> response = adminServiceClient.ListReservationTopics(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReservationTopicsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReservationTopicsAsync</summary>
        public async Task ListReservationTopicsRequestObjectAsync()
        {
            // Snippet: ListReservationTopicsAsync(ListReservationTopicsRequest, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListReservationTopicsRequest request = new ListReservationTopicsRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListReservationTopicsResponse, string> response = adminServiceClient.ListReservationTopicsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReservationTopicsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReservationTopics</summary>
        public void ListReservationTopics()
        {
            // Snippet: ListReservationTopics(string, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            // Make the request
            PagedEnumerable<ListReservationTopicsResponse, string> response = adminServiceClient.ListReservationTopics(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReservationTopicsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReservationTopicsAsync</summary>
        public async Task ListReservationTopicsAsync()
        {
            // Snippet: ListReservationTopicsAsync(string, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            // Make the request
            PagedAsyncEnumerable<ListReservationTopicsResponse, string> response = adminServiceClient.ListReservationTopicsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReservationTopicsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReservationTopics</summary>
        public void ListReservationTopicsResourceNames()
        {
            // Snippet: ListReservationTopics(ReservationName, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = AdminServiceClient.Create();
            // Initialize request argument(s)
            ReservationName name = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            // Make the request
            PagedEnumerable<ListReservationTopicsResponse, string> response = adminServiceClient.ListReservationTopics(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReservationTopicsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReservationTopicsAsync</summary>
        public async Task ListReservationTopicsResourceNamesAsync()
        {
            // Snippet: ListReservationTopicsAsync(ReservationName, string, int?, CallSettings)
            // Create client
            AdminServiceClient adminServiceClient = await AdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReservationName name = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            // Make the request
            PagedAsyncEnumerable<ListReservationTopicsResponse, string> response = adminServiceClient.ListReservationTopicsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReservationTopicsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
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
