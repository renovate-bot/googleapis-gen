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

namespace Google.Ads.GoogleAds.V9.Services.Snippets
{
    using Google.Ads.GoogleAds.V9.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedTopicViewServiceClientSnippets
    {
        /// <summary>Snippet for GetTopicView</summary>
        public void GetTopicViewRequestObject()
        {
            // Snippet: GetTopicView(GetTopicViewRequest, CallSettings)
            // Create client
            TopicViewServiceClient topicViewServiceClient = TopicViewServiceClient.Create();
            // Initialize request argument(s)
            GetTopicViewRequest request = new GetTopicViewRequest
            {
                ResourceNameAsTopicViewName = TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            TopicView response = topicViewServiceClient.GetTopicView(request);
            // End snippet
        }

        /// <summary>Snippet for GetTopicViewAsync</summary>
        public async Task GetTopicViewRequestObjectAsync()
        {
            // Snippet: GetTopicViewAsync(GetTopicViewRequest, CallSettings)
            // Additional: GetTopicViewAsync(GetTopicViewRequest, CancellationToken)
            // Create client
            TopicViewServiceClient topicViewServiceClient = await TopicViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTopicViewRequest request = new GetTopicViewRequest
            {
                ResourceNameAsTopicViewName = TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            TopicView response = await topicViewServiceClient.GetTopicViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTopicView</summary>
        public void GetTopicView()
        {
            // Snippet: GetTopicView(string, CallSettings)
            // Create client
            TopicViewServiceClient topicViewServiceClient = TopicViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/topicViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            TopicView response = topicViewServiceClient.GetTopicView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetTopicViewAsync</summary>
        public async Task GetTopicViewAsync()
        {
            // Snippet: GetTopicViewAsync(string, CallSettings)
            // Additional: GetTopicViewAsync(string, CancellationToken)
            // Create client
            TopicViewServiceClient topicViewServiceClient = await TopicViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/topicViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            TopicView response = await topicViewServiceClient.GetTopicViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetTopicView</summary>
        public void GetTopicViewResourceNames()
        {
            // Snippet: GetTopicView(TopicViewName, CallSettings)
            // Create client
            TopicViewServiceClient topicViewServiceClient = TopicViewServiceClient.Create();
            // Initialize request argument(s)
            TopicViewName resourceName = TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            TopicView response = topicViewServiceClient.GetTopicView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetTopicViewAsync</summary>
        public async Task GetTopicViewResourceNamesAsync()
        {
            // Snippet: GetTopicViewAsync(TopicViewName, CallSettings)
            // Additional: GetTopicViewAsync(TopicViewName, CancellationToken)
            // Create client
            TopicViewServiceClient topicViewServiceClient = await TopicViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            TopicViewName resourceName = TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            TopicView response = await topicViewServiceClient.GetTopicViewAsync(resourceName);
            // End snippet
        }
    }
}
