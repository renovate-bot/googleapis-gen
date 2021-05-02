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
    using Google.Ads.GoogleAds.V7.Enums;
    using Google.Ads.GoogleAds.V7.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedLabelServiceClientSnippets
    {
        /// <summary>Snippet for GetLabel</summary>
        public void GetLabelRequestObject()
        {
            // Snippet: GetLabel(GetLabelRequest, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            GetLabelRequest request = new GetLabelRequest
            {
                ResourceNameAsLabelName = LabelName.FromCustomerLabel("[CUSTOMER_ID]", "[LABEL_ID]"),
            };
            // Make the request
            Label response = labelServiceClient.GetLabel(request);
            // End snippet
        }

        /// <summary>Snippet for GetLabelAsync</summary>
        public async Task GetLabelRequestObjectAsync()
        {
            // Snippet: GetLabelAsync(GetLabelRequest, CallSettings)
            // Additional: GetLabelAsync(GetLabelRequest, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLabelRequest request = new GetLabelRequest
            {
                ResourceNameAsLabelName = LabelName.FromCustomerLabel("[CUSTOMER_ID]", "[LABEL_ID]"),
            };
            // Make the request
            Label response = await labelServiceClient.GetLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLabel</summary>
        public void GetLabel()
        {
            // Snippet: GetLabel(string, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/labels/[LABEL_ID]";
            // Make the request
            Label response = labelServiceClient.GetLabel(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetLabelAsync</summary>
        public async Task GetLabelAsync()
        {
            // Snippet: GetLabelAsync(string, CallSettings)
            // Additional: GetLabelAsync(string, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/labels/[LABEL_ID]";
            // Make the request
            Label response = await labelServiceClient.GetLabelAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetLabel</summary>
        public void GetLabelResourceNames()
        {
            // Snippet: GetLabel(LabelName, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            LabelName resourceName = LabelName.FromCustomerLabel("[CUSTOMER_ID]", "[LABEL_ID]");
            // Make the request
            Label response = labelServiceClient.GetLabel(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetLabelAsync</summary>
        public async Task GetLabelResourceNamesAsync()
        {
            // Snippet: GetLabelAsync(LabelName, CallSettings)
            // Additional: GetLabelAsync(LabelName, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            LabelName resourceName = LabelName.FromCustomerLabel("[CUSTOMER_ID]", "[LABEL_ID]");
            // Make the request
            Label response = await labelServiceClient.GetLabelAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateLabels</summary>
        public void MutateLabelsRequestObject()
        {
            // Snippet: MutateLabels(MutateLabelsRequest, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            MutateLabelsRequest request = new MutateLabelsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new LabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateLabelsResponse response = labelServiceClient.MutateLabels(request);
            // End snippet
        }

        /// <summary>Snippet for MutateLabelsAsync</summary>
        public async Task MutateLabelsRequestObjectAsync()
        {
            // Snippet: MutateLabelsAsync(MutateLabelsRequest, CallSettings)
            // Additional: MutateLabelsAsync(MutateLabelsRequest, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateLabelsRequest request = new MutateLabelsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new LabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateLabelsResponse response = await labelServiceClient.MutateLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateLabels</summary>
        public void MutateLabels()
        {
            // Snippet: MutateLabels(string, IEnumerable<LabelOperation>, CallSettings)
            // Create client
            LabelServiceClient labelServiceClient = LabelServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<LabelOperation> operations = new LabelOperation[]
            {
                new LabelOperation(),
            };
            // Make the request
            MutateLabelsResponse response = labelServiceClient.MutateLabels(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateLabelsAsync</summary>
        public async Task MutateLabelsAsync()
        {
            // Snippet: MutateLabelsAsync(string, IEnumerable<LabelOperation>, CallSettings)
            // Additional: MutateLabelsAsync(string, IEnumerable<LabelOperation>, CancellationToken)
            // Create client
            LabelServiceClient labelServiceClient = await LabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<LabelOperation> operations = new LabelOperation[]
            {
                new LabelOperation(),
            };
            // Make the request
            MutateLabelsResponse response = await labelServiceClient.MutateLabelsAsync(customerId, operations);
            // End snippet
        }
    }
}
