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
    public sealed class GeneratedSearchTermViewServiceClientSnippets
    {
        /// <summary>Snippet for GetSearchTermView</summary>
        public void GetSearchTermViewRequestObject()
        {
            // Snippet: GetSearchTermView(GetSearchTermViewRequest, CallSettings)
            // Create client
            SearchTermViewServiceClient searchTermViewServiceClient = SearchTermViewServiceClient.Create();
            // Initialize request argument(s)
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = SearchTermViewName.FromCustomerCampaignAdGroupQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[QUERY]"),
            };
            // Make the request
            SearchTermView response = searchTermViewServiceClient.GetSearchTermView(request);
            // End snippet
        }

        /// <summary>Snippet for GetSearchTermViewAsync</summary>
        public async Task GetSearchTermViewRequestObjectAsync()
        {
            // Snippet: GetSearchTermViewAsync(GetSearchTermViewRequest, CallSettings)
            // Additional: GetSearchTermViewAsync(GetSearchTermViewRequest, CancellationToken)
            // Create client
            SearchTermViewServiceClient searchTermViewServiceClient = await SearchTermViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = SearchTermViewName.FromCustomerCampaignAdGroupQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[QUERY]"),
            };
            // Make the request
            SearchTermView response = await searchTermViewServiceClient.GetSearchTermViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSearchTermView</summary>
        public void GetSearchTermView()
        {
            // Snippet: GetSearchTermView(string, CallSettings)
            // Create client
            SearchTermViewServiceClient searchTermViewServiceClient = SearchTermViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/searchTermViews/[CAMPAIGN_ID]~[AD_GROUP_ID]~[QUERY]";
            // Make the request
            SearchTermView response = searchTermViewServiceClient.GetSearchTermView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetSearchTermViewAsync</summary>
        public async Task GetSearchTermViewAsync()
        {
            // Snippet: GetSearchTermViewAsync(string, CallSettings)
            // Additional: GetSearchTermViewAsync(string, CancellationToken)
            // Create client
            SearchTermViewServiceClient searchTermViewServiceClient = await SearchTermViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/searchTermViews/[CAMPAIGN_ID]~[AD_GROUP_ID]~[QUERY]";
            // Make the request
            SearchTermView response = await searchTermViewServiceClient.GetSearchTermViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetSearchTermView</summary>
        public void GetSearchTermViewResourceNames()
        {
            // Snippet: GetSearchTermView(SearchTermViewName, CallSettings)
            // Create client
            SearchTermViewServiceClient searchTermViewServiceClient = SearchTermViewServiceClient.Create();
            // Initialize request argument(s)
            SearchTermViewName resourceName = SearchTermViewName.FromCustomerCampaignAdGroupQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[QUERY]");
            // Make the request
            SearchTermView response = searchTermViewServiceClient.GetSearchTermView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetSearchTermViewAsync</summary>
        public async Task GetSearchTermViewResourceNamesAsync()
        {
            // Snippet: GetSearchTermViewAsync(SearchTermViewName, CallSettings)
            // Additional: GetSearchTermViewAsync(SearchTermViewName, CancellationToken)
            // Create client
            SearchTermViewServiceClient searchTermViewServiceClient = await SearchTermViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchTermViewName resourceName = SearchTermViewName.FromCustomerCampaignAdGroupQuery("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[QUERY]");
            // Make the request
            SearchTermView response = await searchTermViewServiceClient.GetSearchTermViewAsync(resourceName);
            // End snippet
        }
    }
}
