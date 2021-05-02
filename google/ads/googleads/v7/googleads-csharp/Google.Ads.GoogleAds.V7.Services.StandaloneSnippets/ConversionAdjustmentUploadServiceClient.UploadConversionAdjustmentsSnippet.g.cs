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

namespace Google.Ads.GoogleAds.V7.Services.Snippets
{
    using System.Collections.Generic;

    public sealed partial class GeneratedConversionAdjustmentUploadServiceClientStandaloneSnippets
    {
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
    }
}
