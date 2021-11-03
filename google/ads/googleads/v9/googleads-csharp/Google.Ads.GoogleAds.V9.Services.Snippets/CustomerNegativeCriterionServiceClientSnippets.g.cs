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
    using Google.Ads.GoogleAds.V9.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomerNegativeCriterionServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomerNegativeCriterion</summary>
        public void GetCustomerNegativeCriterionRequestObject()
        {
            // Snippet: GetCustomerNegativeCriterion(GetCustomerNegativeCriterionRequest, CallSettings)
            // Create client
            CustomerNegativeCriterionServiceClient customerNegativeCriterionServiceClient = CustomerNegativeCriterionServiceClient.Create();
            // Initialize request argument(s)
            GetCustomerNegativeCriterionRequest request = new GetCustomerNegativeCriterionRequest
            {
                ResourceNameAsCustomerNegativeCriterionName = CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            CustomerNegativeCriterion response = customerNegativeCriterionServiceClient.GetCustomerNegativeCriterion(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerNegativeCriterionAsync</summary>
        public async Task GetCustomerNegativeCriterionRequestObjectAsync()
        {
            // Snippet: GetCustomerNegativeCriterionAsync(GetCustomerNegativeCriterionRequest, CallSettings)
            // Additional: GetCustomerNegativeCriterionAsync(GetCustomerNegativeCriterionRequest, CancellationToken)
            // Create client
            CustomerNegativeCriterionServiceClient customerNegativeCriterionServiceClient = await CustomerNegativeCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomerNegativeCriterionRequest request = new GetCustomerNegativeCriterionRequest
            {
                ResourceNameAsCustomerNegativeCriterionName = CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            CustomerNegativeCriterion response = await customerNegativeCriterionServiceClient.GetCustomerNegativeCriterionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerNegativeCriterion</summary>
        public void GetCustomerNegativeCriterion()
        {
            // Snippet: GetCustomerNegativeCriterion(string, CallSettings)
            // Create client
            CustomerNegativeCriterionServiceClient customerNegativeCriterionServiceClient = CustomerNegativeCriterionServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerNegativeCriteria/[CRITERION_ID]";
            // Make the request
            CustomerNegativeCriterion response = customerNegativeCriterionServiceClient.GetCustomerNegativeCriterion(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerNegativeCriterionAsync</summary>
        public async Task GetCustomerNegativeCriterionAsync()
        {
            // Snippet: GetCustomerNegativeCriterionAsync(string, CallSettings)
            // Additional: GetCustomerNegativeCriterionAsync(string, CancellationToken)
            // Create client
            CustomerNegativeCriterionServiceClient customerNegativeCriterionServiceClient = await CustomerNegativeCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerNegativeCriteria/[CRITERION_ID]";
            // Make the request
            CustomerNegativeCriterion response = await customerNegativeCriterionServiceClient.GetCustomerNegativeCriterionAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerNegativeCriterion</summary>
        public void GetCustomerNegativeCriterionResourceNames()
        {
            // Snippet: GetCustomerNegativeCriterion(CustomerNegativeCriterionName, CallSettings)
            // Create client
            CustomerNegativeCriterionServiceClient customerNegativeCriterionServiceClient = CustomerNegativeCriterionServiceClient.Create();
            // Initialize request argument(s)
            CustomerNegativeCriterionName resourceName = CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]");
            // Make the request
            CustomerNegativeCriterion response = customerNegativeCriterionServiceClient.GetCustomerNegativeCriterion(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerNegativeCriterionAsync</summary>
        public async Task GetCustomerNegativeCriterionResourceNamesAsync()
        {
            // Snippet: GetCustomerNegativeCriterionAsync(CustomerNegativeCriterionName, CallSettings)
            // Additional: GetCustomerNegativeCriterionAsync(CustomerNegativeCriterionName, CancellationToken)
            // Create client
            CustomerNegativeCriterionServiceClient customerNegativeCriterionServiceClient = await CustomerNegativeCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomerNegativeCriterionName resourceName = CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]");
            // Make the request
            CustomerNegativeCriterion response = await customerNegativeCriterionServiceClient.GetCustomerNegativeCriterionAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerNegativeCriteria</summary>
        public void MutateCustomerNegativeCriteriaRequestObject()
        {
            // Snippet: MutateCustomerNegativeCriteria(MutateCustomerNegativeCriteriaRequest, CallSettings)
            // Create client
            CustomerNegativeCriterionServiceClient customerNegativeCriterionServiceClient = CustomerNegativeCriterionServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomerNegativeCriteriaRequest request = new MutateCustomerNegativeCriteriaRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerNegativeCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomerNegativeCriteriaResponse response = customerNegativeCriterionServiceClient.MutateCustomerNegativeCriteria(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerNegativeCriteriaAsync</summary>
        public async Task MutateCustomerNegativeCriteriaRequestObjectAsync()
        {
            // Snippet: MutateCustomerNegativeCriteriaAsync(MutateCustomerNegativeCriteriaRequest, CallSettings)
            // Additional: MutateCustomerNegativeCriteriaAsync(MutateCustomerNegativeCriteriaRequest, CancellationToken)
            // Create client
            CustomerNegativeCriterionServiceClient customerNegativeCriterionServiceClient = await CustomerNegativeCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomerNegativeCriteriaRequest request = new MutateCustomerNegativeCriteriaRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerNegativeCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomerNegativeCriteriaResponse response = await customerNegativeCriterionServiceClient.MutateCustomerNegativeCriteriaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerNegativeCriteria</summary>
        public void MutateCustomerNegativeCriteria()
        {
            // Snippet: MutateCustomerNegativeCriteria(string, IEnumerable<CustomerNegativeCriterionOperation>, CallSettings)
            // Create client
            CustomerNegativeCriterionServiceClient customerNegativeCriterionServiceClient = CustomerNegativeCriterionServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerNegativeCriterionOperation> operations = new CustomerNegativeCriterionOperation[]
            {
                new CustomerNegativeCriterionOperation(),
            };
            // Make the request
            MutateCustomerNegativeCriteriaResponse response = customerNegativeCriterionServiceClient.MutateCustomerNegativeCriteria(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerNegativeCriteriaAsync</summary>
        public async Task MutateCustomerNegativeCriteriaAsync()
        {
            // Snippet: MutateCustomerNegativeCriteriaAsync(string, IEnumerable<CustomerNegativeCriterionOperation>, CallSettings)
            // Additional: MutateCustomerNegativeCriteriaAsync(string, IEnumerable<CustomerNegativeCriterionOperation>, CancellationToken)
            // Create client
            CustomerNegativeCriterionServiceClient customerNegativeCriterionServiceClient = await CustomerNegativeCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerNegativeCriterionOperation> operations = new CustomerNegativeCriterionOperation[]
            {
                new CustomerNegativeCriterionOperation(),
            };
            // Make the request
            MutateCustomerNegativeCriteriaResponse response = await customerNegativeCriterionServiceClient.MutateCustomerNegativeCriteriaAsync(customerId, operations);
            // End snippet
        }
    }
}
