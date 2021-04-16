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
    public sealed class GeneratedAdGroupCriterionServiceClientSnippets
    {
        /// <summary>Snippet for GetAdGroupCriterion</summary>
        public void GetAdGroupCriterionRequestObject()
        {
            // Snippet: GetAdGroupCriterion(GetAdGroupCriterionRequest, CallSettings)
            // Create client
            AdGroupCriterionServiceClient adGroupCriterionServiceClient = AdGroupCriterionServiceClient.Create();
            // Initialize request argument(s)
            GetAdGroupCriterionRequest request = new GetAdGroupCriterionRequest
            {
                ResourceNameAsAdGroupCriterionName = AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            AdGroupCriterion response = adGroupCriterionServiceClient.GetAdGroupCriterion(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupCriterionAsync</summary>
        public async Task GetAdGroupCriterionRequestObjectAsync()
        {
            // Snippet: GetAdGroupCriterionAsync(GetAdGroupCriterionRequest, CallSettings)
            // Additional: GetAdGroupCriterionAsync(GetAdGroupCriterionRequest, CancellationToken)
            // Create client
            AdGroupCriterionServiceClient adGroupCriterionServiceClient = await AdGroupCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdGroupCriterionRequest request = new GetAdGroupCriterionRequest
            {
                ResourceNameAsAdGroupCriterionName = AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            AdGroupCriterion response = await adGroupCriterionServiceClient.GetAdGroupCriterionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupCriterion</summary>
        public void GetAdGroupCriterion()
        {
            // Snippet: GetAdGroupCriterion(string, CallSettings)
            // Create client
            AdGroupCriterionServiceClient adGroupCriterionServiceClient = AdGroupCriterionServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupCriteria/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            AdGroupCriterion response = adGroupCriterionServiceClient.GetAdGroupCriterion(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupCriterionAsync</summary>
        public async Task GetAdGroupCriterionAsync()
        {
            // Snippet: GetAdGroupCriterionAsync(string, CallSettings)
            // Additional: GetAdGroupCriterionAsync(string, CancellationToken)
            // Create client
            AdGroupCriterionServiceClient adGroupCriterionServiceClient = await AdGroupCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupCriteria/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            AdGroupCriterion response = await adGroupCriterionServiceClient.GetAdGroupCriterionAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupCriterion</summary>
        public void GetAdGroupCriterionResourceNames()
        {
            // Snippet: GetAdGroupCriterion(AdGroupCriterionName, CallSettings)
            // Create client
            AdGroupCriterionServiceClient adGroupCriterionServiceClient = AdGroupCriterionServiceClient.Create();
            // Initialize request argument(s)
            AdGroupCriterionName resourceName = AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            AdGroupCriterion response = adGroupCriterionServiceClient.GetAdGroupCriterion(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupCriterionAsync</summary>
        public async Task GetAdGroupCriterionResourceNamesAsync()
        {
            // Snippet: GetAdGroupCriterionAsync(AdGroupCriterionName, CallSettings)
            // Additional: GetAdGroupCriterionAsync(AdGroupCriterionName, CancellationToken)
            // Create client
            AdGroupCriterionServiceClient adGroupCriterionServiceClient = await AdGroupCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdGroupCriterionName resourceName = AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            AdGroupCriterion response = await adGroupCriterionServiceClient.GetAdGroupCriterionAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupCriteria</summary>
        public void MutateAdGroupCriteriaRequestObject()
        {
            // Snippet: MutateAdGroupCriteria(MutateAdGroupCriteriaRequest, CallSettings)
            // Create client
            AdGroupCriterionServiceClient adGroupCriterionServiceClient = AdGroupCriterionServiceClient.Create();
            // Initialize request argument(s)
            MutateAdGroupCriteriaRequest request = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdGroupCriteriaResponse response = adGroupCriterionServiceClient.MutateAdGroupCriteria(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupCriteriaAsync</summary>
        public async Task MutateAdGroupCriteriaRequestObjectAsync()
        {
            // Snippet: MutateAdGroupCriteriaAsync(MutateAdGroupCriteriaRequest, CallSettings)
            // Additional: MutateAdGroupCriteriaAsync(MutateAdGroupCriteriaRequest, CancellationToken)
            // Create client
            AdGroupCriterionServiceClient adGroupCriterionServiceClient = await AdGroupCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAdGroupCriteriaRequest request = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdGroupCriteriaResponse response = await adGroupCriterionServiceClient.MutateAdGroupCriteriaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupCriteria</summary>
        public void MutateAdGroupCriteria()
        {
            // Snippet: MutateAdGroupCriteria(string, IEnumerable<AdGroupCriterionOperation>, CallSettings)
            // Create client
            AdGroupCriterionServiceClient adGroupCriterionServiceClient = AdGroupCriterionServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupCriterionOperation> operations = new AdGroupCriterionOperation[]
            {
                new AdGroupCriterionOperation(),
            };
            // Make the request
            MutateAdGroupCriteriaResponse response = adGroupCriterionServiceClient.MutateAdGroupCriteria(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupCriteriaAsync</summary>
        public async Task MutateAdGroupCriteriaAsync()
        {
            // Snippet: MutateAdGroupCriteriaAsync(string, IEnumerable<AdGroupCriterionOperation>, CallSettings)
            // Additional: MutateAdGroupCriteriaAsync(string, IEnumerable<AdGroupCriterionOperation>, CancellationToken)
            // Create client
            AdGroupCriterionServiceClient adGroupCriterionServiceClient = await AdGroupCriterionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupCriterionOperation> operations = new AdGroupCriterionOperation[]
            {
                new AdGroupCriterionOperation(),
            };
            // Make the request
            MutateAdGroupCriteriaResponse response = await adGroupCriterionServiceClient.MutateAdGroupCriteriaAsync(customerId, operations);
            // End snippet
        }
    }
}
