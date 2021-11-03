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
    public sealed class GeneratedConversionActionServiceClientSnippets
    {
        /// <summary>Snippet for GetConversionAction</summary>
        public void GetConversionActionRequestObject()
        {
            // Snippet: GetConversionAction(GetConversionActionRequest, CallSettings)
            // Create client
            ConversionActionServiceClient conversionActionServiceClient = ConversionActionServiceClient.Create();
            // Initialize request argument(s)
            GetConversionActionRequest request = new GetConversionActionRequest
            {
                ResourceNameAsConversionActionName = ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
            };
            // Make the request
            ConversionAction response = conversionActionServiceClient.GetConversionAction(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversionActionAsync</summary>
        public async Task GetConversionActionRequestObjectAsync()
        {
            // Snippet: GetConversionActionAsync(GetConversionActionRequest, CallSettings)
            // Additional: GetConversionActionAsync(GetConversionActionRequest, CancellationToken)
            // Create client
            ConversionActionServiceClient conversionActionServiceClient = await ConversionActionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConversionActionRequest request = new GetConversionActionRequest
            {
                ResourceNameAsConversionActionName = ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]"),
            };
            // Make the request
            ConversionAction response = await conversionActionServiceClient.GetConversionActionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversionAction</summary>
        public void GetConversionAction()
        {
            // Snippet: GetConversionAction(string, CallSettings)
            // Create client
            ConversionActionServiceClient conversionActionServiceClient = ConversionActionServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/conversionActions/[CONVERSION_ACTION_ID]";
            // Make the request
            ConversionAction response = conversionActionServiceClient.GetConversionAction(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetConversionActionAsync</summary>
        public async Task GetConversionActionAsync()
        {
            // Snippet: GetConversionActionAsync(string, CallSettings)
            // Additional: GetConversionActionAsync(string, CancellationToken)
            // Create client
            ConversionActionServiceClient conversionActionServiceClient = await ConversionActionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/conversionActions/[CONVERSION_ACTION_ID]";
            // Make the request
            ConversionAction response = await conversionActionServiceClient.GetConversionActionAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetConversionAction</summary>
        public void GetConversionActionResourceNames()
        {
            // Snippet: GetConversionAction(ConversionActionName, CallSettings)
            // Create client
            ConversionActionServiceClient conversionActionServiceClient = ConversionActionServiceClient.Create();
            // Initialize request argument(s)
            ConversionActionName resourceName = ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]");
            // Make the request
            ConversionAction response = conversionActionServiceClient.GetConversionAction(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetConversionActionAsync</summary>
        public async Task GetConversionActionResourceNamesAsync()
        {
            // Snippet: GetConversionActionAsync(ConversionActionName, CallSettings)
            // Additional: GetConversionActionAsync(ConversionActionName, CancellationToken)
            // Create client
            ConversionActionServiceClient conversionActionServiceClient = await ConversionActionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionActionName resourceName = ConversionActionName.FromCustomerConversionAction("[CUSTOMER_ID]", "[CONVERSION_ACTION_ID]");
            // Make the request
            ConversionAction response = await conversionActionServiceClient.GetConversionActionAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionActions</summary>
        public void MutateConversionActionsRequestObject()
        {
            // Snippet: MutateConversionActions(MutateConversionActionsRequest, CallSettings)
            // Create client
            ConversionActionServiceClient conversionActionServiceClient = ConversionActionServiceClient.Create();
            // Initialize request argument(s)
            MutateConversionActionsRequest request = new MutateConversionActionsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new ConversionActionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateConversionActionsResponse response = conversionActionServiceClient.MutateConversionActions(request);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionActionsAsync</summary>
        public async Task MutateConversionActionsRequestObjectAsync()
        {
            // Snippet: MutateConversionActionsAsync(MutateConversionActionsRequest, CallSettings)
            // Additional: MutateConversionActionsAsync(MutateConversionActionsRequest, CancellationToken)
            // Create client
            ConversionActionServiceClient conversionActionServiceClient = await ConversionActionServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateConversionActionsRequest request = new MutateConversionActionsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new ConversionActionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateConversionActionsResponse response = await conversionActionServiceClient.MutateConversionActionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionActions</summary>
        public void MutateConversionActions()
        {
            // Snippet: MutateConversionActions(string, IEnumerable<ConversionActionOperation>, CallSettings)
            // Create client
            ConversionActionServiceClient conversionActionServiceClient = ConversionActionServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ConversionActionOperation> operations = new ConversionActionOperation[]
            {
                new ConversionActionOperation(),
            };
            // Make the request
            MutateConversionActionsResponse response = conversionActionServiceClient.MutateConversionActions(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateConversionActionsAsync</summary>
        public async Task MutateConversionActionsAsync()
        {
            // Snippet: MutateConversionActionsAsync(string, IEnumerable<ConversionActionOperation>, CallSettings)
            // Additional: MutateConversionActionsAsync(string, IEnumerable<ConversionActionOperation>, CancellationToken)
            // Create client
            ConversionActionServiceClient conversionActionServiceClient = await ConversionActionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ConversionActionOperation> operations = new ConversionActionOperation[]
            {
                new ConversionActionOperation(),
            };
            // Make the request
            MutateConversionActionsResponse response = await conversionActionServiceClient.MutateConversionActionsAsync(customerId, operations);
            // End snippet
        }
    }
}
