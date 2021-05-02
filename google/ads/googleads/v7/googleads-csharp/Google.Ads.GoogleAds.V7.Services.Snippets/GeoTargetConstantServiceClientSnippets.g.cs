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
    public sealed class GeneratedGeoTargetConstantServiceClientSnippets
    {
        /// <summary>Snippet for GetGeoTargetConstant</summary>
        public void GetGeoTargetConstantRequestObject()
        {
            // Snippet: GetGeoTargetConstant(GetGeoTargetConstantRequest, CallSettings)
            // Create client
            GeoTargetConstantServiceClient geoTargetConstantServiceClient = GeoTargetConstantServiceClient.Create();
            // Initialize request argument(s)
            GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
            };
            // Make the request
            GeoTargetConstant response = geoTargetConstantServiceClient.GetGeoTargetConstant(request);
            // End snippet
        }

        /// <summary>Snippet for GetGeoTargetConstantAsync</summary>
        public async Task GetGeoTargetConstantRequestObjectAsync()
        {
            // Snippet: GetGeoTargetConstantAsync(GetGeoTargetConstantRequest, CallSettings)
            // Additional: GetGeoTargetConstantAsync(GetGeoTargetConstantRequest, CancellationToken)
            // Create client
            GeoTargetConstantServiceClient geoTargetConstantServiceClient = await GeoTargetConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
            };
            // Make the request
            GeoTargetConstant response = await geoTargetConstantServiceClient.GetGeoTargetConstantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGeoTargetConstant</summary>
        public void GetGeoTargetConstant()
        {
            // Snippet: GetGeoTargetConstant(string, CallSettings)
            // Create client
            GeoTargetConstantServiceClient geoTargetConstantServiceClient = GeoTargetConstantServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "geoTargetConstants/[CRITERION_ID]";
            // Make the request
            GeoTargetConstant response = geoTargetConstantServiceClient.GetGeoTargetConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetGeoTargetConstantAsync</summary>
        public async Task GetGeoTargetConstantAsync()
        {
            // Snippet: GetGeoTargetConstantAsync(string, CallSettings)
            // Additional: GetGeoTargetConstantAsync(string, CancellationToken)
            // Create client
            GeoTargetConstantServiceClient geoTargetConstantServiceClient = await GeoTargetConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "geoTargetConstants/[CRITERION_ID]";
            // Make the request
            GeoTargetConstant response = await geoTargetConstantServiceClient.GetGeoTargetConstantAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetGeoTargetConstant</summary>
        public void GetGeoTargetConstantResourceNames()
        {
            // Snippet: GetGeoTargetConstant(GeoTargetConstantName, CallSettings)
            // Create client
            GeoTargetConstantServiceClient geoTargetConstantServiceClient = GeoTargetConstantServiceClient.Create();
            // Initialize request argument(s)
            GeoTargetConstantName resourceName = GeoTargetConstantName.FromCriterion("[CRITERION_ID]");
            // Make the request
            GeoTargetConstant response = geoTargetConstantServiceClient.GetGeoTargetConstant(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetGeoTargetConstantAsync</summary>
        public async Task GetGeoTargetConstantResourceNamesAsync()
        {
            // Snippet: GetGeoTargetConstantAsync(GeoTargetConstantName, CallSettings)
            // Additional: GetGeoTargetConstantAsync(GeoTargetConstantName, CancellationToken)
            // Create client
            GeoTargetConstantServiceClient geoTargetConstantServiceClient = await GeoTargetConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            GeoTargetConstantName resourceName = GeoTargetConstantName.FromCriterion("[CRITERION_ID]");
            // Make the request
            GeoTargetConstant response = await geoTargetConstantServiceClient.GetGeoTargetConstantAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for SuggestGeoTargetConstants</summary>
        public void SuggestGeoTargetConstantsRequestObject()
        {
            // Snippet: SuggestGeoTargetConstants(SuggestGeoTargetConstantsRequest, CallSettings)
            // Create client
            GeoTargetConstantServiceClient geoTargetConstantServiceClient = GeoTargetConstantServiceClient.Create();
            // Initialize request argument(s)
            SuggestGeoTargetConstantsRequest request = new SuggestGeoTargetConstantsRequest
            {
                LocationNames = new SuggestGeoTargetConstantsRequest.Types.LocationNames(),
                Locale = "",
                CountryCode = "",
            };
            // Make the request
            SuggestGeoTargetConstantsResponse response = geoTargetConstantServiceClient.SuggestGeoTargetConstants(request);
            // End snippet
        }

        /// <summary>Snippet for SuggestGeoTargetConstantsAsync</summary>
        public async Task SuggestGeoTargetConstantsRequestObjectAsync()
        {
            // Snippet: SuggestGeoTargetConstantsAsync(SuggestGeoTargetConstantsRequest, CallSettings)
            // Additional: SuggestGeoTargetConstantsAsync(SuggestGeoTargetConstantsRequest, CancellationToken)
            // Create client
            GeoTargetConstantServiceClient geoTargetConstantServiceClient = await GeoTargetConstantServiceClient.CreateAsync();
            // Initialize request argument(s)
            SuggestGeoTargetConstantsRequest request = new SuggestGeoTargetConstantsRequest
            {
                LocationNames = new SuggestGeoTargetConstantsRequest.Types.LocationNames(),
                Locale = "",
                CountryCode = "",
            };
            // Make the request
            SuggestGeoTargetConstantsResponse response = await geoTargetConstantServiceClient.SuggestGeoTargetConstantsAsync(request);
            // End snippet
        }
    }
}
