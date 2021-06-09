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

namespace Google.Ads.GoogleAds.V8.Services.Snippets
{
    using Google.Ads.GoogleAds.V8.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAdGroupCriterionLabelServiceClientSnippets
    {
        /// <summary>Snippet for GetAdGroupCriterionLabel</summary>
        public void GetAdGroupCriterionLabelRequestObject()
        {
            // Snippet: GetAdGroupCriterionLabel(GetAdGroupCriterionLabelRequest, CallSettings)
            // Create client
            AdGroupCriterionLabelServiceClient adGroupCriterionLabelServiceClient = AdGroupCriterionLabelServiceClient.Create();
            // Initialize request argument(s)
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]"),
            };
            // Make the request
            AdGroupCriterionLabel response = adGroupCriterionLabelServiceClient.GetAdGroupCriterionLabel(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupCriterionLabelAsync</summary>
        public async Task GetAdGroupCriterionLabelRequestObjectAsync()
        {
            // Snippet: GetAdGroupCriterionLabelAsync(GetAdGroupCriterionLabelRequest, CallSettings)
            // Additional: GetAdGroupCriterionLabelAsync(GetAdGroupCriterionLabelRequest, CancellationToken)
            // Create client
            AdGroupCriterionLabelServiceClient adGroupCriterionLabelServiceClient = await AdGroupCriterionLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]"),
            };
            // Make the request
            AdGroupCriterionLabel response = await adGroupCriterionLabelServiceClient.GetAdGroupCriterionLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupCriterionLabel</summary>
        public void GetAdGroupCriterionLabel()
        {
            // Snippet: GetAdGroupCriterionLabel(string, CallSettings)
            // Create client
            AdGroupCriterionLabelServiceClient adGroupCriterionLabelServiceClient = AdGroupCriterionLabelServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupCriterionLabels/[AD_GROUP_ID]~[CRITERION_ID]~[LABEL_ID]";
            // Make the request
            AdGroupCriterionLabel response = adGroupCriterionLabelServiceClient.GetAdGroupCriterionLabel(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupCriterionLabelAsync</summary>
        public async Task GetAdGroupCriterionLabelAsync()
        {
            // Snippet: GetAdGroupCriterionLabelAsync(string, CallSettings)
            // Additional: GetAdGroupCriterionLabelAsync(string, CancellationToken)
            // Create client
            AdGroupCriterionLabelServiceClient adGroupCriterionLabelServiceClient = await AdGroupCriterionLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupCriterionLabels/[AD_GROUP_ID]~[CRITERION_ID]~[LABEL_ID]";
            // Make the request
            AdGroupCriterionLabel response = await adGroupCriterionLabelServiceClient.GetAdGroupCriterionLabelAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupCriterionLabel</summary>
        public void GetAdGroupCriterionLabelResourceNames()
        {
            // Snippet: GetAdGroupCriterionLabel(AdGroupCriterionLabelName, CallSettings)
            // Create client
            AdGroupCriterionLabelServiceClient adGroupCriterionLabelServiceClient = AdGroupCriterionLabelServiceClient.Create();
            // Initialize request argument(s)
            AdGroupCriterionLabelName resourceName = AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]");
            // Make the request
            AdGroupCriterionLabel response = adGroupCriterionLabelServiceClient.GetAdGroupCriterionLabel(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupCriterionLabelAsync</summary>
        public async Task GetAdGroupCriterionLabelResourceNamesAsync()
        {
            // Snippet: GetAdGroupCriterionLabelAsync(AdGroupCriterionLabelName, CallSettings)
            // Additional: GetAdGroupCriterionLabelAsync(AdGroupCriterionLabelName, CancellationToken)
            // Create client
            AdGroupCriterionLabelServiceClient adGroupCriterionLabelServiceClient = await AdGroupCriterionLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdGroupCriterionLabelName resourceName = AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[LABEL_ID]");
            // Make the request
            AdGroupCriterionLabel response = await adGroupCriterionLabelServiceClient.GetAdGroupCriterionLabelAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupCriterionLabels</summary>
        public void MutateAdGroupCriterionLabelsRequestObject()
        {
            // Snippet: MutateAdGroupCriterionLabels(MutateAdGroupCriterionLabelsRequest, CallSettings)
            // Create client
            AdGroupCriterionLabelServiceClient adGroupCriterionLabelServiceClient = AdGroupCriterionLabelServiceClient.Create();
            // Initialize request argument(s)
            MutateAdGroupCriterionLabelsRequest request = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupCriterionLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateAdGroupCriterionLabelsResponse response = adGroupCriterionLabelServiceClient.MutateAdGroupCriterionLabels(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupCriterionLabelsAsync</summary>
        public async Task MutateAdGroupCriterionLabelsRequestObjectAsync()
        {
            // Snippet: MutateAdGroupCriterionLabelsAsync(MutateAdGroupCriterionLabelsRequest, CallSettings)
            // Additional: MutateAdGroupCriterionLabelsAsync(MutateAdGroupCriterionLabelsRequest, CancellationToken)
            // Create client
            AdGroupCriterionLabelServiceClient adGroupCriterionLabelServiceClient = await AdGroupCriterionLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAdGroupCriterionLabelsRequest request = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupCriterionLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateAdGroupCriterionLabelsResponse response = await adGroupCriterionLabelServiceClient.MutateAdGroupCriterionLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupCriterionLabels</summary>
        public void MutateAdGroupCriterionLabels()
        {
            // Snippet: MutateAdGroupCriterionLabels(string, IEnumerable<AdGroupCriterionLabelOperation>, CallSettings)
            // Create client
            AdGroupCriterionLabelServiceClient adGroupCriterionLabelServiceClient = AdGroupCriterionLabelServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupCriterionLabelOperation> operations = new AdGroupCriterionLabelOperation[]
            {
                new AdGroupCriterionLabelOperation(),
            };
            // Make the request
            MutateAdGroupCriterionLabelsResponse response = adGroupCriterionLabelServiceClient.MutateAdGroupCriterionLabels(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupCriterionLabelsAsync</summary>
        public async Task MutateAdGroupCriterionLabelsAsync()
        {
            // Snippet: MutateAdGroupCriterionLabelsAsync(string, IEnumerable<AdGroupCriterionLabelOperation>, CallSettings)
            // Additional: MutateAdGroupCriterionLabelsAsync(string, IEnumerable<AdGroupCriterionLabelOperation>, CancellationToken)
            // Create client
            AdGroupCriterionLabelServiceClient adGroupCriterionLabelServiceClient = await AdGroupCriterionLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupCriterionLabelOperation> operations = new AdGroupCriterionLabelOperation[]
            {
                new AdGroupCriterionLabelOperation(),
            };
            // Make the request
            MutateAdGroupCriterionLabelsResponse response = await adGroupCriterionLabelServiceClient.MutateAdGroupCriterionLabelsAsync(customerId, operations);
            // End snippet
        }
    }
}
