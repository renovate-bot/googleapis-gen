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

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedThirdPartyAppAnalyticsLinkServiceClientSnippets
    {
        /// <summary>Snippet for GetThirdPartyAppAnalyticsLink</summary>
        public void GetThirdPartyAppAnalyticsLinkRequestObject()
        {
            // Snippet: GetThirdPartyAppAnalyticsLink(GetThirdPartyAppAnalyticsLinkRequest, CallSettings)
            // Create client
            ThirdPartyAppAnalyticsLinkServiceClient thirdPartyAppAnalyticsLinkServiceClient = ThirdPartyAppAnalyticsLinkServiceClient.Create();
            // Initialize request argument(s)
            GetThirdPartyAppAnalyticsLinkRequest request = new GetThirdPartyAppAnalyticsLinkRequest
            {
                ResourceNameAsThirdPartyAppAnalyticsLinkName = ThirdPartyAppAnalyticsLinkName.FromCustomerCustomerLink("[CUSTOMER_ID]", "[CUSTOMER_LINK_ID]"),
            };
            // Make the request
            ThirdPartyAppAnalyticsLink response = thirdPartyAppAnalyticsLinkServiceClient.GetThirdPartyAppAnalyticsLink(request);
            // End snippet
        }

        /// <summary>Snippet for GetThirdPartyAppAnalyticsLinkAsync</summary>
        public async Task GetThirdPartyAppAnalyticsLinkRequestObjectAsync()
        {
            // Snippet: GetThirdPartyAppAnalyticsLinkAsync(GetThirdPartyAppAnalyticsLinkRequest, CallSettings)
            // Additional: GetThirdPartyAppAnalyticsLinkAsync(GetThirdPartyAppAnalyticsLinkRequest, CancellationToken)
            // Create client
            ThirdPartyAppAnalyticsLinkServiceClient thirdPartyAppAnalyticsLinkServiceClient = await ThirdPartyAppAnalyticsLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetThirdPartyAppAnalyticsLinkRequest request = new GetThirdPartyAppAnalyticsLinkRequest
            {
                ResourceNameAsThirdPartyAppAnalyticsLinkName = ThirdPartyAppAnalyticsLinkName.FromCustomerCustomerLink("[CUSTOMER_ID]", "[CUSTOMER_LINK_ID]"),
            };
            // Make the request
            ThirdPartyAppAnalyticsLink response = await thirdPartyAppAnalyticsLinkServiceClient.GetThirdPartyAppAnalyticsLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RegenerateShareableLinkId</summary>
        public void RegenerateShareableLinkIdRequestObject()
        {
            // Snippet: RegenerateShareableLinkId(RegenerateShareableLinkIdRequest, CallSettings)
            // Create client
            ThirdPartyAppAnalyticsLinkServiceClient thirdPartyAppAnalyticsLinkServiceClient = ThirdPartyAppAnalyticsLinkServiceClient.Create();
            // Initialize request argument(s)
            RegenerateShareableLinkIdRequest request = new RegenerateShareableLinkIdRequest
            {
                ResourceNameAsThirdPartyAppAnalyticsLinkName = ThirdPartyAppAnalyticsLinkName.FromCustomerCustomerLink("[CUSTOMER_ID]", "[CUSTOMER_LINK_ID]"),
            };
            // Make the request
            RegenerateShareableLinkIdResponse response = thirdPartyAppAnalyticsLinkServiceClient.RegenerateShareableLinkId(request);
            // End snippet
        }

        /// <summary>Snippet for RegenerateShareableLinkIdAsync</summary>
        public async Task RegenerateShareableLinkIdRequestObjectAsync()
        {
            // Snippet: RegenerateShareableLinkIdAsync(RegenerateShareableLinkIdRequest, CallSettings)
            // Additional: RegenerateShareableLinkIdAsync(RegenerateShareableLinkIdRequest, CancellationToken)
            // Create client
            ThirdPartyAppAnalyticsLinkServiceClient thirdPartyAppAnalyticsLinkServiceClient = await ThirdPartyAppAnalyticsLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            RegenerateShareableLinkIdRequest request = new RegenerateShareableLinkIdRequest
            {
                ResourceNameAsThirdPartyAppAnalyticsLinkName = ThirdPartyAppAnalyticsLinkName.FromCustomerCustomerLink("[CUSTOMER_ID]", "[CUSTOMER_LINK_ID]"),
            };
            // Make the request
            RegenerateShareableLinkIdResponse response = await thirdPartyAppAnalyticsLinkServiceClient.RegenerateShareableLinkIdAsync(request);
            // End snippet
        }
    }
}
