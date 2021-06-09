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
    public sealed class GeneratedAdParameterServiceClientSnippets
    {
        /// <summary>Snippet for GetAdParameter</summary>
        public void GetAdParameterRequestObject()
        {
            // Snippet: GetAdParameter(GetAdParameterRequest, CallSettings)
            // Create client
            AdParameterServiceClient adParameterServiceClient = AdParameterServiceClient.Create();
            // Initialize request argument(s)
            GetAdParameterRequest request = new GetAdParameterRequest
            {
                ResourceNameAsAdParameterName = AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]"),
            };
            // Make the request
            AdParameter response = adParameterServiceClient.GetAdParameter(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdParameterAsync</summary>
        public async Task GetAdParameterRequestObjectAsync()
        {
            // Snippet: GetAdParameterAsync(GetAdParameterRequest, CallSettings)
            // Additional: GetAdParameterAsync(GetAdParameterRequest, CancellationToken)
            // Create client
            AdParameterServiceClient adParameterServiceClient = await AdParameterServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdParameterRequest request = new GetAdParameterRequest
            {
                ResourceNameAsAdParameterName = AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]"),
            };
            // Make the request
            AdParameter response = await adParameterServiceClient.GetAdParameterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdParameter</summary>
        public void GetAdParameter()
        {
            // Snippet: GetAdParameter(string, CallSettings)
            // Create client
            AdParameterServiceClient adParameterServiceClient = AdParameterServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adParameters/[AD_GROUP_ID]~[CRITERION_ID]~[PARAMETER_INDEX]";
            // Make the request
            AdParameter response = adParameterServiceClient.GetAdParameter(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdParameterAsync</summary>
        public async Task GetAdParameterAsync()
        {
            // Snippet: GetAdParameterAsync(string, CallSettings)
            // Additional: GetAdParameterAsync(string, CancellationToken)
            // Create client
            AdParameterServiceClient adParameterServiceClient = await AdParameterServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adParameters/[AD_GROUP_ID]~[CRITERION_ID]~[PARAMETER_INDEX]";
            // Make the request
            AdParameter response = await adParameterServiceClient.GetAdParameterAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdParameter</summary>
        public void GetAdParameterResourceNames()
        {
            // Snippet: GetAdParameter(AdParameterName, CallSettings)
            // Create client
            AdParameterServiceClient adParameterServiceClient = AdParameterServiceClient.Create();
            // Initialize request argument(s)
            AdParameterName resourceName = AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]");
            // Make the request
            AdParameter response = adParameterServiceClient.GetAdParameter(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdParameterAsync</summary>
        public async Task GetAdParameterResourceNamesAsync()
        {
            // Snippet: GetAdParameterAsync(AdParameterName, CallSettings)
            // Additional: GetAdParameterAsync(AdParameterName, CancellationToken)
            // Create client
            AdParameterServiceClient adParameterServiceClient = await AdParameterServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdParameterName resourceName = AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]");
            // Make the request
            AdParameter response = await adParameterServiceClient.GetAdParameterAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAdParameters</summary>
        public void MutateAdParametersRequestObject()
        {
            // Snippet: MutateAdParameters(MutateAdParametersRequest, CallSettings)
            // Create client
            AdParameterServiceClient adParameterServiceClient = AdParameterServiceClient.Create();
            // Initialize request argument(s)
            MutateAdParametersRequest request = new MutateAdParametersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdParameterOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdParametersResponse response = adParameterServiceClient.MutateAdParameters(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdParametersAsync</summary>
        public async Task MutateAdParametersRequestObjectAsync()
        {
            // Snippet: MutateAdParametersAsync(MutateAdParametersRequest, CallSettings)
            // Additional: MutateAdParametersAsync(MutateAdParametersRequest, CancellationToken)
            // Create client
            AdParameterServiceClient adParameterServiceClient = await AdParameterServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAdParametersRequest request = new MutateAdParametersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdParameterOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdParametersResponse response = await adParameterServiceClient.MutateAdParametersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdParameters</summary>
        public void MutateAdParameters()
        {
            // Snippet: MutateAdParameters(string, IEnumerable<AdParameterOperation>, CallSettings)
            // Create client
            AdParameterServiceClient adParameterServiceClient = AdParameterServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdParameterOperation> operations = new AdParameterOperation[]
            {
                new AdParameterOperation(),
            };
            // Make the request
            MutateAdParametersResponse response = adParameterServiceClient.MutateAdParameters(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAdParametersAsync</summary>
        public async Task MutateAdParametersAsync()
        {
            // Snippet: MutateAdParametersAsync(string, IEnumerable<AdParameterOperation>, CallSettings)
            // Additional: MutateAdParametersAsync(string, IEnumerable<AdParameterOperation>, CancellationToken)
            // Create client
            AdParameterServiceClient adParameterServiceClient = await AdParameterServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdParameterOperation> operations = new AdParameterOperation[]
            {
                new AdParameterOperation(),
            };
            // Make the request
            MutateAdParametersResponse response = await adParameterServiceClient.MutateAdParametersAsync(customerId, operations);
            // End snippet
        }
    }
}
