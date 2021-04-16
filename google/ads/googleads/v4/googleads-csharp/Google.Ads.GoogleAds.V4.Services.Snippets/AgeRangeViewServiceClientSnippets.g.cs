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
    public sealed class GeneratedAgeRangeViewServiceClientSnippets
    {
        /// <summary>Snippet for GetAgeRangeView</summary>
        public void GetAgeRangeViewRequestObject()
        {
            // Snippet: GetAgeRangeView(GetAgeRangeViewRequest, CallSettings)
            // Create client
            AgeRangeViewServiceClient ageRangeViewServiceClient = AgeRangeViewServiceClient.Create();
            // Initialize request argument(s)
            GetAgeRangeViewRequest request = new GetAgeRangeViewRequest
            {
                ResourceNameAsAgeRangeViewName = AgeRangeViewName.FromCustomerAgeRangeView("[CUSTOMER]", "[AGE_RANGE_VIEW]"),
            };
            // Make the request
            AgeRangeView response = ageRangeViewServiceClient.GetAgeRangeView(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgeRangeViewAsync</summary>
        public async Task GetAgeRangeViewRequestObjectAsync()
        {
            // Snippet: GetAgeRangeViewAsync(GetAgeRangeViewRequest, CallSettings)
            // Additional: GetAgeRangeViewAsync(GetAgeRangeViewRequest, CancellationToken)
            // Create client
            AgeRangeViewServiceClient ageRangeViewServiceClient = await AgeRangeViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAgeRangeViewRequest request = new GetAgeRangeViewRequest
            {
                ResourceNameAsAgeRangeViewName = AgeRangeViewName.FromCustomerAgeRangeView("[CUSTOMER]", "[AGE_RANGE_VIEW]"),
            };
            // Make the request
            AgeRangeView response = await ageRangeViewServiceClient.GetAgeRangeViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgeRangeView</summary>
        public void GetAgeRangeView()
        {
            // Snippet: GetAgeRangeView(string, CallSettings)
            // Create client
            AgeRangeViewServiceClient ageRangeViewServiceClient = AgeRangeViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/ageRangeViews/[AGE_RANGE_VIEW]";
            // Make the request
            AgeRangeView response = ageRangeViewServiceClient.GetAgeRangeView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAgeRangeViewAsync</summary>
        public async Task GetAgeRangeViewAsync()
        {
            // Snippet: GetAgeRangeViewAsync(string, CallSettings)
            // Additional: GetAgeRangeViewAsync(string, CancellationToken)
            // Create client
            AgeRangeViewServiceClient ageRangeViewServiceClient = await AgeRangeViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/ageRangeViews/[AGE_RANGE_VIEW]";
            // Make the request
            AgeRangeView response = await ageRangeViewServiceClient.GetAgeRangeViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAgeRangeView</summary>
        public void GetAgeRangeViewResourceNames()
        {
            // Snippet: GetAgeRangeView(AgeRangeViewName, CallSettings)
            // Create client
            AgeRangeViewServiceClient ageRangeViewServiceClient = AgeRangeViewServiceClient.Create();
            // Initialize request argument(s)
            AgeRangeViewName resourceName = AgeRangeViewName.FromCustomerAgeRangeView("[CUSTOMER]", "[AGE_RANGE_VIEW]");
            // Make the request
            AgeRangeView response = ageRangeViewServiceClient.GetAgeRangeView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAgeRangeViewAsync</summary>
        public async Task GetAgeRangeViewResourceNamesAsync()
        {
            // Snippet: GetAgeRangeViewAsync(AgeRangeViewName, CallSettings)
            // Additional: GetAgeRangeViewAsync(AgeRangeViewName, CancellationToken)
            // Create client
            AgeRangeViewServiceClient ageRangeViewServiceClient = await AgeRangeViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            AgeRangeViewName resourceName = AgeRangeViewName.FromCustomerAgeRangeView("[CUSTOMER]", "[AGE_RANGE_VIEW]");
            // Make the request
            AgeRangeView response = await ageRangeViewServiceClient.GetAgeRangeViewAsync(resourceName);
            // End snippet
        }
    }
}
