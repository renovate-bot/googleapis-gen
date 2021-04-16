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
    public sealed class GeneratedCustomerLabelServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomerLabel</summary>
        public void GetCustomerLabelRequestObject()
        {
            // Snippet: GetCustomerLabel(GetCustomerLabelRequest, CallSettings)
            // Create client
            CustomerLabelServiceClient customerLabelServiceClient = CustomerLabelServiceClient.Create();
            // Initialize request argument(s)
            GetCustomerLabelRequest request = new GetCustomerLabelRequest
            {
                ResourceNameAsCustomerLabelName = CustomerLabelName.FromCustomerLabel("[CUSTOMER_ID]", "[LABEL_ID]"),
            };
            // Make the request
            CustomerLabel response = customerLabelServiceClient.GetCustomerLabel(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerLabelAsync</summary>
        public async Task GetCustomerLabelRequestObjectAsync()
        {
            // Snippet: GetCustomerLabelAsync(GetCustomerLabelRequest, CallSettings)
            // Additional: GetCustomerLabelAsync(GetCustomerLabelRequest, CancellationToken)
            // Create client
            CustomerLabelServiceClient customerLabelServiceClient = await CustomerLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomerLabelRequest request = new GetCustomerLabelRequest
            {
                ResourceNameAsCustomerLabelName = CustomerLabelName.FromCustomerLabel("[CUSTOMER_ID]", "[LABEL_ID]"),
            };
            // Make the request
            CustomerLabel response = await customerLabelServiceClient.GetCustomerLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerLabel</summary>
        public void GetCustomerLabel()
        {
            // Snippet: GetCustomerLabel(string, CallSettings)
            // Create client
            CustomerLabelServiceClient customerLabelServiceClient = CustomerLabelServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerLabels/[LABEL_ID]";
            // Make the request
            CustomerLabel response = customerLabelServiceClient.GetCustomerLabel(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerLabelAsync</summary>
        public async Task GetCustomerLabelAsync()
        {
            // Snippet: GetCustomerLabelAsync(string, CallSettings)
            // Additional: GetCustomerLabelAsync(string, CancellationToken)
            // Create client
            CustomerLabelServiceClient customerLabelServiceClient = await CustomerLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerLabels/[LABEL_ID]";
            // Make the request
            CustomerLabel response = await customerLabelServiceClient.GetCustomerLabelAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerLabel</summary>
        public void GetCustomerLabelResourceNames()
        {
            // Snippet: GetCustomerLabel(CustomerLabelName, CallSettings)
            // Create client
            CustomerLabelServiceClient customerLabelServiceClient = CustomerLabelServiceClient.Create();
            // Initialize request argument(s)
            CustomerLabelName resourceName = CustomerLabelName.FromCustomerLabel("[CUSTOMER_ID]", "[LABEL_ID]");
            // Make the request
            CustomerLabel response = customerLabelServiceClient.GetCustomerLabel(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerLabelAsync</summary>
        public async Task GetCustomerLabelResourceNamesAsync()
        {
            // Snippet: GetCustomerLabelAsync(CustomerLabelName, CallSettings)
            // Additional: GetCustomerLabelAsync(CustomerLabelName, CancellationToken)
            // Create client
            CustomerLabelServiceClient customerLabelServiceClient = await CustomerLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomerLabelName resourceName = CustomerLabelName.FromCustomerLabel("[CUSTOMER_ID]", "[LABEL_ID]");
            // Make the request
            CustomerLabel response = await customerLabelServiceClient.GetCustomerLabelAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerLabels</summary>
        public void MutateCustomerLabelsRequestObject()
        {
            // Snippet: MutateCustomerLabels(MutateCustomerLabelsRequest, CallSettings)
            // Create client
            CustomerLabelServiceClient customerLabelServiceClient = CustomerLabelServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomerLabelsRequest request = new MutateCustomerLabelsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateCustomerLabelsResponse response = customerLabelServiceClient.MutateCustomerLabels(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerLabelsAsync</summary>
        public async Task MutateCustomerLabelsRequestObjectAsync()
        {
            // Snippet: MutateCustomerLabelsAsync(MutateCustomerLabelsRequest, CallSettings)
            // Additional: MutateCustomerLabelsAsync(MutateCustomerLabelsRequest, CancellationToken)
            // Create client
            CustomerLabelServiceClient customerLabelServiceClient = await CustomerLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomerLabelsRequest request = new MutateCustomerLabelsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateCustomerLabelsResponse response = await customerLabelServiceClient.MutateCustomerLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerLabels</summary>
        public void MutateCustomerLabels()
        {
            // Snippet: MutateCustomerLabels(string, IEnumerable<CustomerLabelOperation>, CallSettings)
            // Create client
            CustomerLabelServiceClient customerLabelServiceClient = CustomerLabelServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerLabelOperation> operations = new CustomerLabelOperation[]
            {
                new CustomerLabelOperation(),
            };
            // Make the request
            MutateCustomerLabelsResponse response = customerLabelServiceClient.MutateCustomerLabels(customerId, operations);
            // End snippet
        }

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
