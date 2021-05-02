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
    using Google.Ads.GoogleAds.V7.Enums;
    using Google.Ads.GoogleAds.V7.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedSharedSetServiceClientSnippets
    {
        /// <summary>Snippet for GetSharedSet</summary>
        public void GetSharedSetRequestObject()
        {
            // Snippet: GetSharedSet(GetSharedSetRequest, CallSettings)
            // Create client
            SharedSetServiceClient sharedSetServiceClient = SharedSetServiceClient.Create();
            // Initialize request argument(s)
            GetSharedSetRequest request = new GetSharedSetRequest
            {
                ResourceNameAsSharedSetName = SharedSetName.FromCustomerSharedSet("[CUSTOMER_ID]", "[SHARED_SET_ID]"),
            };
            // Make the request
            SharedSet response = sharedSetServiceClient.GetSharedSet(request);
            // End snippet
        }

        /// <summary>Snippet for GetSharedSetAsync</summary>
        public async Task GetSharedSetRequestObjectAsync()
        {
            // Snippet: GetSharedSetAsync(GetSharedSetRequest, CallSettings)
            // Additional: GetSharedSetAsync(GetSharedSetRequest, CancellationToken)
            // Create client
            SharedSetServiceClient sharedSetServiceClient = await SharedSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSharedSetRequest request = new GetSharedSetRequest
            {
                ResourceNameAsSharedSetName = SharedSetName.FromCustomerSharedSet("[CUSTOMER_ID]", "[SHARED_SET_ID]"),
            };
            // Make the request
            SharedSet response = await sharedSetServiceClient.GetSharedSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSharedSet</summary>
        public void GetSharedSet()
        {
            // Snippet: GetSharedSet(string, CallSettings)
            // Create client
            SharedSetServiceClient sharedSetServiceClient = SharedSetServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/sharedSets/[SHARED_SET_ID]";
            // Make the request
            SharedSet response = sharedSetServiceClient.GetSharedSet(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetSharedSetAsync</summary>
        public async Task GetSharedSetAsync()
        {
            // Snippet: GetSharedSetAsync(string, CallSettings)
            // Additional: GetSharedSetAsync(string, CancellationToken)
            // Create client
            SharedSetServiceClient sharedSetServiceClient = await SharedSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/sharedSets/[SHARED_SET_ID]";
            // Make the request
            SharedSet response = await sharedSetServiceClient.GetSharedSetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetSharedSet</summary>
        public void GetSharedSetResourceNames()
        {
            // Snippet: GetSharedSet(SharedSetName, CallSettings)
            // Create client
            SharedSetServiceClient sharedSetServiceClient = SharedSetServiceClient.Create();
            // Initialize request argument(s)
            SharedSetName resourceName = SharedSetName.FromCustomerSharedSet("[CUSTOMER_ID]", "[SHARED_SET_ID]");
            // Make the request
            SharedSet response = sharedSetServiceClient.GetSharedSet(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetSharedSetAsync</summary>
        public async Task GetSharedSetResourceNamesAsync()
        {
            // Snippet: GetSharedSetAsync(SharedSetName, CallSettings)
            // Additional: GetSharedSetAsync(SharedSetName, CancellationToken)
            // Create client
            SharedSetServiceClient sharedSetServiceClient = await SharedSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            SharedSetName resourceName = SharedSetName.FromCustomerSharedSet("[CUSTOMER_ID]", "[SHARED_SET_ID]");
            // Make the request
            SharedSet response = await sharedSetServiceClient.GetSharedSetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateSharedSets</summary>
        public void MutateSharedSetsRequestObject()
        {
            // Snippet: MutateSharedSets(MutateSharedSetsRequest, CallSettings)
            // Create client
            SharedSetServiceClient sharedSetServiceClient = SharedSetServiceClient.Create();
            // Initialize request argument(s)
            MutateSharedSetsRequest request = new MutateSharedSetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new SharedSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateSharedSetsResponse response = sharedSetServiceClient.MutateSharedSets(request);
            // End snippet
        }

        /// <summary>Snippet for MutateSharedSetsAsync</summary>
        public async Task MutateSharedSetsRequestObjectAsync()
        {
            // Snippet: MutateSharedSetsAsync(MutateSharedSetsRequest, CallSettings)
            // Additional: MutateSharedSetsAsync(MutateSharedSetsRequest, CancellationToken)
            // Create client
            SharedSetServiceClient sharedSetServiceClient = await SharedSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateSharedSetsRequest request = new MutateSharedSetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new SharedSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateSharedSetsResponse response = await sharedSetServiceClient.MutateSharedSetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateSharedSets</summary>
        public void MutateSharedSets()
        {
            // Snippet: MutateSharedSets(string, IEnumerable<SharedSetOperation>, CallSettings)
            // Create client
            SharedSetServiceClient sharedSetServiceClient = SharedSetServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<SharedSetOperation> operations = new SharedSetOperation[]
            {
                new SharedSetOperation(),
            };
            // Make the request
            MutateSharedSetsResponse response = sharedSetServiceClient.MutateSharedSets(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateSharedSetsAsync</summary>
        public async Task MutateSharedSetsAsync()
        {
            // Snippet: MutateSharedSetsAsync(string, IEnumerable<SharedSetOperation>, CallSettings)
            // Additional: MutateSharedSetsAsync(string, IEnumerable<SharedSetOperation>, CancellationToken)
            // Create client
            SharedSetServiceClient sharedSetServiceClient = await SharedSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<SharedSetOperation> operations = new SharedSetOperation[]
            {
                new SharedSetOperation(),
            };
            // Make the request
            MutateSharedSetsResponse response = await sharedSetServiceClient.MutateSharedSetsAsync(customerId, operations);
            // End snippet
        }
    }
}
