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
    using Google.Ads.GoogleAds.V9.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAccountLinkServiceClientSnippets
    {
        /// <summary>Snippet for GetAccountLink</summary>
        public void GetAccountLinkRequestObject()
        {
            // Snippet: GetAccountLink(GetAccountLinkRequest, CallSettings)
            // Create client
            AccountLinkServiceClient accountLinkServiceClient = AccountLinkServiceClient.Create();
            // Initialize request argument(s)
            GetAccountLinkRequest request = new GetAccountLinkRequest
            {
                ResourceNameAsAccountLinkName = AccountLinkName.FromCustomerAccountLink("[CUSTOMER_ID]", "[ACCOUNT_LINK_ID]"),
            };
            // Make the request
            AccountLink response = accountLinkServiceClient.GetAccountLink(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountLinkAsync</summary>
        public async Task GetAccountLinkRequestObjectAsync()
        {
            // Snippet: GetAccountLinkAsync(GetAccountLinkRequest, CallSettings)
            // Additional: GetAccountLinkAsync(GetAccountLinkRequest, CancellationToken)
            // Create client
            AccountLinkServiceClient accountLinkServiceClient = await AccountLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAccountLinkRequest request = new GetAccountLinkRequest
            {
                ResourceNameAsAccountLinkName = AccountLinkName.FromCustomerAccountLink("[CUSTOMER_ID]", "[ACCOUNT_LINK_ID]"),
            };
            // Make the request
            AccountLink response = await accountLinkServiceClient.GetAccountLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountLink</summary>
        public void GetAccountLink()
        {
            // Snippet: GetAccountLink(string, CallSettings)
            // Create client
            AccountLinkServiceClient accountLinkServiceClient = AccountLinkServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/accountLinks/[ACCOUNT_LINK_ID]";
            // Make the request
            AccountLink response = accountLinkServiceClient.GetAccountLink(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAccountLinkAsync</summary>
        public async Task GetAccountLinkAsync()
        {
            // Snippet: GetAccountLinkAsync(string, CallSettings)
            // Additional: GetAccountLinkAsync(string, CancellationToken)
            // Create client
            AccountLinkServiceClient accountLinkServiceClient = await AccountLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/accountLinks/[ACCOUNT_LINK_ID]";
            // Make the request
            AccountLink response = await accountLinkServiceClient.GetAccountLinkAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAccountLink</summary>
        public void GetAccountLinkResourceNames()
        {
            // Snippet: GetAccountLink(AccountLinkName, CallSettings)
            // Create client
            AccountLinkServiceClient accountLinkServiceClient = AccountLinkServiceClient.Create();
            // Initialize request argument(s)
            AccountLinkName resourceName = AccountLinkName.FromCustomerAccountLink("[CUSTOMER_ID]", "[ACCOUNT_LINK_ID]");
            // Make the request
            AccountLink response = accountLinkServiceClient.GetAccountLink(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAccountLinkAsync</summary>
        public async Task GetAccountLinkResourceNamesAsync()
        {
            // Snippet: GetAccountLinkAsync(AccountLinkName, CallSettings)
            // Additional: GetAccountLinkAsync(AccountLinkName, CancellationToken)
            // Create client
            AccountLinkServiceClient accountLinkServiceClient = await AccountLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountLinkName resourceName = AccountLinkName.FromCustomerAccountLink("[CUSTOMER_ID]", "[ACCOUNT_LINK_ID]");
            // Make the request
            AccountLink response = await accountLinkServiceClient.GetAccountLinkAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for CreateAccountLink</summary>
        public void CreateAccountLinkRequestObject()
        {
            // Snippet: CreateAccountLink(CreateAccountLinkRequest, CallSettings)
            // Create client
            AccountLinkServiceClient accountLinkServiceClient = AccountLinkServiceClient.Create();
            // Initialize request argument(s)
            CreateAccountLinkRequest request = new CreateAccountLinkRequest
            {
                CustomerId = "",
                AccountLink = new AccountLink(),
            };
            // Make the request
            CreateAccountLinkResponse response = accountLinkServiceClient.CreateAccountLink(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAccountLinkAsync</summary>
        public async Task CreateAccountLinkRequestObjectAsync()
        {
            // Snippet: CreateAccountLinkAsync(CreateAccountLinkRequest, CallSettings)
            // Additional: CreateAccountLinkAsync(CreateAccountLinkRequest, CancellationToken)
            // Create client
            AccountLinkServiceClient accountLinkServiceClient = await AccountLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAccountLinkRequest request = new CreateAccountLinkRequest
            {
                CustomerId = "",
                AccountLink = new AccountLink(),
            };
            // Make the request
            CreateAccountLinkResponse response = await accountLinkServiceClient.CreateAccountLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAccountLink</summary>
        public void CreateAccountLink()
        {
            // Snippet: CreateAccountLink(string, AccountLink, CallSettings)
            // Create client
            AccountLinkServiceClient accountLinkServiceClient = AccountLinkServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            AccountLink accountLink = new AccountLink();
            // Make the request
            CreateAccountLinkResponse response = accountLinkServiceClient.CreateAccountLink(customerId, accountLink);
            // End snippet
        }

        /// <summary>Snippet for CreateAccountLinkAsync</summary>
        public async Task CreateAccountLinkAsync()
        {
            // Snippet: CreateAccountLinkAsync(string, AccountLink, CallSettings)
            // Additional: CreateAccountLinkAsync(string, AccountLink, CancellationToken)
            // Create client
            AccountLinkServiceClient accountLinkServiceClient = await AccountLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            AccountLink accountLink = new AccountLink();
            // Make the request
            CreateAccountLinkResponse response = await accountLinkServiceClient.CreateAccountLinkAsync(customerId, accountLink);
            // End snippet
        }

        /// <summary>Snippet for MutateAccountLink</summary>
        public void MutateAccountLinkRequestObject()
        {
            // Snippet: MutateAccountLink(MutateAccountLinkRequest, CallSettings)
            // Create client
            AccountLinkServiceClient accountLinkServiceClient = AccountLinkServiceClient.Create();
            // Initialize request argument(s)
            MutateAccountLinkRequest request = new MutateAccountLinkRequest
            {
                CustomerId = "",
                Operation = new AccountLinkOperation(),
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateAccountLinkResponse response = accountLinkServiceClient.MutateAccountLink(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAccountLinkAsync</summary>
        public async Task MutateAccountLinkRequestObjectAsync()
        {
            // Snippet: MutateAccountLinkAsync(MutateAccountLinkRequest, CallSettings)
            // Additional: MutateAccountLinkAsync(MutateAccountLinkRequest, CancellationToken)
            // Create client
            AccountLinkServiceClient accountLinkServiceClient = await AccountLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAccountLinkRequest request = new MutateAccountLinkRequest
            {
                CustomerId = "",
                Operation = new AccountLinkOperation(),
                PartialFailure = false,
                ValidateOnly = false,
            };
            // Make the request
            MutateAccountLinkResponse response = await accountLinkServiceClient.MutateAccountLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAccountLink</summary>
        public void MutateAccountLink()
        {
            // Snippet: MutateAccountLink(string, AccountLinkOperation, CallSettings)
            // Create client
            AccountLinkServiceClient accountLinkServiceClient = AccountLinkServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            AccountLinkOperation operation = new AccountLinkOperation();
            // Make the request
            MutateAccountLinkResponse response = accountLinkServiceClient.MutateAccountLink(customerId, operation);
            // End snippet
        }

        /// <summary>Snippet for MutateAccountLinkAsync</summary>
        public async Task MutateAccountLinkAsync()
        {
            // Snippet: MutateAccountLinkAsync(string, AccountLinkOperation, CallSettings)
            // Additional: MutateAccountLinkAsync(string, AccountLinkOperation, CancellationToken)
            // Create client
            AccountLinkServiceClient accountLinkServiceClient = await AccountLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            AccountLinkOperation operation = new AccountLinkOperation();
            // Make the request
            MutateAccountLinkResponse response = await accountLinkServiceClient.MutateAccountLinkAsync(customerId, operation);
            // End snippet
        }
    }
}
