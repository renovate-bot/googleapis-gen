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
    public sealed class GeneratedCarrierConstantServiceClientSnippets
    {
        /// <summary>Snippet for GetCarrierConstant</summary>
        public void GetCarrierConstantRequestObject()
        {
            // Snippet: GetCarrierConstant(GetCarrierConstantRequest, CallSettings)
            // Create client
            CarrierConstantServiceClient carrierConstantServiceClient = CarrierConstantServiceClient.Create();
            // Initialize request argument(s)
            GetCarrierConstantRequest request = new GetCarrierConstantRequest
            {
                ResourceNameAsCarrierConstantName = CarrierConstantName.FromCriterion("[CRITERION_ID]"),
            };
            // Make the request
            CarrierConstant response = carrierConstantServiceClient.GetCarrierConstant(request);
            // End snippet
        }

        /// <summary>Snippet for GetCarrierConstantAsync</summary>
        public async Task GetCarrierConstantRequestObjectAsync()
        {
            // Snippet: GetCarrierConstantAsync(GetCarrierConstantRequest, CallSettings)
            // Additional: GetCarrierConstantAsync(GetCarrierConstantRequest, CancellationToken)
            // Create client
            CarrierConstantServiceClient carrierConstantServiceClient = await CarrierConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCarrierConstantRequest request = new GetCarrierConstantRequest
            {
                ResourceNameAsCarrierConstantName = CarrierConstantName.FromCriterion("[CRITERION_ID]"),
            };
            // Make the request
            CarrierConstant response = await carrierConstantServiceClient.GetCarrierConstantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCarrierConstant</summary>
        public void GetCarrierConstant()
        {
            // Snippet: GetCarrierConstant(string, CallSettings)
            // Create client
            CarrierConstantServiceClient carrierConstantServiceClient = CarrierConstantServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "carrierConstants/[CRITERION_ID]";
            // Make the request
            CarrierConstant response = carrierConstantServiceClient.GetCarrierConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCarrierConstantAsync</summary>
        public async Task GetCarrierConstantAsync()
        {
            // Snippet: GetCarrierConstantAsync(string, CallSettings)
            // Additional: GetCarrierConstantAsync(string, CancellationToken)
            // Create client
            CarrierConstantServiceClient carrierConstantServiceClient = await CarrierConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "carrierConstants/[CRITERION_ID]";
            // Make the request
            CarrierConstant response = await carrierConstantServiceClient.GetCarrierConstantAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCarrierConstant</summary>
        public void GetCarrierConstantResourceNames()
        {
            // Snippet: GetCarrierConstant(CarrierConstantName, CallSettings)
            // Create client
            CarrierConstantServiceClient carrierConstantServiceClient = CarrierConstantServiceClient.Create();
            // Initialize request argument(s)
            CarrierConstantName resourceName = CarrierConstantName.FromCriterion("[CRITERION_ID]");
            // Make the request
            CarrierConstant response = carrierConstantServiceClient.GetCarrierConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetCarrierConstantAsync</summary>
        public async Task GetCarrierConstantResourceNamesAsync()
        {
            // Snippet: GetCarrierConstantAsync(CarrierConstantName, CallSettings)
            // Additional: GetCarrierConstantAsync(CarrierConstantName, CancellationToken)
            // Create client
            CarrierConstantServiceClient carrierConstantServiceClient = await CarrierConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            CarrierConstantName resourceName = CarrierConstantName.FromCriterion("[CRITERION_ID]");
            // Make the request
            CarrierConstant response = await carrierConstantServiceClient.GetCarrierConstantAsync(resourceName);
            // End snippet
        }
    }
}
