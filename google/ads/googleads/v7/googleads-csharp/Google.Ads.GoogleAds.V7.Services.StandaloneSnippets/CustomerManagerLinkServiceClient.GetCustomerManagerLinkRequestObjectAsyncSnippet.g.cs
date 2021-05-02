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

    public sealed partial class GeneratedCustomerManagerLinkServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetCustomerManagerLinkAsync</summary>
        public async Task GetCustomerManagerLinkRequestObjectAsync()
        {
            // Snippet: GetCustomerManagerLinkAsync(GetCustomerManagerLinkRequest, CallSettings)
            // Additional: GetCustomerManagerLinkAsync(GetCustomerManagerLinkRequest, CancellationToken)
            // Create client
            CustomerManagerLinkServiceClient customerManagerLinkServiceClient = await CustomerManagerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]"),
            };
            // Make the request
            CustomerManagerLink response = await customerManagerLinkServiceClient.GetCustomerManagerLinkAsync(request);
            // End snippet
        }
    }
}
