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
    using Google.Ads.GoogleAds.V5.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomerClientLinkServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomerClientLink</summary>
        public void GetCustomerClientLinkRequestObject()
        {
            // Snippet: GetCustomerClientLink(GetCustomerClientLinkRequest, CallSettings)
            // Create client
            CustomerClientLinkServiceClient customerClientLinkServiceClient = CustomerClientLinkServiceClient.Create();
            // Initialize request argument(s)
            GetCustomerClientLinkRequest request = new GetCustomerClientLinkRequest
            {
                ResourceNameAsCustomerClientLinkName = CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]"),
            };
            // Make the request
            CustomerClientLink response = customerClientLinkServiceClient.GetCustomerClientLink(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerClientLinkAsync</summary>
        public async Task GetCustomerClientLinkRequestObjectAsync()
        {
            // Snippet: GetCustomerClientLinkAsync(GetCustomerClientLinkRequest, CallSettings)
            // Additional: GetCustomerClientLinkAsync(GetCustomerClientLinkRequest, CancellationToken)
            // Create client
            CustomerClientLinkServiceClient customerClientLinkServiceClient = await CustomerClientLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomerClientLinkRequest request = new GetCustomerClientLinkRequest
            {
                ResourceNameAsCustomerClientLinkName = CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]"),
            };
            // Make the request
            CustomerClientLink response = await customerClientLinkServiceClient.GetCustomerClientLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerClientLink</summary>
        public void GetCustomerClientLink()
        {
            // Snippet: GetCustomerClientLink(string, CallSettings)
            // Create client
            CustomerClientLinkServiceClient customerClientLinkServiceClient = CustomerClientLinkServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/customerClientLinks/[CUSTOMER_CLIENT_LINK]";
            // Make the request
            CustomerClientLink response = customerClientLinkServiceClient.GetCustomerClientLink(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerClientLinkAsync</summary>
        public async Task GetCustomerClientLinkAsync()
        {
            // Snippet: GetCustomerClientLinkAsync(string, CallSettings)
            // Additional: GetCustomerClientLinkAsync(string, CancellationToken)
            // Create client
            CustomerClientLinkServiceClient customerClientLinkServiceClient = await CustomerClientLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/customerClientLinks/[CUSTOMER_CLIENT_LINK]";
            // Make the request
            CustomerClientLink response = await customerClientLinkServiceClient.GetCustomerClientLinkAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerClientLink</summary>
        public void GetCustomerClientLinkResourceNames()
        {
            // Snippet: GetCustomerClientLink(CustomerClientLinkName, CallSettings)
            // Create client
            CustomerClientLinkServiceClient customerClientLinkServiceClient = CustomerClientLinkServiceClient.Create();
            // Initialize request argument(s)
            CustomerClientLinkName resourceName = CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]");
            // Make the request
            CustomerClientLink response = customerClientLinkServiceClient.GetCustomerClientLink(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerClientLinkAsync</summary>
        public async Task GetCustomerClientLinkResourceNamesAsync()
        {
            // Snippet: GetCustomerClientLinkAsync(CustomerClientLinkName, CallSettings)
            // Additional: GetCustomerClientLinkAsync(CustomerClientLinkName, CancellationToken)
            // Create client
            CustomerClientLinkServiceClient customerClientLinkServiceClient = await CustomerClientLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomerClientLinkName resourceName = CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]");
            // Make the request
            CustomerClientLink response = await customerClientLinkServiceClient.GetCustomerClientLinkAsync(resourceName);
            // End snippet
        }

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

        /// <summary>Snippet for MutateCustomerClientLinkAsync</summary>
        public async Task MutateCustomerClientLinkRequestObjectAsync()
        {
            // Snippet: MutateCustomerClientLinkAsync(MutateCustomerClientLinkRequest, CallSettings)
            // Additional: MutateCustomerClientLinkAsync(MutateCustomerClientLinkRequest, CancellationToken)
            // Create client
            CustomerClientLinkServiceClient customerClientLinkServiceClient = await CustomerClientLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomerClientLinkRequest request = new MutateCustomerClientLinkRequest
            {
                CustomerId = "",
                Operation = new CustomerClientLinkOperation(),
            };
            // Make the request
            MutateCustomerClientLinkResponse response = await customerClientLinkServiceClient.MutateCustomerClientLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerClientLink</summary>
        public void MutateCustomerClientLink()
        {
            // Snippet: MutateCustomerClientLink(string, CustomerClientLinkOperation, CallSettings)
            // Create client
            CustomerClientLinkServiceClient customerClientLinkServiceClient = CustomerClientLinkServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            CustomerClientLinkOperation operation = new CustomerClientLinkOperation();
            // Make the request
            MutateCustomerClientLinkResponse response = customerClientLinkServiceClient.MutateCustomerClientLink(customerId, operation);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerClientLinkAsync</summary>
        public async Task MutateCustomerClientLinkAsync()
        {
            // Snippet: MutateCustomerClientLinkAsync(string, CustomerClientLinkOperation, CallSettings)
            // Additional: MutateCustomerClientLinkAsync(string, CustomerClientLinkOperation, CancellationToken)
            // Create client
            CustomerClientLinkServiceClient customerClientLinkServiceClient = await CustomerClientLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            CustomerClientLinkOperation operation = new CustomerClientLinkOperation();
            // Make the request
            MutateCustomerClientLinkResponse response = await customerClientLinkServiceClient.MutateCustomerClientLinkAsync(customerId, operation);
            // End snippet
        }
    }
}
