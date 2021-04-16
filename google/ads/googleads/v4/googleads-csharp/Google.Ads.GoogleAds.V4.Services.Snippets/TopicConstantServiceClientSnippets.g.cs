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

namespace Google.Ads.GoogleAds.V4.Services.Snippets
{
    using Google.Ads.GoogleAds.V4.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedTopicConstantServiceClientSnippets
    {
        /// <summary>Snippet for GetTopicConstant</summary>
        public void GetTopicConstantRequestObject()
        {
            // Snippet: GetTopicConstant(GetTopicConstantRequest, CallSettings)
            // Create client
            TopicConstantServiceClient topicConstantServiceClient = TopicConstantServiceClient.Create();
            // Initialize request argument(s)
            GetTopicConstantRequest request = new GetTopicConstantRequest
            {
                ResourceNameAsTopicConstantName = TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
            };
            // Make the request
            TopicConstant response = topicConstantServiceClient.GetTopicConstant(request);
            // End snippet
        }

        /// <summary>Snippet for GetTopicConstantAsync</summary>
        public async Task GetTopicConstantRequestObjectAsync()
        {
            // Snippet: GetTopicConstantAsync(GetTopicConstantRequest, CallSettings)
            // Additional: GetTopicConstantAsync(GetTopicConstantRequest, CancellationToken)
            // Create client
            TopicConstantServiceClient topicConstantServiceClient = await TopicConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTopicConstantRequest request = new GetTopicConstantRequest
            {
                ResourceNameAsTopicConstantName = TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
            };
            // Make the request
            TopicConstant response = await topicConstantServiceClient.GetTopicConstantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTopicConstant</summary>
        public void GetTopicConstant()
        {
            // Snippet: GetTopicConstant(string, CallSettings)
            // Create client
            TopicConstantServiceClient topicConstantServiceClient = TopicConstantServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "topicConstants/[TOPIC_CONSTANT]";
            // Make the request
            TopicConstant response = topicConstantServiceClient.GetTopicConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetTopicConstantAsync</summary>
        public async Task GetTopicConstantAsync()
        {
            // Snippet: GetTopicConstantAsync(string, CallSettings)
            // Additional: GetTopicConstantAsync(string, CancellationToken)
            // Create client
            TopicConstantServiceClient topicConstantServiceClient = await TopicConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "topicConstants/[TOPIC_CONSTANT]";
            // Make the request
            TopicConstant response = await topicConstantServiceClient.GetTopicConstantAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetTopicConstant</summary>
        public void GetTopicConstantResourceNames()
        {
            // Snippet: GetTopicConstant(TopicConstantName, CallSettings)
            // Create client
            TopicConstantServiceClient topicConstantServiceClient = TopicConstantServiceClient.Create();
            // Initialize request argument(s)
            TopicConstantName resourceName = TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]");
            // Make the request
            TopicConstant response = topicConstantServiceClient.GetTopicConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetTopicConstantAsync</summary>
        public async Task GetTopicConstantResourceNamesAsync()
        {
            // Snippet: GetTopicConstantAsync(TopicConstantName, CallSettings)
            // Additional: GetTopicConstantAsync(TopicConstantName, CancellationToken)
            // Create client
            TopicConstantServiceClient topicConstantServiceClient = await TopicConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            TopicConstantName resourceName = TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]");
            // Make the request
            TopicConstant response = await topicConstantServiceClient.GetTopicConstantAsync(resourceName);
            // End snippet
        }
    }
}
