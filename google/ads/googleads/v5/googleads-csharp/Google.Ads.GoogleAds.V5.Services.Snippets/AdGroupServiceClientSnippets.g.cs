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
    using Google.Ads.GoogleAds.V5.Enums;
    using Google.Ads.GoogleAds.V5.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAdGroupServiceClientSnippets
    {
        /// <summary>Snippet for GetAdGroup</summary>
        public void GetAdGroupRequestObject()
        {
            // Snippet: GetAdGroup(GetAdGroupRequest, CallSettings)
            // Create client
            AdGroupServiceClient adGroupServiceClient = AdGroupServiceClient.Create();
            // Initialize request argument(s)
            GetAdGroupRequest request = new GetAdGroupRequest
            {
                ResourceNameAsAdGroupName = AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
            };
            // Make the request
            AdGroup response = adGroupServiceClient.GetAdGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAsync</summary>
        public async Task GetAdGroupRequestObjectAsync()
        {
            // Snippet: GetAdGroupAsync(GetAdGroupRequest, CallSettings)
            // Additional: GetAdGroupAsync(GetAdGroupRequest, CancellationToken)
            // Create client
            AdGroupServiceClient adGroupServiceClient = await AdGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdGroupRequest request = new GetAdGroupRequest
            {
                ResourceNameAsAdGroupName = AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
            };
            // Make the request
            AdGroup response = await adGroupServiceClient.GetAdGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroup</summary>
        public void GetAdGroup()
        {
            // Snippet: GetAdGroup(string, CallSettings)
            // Create client
            AdGroupServiceClient adGroupServiceClient = AdGroupServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/adGroups/[AD_GROUP]";
            // Make the request
            AdGroup response = adGroupServiceClient.GetAdGroup(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAsync</summary>
        public async Task GetAdGroupAsync()
        {
            // Snippet: GetAdGroupAsync(string, CallSettings)
            // Additional: GetAdGroupAsync(string, CancellationToken)
            // Create client
            AdGroupServiceClient adGroupServiceClient = await AdGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/adGroups/[AD_GROUP]";
            // Make the request
            AdGroup response = await adGroupServiceClient.GetAdGroupAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroup</summary>
        public void GetAdGroupResourceNames()
        {
            // Snippet: GetAdGroup(AdGroupName, CallSettings)
            // Create client
            AdGroupServiceClient adGroupServiceClient = AdGroupServiceClient.Create();
            // Initialize request argument(s)
            AdGroupName resourceName = AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]");
            // Make the request
            AdGroup response = adGroupServiceClient.GetAdGroup(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAsync</summary>
        public async Task GetAdGroupResourceNamesAsync()
        {
            // Snippet: GetAdGroupAsync(AdGroupName, CallSettings)
            // Additional: GetAdGroupAsync(AdGroupName, CancellationToken)
            // Create client
            AdGroupServiceClient adGroupServiceClient = await AdGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdGroupName resourceName = AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]");
            // Make the request
            AdGroup response = await adGroupServiceClient.GetAdGroupAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroups</summary>
        public void MutateAdGroupsRequestObject()
        {
            // Snippet: MutateAdGroups(MutateAdGroupsRequest, CallSettings)
            // Create client
            AdGroupServiceClient adGroupServiceClient = AdGroupServiceClient.Create();
            // Initialize request argument(s)
            MutateAdGroupsRequest request = new MutateAdGroupsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdGroupsResponse response = adGroupServiceClient.MutateAdGroups(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupsAsync</summary>
        public async Task MutateAdGroupsRequestObjectAsync()
        {
            // Snippet: MutateAdGroupsAsync(MutateAdGroupsRequest, CallSettings)
            // Additional: MutateAdGroupsAsync(MutateAdGroupsRequest, CancellationToken)
            // Create client
            AdGroupServiceClient adGroupServiceClient = await AdGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAdGroupsRequest request = new MutateAdGroupsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdGroupsResponse response = await adGroupServiceClient.MutateAdGroupsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroups</summary>
        public void MutateAdGroups()
        {
            // Snippet: MutateAdGroups(string, IEnumerable<AdGroupOperation>, CallSettings)
            // Create client
            AdGroupServiceClient adGroupServiceClient = AdGroupServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupOperation> operations = new AdGroupOperation[]
            {
                new AdGroupOperation(),
            };
            // Make the request
            MutateAdGroupsResponse response = adGroupServiceClient.MutateAdGroups(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupsAsync</summary>
        public async Task MutateAdGroupsAsync()
        {
            // Snippet: MutateAdGroupsAsync(string, IEnumerable<AdGroupOperation>, CallSettings)
            // Additional: MutateAdGroupsAsync(string, IEnumerable<AdGroupOperation>, CancellationToken)
            // Create client
            AdGroupServiceClient adGroupServiceClient = await AdGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupOperation> operations = new AdGroupOperation[]
            {
                new AdGroupOperation(),
            };
            // Make the request
            MutateAdGroupsResponse response = await adGroupServiceClient.MutateAdGroupsAsync(customerId, operations);
            // End snippet
        }
    }
}
