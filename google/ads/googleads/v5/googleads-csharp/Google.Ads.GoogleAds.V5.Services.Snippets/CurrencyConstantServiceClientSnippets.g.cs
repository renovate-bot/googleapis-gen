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

namespace Google.Ads.GoogleAds.V5.Services.Snippets
{
    using Google.Ads.GoogleAds.V5.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCurrencyConstantServiceClientSnippets
    {
        /// <summary>Snippet for GetCurrencyConstant</summary>
        public void GetCurrencyConstantRequestObject()
        {
            // Snippet: GetCurrencyConstant(GetCurrencyConstantRequest, CallSettings)
            // Create client
            CurrencyConstantServiceClient currencyConstantServiceClient = CurrencyConstantServiceClient.Create();
            // Initialize request argument(s)
            GetCurrencyConstantRequest request = new GetCurrencyConstantRequest
            {
                ResourceNameAsCurrencyConstantName = CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
            };
            // Make the request
            CurrencyConstant response = currencyConstantServiceClient.GetCurrencyConstant(request);
            // End snippet
        }

        /// <summary>Snippet for GetCurrencyConstantAsync</summary>
        public async Task GetCurrencyConstantRequestObjectAsync()
        {
            // Snippet: GetCurrencyConstantAsync(GetCurrencyConstantRequest, CallSettings)
            // Additional: GetCurrencyConstantAsync(GetCurrencyConstantRequest, CancellationToken)
            // Create client
            CurrencyConstantServiceClient currencyConstantServiceClient = await CurrencyConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCurrencyConstantRequest request = new GetCurrencyConstantRequest
            {
                ResourceNameAsCurrencyConstantName = CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
            };
            // Make the request
            CurrencyConstant response = await currencyConstantServiceClient.GetCurrencyConstantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCurrencyConstant</summary>
        public void GetCurrencyConstant()
        {
            // Snippet: GetCurrencyConstant(string, CallSettings)
            // Create client
            CurrencyConstantServiceClient currencyConstantServiceClient = CurrencyConstantServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "currencyConstants/[CURRENCY_CONSTANT]";
            // Make the request
            CurrencyConstant response = currencyConstantServiceClient.GetCurrencyConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCurrencyConstantAsync</summary>
        public async Task GetCurrencyConstantAsync()
        {
            // Snippet: GetCurrencyConstantAsync(string, CallSettings)
            // Additional: GetCurrencyConstantAsync(string, CancellationToken)
            // Create client
            CurrencyConstantServiceClient currencyConstantServiceClient = await CurrencyConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "currencyConstants/[CURRENCY_CONSTANT]";
            // Make the request
            CurrencyConstant response = await currencyConstantServiceClient.GetCurrencyConstantAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCurrencyConstant</summary>
        public void GetCurrencyConstantResourceNames()
        {
            // Snippet: GetCurrencyConstant(CurrencyConstantName, CallSettings)
            // Create client
            CurrencyConstantServiceClient currencyConstantServiceClient = CurrencyConstantServiceClient.Create();
            // Initialize request argument(s)
            CurrencyConstantName resourceName = CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]");
            // Make the request
            CurrencyConstant response = currencyConstantServiceClient.GetCurrencyConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCurrencyConstantAsync</summary>
        public async Task GetCurrencyConstantResourceNamesAsync()
        {
            // Snippet: GetCurrencyConstantAsync(CurrencyConstantName, CallSettings)
            // Additional: GetCurrencyConstantAsync(CurrencyConstantName, CancellationToken)
            // Create client
            CurrencyConstantServiceClient currencyConstantServiceClient = await CurrencyConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            CurrencyConstantName resourceName = CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]");
            // Make the request
            CurrencyConstant response = await currencyConstantServiceClient.GetCurrencyConstantAsync(resourceName);
            // End snippet
        }
    }
}
