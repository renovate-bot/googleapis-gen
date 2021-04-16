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

namespace Google.Analytics.Admin.V1Alpha.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedAnalyticsAdminServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetDataSharingSettingsAsync</summary>
        public async Task GetDataSharingSettingsAsync()
        {
            // Snippet: GetDataSharingSettingsAsync(string, CallSettings)
            // Additional: GetDataSharingSettingsAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/dataSharingSettings";
            // Make the request
            DataSharingSettings response = await analyticsAdminServiceClient.GetDataSharingSettingsAsync(name);
            // End snippet
        }
    }
}
