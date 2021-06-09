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

namespace Google.Ads.GoogleAds.V8.Services.Snippets
{
    using Google.Ads.GoogleAds.V8.Enums;
    using Google.Ads.GoogleAds.V8.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAdGroupBidModifierServiceClientSnippets
    {
        /// <summary>Snippet for GetAdGroupBidModifier</summary>
        public void GetAdGroupBidModifierRequestObject()
        {
            // Snippet: GetAdGroupBidModifier(GetAdGroupBidModifierRequest, CallSettings)
            // Create client
            AdGroupBidModifierServiceClient adGroupBidModifierServiceClient = AdGroupBidModifierServiceClient.Create();
            // Initialize request argument(s)
            GetAdGroupBidModifierRequest request = new GetAdGroupBidModifierRequest
            {
                ResourceNameAsAdGroupBidModifierName = AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            AdGroupBidModifier response = adGroupBidModifierServiceClient.GetAdGroupBidModifier(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupBidModifierAsync</summary>
        public async Task GetAdGroupBidModifierRequestObjectAsync()
        {
            // Snippet: GetAdGroupBidModifierAsync(GetAdGroupBidModifierRequest, CallSettings)
            // Additional: GetAdGroupBidModifierAsync(GetAdGroupBidModifierRequest, CancellationToken)
            // Create client
            AdGroupBidModifierServiceClient adGroupBidModifierServiceClient = await AdGroupBidModifierServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdGroupBidModifierRequest request = new GetAdGroupBidModifierRequest
            {
                ResourceNameAsAdGroupBidModifierName = AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            // Make the request
            AdGroupBidModifier response = await adGroupBidModifierServiceClient.GetAdGroupBidModifierAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupBidModifier</summary>
        public void GetAdGroupBidModifier()
        {
            // Snippet: GetAdGroupBidModifier(string, CallSettings)
            // Create client
            AdGroupBidModifierServiceClient adGroupBidModifierServiceClient = AdGroupBidModifierServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupBidModifiers/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            AdGroupBidModifier response = adGroupBidModifierServiceClient.GetAdGroupBidModifier(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupBidModifierAsync</summary>
        public async Task GetAdGroupBidModifierAsync()
        {
            // Snippet: GetAdGroupBidModifierAsync(string, CallSettings)
            // Additional: GetAdGroupBidModifierAsync(string, CancellationToken)
            // Create client
            AdGroupBidModifierServiceClient adGroupBidModifierServiceClient = await AdGroupBidModifierServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupBidModifiers/[AD_GROUP_ID]~[CRITERION_ID]";
            // Make the request
            AdGroupBidModifier response = await adGroupBidModifierServiceClient.GetAdGroupBidModifierAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupBidModifier</summary>
        public void GetAdGroupBidModifierResourceNames()
        {
            // Snippet: GetAdGroupBidModifier(AdGroupBidModifierName, CallSettings)
            // Create client
            AdGroupBidModifierServiceClient adGroupBidModifierServiceClient = AdGroupBidModifierServiceClient.Create();
            // Initialize request argument(s)
            AdGroupBidModifierName resourceName = AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            AdGroupBidModifier response = adGroupBidModifierServiceClient.GetAdGroupBidModifier(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupBidModifierAsync</summary>
        public async Task GetAdGroupBidModifierResourceNamesAsync()
        {
            // Snippet: GetAdGroupBidModifierAsync(AdGroupBidModifierName, CallSettings)
            // Additional: GetAdGroupBidModifierAsync(AdGroupBidModifierName, CancellationToken)
            // Create client
            AdGroupBidModifierServiceClient adGroupBidModifierServiceClient = await AdGroupBidModifierServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdGroupBidModifierName resourceName = AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]");
            // Make the request
            AdGroupBidModifier response = await adGroupBidModifierServiceClient.GetAdGroupBidModifierAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupBidModifiers</summary>
        public void MutateAdGroupBidModifiersRequestObject()
        {
            // Snippet: MutateAdGroupBidModifiers(MutateAdGroupBidModifiersRequest, CallSettings)
            // Create client
            AdGroupBidModifierServiceClient adGroupBidModifierServiceClient = AdGroupBidModifierServiceClient.Create();
            // Initialize request argument(s)
            MutateAdGroupBidModifiersRequest request = new MutateAdGroupBidModifiersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupBidModifierOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdGroupBidModifiersResponse response = adGroupBidModifierServiceClient.MutateAdGroupBidModifiers(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupBidModifiersAsync</summary>
        public async Task MutateAdGroupBidModifiersRequestObjectAsync()
        {
            // Snippet: MutateAdGroupBidModifiersAsync(MutateAdGroupBidModifiersRequest, CallSettings)
            // Additional: MutateAdGroupBidModifiersAsync(MutateAdGroupBidModifiersRequest, CancellationToken)
            // Create client
            AdGroupBidModifierServiceClient adGroupBidModifierServiceClient = await AdGroupBidModifierServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAdGroupBidModifiersRequest request = new MutateAdGroupBidModifiersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupBidModifierOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdGroupBidModifiersResponse response = await adGroupBidModifierServiceClient.MutateAdGroupBidModifiersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupBidModifiers</summary>
        public void MutateAdGroupBidModifiers()
        {
            // Snippet: MutateAdGroupBidModifiers(string, IEnumerable<AdGroupBidModifierOperation>, CallSettings)
            // Create client
            AdGroupBidModifierServiceClient adGroupBidModifierServiceClient = AdGroupBidModifierServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupBidModifierOperation> operations = new AdGroupBidModifierOperation[]
            {
                new AdGroupBidModifierOperation(),
            };
            // Make the request
            MutateAdGroupBidModifiersResponse response = adGroupBidModifierServiceClient.MutateAdGroupBidModifiers(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupBidModifiersAsync</summary>
        public async Task MutateAdGroupBidModifiersAsync()
        {
            // Snippet: MutateAdGroupBidModifiersAsync(string, IEnumerable<AdGroupBidModifierOperation>, CallSettings)
            // Additional: MutateAdGroupBidModifiersAsync(string, IEnumerable<AdGroupBidModifierOperation>, CancellationToken)
            // Create client
            AdGroupBidModifierServiceClient adGroupBidModifierServiceClient = await AdGroupBidModifierServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupBidModifierOperation> operations = new AdGroupBidModifierOperation[]
            {
                new AdGroupBidModifierOperation(),
            };
            // Make the request
            MutateAdGroupBidModifiersResponse response = await adGroupBidModifierServiceClient.MutateAdGroupBidModifiersAsync(customerId, operations);
            // End snippet
        }
    }
}
