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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCustomerLabelServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for MutateCustomerLabelsAsync</summary>
        public async Task MutateCustomerLabelsAsync()
        {
            // Snippet: MutateCustomerLabelsAsync(string, IEnumerable<CustomerLabelOperation>, CallSettings)
            // Additional: MutateCustomerLabelsAsync(string, IEnumerable<CustomerLabelOperation>, CancellationToken)
            // Create client
            CustomerLabelServiceClient customerLabelServiceClient = await CustomerLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerLabelOperation> operations = new CustomerLabelOperation[]
            {
                new CustomerLabelOperation(),
            };
            // Make the request
            MutateCustomerLabelsResponse response = await customerLabelServiceClient.MutateCustomerLabelsAsync(customerId, operations);
            // End snippet
        }
    }
}
