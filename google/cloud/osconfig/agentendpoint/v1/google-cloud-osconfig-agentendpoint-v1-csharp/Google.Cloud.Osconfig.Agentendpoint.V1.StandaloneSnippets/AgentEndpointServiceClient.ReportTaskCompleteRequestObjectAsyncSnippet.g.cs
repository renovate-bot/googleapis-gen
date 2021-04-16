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
    using System.Threading.Tasks;

    public sealed partial class GeneratedAgentEndpointServiceClientStandaloneSnippets
    {
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
                ExecStepTaskOutput = new ExecStepTaskOutput(),
                ApplyConfigTaskOutput = new ApplyConfigTaskOutput(),
            };
            // Make the request
            ReportTaskCompleteResponse response = await agentEndpointServiceClient.ReportTaskCompleteAsync(request);
            // End snippet
        }
    }
}
