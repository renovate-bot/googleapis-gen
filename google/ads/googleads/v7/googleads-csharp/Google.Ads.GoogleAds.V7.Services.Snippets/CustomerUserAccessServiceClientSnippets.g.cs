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

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomerUserAccessServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomerUserAccess</summary>
        public void GetCustomerUserAccessRequestObject()
        {
            // Snippet: GetCustomerUserAccess(GetCustomerUserAccessRequest, CallSettings)
            // Create client
            CustomerUserAccessServiceClient customerUserAccessServiceClient = CustomerUserAccessServiceClient.Create();
            // Initialize request argument(s)
            GetCustomerUserAccessRequest request = new GetCustomerUserAccessRequest
            {
                ResourceNameAsCustomerUserAccessName = CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]"),
            };
            // Make the request
            CustomerUserAccess response = customerUserAccessServiceClient.GetCustomerUserAccess(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerUserAccessAsync</summary>
        public async Task GetCustomerUserAccessRequestObjectAsync()
        {
            // Snippet: GetCustomerUserAccessAsync(GetCustomerUserAccessRequest, CallSettings)
            // Additional: GetCustomerUserAccessAsync(GetCustomerUserAccessRequest, CancellationToken)
            // Create client
            CustomerUserAccessServiceClient customerUserAccessServiceClient = await CustomerUserAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomerUserAccessRequest request = new GetCustomerUserAccessRequest
            {
                ResourceNameAsCustomerUserAccessName = CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]"),
            };
            // Make the request
            CustomerUserAccess response = await customerUserAccessServiceClient.GetCustomerUserAccessAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerUserAccess</summary>
        public void GetCustomerUserAccess()
        {
            // Snippet: GetCustomerUserAccess(string, CallSettings)
            // Create client
            CustomerUserAccessServiceClient customerUserAccessServiceClient = CustomerUserAccessServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerUserAccesses/[USER_ID]";
            // Make the request
            CustomerUserAccess response = customerUserAccessServiceClient.GetCustomerUserAccess(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerUserAccessAsync</summary>
        public async Task GetCustomerUserAccessAsync()
        {
            // Snippet: GetCustomerUserAccessAsync(string, CallSettings)
            // Additional: GetCustomerUserAccessAsync(string, CancellationToken)
            // Create client
            CustomerUserAccessServiceClient customerUserAccessServiceClient = await CustomerUserAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerUserAccesses/[USER_ID]";
            // Make the request
            CustomerUserAccess response = await customerUserAccessServiceClient.GetCustomerUserAccessAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerUserAccess</summary>
        public void GetCustomerUserAccessResourceNames()
        {
            // Snippet: GetCustomerUserAccess(CustomerUserAccessName, CallSettings)
            // Create client
            CustomerUserAccessServiceClient customerUserAccessServiceClient = CustomerUserAccessServiceClient.Create();
            // Initialize request argument(s)
            CustomerUserAccessName resourceName = CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]");
            // Make the request
            CustomerUserAccess response = customerUserAccessServiceClient.GetCustomerUserAccess(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerUserAccessAsync</summary>
        public async Task GetCustomerUserAccessResourceNamesAsync()
        {
            // Snippet: GetCustomerUserAccessAsync(CustomerUserAccessName, CallSettings)
            // Additional: GetCustomerUserAccessAsync(CustomerUserAccessName, CancellationToken)
            // Create client
            CustomerUserAccessServiceClient customerUserAccessServiceClient = await CustomerUserAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomerUserAccessName resourceName = CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]");
            // Make the request
            CustomerUserAccess response = await customerUserAccessServiceClient.GetCustomerUserAccessAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerUserAccess</summary>
        public void MutateCustomerUserAccessRequestObject()
        {
            // Snippet: MutateCustomerUserAccess(MutateCustomerUserAccessRequest, CallSettings)
            // Create client
            CustomerUserAccessServiceClient customerUserAccessServiceClient = CustomerUserAccessServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomerUserAccessRequest request = new MutateCustomerUserAccessRequest
            {
                CustomerId = "",
                Operation = new CustomerUserAccessOperation(),
            };
            // Make the request
            MutateCustomerUserAccessResponse response = customerUserAccessServiceClient.MutateCustomerUserAccess(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerUserAccessAsync</summary>
        public async Task MutateCustomerUserAccessRequestObjectAsync()
        {
            // Snippet: MutateCustomerUserAccessAsync(MutateCustomerUserAccessRequest, CallSettings)
            // Additional: MutateCustomerUserAccessAsync(MutateCustomerUserAccessRequest, CancellationToken)
            // Create client
            CustomerUserAccessServiceClient customerUserAccessServiceClient = await CustomerUserAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomerUserAccessRequest request = new MutateCustomerUserAccessRequest
            {
                CustomerId = "",
                Operation = new CustomerUserAccessOperation(),
            };
            // Make the request
            MutateCustomerUserAccessResponse response = await customerUserAccessServiceClient.MutateCustomerUserAccessAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerUserAccess</summary>
        public void MutateCustomerUserAccess()
        {
            // Snippet: MutateCustomerUserAccess(string, CustomerUserAccessOperation, CallSettings)
            // Create client
            CustomerUserAccessServiceClient customerUserAccessServiceClient = CustomerUserAccessServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            CustomerUserAccessOperation operation = new CustomerUserAccessOperation();
            // Make the request
            MutateCustomerUserAccessResponse response = customerUserAccessServiceClient.MutateCustomerUserAccess(customerId, operation);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerUserAccessAsync</summary>
        public async Task MutateCustomerUserAccessAsync()
        {
            // Snippet: MutateCustomerUserAccessAsync(string, CustomerUserAccessOperation, CallSettings)
            // Additional: MutateCustomerUserAccessAsync(string, CustomerUserAccessOperation, CancellationToken)
            // Create client
            CustomerUserAccessServiceClient customerUserAccessServiceClient = await CustomerUserAccessServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            CustomerUserAccessOperation operation = new CustomerUserAccessOperation();
            // Make the request
            MutateCustomerUserAccessResponse response = await customerUserAccessServiceClient.MutateCustomerUserAccessAsync(customerId, operation);
            // End snippet
        }
    }
}
