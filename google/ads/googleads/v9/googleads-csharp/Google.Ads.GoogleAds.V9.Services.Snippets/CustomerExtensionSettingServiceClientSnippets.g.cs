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
    using Google.Ads.GoogleAds.V9.Enums;
    using Google.Ads.GoogleAds.V9.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCustomerExtensionSettingServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomerExtensionSetting</summary>
        public void GetCustomerExtensionSettingRequestObject()
        {
            // Snippet: GetCustomerExtensionSetting(GetCustomerExtensionSettingRequest, CallSettings)
            // Create client
            CustomerExtensionSettingServiceClient customerExtensionSettingServiceClient = CustomerExtensionSettingServiceClient.Create();
            // Initialize request argument(s)
            GetCustomerExtensionSettingRequest request = new GetCustomerExtensionSettingRequest
            {
                ResourceNameAsCustomerExtensionSettingName = CustomerExtensionSettingName.FromCustomerExtensionType("[CUSTOMER_ID]", "[EXTENSION_TYPE]"),
            };
            // Make the request
            CustomerExtensionSetting response = customerExtensionSettingServiceClient.GetCustomerExtensionSetting(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerExtensionSettingAsync</summary>
        public async Task GetCustomerExtensionSettingRequestObjectAsync()
        {
            // Snippet: GetCustomerExtensionSettingAsync(GetCustomerExtensionSettingRequest, CallSettings)
            // Additional: GetCustomerExtensionSettingAsync(GetCustomerExtensionSettingRequest, CancellationToken)
            // Create client
            CustomerExtensionSettingServiceClient customerExtensionSettingServiceClient = await CustomerExtensionSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomerExtensionSettingRequest request = new GetCustomerExtensionSettingRequest
            {
                ResourceNameAsCustomerExtensionSettingName = CustomerExtensionSettingName.FromCustomerExtensionType("[CUSTOMER_ID]", "[EXTENSION_TYPE]"),
            };
            // Make the request
            CustomerExtensionSetting response = await customerExtensionSettingServiceClient.GetCustomerExtensionSettingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerExtensionSetting</summary>
        public void GetCustomerExtensionSetting()
        {
            // Snippet: GetCustomerExtensionSetting(string, CallSettings)
            // Create client
            CustomerExtensionSettingServiceClient customerExtensionSettingServiceClient = CustomerExtensionSettingServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerExtensionSettings/[EXTENSION_TYPE]";
            // Make the request
            CustomerExtensionSetting response = customerExtensionSettingServiceClient.GetCustomerExtensionSetting(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerExtensionSettingAsync</summary>
        public async Task GetCustomerExtensionSettingAsync()
        {
            // Snippet: GetCustomerExtensionSettingAsync(string, CallSettings)
            // Additional: GetCustomerExtensionSettingAsync(string, CancellationToken)
            // Create client
            CustomerExtensionSettingServiceClient customerExtensionSettingServiceClient = await CustomerExtensionSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/customerExtensionSettings/[EXTENSION_TYPE]";
            // Make the request
            CustomerExtensionSetting response = await customerExtensionSettingServiceClient.GetCustomerExtensionSettingAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerExtensionSetting</summary>
        public void GetCustomerExtensionSettingResourceNames()
        {
            // Snippet: GetCustomerExtensionSetting(CustomerExtensionSettingName, CallSettings)
            // Create client
            CustomerExtensionSettingServiceClient customerExtensionSettingServiceClient = CustomerExtensionSettingServiceClient.Create();
            // Initialize request argument(s)
            CustomerExtensionSettingName resourceName = CustomerExtensionSettingName.FromCustomerExtensionType("[CUSTOMER_ID]", "[EXTENSION_TYPE]");
            // Make the request
            CustomerExtensionSetting response = customerExtensionSettingServiceClient.GetCustomerExtensionSetting(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerExtensionSettingAsync</summary>
        public async Task GetCustomerExtensionSettingResourceNamesAsync()
        {
            // Snippet: GetCustomerExtensionSettingAsync(CustomerExtensionSettingName, CallSettings)
            // Additional: GetCustomerExtensionSettingAsync(CustomerExtensionSettingName, CancellationToken)
            // Create client
            CustomerExtensionSettingServiceClient customerExtensionSettingServiceClient = await CustomerExtensionSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomerExtensionSettingName resourceName = CustomerExtensionSettingName.FromCustomerExtensionType("[CUSTOMER_ID]", "[EXTENSION_TYPE]");
            // Make the request
            CustomerExtensionSetting response = await customerExtensionSettingServiceClient.GetCustomerExtensionSettingAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerExtensionSettings</summary>
        public void MutateCustomerExtensionSettingsRequestObject()
        {
            // Snippet: MutateCustomerExtensionSettings(MutateCustomerExtensionSettingsRequest, CallSettings)
            // Create client
            CustomerExtensionSettingServiceClient customerExtensionSettingServiceClient = CustomerExtensionSettingServiceClient.Create();
            // Initialize request argument(s)
            MutateCustomerExtensionSettingsRequest request = new MutateCustomerExtensionSettingsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerExtensionSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomerExtensionSettingsResponse response = customerExtensionSettingServiceClient.MutateCustomerExtensionSettings(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerExtensionSettingsAsync</summary>
        public async Task MutateCustomerExtensionSettingsRequestObjectAsync()
        {
            // Snippet: MutateCustomerExtensionSettingsAsync(MutateCustomerExtensionSettingsRequest, CallSettings)
            // Additional: MutateCustomerExtensionSettingsAsync(MutateCustomerExtensionSettingsRequest, CancellationToken)
            // Create client
            CustomerExtensionSettingServiceClient customerExtensionSettingServiceClient = await CustomerExtensionSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCustomerExtensionSettingsRequest request = new MutateCustomerExtensionSettingsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CustomerExtensionSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCustomerExtensionSettingsResponse response = await customerExtensionSettingServiceClient.MutateCustomerExtensionSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerExtensionSettings</summary>
        public void MutateCustomerExtensionSettings()
        {
            // Snippet: MutateCustomerExtensionSettings(string, IEnumerable<CustomerExtensionSettingOperation>, CallSettings)
            // Create client
            CustomerExtensionSettingServiceClient customerExtensionSettingServiceClient = CustomerExtensionSettingServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerExtensionSettingOperation> operations = new CustomerExtensionSettingOperation[]
            {
                new CustomerExtensionSettingOperation(),
            };
            // Make the request
            MutateCustomerExtensionSettingsResponse response = customerExtensionSettingServiceClient.MutateCustomerExtensionSettings(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCustomerExtensionSettingsAsync</summary>
        public async Task MutateCustomerExtensionSettingsAsync()
        {
            // Snippet: MutateCustomerExtensionSettingsAsync(string, IEnumerable<CustomerExtensionSettingOperation>, CallSettings)
            // Additional: MutateCustomerExtensionSettingsAsync(string, IEnumerable<CustomerExtensionSettingOperation>, CancellationToken)
            // Create client
            CustomerExtensionSettingServiceClient customerExtensionSettingServiceClient = await CustomerExtensionSettingServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CustomerExtensionSettingOperation> operations = new CustomerExtensionSettingOperation[]
            {
                new CustomerExtensionSettingOperation(),
            };
            // Make the request
            MutateCustomerExtensionSettingsResponse response = await customerExtensionSettingServiceClient.MutateCustomerExtensionSettingsAsync(customerId, operations);
            // End snippet
        }
    }
}
