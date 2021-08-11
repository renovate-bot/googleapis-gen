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
    public sealed class GeneratedConversionValueRuleServiceClientSnippets
    {
        /// <summary>Snippet for GetConversionValueRule</summary>
        public void GetConversionValueRuleRequestObject()
        {
            // Snippet: GetConversionValueRule(GetConversionValueRuleRequest, CallSettings)
            // Create client
            ConversionValueRuleServiceClient conversionValueRuleServiceClient = ConversionValueRuleServiceClient.Create();
            // Initialize request argument(s)
            GetConversionValueRuleRequest request = new GetConversionValueRuleRequest
            {
                ResourceNameAsConversionValueRuleName = ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
            };
            // Make the request
            ConversionValueRule response = conversionValueRuleServiceClient.GetConversionValueRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversionValueRuleAsync</summary>
        public async Task GetConversionValueRuleRequestObjectAsync()
        {
            // Snippet: GetConversionValueRuleAsync(GetConversionValueRuleRequest, CallSettings)
            // Additional: GetConversionValueRuleAsync(GetConversionValueRuleRequest, CancellationToken)
            // Create client
            ConversionValueRuleServiceClient conversionValueRuleServiceClient = await ConversionValueRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConversionValueRuleRequest request = new GetConversionValueRuleRequest
            {
                ResourceNameAsConversionValueRuleName = ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
            };
            // Make the request
            ConversionValueRule response = await conversionValueRuleServiceClient.GetConversionValueRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversionValueRule</summary>
        public void GetConversionValueRule()
        {
            // Snippet: GetConversionValueRule(string, CallSettings)
            // Create client
            ConversionValueRuleServiceClient conversionValueRuleServiceClient = ConversionValueRuleServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/conversionValueRules/[CONVERSION_VALUE_RULE_ID]";
            // Make the request
            ConversionValueRule response = conversionValueRuleServiceClient.GetConversionValueRule(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetConversionValueRuleAsync</summary>
        public async Task GetConversionValueRuleAsync()
        {
            // Snippet: GetConversionValueRuleAsync(string, CallSettings)
            // Additional: GetConversionValueRuleAsync(string, CancellationToken)
            // Create client
            ConversionValueRuleServiceClient conversionValueRuleServiceClient = await ConversionValueRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/conversionValueRules/[CONVERSION_VALUE_RULE_ID]";
            // Make the request
            ConversionValueRule response = await conversionValueRuleServiceClient.GetConversionValueRuleAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetConversionValueRule</summary>
        public void GetConversionValueRuleResourceNames()
        {
            // Snippet: GetConversionValueRule(ConversionValueRuleName, CallSettings)
            // Create client
            ConversionValueRuleServiceClient conversionValueRuleServiceClient = ConversionValueRuleServiceClient.Create();
            // Initialize request argument(s)
            ConversionValueRuleName resourceName = ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]");
            // Make the request
            ConversionValueRule response = conversionValueRuleServiceClient.GetConversionValueRule(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetConversionValueRuleAsync</summary>
        public async Task GetConversionValueRuleResourceNamesAsync()
        {
            // Snippet: GetConversionValueRuleAsync(ConversionValueRuleName, CallSettings)
            // Additional: GetConversionValueRuleAsync(ConversionValueRuleName, CancellationToken)
            // Create client
            ConversionValueRuleServiceClient conversionValueRuleServiceClient = await ConversionValueRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionValueRuleName resourceName = ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]");
            // Make the request
            ConversionValueRule response = await conversionValueRuleServiceClient.GetConversionValueRuleAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionValueRules</summary>
        public void MutateConversionValueRulesRequestObject()
        {
            // Snippet: MutateConversionValueRules(MutateConversionValueRulesRequest, CallSettings)
            // Create client
            ConversionValueRuleServiceClient conversionValueRuleServiceClient = ConversionValueRuleServiceClient.Create();
            // Initialize request argument(s)
            MutateConversionValueRulesRequest request = new MutateConversionValueRulesRequest
            {
                CustomerId = "",
                Operations =
                {
                    new ConversionValueRuleOperation(),
                },
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
                PartialFailure = false,
            };
            // Make the request
            MutateConversionValueRulesResponse response = conversionValueRuleServiceClient.MutateConversionValueRules(request);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionValueRulesAsync</summary>
        public async Task MutateConversionValueRulesRequestObjectAsync()
        {
            // Snippet: MutateConversionValueRulesAsync(MutateConversionValueRulesRequest, CallSettings)
            // Additional: MutateConversionValueRulesAsync(MutateConversionValueRulesRequest, CancellationToken)
            // Create client
            ConversionValueRuleServiceClient conversionValueRuleServiceClient = await ConversionValueRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateConversionValueRulesRequest request = new MutateConversionValueRulesRequest
            {
                CustomerId = "",
                Operations =
                {
                    new ConversionValueRuleOperation(),
                },
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
                PartialFailure = false,
            };
            // Make the request
            MutateConversionValueRulesResponse response = await conversionValueRuleServiceClient.MutateConversionValueRulesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionValueRules</summary>
        public void MutateConversionValueRules()
        {
            // Snippet: MutateConversionValueRules(string, IEnumerable<ConversionValueRuleOperation>, CallSettings)
            // Create client
            ConversionValueRuleServiceClient conversionValueRuleServiceClient = ConversionValueRuleServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ConversionValueRuleOperation> operations = new ConversionValueRuleOperation[]
            {
                new ConversionValueRuleOperation(),
            };
            // Make the request
            MutateConversionValueRulesResponse response = conversionValueRuleServiceClient.MutateConversionValueRules(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionValueRulesAsync</summary>
        public async Task MutateConversionValueRulesAsync()
        {
            // Snippet: MutateConversionValueRulesAsync(string, IEnumerable<ConversionValueRuleOperation>, CallSettings)
            // Additional: MutateConversionValueRulesAsync(string, IEnumerable<ConversionValueRuleOperation>, CancellationToken)
            // Create client
            ConversionValueRuleServiceClient conversionValueRuleServiceClient = await ConversionValueRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ConversionValueRuleOperation> operations = new ConversionValueRuleOperation[]
            {
                new ConversionValueRuleOperation(),
            };
            // Make the request
            MutateConversionValueRulesResponse response = await conversionValueRuleServiceClient.MutateConversionValueRulesAsync(customerId, operations);
            // End snippet
        }
    }
}
