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
    public sealed class GeneratedParentalStatusViewServiceClientSnippets
    {
        /// <summary>Snippet for GetParentalStatusView</summary>
        public void GetParentalStatusViewRequestObject()
        {
            // Snippet: GetParentalStatusView(GetParentalStatusViewRequest, CallSettings)
            // Create client
            ParentalStatusViewServiceClient parentalStatusViewServiceClient = ParentalStatusViewServiceClient.Create();
            // Initialize request argument(s)
            GetParentalStatusViewRequest request = new GetParentalStatusViewRequest
            {
                ResourceNameAsParentalStatusViewName = ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            ParentalStatusView response = parentalStatusViewServiceClient.GetParentalStatusView(request);
            // End snippet
        }

        /// <summary>Snippet for GetParentalStatusViewAsync</summary>
        public async Task GetParentalStatusViewRequestObjectAsync()
        {
            // Snippet: GetParentalStatusViewAsync(GetParentalStatusViewRequest, CallSettings)
            // Additional: GetParentalStatusViewAsync(GetParentalStatusViewRequest, CancellationToken)
            // Create client
            ParentalStatusViewServiceClient parentalStatusViewServiceClient = await ParentalStatusViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetParentalStatusViewRequest request = new GetParentalStatusViewRequest
            {
                ResourceNameAsParentalStatusViewName = ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            ParentalStatusView response = await parentalStatusViewServiceClient.GetParentalStatusViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetParentalStatusView</summary>
        public void GetParentalStatusView()
        {
            // Snippet: GetParentalStatusView(string, CallSettings)
            // Create client
            ParentalStatusViewServiceClient parentalStatusViewServiceClient = ParentalStatusViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/parentalStatusViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            ParentalStatusView response = parentalStatusViewServiceClient.GetParentalStatusView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetParentalStatusViewAsync</summary>
        public async Task GetParentalStatusViewAsync()
        {
            // Snippet: GetParentalStatusViewAsync(string, CallSettings)
            // Additional: GetParentalStatusViewAsync(string, CancellationToken)
            // Create client
            ParentalStatusViewServiceClient parentalStatusViewServiceClient = await ParentalStatusViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/parentalStatusViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            ParentalStatusView response = await parentalStatusViewServiceClient.GetParentalStatusViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetParentalStatusView</summary>
        public void GetParentalStatusViewResourceNames()
        {
            // Snippet: GetParentalStatusView(ParentalStatusViewName, CallSettings)
            // Create client
            ParentalStatusViewServiceClient parentalStatusViewServiceClient = ParentalStatusViewServiceClient.Create();
            // Initialize request argument(s)
            ParentalStatusViewName resourceName = ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            ParentalStatusView response = parentalStatusViewServiceClient.GetParentalStatusView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetParentalStatusViewAsync</summary>
        public async Task GetParentalStatusViewResourceNamesAsync()
        {
            // Snippet: GetParentalStatusViewAsync(ParentalStatusViewName, CallSettings)
            // Additional: GetParentalStatusViewAsync(ParentalStatusViewName, CancellationToken)
            // Create client
            ParentalStatusViewServiceClient parentalStatusViewServiceClient = await ParentalStatusViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            ParentalStatusViewName resourceName = ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            ParentalStatusView response = await parentalStatusViewServiceClient.GetParentalStatusViewAsync(resourceName);
            // End snippet
        }
    }
}
