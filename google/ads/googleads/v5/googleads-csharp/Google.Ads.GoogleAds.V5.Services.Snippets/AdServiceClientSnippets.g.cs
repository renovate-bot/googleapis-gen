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
    using Google.Ads.GoogleAds.V5.Enums;
    using Google.Ads.GoogleAds.V5.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAdServiceClientSnippets
    {
        /// <summary>Snippet for GetAd</summary>
        public void GetAdRequestObject()
        {
            // Snippet: GetAd(GetAdRequest, CallSettings)
            // Create client
            AdServiceClient adServiceClient = AdServiceClient.Create();
            // Initialize request argument(s)
            GetAdRequest request = new GetAdRequest
            {
                ResourceNameAsAdName = AdName.FromCustomerAd("[CUSTOMER]", "[AD]"),
            };
            // Make the request
            Ad response = adServiceClient.GetAd(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdAsync</summary>
        public async Task GetAdRequestObjectAsync()
        {
            // Snippet: GetAdAsync(GetAdRequest, CallSettings)
            // Additional: GetAdAsync(GetAdRequest, CancellationToken)
            // Create client
            AdServiceClient adServiceClient = await AdServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdRequest request = new GetAdRequest
            {
                ResourceNameAsAdName = AdName.FromCustomerAd("[CUSTOMER]", "[AD]"),
            };
            // Make the request
            Ad response = await adServiceClient.GetAdAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAd</summary>
        public void GetAd()
        {
            // Snippet: GetAd(string, CallSettings)
            // Create client
            AdServiceClient adServiceClient = AdServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/ads/[AD]";
            // Make the request
            Ad response = adServiceClient.GetAd(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdAsync</summary>
        public async Task GetAdAsync()
        {
            // Snippet: GetAdAsync(string, CallSettings)
            // Additional: GetAdAsync(string, CancellationToken)
            // Create client
            AdServiceClient adServiceClient = await AdServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/ads/[AD]";
            // Make the request
            Ad response = await adServiceClient.GetAdAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAd</summary>
        public void GetAdResourceNames()
        {
            // Snippet: GetAd(AdName, CallSettings)
            // Create client
            AdServiceClient adServiceClient = AdServiceClient.Create();
            // Initialize request argument(s)
            AdName resourceName = AdName.FromCustomerAd("[CUSTOMER]", "[AD]");
            // Make the request
            Ad response = adServiceClient.GetAd(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdAsync</summary>
        public async Task GetAdResourceNamesAsync()
        {
            // Snippet: GetAdAsync(AdName, CallSettings)
            // Additional: GetAdAsync(AdName, CancellationToken)
            // Create client
            AdServiceClient adServiceClient = await AdServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdName resourceName = AdName.FromCustomerAd("[CUSTOMER]", "[AD]");
            // Make the request
            Ad response = await adServiceClient.GetAdAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAds</summary>
        public void MutateAdsRequestObject()
        {
            // Snippet: MutateAds(MutateAdsRequest, CallSettings)
            // Create client
            AdServiceClient adServiceClient = AdServiceClient.Create();
            // Initialize request argument(s)
            MutateAdsRequest request = new MutateAdsRequest
            {
                CustomerId = "",
                Operations = { new AdOperation(), },
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdsResponse response = adServiceClient.MutateAds(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdsAsync</summary>
        public async Task MutateAdsRequestObjectAsync()
        {
            // Snippet: MutateAdsAsync(MutateAdsRequest, CallSettings)
            // Additional: MutateAdsAsync(MutateAdsRequest, CancellationToken)
            // Create client
            AdServiceClient adServiceClient = await AdServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAdsRequest request = new MutateAdsRequest
            {
                CustomerId = "",
                Operations = { new AdOperation(), },
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateAdsResponse response = await adServiceClient.MutateAdsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAds</summary>
        public void MutateAds()
        {
            // Snippet: MutateAds(string, IEnumerable<AdOperation>, CallSettings)
            // Create client
            AdServiceClient adServiceClient = AdServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdOperation> operations = new AdOperation[] { new AdOperation(), };
            // Make the request
            MutateAdsResponse response = adServiceClient.MutateAds(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAdsAsync</summary>
        public async Task MutateAdsAsync()
        {
            // Snippet: MutateAdsAsync(string, IEnumerable<AdOperation>, CallSettings)
            // Additional: MutateAdsAsync(string, IEnumerable<AdOperation>, CancellationToken)
            // Create client
            AdServiceClient adServiceClient = await AdServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdOperation> operations = new AdOperation[] { new AdOperation(), };
            // Make the request
            MutateAdsResponse response = await adServiceClient.MutateAdsAsync(customerId, operations);
            // End snippet
        }
    }
}
