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

namespace Google.Cloud.Osconfig.Agentendpoint.V1.Snippets
{
    using Google.Api.Gax.Grpc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAgentEndpointServiceClientSnippets
    {
        /// <summary>Snippet for ReceiveTaskNotification</summary>
        public async Task ReceiveTaskNotificationRequestObject()
        {
            // Snippet: ReceiveTaskNotification(ReceiveTaskNotificationRequest, CallSettings)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = AgentEndpointServiceClient.Create();
            // Initialize request argument(s)
            ReceiveTaskNotificationRequest request = new ReceiveTaskNotificationRequest
            {
                InstanceIdToken = "",
                AgentVersion = "",
            };
            // Make the request, returning a streaming response
            AgentEndpointServiceClient.ReceiveTaskNotificationStream response = agentEndpointServiceClient.ReceiveTaskNotification(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReceiveTaskNotificationResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReceiveTaskNotificationResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReceiveTaskNotification</summary>
        public async Task ReceiveTaskNotification()
        {
            // Snippet: ReceiveTaskNotification(string, string, CallSettings)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = AgentEndpointServiceClient.Create();
            // Initialize request argument(s)
            string instanceIdToken = "";
            string agentVersion = "";
            // Make the request, returning a streaming response
            AgentEndpointServiceClient.ReceiveTaskNotificationStream response = agentEndpointServiceClient.ReceiveTaskNotification(instanceIdToken, agentVersion);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReceiveTaskNotificationResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReceiveTaskNotificationResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for StartNextTask</summary>
        public void StartNextTaskRequestObject()
        {
            // Snippet: StartNextTask(StartNextTaskRequest, CallSettings)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = AgentEndpointServiceClient.Create();
            // Initialize request argument(s)
            StartNextTaskRequest request = new StartNextTaskRequest
            {
                InstanceIdToken = "",
            };
            // Make the request
            StartNextTaskResponse response = agentEndpointServiceClient.StartNextTask(request);
            // End snippet
        }

        /// <summary>Snippet for StartNextTaskAsync</summary>
        public async Task StartNextTaskRequestObjectAsync()
        {
            // Snippet: StartNextTaskAsync(StartNextTaskRequest, CallSettings)
            // Additional: StartNextTaskAsync(StartNextTaskRequest, CancellationToken)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = await AgentEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartNextTaskRequest request = new StartNextTaskRequest
            {
                InstanceIdToken = "",
            };
            // Make the request
            StartNextTaskResponse response = await agentEndpointServiceClient.StartNextTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartNextTask</summary>
        public void StartNextTask()
        {
            // Snippet: StartNextTask(string, CallSettings)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = AgentEndpointServiceClient.Create();
            // Initialize request argument(s)
            string instanceIdToken = "";
            // Make the request
            StartNextTaskResponse response = agentEndpointServiceClient.StartNextTask(instanceIdToken);
            // End snippet
        }

        /// <summary>Snippet for StartNextTaskAsync</summary>
        public async Task StartNextTaskAsync()
        {
            // Snippet: StartNextTaskAsync(string, CallSettings)
            // Additional: StartNextTaskAsync(string, CancellationToken)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = await AgentEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string instanceIdToken = "";
            // Make the request
            StartNextTaskResponse response = await agentEndpointServiceClient.StartNextTaskAsync(instanceIdToken);
            // End snippet
        }

        /// <summary>Snippet for ReportTaskProgress</summary>
        public void ReportTaskProgressRequestObject()
        {
            // Snippet: ReportTaskProgress(ReportTaskProgressRequest, CallSettings)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = AgentEndpointServiceClient.Create();
            // Initialize request argument(s)
            ReportTaskProgressRequest request = new ReportTaskProgressRequest
            {
                InstanceIdToken = "",
                TaskId = "",
                TaskType = TaskType.Unspecified,
                ApplyPatchesTaskProgress = new ApplyPatchesTaskProgress(),
            };
            // Make the request
            ReportTaskProgressResponse response = agentEndpointServiceClient.ReportTaskProgress(request);
            // End snippet
        }

        /// <summary>Snippet for ReportTaskProgressAsync</summary>
        public async Task ReportTaskProgressRequestObjectAsync()
        {
            // Snippet: ReportTaskProgressAsync(ReportTaskProgressRequest, CallSettings)
            // Additional: ReportTaskProgressAsync(ReportTaskProgressRequest, CancellationToken)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = await AgentEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReportTaskProgressRequest request = new ReportTaskProgressRequest
            {
                InstanceIdToken = "",
                TaskId = "",
                TaskType = TaskType.Unspecified,
                ApplyPatchesTaskProgress = new ApplyPatchesTaskProgress(),
            };
            // Make the request
            ReportTaskProgressResponse response = await agentEndpointServiceClient.ReportTaskProgressAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReportTaskProgress</summary>
        public void ReportTaskProgress()
        {
            // Snippet: ReportTaskProgress(string, string, TaskType, CallSettings)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = AgentEndpointServiceClient.Create();
            // Initialize request argument(s)
            string instanceIdToken = "";
            string taskId = "";
            TaskType taskType = TaskType.Unspecified;
            // Make the request
            ReportTaskProgressResponse response = agentEndpointServiceClient.ReportTaskProgress(instanceIdToken, taskId, taskType);
            // End snippet
        }

        /// <summary>Snippet for ReportTaskProgressAsync</summary>
        public async Task ReportTaskProgressAsync()
        {
            // Snippet: ReportTaskProgressAsync(string, string, TaskType, CallSettings)
            // Additional: ReportTaskProgressAsync(string, string, TaskType, CancellationToken)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = await AgentEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string instanceIdToken = "";
            string taskId = "";
            TaskType taskType = TaskType.Unspecified;
            // Make the request
            ReportTaskProgressResponse response = await agentEndpointServiceClient.ReportTaskProgressAsync(instanceIdToken, taskId, taskType);
            // End snippet
        }

        /// <summary>Snippet for ReportTaskComplete</summary>
        public void ReportTaskCompleteRequestObject()
        {
            // Snippet: ReportTaskComplete(ReportTaskCompleteRequest, CallSettings)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = AgentEndpointServiceClient.Create();
            // Initialize request argument(s)
            ReportTaskCompleteRequest request = new ReportTaskCompleteRequest
            {
                InstanceIdToken = "",
                TaskId = "",
                TaskType = TaskType.Unspecified,
                ErrorMessage = "",
                ApplyPatchesTaskOutput = new ApplyPatchesTaskOutput(),
            };
            // Make the request
            ReportTaskCompleteResponse response = agentEndpointServiceClient.ReportTaskComplete(request);
            // End snippet
        }

        /// <summary>Snippet for ReportTaskCompleteAsync</summary>
        public async Task ReportTaskCompleteRequestObjectAsync()
        {
            // Snippet: ReportTaskCompleteAsync(ReportTaskCompleteRequest, CallSettings)
            // Additional: ReportTaskCompleteAsync(ReportTaskCompleteRequest, CancellationToken)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = await AgentEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReportTaskCompleteRequest request = new ReportTaskCompleteRequest
            {
                InstanceIdToken = "",
                TaskId = "",
                TaskType = TaskType.Unspecified,
                ErrorMessage = "",
                ApplyPatchesTaskOutput = new ApplyPatchesTaskOutput(),
            };
            // Make the request
            ReportTaskCompleteResponse response = await agentEndpointServiceClient.ReportTaskCompleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReportTaskComplete</summary>
        public void ReportTaskComplete()
        {
            // Snippet: ReportTaskComplete(string, string, TaskType, string, CallSettings)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = AgentEndpointServiceClient.Create();
            // Initialize request argument(s)
            string instanceIdToken = "";
            string taskId = "";
            TaskType taskType = TaskType.Unspecified;
            string errorMessage = "";
            // Make the request
            ReportTaskCompleteResponse response = agentEndpointServiceClient.ReportTaskComplete(instanceIdToken, taskId, taskType, errorMessage);
            // End snippet
        }

        /// <summary>Snippet for ReportTaskCompleteAsync</summary>
        public async Task ReportTaskCompleteAsync()
        {
            // Snippet: ReportTaskCompleteAsync(string, string, TaskType, string, CallSettings)
            // Additional: ReportTaskCompleteAsync(string, string, TaskType, string, CancellationToken)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = await AgentEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string instanceIdToken = "";
            string taskId = "";
            TaskType taskType = TaskType.Unspecified;
            string errorMessage = "";
            // Make the request
            ReportTaskCompleteResponse response = await agentEndpointServiceClient.ReportTaskCompleteAsync(instanceIdToken, taskId, taskType, errorMessage);
            // End snippet
        }

        /// <summary>Snippet for RegisterAgent</summary>
        public void RegisterAgentRequestObject()
        {
            // Snippet: RegisterAgent(RegisterAgentRequest, CallSettings)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = AgentEndpointServiceClient.Create();
            // Initialize request argument(s)
            RegisterAgentRequest request = new RegisterAgentRequest
            {
                InstanceIdToken = "",
                AgentVersion = "",
                SupportedCapabilities = { "", },
                OsLongName = "",
                OsShortName = "",
                OsVersion = "",
                OsArchitecture = "",
            };
            // Make the request
            RegisterAgentResponse response = agentEndpointServiceClient.RegisterAgent(request);
            // End snippet
        }

        /// <summary>Snippet for RegisterAgentAsync</summary>
        public async Task RegisterAgentRequestObjectAsync()
        {
            // Snippet: RegisterAgentAsync(RegisterAgentRequest, CallSettings)
            // Additional: RegisterAgentAsync(RegisterAgentRequest, CancellationToken)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = await AgentEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            RegisterAgentRequest request = new RegisterAgentRequest
            {
                InstanceIdToken = "",
                AgentVersion = "",
                SupportedCapabilities = { "", },
                OsLongName = "",
                OsShortName = "",
                OsVersion = "",
                OsArchitecture = "",
            };
            // Make the request
            RegisterAgentResponse response = await agentEndpointServiceClient.RegisterAgentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RegisterAgent</summary>
        public void RegisterAgent()
        {
            // Snippet: RegisterAgent(string, string, IEnumerable<string>, CallSettings)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = AgentEndpointServiceClient.Create();
            // Initialize request argument(s)
            string instanceIdToken = "";
            string agentVersion = "";
            IEnumerable<string> supportedCapabilities = new string[] { "", };
            // Make the request
            RegisterAgentResponse response = agentEndpointServiceClient.RegisterAgent(instanceIdToken, agentVersion, supportedCapabilities);
            // End snippet
        }

        /// <summary>Snippet for RegisterAgentAsync</summary>
        public async Task RegisterAgentAsync()
        {
            // Snippet: RegisterAgentAsync(string, string, IEnumerable<string>, CallSettings)
            // Additional: RegisterAgentAsync(string, string, IEnumerable<string>, CancellationToken)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = await AgentEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string instanceIdToken = "";
            string agentVersion = "";
            IEnumerable<string> supportedCapabilities = new string[] { "", };
            // Make the request
            RegisterAgentResponse response = await agentEndpointServiceClient.RegisterAgentAsync(instanceIdToken, agentVersion, supportedCapabilities);
            // End snippet
        }

        /// <summary>Snippet for ReportInventory</summary>
        public void ReportInventoryRequestObject()
        {
            // Snippet: ReportInventory(ReportInventoryRequest, CallSettings)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = AgentEndpointServiceClient.Create();
            // Initialize request argument(s)
            ReportInventoryRequest request = new ReportInventoryRequest
            {
                InstanceIdToken = "",
                InventoryChecksum = "",
                Inventory = new Inventory(),
            };
            // Make the request
            ReportInventoryResponse response = agentEndpointServiceClient.ReportInventory(request);
            // End snippet
        }

        /// <summary>Snippet for ReportInventoryAsync</summary>
        public async Task ReportInventoryRequestObjectAsync()
        {
            // Snippet: ReportInventoryAsync(ReportInventoryRequest, CallSettings)
            // Additional: ReportInventoryAsync(ReportInventoryRequest, CancellationToken)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = await AgentEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReportInventoryRequest request = new ReportInventoryRequest
            {
                InstanceIdToken = "",
                InventoryChecksum = "",
                Inventory = new Inventory(),
            };
            // Make the request
            ReportInventoryResponse response = await agentEndpointServiceClient.ReportInventoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReportInventory</summary>
        public void ReportInventory()
        {
            // Snippet: ReportInventory(string, string, Inventory, CallSettings)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = AgentEndpointServiceClient.Create();
            // Initialize request argument(s)
            string instanceIdToken = "";
            string inventoryChecksum = "";
            Inventory inventory = new Inventory();
            // Make the request
            ReportInventoryResponse response = agentEndpointServiceClient.ReportInventory(instanceIdToken, inventoryChecksum, inventory);
            // End snippet
        }

        /// <summary>Snippet for ReportInventoryAsync</summary>
        public async Task ReportInventoryAsync()
        {
            // Snippet: ReportInventoryAsync(string, string, Inventory, CallSettings)
            // Additional: ReportInventoryAsync(string, string, Inventory, CancellationToken)
            // Create client
            AgentEndpointServiceClient agentEndpointServiceClient = await AgentEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string instanceIdToken = "";
            string inventoryChecksum = "";
            Inventory inventory = new Inventory();
            // Make the request
            ReportInventoryResponse response = await agentEndpointServiceClient.ReportInventoryAsync(instanceIdToken, inventoryChecksum, inventory);
            // End snippet
        }
    }
}
