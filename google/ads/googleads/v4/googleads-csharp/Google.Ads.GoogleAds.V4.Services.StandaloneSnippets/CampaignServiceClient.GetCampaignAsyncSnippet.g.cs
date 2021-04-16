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

namespace Google.Ads.GoogleAds.V4.Services.Snippets
{
    using Google.Ads.GoogleAds.V4.Resources;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCampaignServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetCampaignAsync</summary>
        public async Task GetCampaignAsync()
        {
            // Snippet: GetCampaignAsync(string, CallSettings)
            // Additional: GetCampaignAsync(string, CancellationToken)
            // Create client
            CampaignServiceClient campaignServiceClient = await CampaignServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/campaigns/[CAMPAIGN]";
            // Make the request
            Campaign response = await campaignServiceClient.GetCampaignAsync(resourceName);
            // End snippet
        }
    }
}
