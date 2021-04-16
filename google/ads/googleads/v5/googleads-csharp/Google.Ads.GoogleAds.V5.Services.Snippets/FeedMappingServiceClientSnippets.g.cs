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

namespace Google.Ads.GoogleAds.V5.Services.Snippets
{
    using Google.Ads.GoogleAds.V5.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedFeedMappingServiceClientSnippets
    {
        /// <summary>Snippet for GetFeedMapping</summary>
        public void GetFeedMappingRequestObject()
        {
            // Snippet: GetFeedMapping(GetFeedMappingRequest, CallSettings)
            // Create client
            FeedMappingServiceClient feedMappingServiceClient = FeedMappingServiceClient.Create();
            // Initialize request argument(s)
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceNameAsFeedMappingName = FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]"),
            };
            // Make the request
            FeedMapping response = feedMappingServiceClient.GetFeedMapping(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedMappingAsync</summary>
        public async Task GetFeedMappingRequestObjectAsync()
        {
            // Snippet: GetFeedMappingAsync(GetFeedMappingRequest, CallSettings)
            // Additional: GetFeedMappingAsync(GetFeedMappingRequest, CancellationToken)
            // Create client
            FeedMappingServiceClient feedMappingServiceClient = await FeedMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceNameAsFeedMappingName = FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]"),
            };
            // Make the request
            FeedMapping response = await feedMappingServiceClient.GetFeedMappingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedMapping</summary>
        public void GetFeedMapping()
        {
            // Snippet: GetFeedMapping(string, CallSettings)
            // Create client
            FeedMappingServiceClient feedMappingServiceClient = FeedMappingServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/feedMappings/[FEED_MAPPING]";
            // Make the request
            FeedMapping response = feedMappingServiceClient.GetFeedMapping(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedMappingAsync</summary>
        public async Task GetFeedMappingAsync()
        {
            // Snippet: GetFeedMappingAsync(string, CallSettings)
            // Additional: GetFeedMappingAsync(string, CancellationToken)
            // Create client
            FeedMappingServiceClient feedMappingServiceClient = await FeedMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/feedMappings/[FEED_MAPPING]";
            // Make the request
            FeedMapping response = await feedMappingServiceClient.GetFeedMappingAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedMapping</summary>
        public void GetFeedMappingResourceNames()
        {
            // Snippet: GetFeedMapping(FeedMappingName, CallSettings)
            // Create client
            FeedMappingServiceClient feedMappingServiceClient = FeedMappingServiceClient.Create();
            // Initialize request argument(s)
            FeedMappingName resourceName = FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]");
            // Make the request
            FeedMapping response = feedMappingServiceClient.GetFeedMapping(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetFeedMappingAsync</summary>
        public async Task GetFeedMappingResourceNamesAsync()
        {
            // Snippet: GetFeedMappingAsync(FeedMappingName, CallSettings)
            // Additional: GetFeedMappingAsync(FeedMappingName, CancellationToken)
            // Create client
            FeedMappingServiceClient feedMappingServiceClient = await FeedMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedMappingName resourceName = FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]");
            // Make the request
            FeedMapping response = await feedMappingServiceClient.GetFeedMappingAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedMappings</summary>
        public void MutateFeedMappingsRequestObject()
        {
            // Snippet: MutateFeedMappings(MutateFeedMappingsRequest, CallSettings)
            // Create client
            FeedMappingServiceClient feedMappingServiceClient = FeedMappingServiceClient.Create();
            // Initialize request argument(s)
            MutateFeedMappingsRequest request = new MutateFeedMappingsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new FeedMappingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateFeedMappingsResponse response = feedMappingServiceClient.MutateFeedMappings(request);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedMappingsAsync</summary>
        public async Task MutateFeedMappingsRequestObjectAsync()
        {
            // Snippet: MutateFeedMappingsAsync(MutateFeedMappingsRequest, CallSettings)
            // Additional: MutateFeedMappingsAsync(MutateFeedMappingsRequest, CancellationToken)
            // Create client
            FeedMappingServiceClient feedMappingServiceClient = await FeedMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateFeedMappingsRequest request = new MutateFeedMappingsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new FeedMappingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateFeedMappingsResponse response = await feedMappingServiceClient.MutateFeedMappingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedMappings</summary>
        public void MutateFeedMappings()
        {
            // Snippet: MutateFeedMappings(string, IEnumerable<FeedMappingOperation>, CallSettings)
            // Create client
            FeedMappingServiceClient feedMappingServiceClient = FeedMappingServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<FeedMappingOperation> operations = new FeedMappingOperation[]
            {
                new FeedMappingOperation(),
            };
            // Make the request
            MutateFeedMappingsResponse response = feedMappingServiceClient.MutateFeedMappings(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateFeedMappingsAsync</summary>
        public async Task MutateFeedMappingsAsync()
        {
            // Snippet: MutateFeedMappingsAsync(string, IEnumerable<FeedMappingOperation>, CallSettings)
            // Additional: MutateFeedMappingsAsync(string, IEnumerable<FeedMappingOperation>, CancellationToken)
            // Create client
            FeedMappingServiceClient feedMappingServiceClient = await FeedMappingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<FeedMappingOperation> operations = new FeedMappingOperation[]
            {
                new FeedMappingOperation(),
            };
            // Make the request
            MutateFeedMappingsResponse response = await feedMappingServiceClient.MutateFeedMappingsAsync(customerId, operations);
            // End snippet
        }
    }
}
