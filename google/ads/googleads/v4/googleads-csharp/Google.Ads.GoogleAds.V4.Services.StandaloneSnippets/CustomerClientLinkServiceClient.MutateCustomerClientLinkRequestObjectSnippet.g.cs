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
    public sealed partial class GeneratedCustomerClientLinkServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for MutateCustomerClientLink</summary>
        public void MutateCustomerClientLinkRequestObject()
        {
            // Snippet: MutateCustomerClientLink(MutateCustomerClientLinkRequest, CallSettings)
            // Create client
            CustomerClientLinkServiceClient customerClientLinkServiceClient = CustomerClientLinkServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomerClientLinkRequest request = new MutateCustomerClientLinkRequest
            {
                CustomerId = "",
                Operation = new CustomerClientLinkOperation(),
            };
            // Make the request
            MutateCustomerClientLinkResponse response = customerClientLinkServiceClient.MutateCustomerClientLink(request);
            // End snippet
        }
    }
}
