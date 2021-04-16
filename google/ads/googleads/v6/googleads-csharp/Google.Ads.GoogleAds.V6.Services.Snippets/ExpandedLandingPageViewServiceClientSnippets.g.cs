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

namespace Google.Ads.GoogleAds.V6.Services.Snippets
{
    using Google.Ads.GoogleAds.V6.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedExpandedLandingPageViewServiceClientSnippets
    {
        /// <summary>Snippet for GetExpandedLandingPageView</summary>
        public void GetExpandedLandingPageViewRequestObject()
        {
            // Snippet: GetExpandedLandingPageView(GetExpandedLandingPageViewRequest, CallSettings)
            // Create client
            ExpandedLandingPageViewServiceClient expandedLandingPageViewServiceClient = ExpandedLandingPageViewServiceClient.Create();
            // Initialize request argument(s)
            GetExpandedLandingPageViewRequest request = new GetExpandedLandingPageViewRequest
            {
                ResourceNameAsExpandedLandingPageViewName = ExpandedLandingPageViewName.FromCustomerExpandedFinalUrlFingerprint("[CUSTOMER_ID]", "[EXPANDED_FINAL_URL_FINGERPRINT]"),
            };
            // Make the request
            ExpandedLandingPageView response = expandedLandingPageViewServiceClient.GetExpandedLandingPageView(request);
            // End snippet
        }

        /// <summary>Snippet for GetExpandedLandingPageViewAsync</summary>
        public async Task GetExpandedLandingPageViewRequestObjectAsync()
        {
            // Snippet: GetExpandedLandingPageViewAsync(GetExpandedLandingPageViewRequest, CallSettings)
            // Additional: GetExpandedLandingPageViewAsync(GetExpandedLandingPageViewRequest, CancellationToken)
            // Create client
            ExpandedLandingPageViewServiceClient expandedLandingPageViewServiceClient = await ExpandedLandingPageViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetExpandedLandingPageViewRequest request = new GetExpandedLandingPageViewRequest
            {
                ResourceNameAsExpandedLandingPageViewName = ExpandedLandingPageViewName.FromCustomerExpandedFinalUrlFingerprint("[CUSTOMER_ID]", "[EXPANDED_FINAL_URL_FINGERPRINT]"),
            };
            // Make the request
            ExpandedLandingPageView response = await expandedLandingPageViewServiceClient.GetExpandedLandingPageViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExpandedLandingPageView</summary>
        public void GetExpandedLandingPageView()
        {
            // Snippet: GetExpandedLandingPageView(string, CallSettings)
            // Create client
            ExpandedLandingPageViewServiceClient expandedLandingPageViewServiceClient = ExpandedLandingPageViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/expandedLandingPageViews/[EXPANDED_FINAL_URL_FINGERPRINT]";
            // Make the request
            ExpandedLandingPageView response = expandedLandingPageViewServiceClient.GetExpandedLandingPageView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetExpandedLandingPageViewAsync</summary>
        public async Task GetExpandedLandingPageViewAsync()
        {
            // Snippet: GetExpandedLandingPageViewAsync(string, CallSettings)
            // Additional: GetExpandedLandingPageViewAsync(string, CancellationToken)
            // Create client
            ExpandedLandingPageViewServiceClient expandedLandingPageViewServiceClient = await ExpandedLandingPageViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/expandedLandingPageViews/[EXPANDED_FINAL_URL_FINGERPRINT]";
            // Make the request
            ExpandedLandingPageView response = await expandedLandingPageViewServiceClient.GetExpandedLandingPageViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetExpandedLandingPageView</summary>
        public void GetExpandedLandingPageViewResourceNames()
        {
            // Snippet: GetExpandedLandingPageView(ExpandedLandingPageViewName, CallSettings)
            // Create client
            ExpandedLandingPageViewServiceClient expandedLandingPageViewServiceClient = ExpandedLandingPageViewServiceClient.Create();
            // Initialize request argument(s)
            ExpandedLandingPageViewName resourceName = ExpandedLandingPageViewName.FromCustomerExpandedFinalUrlFingerprint("[CUSTOMER_ID]", "[EXPANDED_FINAL_URL_FINGERPRINT]");
            // Make the request
            ExpandedLandingPageView response = expandedLandingPageViewServiceClient.GetExpandedLandingPageView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetExpandedLandingPageViewAsync</summary>
        public async Task GetExpandedLandingPageViewResourceNamesAsync()
        {
            // Snippet: GetExpandedLandingPageViewAsync(ExpandedLandingPageViewName, CallSettings)
            // Additional: GetExpandedLandingPageViewAsync(ExpandedLandingPageViewName, CancellationToken)
            // Create client
            ExpandedLandingPageViewServiceClient expandedLandingPageViewServiceClient = await ExpandedLandingPageViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExpandedLandingPageViewName resourceName = ExpandedLandingPageViewName.FromCustomerExpandedFinalUrlFingerprint("[CUSTOMER_ID]", "[EXPANDED_FINAL_URL_FINGERPRINT]");
            // Make the request
            ExpandedLandingPageView response = await expandedLandingPageViewServiceClient.GetExpandedLandingPageViewAsync(resourceName);
            // End snippet
        }
    }
}
