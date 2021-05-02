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
    using Google.Ads.GoogleAds.V7.Enums;
    using Google.Ads.GoogleAds.V7.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomerFeedServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomerFeed</summary>
        public void GetCustomerFeedRequestObject()
        {
            // Snippet: GetCustomerFeed(GetCustomerFeedRequest, CallSettings)
            // Create client
            CustomerFeedServiceClient customerFeedServiceClient = CustomerFeedServiceClient.Create();
            // Initialize request argument(s)
            GetCustomerFeedRequest request = new GetCustomerFeedRequest
            {
                ResourceNameAsCustomerFeedName = CustomerFeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
            };
            // Make the request
            CustomerFeed response = customerFeedServiceClient.GetCustomerFeed(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerFeedAsync</summary>
        public async Task GetCustomerFeedRequestObjectAsync()
        {
            // Snippet: GetCustomerFeedAsync(GetCustomerFeedRequest, CallSettings)
            // Additional: GetCustomerFeedAsync(GetCustomerFeedRequest, CancellationToken)
            // Create client
            CustomerFeedServiceClient customerFeedServiceClient = await CustomerFeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomerFeedRequest request = new GetCustomerFeedRequest
            {
                ResourceNameAsCustomerFeedName = CustomerFeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
            };
            // Make the request
            CustomerFeed response = await customerFeedServiceClient.GetCustomerFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerFeed</summary>
        public void GetCustomerFeed()
        {
            // Snippet: GetCustomerFeed(string, CallSettings)
            // Create client
            CustomerFeedServiceClient customerFeedServiceClient = CustomerFeedServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerFeeds/[FEED_ID]";
            // Make the request
            CustomerFeed response = customerFeedServiceClient.GetCustomerFeed(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerFeedAsync</summary>
        public async Task GetCustomerFeedAsync()
        {
            // Snippet: GetCustomerFeedAsync(string, CallSettings)
            // Additional: GetCustomerFeedAsync(string, CancellationToken)
            // Create client
            CustomerFeedServiceClient customerFeedServiceClient = await CustomerFeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerFeeds/[FEED_ID]";
            // Make the request
            CustomerFeed response = await customerFeedServiceClient.GetCustomerFeedAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerFeed</summary>
        public void GetCustomerFeedResourceNames()
        {
            // Snippet: GetCustomerFeed(CustomerFeedName, CallSettings)
            // Create client
            CustomerFeedServiceClient customerFeedServiceClient = CustomerFeedServiceClient.Create();
            // Initialize request argument(s)
            CustomerFeedName resourceName = CustomerFeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]");
            // Make the request
            CustomerFeed response = customerFeedServiceClient.GetCustomerFeed(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerFeedAsync</summary>
        public async Task GetCustomerFeedResourceNamesAsync()
        {
            // Snippet: GetCustomerFeedAsync(CustomerFeedName, CallSettings)
            // Additional: GetCustomerFeedAsync(CustomerFeedName, CancellationToken)
            // Create client
            CustomerFeedServiceClient customerFeedServiceClient = await CustomerFeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomerFeedName resourceName = CustomerFeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]");
            // Make the request
            CustomerFeed response = await customerFeedServiceClient.GetCustomerFeedAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerFeeds</summary>
        public void MutateCustomerFeedsRequestObject()
        {
            // Snippet: MutateCustomerFeeds(MutateCustomerFeedsRequest, CallSettings)
            // Create client
            CustomerFeedServiceClient customerFeedServiceClient = CustomerFeedServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomerFeedsRequest request = new MutateCustomerFeedsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerFeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomerFeedsResponse response = customerFeedServiceClient.MutateCustomerFeeds(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerFeedsAsync</summary>
        public async Task MutateCustomerFeedsRequestObjectAsync()
        {
            // Snippet: MutateCustomerFeedsAsync(MutateCustomerFeedsRequest, CallSettings)
            // Additional: MutateCustomerFeedsAsync(MutateCustomerFeedsRequest, CancellationToken)
            // Create client
            CustomerFeedServiceClient customerFeedServiceClient = await CustomerFeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomerFeedsRequest request = new MutateCustomerFeedsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerFeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomerFeedsResponse response = await customerFeedServiceClient.MutateCustomerFeedsAsync(request);
            // End snippet
        }

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

        /// <summary>Snippet for MutateCustomerFeedsAsync</summary>
        public async Task MutateCustomerFeedsAsync()
        {
            // Snippet: MutateCustomerFeedsAsync(string, IEnumerable<CustomerFeedOperation>, CallSettings)
            // Additional: MutateCustomerFeedsAsync(string, IEnumerable<CustomerFeedOperation>, CancellationToken)
            // Create client
            CustomerFeedServiceClient customerFeedServiceClient = await CustomerFeedServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerFeedOperation> operations = new CustomerFeedOperation[]
            {
                new CustomerFeedOperation(),
            };
            // Make the request
            MutateCustomerFeedsResponse response = await customerFeedServiceClient.MutateCustomerFeedsAsync(customerId, operations);
            // End snippet
        }
    }
}
