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

namespace Google.Home.Graph.V1.Snippets
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedHomeGraphApiServiceClientSnippets
    {
        /// <summary>Snippet for RequestSyncDevices</summary>
        public void RequestSyncDevicesRequestObject()
        {
            // Snippet: RequestSyncDevices(RequestSyncDevicesRequest, CallSettings)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.Create();
            // Initialize request argument(s)
            RequestSyncDevicesRequest request = new RequestSyncDevicesRequest
            {
                AgentUserId = "",
                Async = false,
            };
            // Make the request
            RequestSyncDevicesResponse response = homeGraphApiServiceClient.RequestSyncDevices(request);
            // End snippet
        }

        /// <summary>Snippet for RequestSyncDevicesAsync</summary>
        public async Task RequestSyncDevicesRequestObjectAsync()
        {
            // Snippet: RequestSyncDevicesAsync(RequestSyncDevicesRequest, CallSettings)
            // Additional: RequestSyncDevicesAsync(RequestSyncDevicesRequest, CancellationToken)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = await HomeGraphApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            RequestSyncDevicesRequest request = new RequestSyncDevicesRequest
            {
                AgentUserId = "",
                Async = false,
            };
            // Make the request
            RequestSyncDevicesResponse response = await homeGraphApiServiceClient.RequestSyncDevicesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RequestSyncDevices</summary>
        public void RequestSyncDevices()
        {
            // Snippet: RequestSyncDevices(string, CallSettings)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.Create();
            // Initialize request argument(s)
            string agentUserId = "";
            // Make the request
            RequestSyncDevicesResponse response = homeGraphApiServiceClient.RequestSyncDevices(agentUserId);
            // End snippet
        }

        /// <summary>Snippet for RequestSyncDevicesAsync</summary>
        public async Task RequestSyncDevicesAsync()
        {
            // Snippet: RequestSyncDevicesAsync(string, CallSettings)
            // Additional: RequestSyncDevicesAsync(string, CancellationToken)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = await HomeGraphApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            string agentUserId = "";
            // Make the request
            RequestSyncDevicesResponse response = await homeGraphApiServiceClient.RequestSyncDevicesAsync(agentUserId);
            // End snippet
        }

        /// <summary>Snippet for ReportStateAndNotification</summary>
        public void ReportStateAndNotificationRequestObject()
        {
            // Snippet: ReportStateAndNotification(ReportStateAndNotificationRequest, CallSettings)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.Create();
            // Initialize request argument(s)
            ReportStateAndNotificationRequest request = new ReportStateAndNotificationRequest
            {
                RequestId = "",
                AgentUserId = "",
                Payload = new StateAndNotificationPayload(),
                EventId = "",
            };
            // Make the request
            ReportStateAndNotificationResponse response = homeGraphApiServiceClient.ReportStateAndNotification(request);
            // End snippet
        }

        /// <summary>Snippet for ReportStateAndNotificationAsync</summary>
        public async Task ReportStateAndNotificationRequestObjectAsync()
        {
            // Snippet: ReportStateAndNotificationAsync(ReportStateAndNotificationRequest, CallSettings)
            // Additional: ReportStateAndNotificationAsync(ReportStateAndNotificationRequest, CancellationToken)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = await HomeGraphApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReportStateAndNotificationRequest request = new ReportStateAndNotificationRequest
            {
                RequestId = "",
                AgentUserId = "",
                Payload = new StateAndNotificationPayload(),
                EventId = "",
            };
            // Make the request
            ReportStateAndNotificationResponse response = await homeGraphApiServiceClient.ReportStateAndNotificationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReportStateAndNotification</summary>
        public void ReportStateAndNotification()
        {
            // Snippet: ReportStateAndNotification(string, string, string, StateAndNotificationPayload, CallSettings)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.Create();
            // Initialize request argument(s)
            string requestId = "";
            string eventId = "";
            string agentUserId = "";
            StateAndNotificationPayload payload = new StateAndNotificationPayload();
            // Make the request
            ReportStateAndNotificationResponse response = homeGraphApiServiceClient.ReportStateAndNotification(requestId, eventId, agentUserId, payload);
            // End snippet
        }

        /// <summary>Snippet for ReportStateAndNotificationAsync</summary>
        public async Task ReportStateAndNotificationAsync()
        {
            // Snippet: ReportStateAndNotificationAsync(string, string, string, StateAndNotificationPayload, CallSettings)
            // Additional: ReportStateAndNotificationAsync(string, string, string, StateAndNotificationPayload, CancellationToken)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = await HomeGraphApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            string requestId = "";
            string eventId = "";
            string agentUserId = "";
            StateAndNotificationPayload payload = new StateAndNotificationPayload();
            // Make the request
            ReportStateAndNotificationResponse response = await homeGraphApiServiceClient.ReportStateAndNotificationAsync(requestId, eventId, agentUserId, payload);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentUser</summary>
        public void DeleteAgentUserRequestObject()
        {
            // Snippet: DeleteAgentUser(DeleteAgentUserRequest, CallSettings)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.Create();
            // Initialize request argument(s)
            DeleteAgentUserRequest request = new DeleteAgentUserRequest
            {
                RequestId = "",
                AgentUserIdAsAgentUserPathName = AgentUserPathName.FromAgentUserPath("[AGENT_USER_PATH]"),
            };
            // Make the request
            homeGraphApiServiceClient.DeleteAgentUser(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentUserAsync</summary>
        public async Task DeleteAgentUserRequestObjectAsync()
        {
            // Snippet: DeleteAgentUserAsync(DeleteAgentUserRequest, CallSettings)
            // Additional: DeleteAgentUserAsync(DeleteAgentUserRequest, CancellationToken)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = await HomeGraphApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAgentUserRequest request = new DeleteAgentUserRequest
            {
                RequestId = "",
                AgentUserIdAsAgentUserPathName = AgentUserPathName.FromAgentUserPath("[AGENT_USER_PATH]"),
            };
            // Make the request
            await homeGraphApiServiceClient.DeleteAgentUserAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentUser</summary>
        public void DeleteAgentUser()
        {
            // Snippet: DeleteAgentUser(string, string, CallSettings)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.Create();
            // Initialize request argument(s)
            string requestId = "";
            string agentUserId = "agentUsers/[AGENT_USER_PATH]";
            // Make the request
            homeGraphApiServiceClient.DeleteAgentUser(requestId, agentUserId);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentUserAsync</summary>
        public async Task DeleteAgentUserAsync()
        {
            // Snippet: DeleteAgentUserAsync(string, string, CallSettings)
            // Additional: DeleteAgentUserAsync(string, string, CancellationToken)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = await HomeGraphApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            string requestId = "";
            string agentUserId = "agentUsers/[AGENT_USER_PATH]";
            // Make the request
            await homeGraphApiServiceClient.DeleteAgentUserAsync(requestId, agentUserId);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentUser</summary>
        public void DeleteAgentUserResourceNames()
        {
            // Snippet: DeleteAgentUser(string, AgentUserPathName, CallSettings)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.Create();
            // Initialize request argument(s)
            string requestId = "";
            AgentUserPathName agentUserId = AgentUserPathName.FromAgentUserPath("[AGENT_USER_PATH]");
            // Make the request
            homeGraphApiServiceClient.DeleteAgentUser(requestId, agentUserId);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentUserAsync</summary>
        public async Task DeleteAgentUserResourceNamesAsync()
        {
            // Snippet: DeleteAgentUserAsync(string, AgentUserPathName, CallSettings)
            // Additional: DeleteAgentUserAsync(string, AgentUserPathName, CancellationToken)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = await HomeGraphApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            string requestId = "";
            AgentUserPathName agentUserId = AgentUserPathName.FromAgentUserPath("[AGENT_USER_PATH]");
            // Make the request
            await homeGraphApiServiceClient.DeleteAgentUserAsync(requestId, agentUserId);
            // End snippet
        }

        /// <summary>Snippet for Query</summary>
        public void QueryRequestObject()
        {
            // Snippet: Query(QueryRequest, CallSettings)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.Create();
            // Initialize request argument(s)
            QueryRequest request = new QueryRequest
            {
                RequestId = "",
                AgentUserId = "",
                Inputs =
                {
                    new QueryRequestInput(),
                },
            };
            // Make the request
            QueryResponse response = homeGraphApiServiceClient.Query(request);
            // End snippet
        }

        /// <summary>Snippet for QueryAsync</summary>
        public async Task QueryRequestObjectAsync()
        {
            // Snippet: QueryAsync(QueryRequest, CallSettings)
            // Additional: QueryAsync(QueryRequest, CancellationToken)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = await HomeGraphApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryRequest request = new QueryRequest
            {
                RequestId = "",
                AgentUserId = "",
                Inputs =
                {
                    new QueryRequestInput(),
                },
            };
            // Make the request
            QueryResponse response = await homeGraphApiServiceClient.QueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Query</summary>
        public void Query()
        {
            // Snippet: Query(string, string, IEnumerable<QueryRequestInput>, CallSettings)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.Create();
            // Initialize request argument(s)
            string requestId = "";
            string agentUserId = "";
            IEnumerable<QueryRequestInput> inputs = new QueryRequestInput[]
            {
                new QueryRequestInput(),
            };
            // Make the request
            QueryResponse response = homeGraphApiServiceClient.Query(requestId, agentUserId, inputs);
            // End snippet
        }

        /// <summary>Snippet for QueryAsync</summary>
        public async Task QueryAsync()
        {
            // Snippet: QueryAsync(string, string, IEnumerable<QueryRequestInput>, CallSettings)
            // Additional: QueryAsync(string, string, IEnumerable<QueryRequestInput>, CancellationToken)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = await HomeGraphApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            string requestId = "";
            string agentUserId = "";
            IEnumerable<QueryRequestInput> inputs = new QueryRequestInput[]
            {
                new QueryRequestInput(),
            };
            // Make the request
            QueryResponse response = await homeGraphApiServiceClient.QueryAsync(requestId, agentUserId, inputs);
            // End snippet
        }

        /// <summary>Snippet for Sync</summary>
        public void SyncRequestObject()
        {
            // Snippet: Sync(SyncRequest, CallSettings)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.Create();
            // Initialize request argument(s)
            SyncRequest request = new SyncRequest
            {
                RequestId = "",
                AgentUserId = "",
            };
            // Make the request
            SyncResponse response = homeGraphApiServiceClient.Sync(request);
            // End snippet
        }

        /// <summary>Snippet for SyncAsync</summary>
        public async Task SyncRequestObjectAsync()
        {
            // Snippet: SyncAsync(SyncRequest, CallSettings)
            // Additional: SyncAsync(SyncRequest, CancellationToken)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = await HomeGraphApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            SyncRequest request = new SyncRequest
            {
                RequestId = "",
                AgentUserId = "",
            };
            // Make the request
            SyncResponse response = await homeGraphApiServiceClient.SyncAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Sync</summary>
        public void Sync()
        {
            // Snippet: Sync(string, string, CallSettings)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.Create();
            // Initialize request argument(s)
            string requestId = "";
            string agentUserId = "";
            // Make the request
            SyncResponse response = homeGraphApiServiceClient.Sync(requestId, agentUserId);
            // End snippet
        }

        /// <summary>Snippet for SyncAsync</summary>
        public async Task SyncAsync()
        {
            // Snippet: SyncAsync(string, string, CallSettings)
            // Additional: SyncAsync(string, string, CancellationToken)
            // Create client
            HomeGraphApiServiceClient homeGraphApiServiceClient = await HomeGraphApiServiceClient.CreateAsync();
            // Initialize request argument(s)
            string requestId = "";
            string agentUserId = "";
            // Make the request
            SyncResponse response = await homeGraphApiServiceClient.SyncAsync(requestId, agentUserId);
            // End snippet
        }
    }
}
