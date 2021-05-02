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
    using Google.Ads.GoogleAds.V7.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCampaignAssetServiceClientSnippets
    {
        /// <summary>Snippet for GetCampaignAsset</summary>
        public void GetCampaignAssetRequestObject()
        {
            // Snippet: GetCampaignAsset(GetCampaignAssetRequest, CallSettings)
            // Create client
            CampaignAssetServiceClient campaignAssetServiceClient = CampaignAssetServiceClient.Create();
            // Initialize request argument(s)
            GetCampaignAssetRequest request = new GetCampaignAssetRequest
            {
                ResourceNameAsCampaignAssetName = CampaignAssetName.FromCustomerCampaignAssetFieldType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            // Make the request
            CampaignAsset response = campaignAssetServiceClient.GetCampaignAsset(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignAssetAsync</summary>
        public async Task GetCampaignAssetRequestObjectAsync()
        {
            // Snippet: GetCampaignAssetAsync(GetCampaignAssetRequest, CallSettings)
            // Additional: GetCampaignAssetAsync(GetCampaignAssetRequest, CancellationToken)
            // Create client
            CampaignAssetServiceClient campaignAssetServiceClient = await CampaignAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCampaignAssetRequest request = new GetCampaignAssetRequest
            {
                ResourceNameAsCampaignAssetName = CampaignAssetName.FromCustomerCampaignAssetFieldType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[ASSET_ID]", "[FIELD_TYPE]"),
            };
            // Make the request
            CampaignAsset response = await campaignAssetServiceClient.GetCampaignAssetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignAsset</summary>
        public void GetCampaignAsset()
        {
            // Snippet: GetCampaignAsset(string, CallSettings)
            // Create client
            CampaignAssetServiceClient campaignAssetServiceClient = CampaignAssetServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaignAssets/[CAMPAIGN_ID]~[ASSET_ID]~[FIELD_TYPE]";
            // Make the request
            CampaignAsset response = campaignAssetServiceClient.GetCampaignAsset(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignAssetAsync</summary>
        public async Task GetCampaignAssetAsync()
        {
            // Snippet: GetCampaignAssetAsync(string, CallSettings)
            // Additional: GetCampaignAssetAsync(string, CancellationToken)
            // Create client
            CampaignAssetServiceClient campaignAssetServiceClient = await CampaignAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaignAssets/[CAMPAIGN_ID]~[ASSET_ID]~[FIELD_TYPE]";
            // Make the request
            CampaignAsset response = await campaignAssetServiceClient.GetCampaignAssetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignAsset</summary>
        public void GetCampaignAssetResourceNames()
        {
            // Snippet: GetCampaignAsset(CampaignAssetName, CallSettings)
            // Create client
            CampaignAssetServiceClient campaignAssetServiceClient = CampaignAssetServiceClient.Create();
            // Initialize request argument(s)
            CampaignAssetName resourceName = CampaignAssetName.FromCustomerCampaignAssetFieldType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[ASSET_ID]", "[FIELD_TYPE]");
            // Make the request
            CampaignAsset response = campaignAssetServiceClient.GetCampaignAsset(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignAssetAsync</summary>
        public async Task GetCampaignAssetResourceNamesAsync()
        {
            // Snippet: GetCampaignAssetAsync(CampaignAssetName, CallSettings)
            // Additional: GetCampaignAssetAsync(CampaignAssetName, CancellationToken)
            // Create client
            CampaignAssetServiceClient campaignAssetServiceClient = await CampaignAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CampaignAssetName resourceName = CampaignAssetName.FromCustomerCampaignAssetFieldType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[ASSET_ID]", "[FIELD_TYPE]");
            // Make the request
            CampaignAsset response = await campaignAssetServiceClient.GetCampaignAssetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignAssets</summary>
        public void MutateCampaignAssetsRequestObject()
        {
            // Snippet: MutateCampaignAssets(MutateCampaignAssetsRequest, CallSettings)
            // Create client
            CampaignAssetServiceClient campaignAssetServiceClient = CampaignAssetServiceClient.Create();
            // Initialize request argument(s)
            MutateCampaignAssetsRequest request = new MutateCampaignAssetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateCampaignAssetsResponse response = campaignAssetServiceClient.MutateCampaignAssets(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignAssetsAsync</summary>
        public async Task MutateCampaignAssetsRequestObjectAsync()
        {
            // Snippet: MutateCampaignAssetsAsync(MutateCampaignAssetsRequest, CallSettings)
            // Additional: MutateCampaignAssetsAsync(MutateCampaignAssetsRequest, CancellationToken)
            // Create client
            CampaignAssetServiceClient campaignAssetServiceClient = await CampaignAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCampaignAssetsRequest request = new MutateCampaignAssetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignAssetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateCampaignAssetsResponse response = await campaignAssetServiceClient.MutateCampaignAssetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignAssets</summary>
        public void MutateCampaignAssets()
        {
            // Snippet: MutateCampaignAssets(string, IEnumerable<CampaignAssetOperation>, CallSettings)
            // Create client
            CampaignAssetServiceClient campaignAssetServiceClient = CampaignAssetServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignAssetOperation> operations = new CampaignAssetOperation[]
            {
                new CampaignAssetOperation(),
            };
            // Make the request
            MutateCampaignAssetsResponse response = campaignAssetServiceClient.MutateCampaignAssets(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignAssetsAsync</summary>
        public async Task MutateCampaignAssetsAsync()
        {
            // Snippet: MutateCampaignAssetsAsync(string, IEnumerable<CampaignAssetOperation>, CallSettings)
            // Additional: MutateCampaignAssetsAsync(string, IEnumerable<CampaignAssetOperation>, CancellationToken)
            // Create client
            CampaignAssetServiceClient campaignAssetServiceClient = await CampaignAssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignAssetOperation> operations = new CampaignAssetOperation[]
            {
                new CampaignAssetOperation(),
            };
            // Make the request
            MutateCampaignAssetsResponse response = await campaignAssetServiceClient.MutateCampaignAssetsAsync(customerId, operations);
            // End snippet
        }
    }
}
