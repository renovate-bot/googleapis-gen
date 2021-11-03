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
    public sealed class GeneratedConversionCustomVariableServiceClientSnippets
    {
        /// <summary>Snippet for GetConversionCustomVariable</summary>
        public void GetConversionCustomVariableRequestObject()
        {
            // Snippet: GetConversionCustomVariable(GetConversionCustomVariableRequest, CallSettings)
            // Create client
            ConversionCustomVariableServiceClient conversionCustomVariableServiceClient = ConversionCustomVariableServiceClient.Create();
            // Initialize request argument(s)
            GetConversionCustomVariableRequest request = new GetConversionCustomVariableRequest
            {
                ResourceNameAsConversionCustomVariableName = ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
            };
            // Make the request
            ConversionCustomVariable response = conversionCustomVariableServiceClient.GetConversionCustomVariable(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversionCustomVariableAsync</summary>
        public async Task GetConversionCustomVariableRequestObjectAsync()
        {
            // Snippet: GetConversionCustomVariableAsync(GetConversionCustomVariableRequest, CallSettings)
            // Additional: GetConversionCustomVariableAsync(GetConversionCustomVariableRequest, CancellationToken)
            // Create client
            ConversionCustomVariableServiceClient conversionCustomVariableServiceClient = await ConversionCustomVariableServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConversionCustomVariableRequest request = new GetConversionCustomVariableRequest
            {
                ResourceNameAsConversionCustomVariableName = ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]"),
            };
            // Make the request
            ConversionCustomVariable response = await conversionCustomVariableServiceClient.GetConversionCustomVariableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversionCustomVariable</summary>
        public void GetConversionCustomVariable()
        {
            // Snippet: GetConversionCustomVariable(string, CallSettings)
            // Create client
            ConversionCustomVariableServiceClient conversionCustomVariableServiceClient = ConversionCustomVariableServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/conversionCustomVariables/[CONVERSION_CUSTOM_VARIABLE_ID]";
            // Make the request
            ConversionCustomVariable response = conversionCustomVariableServiceClient.GetConversionCustomVariable(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetConversionCustomVariableAsync</summary>
        public async Task GetConversionCustomVariableAsync()
        {
            // Snippet: GetConversionCustomVariableAsync(string, CallSettings)
            // Additional: GetConversionCustomVariableAsync(string, CancellationToken)
            // Create client
            ConversionCustomVariableServiceClient conversionCustomVariableServiceClient = await ConversionCustomVariableServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/conversionCustomVariables/[CONVERSION_CUSTOM_VARIABLE_ID]";
            // Make the request
            ConversionCustomVariable response = await conversionCustomVariableServiceClient.GetConversionCustomVariableAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetConversionCustomVariable</summary>
        public void GetConversionCustomVariableResourceNames()
        {
            // Snippet: GetConversionCustomVariable(ConversionCustomVariableName, CallSettings)
            // Create client
            ConversionCustomVariableServiceClient conversionCustomVariableServiceClient = ConversionCustomVariableServiceClient.Create();
            // Initialize request argument(s)
            ConversionCustomVariableName resourceName = ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]");
            // Make the request
            ConversionCustomVariable response = conversionCustomVariableServiceClient.GetConversionCustomVariable(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetConversionCustomVariableAsync</summary>
        public async Task GetConversionCustomVariableResourceNamesAsync()
        {
            // Snippet: GetConversionCustomVariableAsync(ConversionCustomVariableName, CallSettings)
            // Additional: GetConversionCustomVariableAsync(ConversionCustomVariableName, CancellationToken)
            // Create client
            ConversionCustomVariableServiceClient conversionCustomVariableServiceClient = await ConversionCustomVariableServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionCustomVariableName resourceName = ConversionCustomVariableName.FromCustomerConversionCustomVariable("[CUSTOMER_ID]", "[CONVERSION_CUSTOM_VARIABLE_ID]");
            // Make the request
            ConversionCustomVariable response = await conversionCustomVariableServiceClient.GetConversionCustomVariableAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionCustomVariables</summary>
        public void MutateConversionCustomVariablesRequestObject()
        {
            // Snippet: MutateConversionCustomVariables(MutateConversionCustomVariablesRequest, CallSettings)
            // Create client
            ConversionCustomVariableServiceClient conversionCustomVariableServiceClient = ConversionCustomVariableServiceClient.Create();
            // Initialize request argument(s)
            MutateConversionCustomVariablesRequest request = new MutateConversionCustomVariablesRequest
            {
                CustomerId = "",
                Operations =
                {
                    new ConversionCustomVariableOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateConversionCustomVariablesResponse response = conversionCustomVariableServiceClient.MutateConversionCustomVariables(request);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionCustomVariablesAsync</summary>
        public async Task MutateConversionCustomVariablesRequestObjectAsync()
        {
            // Snippet: MutateConversionCustomVariablesAsync(MutateConversionCustomVariablesRequest, CallSettings)
            // Additional: MutateConversionCustomVariablesAsync(MutateConversionCustomVariablesRequest, CancellationToken)
            // Create client
            ConversionCustomVariableServiceClient conversionCustomVariableServiceClient = await ConversionCustomVariableServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateConversionCustomVariablesRequest request = new MutateConversionCustomVariablesRequest
            {
                CustomerId = "",
                Operations =
                {
                    new ConversionCustomVariableOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateConversionCustomVariablesResponse response = await conversionCustomVariableServiceClient.MutateConversionCustomVariablesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionCustomVariables</summary>
        public void MutateConversionCustomVariables()
        {
            // Snippet: MutateConversionCustomVariables(string, IEnumerable<ConversionCustomVariableOperation>, CallSettings)
            // Create client
            ConversionCustomVariableServiceClient conversionCustomVariableServiceClient = ConversionCustomVariableServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ConversionCustomVariableOperation> operations = new ConversionCustomVariableOperation[]
            {
                new ConversionCustomVariableOperation(),
            };
            // Make the request
            MutateConversionCustomVariablesResponse response = conversionCustomVariableServiceClient.MutateConversionCustomVariables(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionCustomVariablesAsync</summary>
        public async Task MutateConversionCustomVariablesAsync()
        {
            // Snippet: MutateConversionCustomVariablesAsync(string, IEnumerable<ConversionCustomVariableOperation>, CallSettings)
            // Additional: MutateConversionCustomVariablesAsync(string, IEnumerable<ConversionCustomVariableOperation>, CancellationToken)
            // Create client
            ConversionCustomVariableServiceClient conversionCustomVariableServiceClient = await ConversionCustomVariableServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ConversionCustomVariableOperation> operations = new ConversionCustomVariableOperation[]
            {
                new ConversionCustomVariableOperation(),
            };
            // Make the request
            MutateConversionCustomVariablesResponse response = await conversionCustomVariableServiceClient.MutateConversionCustomVariablesAsync(customerId, operations);
            // End snippet
        }
    }
}
