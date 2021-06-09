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

namespace Google.Ads.GoogleAds.V8.Services.Snippets
{
    using Google.Ads.GoogleAds.V8.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedWebpageViewServiceClientSnippets
    {
        /// <summary>Snippet for GetWebpageView</summary>
        public void GetWebpageViewRequestObject()
        {
            // Snippet: GetWebpageView(GetWebpageViewRequest, CallSettings)
            // Create client
            WebpageViewServiceClient webpageViewServiceClient = WebpageViewServiceClient.Create();
            // Initialize request argument(s)
            GetWebpageViewRequest request = new GetWebpageViewRequest
            {
                ResourceNameAsWebpageViewName = WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            WebpageView response = webpageViewServiceClient.GetWebpageView(request);
            // End snippet
        }

        /// <summary>Snippet for GetWebpageViewAsync</summary>
        public async Task GetWebpageViewRequestObjectAsync()
        {
            // Snippet: GetWebpageViewAsync(GetWebpageViewRequest, CallSettings)
            // Additional: GetWebpageViewAsync(GetWebpageViewRequest, CancellationToken)
            // Create client
            WebpageViewServiceClient webpageViewServiceClient = await WebpageViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetWebpageViewRequest request = new GetWebpageViewRequest
            {
                ResourceNameAsWebpageViewName = WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            WebpageView response = await webpageViewServiceClient.GetWebpageViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWebpageView</summary>
        public void GetWebpageView()
        {
            // Snippet: GetWebpageView(string, CallSettings)
            // Create client
            WebpageViewServiceClient webpageViewServiceClient = WebpageViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/webpageViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            WebpageView response = webpageViewServiceClient.GetWebpageView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetWebpageViewAsync</summary>
        public async Task GetWebpageViewAsync()
        {
            // Snippet: GetWebpageViewAsync(string, CallSettings)
            // Additional: GetWebpageViewAsync(string, CancellationToken)
            // Create client
            WebpageViewServiceClient webpageViewServiceClient = await WebpageViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/webpageViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            WebpageView response = await webpageViewServiceClient.GetWebpageViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetWebpageView</summary>
        public void GetWebpageViewResourceNames()
        {
            // Snippet: GetWebpageView(WebpageViewName, CallSettings)
            // Create client
            WebpageViewServiceClient webpageViewServiceClient = WebpageViewServiceClient.Create();
            // Initialize request argument(s)
            WebpageViewName resourceName = WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            WebpageView response = webpageViewServiceClient.GetWebpageView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetWebpageViewAsync</summary>
        public async Task GetWebpageViewResourceNamesAsync()
        {
            // Snippet: GetWebpageViewAsync(WebpageViewName, CallSettings)
            // Additional: GetWebpageViewAsync(WebpageViewName, CancellationToken)
            // Create client
            WebpageViewServiceClient webpageViewServiceClient = await WebpageViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            WebpageViewName resourceName = WebpageViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            WebpageView response = await webpageViewServiceClient.GetWebpageViewAsync(resourceName);
            // End snippet
        }
    }
}
