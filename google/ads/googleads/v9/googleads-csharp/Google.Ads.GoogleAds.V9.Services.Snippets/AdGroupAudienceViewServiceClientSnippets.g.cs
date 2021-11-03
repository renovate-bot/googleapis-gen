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

namespace Google.Ads.GoogleAds.V9.Services.Snippets
{
    using Google.Ads.GoogleAds.V9.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAdGroupAudienceViewServiceClientSnippets
    {
        /// <summary>Snippet for GetAdGroupAudienceView</summary>
        public void GetAdGroupAudienceViewRequestObject()
        {
            // Snippet: GetAdGroupAudienceView(GetAdGroupAudienceViewRequest, CallSettings)
            // Create client
            AdGroupAudienceViewServiceClient adGroupAudienceViewServiceClient = AdGroupAudienceViewServiceClient.Create();
            // Initialize request argument(s)
            GetAdGroupAudienceViewRequest request = new GetAdGroupAudienceViewRequest
            {
                ResourceNameAsAdGroupAudienceViewName = AdGroupAudienceViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            AdGroupAudienceView response = adGroupAudienceViewServiceClient.GetAdGroupAudienceView(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAudienceViewAsync</summary>
        public async Task GetAdGroupAudienceViewRequestObjectAsync()
        {
            // Snippet: GetAdGroupAudienceViewAsync(GetAdGroupAudienceViewRequest, CallSettings)
            // Additional: GetAdGroupAudienceViewAsync(GetAdGroupAudienceViewRequest, CancellationToken)
            // Create client
            AdGroupAudienceViewServiceClient adGroupAudienceViewServiceClient = await AdGroupAudienceViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdGroupAudienceViewRequest request = new GetAdGroupAudienceViewRequest
            {
                ResourceNameAsAdGroupAudienceViewName = AdGroupAudienceViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            AdGroupAudienceView response = await adGroupAudienceViewServiceClient.GetAdGroupAudienceViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAudienceView</summary>
        public void GetAdGroupAudienceView()
        {
            // Snippet: GetAdGroupAudienceView(string, CallSettings)
            // Create client
            AdGroupAudienceViewServiceClient adGroupAudienceViewServiceClient = AdGroupAudienceViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupAudienceViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            AdGroupAudienceView response = adGroupAudienceViewServiceClient.GetAdGroupAudienceView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAudienceViewAsync</summary>
        public async Task GetAdGroupAudienceViewAsync()
        {
            // Snippet: GetAdGroupAudienceViewAsync(string, CallSettings)
            // Additional: GetAdGroupAudienceViewAsync(string, CancellationToken)
            // Create client
            AdGroupAudienceViewServiceClient adGroupAudienceViewServiceClient = await AdGroupAudienceViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupAudienceViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            AdGroupAudienceView response = await adGroupAudienceViewServiceClient.GetAdGroupAudienceViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAudienceView</summary>
        public void GetAdGroupAudienceViewResourceNames()
        {
            // Snippet: GetAdGroupAudienceView(AdGroupAudienceViewName, CallSettings)
            // Create client
            AdGroupAudienceViewServiceClient adGroupAudienceViewServiceClient = AdGroupAudienceViewServiceClient.Create();
            // Initialize request argument(s)
            AdGroupAudienceViewName resourceName = AdGroupAudienceViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            AdGroupAudienceView response = adGroupAudienceViewServiceClient.GetAdGroupAudienceView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAudienceViewAsync</summary>
        public async Task GetAdGroupAudienceViewResourceNamesAsync()
        {
            // Snippet: GetAdGroupAudienceViewAsync(AdGroupAudienceViewName, CallSettings)
            // Additional: GetAdGroupAudienceViewAsync(AdGroupAudienceViewName, CancellationToken)
            // Create client
            AdGroupAudienceViewServiceClient adGroupAudienceViewServiceClient = await AdGroupAudienceViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdGroupAudienceViewName resourceName = AdGroupAudienceViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            AdGroupAudienceView response = await adGroupAudienceViewServiceClient.GetAdGroupAudienceViewAsync(resourceName);
            // End snippet
        }
    }
}
