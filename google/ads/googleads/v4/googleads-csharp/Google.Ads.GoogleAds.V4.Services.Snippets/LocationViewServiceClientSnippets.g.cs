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
    public sealed class GeneratedLocationViewServiceClientSnippets
    {
        /// <summary>Snippet for GetLocationView</summary>
        public void GetLocationViewRequestObject()
        {
            // Snippet: GetLocationView(GetLocationViewRequest, CallSettings)
            // Create client
            LocationViewServiceClient locationViewServiceClient = LocationViewServiceClient.Create();
            // Initialize request argument(s)
            GetLocationViewRequest request = new GetLocationViewRequest
            {
                ResourceNameAsLocationViewName = LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]"),
            };
            // Make the request
            LocationView response = locationViewServiceClient.GetLocationView(request);
            // End snippet
        }

        /// <summary>Snippet for GetLocationViewAsync</summary>
        public async Task GetLocationViewRequestObjectAsync()
        {
            // Snippet: GetLocationViewAsync(GetLocationViewRequest, CallSettings)
            // Additional: GetLocationViewAsync(GetLocationViewRequest, CancellationToken)
            // Create client
            LocationViewServiceClient locationViewServiceClient = await LocationViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLocationViewRequest request = new GetLocationViewRequest
            {
                ResourceNameAsLocationViewName = LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]"),
            };
            // Make the request
            LocationView response = await locationViewServiceClient.GetLocationViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLocationView</summary>
        public void GetLocationView()
        {
            // Snippet: GetLocationView(string, CallSettings)
            // Create client
            LocationViewServiceClient locationViewServiceClient = LocationViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/locationViews/[LOCATION_VIEW]";
            // Make the request
            LocationView response = locationViewServiceClient.GetLocationView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetLocationViewAsync</summary>
        public async Task GetLocationViewAsync()
        {
            // Snippet: GetLocationViewAsync(string, CallSettings)
            // Additional: GetLocationViewAsync(string, CancellationToken)
            // Create client
            LocationViewServiceClient locationViewServiceClient = await LocationViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/locationViews/[LOCATION_VIEW]";
            // Make the request
            LocationView response = await locationViewServiceClient.GetLocationViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetLocationView</summary>
        public void GetLocationViewResourceNames()
        {
            // Snippet: GetLocationView(LocationViewName, CallSettings)
            // Create client
            LocationViewServiceClient locationViewServiceClient = LocationViewServiceClient.Create();
            // Initialize request argument(s)
            LocationViewName resourceName = LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]");
            // Make the request
            LocationView response = locationViewServiceClient.GetLocationView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetLocationViewAsync</summary>
        public async Task GetLocationViewResourceNamesAsync()
        {
            // Snippet: GetLocationViewAsync(LocationViewName, CallSettings)
            // Additional: GetLocationViewAsync(LocationViewName, CancellationToken)
            // Create client
            LocationViewServiceClient locationViewServiceClient = await LocationViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationViewName resourceName = LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]");
            // Make the request
            LocationView response = await locationViewServiceClient.GetLocationViewAsync(resourceName);
            // End snippet
        }
    }
}
