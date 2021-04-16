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

namespace Google.Ads.GoogleAds.V5.Services.Snippets
{
    using System.Collections.Generic;

    public sealed partial class GeneratedCustomerFeedServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for MutateCustomerFeeds</summary>
        public void MutateCustomerFeeds()
        {
            // Snippet: MutateCustomerFeeds(string, IEnumerable<CustomerFeedOperation>, CallSettings)
            // Create client
            CustomerFeedServiceClient customerFeedServiceClient = CustomerFeedServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerFeedOperation> operations = new CustomerFeedOperation[]
            {
                new CustomerFeedOperation(),
            };
            // Make the request
            MutateCustomerFeedsResponse response = customerFeedServiceClient.MutateCustomerFeeds(customerId, operations);
            // End snippet
        }
    }
}
