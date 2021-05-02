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
    public sealed class GeneratedDomainCategoryServiceClientSnippets
    {
        /// <summary>Snippet for GetDomainCategory</summary>
        public void GetDomainCategoryRequestObject()
        {
            // Snippet: GetDomainCategory(GetDomainCategoryRequest, CallSettings)
            // Create client
            DomainCategoryServiceClient domainCategoryServiceClient = DomainCategoryServiceClient.Create();
            // Initialize request argument(s)
            GetDomainCategoryRequest request = new GetDomainCategoryRequest
            {
                ResourceNameAsDomainCategoryName = DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]"),
            };
            // Make the request
            DomainCategory response = domainCategoryServiceClient.GetDomainCategory(request);
            // End snippet
        }

        /// <summary>Snippet for GetDomainCategoryAsync</summary>
        public async Task GetDomainCategoryRequestObjectAsync()
        {
            // Snippet: GetDomainCategoryAsync(GetDomainCategoryRequest, CallSettings)
            // Additional: GetDomainCategoryAsync(GetDomainCategoryRequest, CancellationToken)
            // Create client
            DomainCategoryServiceClient domainCategoryServiceClient = await DomainCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDomainCategoryRequest request = new GetDomainCategoryRequest
            {
                ResourceNameAsDomainCategoryName = DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]"),
            };
            // Make the request
            DomainCategory response = await domainCategoryServiceClient.GetDomainCategoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDomainCategory</summary>
        public void GetDomainCategory()
        {
            // Snippet: GetDomainCategory(string, CallSettings)
            // Create client
            DomainCategoryServiceClient domainCategoryServiceClient = DomainCategoryServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/domainCategories/[CAMPAIGN_ID]~[BASE64_CATEGORY]~[LANGUAGE_CODE]";
            // Make the request
            DomainCategory response = domainCategoryServiceClient.GetDomainCategory(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDomainCategoryAsync</summary>
        public async Task GetDomainCategoryAsync()
        {
            // Snippet: GetDomainCategoryAsync(string, CallSettings)
            // Additional: GetDomainCategoryAsync(string, CancellationToken)
            // Create client
            DomainCategoryServiceClient domainCategoryServiceClient = await DomainCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/domainCategories/[CAMPAIGN_ID]~[BASE64_CATEGORY]~[LANGUAGE_CODE]";
            // Make the request
            DomainCategory response = await domainCategoryServiceClient.GetDomainCategoryAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDomainCategory</summary>
        public void GetDomainCategoryResourceNames()
        {
            // Snippet: GetDomainCategory(DomainCategoryName, CallSettings)
            // Create client
            DomainCategoryServiceClient domainCategoryServiceClient = DomainCategoryServiceClient.Create();
            // Initialize request argument(s)
            DomainCategoryName resourceName = DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]");
            // Make the request
            DomainCategory response = domainCategoryServiceClient.GetDomainCategory(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetDomainCategoryAsync</summary>
        public async Task GetDomainCategoryResourceNamesAsync()
        {
            // Snippet: GetDomainCategoryAsync(DomainCategoryName, CallSettings)
            // Additional: GetDomainCategoryAsync(DomainCategoryName, CancellationToken)
            // Create client
            DomainCategoryServiceClient domainCategoryServiceClient = await DomainCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            DomainCategoryName resourceName = DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]");
            // Make the request
            DomainCategory response = await domainCategoryServiceClient.GetDomainCategoryAsync(resourceName);
            // End snippet
        }
    }
}
