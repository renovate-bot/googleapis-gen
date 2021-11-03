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
    using Google.Ads.GoogleAds.V9.Services;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCustomerClientServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetCustomerClientAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetCustomerClientResourceNamesAsync()
        {
            // Create client
            CustomerClientServiceClient customerClientServiceClient = await CustomerClientServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomerClientName resourceName = CustomerClientName.FromCustomerClientCustomer("[CUSTOMER_ID]", "[CLIENT_CUSTOMER_ID]");
            // Make the request
            CustomerClient response = await customerClientServiceClient.GetCustomerClientAsync(resourceName);
        }
    }
}
