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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomerConversionGoalServiceClientSnippets
    {
        /// <summary>Snippet for MutateCustomerConversionGoals</summary>
        public void MutateCustomerConversionGoalsRequestObject()
        {
            // Snippet: MutateCustomerConversionGoals(MutateCustomerConversionGoalsRequest, CallSettings)
            // Create client
            CustomerConversionGoalServiceClient customerConversionGoalServiceClient = CustomerConversionGoalServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomerConversionGoalsRequest request = new MutateCustomerConversionGoalsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerConversionGoalOperation(),
                },
                ValidateOnly = false,
            };
            // Make the request
            MutateCustomerConversionGoalsResponse response = customerConversionGoalServiceClient.MutateCustomerConversionGoals(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerConversionGoalsAsync</summary>
        public async Task MutateCustomerConversionGoalsRequestObjectAsync()
        {
            // Snippet: MutateCustomerConversionGoalsAsync(MutateCustomerConversionGoalsRequest, CallSettings)
            // Additional: MutateCustomerConversionGoalsAsync(MutateCustomerConversionGoalsRequest, CancellationToken)
            // Create client
            CustomerConversionGoalServiceClient customerConversionGoalServiceClient = await CustomerConversionGoalServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomerConversionGoalsRequest request = new MutateCustomerConversionGoalsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerConversionGoalOperation(),
                },
                ValidateOnly = false,
            };
            // Make the request
            MutateCustomerConversionGoalsResponse response = await customerConversionGoalServiceClient.MutateCustomerConversionGoalsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerConversionGoals</summary>
        public void MutateCustomerConversionGoals()
        {
            // Snippet: MutateCustomerConversionGoals(string, IEnumerable<CustomerConversionGoalOperation>, CallSettings)
            // Create client
            CustomerConversionGoalServiceClient customerConversionGoalServiceClient = CustomerConversionGoalServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerConversionGoalOperation> operations = new CustomerConversionGoalOperation[]
            {
                new CustomerConversionGoalOperation(),
            };
            // Make the request
            MutateCustomerConversionGoalsResponse response = customerConversionGoalServiceClient.MutateCustomerConversionGoals(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerConversionGoalsAsync</summary>
        public async Task MutateCustomerConversionGoalsAsync()
        {
            // Snippet: MutateCustomerConversionGoalsAsync(string, IEnumerable<CustomerConversionGoalOperation>, CallSettings)
            // Additional: MutateCustomerConversionGoalsAsync(string, IEnumerable<CustomerConversionGoalOperation>, CancellationToken)
            // Create client
            CustomerConversionGoalServiceClient customerConversionGoalServiceClient = await CustomerConversionGoalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerConversionGoalOperation> operations = new CustomerConversionGoalOperation[]
            {
                new CustomerConversionGoalOperation(),
            };
            // Make the request
            MutateCustomerConversionGoalsResponse response = await customerConversionGoalServiceClient.MutateCustomerConversionGoalsAsync(customerId, operations);
            // End snippet
        }
    }
}
