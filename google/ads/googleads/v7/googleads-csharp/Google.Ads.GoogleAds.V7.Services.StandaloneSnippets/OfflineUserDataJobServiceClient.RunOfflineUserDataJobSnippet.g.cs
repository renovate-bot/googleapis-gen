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

namespace Google.Ads.GoogleAds.V7.Services.Snippets
{
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedOfflineUserDataJobServiceClientStandaloneSnippets
    {
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
    }
}
