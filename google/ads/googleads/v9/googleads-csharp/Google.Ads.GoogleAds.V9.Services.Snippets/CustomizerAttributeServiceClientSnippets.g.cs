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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomizerAttributeServiceClientSnippets
    {
        /// <summary>Snippet for MutateCustomizerAttributes</summary>
        public void MutateCustomizerAttributesRequestObject()
        {
            // Snippet: MutateCustomizerAttributes(MutateCustomizerAttributesRequest, CallSettings)
            // Create client
            CustomizerAttributeServiceClient customizerAttributeServiceClient = CustomizerAttributeServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomizerAttributesRequest request = new MutateCustomizerAttributesRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomizerAttributeOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomizerAttributesResponse response = customizerAttributeServiceClient.MutateCustomizerAttributes(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomizerAttributesAsync</summary>
        public async Task MutateCustomizerAttributesRequestObjectAsync()
        {
            // Snippet: MutateCustomizerAttributesAsync(MutateCustomizerAttributesRequest, CallSettings)
            // Additional: MutateCustomizerAttributesAsync(MutateCustomizerAttributesRequest, CancellationToken)
            // Create client
            CustomizerAttributeServiceClient customizerAttributeServiceClient = await CustomizerAttributeServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomizerAttributesRequest request = new MutateCustomizerAttributesRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomizerAttributeOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomizerAttributesResponse response = await customizerAttributeServiceClient.MutateCustomizerAttributesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomizerAttributes</summary>
        public void MutateCustomizerAttributes()
        {
            // Snippet: MutateCustomizerAttributes(string, IEnumerable<CustomizerAttributeOperation>, CallSettings)
            // Create client
            CustomizerAttributeServiceClient customizerAttributeServiceClient = CustomizerAttributeServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomizerAttributeOperation> operations = new CustomizerAttributeOperation[]
            {
                new CustomizerAttributeOperation(),
            };
            // Make the request
            MutateCustomizerAttributesResponse response = customizerAttributeServiceClient.MutateCustomizerAttributes(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomizerAttributesAsync</summary>
        public async Task MutateCustomizerAttributesAsync()
        {
            // Snippet: MutateCustomizerAttributesAsync(string, IEnumerable<CustomizerAttributeOperation>, CallSettings)
            // Additional: MutateCustomizerAttributesAsync(string, IEnumerable<CustomizerAttributeOperation>, CancellationToken)
            // Create client
            CustomizerAttributeServiceClient customizerAttributeServiceClient = await CustomizerAttributeServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomizerAttributeOperation> operations = new CustomizerAttributeOperation[]
            {
                new CustomizerAttributeOperation(),
            };
            // Make the request
            MutateCustomizerAttributesResponse response = await customizerAttributeServiceClient.MutateCustomizerAttributesAsync(customerId, operations);
            // End snippet
        }
    }
}
