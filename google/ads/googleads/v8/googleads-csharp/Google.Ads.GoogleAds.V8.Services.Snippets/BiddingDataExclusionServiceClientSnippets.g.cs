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

namespace Google.Ads.GoogleAds.V8.Services.Snippets
{
    using Google.Ads.GoogleAds.V8.Enums;
    using Google.Ads.GoogleAds.V8.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedBiddingDataExclusionServiceClientSnippets
    {
        /// <summary>Snippet for GetBiddingDataExclusion</summary>
        public void GetBiddingDataExclusionRequestObject()
        {
            // Snippet: GetBiddingDataExclusion(GetBiddingDataExclusionRequest, CallSettings)
            // Create client
            BiddingDataExclusionServiceClient biddingDataExclusionServiceClient = BiddingDataExclusionServiceClient.Create();
            // Initialize request argument(s)
            GetBiddingDataExclusionRequest request = new GetBiddingDataExclusionRequest
            {
                ResourceNameAsBiddingDataExclusionName = BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            // Make the request
            BiddingDataExclusion response = biddingDataExclusionServiceClient.GetBiddingDataExclusion(request);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingDataExclusionAsync</summary>
        public async Task GetBiddingDataExclusionRequestObjectAsync()
        {
            // Snippet: GetBiddingDataExclusionAsync(GetBiddingDataExclusionRequest, CallSettings)
            // Additional: GetBiddingDataExclusionAsync(GetBiddingDataExclusionRequest, CancellationToken)
            // Create client
            BiddingDataExclusionServiceClient biddingDataExclusionServiceClient = await BiddingDataExclusionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBiddingDataExclusionRequest request = new GetBiddingDataExclusionRequest
            {
                ResourceNameAsBiddingDataExclusionName = BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            // Make the request
            BiddingDataExclusion response = await biddingDataExclusionServiceClient.GetBiddingDataExclusionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingDataExclusion</summary>
        public void GetBiddingDataExclusion()
        {
            // Snippet: GetBiddingDataExclusion(string, CallSettings)
            // Create client
            BiddingDataExclusionServiceClient biddingDataExclusionServiceClient = BiddingDataExclusionServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/biddingDataExclusions/[SEASONALITY_EVENT_ID]";
            // Make the request
            BiddingDataExclusion response = biddingDataExclusionServiceClient.GetBiddingDataExclusion(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingDataExclusionAsync</summary>
        public async Task GetBiddingDataExclusionAsync()
        {
            // Snippet: GetBiddingDataExclusionAsync(string, CallSettings)
            // Additional: GetBiddingDataExclusionAsync(string, CancellationToken)
            // Create client
            BiddingDataExclusionServiceClient biddingDataExclusionServiceClient = await BiddingDataExclusionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/biddingDataExclusions/[SEASONALITY_EVENT_ID]";
            // Make the request
            BiddingDataExclusion response = await biddingDataExclusionServiceClient.GetBiddingDataExclusionAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingDataExclusion</summary>
        public void GetBiddingDataExclusionResourceNames()
        {
            // Snippet: GetBiddingDataExclusion(BiddingDataExclusionName, CallSettings)
            // Create client
            BiddingDataExclusionServiceClient biddingDataExclusionServiceClient = BiddingDataExclusionServiceClient.Create();
            // Initialize request argument(s)
            BiddingDataExclusionName resourceName = BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]");
            // Make the request
            BiddingDataExclusion response = biddingDataExclusionServiceClient.GetBiddingDataExclusion(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingDataExclusionAsync</summary>
        public async Task GetBiddingDataExclusionResourceNamesAsync()
        {
            // Snippet: GetBiddingDataExclusionAsync(BiddingDataExclusionName, CallSettings)
            // Additional: GetBiddingDataExclusionAsync(BiddingDataExclusionName, CancellationToken)
            // Create client
            BiddingDataExclusionServiceClient biddingDataExclusionServiceClient = await BiddingDataExclusionServiceClient.CreateAsync();
            // Initialize request argument(s)
            BiddingDataExclusionName resourceName = BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]");
            // Make the request
            BiddingDataExclusion response = await biddingDataExclusionServiceClient.GetBiddingDataExclusionAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateBiddingDataExclusions</summary>
        public void MutateBiddingDataExclusionsRequestObject()
        {
            // Snippet: MutateBiddingDataExclusions(MutateBiddingDataExclusionsRequest, CallSettings)
            // Create client
            BiddingDataExclusionServiceClient biddingDataExclusionServiceClient = BiddingDataExclusionServiceClient.Create();
            // Initialize request argument(s)
            MutateBiddingDataExclusionsRequest request = new MutateBiddingDataExclusionsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new BiddingDataExclusionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateBiddingDataExclusionsResponse response = biddingDataExclusionServiceClient.MutateBiddingDataExclusions(request);
            // End snippet
        }

        /// <summary>Snippet for MutateBiddingDataExclusionsAsync</summary>
        public async Task MutateBiddingDataExclusionsRequestObjectAsync()
        {
            // Snippet: MutateBiddingDataExclusionsAsync(MutateBiddingDataExclusionsRequest, CallSettings)
            // Additional: MutateBiddingDataExclusionsAsync(MutateBiddingDataExclusionsRequest, CancellationToken)
            // Create client
            BiddingDataExclusionServiceClient biddingDataExclusionServiceClient = await BiddingDataExclusionServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateBiddingDataExclusionsRequest request = new MutateBiddingDataExclusionsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new BiddingDataExclusionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateBiddingDataExclusionsResponse response = await biddingDataExclusionServiceClient.MutateBiddingDataExclusionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateBiddingDataExclusions</summary>
        public void MutateBiddingDataExclusions()
        {
            // Snippet: MutateBiddingDataExclusions(string, IEnumerable<BiddingDataExclusionOperation>, CallSettings)
            // Create client
            BiddingDataExclusionServiceClient biddingDataExclusionServiceClient = BiddingDataExclusionServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<BiddingDataExclusionOperation> operations = new BiddingDataExclusionOperation[]
            {
                new BiddingDataExclusionOperation(),
            };
            // Make the request
            MutateBiddingDataExclusionsResponse response = biddingDataExclusionServiceClient.MutateBiddingDataExclusions(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateBiddingDataExclusionsAsync</summary>
        public async Task MutateBiddingDataExclusionsAsync()
        {
            // Snippet: MutateBiddingDataExclusionsAsync(string, IEnumerable<BiddingDataExclusionOperation>, CallSettings)
            // Additional: MutateBiddingDataExclusionsAsync(string, IEnumerable<BiddingDataExclusionOperation>, CancellationToken)
            // Create client
            BiddingDataExclusionServiceClient biddingDataExclusionServiceClient = await BiddingDataExclusionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<BiddingDataExclusionOperation> operations = new BiddingDataExclusionOperation[]
            {
                new BiddingDataExclusionOperation(),
            };
            // Make the request
            MutateBiddingDataExclusionsResponse response = await biddingDataExclusionServiceClient.MutateBiddingDataExclusionsAsync(customerId, operations);
            // End snippet
        }
    }
}
