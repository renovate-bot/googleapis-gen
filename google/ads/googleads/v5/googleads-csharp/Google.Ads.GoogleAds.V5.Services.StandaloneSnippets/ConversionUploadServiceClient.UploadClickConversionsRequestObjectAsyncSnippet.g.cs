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

namespace Google.Ads.GoogleAds.V5.Services.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedConversionUploadServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for UploadClickConversionsAsync</summary>
        public async Task UploadClickConversionsRequestObjectAsync()
        {
            // Snippet: UploadClickConversionsAsync(UploadClickConversionsRequest, CallSettings)
            // Additional: UploadClickConversionsAsync(UploadClickConversionsRequest, CancellationToken)
            // Create client
            ConversionUploadServiceClient conversionUploadServiceClient = await ConversionUploadServiceClient.CreateAsync();
            // Initialize request argument(s)
            UploadClickConversionsRequest request = new UploadClickConversionsRequest
            {
                CustomerId = "",
                Conversions =
                {
                    new ClickConversion(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            UploadClickConversionsResponse response = await conversionUploadServiceClient.UploadClickConversionsAsync(request);
            // End snippet
        }
    }
}
