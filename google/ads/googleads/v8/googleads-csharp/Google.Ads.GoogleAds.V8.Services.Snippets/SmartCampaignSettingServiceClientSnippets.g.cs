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
    public sealed class GeneratedSmartCampaignSettingServiceClientSnippets
    {
        /// <summary>Snippet for GetSmartCampaignSetting</summary>
        public void GetSmartCampaignSettingRequestObject()
        {
            // Snippet: GetSmartCampaignSetting(GetSmartCampaignSettingRequest, CallSettings)
            // Create client
            SmartCampaignSettingServiceClient smartCampaignSettingServiceClient = SmartCampaignSettingServiceClient.Create();
            // Initialize request argument(s)
            GetSmartCampaignSettingRequest request = new GetSmartCampaignSettingRequest
            {
                ResourceNameAsSmartCampaignSettingName = SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            // Make the request
            SmartCampaignSetting response = smartCampaignSettingServiceClient.GetSmartCampaignSetting(request);
            // End snippet
        }

        /// <summary>Snippet for GetSmartCampaignSettingAsync</summary>
        public async Task GetSmartCampaignSettingRequestObjectAsync()
        {
            // Snippet: GetSmartCampaignSettingAsync(GetSmartCampaignSettingRequest, CallSettings)
            // Additional: GetSmartCampaignSettingAsync(GetSmartCampaignSettingRequest, CancellationToken)
            // Create client
            SmartCampaignSettingServiceClient smartCampaignSettingServiceClient = await SmartCampaignSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSmartCampaignSettingRequest request = new GetSmartCampaignSettingRequest
            {
                ResourceNameAsSmartCampaignSettingName = SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            // Make the request
            SmartCampaignSetting response = await smartCampaignSettingServiceClient.GetSmartCampaignSettingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSmartCampaignSetting</summary>
        public void GetSmartCampaignSetting()
        {
            // Snippet: GetSmartCampaignSetting(string, CallSettings)
            // Create client
            SmartCampaignSettingServiceClient smartCampaignSettingServiceClient = SmartCampaignSettingServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/smartCampaignSettings/[CAMPAIGN_ID]";
            // Make the request
            SmartCampaignSetting response = smartCampaignSettingServiceClient.GetSmartCampaignSetting(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetSmartCampaignSettingAsync</summary>
        public async Task GetSmartCampaignSettingAsync()
        {
            // Snippet: GetSmartCampaignSettingAsync(string, CallSettings)
            // Additional: GetSmartCampaignSettingAsync(string, CancellationToken)
            // Create client
            SmartCampaignSettingServiceClient smartCampaignSettingServiceClient = await SmartCampaignSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/smartCampaignSettings/[CAMPAIGN_ID]";
            // Make the request
            SmartCampaignSetting response = await smartCampaignSettingServiceClient.GetSmartCampaignSettingAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetSmartCampaignSetting</summary>
        public void GetSmartCampaignSettingResourceNames()
        {
            // Snippet: GetSmartCampaignSetting(SmartCampaignSettingName, CallSettings)
            // Create client
            SmartCampaignSettingServiceClient smartCampaignSettingServiceClient = SmartCampaignSettingServiceClient.Create();
            // Initialize request argument(s)
            SmartCampaignSettingName resourceName = SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]");
            // Make the request
            SmartCampaignSetting response = smartCampaignSettingServiceClient.GetSmartCampaignSetting(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetSmartCampaignSettingAsync</summary>
        public async Task GetSmartCampaignSettingResourceNamesAsync()
        {
            // Snippet: GetSmartCampaignSettingAsync(SmartCampaignSettingName, CallSettings)
            // Additional: GetSmartCampaignSettingAsync(SmartCampaignSettingName, CancellationToken)
            // Create client
            SmartCampaignSettingServiceClient smartCampaignSettingServiceClient = await SmartCampaignSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            SmartCampaignSettingName resourceName = SmartCampaignSettingName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]");
            // Make the request
            SmartCampaignSetting response = await smartCampaignSettingServiceClient.GetSmartCampaignSettingAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateSmartCampaignSettings</summary>
        public void MutateSmartCampaignSettingsRequestObject()
        {
            // Snippet: MutateSmartCampaignSettings(MutateSmartCampaignSettingsRequest, CallSettings)
            // Create client
            SmartCampaignSettingServiceClient smartCampaignSettingServiceClient = SmartCampaignSettingServiceClient.Create();
            // Initialize request argument(s)
            MutateSmartCampaignSettingsRequest request = new MutateSmartCampaignSettingsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new SmartCampaignSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateSmartCampaignSettingsResponse response = smartCampaignSettingServiceClient.MutateSmartCampaignSettings(request);
            // End snippet
        }

        /// <summary>Snippet for MutateSmartCampaignSettingsAsync</summary>
        public async Task MutateSmartCampaignSettingsRequestObjectAsync()
        {
            // Snippet: MutateSmartCampaignSettingsAsync(MutateSmartCampaignSettingsRequest, CallSettings)
            // Additional: MutateSmartCampaignSettingsAsync(MutateSmartCampaignSettingsRequest, CancellationToken)
            // Create client
            SmartCampaignSettingServiceClient smartCampaignSettingServiceClient = await SmartCampaignSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateSmartCampaignSettingsRequest request = new MutateSmartCampaignSettingsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new SmartCampaignSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateSmartCampaignSettingsResponse response = await smartCampaignSettingServiceClient.MutateSmartCampaignSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateSmartCampaignSettings</summary>
        public void MutateSmartCampaignSettings()
        {
            // Snippet: MutateSmartCampaignSettings(string, IEnumerable<SmartCampaignSettingOperation>, CallSettings)
            // Create client
            SmartCampaignSettingServiceClient smartCampaignSettingServiceClient = SmartCampaignSettingServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<SmartCampaignSettingOperation> operations = new SmartCampaignSettingOperation[]
            {
                new SmartCampaignSettingOperation(),
            };
            // Make the request
            MutateSmartCampaignSettingsResponse response = smartCampaignSettingServiceClient.MutateSmartCampaignSettings(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateSmartCampaignSettingsAsync</summary>
        public async Task MutateSmartCampaignSettingsAsync()
        {
            // Snippet: MutateSmartCampaignSettingsAsync(string, IEnumerable<SmartCampaignSettingOperation>, CallSettings)
            // Additional: MutateSmartCampaignSettingsAsync(string, IEnumerable<SmartCampaignSettingOperation>, CancellationToken)
            // Create client
            SmartCampaignSettingServiceClient smartCampaignSettingServiceClient = await SmartCampaignSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<SmartCampaignSettingOperation> operations = new SmartCampaignSettingOperation[]
            {
                new SmartCampaignSettingOperation(),
            };
            // Make the request
            MutateSmartCampaignSettingsResponse response = await smartCampaignSettingServiceClient.MutateSmartCampaignSettingsAsync(customerId, operations);
            // End snippet
        }
    }
}
