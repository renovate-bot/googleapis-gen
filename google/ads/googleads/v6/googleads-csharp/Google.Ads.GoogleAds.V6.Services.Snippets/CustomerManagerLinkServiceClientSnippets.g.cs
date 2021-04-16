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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomerManagerLinkServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomerManagerLink</summary>
        public void GetCustomerManagerLinkRequestObject()
        {
            // Snippet: GetCustomerManagerLink(GetCustomerManagerLinkRequest, CallSettings)
            // Create client
            CustomerManagerLinkServiceClient customerManagerLinkServiceClient = CustomerManagerLinkServiceClient.Create();
            // Initialize request argument(s)
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]"),
            };
            // Make the request
            CustomerManagerLink response = customerManagerLinkServiceClient.GetCustomerManagerLink(request);
            // End snippet
        }

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

        /// <summary>Snippet for GetCustomerManagerLink</summary>
        public void GetCustomerManagerLink()
        {
            // Snippet: GetCustomerManagerLink(string, CallSettings)
            // Create client
            CustomerManagerLinkServiceClient customerManagerLinkServiceClient = CustomerManagerLinkServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerManagerLinks/[MANAGER_CUSTOMER_ID]~[MANAGER_LINK_ID]";
            // Make the request
            CustomerManagerLink response = customerManagerLinkServiceClient.GetCustomerManagerLink(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerManagerLinkAsync</summary>
        public async Task GetCustomerManagerLinkAsync()
        {
            // Snippet: GetCustomerManagerLinkAsync(string, CallSettings)
            // Additional: GetCustomerManagerLinkAsync(string, CancellationToken)
            // Create client
            CustomerManagerLinkServiceClient customerManagerLinkServiceClient = await CustomerManagerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerManagerLinks/[MANAGER_CUSTOMER_ID]~[MANAGER_LINK_ID]";
            // Make the request
            CustomerManagerLink response = await customerManagerLinkServiceClient.GetCustomerManagerLinkAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerManagerLink</summary>
        public void GetCustomerManagerLinkResourceNames()
        {
            // Snippet: GetCustomerManagerLink(CustomerManagerLinkName, CallSettings)
            // Create client
            CustomerManagerLinkServiceClient customerManagerLinkServiceClient = CustomerManagerLinkServiceClient.Create();
            // Initialize request argument(s)
            CustomerManagerLinkName resourceName = CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]");
            // Make the request
            CustomerManagerLink response = customerManagerLinkServiceClient.GetCustomerManagerLink(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerManagerLinkAsync</summary>
        public async Task GetCustomerManagerLinkResourceNamesAsync()
        {
            // Snippet: GetCustomerManagerLinkAsync(CustomerManagerLinkName, CallSettings)
            // Additional: GetCustomerManagerLinkAsync(CustomerManagerLinkName, CancellationToken)
            // Create client
            CustomerManagerLinkServiceClient customerManagerLinkServiceClient = await CustomerManagerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomerManagerLinkName resourceName = CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]");
            // Make the request
            CustomerManagerLink response = await customerManagerLinkServiceClient.GetCustomerManagerLinkAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerManagerLink</summary>
        public void MutateCustomerManagerLinkRequestObject()
        {
            // Snippet: MutateCustomerManagerLink(MutateCustomerManagerLinkRequest, CallSettings)
            // Create client
            CustomerManagerLinkServiceClient customerManagerLinkServiceClient = CustomerManagerLinkServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomerManagerLinkRequest request = new MutateCustomerManagerLinkRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerManagerLinkOperation(),
                },
            };
            // Make the request
            MutateCustomerManagerLinkResponse response = customerManagerLinkServiceClient.MutateCustomerManagerLink(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerManagerLinkAsync</summary>
        public async Task MutateCustomerManagerLinkRequestObjectAsync()
        {
            // Snippet: MutateCustomerManagerLinkAsync(MutateCustomerManagerLinkRequest, CallSettings)
            // Additional: MutateCustomerManagerLinkAsync(MutateCustomerManagerLinkRequest, CancellationToken)
            // Create client
            CustomerManagerLinkServiceClient customerManagerLinkServiceClient = await CustomerManagerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomerManagerLinkRequest request = new MutateCustomerManagerLinkRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerManagerLinkOperation(),
                },
            };
            // Make the request
            MutateCustomerManagerLinkResponse response = await customerManagerLinkServiceClient.MutateCustomerManagerLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerManagerLink</summary>
        public void MutateCustomerManagerLink()
        {
            // Snippet: MutateCustomerManagerLink(string, IEnumerable<CustomerManagerLinkOperation>, CallSettings)
            // Create client
            CustomerManagerLinkServiceClient customerManagerLinkServiceClient = CustomerManagerLinkServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerManagerLinkOperation> operations = new CustomerManagerLinkOperation[]
            {
                new CustomerManagerLinkOperation(),
            };
            // Make the request
            MutateCustomerManagerLinkResponse response = customerManagerLinkServiceClient.MutateCustomerManagerLink(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerManagerLinkAsync</summary>
        public async Task MutateCustomerManagerLinkAsync()
        {
            // Snippet: MutateCustomerManagerLinkAsync(string, IEnumerable<CustomerManagerLinkOperation>, CallSettings)
            // Additional: MutateCustomerManagerLinkAsync(string, IEnumerable<CustomerManagerLinkOperation>, CancellationToken)
            // Create client
            CustomerManagerLinkServiceClient customerManagerLinkServiceClient = await CustomerManagerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerManagerLinkOperation> operations = new CustomerManagerLinkOperation[]
            {
                new CustomerManagerLinkOperation(),
            };
            // Make the request
            MutateCustomerManagerLinkResponse response = await customerManagerLinkServiceClient.MutateCustomerManagerLinkAsync(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MoveManagerLink</summary>
        public void MoveManagerLinkRequestObject()
        {
            // Snippet: MoveManagerLink(MoveManagerLinkRequest, CallSettings)
            // Create client
            CustomerManagerLinkServiceClient customerManagerLinkServiceClient = CustomerManagerLinkServiceClient.Create();
            // Initialize request argument(s)
            MoveManagerLinkRequest request = new MoveManagerLinkRequest
            {
                CustomerId = "",
                PreviousCustomerManagerLink = "",
                NewManager = "",
            };
            // Make the request
            MoveManagerLinkResponse response = customerManagerLinkServiceClient.MoveManagerLink(request);
            // End snippet
        }

        /// <summary>Snippet for MoveManagerLinkAsync</summary>
        public async Task MoveManagerLinkRequestObjectAsync()
        {
            // Snippet: MoveManagerLinkAsync(MoveManagerLinkRequest, CallSettings)
            // Additional: MoveManagerLinkAsync(MoveManagerLinkRequest, CancellationToken)
            // Create client
            CustomerManagerLinkServiceClient customerManagerLinkServiceClient = await CustomerManagerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            MoveManagerLinkRequest request = new MoveManagerLinkRequest
            {
                CustomerId = "",
                PreviousCustomerManagerLink = "",
                NewManager = "",
            };
            // Make the request
            MoveManagerLinkResponse response = await customerManagerLinkServiceClient.MoveManagerLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MoveManagerLink</summary>
        public void MoveManagerLink()
        {
            // Snippet: MoveManagerLink(string, string, string, CallSettings)
            // Create client
            CustomerManagerLinkServiceClient customerManagerLinkServiceClient = CustomerManagerLinkServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            string previousCustomerManagerLink = "";
            string newManager = "";
            // Make the request
            MoveManagerLinkResponse response = customerManagerLinkServiceClient.MoveManagerLink(customerId, previousCustomerManagerLink, newManager);
            // End snippet
        }

        /// <summary>Snippet for MoveManagerLinkAsync</summary>
        public async Task MoveManagerLinkAsync()
        {
            // Snippet: MoveManagerLinkAsync(string, string, string, CallSettings)
            // Additional: MoveManagerLinkAsync(string, string, string, CancellationToken)
            // Create client
            CustomerManagerLinkServiceClient customerManagerLinkServiceClient = await CustomerManagerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            string previousCustomerManagerLink = "";
            string newManager = "";
            // Make the request
            MoveManagerLinkResponse response = await customerManagerLinkServiceClient.MoveManagerLinkAsync(customerId, previousCustomerManagerLink, newManager);
            // End snippet
        }
    }
}
