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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedSharedCriterionServiceClientSnippets
    {
        /// <summary>Snippet for GetSharedCriterion</summary>
        public void GetSharedCriterionRequestObject()
        {
            // Snippet: GetSharedCriterion(GetSharedCriterionRequest, CallSettings)
            // Create client
            SharedCriterionServiceClient sharedCriterionServiceClient = SharedCriterionServiceClient.Create();
            // Initialize request argument(s)
            GetSharedCriterionRequest request = new GetSharedCriterionRequest
            {
                ResourceNameAsSharedCriterionName = SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            SharedCriterion response = sharedCriterionServiceClient.GetSharedCriterion(request);
            // End snippet
        }

        /// <summary>Snippet for GetSharedCriterionAsync</summary>
        public async Task GetSharedCriterionRequestObjectAsync()
        {
            // Snippet: GetSharedCriterionAsync(GetSharedCriterionRequest, CallSettings)
            // Additional: GetSharedCriterionAsync(GetSharedCriterionRequest, CancellationToken)
            // Create client
            SharedCriterionServiceClient sharedCriterionServiceClient = await SharedCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSharedCriterionRequest request = new GetSharedCriterionRequest
            {
                ResourceNameAsSharedCriterionName = SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            SharedCriterion response = await sharedCriterionServiceClient.GetSharedCriterionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSharedCriterion</summary>
        public void GetSharedCriterion()
        {
            // Snippet: GetSharedCriterion(string, CallSettings)
            // Create client
            SharedCriterionServiceClient sharedCriterionServiceClient = SharedCriterionServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/sharedCriteria/[SHARED_SET_ID]~[CRITERION_ID]";
            // Make the request
            SharedCriterion response = sharedCriterionServiceClient.GetSharedCriterion(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetSharedCriterionAsync</summary>
        public async Task GetSharedCriterionAsync()
        {
            // Snippet: GetSharedCriterionAsync(string, CallSettings)
            // Additional: GetSharedCriterionAsync(string, CancellationToken)
            // Create client
            SharedCriterionServiceClient sharedCriterionServiceClient = await SharedCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/sharedCriteria/[SHARED_SET_ID]~[CRITERION_ID]";
            // Make the request
            SharedCriterion response = await sharedCriterionServiceClient.GetSharedCriterionAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetSharedCriterion</summary>
        public void GetSharedCriterionResourceNames()
        {
            // Snippet: GetSharedCriterion(SharedCriterionName, CallSettings)
            // Create client
            SharedCriterionServiceClient sharedCriterionServiceClient = SharedCriterionServiceClient.Create();
            // Initialize request argument(s)
            SharedCriterionName resourceName = SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]");
            // Make the request
            SharedCriterion response = sharedCriterionServiceClient.GetSharedCriterion(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetSharedCriterionAsync</summary>
        public async Task GetSharedCriterionResourceNamesAsync()
        {
            // Snippet: GetSharedCriterionAsync(SharedCriterionName, CallSettings)
            // Additional: GetSharedCriterionAsync(SharedCriterionName, CancellationToken)
            // Create client
            SharedCriterionServiceClient sharedCriterionServiceClient = await SharedCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            SharedCriterionName resourceName = SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]");
            // Make the request
            SharedCriterion response = await sharedCriterionServiceClient.GetSharedCriterionAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateSharedCriteria</summary>
        public void MutateSharedCriteriaRequestObject()
        {
            // Snippet: MutateSharedCriteria(MutateSharedCriteriaRequest, CallSettings)
            // Create client
            SharedCriterionServiceClient sharedCriterionServiceClient = SharedCriterionServiceClient.Create();
            // Initialize request argument(s)
            MutateSharedCriteriaRequest request = new MutateSharedCriteriaRequest
            {
                CustomerId = "",
                Operations =
                {
                    new SharedCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateSharedCriteriaResponse response = sharedCriterionServiceClient.MutateSharedCriteria(request);
            // End snippet
        }

        /// <summary>Snippet for MutateSharedCriteriaAsync</summary>
        public async Task MutateSharedCriteriaRequestObjectAsync()
        {
            // Snippet: MutateSharedCriteriaAsync(MutateSharedCriteriaRequest, CallSettings)
            // Additional: MutateSharedCriteriaAsync(MutateSharedCriteriaRequest, CancellationToken)
            // Create client
            SharedCriterionServiceClient sharedCriterionServiceClient = await SharedCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateSharedCriteriaRequest request = new MutateSharedCriteriaRequest
            {
                CustomerId = "",
                Operations =
                {
                    new SharedCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateSharedCriteriaResponse response = await sharedCriterionServiceClient.MutateSharedCriteriaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateSharedCriteria</summary>
        public void MutateSharedCriteria()
        {
            // Snippet: MutateSharedCriteria(string, IEnumerable<SharedCriterionOperation>, CallSettings)
            // Create client
            SharedCriterionServiceClient sharedCriterionServiceClient = SharedCriterionServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<SharedCriterionOperation> operations = new SharedCriterionOperation[]
            {
                new SharedCriterionOperation(),
            };
            // Make the request
            MutateSharedCriteriaResponse response = sharedCriterionServiceClient.MutateSharedCriteria(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateSharedCriteriaAsync</summary>
        public async Task MutateSharedCriteriaAsync()
        {
            // Snippet: MutateSharedCriteriaAsync(string, IEnumerable<SharedCriterionOperation>, CallSettings)
            // Additional: MutateSharedCriteriaAsync(string, IEnumerable<SharedCriterionOperation>, CancellationToken)
            // Create client
            SharedCriterionServiceClient sharedCriterionServiceClient = await SharedCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<SharedCriterionOperation> operations = new SharedCriterionOperation[]
            {
                new SharedCriterionOperation(),
            };
            // Make the request
            MutateSharedCriteriaResponse response = await sharedCriterionServiceClient.MutateSharedCriteriaAsync(customerId, operations);
            // End snippet
        }
    }
}
