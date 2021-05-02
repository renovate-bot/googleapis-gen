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

    public sealed partial class GeneratedOfflineUserDataJobServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for AddOfflineUserDataJobOperations</summary>
        public void AddOfflineUserDataJobOperationsRequestObject()
        {
            // Snippet: AddOfflineUserDataJobOperations(AddOfflineUserDataJobOperationsRequest, CallSettings)
            // Create client
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient = OfflineUserDataJobServiceClient.Create();
            // Initialize request argument(s)
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Operations =
                {
                    new OfflineUserDataJobOperation(),
                },
                EnablePartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            AddOfflineUserDataJobOperationsResponse response = offlineUserDataJobServiceClient.AddOfflineUserDataJobOperations(request);
            // End snippet
        }
    }
}
