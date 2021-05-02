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
    using Google.Ads.GoogleAds.V7.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedPaidOrganicSearchTermViewServiceClientSnippets
    {
        /// <summary>Snippet for GetPaidOrganicSearchTermView</summary>
        public void GetPaidOrganicSearchTermViewRequestObject()
        {
            // Snippet: GetPaidOrganicSearchTermView(GetPaidOrganicSearchTermViewRequest, CallSettings)
            // Create client
            PaidOrganicSearchTermViewServiceClient paidOrganicSearchTermViewServiceClient = PaidOrganicSearchTermViewServiceClient.Create();
            // Initialize request argument(s)
            GetPaidOrganicSearchTermViewRequest request = new GetPaidOrganicSearchTermViewRequest
            {
                ResourceNameAsPaidOrganicSearchTermViewName = PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]"),
            };
            // Make the request
            PaidOrganicSearchTermView response = paidOrganicSearchTermViewServiceClient.GetPaidOrganicSearchTermView(request);
            // End snippet
        }

        /// <summary>Snippet for GetPaidOrganicSearchTermViewAsync</summary>
        public async Task GetPaidOrganicSearchTermViewRequestObjectAsync()
        {
            // Snippet: GetPaidOrganicSearchTermViewAsync(GetPaidOrganicSearchTermViewRequest, CallSettings)
            // Additional: GetPaidOrganicSearchTermViewAsync(GetPaidOrganicSearchTermViewRequest, CancellationToken)
            // Create client
            PaidOrganicSearchTermViewServiceClient paidOrganicSearchTermViewServiceClient = await PaidOrganicSearchTermViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPaidOrganicSearchTermViewRequest request = new GetPaidOrganicSearchTermViewRequest
            {
                ResourceNameAsPaidOrganicSearchTermViewName = PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]"),
            };
            // Make the request
            PaidOrganicSearchTermView response = await paidOrganicSearchTermViewServiceClient.GetPaidOrganicSearchTermViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPaidOrganicSearchTermView</summary>
        public void GetPaidOrganicSearchTermView()
        {
            // Snippet: GetPaidOrganicSearchTermView(string, CallSettings)
            // Create client
            PaidOrganicSearchTermViewServiceClient paidOrganicSearchTermViewServiceClient = PaidOrganicSearchTermViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/paidOrganicSearchTermViews/[CAMPAIGN_ID]~[AD_GROUP_ID]~[BASE64_SEARCH_TERM]";
            // Make the request
            PaidOrganicSearchTermView response = paidOrganicSearchTermViewServiceClient.GetPaidOrganicSearchTermView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetPaidOrganicSearchTermViewAsync</summary>
        public async Task GetPaidOrganicSearchTermViewAsync()
        {
            // Snippet: GetPaidOrganicSearchTermViewAsync(string, CallSettings)
            // Additional: GetPaidOrganicSearchTermViewAsync(string, CancellationToken)
            // Create client
            PaidOrganicSearchTermViewServiceClient paidOrganicSearchTermViewServiceClient = await PaidOrganicSearchTermViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/paidOrganicSearchTermViews/[CAMPAIGN_ID]~[AD_GROUP_ID]~[BASE64_SEARCH_TERM]";
            // Make the request
            PaidOrganicSearchTermView response = await paidOrganicSearchTermViewServiceClient.GetPaidOrganicSearchTermViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetPaidOrganicSearchTermView</summary>
        public void GetPaidOrganicSearchTermViewResourceNames()
        {
            // Snippet: GetPaidOrganicSearchTermView(PaidOrganicSearchTermViewName, CallSettings)
            // Create client
            PaidOrganicSearchTermViewServiceClient paidOrganicSearchTermViewServiceClient = PaidOrganicSearchTermViewServiceClient.Create();
            // Initialize request argument(s)
            PaidOrganicSearchTermViewName resourceName = PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]");
            // Make the request
            PaidOrganicSearchTermView response = paidOrganicSearchTermViewServiceClient.GetPaidOrganicSearchTermView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetPaidOrganicSearchTermViewAsync</summary>
        public async Task GetPaidOrganicSearchTermViewResourceNamesAsync()
        {
            // Snippet: GetPaidOrganicSearchTermViewAsync(PaidOrganicSearchTermViewName, CallSettings)
            // Additional: GetPaidOrganicSearchTermViewAsync(PaidOrganicSearchTermViewName, CancellationToken)
            // Create client
            PaidOrganicSearchTermViewServiceClient paidOrganicSearchTermViewServiceClient = await PaidOrganicSearchTermViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            PaidOrganicSearchTermViewName resourceName = PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]");
            // Make the request
            PaidOrganicSearchTermView response = await paidOrganicSearchTermViewServiceClient.GetPaidOrganicSearchTermViewAsync(resourceName);
            // End snippet
        }
    }
}
