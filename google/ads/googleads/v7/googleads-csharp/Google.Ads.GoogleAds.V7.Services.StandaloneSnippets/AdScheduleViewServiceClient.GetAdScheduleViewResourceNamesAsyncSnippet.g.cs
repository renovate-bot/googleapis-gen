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
    using System.Threading.Tasks;

    public sealed partial class GeneratedAdScheduleViewServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetAdScheduleViewAsync</summary>
        public async Task GetAdScheduleViewResourceNamesAsync()
        {
            // Snippet: GetAdScheduleViewAsync(AdScheduleViewName, CallSettings)
            // Additional: GetAdScheduleViewAsync(AdScheduleViewName, CancellationToken)
            // Create client
            AdScheduleViewServiceClient adScheduleViewServiceClient = await AdScheduleViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdScheduleViewName resourceName = AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]");
            // Make the request
            AdScheduleView response = await adScheduleViewServiceClient.GetAdScheduleViewAsync(resourceName);
            // End snippet
        }
    }
}
