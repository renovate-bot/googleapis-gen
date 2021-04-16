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
    public sealed class GeneratedDisplayKeywordViewServiceClientSnippets
    {
        /// <summary>Snippet for GetDisplayKeywordView</summary>
        public void GetDisplayKeywordViewRequestObject()
        {
            // Snippet: GetDisplayKeywordView(GetDisplayKeywordViewRequest, CallSettings)
            // Create client
            DisplayKeywordViewServiceClient displayKeywordViewServiceClient = DisplayKeywordViewServiceClient.Create();
            // Initialize request argument(s)
            GetDisplayKeywordViewRequest request = new GetDisplayKeywordViewRequest
            {
                ResourceNameAsDisplayKeywordViewName = DisplayKeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            DisplayKeywordView response = displayKeywordViewServiceClient.GetDisplayKeywordView(request);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayKeywordViewAsync</summary>
        public async Task GetDisplayKeywordViewRequestObjectAsync()
        {
            // Snippet: GetDisplayKeywordViewAsync(GetDisplayKeywordViewRequest, CallSettings)
            // Additional: GetDisplayKeywordViewAsync(GetDisplayKeywordViewRequest, CancellationToken)
            // Create client
            DisplayKeywordViewServiceClient displayKeywordViewServiceClient = await DisplayKeywordViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDisplayKeywordViewRequest request = new GetDisplayKeywordViewRequest
            {
                ResourceNameAsDisplayKeywordViewName = DisplayKeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            DisplayKeywordView response = await displayKeywordViewServiceClient.GetDisplayKeywordViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayKeywordView</summary>
        public void GetDisplayKeywordView()
        {
            // Snippet: GetDisplayKeywordView(string, CallSettings)
            // Create client
            DisplayKeywordViewServiceClient displayKeywordViewServiceClient = DisplayKeywordViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/displayKeywordViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            DisplayKeywordView response = displayKeywordViewServiceClient.GetDisplayKeywordView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayKeywordViewAsync</summary>
        public async Task GetDisplayKeywordViewAsync()
        {
            // Snippet: GetDisplayKeywordViewAsync(string, CallSettings)
            // Additional: GetDisplayKeywordViewAsync(string, CancellationToken)
            // Create client
            DisplayKeywordViewServiceClient displayKeywordViewServiceClient = await DisplayKeywordViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/displayKeywordViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            DisplayKeywordView response = await displayKeywordViewServiceClient.GetDisplayKeywordViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayKeywordView</summary>
        public void GetDisplayKeywordViewResourceNames()
        {
            // Snippet: GetDisplayKeywordView(DisplayKeywordViewName, CallSettings)
            // Create client
            DisplayKeywordViewServiceClient displayKeywordViewServiceClient = DisplayKeywordViewServiceClient.Create();
            // Initialize request argument(s)
            DisplayKeywordViewName resourceName = DisplayKeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            DisplayKeywordView response = displayKeywordViewServiceClient.GetDisplayKeywordView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayKeywordViewAsync</summary>
        public async Task GetDisplayKeywordViewResourceNamesAsync()
        {
            // Snippet: GetDisplayKeywordViewAsync(DisplayKeywordViewName, CallSettings)
            // Additional: GetDisplayKeywordViewAsync(DisplayKeywordViewName, CancellationToken)
            // Create client
            DisplayKeywordViewServiceClient displayKeywordViewServiceClient = await DisplayKeywordViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            DisplayKeywordViewName resourceName = DisplayKeywordViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            DisplayKeywordView response = await displayKeywordViewServiceClient.GetDisplayKeywordViewAsync(resourceName);
            // End snippet
        }
    }
}
