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
    using System.Threading.Tasks;

    public sealed partial class GeneratedAgentEndpointServiceClientStandaloneSnippets
    {
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
    }
}
