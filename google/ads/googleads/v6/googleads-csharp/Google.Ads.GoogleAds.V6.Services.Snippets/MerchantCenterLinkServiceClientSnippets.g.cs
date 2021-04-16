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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedMerchantCenterLinkServiceClientSnippets
    {
        /// <summary>Snippet for ListMerchantCenterLinks</summary>
        public void ListMerchantCenterLinksRequestObject()
        {
            // Snippet: ListMerchantCenterLinks(ListMerchantCenterLinksRequest, CallSettings)
            // Create client
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient = MerchantCenterLinkServiceClient.Create();
            // Initialize request argument(s)
            ListMerchantCenterLinksRequest request = new ListMerchantCenterLinksRequest { CustomerId = "", };
            // Make the request
            ListMerchantCenterLinksResponse response = merchantCenterLinkServiceClient.ListMerchantCenterLinks(request);
            // End snippet
        }

        /// <summary>Snippet for ListMerchantCenterLinksAsync</summary>
        public async Task ListMerchantCenterLinksRequestObjectAsync()
        {
            // Snippet: ListMerchantCenterLinksAsync(ListMerchantCenterLinksRequest, CallSettings)
            // Additional: ListMerchantCenterLinksAsync(ListMerchantCenterLinksRequest, CancellationToken)
            // Create client
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient = await MerchantCenterLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMerchantCenterLinksRequest request = new ListMerchantCenterLinksRequest { CustomerId = "", };
            // Make the request
            ListMerchantCenterLinksResponse response = await merchantCenterLinkServiceClient.ListMerchantCenterLinksAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListMerchantCenterLinks</summary>
        public void ListMerchantCenterLinks()
        {
            // Snippet: ListMerchantCenterLinks(string, CallSettings)
            // Create client
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient = MerchantCenterLinkServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            // Make the request
            ListMerchantCenterLinksResponse response = merchantCenterLinkServiceClient.ListMerchantCenterLinks(customerId);
            // End snippet
        }

        /// <summary>Snippet for ListMerchantCenterLinksAsync</summary>
        public async Task ListMerchantCenterLinksAsync()
        {
            // Snippet: ListMerchantCenterLinksAsync(string, CallSettings)
            // Additional: ListMerchantCenterLinksAsync(string, CancellationToken)
            // Create client
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient = await MerchantCenterLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            // Make the request
            ListMerchantCenterLinksResponse response = await merchantCenterLinkServiceClient.ListMerchantCenterLinksAsync(customerId);
            // End snippet
        }

        /// <summary>Snippet for GetMerchantCenterLink</summary>
        public void GetMerchantCenterLinkRequestObject()
        {
            // Snippet: GetMerchantCenterLink(GetMerchantCenterLinkRequest, CallSettings)
            // Create client
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient = MerchantCenterLinkServiceClient.Create();
            // Initialize request argument(s)
            GetMerchantCenterLinkRequest request = new GetMerchantCenterLinkRequest
            {
                ResourceNameAsMerchantCenterLinkName = MerchantCenterLinkName.FromCustomerMerchantCenter("[CUSTOMER_ID]", "[MERCHANT_CENTER_ID]"),
            };
            // Make the request
            MerchantCenterLink response = merchantCenterLinkServiceClient.GetMerchantCenterLink(request);
            // End snippet
        }

        /// <summary>Snippet for GetMerchantCenterLinkAsync</summary>
        public async Task GetMerchantCenterLinkRequestObjectAsync()
        {
            // Snippet: GetMerchantCenterLinkAsync(GetMerchantCenterLinkRequest, CallSettings)
            // Additional: GetMerchantCenterLinkAsync(GetMerchantCenterLinkRequest, CancellationToken)
            // Create client
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient = await MerchantCenterLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMerchantCenterLinkRequest request = new GetMerchantCenterLinkRequest
            {
                ResourceNameAsMerchantCenterLinkName = MerchantCenterLinkName.FromCustomerMerchantCenter("[CUSTOMER_ID]", "[MERCHANT_CENTER_ID]"),
            };
            // Make the request
            MerchantCenterLink response = await merchantCenterLinkServiceClient.GetMerchantCenterLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMerchantCenterLink</summary>
        public void GetMerchantCenterLink()
        {
            // Snippet: GetMerchantCenterLink(string, CallSettings)
            // Create client
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient = MerchantCenterLinkServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/merchantCenterLinks/[MERCHANT_CENTER_ID]";
            // Make the request
            MerchantCenterLink response = merchantCenterLinkServiceClient.GetMerchantCenterLink(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetMerchantCenterLinkAsync</summary>
        public async Task GetMerchantCenterLinkAsync()
        {
            // Snippet: GetMerchantCenterLinkAsync(string, CallSettings)
            // Additional: GetMerchantCenterLinkAsync(string, CancellationToken)
            // Create client
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient = await MerchantCenterLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/merchantCenterLinks/[MERCHANT_CENTER_ID]";
            // Make the request
            MerchantCenterLink response = await merchantCenterLinkServiceClient.GetMerchantCenterLinkAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetMerchantCenterLink</summary>
        public void GetMerchantCenterLinkResourceNames()
        {
            // Snippet: GetMerchantCenterLink(MerchantCenterLinkName, CallSettings)
            // Create client
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient = MerchantCenterLinkServiceClient.Create();
            // Initialize request argument(s)
            MerchantCenterLinkName resourceName = MerchantCenterLinkName.FromCustomerMerchantCenter("[CUSTOMER_ID]", "[MERCHANT_CENTER_ID]");
            // Make the request
            MerchantCenterLink response = merchantCenterLinkServiceClient.GetMerchantCenterLink(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetMerchantCenterLinkAsync</summary>
        public async Task GetMerchantCenterLinkResourceNamesAsync()
        {
            // Snippet: GetMerchantCenterLinkAsync(MerchantCenterLinkName, CallSettings)
            // Additional: GetMerchantCenterLinkAsync(MerchantCenterLinkName, CancellationToken)
            // Create client
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient = await MerchantCenterLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            MerchantCenterLinkName resourceName = MerchantCenterLinkName.FromCustomerMerchantCenter("[CUSTOMER_ID]", "[MERCHANT_CENTER_ID]");
            // Make the request
            MerchantCenterLink response = await merchantCenterLinkServiceClient.GetMerchantCenterLinkAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateMerchantCenterLink</summary>
        public void MutateMerchantCenterLinkRequestObject()
        {
            // Snippet: MutateMerchantCenterLink(MutateMerchantCenterLinkRequest, CallSettings)
            // Create client
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient = MerchantCenterLinkServiceClient.Create();
            // Initialize request argument(s)
            MutateMerchantCenterLinkRequest request = new MutateMerchantCenterLinkRequest
            {
                CustomerId = "",
                Operation = new MerchantCenterLinkOperation(),
            };
            // Make the request
            MutateMerchantCenterLinkResponse response = merchantCenterLinkServiceClient.MutateMerchantCenterLink(request);
            // End snippet
        }

        /// <summary>Snippet for MutateMerchantCenterLinkAsync</summary>
        public async Task MutateMerchantCenterLinkRequestObjectAsync()
        {
            // Snippet: MutateMerchantCenterLinkAsync(MutateMerchantCenterLinkRequest, CallSettings)
            // Additional: MutateMerchantCenterLinkAsync(MutateMerchantCenterLinkRequest, CancellationToken)
            // Create client
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient = await MerchantCenterLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateMerchantCenterLinkRequest request = new MutateMerchantCenterLinkRequest
            {
                CustomerId = "",
                Operation = new MerchantCenterLinkOperation(),
            };
            // Make the request
            MutateMerchantCenterLinkResponse response = await merchantCenterLinkServiceClient.MutateMerchantCenterLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateMerchantCenterLink</summary>
        public void MutateMerchantCenterLink()
        {
            // Snippet: MutateMerchantCenterLink(string, MerchantCenterLinkOperation, CallSettings)
            // Create client
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient = MerchantCenterLinkServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            MerchantCenterLinkOperation operation = new MerchantCenterLinkOperation();
            // Make the request
            MutateMerchantCenterLinkResponse response = merchantCenterLinkServiceClient.MutateMerchantCenterLink(customerId, operation);
            // End snippet
        }

        /// <summary>Snippet for MutateMerchantCenterLinkAsync</summary>
        public async Task MutateMerchantCenterLinkAsync()
        {
            // Snippet: MutateMerchantCenterLinkAsync(string, MerchantCenterLinkOperation, CallSettings)
            // Additional: MutateMerchantCenterLinkAsync(string, MerchantCenterLinkOperation, CancellationToken)
            // Create client
            MerchantCenterLinkServiceClient merchantCenterLinkServiceClient = await MerchantCenterLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            MerchantCenterLinkOperation operation = new MerchantCenterLinkOperation();
            // Make the request
            MutateMerchantCenterLinkResponse response = await merchantCenterLinkServiceClient.MutateMerchantCenterLinkAsync(customerId, operation);
            // End snippet
        }
    }
}
