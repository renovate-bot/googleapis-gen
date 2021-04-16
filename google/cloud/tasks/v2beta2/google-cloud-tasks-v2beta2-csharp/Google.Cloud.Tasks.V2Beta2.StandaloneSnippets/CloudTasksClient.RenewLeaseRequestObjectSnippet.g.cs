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

    public sealed partial class GeneratedCloudTasksClientStandaloneSnippets
    {
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
                ResponseView = Task.Types.View.Unspecified,
            };
            // Make the request
            Task response = cloudTasksClient.RenewLease(request);
            // End snippet
        }
    }
}
