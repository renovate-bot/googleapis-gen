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

namespace Google.Ads.GoogleAds.V8.Services.Snippets
{
    using Google.Ads.GoogleAds.V8.Resources;
    using Google.Ads.GoogleAds.V8.Services;

    public sealed partial class GeneratedFeedMappingServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetFeedMapping</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetFeedMappingRequestObject()
        {
            // Create client
            FeedMappingServiceClient feedMappingServiceClient = FeedMappingServiceClient.Create();
            // Initialize request argument(s)
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceNameAsFeedMappingName = FeedMappingName.FromCustomerFeedFeedMapping("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_MAPPING_ID]"),
            };
            // Make the request
            FeedMapping response = feedMappingServiceClient.GetFeedMapping(request);
        }
    }
}
