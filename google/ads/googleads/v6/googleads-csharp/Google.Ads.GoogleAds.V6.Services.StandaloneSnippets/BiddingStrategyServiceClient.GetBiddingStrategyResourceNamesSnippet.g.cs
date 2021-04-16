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
    using Google.Ads.GoogleAds.V6.Resources;

    public sealed partial class GeneratedBiddingStrategyServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetBiddingStrategy</summary>
        public void GetBiddingStrategyResourceNames()
        {
            // Snippet: GetBiddingStrategy(BiddingStrategyName, CallSettings)
            // Create client
            BiddingStrategyServiceClient biddingStrategyServiceClient = BiddingStrategyServiceClient.Create();
            // Initialize request argument(s)
            BiddingStrategyName resourceName = BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]");
            // Make the request
            BiddingStrategy response = biddingStrategyServiceClient.GetBiddingStrategy(resourceName);
            // End snippet
        }
    }
}
