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

    public sealed partial class GeneratedAccountLinkServiceClientStandaloneSnippets
    {
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
    }
}
