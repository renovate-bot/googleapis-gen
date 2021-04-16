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
    public sealed class GeneratedClickViewServiceClientSnippets
    {
        /// <summary>Snippet for GetClickView</summary>
        public void GetClickViewRequestObject()
        {
            // Snippet: GetClickView(GetClickViewRequest, CallSettings)
            // Create client
            ClickViewServiceClient clickViewServiceClient = ClickViewServiceClient.Create();
            // Initialize request argument(s)
            GetClickViewRequest request = new GetClickViewRequest
            {
                ResourceNameAsClickViewName = ClickViewName.FromCustomerDateGclid("[CUSTOMER_ID]", "[DATE]", "[GCLID]"),
            };
            // Make the request
            ClickView response = clickViewServiceClient.GetClickView(request);
            // End snippet
        }

        /// <summary>Snippet for GetClickViewAsync</summary>
        public async Task GetClickViewRequestObjectAsync()
        {
            // Snippet: GetClickViewAsync(GetClickViewRequest, CallSettings)
            // Additional: GetClickViewAsync(GetClickViewRequest, CancellationToken)
            // Create client
            ClickViewServiceClient clickViewServiceClient = await ClickViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetClickViewRequest request = new GetClickViewRequest
            {
                ResourceNameAsClickViewName = ClickViewName.FromCustomerDateGclid("[CUSTOMER_ID]", "[DATE]", "[GCLID]"),
            };
            // Make the request
            ClickView response = await clickViewServiceClient.GetClickViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetClickView</summary>
        public void GetClickView()
        {
            // Snippet: GetClickView(string, CallSettings)
            // Create client
            ClickViewServiceClient clickViewServiceClient = ClickViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/clickViews/[DATE]~[GCLID]";
            // Make the request
            ClickView response = clickViewServiceClient.GetClickView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetClickViewAsync</summary>
        public async Task GetClickViewAsync()
        {
            // Snippet: GetClickViewAsync(string, CallSettings)
            // Additional: GetClickViewAsync(string, CancellationToken)
            // Create client
            ClickViewServiceClient clickViewServiceClient = await ClickViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/clickViews/[DATE]~[GCLID]";
            // Make the request
            ClickView response = await clickViewServiceClient.GetClickViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetClickView</summary>
        public void GetClickViewResourceNames()
        {
            // Snippet: GetClickView(ClickViewName, CallSettings)
            // Create client
            ClickViewServiceClient clickViewServiceClient = ClickViewServiceClient.Create();
            // Initialize request argument(s)
            ClickViewName resourceName = ClickViewName.FromCustomerDateGclid("[CUSTOMER_ID]", "[DATE]", "[GCLID]");
            // Make the request
            ClickView response = clickViewServiceClient.GetClickView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetClickViewAsync</summary>
        public async Task GetClickViewResourceNamesAsync()
        {
            // Snippet: GetClickViewAsync(ClickViewName, CallSettings)
            // Additional: GetClickViewAsync(ClickViewName, CancellationToken)
            // Create client
            ClickViewServiceClient clickViewServiceClient = await ClickViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClickViewName resourceName = ClickViewName.FromCustomerDateGclid("[CUSTOMER_ID]", "[DATE]", "[GCLID]");
            // Make the request
            ClickView response = await clickViewServiceClient.GetClickViewAsync(resourceName);
            // End snippet
        }
    }
}
