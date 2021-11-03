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
    public sealed class GeneratedAdGroupCriterionCustomizerServiceClientSnippets
    {
        /// <summary>Snippet for MutateAdGroupCriterionCustomizers</summary>
        public void MutateAdGroupCriterionCustomizersRequestObject()
        {
            // Snippet: MutateAdGroupCriterionCustomizers(MutateAdGroupCriterionCustomizersRequest, CallSettings)
            // Create client
            AdGroupCriterionCustomizerServiceClient adGroupCriterionCustomizerServiceClient = AdGroupCriterionCustomizerServiceClient.Create();
            // Initialize request argument(s)
            MutateAdGroupCriterionCustomizersRequest request = new MutateAdGroupCriterionCustomizersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupCriterionCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdGroupCriterionCustomizersResponse response = adGroupCriterionCustomizerServiceClient.MutateAdGroupCriterionCustomizers(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupCriterionCustomizersAsync</summary>
        public async Task MutateAdGroupCriterionCustomizersRequestObjectAsync()
        {
            // Snippet: MutateAdGroupCriterionCustomizersAsync(MutateAdGroupCriterionCustomizersRequest, CallSettings)
            // Additional: MutateAdGroupCriterionCustomizersAsync(MutateAdGroupCriterionCustomizersRequest, CancellationToken)
            // Create client
            AdGroupCriterionCustomizerServiceClient adGroupCriterionCustomizerServiceClient = await AdGroupCriterionCustomizerServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAdGroupCriterionCustomizersRequest request = new MutateAdGroupCriterionCustomizersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupCriterionCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdGroupCriterionCustomizersResponse response = await adGroupCriterionCustomizerServiceClient.MutateAdGroupCriterionCustomizersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupCriterionCustomizers</summary>
        public void MutateAdGroupCriterionCustomizers()
        {
            // Snippet: MutateAdGroupCriterionCustomizers(string, IEnumerable<AdGroupCriterionCustomizerOperation>, CallSettings)
            // Create client
            AdGroupCriterionCustomizerServiceClient adGroupCriterionCustomizerServiceClient = AdGroupCriterionCustomizerServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupCriterionCustomizerOperation> operations = new AdGroupCriterionCustomizerOperation[]
            {
                new AdGroupCriterionCustomizerOperation(),
            };
            // Make the request
            MutateAdGroupCriterionCustomizersResponse response = adGroupCriterionCustomizerServiceClient.MutateAdGroupCriterionCustomizers(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupCriterionCustomizersAsync</summary>
        public async Task MutateAdGroupCriterionCustomizersAsync()
        {
            // Snippet: MutateAdGroupCriterionCustomizersAsync(string, IEnumerable<AdGroupCriterionCustomizerOperation>, CallSettings)
            // Additional: MutateAdGroupCriterionCustomizersAsync(string, IEnumerable<AdGroupCriterionCustomizerOperation>, CancellationToken)
            // Create client
            AdGroupCriterionCustomizerServiceClient adGroupCriterionCustomizerServiceClient = await AdGroupCriterionCustomizerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupCriterionCustomizerOperation> operations = new AdGroupCriterionCustomizerOperation[]
            {
                new AdGroupCriterionCustomizerOperation(),
            };
            // Make the request
            MutateAdGroupCriterionCustomizersResponse response = await adGroupCriterionCustomizerServiceClient.MutateAdGroupCriterionCustomizersAsync(customerId, operations);
            // End snippet
        }
    }
}
