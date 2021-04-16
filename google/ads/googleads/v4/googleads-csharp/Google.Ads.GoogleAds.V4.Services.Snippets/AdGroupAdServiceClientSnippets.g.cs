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

namespace Google.Ads.GoogleAds.V4.Services.Snippets
{
    using Google.Ads.GoogleAds.V4.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAdGroupAdServiceClientSnippets
    {
        /// <summary>Snippet for GetAdGroupAd</summary>
        public void GetAdGroupAdRequestObject()
        {
            // Snippet: GetAdGroupAd(GetAdGroupAdRequest, CallSettings)
            // Create client
            AdGroupAdServiceClient adGroupAdServiceClient = AdGroupAdServiceClient.Create();
            // Initialize request argument(s)
            GetAdGroupAdRequest request = new GetAdGroupAdRequest
            {
                ResourceNameAsAdGroupAdName = AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
            };
            // Make the request
            AdGroupAd response = adGroupAdServiceClient.GetAdGroupAd(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAdAsync</summary>
        public async Task GetAdGroupAdRequestObjectAsync()
        {
            // Snippet: GetAdGroupAdAsync(GetAdGroupAdRequest, CallSettings)
            // Additional: GetAdGroupAdAsync(GetAdGroupAdRequest, CancellationToken)
            // Create client
            AdGroupAdServiceClient adGroupAdServiceClient = await AdGroupAdServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdGroupAdRequest request = new GetAdGroupAdRequest
            {
                ResourceNameAsAdGroupAdName = AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
            };
            // Make the request
            AdGroupAd response = await adGroupAdServiceClient.GetAdGroupAdAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAd</summary>
        public void GetAdGroupAd()
        {
            // Snippet: GetAdGroupAd(string, CallSettings)
            // Create client
            AdGroupAdServiceClient adGroupAdServiceClient = AdGroupAdServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/adGroupAds/[AD_GROUP_AD]";
            // Make the request
            AdGroupAd response = adGroupAdServiceClient.GetAdGroupAd(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAdAsync</summary>
        public async Task GetAdGroupAdAsync()
        {
            // Snippet: GetAdGroupAdAsync(string, CallSettings)
            // Additional: GetAdGroupAdAsync(string, CancellationToken)
            // Create client
            AdGroupAdServiceClient adGroupAdServiceClient = await AdGroupAdServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/adGroupAds/[AD_GROUP_AD]";
            // Make the request
            AdGroupAd response = await adGroupAdServiceClient.GetAdGroupAdAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAd</summary>
        public void GetAdGroupAdResourceNames()
        {
            // Snippet: GetAdGroupAd(AdGroupAdName, CallSettings)
            // Create client
            AdGroupAdServiceClient adGroupAdServiceClient = AdGroupAdServiceClient.Create();
            // Initialize request argument(s)
            AdGroupAdName resourceName = AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]");
            // Make the request
            AdGroupAd response = adGroupAdServiceClient.GetAdGroupAd(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAdAsync</summary>
        public async Task GetAdGroupAdResourceNamesAsync()
        {
            // Snippet: GetAdGroupAdAsync(AdGroupAdName, CallSettings)
            // Additional: GetAdGroupAdAsync(AdGroupAdName, CancellationToken)
            // Create client
            AdGroupAdServiceClient adGroupAdServiceClient = await AdGroupAdServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdGroupAdName resourceName = AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]");
            // Make the request
            AdGroupAd response = await adGroupAdServiceClient.GetAdGroupAdAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupAds</summary>
        public void MutateAdGroupAdsRequestObject()
        {
            // Snippet: MutateAdGroupAds(MutateAdGroupAdsRequest, CallSettings)
            // Create client
            AdGroupAdServiceClient adGroupAdServiceClient = AdGroupAdServiceClient.Create();
            // Initialize request argument(s)
            MutateAdGroupAdsRequest request = new MutateAdGroupAdsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupAdOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateAdGroupAdsResponse response = adGroupAdServiceClient.MutateAdGroupAds(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupAdsAsync</summary>
        public async Task MutateAdGroupAdsRequestObjectAsync()
        {
            // Snippet: MutateAdGroupAdsAsync(MutateAdGroupAdsRequest, CallSettings)
            // Additional: MutateAdGroupAdsAsync(MutateAdGroupAdsRequest, CancellationToken)
            // Create client
            AdGroupAdServiceClient adGroupAdServiceClient = await AdGroupAdServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAdGroupAdsRequest request = new MutateAdGroupAdsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupAdOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateAdGroupAdsResponse response = await adGroupAdServiceClient.MutateAdGroupAdsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupAds</summary>
        public void MutateAdGroupAds()
        {
            // Snippet: MutateAdGroupAds(string, IEnumerable<AdGroupAdOperation>, CallSettings)
            // Create client
            AdGroupAdServiceClient adGroupAdServiceClient = AdGroupAdServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupAdOperation> operations = new AdGroupAdOperation[]
            {
                new AdGroupAdOperation(),
            };
            // Make the request
            MutateAdGroupAdsResponse response = adGroupAdServiceClient.MutateAdGroupAds(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupAdsAsync</summary>
        public async Task MutateAdGroupAdsAsync()
        {
            // Snippet: MutateAdGroupAdsAsync(string, IEnumerable<AdGroupAdOperation>, CallSettings)
            // Additional: MutateAdGroupAdsAsync(string, IEnumerable<AdGroupAdOperation>, CancellationToken)
            // Create client
            AdGroupAdServiceClient adGroupAdServiceClient = await AdGroupAdServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupAdOperation> operations = new AdGroupAdOperation[]
            {
                new AdGroupAdOperation(),
            };
            // Make the request
            MutateAdGroupAdsResponse response = await adGroupAdServiceClient.MutateAdGroupAdsAsync(customerId, operations);
            // End snippet
        }
    }
}
