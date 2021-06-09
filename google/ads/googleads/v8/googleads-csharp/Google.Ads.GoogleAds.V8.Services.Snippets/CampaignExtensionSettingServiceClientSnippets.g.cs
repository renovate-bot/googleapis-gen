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
    using Google.Ads.GoogleAds.V8.Enums;
    using Google.Ads.GoogleAds.V8.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCampaignExtensionSettingServiceClientSnippets
    {
        /// <summary>Snippet for GetCampaignExtensionSetting</summary>
        public void GetCampaignExtensionSettingRequestObject()
        {
            // Snippet: GetCampaignExtensionSetting(GetCampaignExtensionSettingRequest, CallSettings)
            // Create client
            CampaignExtensionSettingServiceClient campaignExtensionSettingServiceClient = CampaignExtensionSettingServiceClient.Create();
            // Initialize request argument(s)
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]"),
            };
            // Make the request
            CampaignExtensionSetting response = campaignExtensionSettingServiceClient.GetCampaignExtensionSetting(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignExtensionSettingAsync</summary>
        public async Task GetCampaignExtensionSettingRequestObjectAsync()
        {
            // Snippet: GetCampaignExtensionSettingAsync(GetCampaignExtensionSettingRequest, CallSettings)
            // Additional: GetCampaignExtensionSettingAsync(GetCampaignExtensionSettingRequest, CancellationToken)
            // Create client
            CampaignExtensionSettingServiceClient campaignExtensionSettingServiceClient = await CampaignExtensionSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]"),
            };
            // Make the request
            CampaignExtensionSetting response = await campaignExtensionSettingServiceClient.GetCampaignExtensionSettingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignExtensionSetting</summary>
        public void GetCampaignExtensionSetting()
        {
            // Snippet: GetCampaignExtensionSetting(string, CallSettings)
            // Create client
            CampaignExtensionSettingServiceClient campaignExtensionSettingServiceClient = CampaignExtensionSettingServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaignExtensionSettings/[CAMPAIGN_ID]~[EXTENSION_TYPE]";
            // Make the request
            CampaignExtensionSetting response = campaignExtensionSettingServiceClient.GetCampaignExtensionSetting(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignExtensionSettingAsync</summary>
        public async Task GetCampaignExtensionSettingAsync()
        {
            // Snippet: GetCampaignExtensionSettingAsync(string, CallSettings)
            // Additional: GetCampaignExtensionSettingAsync(string, CancellationToken)
            // Create client
            CampaignExtensionSettingServiceClient campaignExtensionSettingServiceClient = await CampaignExtensionSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/campaignExtensionSettings/[CAMPAIGN_ID]~[EXTENSION_TYPE]";
            // Make the request
            CampaignExtensionSetting response = await campaignExtensionSettingServiceClient.GetCampaignExtensionSettingAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignExtensionSetting</summary>
        public void GetCampaignExtensionSettingResourceNames()
        {
            // Snippet: GetCampaignExtensionSetting(CampaignExtensionSettingName, CallSettings)
            // Create client
            CampaignExtensionSettingServiceClient campaignExtensionSettingServiceClient = CampaignExtensionSettingServiceClient.Create();
            // Initialize request argument(s)
            CampaignExtensionSettingName resourceName = CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]");
            // Make the request
            CampaignExtensionSetting response = campaignExtensionSettingServiceClient.GetCampaignExtensionSetting(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignExtensionSettingAsync</summary>
        public async Task GetCampaignExtensionSettingResourceNamesAsync()
        {
            // Snippet: GetCampaignExtensionSettingAsync(CampaignExtensionSettingName, CallSettings)
            // Additional: GetCampaignExtensionSettingAsync(CampaignExtensionSettingName, CancellationToken)
            // Create client
            CampaignExtensionSettingServiceClient campaignExtensionSettingServiceClient = await CampaignExtensionSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            CampaignExtensionSettingName resourceName = CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]");
            // Make the request
            CampaignExtensionSetting response = await campaignExtensionSettingServiceClient.GetCampaignExtensionSettingAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignExtensionSettings</summary>
        public void MutateCampaignExtensionSettingsRequestObject()
        {
            // Snippet: MutateCampaignExtensionSettings(MutateCampaignExtensionSettingsRequest, CallSettings)
            // Create client
            CampaignExtensionSettingServiceClient campaignExtensionSettingServiceClient = CampaignExtensionSettingServiceClient.Create();
            // Initialize request argument(s)
            MutateCampaignExtensionSettingsRequest request = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignExtensionSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignExtensionSettingsResponse response = campaignExtensionSettingServiceClient.MutateCampaignExtensionSettings(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignExtensionSettingsAsync</summary>
        public async Task MutateCampaignExtensionSettingsRequestObjectAsync()
        {
            // Snippet: MutateCampaignExtensionSettingsAsync(MutateCampaignExtensionSettingsRequest, CallSettings)
            // Additional: MutateCampaignExtensionSettingsAsync(MutateCampaignExtensionSettingsRequest, CancellationToken)
            // Create client
            CampaignExtensionSettingServiceClient campaignExtensionSettingServiceClient = await CampaignExtensionSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCampaignExtensionSettingsRequest request = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignExtensionSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignExtensionSettingsResponse response = await campaignExtensionSettingServiceClient.MutateCampaignExtensionSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignExtensionSettings</summary>
        public void MutateCampaignExtensionSettings()
        {
            // Snippet: MutateCampaignExtensionSettings(string, IEnumerable<CampaignExtensionSettingOperation>, CallSettings)
            // Create client
            CampaignExtensionSettingServiceClient campaignExtensionSettingServiceClient = CampaignExtensionSettingServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignExtensionSettingOperation> operations = new CampaignExtensionSettingOperation[]
            {
                new CampaignExtensionSettingOperation(),
            };
            // Make the request
            MutateCampaignExtensionSettingsResponse response = campaignExtensionSettingServiceClient.MutateCampaignExtensionSettings(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignExtensionSettingsAsync</summary>
        public async Task MutateCampaignExtensionSettingsAsync()
        {
            // Snippet: MutateCampaignExtensionSettingsAsync(string, IEnumerable<CampaignExtensionSettingOperation>, CallSettings)
            // Additional: MutateCampaignExtensionSettingsAsync(string, IEnumerable<CampaignExtensionSettingOperation>, CancellationToken)
            // Create client
            CampaignExtensionSettingServiceClient campaignExtensionSettingServiceClient = await CampaignExtensionSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignExtensionSettingOperation> operations = new CampaignExtensionSettingOperation[]
            {
                new CampaignExtensionSettingOperation(),
            };
            // Make the request
            MutateCampaignExtensionSettingsResponse response = await campaignExtensionSettingServiceClient.MutateCampaignExtensionSettingsAsync(customerId, operations);
            // End snippet
        }
    }
}
