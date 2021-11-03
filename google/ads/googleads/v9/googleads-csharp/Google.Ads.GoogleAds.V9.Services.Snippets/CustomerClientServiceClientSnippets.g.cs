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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomerClientServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomerClient</summary>
        public void GetCustomerClientRequestObject()
        {
            // Snippet: GetCustomerClient(GetCustomerClientRequest, CallSettings)
            // Create client
            CustomerClientServiceClient customerClientServiceClient = CustomerClientServiceClient.Create();
            // Initialize request argument(s)
            GetCustomerClientRequest request = new GetCustomerClientRequest
            {
                ResourceNameAsCustomerClientName = CustomerClientName.FromCustomerClientCustomer("[CUSTOMER_ID]", "[CLIENT_CUSTOMER_ID]"),
            };
            // Make the request
            CustomerClient response = customerClientServiceClient.GetCustomerClient(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerClientAsync</summary>
        public async Task GetCustomerClientRequestObjectAsync()
        {
            // Snippet: GetCustomerClientAsync(GetCustomerClientRequest, CallSettings)
            // Additional: GetCustomerClientAsync(GetCustomerClientRequest, CancellationToken)
            // Create client
            CustomerClientServiceClient customerClientServiceClient = await CustomerClientServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomerClientRequest request = new GetCustomerClientRequest
            {
                ResourceNameAsCustomerClientName = CustomerClientName.FromCustomerClientCustomer("[CUSTOMER_ID]", "[CLIENT_CUSTOMER_ID]"),
            };
            // Make the request
            CustomerClient response = await customerClientServiceClient.GetCustomerClientAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerClient</summary>
        public void GetCustomerClient()
        {
            // Snippet: GetCustomerClient(string, CallSettings)
            // Create client
            CustomerClientServiceClient customerClientServiceClient = CustomerClientServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerClients/[CLIENT_CUSTOMER_ID]";
            // Make the request
            CustomerClient response = customerClientServiceClient.GetCustomerClient(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerClientAsync</summary>
        public async Task GetCustomerClientAsync()
        {
            // Snippet: GetCustomerClientAsync(string, CallSettings)
            // Additional: GetCustomerClientAsync(string, CancellationToken)
            // Create client
            CustomerClientServiceClient customerClientServiceClient = await CustomerClientServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerClients/[CLIENT_CUSTOMER_ID]";
            // Make the request
            CustomerClient response = await customerClientServiceClient.GetCustomerClientAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerClient</summary>
        public void GetCustomerClientResourceNames()
        {
            // Snippet: GetCustomerClient(CustomerClientName, CallSettings)
            // Create client
            CustomerClientServiceClient customerClientServiceClient = CustomerClientServiceClient.Create();
            // Initialize request argument(s)
            CustomerClientName resourceName = CustomerClientName.FromCustomerClientCustomer("[CUSTOMER_ID]", "[CLIENT_CUSTOMER_ID]");
            // Make the request
            CustomerClient response = customerClientServiceClient.GetCustomerClient(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerClientAsync</summary>
        public async Task GetCustomerClientResourceNamesAsync()
        {
            // Snippet: GetCustomerClientAsync(CustomerClientName, CallSettings)
            // Additional: GetCustomerClientAsync(CustomerClientName, CancellationToken)
            // Create client
            CustomerClientServiceClient customerClientServiceClient = await CustomerClientServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomerClientName resourceName = CustomerClientName.FromCustomerClientCustomer("[CUSTOMER_ID]", "[CLIENT_CUSTOMER_ID]");
            // Make the request
            CustomerClient response = await customerClientServiceClient.GetCustomerClientAsync(resourceName);
            // End snippet
        }
    }
}
