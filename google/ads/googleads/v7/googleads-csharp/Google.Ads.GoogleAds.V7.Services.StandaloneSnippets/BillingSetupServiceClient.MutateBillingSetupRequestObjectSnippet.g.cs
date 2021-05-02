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
    public sealed partial class GeneratedBillingSetupServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for MutateBillingSetup</summary>
        public void MutateBillingSetupRequestObject()
        {
            // Snippet: MutateBillingSetup(MutateBillingSetupRequest, CallSettings)
            // Create client
            BillingSetupServiceClient billingSetupServiceClient = BillingSetupServiceClient.Create();
            // Initialize request argument(s)
            MutateBillingSetupRequest request = new MutateBillingSetupRequest
            {
                CustomerId = "",
                Operation = new BillingSetupOperation(),
            };
            // Make the request
            MutateBillingSetupResponse response = billingSetupServiceClient.MutateBillingSetup(request);
            // End snippet
        }
    }
}
