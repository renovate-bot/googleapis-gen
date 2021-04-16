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
    public sealed class GeneratedLandingPageViewServiceClientSnippets
    {
        /// <summary>Snippet for GetLandingPageView</summary>
        public void GetLandingPageViewRequestObject()
        {
            // Snippet: GetLandingPageView(GetLandingPageViewRequest, CallSettings)
            // Create client
            LandingPageViewServiceClient landingPageViewServiceClient = LandingPageViewServiceClient.Create();
            // Initialize request argument(s)
            GetLandingPageViewRequest request = new GetLandingPageViewRequest
            {
                ResourceNameAsLandingPageViewName = LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]"),
            };
            // Make the request
            LandingPageView response = landingPageViewServiceClient.GetLandingPageView(request);
            // End snippet
        }

        /// <summary>Snippet for GetLandingPageViewAsync</summary>
        public async Task GetLandingPageViewRequestObjectAsync()
        {
            // Snippet: GetLandingPageViewAsync(GetLandingPageViewRequest, CallSettings)
            // Additional: GetLandingPageViewAsync(GetLandingPageViewRequest, CancellationToken)
            // Create client
            LandingPageViewServiceClient landingPageViewServiceClient = await LandingPageViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLandingPageViewRequest request = new GetLandingPageViewRequest
            {
                ResourceNameAsLandingPageViewName = LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]"),
            };
            // Make the request
            LandingPageView response = await landingPageViewServiceClient.GetLandingPageViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLandingPageView</summary>
        public void GetLandingPageView()
        {
            // Snippet: GetLandingPageView(string, CallSettings)
            // Create client
            LandingPageViewServiceClient landingPageViewServiceClient = LandingPageViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/landingPageViews/[LANDING_PAGE_VIEW]";
            // Make the request
            LandingPageView response = landingPageViewServiceClient.GetLandingPageView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetLandingPageViewAsync</summary>
        public async Task GetLandingPageViewAsync()
        {
            // Snippet: GetLandingPageViewAsync(string, CallSettings)
            // Additional: GetLandingPageViewAsync(string, CancellationToken)
            // Create client
            LandingPageViewServiceClient landingPageViewServiceClient = await LandingPageViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/landingPageViews/[LANDING_PAGE_VIEW]";
            // Make the request
            LandingPageView response = await landingPageViewServiceClient.GetLandingPageViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetLandingPageView</summary>
        public void GetLandingPageViewResourceNames()
        {
            // Snippet: GetLandingPageView(LandingPageViewName, CallSettings)
            // Create client
            LandingPageViewServiceClient landingPageViewServiceClient = LandingPageViewServiceClient.Create();
            // Initialize request argument(s)
            LandingPageViewName resourceName = LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]");
            // Make the request
            LandingPageView response = landingPageViewServiceClient.GetLandingPageView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetLandingPageViewAsync</summary>
        public async Task GetLandingPageViewResourceNamesAsync()
        {
            // Snippet: GetLandingPageViewAsync(LandingPageViewName, CallSettings)
            // Additional: GetLandingPageViewAsync(LandingPageViewName, CancellationToken)
            // Create client
            LandingPageViewServiceClient landingPageViewServiceClient = await LandingPageViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            LandingPageViewName resourceName = LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]");
            // Make the request
            LandingPageView response = await landingPageViewServiceClient.GetLandingPageViewAsync(resourceName);
            // End snippet
        }
    }
}
