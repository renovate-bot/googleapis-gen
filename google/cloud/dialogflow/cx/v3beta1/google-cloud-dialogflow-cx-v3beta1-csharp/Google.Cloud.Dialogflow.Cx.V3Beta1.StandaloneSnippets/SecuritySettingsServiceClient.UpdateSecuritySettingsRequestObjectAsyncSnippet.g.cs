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

namespace Google.Cloud.Dialogflow.Cx.V3Beta1.Snippets
{
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSecuritySettingsServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for UpdateSecuritySettingsAsync</summary>
        public async Task UpdateSecuritySettingsRequestObjectAsync()
        {
            // Snippet: UpdateSecuritySettingsAsync(UpdateSecuritySettingsRequest, CallSettings)
            // Additional: UpdateSecuritySettingsAsync(UpdateSecuritySettingsRequest, CancellationToken)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = await SecuritySettingsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSecuritySettingsRequest request = new UpdateSecuritySettingsRequest
            {
                SecuritySettings = new SecuritySettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SecuritySettings response = await securitySettingsServiceClient.UpdateSecuritySettingsAsync(request);
            // End snippet
        }
    }
}
