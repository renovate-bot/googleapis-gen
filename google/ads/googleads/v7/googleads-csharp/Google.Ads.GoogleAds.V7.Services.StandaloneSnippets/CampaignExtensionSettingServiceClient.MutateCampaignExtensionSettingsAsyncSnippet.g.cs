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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCampaignExtensionSettingServiceClientStandaloneSnippets
    {
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
