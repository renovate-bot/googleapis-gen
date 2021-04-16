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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedConversionUploadServiceClientSnippets
    {
        /// <summary>Snippet for UploadClickConversions</summary>
        public void UploadClickConversionsRequestObject()
        {
            // Snippet: UploadClickConversions(UploadClickConversionsRequest, CallSettings)
            // Create client
            ConversionUploadServiceClient conversionUploadServiceClient = ConversionUploadServiceClient.Create();
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
            UploadClickConversionsResponse response = conversionUploadServiceClient.UploadClickConversions(request);
            // End snippet
        }

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

        /// <summary>Snippet for UploadClickConversions</summary>
        public void UploadClickConversions()
        {
            // Snippet: UploadClickConversions(string, IEnumerable<ClickConversion>, bool, CallSettings)
            // Create client
            ConversionUploadServiceClient conversionUploadServiceClient = ConversionUploadServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ClickConversion> conversions = new ClickConversion[]
            {
                new ClickConversion(),
            };
            bool partialFailure = false;
            // Make the request
            UploadClickConversionsResponse response = conversionUploadServiceClient.UploadClickConversions(customerId, conversions, partialFailure);
            // End snippet
        }

        /// <summary>Snippet for UploadClickConversionsAsync</summary>
        public async Task UploadClickConversionsAsync()
        {
            // Snippet: UploadClickConversionsAsync(string, IEnumerable<ClickConversion>, bool, CallSettings)
            // Additional: UploadClickConversionsAsync(string, IEnumerable<ClickConversion>, bool, CancellationToken)
            // Create client
            ConversionUploadServiceClient conversionUploadServiceClient = await ConversionUploadServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<ClickConversion> conversions = new ClickConversion[]
            {
                new ClickConversion(),
            };
            bool partialFailure = false;
            // Make the request
            UploadClickConversionsResponse response = await conversionUploadServiceClient.UploadClickConversionsAsync(customerId, conversions, partialFailure);
            // End snippet
        }

        /// <summary>Snippet for UploadCallConversions</summary>
        public void UploadCallConversionsRequestObject()
        {
            // Snippet: UploadCallConversions(UploadCallConversionsRequest, CallSettings)
            // Create client
            ConversionUploadServiceClient conversionUploadServiceClient = ConversionUploadServiceClient.Create();
            // Initialize request argument(s)
            UploadCallConversionsRequest request = new UploadCallConversionsRequest
            {
                CustomerId = "",
                Conversions =
                {
                    new CallConversion(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            UploadCallConversionsResponse response = conversionUploadServiceClient.UploadCallConversions(request);
            // End snippet
        }

        /// <summary>Snippet for UploadCallConversionsAsync</summary>
        public async Task UploadCallConversionsRequestObjectAsync()
        {
            // Snippet: UploadCallConversionsAsync(UploadCallConversionsRequest, CallSettings)
            // Additional: UploadCallConversionsAsync(UploadCallConversionsRequest, CancellationToken)
            // Create client
            ConversionUploadServiceClient conversionUploadServiceClient = await ConversionUploadServiceClient.CreateAsync();
            // Initialize request argument(s)
            UploadCallConversionsRequest request = new UploadCallConversionsRequest
            {
                CustomerId = "",
                Conversions =
                {
                    new CallConversion(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            UploadCallConversionsResponse response = await conversionUploadServiceClient.UploadCallConversionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UploadCallConversions</summary>
        public void UploadCallConversions()
        {
            // Snippet: UploadCallConversions(string, IEnumerable<CallConversion>, bool, CallSettings)
            // Create client
            ConversionUploadServiceClient conversionUploadServiceClient = ConversionUploadServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CallConversion> conversions = new CallConversion[]
            {
                new CallConversion(),
            };
            bool partialFailure = false;
            // Make the request
            UploadCallConversionsResponse response = conversionUploadServiceClient.UploadCallConversions(customerId, conversions, partialFailure);
            // End snippet
        }

        /// <summary>Snippet for UploadCallConversionsAsync</summary>
        public async Task UploadCallConversionsAsync()
        {
            // Snippet: UploadCallConversionsAsync(string, IEnumerable<CallConversion>, bool, CallSettings)
            // Additional: UploadCallConversionsAsync(string, IEnumerable<CallConversion>, bool, CancellationToken)
            // Create client
            ConversionUploadServiceClient conversionUploadServiceClient = await ConversionUploadServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CallConversion> conversions = new CallConversion[]
            {
                new CallConversion(),
            };
            bool partialFailure = false;
            // Make the request
            UploadCallConversionsResponse response = await conversionUploadServiceClient.UploadCallConversionsAsync(customerId, conversions, partialFailure);
            // End snippet
        }
    }
}
