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

namespace Google.Ads.GoogleAds.V6.Services.Snippets
{
    using Google.Ads.GoogleAds.V6.Resources;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedOfflineUserDataJobServiceClientSnippets
    {
        /// <summary>Snippet for CreateOfflineUserDataJob</summary>
        public void CreateOfflineUserDataJobRequestObject()
        {
            // Snippet: CreateOfflineUserDataJob(CreateOfflineUserDataJobRequest, CallSettings)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = OfflineUserDataJobServiceClient.Create();
            // Initialize request argument(s)
            CreateOfflineUserDataJobRequest request = new CreateOfflineUserDataJobRequest
            {
                CustomerId = "",
                Job = new OfflineUserDataJob(),
            };
            // Make the request
            CreateOfflineUserDataJobResponse response = offlineUserDataJobServiceClient.CreateOfflineUserDataJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOfflineUserDataJobAsync</summary>
        public async Task CreateOfflineUserDataJobRequestObjectAsync()
        {
            // Snippet: CreateOfflineUserDataJobAsync(CreateOfflineUserDataJobRequest, CallSettings)
            // Additional: CreateOfflineUserDataJobAsync(CreateOfflineUserDataJobRequest, CancellationToken)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = await OfflineUserDataJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateOfflineUserDataJobRequest request = new CreateOfflineUserDataJobRequest
            {
                CustomerId = "",
                Job = new OfflineUserDataJob(),
            };
            // Make the request
            CreateOfflineUserDataJobResponse response = await offlineUserDataJobServiceClient.CreateOfflineUserDataJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOfflineUserDataJob</summary>
        public void CreateOfflineUserDataJob()
        {
            // Snippet: CreateOfflineUserDataJob(string, OfflineUserDataJob, CallSettings)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = OfflineUserDataJobServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            OfflineUserDataJob job = new OfflineUserDataJob();
            // Make the request
            CreateOfflineUserDataJobResponse response = offlineUserDataJobServiceClient.CreateOfflineUserDataJob(customerId, job);
            // End snippet
        }

        /// <summary>Snippet for CreateOfflineUserDataJobAsync</summary>
        public async Task CreateOfflineUserDataJobAsync()
        {
            // Snippet: CreateOfflineUserDataJobAsync(string, OfflineUserDataJob, CallSettings)
            // Additional: CreateOfflineUserDataJobAsync(string, OfflineUserDataJob, CancellationToken)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = await OfflineUserDataJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            OfflineUserDataJob job = new OfflineUserDataJob();
            // Make the request
            CreateOfflineUserDataJobResponse response = await offlineUserDataJobServiceClient.CreateOfflineUserDataJobAsync(customerId, job);
            // End snippet
        }

        /// <summary>Snippet for GetOfflineUserDataJob</summary>
        public void GetOfflineUserDataJobRequestObject()
        {
            // Snippet: GetOfflineUserDataJob(GetOfflineUserDataJobRequest, CallSettings)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = OfflineUserDataJobServiceClient.Create();
            // Initialize request argument(s)
            GetOfflineUserDataJobRequest request = new GetOfflineUserDataJobRequest
            {
                ResourceNameAsOfflineUserDataJobName = OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
            };
            // Make the request
            OfflineUserDataJob response = offlineUserDataJobServiceClient.GetOfflineUserDataJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetOfflineUserDataJobAsync</summary>
        public async Task GetOfflineUserDataJobRequestObjectAsync()
        {
            // Snippet: GetOfflineUserDataJobAsync(GetOfflineUserDataJobRequest, CallSettings)
            // Additional: GetOfflineUserDataJobAsync(GetOfflineUserDataJobRequest, CancellationToken)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = await OfflineUserDataJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetOfflineUserDataJobRequest request = new GetOfflineUserDataJobRequest
            {
                ResourceNameAsOfflineUserDataJobName = OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
            };
            // Make the request
            OfflineUserDataJob response = await offlineUserDataJobServiceClient.GetOfflineUserDataJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOfflineUserDataJob</summary>
        public void GetOfflineUserDataJob()
        {
            // Snippet: GetOfflineUserDataJob(string, CallSettings)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = OfflineUserDataJobServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/offlineUserDataJobs/[OFFLINE_USER_DATA_UPDATE_ID]";
            // Make the request
            OfflineUserDataJob response = offlineUserDataJobServiceClient.GetOfflineUserDataJob(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetOfflineUserDataJobAsync</summary>
        public async Task GetOfflineUserDataJobAsync()
        {
            // Snippet: GetOfflineUserDataJobAsync(string, CallSettings)
            // Additional: GetOfflineUserDataJobAsync(string, CancellationToken)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = await OfflineUserDataJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/offlineUserDataJobs/[OFFLINE_USER_DATA_UPDATE_ID]";
            // Make the request
            OfflineUserDataJob response = await offlineUserDataJobServiceClient.GetOfflineUserDataJobAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetOfflineUserDataJob</summary>
        public void GetOfflineUserDataJobResourceNames()
        {
            // Snippet: GetOfflineUserDataJob(OfflineUserDataJobName, CallSettings)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = OfflineUserDataJobServiceClient.Create();
            // Initialize request argument(s)
            OfflineUserDataJobName resourceName = OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]");
            // Make the request
            OfflineUserDataJob response = offlineUserDataJobServiceClient.GetOfflineUserDataJob(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetOfflineUserDataJobAsync</summary>
        public async Task GetOfflineUserDataJobResourceNamesAsync()
        {
            // Snippet: GetOfflineUserDataJobAsync(OfflineUserDataJobName, CallSettings)
            // Additional: GetOfflineUserDataJobAsync(OfflineUserDataJobName, CancellationToken)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = await OfflineUserDataJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            OfflineUserDataJobName resourceName = OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]");
            // Make the request
            OfflineUserDataJob response = await offlineUserDataJobServiceClient.GetOfflineUserDataJobAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for AddOfflineUserDataJobOperations</summary>
        public void AddOfflineUserDataJobOperationsRequestObject()
        {
            // Snippet: AddOfflineUserDataJobOperations(AddOfflineUserDataJobOperationsRequest, CallSettings)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = OfflineUserDataJobServiceClient.Create();
            // Initialize request argument(s)
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Operations =
                {
                    new OfflineUserDataJobOperation(),
                },
                EnablePartialFailure = false,
            };
            // Make the request
            AddOfflineUserDataJobOperationsResponse response = offlineUserDataJobServiceClient.AddOfflineUserDataJobOperations(request);
            // End snippet
        }

        /// <summary>Snippet for AddOfflineUserDataJobOperationsAsync</summary>
        public async Task AddOfflineUserDataJobOperationsRequestObjectAsync()
        {
            // Snippet: AddOfflineUserDataJobOperationsAsync(AddOfflineUserDataJobOperationsRequest, CallSettings)
            // Additional: AddOfflineUserDataJobOperationsAsync(AddOfflineUserDataJobOperationsRequest, CancellationToken)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = await OfflineUserDataJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Operations =
                {
                    new OfflineUserDataJobOperation(),
                },
                EnablePartialFailure = false,
            };
            // Make the request
            AddOfflineUserDataJobOperationsResponse response = await offlineUserDataJobServiceClient.AddOfflineUserDataJobOperationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddOfflineUserDataJobOperations</summary>
        public void AddOfflineUserDataJobOperations()
        {
            // Snippet: AddOfflineUserDataJobOperations(string, IEnumerable<OfflineUserDataJobOperation>, CallSettings)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = OfflineUserDataJobServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/offlineUserDataJobs/[OFFLINE_USER_DATA_UPDATE_ID]";
            IEnumerable<OfflineUserDataJobOperation> operations = new OfflineUserDataJobOperation[]
            {
                new OfflineUserDataJobOperation(),
            };
            // Make the request
            AddOfflineUserDataJobOperationsResponse response = offlineUserDataJobServiceClient.AddOfflineUserDataJobOperations(resourceName, operations);
            // End snippet
        }

        /// <summary>Snippet for AddOfflineUserDataJobOperationsAsync</summary>
        public async Task AddOfflineUserDataJobOperationsAsync()
        {
            // Snippet: AddOfflineUserDataJobOperationsAsync(string, IEnumerable<OfflineUserDataJobOperation>, CallSettings)
            // Additional: AddOfflineUserDataJobOperationsAsync(string, IEnumerable<OfflineUserDataJobOperation>, CancellationToken)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = await OfflineUserDataJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/offlineUserDataJobs/[OFFLINE_USER_DATA_UPDATE_ID]";
            IEnumerable<OfflineUserDataJobOperation> operations = new OfflineUserDataJobOperation[]
            {
                new OfflineUserDataJobOperation(),
            };
            // Make the request
            AddOfflineUserDataJobOperationsResponse response = await offlineUserDataJobServiceClient.AddOfflineUserDataJobOperationsAsync(resourceName, operations);
            // End snippet
        }

        /// <summary>Snippet for AddOfflineUserDataJobOperations</summary>
        public void AddOfflineUserDataJobOperationsResourceNames()
        {
            // Snippet: AddOfflineUserDataJobOperations(OfflineUserDataJobName, IEnumerable<OfflineUserDataJobOperation>, CallSettings)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = OfflineUserDataJobServiceClient.Create();
            // Initialize request argument(s)
            OfflineUserDataJobName resourceName = OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]");
            IEnumerable<OfflineUserDataJobOperation> operations = new OfflineUserDataJobOperation[]
            {
                new OfflineUserDataJobOperation(),
            };
            // Make the request
            AddOfflineUserDataJobOperationsResponse response = offlineUserDataJobServiceClient.AddOfflineUserDataJobOperations(resourceName, operations);
            // End snippet
        }

        /// <summary>Snippet for AddOfflineUserDataJobOperationsAsync</summary>
        public async Task AddOfflineUserDataJobOperationsResourceNamesAsync()
        {
            // Snippet: AddOfflineUserDataJobOperationsAsync(OfflineUserDataJobName, IEnumerable<OfflineUserDataJobOperation>, CallSettings)
            // Additional: AddOfflineUserDataJobOperationsAsync(OfflineUserDataJobName, IEnumerable<OfflineUserDataJobOperation>, CancellationToken)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = await OfflineUserDataJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            OfflineUserDataJobName resourceName = OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]");
            IEnumerable<OfflineUserDataJobOperation> operations = new OfflineUserDataJobOperation[]
            {
                new OfflineUserDataJobOperation(),
            };
            // Make the request
            AddOfflineUserDataJobOperationsResponse response = await offlineUserDataJobServiceClient.AddOfflineUserDataJobOperationsAsync(resourceName, operations);
            // End snippet
        }

        /// <summary>Snippet for RunOfflineUserDataJob</summary>
        public void RunOfflineUserDataJobRequestObject()
        {
            // Snippet: RunOfflineUserDataJob(RunOfflineUserDataJobRequest, CallSettings)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = OfflineUserDataJobServiceClient.Create();
            // Initialize request argument(s)
            RunOfflineUserDataJobRequest request = new RunOfflineUserDataJobRequest
            {
                ResourceNameAsOfflineUserDataJobName = OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
            };
            // Make the request
            Operation<Empty, Empty> response = offlineUserDataJobServiceClient.RunOfflineUserDataJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Empty> retrievedResponse = offlineUserDataJobServiceClient.PollOnceRunOfflineUserDataJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunOfflineUserDataJobAsync</summary>
        public async Task RunOfflineUserDataJobRequestObjectAsync()
        {
            // Snippet: RunOfflineUserDataJobAsync(RunOfflineUserDataJobRequest, CallSettings)
            // Additional: RunOfflineUserDataJobAsync(RunOfflineUserDataJobRequest, CancellationToken)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = await OfflineUserDataJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunOfflineUserDataJobRequest request = new RunOfflineUserDataJobRequest
            {
                ResourceNameAsOfflineUserDataJobName = OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
            };
            // Make the request
            Operation<Empty, Empty> response = await offlineUserDataJobServiceClient.RunOfflineUserDataJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Empty> retrievedResponse = await offlineUserDataJobServiceClient.PollOnceRunOfflineUserDataJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunOfflineUserDataJob</summary>
        public void RunOfflineUserDataJob()
        {
            // Snippet: RunOfflineUserDataJob(string, CallSettings)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = OfflineUserDataJobServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/offlineUserDataJobs/[OFFLINE_USER_DATA_UPDATE_ID]";
            // Make the request
            Operation<Empty, Empty> response = offlineUserDataJobServiceClient.RunOfflineUserDataJob(resourceName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Empty> retrievedResponse = offlineUserDataJobServiceClient.PollOnceRunOfflineUserDataJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunOfflineUserDataJobAsync</summary>
        public async Task RunOfflineUserDataJobAsync()
        {
            // Snippet: RunOfflineUserDataJobAsync(string, CallSettings)
            // Additional: RunOfflineUserDataJobAsync(string, CancellationToken)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = await OfflineUserDataJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/offlineUserDataJobs/[OFFLINE_USER_DATA_UPDATE_ID]";
            // Make the request
            Operation<Empty, Empty> response = await offlineUserDataJobServiceClient.RunOfflineUserDataJobAsync(resourceName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Empty> retrievedResponse = await offlineUserDataJobServiceClient.PollOnceRunOfflineUserDataJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunOfflineUserDataJob</summary>
        public void RunOfflineUserDataJobResourceNames()
        {
            // Snippet: RunOfflineUserDataJob(OfflineUserDataJobName, CallSettings)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = OfflineUserDataJobServiceClient.Create();
            // Initialize request argument(s)
            OfflineUserDataJobName resourceName = OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]");
            // Make the request
            Operation<Empty, Empty> response = offlineUserDataJobServiceClient.RunOfflineUserDataJob(resourceName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Empty> retrievedResponse = offlineUserDataJobServiceClient.PollOnceRunOfflineUserDataJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunOfflineUserDataJobAsync</summary>
        public async Task RunOfflineUserDataJobResourceNamesAsync()
        {
            // Snippet: RunOfflineUserDataJobAsync(OfflineUserDataJobName, CallSettings)
            // Additional: RunOfflineUserDataJobAsync(OfflineUserDataJobName, CancellationToken)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = await OfflineUserDataJobServiceClient.CreateAsync();
            // Initialize request argument(s)
            OfflineUserDataJobName resourceName = OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]");
            // Make the request
            Operation<Empty, Empty> response = await offlineUserDataJobServiceClient.RunOfflineUserDataJobAsync(resourceName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Empty> retrievedResponse = await offlineUserDataJobServiceClient.PollOnceRunOfflineUserDataJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
