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

namespace Google.Cloud.PubSubLite.V1.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedTopicStatsServiceClientSnippets
    {
        /// <summary>Snippet for ComputeMessageStats</summary>
        public void ComputeMessageStatsRequestObject()
        {
            // Snippet: ComputeMessageStats(ComputeMessageStatsRequest, CallSettings)
            // Create client
            TopicStatsServiceClient topicStatsServiceClient = TopicStatsServiceClient.Create();
            // Initialize request argument(s)
            ComputeMessageStatsRequest request = new ComputeMessageStatsRequest
            {
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                Partition = 0L,
                StartCursor = new Cursor(),
                EndCursor = new Cursor(),
            };
            // Make the request
            ComputeMessageStatsResponse response = topicStatsServiceClient.ComputeMessageStats(request);
            // End snippet
        }

        /// <summary>Snippet for ComputeMessageStatsAsync</summary>
        public async Task ComputeMessageStatsRequestObjectAsync()
        {
            // Snippet: ComputeMessageStatsAsync(ComputeMessageStatsRequest, CallSettings)
            // Additional: ComputeMessageStatsAsync(ComputeMessageStatsRequest, CancellationToken)
            // Create client
            TopicStatsServiceClient topicStatsServiceClient = await TopicStatsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ComputeMessageStatsRequest request = new ComputeMessageStatsRequest
            {
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                Partition = 0L,
                StartCursor = new Cursor(),
                EndCursor = new Cursor(),
            };
            // Make the request
            ComputeMessageStatsResponse response = await topicStatsServiceClient.ComputeMessageStatsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ComputeHeadCursor</summary>
        public void ComputeHeadCursorRequestObject()
        {
            // Snippet: ComputeHeadCursor(ComputeHeadCursorRequest, CallSettings)
            // Create client
            TopicStatsServiceClient topicStatsServiceClient = TopicStatsServiceClient.Create();
            // Initialize request argument(s)
            ComputeHeadCursorRequest request = new ComputeHeadCursorRequest
            {
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                Partition = 0L,
            };
            // Make the request
            ComputeHeadCursorResponse response = topicStatsServiceClient.ComputeHeadCursor(request);
            // End snippet
        }

        /// <summary>Snippet for ComputeHeadCursorAsync</summary>
        public async Task ComputeHeadCursorRequestObjectAsync()
        {
            // Snippet: ComputeHeadCursorAsync(ComputeHeadCursorRequest, CallSettings)
            // Additional: ComputeHeadCursorAsync(ComputeHeadCursorRequest, CancellationToken)
            // Create client
            TopicStatsServiceClient topicStatsServiceClient = await TopicStatsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ComputeHeadCursorRequest request = new ComputeHeadCursorRequest
            {
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                Partition = 0L,
            };
            // Make the request
            ComputeHeadCursorResponse response = await topicStatsServiceClient.ComputeHeadCursorAsync(request);
            // End snippet
        }
    }
}
