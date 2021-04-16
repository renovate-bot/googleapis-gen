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
    using Google.Ads.GoogleAds.V5.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedBillingSetupServiceClientSnippets
    {
        /// <summary>Snippet for GetBillingSetup</summary>
        public void GetBillingSetupRequestObject()
        {
            // Snippet: GetBillingSetup(GetBillingSetupRequest, CallSettings)
            // Create client
            BillingSetupServiceClient billingSetupServiceClient = BillingSetupServiceClient.Create();
            // Initialize request argument(s)
            GetBillingSetupRequest request = new GetBillingSetupRequest
            {
                ResourceNameAsBillingSetupName = BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
            };
            // Make the request
            BillingSetup response = billingSetupServiceClient.GetBillingSetup(request);
            // End snippet
        }

        /// <summary>Snippet for GetBillingSetupAsync</summary>
        public async Task GetBillingSetupRequestObjectAsync()
        {
            // Snippet: GetBillingSetupAsync(GetBillingSetupRequest, CallSettings)
            // Additional: GetBillingSetupAsync(GetBillingSetupRequest, CancellationToken)
            // Create client
            BillingSetupServiceClient billingSetupServiceClient = await BillingSetupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBillingSetupRequest request = new GetBillingSetupRequest
            {
                ResourceNameAsBillingSetupName = BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
            };
            // Make the request
            BillingSetup response = await billingSetupServiceClient.GetBillingSetupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBillingSetup</summary>
        public void GetBillingSetup()
        {
            // Snippet: GetBillingSetup(string, CallSettings)
            // Create client
            BillingSetupServiceClient billingSetupServiceClient = BillingSetupServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/billingSetups/[BILLING_SETUP]";
            // Make the request
            BillingSetup response = billingSetupServiceClient.GetBillingSetup(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBillingSetupAsync</summary>
        public async Task GetBillingSetupAsync()
        {
            // Snippet: GetBillingSetupAsync(string, CallSettings)
            // Additional: GetBillingSetupAsync(string, CancellationToken)
            // Create client
            BillingSetupServiceClient billingSetupServiceClient = await BillingSetupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/billingSetups/[BILLING_SETUP]";
            // Make the request
            BillingSetup response = await billingSetupServiceClient.GetBillingSetupAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBillingSetup</summary>
        public void GetBillingSetupResourceNames()
        {
            // Snippet: GetBillingSetup(BillingSetupName, CallSettings)
            // Create client
            BillingSetupServiceClient billingSetupServiceClient = BillingSetupServiceClient.Create();
            // Initialize request argument(s)
            BillingSetupName resourceName = BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]");
            // Make the request
            BillingSetup response = billingSetupServiceClient.GetBillingSetup(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetBillingSetupAsync</summary>
        public async Task GetBillingSetupResourceNamesAsync()
        {
            // Snippet: GetBillingSetupAsync(BillingSetupName, CallSettings)
            // Additional: GetBillingSetupAsync(BillingSetupName, CancellationToken)
            // Create client
            BillingSetupServiceClient billingSetupServiceClient = await BillingSetupServiceClient.CreateAsync();
            // Initialize request argument(s)
            BillingSetupName resourceName = BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]");
            // Make the request
            BillingSetup response = await billingSetupServiceClient.GetBillingSetupAsync(resourceName);
            // End snippet
        }

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

        /// <summary>Snippet for MutateBillingSetupAsync</summary>
        public async Task MutateBillingSetupRequestObjectAsync()
        {
            // Snippet: MutateBillingSetupAsync(MutateBillingSetupRequest, CallSettings)
            // Additional: MutateBillingSetupAsync(MutateBillingSetupRequest, CancellationToken)
            // Create client
            BillingSetupServiceClient billingSetupServiceClient = await BillingSetupServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateBillingSetupRequest request = new MutateBillingSetupRequest
            {
                CustomerId = "",
                Operation = new BillingSetupOperation(),
            };
            // Make the request
            MutateBillingSetupResponse response = await billingSetupServiceClient.MutateBillingSetupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateBillingSetup</summary>
        public void MutateBillingSetup()
        {
            // Snippet: MutateBillingSetup(string, BillingSetupOperation, CallSettings)
            // Create client
            BillingSetupServiceClient billingSetupServiceClient = BillingSetupServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            BillingSetupOperation operation = new BillingSetupOperation();
            // Make the request
            MutateBillingSetupResponse response = billingSetupServiceClient.MutateBillingSetup(customerId, operation);
            // End snippet
        }

        /// <summary>Snippet for MutateBillingSetupAsync</summary>
        public async Task MutateBillingSetupAsync()
        {
            // Snippet: MutateBillingSetupAsync(string, BillingSetupOperation, CallSettings)
            // Additional: MutateBillingSetupAsync(string, BillingSetupOperation, CancellationToken)
            // Create client
            BillingSetupServiceClient billingSetupServiceClient = await BillingSetupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            BillingSetupOperation operation = new BillingSetupOperation();
            // Make the request
            MutateBillingSetupResponse response = await billingSetupServiceClient.MutateBillingSetupAsync(customerId, operation);
            // End snippet
        }
    }
}
