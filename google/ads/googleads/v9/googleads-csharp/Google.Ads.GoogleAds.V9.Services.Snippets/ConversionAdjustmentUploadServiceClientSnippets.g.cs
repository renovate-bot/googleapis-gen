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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedConversionAdjustmentUploadServiceClientSnippets
    {
        /// <summary>Snippet for UploadConversionAdjustments</summary>
        public void UploadConversionAdjustmentsRequestObject()
        {
            // Snippet: UploadConversionAdjustments(UploadConversionAdjustmentsRequest, CallSettings)
            // Create client
            ConversionAdjustmentUploadServiceClient conversionAdjustmentUploadServiceClient = ConversionAdjustmentUploadServiceClient.Create();
            // Initialize request argument(s)
            UploadConversionAdjustmentsRequest request = new UploadConversionAdjustmentsRequest
            {
                CustomerId = "",
                ConversionAdjustments =
                {
                    new ConversionAdjustment(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            UploadConversionAdjustmentsResponse response = conversionAdjustmentUploadServiceClient.UploadConversionAdjustments(request);
            // End snippet
        }

        /// <summary>Snippet for UploadConversionAdjustmentsAsync</summary>
        public async Task UploadConversionAdjustmentsRequestObjectAsync()
        {
            // Snippet: UploadConversionAdjustmentsAsync(UploadConversionAdjustmentsRequest, CallSettings)
            // Additional: UploadConversionAdjustmentsAsync(UploadConversionAdjustmentsRequest, CancellationToken)
            // Create client
            ConversionAdjustmentUploadServiceClient conversionAdjustmentUploadServiceClient = await ConversionAdjustmentUploadServiceClient.CreateAsync();
            // Initialize request argument(s)
            UploadConversionAdjustmentsRequest request = new UploadConversionAdjustmentsRequest
            {
                CustomerId = "",
                ConversionAdjustments =
                {
                    new ConversionAdjustment(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            UploadConversionAdjustmentsResponse response = await conversionAdjustmentUploadServiceClient.UploadConversionAdjustmentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UploadConversionAdjustments</summary>
        public void UploadConversionAdjustments()
        {
            // Snippet: UploadConversionAdjustments(string, IEnumerable<ConversionAdjustment>, bool, CallSettings)
            // Create client
            ConversionAdjustmentUploadServiceClient conversionAdjustmentUploadServiceClient = ConversionAdjustmentUploadServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ConversionAdjustment> conversionAdjustments = new ConversionAdjustment[]
            {
                new ConversionAdjustment(),
            };
            bool partialFailure = false;
            // Make the request
            UploadConversionAdjustmentsResponse response = conversionAdjustmentUploadServiceClient.UploadConversionAdjustments(customerId, conversionAdjustments, partialFailure);
            // End snippet
        }

        /// <summary>Snippet for UploadConversionAdjustmentsAsync</summary>
        public async Task UploadConversionAdjustmentsAsync()
        {
            // Snippet: UploadConversionAdjustmentsAsync(string, IEnumerable<ConversionAdjustment>, bool, CallSettings)
            // Additional: UploadConversionAdjustmentsAsync(string, IEnumerable<ConversionAdjustment>, bool, CancellationToken)
            // Create client
            ConversionAdjustmentUploadServiceClient conversionAdjustmentUploadServiceClient = await ConversionAdjustmentUploadServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ConversionAdjustment> conversionAdjustments = new ConversionAdjustment[]
            {
                new ConversionAdjustment(),
            };
            bool partialFailure = false;
            // Make the request
            UploadConversionAdjustmentsResponse response = await conversionAdjustmentUploadServiceClient.UploadConversionAdjustmentsAsync(customerId, conversionAdjustments, partialFailure);
            // End snippet
        }
    }
}
