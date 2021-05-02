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

namespace Google.Ads.GoogleAds.V7.Services.Snippets
{
    using Google.Ads.GoogleAds.V7.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedDynamicSearchAdsSearchTermViewServiceClientSnippets
    {
        /// <summary>Snippet for GetDynamicSearchAdsSearchTermView</summary>
        public void GetDynamicSearchAdsSearchTermViewRequestObject()
        {
            // Snippet: GetDynamicSearchAdsSearchTermView(GetDynamicSearchAdsSearchTermViewRequest, CallSettings)
            // Create client
            DynamicSearchAdsSearchTermViewServiceClient dynamicSearchAdsSearchTermViewServiceClient = DynamicSearchAdsSearchTermViewServiceClient.Create();
            // Initialize request argument(s)
            GetDynamicSearchAdsSearchTermViewRequest request = new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]"),
            };
            // Make the request
            DynamicSearchAdsSearchTermView response = dynamicSearchAdsSearchTermViewServiceClient.GetDynamicSearchAdsSearchTermView(request);
            // End snippet
        }

        /// <summary>Snippet for GetDynamicSearchAdsSearchTermViewAsync</summary>
        public async Task GetDynamicSearchAdsSearchTermViewRequestObjectAsync()
        {
            // Snippet: GetDynamicSearchAdsSearchTermViewAsync(GetDynamicSearchAdsSearchTermViewRequest, CallSettings)
            // Additional: GetDynamicSearchAdsSearchTermViewAsync(GetDynamicSearchAdsSearchTermViewRequest, CancellationToken)
            // Create client
            DynamicSearchAdsSearchTermViewServiceClient dynamicSearchAdsSearchTermViewServiceClient = await DynamicSearchAdsSearchTermViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDynamicSearchAdsSearchTermViewRequest request = new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]"),
            };
            // Make the request
            DynamicSearchAdsSearchTermView response = await dynamicSearchAdsSearchTermViewServiceClient.GetDynamicSearchAdsSearchTermViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDynamicSearchAdsSearchTermView</summary>
        public void GetDynamicSearchAdsSearchTermView()
        {
            // Snippet: GetDynamicSearchAdsSearchTermView(string, CallSettings)
            // Create client
            DynamicSearchAdsSearchTermViewServiceClient dynamicSearchAdsSearchTermViewServiceClient = DynamicSearchAdsSearchTermViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/dynamicSearchAdsSearchTermViews/[AD_GROUP_ID]~[SEARCH_TERM_FINGERPRINT]~[HEADLINE_FINGERPRINT]~[LANDING_PAGE_FINGERPRINT]~[PAGE_URL_FINGERPRINT]";
            // Make the request
            DynamicSearchAdsSearchTermView response = dynamicSearchAdsSearchTermViewServiceClient.GetDynamicSearchAdsSearchTermView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDynamicSearchAdsSearchTermViewAsync</summary>
        public async Task GetDynamicSearchAdsSearchTermViewAsync()
        {
            // Snippet: GetDynamicSearchAdsSearchTermViewAsync(string, CallSettings)
            // Additional: GetDynamicSearchAdsSearchTermViewAsync(string, CancellationToken)
            // Create client
            DynamicSearchAdsSearchTermViewServiceClient dynamicSearchAdsSearchTermViewServiceClient = await DynamicSearchAdsSearchTermViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/dynamicSearchAdsSearchTermViews/[AD_GROUP_ID]~[SEARCH_TERM_FINGERPRINT]~[HEADLINE_FINGERPRINT]~[LANDING_PAGE_FINGERPRINT]~[PAGE_URL_FINGERPRINT]";
            // Make the request
            DynamicSearchAdsSearchTermView response = await dynamicSearchAdsSearchTermViewServiceClient.GetDynamicSearchAdsSearchTermViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDynamicSearchAdsSearchTermView</summary>
        public void GetDynamicSearchAdsSearchTermViewResourceNames()
        {
            // Snippet: GetDynamicSearchAdsSearchTermView(DynamicSearchAdsSearchTermViewName, CallSettings)
            // Create client
            DynamicSearchAdsSearchTermViewServiceClient dynamicSearchAdsSearchTermViewServiceClient = DynamicSearchAdsSearchTermViewServiceClient.Create();
            // Initialize request argument(s)
            DynamicSearchAdsSearchTermViewName resourceName = DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]");
            // Make the request
            DynamicSearchAdsSearchTermView response = dynamicSearchAdsSearchTermViewServiceClient.GetDynamicSearchAdsSearchTermView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDynamicSearchAdsSearchTermViewAsync</summary>
        public async Task GetDynamicSearchAdsSearchTermViewResourceNamesAsync()
        {
            // Snippet: GetDynamicSearchAdsSearchTermViewAsync(DynamicSearchAdsSearchTermViewName, CallSettings)
            // Additional: GetDynamicSearchAdsSearchTermViewAsync(DynamicSearchAdsSearchTermViewName, CancellationToken)
            // Create client
            DynamicSearchAdsSearchTermViewServiceClient dynamicSearchAdsSearchTermViewServiceClient = await DynamicSearchAdsSearchTermViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            DynamicSearchAdsSearchTermViewName resourceName = DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]");
            // Make the request
            DynamicSearchAdsSearchTermView response = await dynamicSearchAdsSearchTermViewServiceClient.GetDynamicSearchAdsSearchTermViewAsync(resourceName);
            // End snippet
        }
    }
}
