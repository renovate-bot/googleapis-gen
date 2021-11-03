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
    using Google.Ads.GoogleAds.V9.Resources;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedBiddingSeasonalityAdjustmentServiceClientSnippets
    {
        /// <summary>Snippet for GetBiddingSeasonalityAdjustment</summary>
        public void GetBiddingSeasonalityAdjustmentRequestObject()
        {
            // Snippet: GetBiddingSeasonalityAdjustment(GetBiddingSeasonalityAdjustmentRequest, CallSettings)
            // Create client
            BiddingSeasonalityAdjustmentServiceClient biddingSeasonalityAdjustmentServiceClient = BiddingSeasonalityAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            GetBiddingSeasonalityAdjustmentRequest request = new GetBiddingSeasonalityAdjustmentRequest
            {
                ResourceNameAsBiddingSeasonalityAdjustmentName = BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            // Make the request
            BiddingSeasonalityAdjustment response = biddingSeasonalityAdjustmentServiceClient.GetBiddingSeasonalityAdjustment(request);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingSeasonalityAdjustmentAsync</summary>
        public async Task GetBiddingSeasonalityAdjustmentRequestObjectAsync()
        {
            // Snippet: GetBiddingSeasonalityAdjustmentAsync(GetBiddingSeasonalityAdjustmentRequest, CallSettings)
            // Additional: GetBiddingSeasonalityAdjustmentAsync(GetBiddingSeasonalityAdjustmentRequest, CancellationToken)
            // Create client
            BiddingSeasonalityAdjustmentServiceClient biddingSeasonalityAdjustmentServiceClient = await BiddingSeasonalityAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBiddingSeasonalityAdjustmentRequest request = new GetBiddingSeasonalityAdjustmentRequest
            {
                ResourceNameAsBiddingSeasonalityAdjustmentName = BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            // Make the request
            BiddingSeasonalityAdjustment response = await biddingSeasonalityAdjustmentServiceClient.GetBiddingSeasonalityAdjustmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingSeasonalityAdjustment</summary>
        public void GetBiddingSeasonalityAdjustment()
        {
            // Snippet: GetBiddingSeasonalityAdjustment(string, CallSettings)
            // Create client
            BiddingSeasonalityAdjustmentServiceClient biddingSeasonalityAdjustmentServiceClient = BiddingSeasonalityAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/biddingSeasonalityAdjustments/[SEASONALITY_EVENT_ID]";
            // Make the request
            BiddingSeasonalityAdjustment response = biddingSeasonalityAdjustmentServiceClient.GetBiddingSeasonalityAdjustment(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingSeasonalityAdjustmentAsync</summary>
        public async Task GetBiddingSeasonalityAdjustmentAsync()
        {
            // Snippet: GetBiddingSeasonalityAdjustmentAsync(string, CallSettings)
            // Additional: GetBiddingSeasonalityAdjustmentAsync(string, CancellationToken)
            // Create client
            BiddingSeasonalityAdjustmentServiceClient biddingSeasonalityAdjustmentServiceClient = await BiddingSeasonalityAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/biddingSeasonalityAdjustments/[SEASONALITY_EVENT_ID]";
            // Make the request
            BiddingSeasonalityAdjustment response = await biddingSeasonalityAdjustmentServiceClient.GetBiddingSeasonalityAdjustmentAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingSeasonalityAdjustment</summary>
        public void GetBiddingSeasonalityAdjustmentResourceNames()
        {
            // Snippet: GetBiddingSeasonalityAdjustment(BiddingSeasonalityAdjustmentName, CallSettings)
            // Create client
            BiddingSeasonalityAdjustmentServiceClient biddingSeasonalityAdjustmentServiceClient = BiddingSeasonalityAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            BiddingSeasonalityAdjustmentName resourceName = BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]");
            // Make the request
            BiddingSeasonalityAdjustment response = biddingSeasonalityAdjustmentServiceClient.GetBiddingSeasonalityAdjustment(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBiddingSeasonalityAdjustmentAsync</summary>
        public async Task GetBiddingSeasonalityAdjustmentResourceNamesAsync()
        {
            // Snippet: GetBiddingSeasonalityAdjustmentAsync(BiddingSeasonalityAdjustmentName, CallSettings)
            // Additional: GetBiddingSeasonalityAdjustmentAsync(BiddingSeasonalityAdjustmentName, CancellationToken)
            // Create client
            BiddingSeasonalityAdjustmentServiceClient biddingSeasonalityAdjustmentServiceClient = await BiddingSeasonalityAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BiddingSeasonalityAdjustmentName resourceName = BiddingSeasonalityAdjustmentName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]");
            // Make the request
            BiddingSeasonalityAdjustment response = await biddingSeasonalityAdjustmentServiceClient.GetBiddingSeasonalityAdjustmentAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateBiddingSeasonalityAdjustments</summary>
        public void MutateBiddingSeasonalityAdjustmentsRequestObject()
        {
            // Snippet: MutateBiddingSeasonalityAdjustments(MutateBiddingSeasonalityAdjustmentsRequest, CallSettings)
            // Create client
            BiddingSeasonalityAdjustmentServiceClient biddingSeasonalityAdjustmentServiceClient = BiddingSeasonalityAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            MutateBiddingSeasonalityAdjustmentsRequest request = new MutateBiddingSeasonalityAdjustmentsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new BiddingSeasonalityAdjustmentOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateBiddingSeasonalityAdjustmentsResponse response = biddingSeasonalityAdjustmentServiceClient.MutateBiddingSeasonalityAdjustments(request);
            // End snippet
        }

        /// <summary>Snippet for MutateBiddingSeasonalityAdjustmentsAsync</summary>
        public async Task MutateBiddingSeasonalityAdjustmentsRequestObjectAsync()
        {
            // Snippet: MutateBiddingSeasonalityAdjustmentsAsync(MutateBiddingSeasonalityAdjustmentsRequest, CallSettings)
            // Additional: MutateBiddingSeasonalityAdjustmentsAsync(MutateBiddingSeasonalityAdjustmentsRequest, CancellationToken)
            // Create client
            BiddingSeasonalityAdjustmentServiceClient biddingSeasonalityAdjustmentServiceClient = await BiddingSeasonalityAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateBiddingSeasonalityAdjustmentsRequest request = new MutateBiddingSeasonalityAdjustmentsRequest
            {
                CustomerId = "",
                Operations =
                {
                    new BiddingSeasonalityAdjustmentOperation(),
                },
                PartialFailure = false,
                ValidateOnly = false,
                ResponseContentType = ResponseContentTypeEnum.Types.ResponseContentType.Unspecified,
            };
            // Make the request
            MutateBiddingSeasonalityAdjustmentsResponse response = await biddingSeasonalityAdjustmentServiceClient.MutateBiddingSeasonalityAdjustmentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateBiddingSeasonalityAdjustments</summary>
        public void MutateBiddingSeasonalityAdjustments()
        {
            // Snippet: MutateBiddingSeasonalityAdjustments(string, IEnumerable<BiddingSeasonalityAdjustmentOperation>, CallSettings)
            // Create client
            BiddingSeasonalityAdjustmentServiceClient biddingSeasonalityAdjustmentServiceClient = BiddingSeasonalityAdjustmentServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<BiddingSeasonalityAdjustmentOperation> operations = new BiddingSeasonalityAdjustmentOperation[]
            {
                new BiddingSeasonalityAdjustmentOperation(),
            };
            // Make the request
            MutateBiddingSeasonalityAdjustmentsResponse response = biddingSeasonalityAdjustmentServiceClient.MutateBiddingSeasonalityAdjustments(customerId, operations);
            // End snippet
        }

        /// <summary>Snippet for MutateBiddingSeasonalityAdjustmentsAsync</summary>
        public async Task MutateBiddingSeasonalityAdjustmentsAsync()
        {
            // Snippet: MutateBiddingSeasonalityAdjustmentsAsync(string, IEnumerable<BiddingSeasonalityAdjustmentOperation>, CallSettings)
            // Additional: MutateBiddingSeasonalityAdjustmentsAsync(string, IEnumerable<BiddingSeasonalityAdjustmentOperation>, CancellationToken)
            // Create client
            BiddingSeasonalityAdjustmentServiceClient biddingSeasonalityAdjustmentServiceClient = await BiddingSeasonalityAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            IEnumerable<BiddingSeasonalityAdjustmentOperation> operations = new BiddingSeasonalityAdjustmentOperation[]
            {
                new BiddingSeasonalityAdjustmentOperation(),
            };
            // Make the request
            MutateBiddingSeasonalityAdjustmentsResponse response = await biddingSeasonalityAdjustmentServiceClient.MutateBiddingSeasonalityAdjustmentsAsync(customerId, operations);
            // End snippet
        }
    }
}
