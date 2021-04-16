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
    using Google.Ads.GoogleAds.V6.Enums;
    using Google.Ads.GoogleAds.V6.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomerServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomer</summary>
        public void GetCustomerRequestObject()
        {
            // Snippet: GetCustomer(GetCustomerRequest, CallSettings)
            // Create client
            CustomerServiceClient customerServiceClient = CustomerServiceClient.Create();
            // Initialize request argument(s)
            GetCustomerRequest request = new GetCustomerRequest
            {
                ResourceNameAsCustomerName = CustomerName.FromCustomer("[CUSTOMER_ID]"),
            };
            // Make the request
            Customer response = customerServiceClient.GetCustomer(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerAsync</summary>
        public async Task GetCustomerRequestObjectAsync()
        {
            // Snippet: GetCustomerAsync(GetCustomerRequest, CallSettings)
            // Additional: GetCustomerAsync(GetCustomerRequest, CancellationToken)
            // Create client
            CustomerServiceClient customerServiceClient = await CustomerServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomerRequest request = new GetCustomerRequest
            {
                ResourceNameAsCustomerName = CustomerName.FromCustomer("[CUSTOMER_ID]"),
            };
            // Make the request
            Customer response = await customerServiceClient.GetCustomerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomer</summary>
        public void GetCustomer()
        {
            // Snippet: GetCustomer(string, CallSettings)
            // Create client
            CustomerServiceClient customerServiceClient = CustomerServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]";
            // Make the request
            Customer response = customerServiceClient.GetCustomer(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerAsync</summary>
        public async Task GetCustomerAsync()
        {
            // Snippet: GetCustomerAsync(string, CallSettings)
            // Additional: GetCustomerAsync(string, CancellationToken)
            // Create client
            CustomerServiceClient customerServiceClient = await CustomerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]";
            // Make the request
            Customer response = await customerServiceClient.GetCustomerAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomer</summary>
        public void GetCustomerResourceNames()
        {
            // Snippet: GetCustomer(CustomerName, CallSettings)
            // Create client
            CustomerServiceClient customerServiceClient = CustomerServiceClient.Create();
            // Initialize request argument(s)
            CustomerName resourceName = CustomerName.FromCustomer("[CUSTOMER_ID]");
            // Make the request
            Customer response = customerServiceClient.GetCustomer(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerAsync</summary>
        public async Task GetCustomerResourceNamesAsync()
        {
            // Snippet: GetCustomerAsync(CustomerName, CallSettings)
            // Additional: GetCustomerAsync(CustomerName, CancellationToken)
            // Create client
            CustomerServiceClient customerServiceClient = await CustomerServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomerName resourceName = CustomerName.FromCustomer("[CUSTOMER_ID]");
            // Make the request
            Customer response = await customerServiceClient.GetCustomerAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomer</summary>
        public void MutateCustomerRequestObject()
        {
            // Snippet: MutateCustomer(MutateCustomerRequest, CallSettings)
            // Create client
            CustomerServiceClient customerServiceClient = CustomerServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomerRequest request = new MutateCustomerRequest
            {
                CustomerId = "",
                Operation = new CustomerOperation(),
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomerResponse response = customerServiceClient.MutateCustomer(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerAsync</summary>
        public async Task MutateCustomerRequestObjectAsync()
        {
            // Snippet: MutateCustomerAsync(MutateCustomerRequest, CallSettings)
            // Additional: MutateCustomerAsync(MutateCustomerRequest, CancellationToken)
            // Create client
            CustomerServiceClient customerServiceClient = await CustomerServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomerRequest request = new MutateCustomerRequest
            {
                CustomerId = "",
                Operation = new CustomerOperation(),
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomerResponse response = await customerServiceClient.MutateCustomerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomer</summary>
        public void MutateCustomer()
        {
            // Snippet: MutateCustomer(string, CustomerOperation, CallSettings)
            // Create client
            CustomerServiceClient customerServiceClient = CustomerServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            CustomerOperation operation = new CustomerOperation();
            // Make the request
            MutateCustomerResponse response = customerServiceClient.MutateCustomer(customerId, operation);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerAsync</summary>
        public async Task MutateCustomerAsync()
        {
            // Snippet: MutateCustomerAsync(string, CustomerOperation, CallSettings)
            // Additional: MutateCustomerAsync(string, CustomerOperation, CancellationToken)
            // Create client
            CustomerServiceClient customerServiceClient = await CustomerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            CustomerOperation operation = new CustomerOperation();
            // Make the request
            MutateCustomerResponse response = await customerServiceClient.MutateCustomerAsync(customerId, operation);
            // End snippet
        }

        /// <summary>Snippet for ListAccessibleCustomers</summary>
        public void ListAccessibleCustomersRequestObject()
        {
            // Snippet: ListAccessibleCustomers(ListAccessibleCustomersRequest, CallSettings)
            // Create client
            CustomerServiceClient customerServiceClient = CustomerServiceClient.Create();
            // Initialize request argument(s)
            ListAccessibleCustomersRequest request = new ListAccessibleCustomersRequest { };
            // Make the request
            ListAccessibleCustomersResponse response = customerServiceClient.ListAccessibleCustomers(request);
            // End snippet
        }

        /// <summary>Snippet for ListAccessibleCustomersAsync</summary>
        public async Task ListAccessibleCustomersRequestObjectAsync()
        {
            // Snippet: ListAccessibleCustomersAsync(ListAccessibleCustomersRequest, CallSettings)
            // Additional: ListAccessibleCustomersAsync(ListAccessibleCustomersRequest, CancellationToken)
            // Create client
            CustomerServiceClient customerServiceClient = await CustomerServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAccessibleCustomersRequest request = new ListAccessibleCustomersRequest { };
            // Make the request
            ListAccessibleCustomersResponse response = await customerServiceClient.ListAccessibleCustomersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomerClient</summary>
        public void CreateCustomerClientRequestObject()
        {
            // Snippet: CreateCustomerClient(CreateCustomerClientRequest, CallSettings)
            // Create client
            CustomerServiceClient customerServiceClient = CustomerServiceClient.Create();
            // Initialize request argument(s)
            CreateCustomerClientRequest request = new CreateCustomerClientRequest
            {
                CustomerId = "",
                CustomerClient = new Customer(),
                AccessRole = AccessRoleEnum.Types.AccessRole.Unspecified,
                EmailAddress = "",
            };
            // Make the request
            CreateCustomerClientResponse response = customerServiceClient.CreateCustomerClient(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomerClientAsync</summary>
        public async Task CreateCustomerClientRequestObjectAsync()
        {
            // Snippet: CreateCustomerClientAsync(CreateCustomerClientRequest, CallSettings)
            // Additional: CreateCustomerClientAsync(CreateCustomerClientRequest, CancellationToken)
            // Create client
            CustomerServiceClient customerServiceClient = await CustomerServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCustomerClientRequest request = new CreateCustomerClientRequest
            {
                CustomerId = "",
                CustomerClient = new Customer(),
                AccessRole = AccessRoleEnum.Types.AccessRole.Unspecified,
                EmailAddress = "",
            };
            // Make the request
            CreateCustomerClientResponse response = await customerServiceClient.CreateCustomerClientAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomerClient</summary>
        public void CreateCustomerClient()
        {
            // Snippet: CreateCustomerClient(string, Customer, CallSettings)
            // Create client
            CustomerServiceClient customerServiceClient = CustomerServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            Customer customerClient = new Customer();
            // Make the request
            CreateCustomerClientResponse response = customerServiceClient.CreateCustomerClient(customerId, customerClient);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomerClientAsync</summary>
        public async Task CreateCustomerClientAsync()
        {
            // Snippet: CreateCustomerClientAsync(string, Customer, CallSettings)
            // Additional: CreateCustomerClientAsync(string, Customer, CancellationToken)
            // Create client
            CustomerServiceClient customerServiceClient = await CustomerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            Customer customerClient = new Customer();
            // Make the request
            CreateCustomerClientResponse response = await customerServiceClient.CreateCustomerClientAsync(customerId, customerClient);
            // End snippet
        }
    }
}
