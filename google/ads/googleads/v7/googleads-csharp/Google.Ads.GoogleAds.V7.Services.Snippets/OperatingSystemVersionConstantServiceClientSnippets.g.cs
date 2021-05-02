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
    public sealed class GeneratedOperatingSystemVersionConstantServiceClientSnippets
    {
        /// <summary>Snippet for GetOperatingSystemVersionConstant</summary>
        public void GetOperatingSystemVersionConstantRequestObject()
        {
            // Snippet: GetOperatingSystemVersionConstant(GetOperatingSystemVersionConstantRequest, CallSettings)
            // Create client
            OperatingSystemVersionConstantServiceClient operatingSystemVersionConstantServiceClient = OperatingSystemVersionConstantServiceClient.Create();
            // Initialize request argument(s)
            GetOperatingSystemVersionConstantRequest request = new GetOperatingSystemVersionConstantRequest
            {
                ResourceNameAsOperatingSystemVersionConstantName = OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
            };
            // Make the request
            OperatingSystemVersionConstant response = operatingSystemVersionConstantServiceClient.GetOperatingSystemVersionConstant(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperatingSystemVersionConstantAsync</summary>
        public async Task GetOperatingSystemVersionConstantRequestObjectAsync()
        {
            // Snippet: GetOperatingSystemVersionConstantAsync(GetOperatingSystemVersionConstantRequest, CallSettings)
            // Additional: GetOperatingSystemVersionConstantAsync(GetOperatingSystemVersionConstantRequest, CancellationToken)
            // Create client
            OperatingSystemVersionConstantServiceClient operatingSystemVersionConstantServiceClient = await OperatingSystemVersionConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetOperatingSystemVersionConstantRequest request = new GetOperatingSystemVersionConstantRequest
            {
                ResourceNameAsOperatingSystemVersionConstantName = OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
            };
            // Make the request
            OperatingSystemVersionConstant response = await operatingSystemVersionConstantServiceClient.GetOperatingSystemVersionConstantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperatingSystemVersionConstant</summary>
        public void GetOperatingSystemVersionConstant()
        {
            // Snippet: GetOperatingSystemVersionConstant(string, CallSettings)
            // Create client
            OperatingSystemVersionConstantServiceClient operatingSystemVersionConstantServiceClient = OperatingSystemVersionConstantServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "operatingSystemVersionConstants/[CRITERION_ID]";
            // Make the request
            OperatingSystemVersionConstant response = operatingSystemVersionConstantServiceClient.GetOperatingSystemVersionConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetOperatingSystemVersionConstantAsync</summary>
        public async Task GetOperatingSystemVersionConstantAsync()
        {
            // Snippet: GetOperatingSystemVersionConstantAsync(string, CallSettings)
            // Additional: GetOperatingSystemVersionConstantAsync(string, CancellationToken)
            // Create client
            OperatingSystemVersionConstantServiceClient operatingSystemVersionConstantServiceClient = await OperatingSystemVersionConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "operatingSystemVersionConstants/[CRITERION_ID]";
            // Make the request
            OperatingSystemVersionConstant response = await operatingSystemVersionConstantServiceClient.GetOperatingSystemVersionConstantAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetOperatingSystemVersionConstant</summary>
        public void GetOperatingSystemVersionConstantResourceNames()
        {
            // Snippet: GetOperatingSystemVersionConstant(OperatingSystemVersionConstantName, CallSettings)
            // Create client
            OperatingSystemVersionConstantServiceClient operatingSystemVersionConstantServiceClient = OperatingSystemVersionConstantServiceClient.Create();
            // Initialize request argument(s)
            OperatingSystemVersionConstantName resourceName = OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]");
            // Make the request
            OperatingSystemVersionConstant response = operatingSystemVersionConstantServiceClient.GetOperatingSystemVersionConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetOperatingSystemVersionConstantAsync</summary>
        public async Task GetOperatingSystemVersionConstantResourceNamesAsync()
        {
            // Snippet: GetOperatingSystemVersionConstantAsync(OperatingSystemVersionConstantName, CallSettings)
            // Additional: GetOperatingSystemVersionConstantAsync(OperatingSystemVersionConstantName, CancellationToken)
            // Create client
            OperatingSystemVersionConstantServiceClient operatingSystemVersionConstantServiceClient = await OperatingSystemVersionConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            OperatingSystemVersionConstantName resourceName = OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]");
            // Make the request
            OperatingSystemVersionConstant response = await operatingSystemVersionConstantServiceClient.GetOperatingSystemVersionConstantAsync(resourceName);
            // End snippet
        }
    }
}
