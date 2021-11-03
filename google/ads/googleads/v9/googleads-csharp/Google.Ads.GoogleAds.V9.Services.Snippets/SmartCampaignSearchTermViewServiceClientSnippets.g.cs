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
    public sealed class GeneratedSmartCampaignSearchTermViewServiceClientSnippets
    {
        /// <summary>Snippet for GetSmartCampaignSearchTermView</summary>
        public void GetSmartCampaignSearchTermViewRequestObject()
        {
            // Snippet: GetSmartCampaignSearchTermView(GetSmartCampaignSearchTermViewRequest, CallSettings)
            // Create client
            SmartCampaignSearchTermViewServiceClient smartCampaignSearchTermViewServiceClient = SmartCampaignSearchTermViewServiceClient.Create();
            // Initialize request argument(s)
            GetSmartCampaignSearchTermViewRequest request = new GetSmartCampaignSearchTermViewRequest
            {
                ResourceNameAsSmartCampaignSearchTermViewName = SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]"),
            };
            // Make the request
            SmartCampaignSearchTermView response = smartCampaignSearchTermViewServiceClient.GetSmartCampaignSearchTermView(request);
            // End snippet
        }

        /// <summary>Snippet for GetSmartCampaignSearchTermViewAsync</summary>
        public async Task GetSmartCampaignSearchTermViewRequestObjectAsync()
        {
            // Snippet: GetSmartCampaignSearchTermViewAsync(GetSmartCampaignSearchTermViewRequest, CallSettings)
            // Additional: GetSmartCampaignSearchTermViewAsync(GetSmartCampaignSearchTermViewRequest, CancellationToken)
            // Create client
            SmartCampaignSearchTermViewServiceClient smartCampaignSearchTermViewServiceClient = await SmartCampaignSearchTermViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSmartCampaignSearchTermViewRequest request = new GetSmartCampaignSearchTermViewRequest
            {
                ResourceNameAsSmartCampaignSearchTermViewName = SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]"),
            };
            // Make the request
            SmartCampaignSearchTermView response = await smartCampaignSearchTermViewServiceClient.GetSmartCampaignSearchTermViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSmartCampaignSearchTermView</summary>
        public void GetSmartCampaignSearchTermView()
        {
            // Snippet: GetSmartCampaignSearchTermView(string, CallSettings)
            // Create client
            SmartCampaignSearchTermViewServiceClient smartCampaignSearchTermViewServiceClient = SmartCampaignSearchTermViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/smartCampaignSearchTermViews/[CAMPAIGN_ID]~[QUERY]";
            // Make the request
            SmartCampaignSearchTermView response = smartCampaignSearchTermViewServiceClient.GetSmartCampaignSearchTermView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetSmartCampaignSearchTermViewAsync</summary>
        public async Task GetSmartCampaignSearchTermViewAsync()
        {
            // Snippet: GetSmartCampaignSearchTermViewAsync(string, CallSettings)
            // Additional: GetSmartCampaignSearchTermViewAsync(string, CancellationToken)
            // Create client
            SmartCampaignSearchTermViewServiceClient smartCampaignSearchTermViewServiceClient = await SmartCampaignSearchTermViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/smartCampaignSearchTermViews/[CAMPAIGN_ID]~[QUERY]";
            // Make the request
            SmartCampaignSearchTermView response = await smartCampaignSearchTermViewServiceClient.GetSmartCampaignSearchTermViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetSmartCampaignSearchTermView</summary>
        public void GetSmartCampaignSearchTermViewResourceNames()
        {
            // Snippet: GetSmartCampaignSearchTermView(SmartCampaignSearchTermViewName, CallSettings)
            // Create client
            SmartCampaignSearchTermViewServiceClient smartCampaignSearchTermViewServiceClient = SmartCampaignSearchTermViewServiceClient.Create();
            // Initialize request argument(s)
            SmartCampaignSearchTermViewName resourceName = SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]");
            // Make the request
            SmartCampaignSearchTermView response = smartCampaignSearchTermViewServiceClient.GetSmartCampaignSearchTermView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetSmartCampaignSearchTermViewAsync</summary>
        public async Task GetSmartCampaignSearchTermViewResourceNamesAsync()
        {
            // Snippet: GetSmartCampaignSearchTermViewAsync(SmartCampaignSearchTermViewName, CallSettings)
            // Additional: GetSmartCampaignSearchTermViewAsync(SmartCampaignSearchTermViewName, CancellationToken)
            // Create client
            SmartCampaignSearchTermViewServiceClient smartCampaignSearchTermViewServiceClient = await SmartCampaignSearchTermViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            SmartCampaignSearchTermViewName resourceName = SmartCampaignSearchTermViewName.FromCustomerCampaignQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[QUERY]");
            // Make the request
            SmartCampaignSearchTermView response = await smartCampaignSearchTermViewServiceClient.GetSmartCampaignSearchTermViewAsync(resourceName);
            // End snippet
        }
    }
}
