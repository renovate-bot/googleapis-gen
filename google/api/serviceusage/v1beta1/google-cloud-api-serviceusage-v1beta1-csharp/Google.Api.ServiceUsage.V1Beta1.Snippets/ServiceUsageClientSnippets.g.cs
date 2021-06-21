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

namespace Google.Api.ServiceUsage.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedServiceUsageClientSnippets
    {
        /// <summary>Snippet for EnableService</summary>
        public void EnableServiceRequestObject()
        {
            // Snippet: EnableService(EnableServiceRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            EnableServiceRequest request = new EnableServiceRequest { Name = "", };
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = serviceUsageClient.EnableService(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = serviceUsageClient.PollOnceEnableService(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableServiceAsync</summary>
        public async Task EnableServiceRequestObjectAsync()
        {
            // Snippet: EnableServiceAsync(EnableServiceRequest, CallSettings)
            // Additional: EnableServiceAsync(EnableServiceRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            EnableServiceRequest request = new EnableServiceRequest { Name = "", };
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await serviceUsageClient.EnableServiceAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await serviceUsageClient.PollOnceEnableServiceAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableService</summary>
        public void DisableServiceRequestObject()
        {
            // Snippet: DisableService(DisableServiceRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            DisableServiceRequest request = new DisableServiceRequest { Name = "", };
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = serviceUsageClient.DisableService(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = serviceUsageClient.PollOnceDisableService(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableServiceAsync</summary>
        public async Task DisableServiceRequestObjectAsync()
        {
            // Snippet: DisableServiceAsync(DisableServiceRequest, CallSettings)
            // Additional: DisableServiceAsync(DisableServiceRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            DisableServiceRequest request = new DisableServiceRequest { Name = "", };
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await serviceUsageClient.DisableServiceAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await serviceUsageClient.PollOnceDisableServiceAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetServiceRequestObject()
        {
            // Snippet: GetService(GetServiceRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest { Name = "", };
            // Make the request
#pragma warning disable CS0612
            Service response = serviceUsageClient.GetService(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceRequestObjectAsync()
        {
            // Snippet: GetServiceAsync(GetServiceRequest, CallSettings)
            // Additional: GetServiceAsync(GetServiceRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest { Name = "", };
            // Make the request
#pragma warning disable CS0612
            Service response = await serviceUsageClient.GetServiceAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServicesRequestObject()
        {
            // Snippet: ListServices(ListServicesRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListServicesResponse, Service> response = serviceUsageClient.ListServices(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesRequestObjectAsync()
        {
            // Snippet: ListServicesAsync(ListServicesRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListServicesResponse, Service> response = serviceUsageClient.ListServicesAsync(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Service item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchEnableServices</summary>
        public void BatchEnableServicesRequestObject()
        {
            // Snippet: BatchEnableServices(BatchEnableServicesRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            BatchEnableServicesRequest request = new BatchEnableServicesRequest
            {
                Parent = "",
                ServiceIds = { "", },
            };
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = serviceUsageClient.BatchEnableServices(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = serviceUsageClient.PollOnceBatchEnableServices(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchEnableServicesAsync</summary>
        public async Task BatchEnableServicesRequestObjectAsync()
        {
            // Snippet: BatchEnableServicesAsync(BatchEnableServicesRequest, CallSettings)
            // Additional: BatchEnableServicesAsync(BatchEnableServicesRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            BatchEnableServicesRequest request = new BatchEnableServicesRequest
            {
                Parent = "",
                ServiceIds = { "", },
            };
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await serviceUsageClient.BatchEnableServicesAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await serviceUsageClient.PollOnceBatchEnableServicesAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListConsumerQuotaMetrics</summary>
        public void ListConsumerQuotaMetricsRequestObject()
        {
            // Snippet: ListConsumerQuotaMetrics(ListConsumerQuotaMetricsRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            ListConsumerQuotaMetricsRequest request = new ListConsumerQuotaMetricsRequest
            {
                Parent = "",
                View = QuotaView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListConsumerQuotaMetricsResponse, ConsumerQuotaMetric> response = serviceUsageClient.ListConsumerQuotaMetrics(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConsumerQuotaMetric item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConsumerQuotaMetricsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConsumerQuotaMetric item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConsumerQuotaMetric> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConsumerQuotaMetric item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConsumerQuotaMetricsAsync</summary>
        public async Task ListConsumerQuotaMetricsRequestObjectAsync()
        {
            // Snippet: ListConsumerQuotaMetricsAsync(ListConsumerQuotaMetricsRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            ListConsumerQuotaMetricsRequest request = new ListConsumerQuotaMetricsRequest
            {
                Parent = "",
                View = QuotaView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListConsumerQuotaMetricsResponse, ConsumerQuotaMetric> response = serviceUsageClient.ListConsumerQuotaMetricsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConsumerQuotaMetric item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConsumerQuotaMetricsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConsumerQuotaMetric item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConsumerQuotaMetric> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConsumerQuotaMetric item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetConsumerQuotaMetric</summary>
        public void GetConsumerQuotaMetricRequestObject()
        {
            // Snippet: GetConsumerQuotaMetric(GetConsumerQuotaMetricRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            GetConsumerQuotaMetricRequest request = new GetConsumerQuotaMetricRequest
            {
                Name = "",
                View = QuotaView.Unspecified,
            };
            // Make the request
            ConsumerQuotaMetric response = serviceUsageClient.GetConsumerQuotaMetric(request);
            // End snippet
        }

        /// <summary>Snippet for GetConsumerQuotaMetricAsync</summary>
        public async Task GetConsumerQuotaMetricRequestObjectAsync()
        {
            // Snippet: GetConsumerQuotaMetricAsync(GetConsumerQuotaMetricRequest, CallSettings)
            // Additional: GetConsumerQuotaMetricAsync(GetConsumerQuotaMetricRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            GetConsumerQuotaMetricRequest request = new GetConsumerQuotaMetricRequest
            {
                Name = "",
                View = QuotaView.Unspecified,
            };
            // Make the request
            ConsumerQuotaMetric response = await serviceUsageClient.GetConsumerQuotaMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConsumerQuotaLimit</summary>
        public void GetConsumerQuotaLimitRequestObject()
        {
            // Snippet: GetConsumerQuotaLimit(GetConsumerQuotaLimitRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            GetConsumerQuotaLimitRequest request = new GetConsumerQuotaLimitRequest
            {
                Name = "",
                View = QuotaView.Unspecified,
            };
            // Make the request
            ConsumerQuotaLimit response = serviceUsageClient.GetConsumerQuotaLimit(request);
            // End snippet
        }

        /// <summary>Snippet for GetConsumerQuotaLimitAsync</summary>
        public async Task GetConsumerQuotaLimitRequestObjectAsync()
        {
            // Snippet: GetConsumerQuotaLimitAsync(GetConsumerQuotaLimitRequest, CallSettings)
            // Additional: GetConsumerQuotaLimitAsync(GetConsumerQuotaLimitRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            GetConsumerQuotaLimitRequest request = new GetConsumerQuotaLimitRequest
            {
                Name = "",
                View = QuotaView.Unspecified,
            };
            // Make the request
            ConsumerQuotaLimit response = await serviceUsageClient.GetConsumerQuotaLimitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAdminOverride</summary>
        public void CreateAdminOverrideRequestObject()
        {
            // Snippet: CreateAdminOverride(CreateAdminOverrideRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            CreateAdminOverrideRequest request = new CreateAdminOverrideRequest
            {
                Parent = "",
                Override = new QuotaOverride(),
                Force = false,
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<QuotaOverride, OperationMetadata> response = serviceUsageClient.CreateAdminOverride(request);

            // Poll until the returned long-running operation is complete
            Operation<QuotaOverride, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            QuotaOverride result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<QuotaOverride, OperationMetadata> retrievedResponse = serviceUsageClient.PollOnceCreateAdminOverride(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                QuotaOverride retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAdminOverrideAsync</summary>
        public async Task CreateAdminOverrideRequestObjectAsync()
        {
            // Snippet: CreateAdminOverrideAsync(CreateAdminOverrideRequest, CallSettings)
            // Additional: CreateAdminOverrideAsync(CreateAdminOverrideRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            CreateAdminOverrideRequest request = new CreateAdminOverrideRequest
            {
                Parent = "",
                Override = new QuotaOverride(),
                Force = false,
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<QuotaOverride, OperationMetadata> response = await serviceUsageClient.CreateAdminOverrideAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<QuotaOverride, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            QuotaOverride result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<QuotaOverride, OperationMetadata> retrievedResponse = await serviceUsageClient.PollOnceCreateAdminOverrideAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                QuotaOverride retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAdminOverride</summary>
        public void UpdateAdminOverrideRequestObject()
        {
            // Snippet: UpdateAdminOverride(UpdateAdminOverrideRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            UpdateAdminOverrideRequest request = new UpdateAdminOverrideRequest
            {
                Name = "",
                Override = new QuotaOverride(),
                Force = false,
                UpdateMask = new FieldMask(),
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<QuotaOverride, OperationMetadata> response = serviceUsageClient.UpdateAdminOverride(request);

            // Poll until the returned long-running operation is complete
            Operation<QuotaOverride, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            QuotaOverride result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<QuotaOverride, OperationMetadata> retrievedResponse = serviceUsageClient.PollOnceUpdateAdminOverride(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                QuotaOverride retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAdminOverrideAsync</summary>
        public async Task UpdateAdminOverrideRequestObjectAsync()
        {
            // Snippet: UpdateAdminOverrideAsync(UpdateAdminOverrideRequest, CallSettings)
            // Additional: UpdateAdminOverrideAsync(UpdateAdminOverrideRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAdminOverrideRequest request = new UpdateAdminOverrideRequest
            {
                Name = "",
                Override = new QuotaOverride(),
                Force = false,
                UpdateMask = new FieldMask(),
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<QuotaOverride, OperationMetadata> response = await serviceUsageClient.UpdateAdminOverrideAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<QuotaOverride, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            QuotaOverride result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<QuotaOverride, OperationMetadata> retrievedResponse = await serviceUsageClient.PollOnceUpdateAdminOverrideAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                QuotaOverride retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAdminOverride</summary>
        public void DeleteAdminOverrideRequestObject()
        {
            // Snippet: DeleteAdminOverride(DeleteAdminOverrideRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            DeleteAdminOverrideRequest request = new DeleteAdminOverrideRequest
            {
                Name = "",
                Force = false,
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = serviceUsageClient.DeleteAdminOverride(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = serviceUsageClient.PollOnceDeleteAdminOverride(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAdminOverrideAsync</summary>
        public async Task DeleteAdminOverrideRequestObjectAsync()
        {
            // Snippet: DeleteAdminOverrideAsync(DeleteAdminOverrideRequest, CallSettings)
            // Additional: DeleteAdminOverrideAsync(DeleteAdminOverrideRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAdminOverrideRequest request = new DeleteAdminOverrideRequest
            {
                Name = "",
                Force = false,
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await serviceUsageClient.DeleteAdminOverrideAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await serviceUsageClient.PollOnceDeleteAdminOverrideAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListAdminOverrides</summary>
        public void ListAdminOverridesRequestObject()
        {
            // Snippet: ListAdminOverrides(ListAdminOverridesRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            ListAdminOverridesRequest request = new ListAdminOverridesRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListAdminOverridesResponse, QuotaOverride> response = serviceUsageClient.ListAdminOverrides(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (QuotaOverride item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdminOverridesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaOverride item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaOverride> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaOverride item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdminOverridesAsync</summary>
        public async Task ListAdminOverridesRequestObjectAsync()
        {
            // Snippet: ListAdminOverridesAsync(ListAdminOverridesRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            ListAdminOverridesRequest request = new ListAdminOverridesRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListAdminOverridesResponse, QuotaOverride> response = serviceUsageClient.ListAdminOverridesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((QuotaOverride item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdminOverridesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaOverride item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaOverride> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaOverride item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ImportAdminOverrides</summary>
        public void ImportAdminOverridesRequestObject()
        {
            // Snippet: ImportAdminOverrides(ImportAdminOverridesRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            ImportAdminOverridesRequest request = new ImportAdminOverridesRequest
            {
                Parent = "",
                InlineSource = new OverrideInlineSource(),
                Force = false,
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata> response = serviceUsageClient.ImportAdminOverrides(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportAdminOverridesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata> retrievedResponse = serviceUsageClient.PollOnceImportAdminOverrides(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportAdminOverridesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportAdminOverridesAsync</summary>
        public async Task ImportAdminOverridesRequestObjectAsync()
        {
            // Snippet: ImportAdminOverridesAsync(ImportAdminOverridesRequest, CallSettings)
            // Additional: ImportAdminOverridesAsync(ImportAdminOverridesRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            ImportAdminOverridesRequest request = new ImportAdminOverridesRequest
            {
                Parent = "",
                InlineSource = new OverrideInlineSource(),
                Force = false,
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata> response = await serviceUsageClient.ImportAdminOverridesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportAdminOverridesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata> retrievedResponse = await serviceUsageClient.PollOnceImportAdminOverridesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportAdminOverridesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConsumerOverride</summary>
        public void CreateConsumerOverrideRequestObject()
        {
            // Snippet: CreateConsumerOverride(CreateConsumerOverrideRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            CreateConsumerOverrideRequest request = new CreateConsumerOverrideRequest
            {
                Parent = "",
                Override = new QuotaOverride(),
                Force = false,
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<QuotaOverride, OperationMetadata> response = serviceUsageClient.CreateConsumerOverride(request);

            // Poll until the returned long-running operation is complete
            Operation<QuotaOverride, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            QuotaOverride result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<QuotaOverride, OperationMetadata> retrievedResponse = serviceUsageClient.PollOnceCreateConsumerOverride(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                QuotaOverride retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConsumerOverrideAsync</summary>
        public async Task CreateConsumerOverrideRequestObjectAsync()
        {
            // Snippet: CreateConsumerOverrideAsync(CreateConsumerOverrideRequest, CallSettings)
            // Additional: CreateConsumerOverrideAsync(CreateConsumerOverrideRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            CreateConsumerOverrideRequest request = new CreateConsumerOverrideRequest
            {
                Parent = "",
                Override = new QuotaOverride(),
                Force = false,
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<QuotaOverride, OperationMetadata> response = await serviceUsageClient.CreateConsumerOverrideAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<QuotaOverride, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            QuotaOverride result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<QuotaOverride, OperationMetadata> retrievedResponse = await serviceUsageClient.PollOnceCreateConsumerOverrideAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                QuotaOverride retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConsumerOverride</summary>
        public void UpdateConsumerOverrideRequestObject()
        {
            // Snippet: UpdateConsumerOverride(UpdateConsumerOverrideRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            UpdateConsumerOverrideRequest request = new UpdateConsumerOverrideRequest
            {
                Name = "",
                Override = new QuotaOverride(),
                Force = false,
                UpdateMask = new FieldMask(),
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<QuotaOverride, OperationMetadata> response = serviceUsageClient.UpdateConsumerOverride(request);

            // Poll until the returned long-running operation is complete
            Operation<QuotaOverride, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            QuotaOverride result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<QuotaOverride, OperationMetadata> retrievedResponse = serviceUsageClient.PollOnceUpdateConsumerOverride(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                QuotaOverride retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConsumerOverrideAsync</summary>
        public async Task UpdateConsumerOverrideRequestObjectAsync()
        {
            // Snippet: UpdateConsumerOverrideAsync(UpdateConsumerOverrideRequest, CallSettings)
            // Additional: UpdateConsumerOverrideAsync(UpdateConsumerOverrideRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConsumerOverrideRequest request = new UpdateConsumerOverrideRequest
            {
                Name = "",
                Override = new QuotaOverride(),
                Force = false,
                UpdateMask = new FieldMask(),
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<QuotaOverride, OperationMetadata> response = await serviceUsageClient.UpdateConsumerOverrideAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<QuotaOverride, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            QuotaOverride result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<QuotaOverride, OperationMetadata> retrievedResponse = await serviceUsageClient.PollOnceUpdateConsumerOverrideAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                QuotaOverride retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConsumerOverride</summary>
        public void DeleteConsumerOverrideRequestObject()
        {
            // Snippet: DeleteConsumerOverride(DeleteConsumerOverrideRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            DeleteConsumerOverrideRequest request = new DeleteConsumerOverrideRequest
            {
                Name = "",
                Force = false,
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = serviceUsageClient.DeleteConsumerOverride(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = serviceUsageClient.PollOnceDeleteConsumerOverride(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConsumerOverrideAsync</summary>
        public async Task DeleteConsumerOverrideRequestObjectAsync()
        {
            // Snippet: DeleteConsumerOverrideAsync(DeleteConsumerOverrideRequest, CallSettings)
            // Additional: DeleteConsumerOverrideAsync(DeleteConsumerOverrideRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConsumerOverrideRequest request = new DeleteConsumerOverrideRequest
            {
                Name = "",
                Force = false,
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await serviceUsageClient.DeleteConsumerOverrideAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await serviceUsageClient.PollOnceDeleteConsumerOverrideAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListConsumerOverrides</summary>
        public void ListConsumerOverridesRequestObject()
        {
            // Snippet: ListConsumerOverrides(ListConsumerOverridesRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            ListConsumerOverridesRequest request = new ListConsumerOverridesRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListConsumerOverridesResponse, QuotaOverride> response = serviceUsageClient.ListConsumerOverrides(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (QuotaOverride item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConsumerOverridesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaOverride item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaOverride> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaOverride item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConsumerOverridesAsync</summary>
        public async Task ListConsumerOverridesRequestObjectAsync()
        {
            // Snippet: ListConsumerOverridesAsync(ListConsumerOverridesRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            ListConsumerOverridesRequest request = new ListConsumerOverridesRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListConsumerOverridesResponse, QuotaOverride> response = serviceUsageClient.ListConsumerOverridesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((QuotaOverride item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConsumerOverridesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaOverride item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaOverride> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaOverride item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ImportConsumerOverrides</summary>
        public void ImportConsumerOverridesRequestObject()
        {
            // Snippet: ImportConsumerOverrides(ImportConsumerOverridesRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            ImportConsumerOverridesRequest request = new ImportConsumerOverridesRequest
            {
                Parent = "",
                InlineSource = new OverrideInlineSource(),
                Force = false,
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata> response = serviceUsageClient.ImportConsumerOverrides(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportConsumerOverridesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata> retrievedResponse = serviceUsageClient.PollOnceImportConsumerOverrides(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportConsumerOverridesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportConsumerOverridesAsync</summary>
        public async Task ImportConsumerOverridesRequestObjectAsync()
        {
            // Snippet: ImportConsumerOverridesAsync(ImportConsumerOverridesRequest, CallSettings)
            // Additional: ImportConsumerOverridesAsync(ImportConsumerOverridesRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            ImportConsumerOverridesRequest request = new ImportConsumerOverridesRequest
            {
                Parent = "",
                InlineSource = new OverrideInlineSource(),
                Force = false,
                ForceOnly =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata> response = await serviceUsageClient.ImportConsumerOverridesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportConsumerOverridesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata> retrievedResponse = await serviceUsageClient.PollOnceImportConsumerOverridesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportConsumerOverridesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateServiceIdentity</summary>
        public void GenerateServiceIdentityRequestObject()
        {
            // Snippet: GenerateServiceIdentity(GenerateServiceIdentityRequest, CallSettings)
            // Create client
            ServiceUsageClient serviceUsageClient = ServiceUsageClient.Create();
            // Initialize request argument(s)
            GenerateServiceIdentityRequest request = new GenerateServiceIdentityRequest { Parent = "", };
            // Make the request
            Operation<ServiceIdentity, Empty> response = serviceUsageClient.GenerateServiceIdentity(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceIdentity, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceIdentity result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceIdentity, Empty> retrievedResponse = serviceUsageClient.PollOnceGenerateServiceIdentity(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceIdentity retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateServiceIdentityAsync</summary>
        public async Task GenerateServiceIdentityRequestObjectAsync()
        {
            // Snippet: GenerateServiceIdentityAsync(GenerateServiceIdentityRequest, CallSettings)
            // Additional: GenerateServiceIdentityAsync(GenerateServiceIdentityRequest, CancellationToken)
            // Create client
            ServiceUsageClient serviceUsageClient = await ServiceUsageClient.CreateAsync();
            // Initialize request argument(s)
            GenerateServiceIdentityRequest request = new GenerateServiceIdentityRequest { Parent = "", };
            // Make the request
            Operation<ServiceIdentity, Empty> response = await serviceUsageClient.GenerateServiceIdentityAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceIdentity, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceIdentity result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceIdentity, Empty> retrievedResponse = await serviceUsageClient.PollOnceGenerateServiceIdentityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceIdentity retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
