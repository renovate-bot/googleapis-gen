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

namespace Google.Cloud.Billing.V1.Snippets
{
    using Google.Api.Gax.ResourceNames;

    public sealed partial class GeneratedCloudBillingClientStandaloneSnippets
    {
        /// <summary>Snippet for GetBillingAccount</summary>
        public void GetBillingAccountRequestObject()
        {
            // Snippet: GetBillingAccount(GetBillingAccountRequest, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            GetBillingAccountRequest request = new GetBillingAccountRequest
            {
                BillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
            };
            // Make the request
            BillingAccount response = cloudBillingClient.GetBillingAccount(request);
            // End snippet
        }
    }
}
