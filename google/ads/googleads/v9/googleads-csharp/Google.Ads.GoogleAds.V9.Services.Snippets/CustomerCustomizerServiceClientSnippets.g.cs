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
    using Google.Ads.GoogleAds.V9.Enums;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomerCustomizerServiceClientSnippets
    {
        /// <summary>Snippet for MutateCustomerCustomizers</summary>
        public void MutateCustomerCustomizersRequestObject()
        {
            // Snippet: MutateCustomerCustomizers(MutateCustomerCustomizersRequest, CallSettings)
            // Create client
            CustomerCustomizerServiceClient customerCustomizerServiceClient = CustomerCustomizerServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomerCustomizersRequest request = new MutateCustomerCustomizersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomerCustomizersResponse response = customerCustomizerServiceClient.MutateCustomerCustomizers(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerCustomizersAsync</summary>
        public async Task MutateCustomerCustomizersRequestObjectAsync()
        {
            // Snippet: MutateCustomerCustomizersAsync(MutateCustomerCustomizersRequest, CallSettings)
            // Additional: MutateCustomerCustomizersAsync(MutateCustomerCustomizersRequest, CancellationToken)
            // Create client
            CustomerCustomizerServiceClient customerCustomizerServiceClient = await CustomerCustomizerServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomerCustomizersRequest request = new MutateCustomerCustomizersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomerCustomizersResponse response = await customerCustomizerServiceClient.MutateCustomerCustomizersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerCustomizers</summary>
        public void MutateCustomerCustomizers()
        {
            // Snippet: MutateCustomerCustomizers(string, IEnumerable<CustomerCustomizerOperation>, CallSettings)
            // Create client
            CustomerCustomizerServiceClient customerCustomizerServiceClient = CustomerCustomizerServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerCustomizerOperation> operations = new CustomerCustomizerOperation[]
            {
                new CustomerCustomizerOperation(),
            };
            // Make the request
            MutateCustomerCustomizersResponse response = customerCustomizerServiceClient.MutateCustomerCustomizers(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerCustomizersAsync</summary>
        public async Task MutateCustomerCustomizersAsync()
        {
            // Snippet: MutateCustomerCustomizersAsync(string, IEnumerable<CustomerCustomizerOperation>, CallSettings)
            // Additional: MutateCustomerCustomizersAsync(string, IEnumerable<CustomerCustomizerOperation>, CancellationToken)
            // Create client
            CustomerCustomizerServiceClient customerCustomizerServiceClient = await CustomerCustomizerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerCustomizerOperation> operations = new CustomerCustomizerOperation[]
            {
                new CustomerCustomizerOperation(),
            };
            // Make the request
            MutateCustomerCustomizersResponse response = await customerCustomizerServiceClient.MutateCustomerCustomizersAsync(customerId, operations);
            // End snippet
        }
    }
}
