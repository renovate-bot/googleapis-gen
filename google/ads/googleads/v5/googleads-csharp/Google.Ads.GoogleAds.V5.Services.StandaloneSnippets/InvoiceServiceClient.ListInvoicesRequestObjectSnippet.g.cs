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
    using Google.Ads.GoogleAds.V5.Enums;

    public sealed partial class GeneratedInvoiceServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for ListInvoices</summary>
        public void ListInvoicesRequestObject()
        {
            // Snippet: ListInvoices(ListInvoicesRequest, CallSettings)
            // Create client
            InvoiceServiceClient invoiceServiceClient = InvoiceServiceClient.Create();
            // Initialize request argument(s)
            ListInvoicesRequest request = new ListInvoicesRequest
            {
                CustomerId = "",
                BillingSetup = "",
                IssueYear = "",
                IssueMonth = MonthOfYearEnum.Types.MonthOfYear.Unspecified,
            };
            // Make the request
            ListInvoicesResponse response = invoiceServiceClient.ListInvoices(request);
            // End snippet
        }
    }
}
