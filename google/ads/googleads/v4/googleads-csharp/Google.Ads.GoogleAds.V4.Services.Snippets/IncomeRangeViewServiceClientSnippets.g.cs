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
    public sealed class GeneratedIncomeRangeViewServiceClientSnippets
    {
        /// <summary>Snippet for GetIncomeRangeView</summary>
        public void GetIncomeRangeViewRequestObject()
        {
            // Snippet: GetIncomeRangeView(GetIncomeRangeViewRequest, CallSettings)
            // Create client
            IncomeRangeViewServiceClient incomeRangeViewServiceClient = IncomeRangeViewServiceClient.Create();
            // Initialize request argument(s)
            GetIncomeRangeViewRequest request = new GetIncomeRangeViewRequest
            {
                ResourceNameAsIncomeRangeViewName = IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]"),
            };
            // Make the request
            IncomeRangeView response = incomeRangeViewServiceClient.GetIncomeRangeView(request);
            // End snippet
        }

        /// <summary>Snippet for GetIncomeRangeViewAsync</summary>
        public async Task GetIncomeRangeViewRequestObjectAsync()
        {
            // Snippet: GetIncomeRangeViewAsync(GetIncomeRangeViewRequest, CallSettings)
            // Additional: GetIncomeRangeViewAsync(GetIncomeRangeViewRequest, CancellationToken)
            // Create client
            IncomeRangeViewServiceClient incomeRangeViewServiceClient = await IncomeRangeViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIncomeRangeViewRequest request = new GetIncomeRangeViewRequest
            {
                ResourceNameAsIncomeRangeViewName = IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]"),
            };
            // Make the request
            IncomeRangeView response = await incomeRangeViewServiceClient.GetIncomeRangeViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIncomeRangeView</summary>
        public void GetIncomeRangeView()
        {
            // Snippet: GetIncomeRangeView(string, CallSettings)
            // Create client
            IncomeRangeViewServiceClient incomeRangeViewServiceClient = IncomeRangeViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/incomeRangeViews/[INCOME_RANGE_VIEW]";
            // Make the request
            IncomeRangeView response = incomeRangeViewServiceClient.GetIncomeRangeView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetIncomeRangeViewAsync</summary>
        public async Task GetIncomeRangeViewAsync()
        {
            // Snippet: GetIncomeRangeViewAsync(string, CallSettings)
            // Additional: GetIncomeRangeViewAsync(string, CancellationToken)
            // Create client
            IncomeRangeViewServiceClient incomeRangeViewServiceClient = await IncomeRangeViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/incomeRangeViews/[INCOME_RANGE_VIEW]";
            // Make the request
            IncomeRangeView response = await incomeRangeViewServiceClient.GetIncomeRangeViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetIncomeRangeView</summary>
        public void GetIncomeRangeViewResourceNames()
        {
            // Snippet: GetIncomeRangeView(IncomeRangeViewName, CallSettings)
            // Create client
            IncomeRangeViewServiceClient incomeRangeViewServiceClient = IncomeRangeViewServiceClient.Create();
            // Initialize request argument(s)
            IncomeRangeViewName resourceName = IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]");
            // Make the request
            IncomeRangeView response = incomeRangeViewServiceClient.GetIncomeRangeView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetIncomeRangeViewAsync</summary>
        public async Task GetIncomeRangeViewResourceNamesAsync()
        {
            // Snippet: GetIncomeRangeViewAsync(IncomeRangeViewName, CallSettings)
            // Additional: GetIncomeRangeViewAsync(IncomeRangeViewName, CancellationToken)
            // Create client
            IncomeRangeViewServiceClient incomeRangeViewServiceClient = await IncomeRangeViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            IncomeRangeViewName resourceName = IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]");
            // Make the request
            IncomeRangeView response = await incomeRangeViewServiceClient.GetIncomeRangeViewAsync(resourceName);
            // End snippet
        }
    }
}
