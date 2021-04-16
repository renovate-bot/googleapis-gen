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
    public sealed class GeneratedMobileDeviceConstantServiceClientSnippets
    {
        /// <summary>Snippet for GetMobileDeviceConstant</summary>
        public void GetMobileDeviceConstantRequestObject()
        {
            // Snippet: GetMobileDeviceConstant(GetMobileDeviceConstantRequest, CallSettings)
            // Create client
            MobileDeviceConstantServiceClient mobileDeviceConstantServiceClient = MobileDeviceConstantServiceClient.Create();
            // Initialize request argument(s)
            GetMobileDeviceConstantRequest request = new GetMobileDeviceConstantRequest
            {
                ResourceNameAsMobileDeviceConstantName = MobileDeviceConstantName.FromCriterion("[CRITERION_ID]"),
            };
            // Make the request
            MobileDeviceConstant response = mobileDeviceConstantServiceClient.GetMobileDeviceConstant(request);
            // End snippet
        }

        /// <summary>Snippet for GetMobileDeviceConstantAsync</summary>
        public async Task GetMobileDeviceConstantRequestObjectAsync()
        {
            // Snippet: GetMobileDeviceConstantAsync(GetMobileDeviceConstantRequest, CallSettings)
            // Additional: GetMobileDeviceConstantAsync(GetMobileDeviceConstantRequest, CancellationToken)
            // Create client
            MobileDeviceConstantServiceClient mobileDeviceConstantServiceClient = await MobileDeviceConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMobileDeviceConstantRequest request = new GetMobileDeviceConstantRequest
            {
                ResourceNameAsMobileDeviceConstantName = MobileDeviceConstantName.FromCriterion("[CRITERION_ID]"),
            };
            // Make the request
            MobileDeviceConstant response = await mobileDeviceConstantServiceClient.GetMobileDeviceConstantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMobileDeviceConstant</summary>
        public void GetMobileDeviceConstant()
        {
            // Snippet: GetMobileDeviceConstant(string, CallSettings)
            // Create client
            MobileDeviceConstantServiceClient mobileDeviceConstantServiceClient = MobileDeviceConstantServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "mobileDeviceConstants/[CRITERION_ID]";
            // Make the request
            MobileDeviceConstant response = mobileDeviceConstantServiceClient.GetMobileDeviceConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetMobileDeviceConstantAsync</summary>
        public async Task GetMobileDeviceConstantAsync()
        {
            // Snippet: GetMobileDeviceConstantAsync(string, CallSettings)
            // Additional: GetMobileDeviceConstantAsync(string, CancellationToken)
            // Create client
            MobileDeviceConstantServiceClient mobileDeviceConstantServiceClient = await MobileDeviceConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "mobileDeviceConstants/[CRITERION_ID]";
            // Make the request
            MobileDeviceConstant response = await mobileDeviceConstantServiceClient.GetMobileDeviceConstantAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetMobileDeviceConstant</summary>
        public void GetMobileDeviceConstantResourceNames()
        {
            // Snippet: GetMobileDeviceConstant(MobileDeviceConstantName, CallSettings)
            // Create client
            MobileDeviceConstantServiceClient mobileDeviceConstantServiceClient = MobileDeviceConstantServiceClient.Create();
            // Initialize request argument(s)
            MobileDeviceConstantName resourceName = MobileDeviceConstantName.FromCriterion("[CRITERION_ID]");
            // Make the request
            MobileDeviceConstant response = mobileDeviceConstantServiceClient.GetMobileDeviceConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetMobileDeviceConstantAsync</summary>
        public async Task GetMobileDeviceConstantResourceNamesAsync()
        {
            // Snippet: GetMobileDeviceConstantAsync(MobileDeviceConstantName, CallSettings)
            // Additional: GetMobileDeviceConstantAsync(MobileDeviceConstantName, CancellationToken)
            // Create client
            MobileDeviceConstantServiceClient mobileDeviceConstantServiceClient = await MobileDeviceConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            MobileDeviceConstantName resourceName = MobileDeviceConstantName.FromCriterion("[CRITERION_ID]");
            // Make the request
            MobileDeviceConstant response = await mobileDeviceConstantServiceClient.GetMobileDeviceConstantAsync(resourceName);
            // End snippet
        }
    }
}
