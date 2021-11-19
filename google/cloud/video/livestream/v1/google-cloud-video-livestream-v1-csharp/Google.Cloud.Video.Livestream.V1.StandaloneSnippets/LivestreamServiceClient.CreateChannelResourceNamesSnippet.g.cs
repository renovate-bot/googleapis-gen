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

namespace Google.Cloud.Video.Livestream.V1.Snippets
{
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Video.Livestream.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedLivestreamServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateChannel</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateChannelResourceNames()
        {
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Channel channel = new Channel();
            string channelId = "";
            // Make the request
            Operation<Channel, OperationMetadata> response = livestreamServiceClient.CreateChannel(parent, channel, channelId);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceCreateChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
        }
    }
}
