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
    using Google.Ads.GoogleAds.V5.Enums;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCampaignDraftServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for MutateCampaignDraftsAsync</summary>
        public async Task MutateCampaignDraftsRequestObjectAsync()
        {
            // Snippet: MutateCampaignDraftsAsync(MutateCampaignDraftsRequest, CallSettings)
            // Additional: MutateCampaignDraftsAsync(MutateCampaignDraftsRequest, CancellationToken)
            // Create client
            CampaignDraftServiceClient campaignDraftServiceClient = await CampaignDraftServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCampaignDraftsRequest request = new MutateCampaignDraftsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignDraftOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignDraftsResponse response = await campaignDraftServiceClient.MutateCampaignDraftsAsync(request);
            // End snippet
        }
    }
}
