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
    using System.Threading.Tasks;

    public sealed partial class GeneratedAccountBudgetProposalServiceClientStandaloneSnippets
    {
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
    }
}
