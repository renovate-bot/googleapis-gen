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
    public sealed class GeneratedCampaignLabelServiceClientSnippets
    {
        /// <summary>Snippet for GetCampaignLabel</summary>
        public void GetCampaignLabelRequestObject()
        {
            // Snippet: GetCampaignLabel(GetCampaignLabelRequest, CallSettings)
            // Create client
            CampaignLabelServiceClient campaignLabelServiceClient = CampaignLabelServiceClient.Create();
            // Initialize request argument(s)
            GetCampaignLabelRequest request = new GetCampaignLabelRequest
            {
                ResourceNameAsCampaignLabelName = CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[LABEL_ID]"),
            };
            // Make the request
            CampaignLabel response = campaignLabelServiceClient.GetCampaignLabel(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignLabelAsync</summary>
        public async Task GetCampaignLabelRequestObjectAsync()
        {
            // Snippet: GetCampaignLabelAsync(GetCampaignLabelRequest, CallSettings)
            // Additional: GetCampaignLabelAsync(GetCampaignLabelRequest, CancellationToken)
            // Create client
            CampaignLabelServiceClient campaignLabelServiceClient = await CampaignLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCampaignLabelRequest request = new GetCampaignLabelRequest
            {
                ResourceNameAsCampaignLabelName = CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[LABEL_ID]"),
            };
            // Make the request
            CampaignLabel response = await campaignLabelServiceClient.GetCampaignLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignLabel</summary>
        public void GetCampaignLabel()
        {
            // Snippet: GetCampaignLabel(string, CallSettings)
            // Create client
            CampaignLabelServiceClient campaignLabelServiceClient = CampaignLabelServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaignLabels/[CAMPAIGN_ID]~[LABEL_ID]";
            // Make the request
            CampaignLabel response = campaignLabelServiceClient.GetCampaignLabel(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignLabelAsync</summary>
        public async Task GetCampaignLabelAsync()
        {
            // Snippet: GetCampaignLabelAsync(string, CallSettings)
            // Additional: GetCampaignLabelAsync(string, CancellationToken)
            // Create client
            CampaignLabelServiceClient campaignLabelServiceClient = await CampaignLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaignLabels/[CAMPAIGN_ID]~[LABEL_ID]";
            // Make the request
            CampaignLabel response = await campaignLabelServiceClient.GetCampaignLabelAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignLabel</summary>
        public void GetCampaignLabelResourceNames()
        {
            // Snippet: GetCampaignLabel(CampaignLabelName, CallSettings)
            // Create client
            CampaignLabelServiceClient campaignLabelServiceClient = CampaignLabelServiceClient.Create();
            // Initialize request argument(s)
            CampaignLabelName resourceName = CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[LABEL_ID]");
            // Make the request
            CampaignLabel response = campaignLabelServiceClient.GetCampaignLabel(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignLabelAsync</summary>
        public async Task GetCampaignLabelResourceNamesAsync()
        {
            // Snippet: GetCampaignLabelAsync(CampaignLabelName, CallSettings)
            // Additional: GetCampaignLabelAsync(CampaignLabelName, CancellationToken)
            // Create client
            CampaignLabelServiceClient campaignLabelServiceClient = await CampaignLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            CampaignLabelName resourceName = CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[LABEL_ID]");
            // Make the request
            CampaignLabel response = await campaignLabelServiceClient.GetCampaignLabelAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignLabels</summary>
        public void MutateCampaignLabelsRequestObject()
        {
            // Snippet: MutateCampaignLabels(MutateCampaignLabelsRequest, CallSettings)
            // Create client
            CampaignLabelServiceClient campaignLabelServiceClient = CampaignLabelServiceClient.Create();
            // Initialize request argument(s)
            MutateCampaignLabelsRequest request = new MutateCampaignLabelsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateCampaignLabelsResponse response = campaignLabelServiceClient.MutateCampaignLabels(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignLabelsAsync</summary>
        public async Task MutateCampaignLabelsRequestObjectAsync()
        {
            // Snippet: MutateCampaignLabelsAsync(MutateCampaignLabelsRequest, CallSettings)
            // Additional: MutateCampaignLabelsAsync(MutateCampaignLabelsRequest, CancellationToken)
            // Create client
            CampaignLabelServiceClient campaignLabelServiceClient = await CampaignLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCampaignLabelsRequest request = new MutateCampaignLabelsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateCampaignLabelsResponse response = await campaignLabelServiceClient.MutateCampaignLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignLabels</summary>
        public void MutateCampaignLabels()
        {
            // Snippet: MutateCampaignLabels(string, IEnumerable<CampaignLabelOperation>, CallSettings)
            // Create client
            CampaignLabelServiceClient campaignLabelServiceClient = CampaignLabelServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignLabelOperation> operations = new CampaignLabelOperation[]
            {
                new CampaignLabelOperation(),
            };
            // Make the request
            MutateCampaignLabelsResponse response = campaignLabelServiceClient.MutateCampaignLabels(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignLabelsAsync</summary>
        public async Task MutateCampaignLabelsAsync()
        {
            // Snippet: MutateCampaignLabelsAsync(string, IEnumerable<CampaignLabelOperation>, CallSettings)
            // Additional: MutateCampaignLabelsAsync(string, IEnumerable<CampaignLabelOperation>, CancellationToken)
            // Create client
            CampaignLabelServiceClient campaignLabelServiceClient = await CampaignLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignLabelOperation> operations = new CampaignLabelOperation[]
            {
                new CampaignLabelOperation(),
            };
            // Make the request
            MutateCampaignLabelsResponse response = await campaignLabelServiceClient.MutateCampaignLabelsAsync(customerId, operations);
            // End snippet
        }
    }
}
