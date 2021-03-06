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

namespace Ccc.Hosted.Marketplace.V2.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedLicenseNotificationServiceClientSnippets
    {
        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(LicenseNotificationListRequest, CallSettings)
            // Create client
            LicenseNotificationServiceClient licenseNotificationServiceClient = LicenseNotificationServiceClient.Create();
            // Initialize request argument(s)
            LicenseNotificationListRequest request = new LicenseNotificationListRequest
            {
                ApplicationId = "",
                MaxResults = 0U,
                StartToken = "",
                Timestamp = 0UL,
            };
            // Make the request
            LicenseNotificationList response = licenseNotificationServiceClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(LicenseNotificationListRequest, CallSettings)
            // Additional: ListAsync(LicenseNotificationListRequest, CancellationToken)
            // Create client
            LicenseNotificationServiceClient licenseNotificationServiceClient = await LicenseNotificationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LicenseNotificationListRequest request = new LicenseNotificationListRequest
            {
                ApplicationId = "",
                MaxResults = 0U,
                StartToken = "",
                Timestamp = 0UL,
            };
            // Make the request
            LicenseNotificationList response = await licenseNotificationServiceClient.ListAsync(request);
            // End snippet
        }
    }
}
