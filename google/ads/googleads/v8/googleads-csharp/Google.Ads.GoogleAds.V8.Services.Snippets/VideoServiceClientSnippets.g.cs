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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedVideoServiceClientSnippets
    {
        /// <summary>Snippet for GetVideo</summary>
        public void GetVideoRequestObject()
        {
            // Snippet: GetVideo(GetVideoRequest, CallSettings)
            // Create client
            VideoServiceClient videoServiceClient = VideoServiceClient.Create();
            // Initialize request argument(s)
            GetVideoRequest request = new GetVideoRequest
            {
                ResourceNameAsVideoName = VideoName.FromCustomerVideo("[CUSTOMER_ID]", "[VIDEO_ID]"),
            };
            // Make the request
            Video response = videoServiceClient.GetVideo(request);
            // End snippet
        }

        /// <summary>Snippet for GetVideoAsync</summary>
        public async Task GetVideoRequestObjectAsync()
        {
            // Snippet: GetVideoAsync(GetVideoRequest, CallSettings)
            // Additional: GetVideoAsync(GetVideoRequest, CancellationToken)
            // Create client
            VideoServiceClient videoServiceClient = await VideoServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetVideoRequest request = new GetVideoRequest
            {
                ResourceNameAsVideoName = VideoName.FromCustomerVideo("[CUSTOMER_ID]", "[VIDEO_ID]"),
            };
            // Make the request
            Video response = await videoServiceClient.GetVideoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVideo</summary>
        public void GetVideo()
        {
            // Snippet: GetVideo(string, CallSettings)
            // Create client
            VideoServiceClient videoServiceClient = VideoServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/videos/[VIDEO_ID]";
            // Make the request
            Video response = videoServiceClient.GetVideo(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetVideoAsync</summary>
        public async Task GetVideoAsync()
        {
            // Snippet: GetVideoAsync(string, CallSettings)
            // Additional: GetVideoAsync(string, CancellationToken)
            // Create client
            VideoServiceClient videoServiceClient = await VideoServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/videos/[VIDEO_ID]";
            // Make the request
            Video response = await videoServiceClient.GetVideoAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetVideo</summary>
        public void GetVideoResourceNames()
        {
            // Snippet: GetVideo(VideoName, CallSettings)
            // Create client
            VideoServiceClient videoServiceClient = VideoServiceClient.Create();
            // Initialize request argument(s)
            VideoName resourceName = VideoName.FromCustomerVideo("[CUSTOMER_ID]", "[VIDEO_ID]");
            // Make the request
            Video response = videoServiceClient.GetVideo(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetVideoAsync</summary>
        public async Task GetVideoResourceNamesAsync()
        {
            // Snippet: GetVideoAsync(VideoName, CallSettings)
            // Additional: GetVideoAsync(VideoName, CancellationToken)
            // Create client
            VideoServiceClient videoServiceClient = await VideoServiceClient.CreateAsync();
            // Initialize request argument(s)
            VideoName resourceName = VideoName.FromCustomerVideo("[CUSTOMER_ID]", "[VIDEO_ID]");
            // Make the request
            Video response = await videoServiceClient.GetVideoAsync(resourceName);
            // End snippet
        }
    }
}
