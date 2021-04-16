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
    public sealed class GeneratedAccountBudgetProposalServiceClientSnippets
    {
        /// <summary>Snippet for GetAccountBudgetProposal</summary>
        public void GetAccountBudgetProposalRequestObject()
        {
            // Snippet: GetAccountBudgetProposal(GetAccountBudgetProposalRequest, CallSettings)
            // Create client
            AccountBudgetProposalServiceClient accountBudgetProposalServiceClient = AccountBudgetProposalServiceClient.Create();
            // Initialize request argument(s)
            GetAccountBudgetProposalRequest request = new GetAccountBudgetProposalRequest
            {
                ResourceNameAsAccountBudgetProposalName = AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]"),
            };
            // Make the request
            AccountBudgetProposal response = accountBudgetProposalServiceClient.GetAccountBudgetProposal(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountBudgetProposalAsync</summary>
        public async Task GetAccountBudgetProposalRequestObjectAsync()
        {
            // Snippet: GetAccountBudgetProposalAsync(GetAccountBudgetProposalRequest, CallSettings)
            // Additional: GetAccountBudgetProposalAsync(GetAccountBudgetProposalRequest, CancellationToken)
            // Create client
            AccountBudgetProposalServiceClient accountBudgetProposalServiceClient = await AccountBudgetProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAccountBudgetProposalRequest request = new GetAccountBudgetProposalRequest
            {
                ResourceNameAsAccountBudgetProposalName = AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]"),
            };
            // Make the request
            AccountBudgetProposal response = await accountBudgetProposalServiceClient.GetAccountBudgetProposalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountBudgetProposal</summary>
        public void GetAccountBudgetProposal()
        {
            // Snippet: GetAccountBudgetProposal(string, CallSettings)
            // Create client
            AccountBudgetProposalServiceClient accountBudgetProposalServiceClient = AccountBudgetProposalServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/accountBudgetProposals/[ACCOUNT_BUDGET_PROPOSAL]";
            // Make the request
            AccountBudgetProposal response = accountBudgetProposalServiceClient.GetAccountBudgetProposal(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAccountBudgetProposalAsync</summary>
        public async Task GetAccountBudgetProposalAsync()
        {
            // Snippet: GetAccountBudgetProposalAsync(string, CallSettings)
            // Additional: GetAccountBudgetProposalAsync(string, CancellationToken)
            // Create client
            AccountBudgetProposalServiceClient accountBudgetProposalServiceClient = await AccountBudgetProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/accountBudgetProposals/[ACCOUNT_BUDGET_PROPOSAL]";
            // Make the request
            AccountBudgetProposal response = await accountBudgetProposalServiceClient.GetAccountBudgetProposalAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAccountBudgetProposal</summary>
        public void GetAccountBudgetProposalResourceNames()
        {
            // Snippet: GetAccountBudgetProposal(AccountBudgetProposalName, CallSettings)
            // Create client
            AccountBudgetProposalServiceClient accountBudgetProposalServiceClient = AccountBudgetProposalServiceClient.Create();
            // Initialize request argument(s)
            AccountBudgetProposalName resourceName = AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]");
            // Make the request
            AccountBudgetProposal response = accountBudgetProposalServiceClient.GetAccountBudgetProposal(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetAccountBudgetProposalAsync</summary>
        public async Task GetAccountBudgetProposalResourceNamesAsync()
        {
            // Snippet: GetAccountBudgetProposalAsync(AccountBudgetProposalName, CallSettings)
            // Additional: GetAccountBudgetProposalAsync(AccountBudgetProposalName, CancellationToken)
            // Create client
            AccountBudgetProposalServiceClient accountBudgetProposalServiceClient = await AccountBudgetProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountBudgetProposalName resourceName = AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]");
            // Make the request
            AccountBudgetProposal response = await accountBudgetProposalServiceClient.GetAccountBudgetProposalAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for MutateAccountBudgetProposal</summary>
        public void MutateAccountBudgetProposalRequestObject()
        {
            // Snippet: MutateAccountBudgetProposal(MutateAccountBudgetProposalRequest, CallSettings)
            // Create client
            AccountBudgetProposalServiceClient accountBudgetProposalServiceClient = AccountBudgetProposalServiceClient.Create();
            // Initialize request argument(s)
            MutateAccountBudgetProposalRequest request = new MutateAccountBudgetProposalRequest
            {
                CustomerId = "",
                Operation = new AccountBudgetProposalOperation(),
                ValidateOnly = false,
            };
            // Make the request
            MutateAccountBudgetProposalResponse response = accountBudgetProposalServiceClient.MutateAccountBudgetProposal(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAccountBudgetProposalAsync</summary>
        public async Task MutateAccountBudgetProposalRequestObjectAsync()
        {
            // Snippet: MutateAccountBudgetProposalAsync(MutateAccountBudgetProposalRequest, CallSettings)
            // Additional: MutateAccountBudgetProposalAsync(MutateAccountBudgetProposalRequest, CancellationToken)
            // Create client
            AccountBudgetProposalServiceClient accountBudgetProposalServiceClient = await AccountBudgetProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateAccountBudgetProposalRequest request = new MutateAccountBudgetProposalRequest
            {
                CustomerId = "",
                Operation = new AccountBudgetProposalOperation(),
                ValidateOnly = false,
            };
            // Make the request
            MutateAccountBudgetProposalResponse response = await accountBudgetProposalServiceClient.MutateAccountBudgetProposalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateAccountBudgetProposal</summary>
        public void MutateAccountBudgetProposal()
        {
            // Snippet: MutateAccountBudgetProposal(string, AccountBudgetProposalOperation, CallSettings)
            // Create client
            AccountBudgetProposalServiceClient accountBudgetProposalServiceClient = AccountBudgetProposalServiceClient.Create();
            // Initialize request argument(s)
            string customerId = "";
            AccountBudgetProposalOperation operation = new AccountBudgetProposalOperation();
            // Make the request
            MutateAccountBudgetProposalResponse response = accountBudgetProposalServiceClient.MutateAccountBudgetProposal(customerId, operation);
            // End snippet
        }

        /// <summary>Snippet for MutateAccountBudgetProposalAsync</summary>
        public async Task MutateAccountBudgetProposalAsync()
        {
            // Snippet: MutateAccountBudgetProposalAsync(string, AccountBudgetProposalOperation, CallSettings)
            // Additional: MutateAccountBudgetProposalAsync(string, AccountBudgetProposalOperation, CancellationToken)
            // Create client
            AccountBudgetProposalServiceClient accountBudgetProposalServiceClient = await AccountBudgetProposalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string customerId = "";
            AccountBudgetProposalOperation operation = new AccountBudgetProposalOperation();
            // Make the request
            MutateAccountBudgetProposalResponse response = await accountBudgetProposalServiceClient.MutateAccountBudgetProposalAsync(customerId, operation);
            // End snippet
        }
    }
}
