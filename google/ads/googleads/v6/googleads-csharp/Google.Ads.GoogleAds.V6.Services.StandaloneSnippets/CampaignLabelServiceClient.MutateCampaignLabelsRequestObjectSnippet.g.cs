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

namespace Google.Ads.GoogleAds.V6.Services.Snippets
{
    public sealed partial class GeneratedCampaignLabelServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for MutateCampaignLabels</summary>
        public void MutateCampaignLabelsRequestObject()
        {
            // Snippet: MutateCampaignLabels(MutateCampaignLabelsRequest, CallSettings)
            // Create client
            CampaignLabelServiceClient campaignLabelServiceClient = CampaignLabelServiceClient.Create();
            // Initialize request argument(s)
            MutateCampaignLabelsRequest request = new MutateCampaignLabelsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateCampaignLabelsResponse response = campaignLabelServiceClient.MutateCampaignLabels(request);
            // End snippet
        }
    }
}
