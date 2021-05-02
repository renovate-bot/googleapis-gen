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
    using Google.Ads.GoogleAds.V7.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedFeedPlaceholderViewServiceClientSnippets
    {
        /// <summary>Snippet for GetFeedPlaceholderView</summary>
        public void GetFeedPlaceholderViewRequestObject()
        {
            // Snippet: GetFeedPlaceholderView(GetFeedPlaceholderViewRequest, CallSettings)
            // Create client
            FeedPlaceholderViewServiceClient feedPlaceholderViewServiceClient = FeedPlaceholderViewServiceClient.Create();
            // Initialize request argument(s)
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]"),
            };
            // Make the request
            FeedPlaceholderView response = feedPlaceholderViewServiceClient.GetFeedPlaceholderView(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedPlaceholderViewAsync</summary>
        public async Task GetFeedPlaceholderViewRequestObjectAsync()
        {
            // Snippet: GetFeedPlaceholderViewAsync(GetFeedPlaceholderViewRequest, CallSettings)
            // Additional: GetFeedPlaceholderViewAsync(GetFeedPlaceholderViewRequest, CancellationToken)
            // Create client
            FeedPlaceholderViewServiceClient feedPlaceholderViewServiceClient = await FeedPlaceholderViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]"),
            };
            // Make the request
            FeedPlaceholderView response = await feedPlaceholderViewServiceClient.GetFeedPlaceholderViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedPlaceholderView</summary>
        public void GetFeedPlaceholderView()
        {
            // Snippet: GetFeedPlaceholderView(string, CallSettings)
            // Create client
            FeedPlaceholderViewServiceClient feedPlaceholderViewServiceClient = FeedPlaceholderViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/feedPlaceholderViews/[PLACEHOLDER_TYPE]";
            // Make the request
            FeedPlaceholderView response = feedPlaceholderViewServiceClient.GetFeedPlaceholderView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedPlaceholderViewAsync</summary>
        public async Task GetFeedPlaceholderViewAsync()
        {
            // Snippet: GetFeedPlaceholderViewAsync(string, CallSettings)
            // Additional: GetFeedPlaceholderViewAsync(string, CancellationToken)
            // Create client
            FeedPlaceholderViewServiceClient feedPlaceholderViewServiceClient = await FeedPlaceholderViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/feedPlaceholderViews/[PLACEHOLDER_TYPE]";
            // Make the request
            FeedPlaceholderView response = await feedPlaceholderViewServiceClient.GetFeedPlaceholderViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedPlaceholderView</summary>
        public void GetFeedPlaceholderViewResourceNames()
        {
            // Snippet: GetFeedPlaceholderView(FeedPlaceholderViewName, CallSettings)
            // Create client
            FeedPlaceholderViewServiceClient feedPlaceholderViewServiceClient = FeedPlaceholderViewServiceClient.Create();
            // Initialize request argument(s)
            FeedPlaceholderViewName resourceName = FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]");
            // Make the request
            FeedPlaceholderView response = feedPlaceholderViewServiceClient.GetFeedPlaceholderView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedPlaceholderViewAsync</summary>
        public async Task GetFeedPlaceholderViewResourceNamesAsync()
        {
            // Snippet: GetFeedPlaceholderViewAsync(FeedPlaceholderViewName, CallSettings)
            // Additional: GetFeedPlaceholderViewAsync(FeedPlaceholderViewName, CancellationToken)
            // Create client
            FeedPlaceholderViewServiceClient feedPlaceholderViewServiceClient = await FeedPlaceholderViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedPlaceholderViewName resourceName = FeedPlaceholderViewName.FromCustomerPlaceholderType("[CUSTOMER_ID]", "[PLACEHOLDER_TYPE]");
            // Make the request
            FeedPlaceholderView response = await feedPlaceholderViewServiceClient.GetFeedPlaceholderViewAsync(resourceName);
            // End snippet
        }
    }
}
