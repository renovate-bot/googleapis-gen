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

namespace Google.Cloud.Dialogflow.Cx.V3.Snippets
{
    using Google.Api.Gax.ResourceNames;

    public sealed partial class GeneratedSecuritySettingsServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for CreateSecuritySettings</summary>
        public void CreateSecuritySettingsRequestObject()
        {
            // Snippet: CreateSecuritySettings(CreateSecuritySettingsRequest, CallSettings)
            // Create client
            SecuritySettingsServiceClient securitySettingsServiceClient = SecuritySettingsServiceClient.Create();
            // Initialize request argument(s)
            CreateSecuritySettingsRequest request = new CreateSecuritySettingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SecuritySettings = new SecuritySettings(),
            };
            // Make the request
            SecuritySettings response = securitySettingsServiceClient.CreateSecuritySettings(request);
            // End snippet
        }
    }
}
