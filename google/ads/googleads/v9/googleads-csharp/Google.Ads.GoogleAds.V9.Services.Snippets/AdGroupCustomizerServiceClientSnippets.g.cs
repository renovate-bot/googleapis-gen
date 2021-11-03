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
    public sealed class GeneratedAdGroupCustomizerServiceClientSnippets
    {
        /// <summary>Snippet for MutateAdGroupCustomizers</summary>
        public void MutateAdGroupCustomizersRequestObject()
        {
            // Snippet: MutateAdGroupCustomizers(MutateAdGroupCustomizersRequest, CallSettings)
            // Create client
            AdGroupCustomizerServiceClient adGroupCustomizerServiceClient = AdGroupCustomizerServiceClient.Create();
            // Initialize request argument(s)
            MutateAdGroupCustomizersRequest request = new MutateAdGroupCustomizersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdGroupCustomizersResponse response = adGroupCustomizerServiceClient.MutateAdGroupCustomizers(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupCustomizersAsync</summary>
        public async Task MutateAdGroupCustomizersRequestObjectAsync()
        {
            // Snippet: MutateAdGroupCustomizersAsync(MutateAdGroupCustomizersRequest, CallSettings)
            // Additional: MutateAdGroupCustomizersAsync(MutateAdGroupCustomizersRequest, CancellationToken)
            // Create client
            AdGroupCustomizerServiceClient adGroupCustomizerServiceClient = await AdGroupCustomizerServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAdGroupCustomizersRequest request = new MutateAdGroupCustomizersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdGroupCustomizersResponse response = await adGroupCustomizerServiceClient.MutateAdGroupCustomizersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupCustomizers</summary>
        public void MutateAdGroupCustomizers()
        {
            // Snippet: MutateAdGroupCustomizers(string, IEnumerable<AdGroupCustomizerOperation>, CallSettings)
            // Create client
            AdGroupCustomizerServiceClient adGroupCustomizerServiceClient = AdGroupCustomizerServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupCustomizerOperation> operations = new AdGroupCustomizerOperation[]
            {
                new AdGroupCustomizerOperation(),
            };
            // Make the request
            MutateAdGroupCustomizersResponse response = adGroupCustomizerServiceClient.MutateAdGroupCustomizers(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupCustomizersAsync</summary>
        public async Task MutateAdGroupCustomizersAsync()
        {
            // Snippet: MutateAdGroupCustomizersAsync(string, IEnumerable<AdGroupCustomizerOperation>, CallSettings)
            // Additional: MutateAdGroupCustomizersAsync(string, IEnumerable<AdGroupCustomizerOperation>, CancellationToken)
            // Create client
            AdGroupCustomizerServiceClient adGroupCustomizerServiceClient = await AdGroupCustomizerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupCustomizerOperation> operations = new AdGroupCustomizerOperation[]
            {
                new AdGroupCustomizerOperation(),
            };
            // Make the request
            MutateAdGroupCustomizersResponse response = await adGroupCustomizerServiceClient.MutateAdGroupCustomizersAsync(customerId, operations);
            // End snippet
        }
    }
}
