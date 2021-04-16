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
    public sealed class GeneratedGenderViewServiceClientSnippets
    {
        /// <summary>Snippet for GetGenderView</summary>
        public void GetGenderViewRequestObject()
        {
            // Snippet: GetGenderView(GetGenderViewRequest, CallSettings)
            // Create client
            GenderViewServiceClient genderViewServiceClient = GenderViewServiceClient.Create();
            // Initialize request argument(s)
            GetGenderViewRequest request = new GetGenderViewRequest
            {
                ResourceNameAsGenderViewName = GenderViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            GenderView response = genderViewServiceClient.GetGenderView(request);
            // End snippet
        }

        /// <summary>Snippet for GetGenderViewAsync</summary>
        public async Task GetGenderViewRequestObjectAsync()
        {
            // Snippet: GetGenderViewAsync(GetGenderViewRequest, CallSettings)
            // Additional: GetGenderViewAsync(GetGenderViewRequest, CancellationToken)
            // Create client
            GenderViewServiceClient genderViewServiceClient = await GenderViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGenderViewRequest request = new GetGenderViewRequest
            {
                ResourceNameAsGenderViewName = GenderViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            GenderView response = await genderViewServiceClient.GetGenderViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGenderView</summary>
        public void GetGenderView()
        {
            // Snippet: GetGenderView(string, CallSettings)
            // Create client
            GenderViewServiceClient genderViewServiceClient = GenderViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/genderViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            GenderView response = genderViewServiceClient.GetGenderView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetGenderViewAsync</summary>
        public async Task GetGenderViewAsync()
        {
            // Snippet: GetGenderViewAsync(string, CallSettings)
            // Additional: GetGenderViewAsync(string, CancellationToken)
            // Create client
            GenderViewServiceClient genderViewServiceClient = await GenderViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/genderViews/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            GenderView response = await genderViewServiceClient.GetGenderViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetGenderView</summary>
        public void GetGenderViewResourceNames()
        {
            // Snippet: GetGenderView(GenderViewName, CallSettings)
            // Create client
            GenderViewServiceClient genderViewServiceClient = GenderViewServiceClient.Create();
            // Initialize request argument(s)
            GenderViewName resourceName = GenderViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            GenderView response = genderViewServiceClient.GetGenderView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetGenderViewAsync</summary>
        public async Task GetGenderViewResourceNamesAsync()
        {
            // Snippet: GetGenderViewAsync(GenderViewName, CallSettings)
            // Additional: GetGenderViewAsync(GenderViewName, CancellationToken)
            // Create client
            GenderViewServiceClient genderViewServiceClient = await GenderViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenderViewName resourceName = GenderViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            GenderView response = await genderViewServiceClient.GetGenderViewAsync(resourceName);
            // End snippet
        }
    }
}
