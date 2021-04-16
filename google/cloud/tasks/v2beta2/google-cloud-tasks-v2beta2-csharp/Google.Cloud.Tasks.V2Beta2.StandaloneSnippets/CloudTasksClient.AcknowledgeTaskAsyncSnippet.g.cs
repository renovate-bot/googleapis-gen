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
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCloudTasksClientStandaloneSnippets
    {
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
    }
}
