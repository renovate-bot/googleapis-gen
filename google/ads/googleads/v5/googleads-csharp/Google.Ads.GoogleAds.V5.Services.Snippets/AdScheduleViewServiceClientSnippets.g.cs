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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAdScheduleViewServiceClientSnippets
    {
        /// <summary>Snippet for GetAdScheduleView</summary>
        public void GetAdScheduleViewRequestObject()
        {
            // Snippet: GetAdScheduleView(GetAdScheduleViewRequest, CallSettings)
            // Create client
            AdScheduleViewServiceClient adScheduleViewServiceClient = AdScheduleViewServiceClient.Create();
            // Initialize request argument(s)
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = AdScheduleViewName.FromCustomerAdScheduleView("[CUSTOMER]", "[AD_SCHEDULE_VIEW]"),
            };
            // Make the request
            AdScheduleView response = adScheduleViewServiceClient.GetAdScheduleView(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdScheduleViewAsync</summary>
        public async Task GetAdScheduleViewRequestObjectAsync()
        {
            // Snippet: GetAdScheduleViewAsync(GetAdScheduleViewRequest, CallSettings)
            // Additional: GetAdScheduleViewAsync(GetAdScheduleViewRequest, CancellationToken)
            // Create client
            AdScheduleViewServiceClient adScheduleViewServiceClient = await AdScheduleViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = AdScheduleViewName.FromCustomerAdScheduleView("[CUSTOMER]", "[AD_SCHEDULE_VIEW]"),
            };
            // Make the request
            AdScheduleView response = await adScheduleViewServiceClient.GetAdScheduleViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdScheduleView</summary>
        public void GetAdScheduleView()
        {
            // Snippet: GetAdScheduleView(string, CallSettings)
            // Create client
            AdScheduleViewServiceClient adScheduleViewServiceClient = AdScheduleViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/adScheduleViews/[AD_SCHEDULE_VIEW]";
            // Make the request
            AdScheduleView response = adScheduleViewServiceClient.GetAdScheduleView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdScheduleViewAsync</summary>
        public async Task GetAdScheduleViewAsync()
        {
            // Snippet: GetAdScheduleViewAsync(string, CallSettings)
            // Additional: GetAdScheduleViewAsync(string, CancellationToken)
            // Create client
            AdScheduleViewServiceClient adScheduleViewServiceClient = await AdScheduleViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/adScheduleViews/[AD_SCHEDULE_VIEW]";
            // Make the request
            AdScheduleView response = await adScheduleViewServiceClient.GetAdScheduleViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdScheduleView</summary>
        public void GetAdScheduleViewResourceNames()
        {
            // Snippet: GetAdScheduleView(AdScheduleViewName, CallSettings)
            // Create client
            AdScheduleViewServiceClient adScheduleViewServiceClient = AdScheduleViewServiceClient.Create();
            // Initialize request argument(s)
            AdScheduleViewName resourceName = AdScheduleViewName.FromCustomerAdScheduleView("[CUSTOMER]", "[AD_SCHEDULE_VIEW]");
            // Make the request
            AdScheduleView response = adScheduleViewServiceClient.GetAdScheduleView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdScheduleViewAsync</summary>
        public async Task GetAdScheduleViewResourceNamesAsync()
        {
            // Snippet: GetAdScheduleViewAsync(AdScheduleViewName, CallSettings)
            // Additional: GetAdScheduleViewAsync(AdScheduleViewName, CancellationToken)
            // Create client
            AdScheduleViewServiceClient adScheduleViewServiceClient = await AdScheduleViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdScheduleViewName resourceName = AdScheduleViewName.FromCustomerAdScheduleView("[CUSTOMER]", "[AD_SCHEDULE_VIEW]");
            // Make the request
            AdScheduleView response = await adScheduleViewServiceClient.GetAdScheduleViewAsync(resourceName);
            // End snippet
        }
    }
}
