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
    public sealed class GeneratedDistanceViewServiceClientSnippets
    {
        /// <summary>Snippet for GetDistanceView</summary>
        public void GetDistanceViewRequestObject()
        {
            // Snippet: GetDistanceView(GetDistanceViewRequest, CallSettings)
            // Create client
            DistanceViewServiceClient distanceViewServiceClient = DistanceViewServiceClient.Create();
            // Initialize request argument(s)
            GetDistanceViewRequest request = new GetDistanceViewRequest
            {
                ResourceNameAsDistanceViewName = DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]"),
            };
            // Make the request
            DistanceView response = distanceViewServiceClient.GetDistanceView(request);
            // End snippet
        }

        /// <summary>Snippet for GetDistanceViewAsync</summary>
        public async Task GetDistanceViewRequestObjectAsync()
        {
            // Snippet: GetDistanceViewAsync(GetDistanceViewRequest, CallSettings)
            // Additional: GetDistanceViewAsync(GetDistanceViewRequest, CancellationToken)
            // Create client
            DistanceViewServiceClient distanceViewServiceClient = await DistanceViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDistanceViewRequest request = new GetDistanceViewRequest
            {
                ResourceNameAsDistanceViewName = DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]"),
            };
            // Make the request
            DistanceView response = await distanceViewServiceClient.GetDistanceViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDistanceView</summary>
        public void GetDistanceView()
        {
            // Snippet: GetDistanceView(string, CallSettings)
            // Create client
            DistanceViewServiceClient distanceViewServiceClient = DistanceViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/distanceViews/[DISTANCE_VIEW]";
            // Make the request
            DistanceView response = distanceViewServiceClient.GetDistanceView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDistanceViewAsync</summary>
        public async Task GetDistanceViewAsync()
        {
            // Snippet: GetDistanceViewAsync(string, CallSettings)
            // Additional: GetDistanceViewAsync(string, CancellationToken)
            // Create client
            DistanceViewServiceClient distanceViewServiceClient = await DistanceViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/distanceViews/[DISTANCE_VIEW]";
            // Make the request
            DistanceView response = await distanceViewServiceClient.GetDistanceViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDistanceView</summary>
        public void GetDistanceViewResourceNames()
        {
            // Snippet: GetDistanceView(DistanceViewName, CallSettings)
            // Create client
            DistanceViewServiceClient distanceViewServiceClient = DistanceViewServiceClient.Create();
            // Initialize request argument(s)
            DistanceViewName resourceName = DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]");
            // Make the request
            DistanceView response = distanceViewServiceClient.GetDistanceView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDistanceViewAsync</summary>
        public async Task GetDistanceViewResourceNamesAsync()
        {
            // Snippet: GetDistanceViewAsync(DistanceViewName, CallSettings)
            // Additional: GetDistanceViewAsync(DistanceViewName, CancellationToken)
            // Create client
            DistanceViewServiceClient distanceViewServiceClient = await DistanceViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            DistanceViewName resourceName = DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]");
            // Make the request
            DistanceView response = await distanceViewServiceClient.GetDistanceViewAsync(resourceName);
            // End snippet
        }
    }
}
