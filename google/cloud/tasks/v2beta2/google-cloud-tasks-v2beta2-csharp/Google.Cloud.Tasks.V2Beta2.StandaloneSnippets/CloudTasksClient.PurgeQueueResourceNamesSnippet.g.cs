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
    public sealed partial class GeneratedCloudTasksClientStandaloneSnippets
    {
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
    }
}
