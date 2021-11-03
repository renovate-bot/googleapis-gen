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

namespace Google.Ads.GoogleAds.V9.Services.Snippets
{
    using Google.Ads.GoogleAds.V9.Enums;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCampaignAssetSetServiceClientSnippets
    {
        /// <summary>Snippet for MutateCampaignAssetSets</summary>
        public void MutateCampaignAssetSetsRequestObject()
        {
            // Snippet: MutateCampaignAssetSets(MutateCampaignAssetSetsRequest, CallSettings)
            // Create client
            CampaignAssetSetServiceClient campaignAssetSetServiceClient = CampaignAssetSetServiceClient.Create();
            // Initialize request argument(s)
            MutateCampaignAssetSetsRequest request = new MutateCampaignAssetSetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignAssetSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignAssetSetsResponse response = campaignAssetSetServiceClient.MutateCampaignAssetSets(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignAssetSetsAsync</summary>
        public async Task MutateCampaignAssetSetsRequestObjectAsync()
        {
            // Snippet: MutateCampaignAssetSetsAsync(MutateCampaignAssetSetsRequest, CallSettings)
            // Additional: MutateCampaignAssetSetsAsync(MutateCampaignAssetSetsRequest, CancellationToken)
            // Create client
            CampaignAssetSetServiceClient campaignAssetSetServiceClient = await CampaignAssetSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCampaignAssetSetsRequest request = new MutateCampaignAssetSetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignAssetSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignAssetSetsResponse response = await campaignAssetSetServiceClient.MutateCampaignAssetSetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignAssetSets</summary>
        public void MutateCampaignAssetSets()
        {
            // Snippet: MutateCampaignAssetSets(string, IEnumerable<CampaignAssetSetOperation>, CallSettings)
            // Create client
            CampaignAssetSetServiceClient campaignAssetSetServiceClient = CampaignAssetSetServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignAssetSetOperation> operations = new CampaignAssetSetOperation[]
            {
                new CampaignAssetSetOperation(),
            };
            // Make the request
            MutateCampaignAssetSetsResponse response = campaignAssetSetServiceClient.MutateCampaignAssetSets(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignAssetSetsAsync</summary>
        public async Task MutateCampaignAssetSetsAsync()
        {
            // Snippet: MutateCampaignAssetSetsAsync(string, IEnumerable<CampaignAssetSetOperation>, CallSettings)
            // Additional: MutateCampaignAssetSetsAsync(string, IEnumerable<CampaignAssetSetOperation>, CancellationToken)
            // Create client
            CampaignAssetSetServiceClient campaignAssetSetServiceClient = await CampaignAssetSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignAssetSetOperation> operations = new CampaignAssetSetOperation[]
            {
                new CampaignAssetSetOperation(),
            };
            // Make the request
            MutateCampaignAssetSetsResponse response = await campaignAssetSetServiceClient.MutateCampaignAssetSetsAsync(customerId, operations);
            // End snippet
        }
    }
}
