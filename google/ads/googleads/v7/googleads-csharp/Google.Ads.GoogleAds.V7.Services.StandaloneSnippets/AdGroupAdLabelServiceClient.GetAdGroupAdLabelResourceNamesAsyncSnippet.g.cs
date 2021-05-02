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

    public sealed partial class GeneratedAdGroupAdLabelServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetAdGroupAdLabelAsync</summary>
        public async Task GetAdGroupAdLabelResourceNamesAsync()
        {
            // Snippet: GetAdGroupAdLabelAsync(AdGroupAdLabelName, CallSettings)
            // Additional: GetAdGroupAdLabelAsync(AdGroupAdLabelName, CancellationToken)
            // Create client
            AdGroupAdLabelServiceClient adGroupAdLabelServiceClient = await AdGroupAdLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdGroupAdLabelName resourceName = AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[AD_ID]", "[LABEL_ID]");
            // Make the request
            AdGroupAdLabel response = await adGroupAdLabelServiceClient.GetAdGroupAdLabelAsync(resourceName);
            // End snippet
        }
    }
}
