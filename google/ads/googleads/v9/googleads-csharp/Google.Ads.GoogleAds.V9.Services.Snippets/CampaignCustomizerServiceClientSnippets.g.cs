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
    public sealed class GeneratedCampaignCustomizerServiceClientSnippets
    {
        /// <summary>Snippet for MutateCampaignCustomizers</summary>
        public void MutateCampaignCustomizersRequestObject()
        {
            // Snippet: MutateCampaignCustomizers(MutateCampaignCustomizersRequest, CallSettings)
            // Create client
            CampaignCustomizerServiceClient campaignCustomizerServiceClient = CampaignCustomizerServiceClient.Create();
            // Initialize request argument(s)
            MutateCampaignCustomizersRequest request = new MutateCampaignCustomizersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignCustomizersResponse response = campaignCustomizerServiceClient.MutateCampaignCustomizers(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignCustomizersAsync</summary>
        public async Task MutateCampaignCustomizersRequestObjectAsync()
        {
            // Snippet: MutateCampaignCustomizersAsync(MutateCampaignCustomizersRequest, CallSettings)
            // Additional: MutateCampaignCustomizersAsync(MutateCampaignCustomizersRequest, CancellationToken)
            // Create client
            CampaignCustomizerServiceClient campaignCustomizerServiceClient = await CampaignCustomizerServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCampaignCustomizersRequest request = new MutateCampaignCustomizersRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateCampaignCustomizersResponse response = await campaignCustomizerServiceClient.MutateCampaignCustomizersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignCustomizers</summary>
        public void MutateCampaignCustomizers()
        {
            // Snippet: MutateCampaignCustomizers(string, IEnumerable<CampaignCustomizerOperation>, CallSettings)
            // Create client
            CampaignCustomizerServiceClient campaignCustomizerServiceClient = CampaignCustomizerServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignCustomizerOperation> operations = new CampaignCustomizerOperation[]
            {
                new CampaignCustomizerOperation(),
            };
            // Make the request
            MutateCampaignCustomizersResponse response = campaignCustomizerServiceClient.MutateCampaignCustomizers(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignCustomizersAsync</summary>
        public async Task MutateCampaignCustomizersAsync()
        {
            // Snippet: MutateCampaignCustomizersAsync(string, IEnumerable<CampaignCustomizerOperation>, CallSettings)
            // Additional: MutateCampaignCustomizersAsync(string, IEnumerable<CampaignCustomizerOperation>, CancellationToken)
            // Create client
            CampaignCustomizerServiceClient campaignCustomizerServiceClient = await CampaignCustomizerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignCustomizerOperation> operations = new CampaignCustomizerOperation[]
            {
                new CampaignCustomizerOperation(),
            };
            // Make the request
            MutateCampaignCustomizersResponse response = await campaignCustomizerServiceClient.MutateCampaignCustomizersAsync(customerId, operations);
            // End snippet
        }
    }
}
