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
    public sealed class GeneratedConversionValueRuleSetServiceClientSnippets
    {
        /// <summary>Snippet for GetConversionValueRuleSet</summary>
        public void GetConversionValueRuleSetRequestObject()
        {
            // Snippet: GetConversionValueRuleSet(GetConversionValueRuleSetRequest, CallSettings)
            // Create client
            ConversionValueRuleSetServiceClient conversionValueRuleSetServiceClient = ConversionValueRuleSetServiceClient.Create();
            // Initialize request argument(s)
            GetConversionValueRuleSetRequest request = new GetConversionValueRuleSetRequest
            {
                ResourceNameAsConversionValueRuleSetName = ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]"),
            };
            // Make the request
            ConversionValueRuleSet response = conversionValueRuleSetServiceClient.GetConversionValueRuleSet(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversionValueRuleSetAsync</summary>
        public async Task GetConversionValueRuleSetRequestObjectAsync()
        {
            // Snippet: GetConversionValueRuleSetAsync(GetConversionValueRuleSetRequest, CallSettings)
            // Additional: GetConversionValueRuleSetAsync(GetConversionValueRuleSetRequest, CancellationToken)
            // Create client
            ConversionValueRuleSetServiceClient conversionValueRuleSetServiceClient = await ConversionValueRuleSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConversionValueRuleSetRequest request = new GetConversionValueRuleSetRequest
            {
                ResourceNameAsConversionValueRuleSetName = ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]"),
            };
            // Make the request
            ConversionValueRuleSet response = await conversionValueRuleSetServiceClient.GetConversionValueRuleSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversionValueRuleSet</summary>
        public void GetConversionValueRuleSet()
        {
            // Snippet: GetConversionValueRuleSet(string, CallSettings)
            // Create client
            ConversionValueRuleSetServiceClient conversionValueRuleSetServiceClient = ConversionValueRuleSetServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/conversionValueRuleSets/[CONVERSION_VALUE_RULE_SET_ID]";
            // Make the request
            ConversionValueRuleSet response = conversionValueRuleSetServiceClient.GetConversionValueRuleSet(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetConversionValueRuleSetAsync</summary>
        public async Task GetConversionValueRuleSetAsync()
        {
            // Snippet: GetConversionValueRuleSetAsync(string, CallSettings)
            // Additional: GetConversionValueRuleSetAsync(string, CancellationToken)
            // Create client
            ConversionValueRuleSetServiceClient conversionValueRuleSetServiceClient = await ConversionValueRuleSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/conversionValueRuleSets/[CONVERSION_VALUE_RULE_SET_ID]";
            // Make the request
            ConversionValueRuleSet response = await conversionValueRuleSetServiceClient.GetConversionValueRuleSetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetConversionValueRuleSet</summary>
        public void GetConversionValueRuleSetResourceNames()
        {
            // Snippet: GetConversionValueRuleSet(ConversionValueRuleSetName, CallSettings)
            // Create client
            ConversionValueRuleSetServiceClient conversionValueRuleSetServiceClient = ConversionValueRuleSetServiceClient.Create();
            // Initialize request argument(s)
            ConversionValueRuleSetName resourceName = ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]");
            // Make the request
            ConversionValueRuleSet response = conversionValueRuleSetServiceClient.GetConversionValueRuleSet(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetConversionValueRuleSetAsync</summary>
        public async Task GetConversionValueRuleSetResourceNamesAsync()
        {
            // Snippet: GetConversionValueRuleSetAsync(ConversionValueRuleSetName, CallSettings)
            // Additional: GetConversionValueRuleSetAsync(ConversionValueRuleSetName, CancellationToken)
            // Create client
            ConversionValueRuleSetServiceClient conversionValueRuleSetServiceClient = await ConversionValueRuleSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionValueRuleSetName resourceName = ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]");
            // Make the request
            ConversionValueRuleSet response = await conversionValueRuleSetServiceClient.GetConversionValueRuleSetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionValueRuleSets</summary>
        public void MutateConversionValueRuleSetsRequestObject()
        {
            // Snippet: MutateConversionValueRuleSets(MutateConversionValueRuleSetsRequest, CallSettings)
            // Create client
            ConversionValueRuleSetServiceClient conversionValueRuleSetServiceClient = ConversionValueRuleSetServiceClient.Create();
            // Initialize request argument(s)
            MutateConversionValueRuleSetsRequest request = new MutateConversionValueRuleSetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new ConversionValueRuleSetOperation(),
                },
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
                PartialFailure = false,
            };
            // Make the request
            MutateConversionValueRuleSetsResponse response = conversionValueRuleSetServiceClient.MutateConversionValueRuleSets(request);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionValueRuleSetsAsync</summary>
        public async Task MutateConversionValueRuleSetsRequestObjectAsync()
        {
            // Snippet: MutateConversionValueRuleSetsAsync(MutateConversionValueRuleSetsRequest, CallSettings)
            // Additional: MutateConversionValueRuleSetsAsync(MutateConversionValueRuleSetsRequest, CancellationToken)
            // Create client
            ConversionValueRuleSetServiceClient conversionValueRuleSetServiceClient = await ConversionValueRuleSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateConversionValueRuleSetsRequest request = new MutateConversionValueRuleSetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new ConversionValueRuleSetOperation(),
                },
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
                PartialFailure = false,
            };
            // Make the request
            MutateConversionValueRuleSetsResponse response = await conversionValueRuleSetServiceClient.MutateConversionValueRuleSetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionValueRuleSets</summary>
        public void MutateConversionValueRuleSets()
        {
            // Snippet: MutateConversionValueRuleSets(string, IEnumerable<ConversionValueRuleSetOperation>, CallSettings)
            // Create client
            ConversionValueRuleSetServiceClient conversionValueRuleSetServiceClient = ConversionValueRuleSetServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ConversionValueRuleSetOperation> operations = new ConversionValueRuleSetOperation[]
            {
                new ConversionValueRuleSetOperation(),
            };
            // Make the request
            MutateConversionValueRuleSetsResponse response = conversionValueRuleSetServiceClient.MutateConversionValueRuleSets(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionValueRuleSetsAsync</summary>
        public async Task MutateConversionValueRuleSetsAsync()
        {
            // Snippet: MutateConversionValueRuleSetsAsync(string, IEnumerable<ConversionValueRuleSetOperation>, CallSettings)
            // Additional: MutateConversionValueRuleSetsAsync(string, IEnumerable<ConversionValueRuleSetOperation>, CancellationToken)
            // Create client
            ConversionValueRuleSetServiceClient conversionValueRuleSetServiceClient = await ConversionValueRuleSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ConversionValueRuleSetOperation> operations = new ConversionValueRuleSetOperation[]
            {
                new ConversionValueRuleSetOperation(),
            };
            // Make the request
            MutateConversionValueRuleSetsResponse response = await conversionValueRuleSetServiceClient.MutateConversionValueRuleSetsAsync(customerId, operations);
            // End snippet
        }
    }
}
