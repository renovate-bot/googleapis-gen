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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomInterestServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomInterest</summary>
        public void GetCustomInterestRequestObject()
        {
            // Snippet: GetCustomInterest(GetCustomInterestRequest, CallSettings)
            // Create client
            CustomInterestServiceClient customInterestServiceClient = CustomInterestServiceClient.Create();
            // Initialize request argument(s)
            GetCustomInterestRequest request = new GetCustomInterestRequest
            {
                ResourceNameAsCustomInterestName = CustomInterestName.FromCustomerCustomInterest("[CUSTOMER]", "[CUSTOM_INTEREST]"),
            };
            // Make the request
            CustomInterest response = customInterestServiceClient.GetCustomInterest(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomInterestAsync</summary>
        public async Task GetCustomInterestRequestObjectAsync()
        {
            // Snippet: GetCustomInterestAsync(GetCustomInterestRequest, CallSettings)
            // Additional: GetCustomInterestAsync(GetCustomInterestRequest, CancellationToken)
            // Create client
            CustomInterestServiceClient customInterestServiceClient = await CustomInterestServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomInterestRequest request = new GetCustomInterestRequest
            {
                ResourceNameAsCustomInterestName = CustomInterestName.FromCustomerCustomInterest("[CUSTOMER]", "[CUSTOM_INTEREST]"),
            };
            // Make the request
            CustomInterest response = await customInterestServiceClient.GetCustomInterestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomInterest</summary>
        public void GetCustomInterest()
        {
            // Snippet: GetCustomInterest(string, CallSettings)
            // Create client
            CustomInterestServiceClient customInterestServiceClient = CustomInterestServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/customInterests/[CUSTOM_INTEREST]";
            // Make the request
            CustomInterest response = customInterestServiceClient.GetCustomInterest(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomInterestAsync</summary>
        public async Task GetCustomInterestAsync()
        {
            // Snippet: GetCustomInterestAsync(string, CallSettings)
            // Additional: GetCustomInterestAsync(string, CancellationToken)
            // Create client
            CustomInterestServiceClient customInterestServiceClient = await CustomInterestServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/customInterests/[CUSTOM_INTEREST]";
            // Make the request
            CustomInterest response = await customInterestServiceClient.GetCustomInterestAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomInterest</summary>
        public void GetCustomInterestResourceNames()
        {
            // Snippet: GetCustomInterest(CustomInterestName, CallSettings)
            // Create client
            CustomInterestServiceClient customInterestServiceClient = CustomInterestServiceClient.Create();
            // Initialize request argument(s)
            CustomInterestName resourceName = CustomInterestName.FromCustomerCustomInterest("[CUSTOMER]", "[CUSTOM_INTEREST]");
            // Make the request
            CustomInterest response = customInterestServiceClient.GetCustomInterest(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomInterestAsync</summary>
        public async Task GetCustomInterestResourceNamesAsync()
        {
            // Snippet: GetCustomInterestAsync(CustomInterestName, CallSettings)
            // Additional: GetCustomInterestAsync(CustomInterestName, CancellationToken)
            // Create client
            CustomInterestServiceClient customInterestServiceClient = await CustomInterestServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomInterestName resourceName = CustomInterestName.FromCustomerCustomInterest("[CUSTOMER]", "[CUSTOM_INTEREST]");
            // Make the request
            CustomInterest response = await customInterestServiceClient.GetCustomInterestAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomInterests</summary>
        public void MutateCustomInterestsRequestObject()
        {
            // Snippet: MutateCustomInterests(MutateCustomInterestsRequest, CallSettings)
            // Create client
            CustomInterestServiceClient customInterestServiceClient = CustomInterestServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomInterestsRequest request = new MutateCustomInterestsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomInterestOperation(),
                },
                ValidateOnly = false,
            };
            // Make the request
            MutateCustomInterestsResponse response = customInterestServiceClient.MutateCustomInterests(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomInterestsAsync</summary>
        public async Task MutateCustomInterestsRequestObjectAsync()
        {
            // Snippet: MutateCustomInterestsAsync(MutateCustomInterestsRequest, CallSettings)
            // Additional: MutateCustomInterestsAsync(MutateCustomInterestsRequest, CancellationToken)
            // Create client
            CustomInterestServiceClient customInterestServiceClient = await CustomInterestServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomInterestsRequest request = new MutateCustomInterestsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomInterestOperation(),
                },
                ValidateOnly = false,
            };
            // Make the request
            MutateCustomInterestsResponse response = await customInterestServiceClient.MutateCustomInterestsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomInterests</summary>
        public void MutateCustomInterests()
        {
            // Snippet: MutateCustomInterests(string, IEnumerable<CustomInterestOperation>, CallSettings)
            // Create client
            CustomInterestServiceClient customInterestServiceClient = CustomInterestServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomInterestOperation> operations = new CustomInterestOperation[]
            {
                new CustomInterestOperation(),
            };
            // Make the request
            MutateCustomInterestsResponse response = customInterestServiceClient.MutateCustomInterests(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomInterestsAsync</summary>
        public async Task MutateCustomInterestsAsync()
        {
            // Snippet: MutateCustomInterestsAsync(string, IEnumerable<CustomInterestOperation>, CallSettings)
            // Additional: MutateCustomInterestsAsync(string, IEnumerable<CustomInterestOperation>, CancellationToken)
            // Create client
            CustomInterestServiceClient customInterestServiceClient = await CustomInterestServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomInterestOperation> operations = new CustomInterestOperation[]
            {
                new CustomInterestOperation(),
            };
            // Make the request
            MutateCustomInterestsResponse response = await customInterestServiceClient.MutateCustomInterestsAsync(customerId, operations);
            // End snippet
        }
    }
}
