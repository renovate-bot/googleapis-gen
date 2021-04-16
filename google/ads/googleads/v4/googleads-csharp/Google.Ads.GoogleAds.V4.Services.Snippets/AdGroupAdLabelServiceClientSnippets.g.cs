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
    public sealed class GeneratedAdGroupAdLabelServiceClientSnippets
    {
        /// <summary>Snippet for GetAdGroupAdLabel</summary>
        public void GetAdGroupAdLabelRequestObject()
        {
            // Snippet: GetAdGroupAdLabel(GetAdGroupAdLabelRequest, CallSettings)
            // Create client
            AdGroupAdLabelServiceClient adGroupAdLabelServiceClient = AdGroupAdLabelServiceClient.Create();
            // Initialize request argument(s)
            GetAdGroupAdLabelRequest request = new GetAdGroupAdLabelRequest
            {
                ResourceNameAsAdGroupAdLabelName = AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]"),
            };
            // Make the request
            AdGroupAdLabel response = adGroupAdLabelServiceClient.GetAdGroupAdLabel(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAdLabelAsync</summary>
        public async Task GetAdGroupAdLabelRequestObjectAsync()
        {
            // Snippet: GetAdGroupAdLabelAsync(GetAdGroupAdLabelRequest, CallSettings)
            // Additional: GetAdGroupAdLabelAsync(GetAdGroupAdLabelRequest, CancellationToken)
            // Create client
            AdGroupAdLabelServiceClient adGroupAdLabelServiceClient = await AdGroupAdLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdGroupAdLabelRequest request = new GetAdGroupAdLabelRequest
            {
                ResourceNameAsAdGroupAdLabelName = AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]"),
            };
            // Make the request
            AdGroupAdLabel response = await adGroupAdLabelServiceClient.GetAdGroupAdLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAdLabel</summary>
        public void GetAdGroupAdLabel()
        {
            // Snippet: GetAdGroupAdLabel(string, CallSettings)
            // Create client
            AdGroupAdLabelServiceClient adGroupAdLabelServiceClient = AdGroupAdLabelServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/adGroupAdLabels/[AD_GROUP_AD_LABEL]";
            // Make the request
            AdGroupAdLabel response = adGroupAdLabelServiceClient.GetAdGroupAdLabel(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAdLabelAsync</summary>
        public async Task GetAdGroupAdLabelAsync()
        {
            // Snippet: GetAdGroupAdLabelAsync(string, CallSettings)
            // Additional: GetAdGroupAdLabelAsync(string, CancellationToken)
            // Create client
            AdGroupAdLabelServiceClient adGroupAdLabelServiceClient = await AdGroupAdLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/adGroupAdLabels/[AD_GROUP_AD_LABEL]";
            // Make the request
            AdGroupAdLabel response = await adGroupAdLabelServiceClient.GetAdGroupAdLabelAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAdLabel</summary>
        public void GetAdGroupAdLabelResourceNames()
        {
            // Snippet: GetAdGroupAdLabel(AdGroupAdLabelName, CallSettings)
            // Create client
            AdGroupAdLabelServiceClient adGroupAdLabelServiceClient = AdGroupAdLabelServiceClient.Create();
            // Initialize request argument(s)
            AdGroupAdLabelName resourceName = AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]");
            // Make the request
            AdGroupAdLabel response = adGroupAdLabelServiceClient.GetAdGroupAdLabel(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupAdLabelAsync</summary>
        public async Task GetAdGroupAdLabelResourceNamesAsync()
        {
            // Snippet: GetAdGroupAdLabelAsync(AdGroupAdLabelName, CallSettings)
            // Additional: GetAdGroupAdLabelAsync(AdGroupAdLabelName, CancellationToken)
            // Create client
            AdGroupAdLabelServiceClient adGroupAdLabelServiceClient = await AdGroupAdLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdGroupAdLabelName resourceName = AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]");
            // Make the request
            AdGroupAdLabel response = await adGroupAdLabelServiceClient.GetAdGroupAdLabelAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupAdLabels</summary>
        public void MutateAdGroupAdLabelsRequestObject()
        {
            // Snippet: MutateAdGroupAdLabels(MutateAdGroupAdLabelsRequest, CallSettings)
            // Create client
            AdGroupAdLabelServiceClient adGroupAdLabelServiceClient = AdGroupAdLabelServiceClient.Create();
            // Initialize request argument(s)
            MutateAdGroupAdLabelsRequest request = new MutateAdGroupAdLabelsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupAdLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateAdGroupAdLabelsResponse response = adGroupAdLabelServiceClient.MutateAdGroupAdLabels(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupAdLabelsAsync</summary>
        public async Task MutateAdGroupAdLabelsRequestObjectAsync()
        {
            // Snippet: MutateAdGroupAdLabelsAsync(MutateAdGroupAdLabelsRequest, CallSettings)
            // Additional: MutateAdGroupAdLabelsAsync(MutateAdGroupAdLabelsRequest, CancellationToken)
            // Create client
            AdGroupAdLabelServiceClient adGroupAdLabelServiceClient = await AdGroupAdLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAdGroupAdLabelsRequest request = new MutateAdGroupAdLabelsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupAdLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateAdGroupAdLabelsResponse response = await adGroupAdLabelServiceClient.MutateAdGroupAdLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupAdLabels</summary>
        public void MutateAdGroupAdLabels()
        {
            // Snippet: MutateAdGroupAdLabels(string, IEnumerable<AdGroupAdLabelOperation>, CallSettings)
            // Create client
            AdGroupAdLabelServiceClient adGroupAdLabelServiceClient = AdGroupAdLabelServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupAdLabelOperation> operations = new AdGroupAdLabelOperation[]
            {
                new AdGroupAdLabelOperation(),
            };
            // Make the request
            MutateAdGroupAdLabelsResponse response = adGroupAdLabelServiceClient.MutateAdGroupAdLabels(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupAdLabelsAsync</summary>
        public async Task MutateAdGroupAdLabelsAsync()
        {
            // Snippet: MutateAdGroupAdLabelsAsync(string, IEnumerable<AdGroupAdLabelOperation>, CallSettings)
            // Additional: MutateAdGroupAdLabelsAsync(string, IEnumerable<AdGroupAdLabelOperation>, CancellationToken)
            // Create client
            AdGroupAdLabelServiceClient adGroupAdLabelServiceClient = await AdGroupAdLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupAdLabelOperation> operations = new AdGroupAdLabelOperation[]
            {
                new AdGroupAdLabelOperation(),
            };
            // Make the request
            MutateAdGroupAdLabelsResponse response = await adGroupAdLabelServiceClient.MutateAdGroupAdLabelsAsync(customerId, operations);
            // End snippet
        }
    }
}
