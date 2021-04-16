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
    public sealed class GeneratedLanguageConstantServiceClientSnippets
    {
        /// <summary>Snippet for GetLanguageConstant</summary>
        public void GetLanguageConstantRequestObject()
        {
            // Snippet: GetLanguageConstant(GetLanguageConstantRequest, CallSettings)
            // Create client
            LanguageConstantServiceClient languageConstantServiceClient = LanguageConstantServiceClient.Create();
            // Initialize request argument(s)
            GetLanguageConstantRequest request = new GetLanguageConstantRequest
            {
                ResourceNameAsLanguageConstantName = LanguageConstantName.FromCriterion("[CRITERION_ID]"),
            };
            // Make the request
            LanguageConstant response = languageConstantServiceClient.GetLanguageConstant(request);
            // End snippet
        }

        /// <summary>Snippet for GetLanguageConstantAsync</summary>
        public async Task GetLanguageConstantRequestObjectAsync()
        {
            // Snippet: GetLanguageConstantAsync(GetLanguageConstantRequest, CallSettings)
            // Additional: GetLanguageConstantAsync(GetLanguageConstantRequest, CancellationToken)
            // Create client
            LanguageConstantServiceClient languageConstantServiceClient = await LanguageConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLanguageConstantRequest request = new GetLanguageConstantRequest
            {
                ResourceNameAsLanguageConstantName = LanguageConstantName.FromCriterion("[CRITERION_ID]"),
            };
            // Make the request
            LanguageConstant response = await languageConstantServiceClient.GetLanguageConstantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLanguageConstant</summary>
        public void GetLanguageConstant()
        {
            // Snippet: GetLanguageConstant(string, CallSettings)
            // Create client
            LanguageConstantServiceClient languageConstantServiceClient = LanguageConstantServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "languageConstants/[CRITERION_ID]";
            // Make the request
            LanguageConstant response = languageConstantServiceClient.GetLanguageConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetLanguageConstantAsync</summary>
        public async Task GetLanguageConstantAsync()
        {
            // Snippet: GetLanguageConstantAsync(string, CallSettings)
            // Additional: GetLanguageConstantAsync(string, CancellationToken)
            // Create client
            LanguageConstantServiceClient languageConstantServiceClient = await LanguageConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "languageConstants/[CRITERION_ID]";
            // Make the request
            LanguageConstant response = await languageConstantServiceClient.GetLanguageConstantAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetLanguageConstant</summary>
        public void GetLanguageConstantResourceNames()
        {
            // Snippet: GetLanguageConstant(LanguageConstantName, CallSettings)
            // Create client
            LanguageConstantServiceClient languageConstantServiceClient = LanguageConstantServiceClient.Create();
            // Initialize request argument(s)
            LanguageConstantName resourceName = LanguageConstantName.FromCriterion("[CRITERION_ID]");
            // Make the request
            LanguageConstant response = languageConstantServiceClient.GetLanguageConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetLanguageConstantAsync</summary>
        public async Task GetLanguageConstantResourceNamesAsync()
        {
            // Snippet: GetLanguageConstantAsync(LanguageConstantName, CallSettings)
            // Additional: GetLanguageConstantAsync(LanguageConstantName, CancellationToken)
            // Create client
            LanguageConstantServiceClient languageConstantServiceClient = await LanguageConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            LanguageConstantName resourceName = LanguageConstantName.FromCriterion("[CRITERION_ID]");
            // Make the request
            LanguageConstant response = await languageConstantServiceClient.GetLanguageConstantAsync(resourceName);
            // End snippet
        }
    }
}
