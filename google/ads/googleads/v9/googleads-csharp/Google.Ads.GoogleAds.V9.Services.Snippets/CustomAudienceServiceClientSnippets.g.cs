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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomAudienceServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomAudience</summary>
        public void GetCustomAudienceRequestObject()
        {
            // Snippet: GetCustomAudience(GetCustomAudienceRequest, CallSettings)
            // Create client
            CustomAudienceServiceClient customAudienceServiceClient = CustomAudienceServiceClient.Create();
            // Initialize request argument(s)
            GetCustomAudienceRequest request = new GetCustomAudienceRequest
            {
                ResourceNameAsCustomAudienceName = CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
            };
            // Make the request
            CustomAudience response = customAudienceServiceClient.GetCustomAudience(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomAudienceAsync</summary>
        public async Task GetCustomAudienceRequestObjectAsync()
        {
            // Snippet: GetCustomAudienceAsync(GetCustomAudienceRequest, CallSettings)
            // Additional: GetCustomAudienceAsync(GetCustomAudienceRequest, CancellationToken)
            // Create client
            CustomAudienceServiceClient customAudienceServiceClient = await CustomAudienceServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomAudienceRequest request = new GetCustomAudienceRequest
            {
                ResourceNameAsCustomAudienceName = CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
            };
            // Make the request
            CustomAudience response = await customAudienceServiceClient.GetCustomAudienceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomAudience</summary>
        public void GetCustomAudience()
        {
            // Snippet: GetCustomAudience(string, CallSettings)
            // Create client
            CustomAudienceServiceClient customAudienceServiceClient = CustomAudienceServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customAudiences/[CUSTOM_AUDIENCE_ID]";
            // Make the request
            CustomAudience response = customAudienceServiceClient.GetCustomAudience(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomAudienceAsync</summary>
        public async Task GetCustomAudienceAsync()
        {
            // Snippet: GetCustomAudienceAsync(string, CallSettings)
            // Additional: GetCustomAudienceAsync(string, CancellationToken)
            // Create client
            CustomAudienceServiceClient customAudienceServiceClient = await CustomAudienceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customAudiences/[CUSTOM_AUDIENCE_ID]";
            // Make the request
            CustomAudience response = await customAudienceServiceClient.GetCustomAudienceAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomAudience</summary>
        public void GetCustomAudienceResourceNames()
        {
            // Snippet: GetCustomAudience(CustomAudienceName, CallSettings)
            // Create client
            CustomAudienceServiceClient customAudienceServiceClient = CustomAudienceServiceClient.Create();
            // Initialize request argument(s)
            CustomAudienceName resourceName = CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]");
            // Make the request
            CustomAudience response = customAudienceServiceClient.GetCustomAudience(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomAudienceAsync</summary>
        public async Task GetCustomAudienceResourceNamesAsync()
        {
            // Snippet: GetCustomAudienceAsync(CustomAudienceName, CallSettings)
            // Additional: GetCustomAudienceAsync(CustomAudienceName, CancellationToken)
            // Create client
            CustomAudienceServiceClient customAudienceServiceClient = await CustomAudienceServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomAudienceName resourceName = CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]");
            // Make the request
            CustomAudience response = await customAudienceServiceClient.GetCustomAudienceAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomAudiences</summary>
        public void MutateCustomAudiencesRequestObject()
        {
            // Snippet: MutateCustomAudiences(MutateCustomAudiencesRequest, CallSettings)
            // Create client
            CustomAudienceServiceClient customAudienceServiceClient = CustomAudienceServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomAudiencesRequest request = new MutateCustomAudiencesRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomAudienceOperation(),
                },
                ValidateOnly = false,
            };
            // Make the request
            MutateCustomAudiencesResponse response = customAudienceServiceClient.MutateCustomAudiences(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomAudiencesAsync</summary>
        public async Task MutateCustomAudiencesRequestObjectAsync()
        {
            // Snippet: MutateCustomAudiencesAsync(MutateCustomAudiencesRequest, CallSettings)
            // Additional: MutateCustomAudiencesAsync(MutateCustomAudiencesRequest, CancellationToken)
            // Create client
            CustomAudienceServiceClient customAudienceServiceClient = await CustomAudienceServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomAudiencesRequest request = new MutateCustomAudiencesRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomAudienceOperation(),
                },
                ValidateOnly = false,
            };
            // Make the request
            MutateCustomAudiencesResponse response = await customAudienceServiceClient.MutateCustomAudiencesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomAudiences</summary>
        public void MutateCustomAudiences()
        {
            // Snippet: MutateCustomAudiences(string, IEnumerable<CustomAudienceOperation>, CallSettings)
            // Create client
            CustomAudienceServiceClient customAudienceServiceClient = CustomAudienceServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomAudienceOperation> operations = new CustomAudienceOperation[]
            {
                new CustomAudienceOperation(),
            };
            // Make the request
            MutateCustomAudiencesResponse response = customAudienceServiceClient.MutateCustomAudiences(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomAudiencesAsync</summary>
        public async Task MutateCustomAudiencesAsync()
        {
            // Snippet: MutateCustomAudiencesAsync(string, IEnumerable<CustomAudienceOperation>, CallSettings)
            // Additional: MutateCustomAudiencesAsync(string, IEnumerable<CustomAudienceOperation>, CancellationToken)
            // Create client
            CustomAudienceServiceClient customAudienceServiceClient = await CustomAudienceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomAudienceOperation> operations = new CustomAudienceOperation[]
            {
                new CustomAudienceOperation(),
            };
            // Make the request
            MutateCustomAudiencesResponse response = await customAudienceServiceClient.MutateCustomAudiencesAsync(customerId, operations);
            // End snippet
        }
    }
}
