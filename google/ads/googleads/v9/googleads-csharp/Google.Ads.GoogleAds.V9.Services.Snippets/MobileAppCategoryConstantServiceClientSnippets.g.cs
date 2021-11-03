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
    public sealed class GeneratedMobileAppCategoryConstantServiceClientSnippets
    {
        /// <summary>Snippet for GetMobileAppCategoryConstant</summary>
        public void GetMobileAppCategoryConstantRequestObject()
        {
            // Snippet: GetMobileAppCategoryConstant(GetMobileAppCategoryConstantRequest, CallSettings)
            // Create client
            MobileAppCategoryConstantServiceClient mobileAppCategoryConstantServiceClient = MobileAppCategoryConstantServiceClient.Create();
            // Initialize request argument(s)
            GetMobileAppCategoryConstantRequest request = new GetMobileAppCategoryConstantRequest
            {
                ResourceNameAsMobileAppCategoryConstantName = MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
            };
            // Make the request
            MobileAppCategoryConstant response = mobileAppCategoryConstantServiceClient.GetMobileAppCategoryConstant(request);
            // End snippet
        }

        /// <summary>Snippet for GetMobileAppCategoryConstantAsync</summary>
        public async Task GetMobileAppCategoryConstantRequestObjectAsync()
        {
            // Snippet: GetMobileAppCategoryConstantAsync(GetMobileAppCategoryConstantRequest, CallSettings)
            // Additional: GetMobileAppCategoryConstantAsync(GetMobileAppCategoryConstantRequest, CancellationToken)
            // Create client
            MobileAppCategoryConstantServiceClient mobileAppCategoryConstantServiceClient = await MobileAppCategoryConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMobileAppCategoryConstantRequest request = new GetMobileAppCategoryConstantRequest
            {
                ResourceNameAsMobileAppCategoryConstantName = MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
            };
            // Make the request
            MobileAppCategoryConstant response = await mobileAppCategoryConstantServiceClient.GetMobileAppCategoryConstantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMobileAppCategoryConstant</summary>
        public void GetMobileAppCategoryConstant()
        {
            // Snippet: GetMobileAppCategoryConstant(string, CallSettings)
            // Create client
            MobileAppCategoryConstantServiceClient mobileAppCategoryConstantServiceClient = MobileAppCategoryConstantServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "mobileAppCategoryConstants/[MOBILE_APP_CATEGORY_ID]";
            // Make the request
            MobileAppCategoryConstant response = mobileAppCategoryConstantServiceClient.GetMobileAppCategoryConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetMobileAppCategoryConstantAsync</summary>
        public async Task GetMobileAppCategoryConstantAsync()
        {
            // Snippet: GetMobileAppCategoryConstantAsync(string, CallSettings)
            // Additional: GetMobileAppCategoryConstantAsync(string, CancellationToken)
            // Create client
            MobileAppCategoryConstantServiceClient mobileAppCategoryConstantServiceClient = await MobileAppCategoryConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "mobileAppCategoryConstants/[MOBILE_APP_CATEGORY_ID]";
            // Make the request
            MobileAppCategoryConstant response = await mobileAppCategoryConstantServiceClient.GetMobileAppCategoryConstantAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetMobileAppCategoryConstant</summary>
        public void GetMobileAppCategoryConstantResourceNames()
        {
            // Snippet: GetMobileAppCategoryConstant(MobileAppCategoryConstantName, CallSettings)
            // Create client
            MobileAppCategoryConstantServiceClient mobileAppCategoryConstantServiceClient = MobileAppCategoryConstantServiceClient.Create();
            // Initialize request argument(s)
            MobileAppCategoryConstantName resourceName = MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]");
            // Make the request
            MobileAppCategoryConstant response = mobileAppCategoryConstantServiceClient.GetMobileAppCategoryConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetMobileAppCategoryConstantAsync</summary>
        public async Task GetMobileAppCategoryConstantResourceNamesAsync()
        {
            // Snippet: GetMobileAppCategoryConstantAsync(MobileAppCategoryConstantName, CallSettings)
            // Additional: GetMobileAppCategoryConstantAsync(MobileAppCategoryConstantName, CancellationToken)
            // Create client
            MobileAppCategoryConstantServiceClient mobileAppCategoryConstantServiceClient = await MobileAppCategoryConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            MobileAppCategoryConstantName resourceName = MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]");
            // Make the request
            MobileAppCategoryConstant response = await mobileAppCategoryConstantServiceClient.GetMobileAppCategoryConstantAsync(resourceName);
            // End snippet
        }
    }
}
