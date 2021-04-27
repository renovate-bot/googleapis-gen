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
    public sealed partial class GeneratedTopicStatsServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for ComputeTimeCursor</summary>
        public void ComputeTimeCursorRequestObject()
        {
            // Snippet: ComputeTimeCursor(ComputeTimeCursorRequest, CallSettings)
            // Create client
            TopicStatsServiceClient topicStatsServiceClient = TopicStatsServiceClient.Create();
            // Initialize request argument(s)
            ComputeTimeCursorRequest request = new ComputeTimeCursorRequest
            {
                TopicAsTopicName = TopicName.FromProjectLocationTopic("[PROJECT]", "[LOCATION]", "[TOPIC]"),
                Partition = 0L,
                Target = new TimeTarget(),
            };
            // Make the request
            ComputeTimeCursorResponse response = topicStatsServiceClient.ComputeTimeCursor(request);
            // End snippet
        }
    }
}
