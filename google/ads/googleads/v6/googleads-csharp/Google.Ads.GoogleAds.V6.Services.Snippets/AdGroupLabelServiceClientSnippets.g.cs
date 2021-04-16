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

namespace Google.Ads.GoogleAds.V6.Services.Snippets
{
    using Google.Ads.GoogleAds.V6.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAdGroupLabelServiceClientSnippets
    {
        /// <summary>Snippet for GetAdGroupLabel</summary>
        public void GetAdGroupLabelRequestObject()
        {
            // Snippet: GetAdGroupLabel(GetAdGroupLabelRequest, CallSettings)
            // Create client
            AdGroupLabelServiceClient adGroupLabelServiceClient = AdGroupLabelServiceClient.Create();
            // Initialize request argument(s)
            GetAdGroupLabelRequest request = new GetAdGroupLabelRequest
            {
                ResourceNameAsAdGroupLabelName = AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[LABEL_ID]"),
            };
            // Make the request
            AdGroupLabel response = adGroupLabelServiceClient.GetAdGroupLabel(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupLabelAsync</summary>
        public async Task GetAdGroupLabelRequestObjectAsync()
        {
            // Snippet: GetAdGroupLabelAsync(GetAdGroupLabelRequest, CallSettings)
            // Additional: GetAdGroupLabelAsync(GetAdGroupLabelRequest, CancellationToken)
            // Create client
            AdGroupLabelServiceClient adGroupLabelServiceClient = await AdGroupLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdGroupLabelRequest request = new GetAdGroupLabelRequest
            {
                ResourceNameAsAdGroupLabelName = AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[LABEL_ID]"),
            };
            // Make the request
            AdGroupLabel response = await adGroupLabelServiceClient.GetAdGroupLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupLabel</summary>
        public void GetAdGroupLabel()
        {
            // Snippet: GetAdGroupLabel(string, CallSettings)
            // Create client
            AdGroupLabelServiceClient adGroupLabelServiceClient = AdGroupLabelServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupLabels/[AD_GROUP_ID]~[LABEL_ID]";
            // Make the request
            AdGroupLabel response = adGroupLabelServiceClient.GetAdGroupLabel(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupLabelAsync</summary>
        public async Task GetAdGroupLabelAsync()
        {
            // Snippet: GetAdGroupLabelAsync(string, CallSettings)
            // Additional: GetAdGroupLabelAsync(string, CancellationToken)
            // Create client
            AdGroupLabelServiceClient adGroupLabelServiceClient = await AdGroupLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupLabels/[AD_GROUP_ID]~[LABEL_ID]";
            // Make the request
            AdGroupLabel response = await adGroupLabelServiceClient.GetAdGroupLabelAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupLabel</summary>
        public void GetAdGroupLabelResourceNames()
        {
            // Snippet: GetAdGroupLabel(AdGroupLabelName, CallSettings)
            // Create client
            AdGroupLabelServiceClient adGroupLabelServiceClient = AdGroupLabelServiceClient.Create();
            // Initialize request argument(s)
            AdGroupLabelName resourceName = AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[LABEL_ID]");
            // Make the request
            AdGroupLabel response = adGroupLabelServiceClient.GetAdGroupLabel(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupLabelAsync</summary>
        public async Task GetAdGroupLabelResourceNamesAsync()
        {
            // Snippet: GetAdGroupLabelAsync(AdGroupLabelName, CallSettings)
            // Additional: GetAdGroupLabelAsync(AdGroupLabelName, CancellationToken)
            // Create client
            AdGroupLabelServiceClient adGroupLabelServiceClient = await AdGroupLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdGroupLabelName resourceName = AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[LABEL_ID]");
            // Make the request
            AdGroupLabel response = await adGroupLabelServiceClient.GetAdGroupLabelAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupLabels</summary>
        public void MutateAdGroupLabelsRequestObject()
        {
            // Snippet: MutateAdGroupLabels(MutateAdGroupLabelsRequest, CallSettings)
            // Create client
            AdGroupLabelServiceClient adGroupLabelServiceClient = AdGroupLabelServiceClient.Create();
            // Initialize request argument(s)
            MutateAdGroupLabelsRequest request = new MutateAdGroupLabelsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateAdGroupLabelsResponse response = adGroupLabelServiceClient.MutateAdGroupLabels(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupLabelsAsync</summary>
        public async Task MutateAdGroupLabelsRequestObjectAsync()
        {
            // Snippet: MutateAdGroupLabelsAsync(MutateAdGroupLabelsRequest, CallSettings)
            // Additional: MutateAdGroupLabelsAsync(MutateAdGroupLabelsRequest, CancellationToken)
            // Create client
            AdGroupLabelServiceClient adGroupLabelServiceClient = await AdGroupLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAdGroupLabelsRequest request = new MutateAdGroupLabelsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateAdGroupLabelsResponse response = await adGroupLabelServiceClient.MutateAdGroupLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupLabels</summary>
        public void MutateAdGroupLabels()
        {
            // Snippet: MutateAdGroupLabels(string, IEnumerable<AdGroupLabelOperation>, CallSettings)
            // Create client
            AdGroupLabelServiceClient adGroupLabelServiceClient = AdGroupLabelServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupLabelOperation> operations = new AdGroupLabelOperation[]
            {
                new AdGroupLabelOperation(),
            };
            // Make the request
            MutateAdGroupLabelsResponse response = adGroupLabelServiceClient.MutateAdGroupLabels(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupLabelsAsync</summary>
        public async Task MutateAdGroupLabelsAsync()
        {
            // Snippet: MutateAdGroupLabelsAsync(string, IEnumerable<AdGroupLabelOperation>, CallSettings)
            // Additional: MutateAdGroupLabelsAsync(string, IEnumerable<AdGroupLabelOperation>, CancellationToken)
            // Create client
            AdGroupLabelServiceClient adGroupLabelServiceClient = await AdGroupLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupLabelOperation> operations = new AdGroupLabelOperation[]
            {
                new AdGroupLabelOperation(),
            };
            // Make the request
            MutateAdGroupLabelsResponse response = await adGroupLabelServiceClient.MutateAdGroupLabelsAsync(customerId, operations);
            // End snippet
        }
    }
}
