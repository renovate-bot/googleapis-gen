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

namespace Google.Cloud.SecurityCenter.Settings.V1Beta1.Snippets
{
    using System.Threading.Tasks;

    public sealed partial class GeneratedSecurityCenterSettingsServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for ResetComponentSettingsAsync</summary>
        public async Task ResetComponentSettingsRequestObjectAsync()
        {
            // Snippet: ResetComponentSettingsAsync(ResetComponentSettingsRequest, CallSettings)
            // Additional: ResetComponentSettingsAsync(ResetComponentSettingsRequest, CancellationToken)
            // Create client
            SecurityCenterSettingsServiceClient securityCenterSettingsServiceClient = await SecurityCenterSettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResetComponentSettingsRequest request = new ResetComponentSettingsRequest
            {
                ComponentSettingsName = ComponentSettingsName.FromOrganizationComponent("[ORGANIZATION]", "[COMPONENT]"),
                Etag = "",
            };
            // Make the request
            await securityCenterSettingsServiceClient.ResetComponentSettingsAsync(request);
            // End snippet
        }
    }
}
