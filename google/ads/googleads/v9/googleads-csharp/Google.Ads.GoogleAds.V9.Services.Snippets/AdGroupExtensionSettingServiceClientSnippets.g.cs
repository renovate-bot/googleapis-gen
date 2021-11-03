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

namespace Google.Ads.GoogleAds.V9.Services.Snippets
{
    using Google.Ads.GoogleAds.V9.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAdGroupExtensionSettingServiceClientSnippets
    {
        /// <summary>Snippet for GetAdGroupExtensionSetting</summary>
        public void GetAdGroupExtensionSettingRequestObject()
        {
            // Snippet: GetAdGroupExtensionSetting(GetAdGroupExtensionSettingRequest, CallSettings)
            // Create client
            AdGroupExtensionSettingServiceClient adGroupExtensionSettingServiceClient = AdGroupExtensionSettingServiceClient.Create();
            // Initialize request argument(s)
            GetAdGroupExtensionSettingRequest request = new GetAdGroupExtensionSettingRequest
            {
                ResourceNameAsAdGroupExtensionSettingName = AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]"),
            };
            // Make the request
            AdGroupExtensionSetting response = adGroupExtensionSettingServiceClient.GetAdGroupExtensionSetting(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupExtensionSettingAsync</summary>
        public async Task GetAdGroupExtensionSettingRequestObjectAsync()
        {
            // Snippet: GetAdGroupExtensionSettingAsync(GetAdGroupExtensionSettingRequest, CallSettings)
            // Additional: GetAdGroupExtensionSettingAsync(GetAdGroupExtensionSettingRequest, CancellationToken)
            // Create client
            AdGroupExtensionSettingServiceClient adGroupExtensionSettingServiceClient = await AdGroupExtensionSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdGroupExtensionSettingRequest request = new GetAdGroupExtensionSettingRequest
            {
                ResourceNameAsAdGroupExtensionSettingName = AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]"),
            };
            // Make the request
            AdGroupExtensionSetting response = await adGroupExtensionSettingServiceClient.GetAdGroupExtensionSettingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupExtensionSetting</summary>
        public void GetAdGroupExtensionSetting()
        {
            // Snippet: GetAdGroupExtensionSetting(string, CallSettings)
            // Create client
            AdGroupExtensionSettingServiceClient adGroupExtensionSettingServiceClient = AdGroupExtensionSettingServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupExtensionSettings/[AD_GROUP_ID]~[EXTENSION_TYPE]";
            // Make the request
            AdGroupExtensionSetting response = adGroupExtensionSettingServiceClient.GetAdGroupExtensionSetting(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupExtensionSettingAsync</summary>
        public async Task GetAdGroupExtensionSettingAsync()
        {
            // Snippet: GetAdGroupExtensionSettingAsync(string, CallSettings)
            // Additional: GetAdGroupExtensionSettingAsync(string, CancellationToken)
            // Create client
            AdGroupExtensionSettingServiceClient adGroupExtensionSettingServiceClient = await AdGroupExtensionSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/adGroupExtensionSettings/[AD_GROUP_ID]~[EXTENSION_TYPE]";
            // Make the request
            AdGroupExtensionSetting response = await adGroupExtensionSettingServiceClient.GetAdGroupExtensionSettingAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupExtensionSetting</summary>
        public void GetAdGroupExtensionSettingResourceNames()
        {
            // Snippet: GetAdGroupExtensionSetting(AdGroupExtensionSettingName, CallSettings)
            // Create client
            AdGroupExtensionSettingServiceClient adGroupExtensionSettingServiceClient = AdGroupExtensionSettingServiceClient.Create();
            // Initialize request argument(s)
            AdGroupExtensionSettingName resourceName = AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]");
            // Make the request
            AdGroupExtensionSetting response = adGroupExtensionSettingServiceClient.GetAdGroupExtensionSetting(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAdGroupExtensionSettingAsync</summary>
        public async Task GetAdGroupExtensionSettingResourceNamesAsync()
        {
            // Snippet: GetAdGroupExtensionSettingAsync(AdGroupExtensionSettingName, CallSettings)
            // Additional: GetAdGroupExtensionSettingAsync(AdGroupExtensionSettingName, CancellationToken)
            // Create client
            AdGroupExtensionSettingServiceClient adGroupExtensionSettingServiceClient = await AdGroupExtensionSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdGroupExtensionSettingName resourceName = AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]");
            // Make the request
            AdGroupExtensionSetting response = await adGroupExtensionSettingServiceClient.GetAdGroupExtensionSettingAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupExtensionSettings</summary>
        public void MutateAdGroupExtensionSettingsRequestObject()
        {
            // Snippet: MutateAdGroupExtensionSettings(MutateAdGroupExtensionSettingsRequest, CallSettings)
            // Create client
            AdGroupExtensionSettingServiceClient adGroupExtensionSettingServiceClient = AdGroupExtensionSettingServiceClient.Create();
            // Initialize request argument(s)
            MutateAdGroupExtensionSettingsRequest request = new MutateAdGroupExtensionSettingsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupExtensionSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateAdGroupExtensionSettingsResponse response = adGroupExtensionSettingServiceClient.MutateAdGroupExtensionSettings(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupExtensionSettingsAsync</summary>
        public async Task MutateAdGroupExtensionSettingsRequestObjectAsync()
        {
            // Snippet: MutateAdGroupExtensionSettingsAsync(MutateAdGroupExtensionSettingsRequest, CallSettings)
            // Additional: MutateAdGroupExtensionSettingsAsync(MutateAdGroupExtensionSettingsRequest, CancellationToken)
            // Create client
            AdGroupExtensionSettingServiceClient adGroupExtensionSettingServiceClient = await AdGroupExtensionSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAdGroupExtensionSettingsRequest request = new MutateAdGroupExtensionSettingsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new AdGroupExtensionSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateAdGroupExtensionSettingsResponse response = await adGroupExtensionSettingServiceClient.MutateAdGroupExtensionSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupExtensionSettings</summary>
        public void MutateAdGroupExtensionSettings()
        {
            // Snippet: MutateAdGroupExtensionSettings(string, IEnumerable<AdGroupExtensionSettingOperation>, CallSettings)
            // Create client
            AdGroupExtensionSettingServiceClient adGroupExtensionSettingServiceClient = AdGroupExtensionSettingServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupExtensionSettingOperation> operations = new AdGroupExtensionSettingOperation[]
            {
                new AdGroupExtensionSettingOperation(),
            };
            // Make the request
            MutateAdGroupExtensionSettingsResponse response = adGroupExtensionSettingServiceClient.MutateAdGroupExtensionSettings(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateAdGroupExtensionSettingsAsync</summary>
        public async Task MutateAdGroupExtensionSettingsAsync()
        {
            // Snippet: MutateAdGroupExtensionSettingsAsync(string, IEnumerable<AdGroupExtensionSettingOperation>, CallSettings)
            // Additional: MutateAdGroupExtensionSettingsAsync(string, IEnumerable<AdGroupExtensionSettingOperation>, CancellationToken)
            // Create client
            AdGroupExtensionSettingServiceClient adGroupExtensionSettingServiceClient = await AdGroupExtensionSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<AdGroupExtensionSettingOperation> operations = new AdGroupExtensionSettingOperation[]
            {
                new AdGroupExtensionSettingOperation(),
            };
            // Make the request
            MutateAdGroupExtensionSettingsResponse response = await adGroupExtensionSettingServiceClient.MutateAdGroupExtensionSettingsAsync(customerId, operations);
            // End snippet
        }
    }
}
