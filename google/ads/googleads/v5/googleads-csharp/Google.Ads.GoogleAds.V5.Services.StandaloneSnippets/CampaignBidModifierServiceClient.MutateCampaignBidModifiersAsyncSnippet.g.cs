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

namespace Google.Ads.GoogleAds.V5.Services.Snippets
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCampaignBidModifierServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for MutateCampaignBidModifiersAsync</summary>
        public async Task MutateCampaignBidModifiersAsync()
        {
            // Snippet: MutateCampaignBidModifiersAsync(string, IEnumerable<CampaignBidModifierOperation>, CallSettings)
            // Additional: MutateCampaignBidModifiersAsync(string, IEnumerable<CampaignBidModifierOperation>, CancellationToken)
            // Create client
            CampaignBidModifierServiceClient campaignBidModifierServiceClient = await CampaignBidModifierServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignBidModifierOperation> operations = new CampaignBidModifierOperation[]
            {
                new CampaignBidModifierOperation(),
            };
            // Make the request
            MutateCampaignBidModifiersResponse response = await campaignBidModifierServiceClient.MutateCampaignBidModifiersAsync(customerId, operations);
            // End snippet
        }
    }
}
