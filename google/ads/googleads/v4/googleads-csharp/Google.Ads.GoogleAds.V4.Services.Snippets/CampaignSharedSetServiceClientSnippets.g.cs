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
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCampaignSharedSetServiceClientSnippets
    {
        /// <summary>Snippet for GetCampaignSharedSet</summary>
        public void GetCampaignSharedSetRequestObject()
        {
            // Snippet: GetCampaignSharedSet(GetCampaignSharedSetRequest, CallSettings)
            // Create client
            CampaignSharedSetServiceClient campaignSharedSetServiceClient = CampaignSharedSetServiceClient.Create();
            // Initialize request argument(s)
            GetCampaignSharedSetRequest request = new GetCampaignSharedSetRequest
            {
                ResourceNameAsCampaignSharedSetName = CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]"),
            };
            // Make the request
            CampaignSharedSet response = campaignSharedSetServiceClient.GetCampaignSharedSet(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignSharedSetAsync</summary>
        public async Task GetCampaignSharedSetRequestObjectAsync()
        {
            // Snippet: GetCampaignSharedSetAsync(GetCampaignSharedSetRequest, CallSettings)
            // Additional: GetCampaignSharedSetAsync(GetCampaignSharedSetRequest, CancellationToken)
            // Create client
            CampaignSharedSetServiceClient campaignSharedSetServiceClient = await CampaignSharedSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCampaignSharedSetRequest request = new GetCampaignSharedSetRequest
            {
                ResourceNameAsCampaignSharedSetName = CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]"),
            };
            // Make the request
            CampaignSharedSet response = await campaignSharedSetServiceClient.GetCampaignSharedSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignSharedSet</summary>
        public void GetCampaignSharedSet()
        {
            // Snippet: GetCampaignSharedSet(string, CallSettings)
            // Create client
            CampaignSharedSetServiceClient campaignSharedSetServiceClient = CampaignSharedSetServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/campaignSharedSets/[CAMPAIGN_SHARED_SET]";
            // Make the request
            CampaignSharedSet response = campaignSharedSetServiceClient.GetCampaignSharedSet(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignSharedSetAsync</summary>
        public async Task GetCampaignSharedSetAsync()
        {
            // Snippet: GetCampaignSharedSetAsync(string, CallSettings)
            // Additional: GetCampaignSharedSetAsync(string, CancellationToken)
            // Create client
            CampaignSharedSetServiceClient campaignSharedSetServiceClient = await CampaignSharedSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/campaignSharedSets/[CAMPAIGN_SHARED_SET]";
            // Make the request
            CampaignSharedSet response = await campaignSharedSetServiceClient.GetCampaignSharedSetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignSharedSet</summary>
        public void GetCampaignSharedSetResourceNames()
        {
            // Snippet: GetCampaignSharedSet(CampaignSharedSetName, CallSettings)
            // Create client
            CampaignSharedSetServiceClient campaignSharedSetServiceClient = CampaignSharedSetServiceClient.Create();
            // Initialize request argument(s)
            CampaignSharedSetName resourceName = CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]");
            // Make the request
            CampaignSharedSet response = campaignSharedSetServiceClient.GetCampaignSharedSet(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCampaignSharedSetAsync</summary>
        public async Task GetCampaignSharedSetResourceNamesAsync()
        {
            // Snippet: GetCampaignSharedSetAsync(CampaignSharedSetName, CallSettings)
            // Additional: GetCampaignSharedSetAsync(CampaignSharedSetName, CancellationToken)
            // Create client
            CampaignSharedSetServiceClient campaignSharedSetServiceClient = await CampaignSharedSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CampaignSharedSetName resourceName = CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]");
            // Make the request
            CampaignSharedSet response = await campaignSharedSetServiceClient.GetCampaignSharedSetAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignSharedSets</summary>
        public void MutateCampaignSharedSetsRequestObject()
        {
            // Snippet: MutateCampaignSharedSets(MutateCampaignSharedSetsRequest, CallSettings)
            // Create client
            CampaignSharedSetServiceClient campaignSharedSetServiceClient = CampaignSharedSetServiceClient.Create();
            // Initialize request argument(s)
            MutateCampaignSharedSetsRequest request = new MutateCampaignSharedSetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignSharedSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateCampaignSharedSetsResponse response = campaignSharedSetServiceClient.MutateCampaignSharedSets(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignSharedSetsAsync</summary>
        public async Task MutateCampaignSharedSetsRequestObjectAsync()
        {
            // Snippet: MutateCampaignSharedSetsAsync(MutateCampaignSharedSetsRequest, CallSettings)
            // Additional: MutateCampaignSharedSetsAsync(MutateCampaignSharedSetsRequest, CancellationToken)
            // Create client
            CampaignSharedSetServiceClient campaignSharedSetServiceClient = await CampaignSharedSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateCampaignSharedSetsRequest request = new MutateCampaignSharedSetsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new CampaignSharedSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateCampaignSharedSetsResponse response = await campaignSharedSetServiceClient.MutateCampaignSharedSetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignSharedSets</summary>
        public void MutateCampaignSharedSets()
        {
            // Snippet: MutateCampaignSharedSets(string, IEnumerable<CampaignSharedSetOperation>, CallSettings)
            // Create client
            CampaignSharedSetServiceClient campaignSharedSetServiceClient = CampaignSharedSetServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignSharedSetOperation> operations = new CampaignSharedSetOperation[]
            {
                new CampaignSharedSetOperation(),
            };
            // Make the request
            MutateCampaignSharedSetsResponse response = campaignSharedSetServiceClient.MutateCampaignSharedSets(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateCampaignSharedSetsAsync</summary>
        public async Task MutateCampaignSharedSetsAsync()
        {
            // Snippet: MutateCampaignSharedSetsAsync(string, IEnumerable<CampaignSharedSetOperation>, CallSettings)
            // Additional: MutateCampaignSharedSetsAsync(string, IEnumerable<CampaignSharedSetOperation>, CancellationToken)
            // Create client
            CampaignSharedSetServiceClient campaignSharedSetServiceClient = await CampaignSharedSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<CampaignSharedSetOperation> operations = new CampaignSharedSetOperation[]
            {
                new CampaignSharedSetOperation(),
            };
            // Make the request
            MutateCampaignSharedSetsResponse response = await campaignSharedSetServiceClient.MutateCampaignSharedSetsAsync(customerId, operations);
            // End snippet
        }
    }
}
