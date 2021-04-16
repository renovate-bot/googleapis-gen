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
    public sealed class GeneratedUserLocationViewServiceClientSnippets
    {
        /// <summary>Snippet for GetUserLocationView</summary>
        public void GetUserLocationViewRequestObject()
        {
            // Snippet: GetUserLocationView(GetUserLocationViewRequest, CallSettings)
            // Create client
            UserLocationViewServiceClient userLocationViewServiceClient = UserLocationViewServiceClient.Create();
            // Initialize request argument(s)
            GetUserLocationViewRequest request = new GetUserLocationViewRequest
            {
                ResourceNameAsUserLocationViewName = UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]"),
            };
            // Make the request
            UserLocationView response = userLocationViewServiceClient.GetUserLocationView(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserLocationViewAsync</summary>
        public async Task GetUserLocationViewRequestObjectAsync()
        {
            // Snippet: GetUserLocationViewAsync(GetUserLocationViewRequest, CallSettings)
            // Additional: GetUserLocationViewAsync(GetUserLocationViewRequest, CancellationToken)
            // Create client
            UserLocationViewServiceClient userLocationViewServiceClient = await UserLocationViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetUserLocationViewRequest request = new GetUserLocationViewRequest
            {
                ResourceNameAsUserLocationViewName = UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]"),
            };
            // Make the request
            UserLocationView response = await userLocationViewServiceClient.GetUserLocationViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserLocationView</summary>
        public void GetUserLocationView()
        {
            // Snippet: GetUserLocationView(string, CallSettings)
            // Create client
            UserLocationViewServiceClient userLocationViewServiceClient = UserLocationViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/userLocationViews/[USER_LOCATION_VIEW]";
            // Make the request
            UserLocationView response = userLocationViewServiceClient.GetUserLocationView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetUserLocationViewAsync</summary>
        public async Task GetUserLocationViewAsync()
        {
            // Snippet: GetUserLocationViewAsync(string, CallSettings)
            // Additional: GetUserLocationViewAsync(string, CancellationToken)
            // Create client
            UserLocationViewServiceClient userLocationViewServiceClient = await UserLocationViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/userLocationViews/[USER_LOCATION_VIEW]";
            // Make the request
            UserLocationView response = await userLocationViewServiceClient.GetUserLocationViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetUserLocationView</summary>
        public void GetUserLocationViewResourceNames()
        {
            // Snippet: GetUserLocationView(UserLocationViewName, CallSettings)
            // Create client
            UserLocationViewServiceClient userLocationViewServiceClient = UserLocationViewServiceClient.Create();
            // Initialize request argument(s)
            UserLocationViewName resourceName = UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]");
            // Make the request
            UserLocationView response = userLocationViewServiceClient.GetUserLocationView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetUserLocationViewAsync</summary>
        public async Task GetUserLocationViewResourceNamesAsync()
        {
            // Snippet: GetUserLocationViewAsync(UserLocationViewName, CallSettings)
            // Additional: GetUserLocationViewAsync(UserLocationViewName, CancellationToken)
            // Create client
            UserLocationViewServiceClient userLocationViewServiceClient = await UserLocationViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserLocationViewName resourceName = UserLocationViewName.FromCustomerUserLocationView("[CUSTOMER]", "[USER_LOCATION_VIEW]");
            // Make the request
            UserLocationView response = await userLocationViewServiceClient.GetUserLocationViewAsync(resourceName);
            // End snippet
        }
    }
}
