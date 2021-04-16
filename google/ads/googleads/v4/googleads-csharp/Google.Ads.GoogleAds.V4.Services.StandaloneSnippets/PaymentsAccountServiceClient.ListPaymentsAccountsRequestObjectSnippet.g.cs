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

namespace Google.Ads.GoogleAds.V4.Services.Snippets
{
    public sealed partial class GeneratedPaymentsAccountServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for ListPaymentsAccounts</summary>
        public void ListPaymentsAccountsRequestObject()
        {
            // Snippet: ListPaymentsAccounts(ListPaymentsAccountsRequest, CallSettings)
            // Create client
            PaymentsAccountServiceClient paymentsAccountServiceClient = PaymentsAccountServiceClient.Create();
            // Initialize request argument(s)
            ListPaymentsAccountsRequest request = new ListPaymentsAccountsRequest { CustomerId = "", };
            // Make the request
            ListPaymentsAccountsResponse response = paymentsAccountServiceClient.ListPaymentsAccounts(request);
            // End snippet
        }
    }
}
