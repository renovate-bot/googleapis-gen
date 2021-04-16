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
    public sealed class GeneratedGeographicViewServiceClientSnippets
    {
        /// <summary>Snippet for GetGeographicView</summary>
        public void GetGeographicViewRequestObject()
        {
            // Snippet: GetGeographicView(GetGeographicViewRequest, CallSettings)
            // Create client
            GeographicViewServiceClient geographicViewServiceClient = GeographicViewServiceClient.Create();
            // Initialize request argument(s)
            GetGeographicViewRequest request = new GetGeographicViewRequest
            {
                ResourceNameAsGeographicViewName = GeographicViewName.FromCustomerGeographicView("[CUSTOMER]", "[GEOGRAPHIC_VIEW]"),
            };
            // Make the request
            GeographicView response = geographicViewServiceClient.GetGeographicView(request);
            // End snippet
        }

        /// <summary>Snippet for GetGeographicViewAsync</summary>
        public async Task GetGeographicViewRequestObjectAsync()
        {
            // Snippet: GetGeographicViewAsync(GetGeographicViewRequest, CallSettings)
            // Additional: GetGeographicViewAsync(GetGeographicViewRequest, CancellationToken)
            // Create client
            GeographicViewServiceClient geographicViewServiceClient = await GeographicViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGeographicViewRequest request = new GetGeographicViewRequest
            {
                ResourceNameAsGeographicViewName = GeographicViewName.FromCustomerGeographicView("[CUSTOMER]", "[GEOGRAPHIC_VIEW]"),
            };
            // Make the request
            GeographicView response = await geographicViewServiceClient.GetGeographicViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGeographicView</summary>
        public void GetGeographicView()
        {
            // Snippet: GetGeographicView(string, CallSettings)
            // Create client
            GeographicViewServiceClient geographicViewServiceClient = GeographicViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/geographicViews/[GEOGRAPHIC_VIEW]";
            // Make the request
            GeographicView response = geographicViewServiceClient.GetGeographicView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetGeographicViewAsync</summary>
        public async Task GetGeographicViewAsync()
        {
            // Snippet: GetGeographicViewAsync(string, CallSettings)
            // Additional: GetGeographicViewAsync(string, CancellationToken)
            // Create client
            GeographicViewServiceClient geographicViewServiceClient = await GeographicViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/geographicViews/[GEOGRAPHIC_VIEW]";
            // Make the request
            GeographicView response = await geographicViewServiceClient.GetGeographicViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetGeographicView</summary>
        public void GetGeographicViewResourceNames()
        {
            // Snippet: GetGeographicView(GeographicViewName, CallSettings)
            // Create client
            GeographicViewServiceClient geographicViewServiceClient = GeographicViewServiceClient.Create();
            // Initialize request argument(s)
            GeographicViewName resourceName = GeographicViewName.FromCustomerGeographicView("[CUSTOMER]", "[GEOGRAPHIC_VIEW]");
            // Make the request
            GeographicView response = geographicViewServiceClient.GetGeographicView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetGeographicViewAsync</summary>
        public async Task GetGeographicViewResourceNamesAsync()
        {
            // Snippet: GetGeographicViewAsync(GeographicViewName, CallSettings)
            // Additional: GetGeographicViewAsync(GeographicViewName, CancellationToken)
            // Create client
            GeographicViewServiceClient geographicViewServiceClient = await GeographicViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GeographicViewName resourceName = GeographicViewName.FromCustomerGeographicView("[CUSTOMER]", "[GEOGRAPHIC_VIEW]");
            // Make the request
            GeographicView response = await geographicViewServiceClient.GetGeographicViewAsync(resourceName);
            // End snippet
        }
    }
}
