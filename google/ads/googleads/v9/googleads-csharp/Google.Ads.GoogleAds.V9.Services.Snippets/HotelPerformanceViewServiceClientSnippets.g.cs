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
    public sealed class GeneratedHotelPerformanceViewServiceClientSnippets
    {
        /// <summary>Snippet for GetHotelPerformanceView</summary>
        public void GetHotelPerformanceViewRequestObject()
        {
            // Snippet: GetHotelPerformanceView(GetHotelPerformanceViewRequest, CallSettings)
            // Create client
            HotelPerformanceViewServiceClient hotelPerformanceViewServiceClient = HotelPerformanceViewServiceClient.Create();
            // Initialize request argument(s)
            GetHotelPerformanceViewRequest request = new GetHotelPerformanceViewRequest
            {
                ResourceNameAsHotelPerformanceViewName = HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            // Make the request
            HotelPerformanceView response = hotelPerformanceViewServiceClient.GetHotelPerformanceView(request);
            // End snippet
        }

        /// <summary>Snippet for GetHotelPerformanceViewAsync</summary>
        public async Task GetHotelPerformanceViewRequestObjectAsync()
        {
            // Snippet: GetHotelPerformanceViewAsync(GetHotelPerformanceViewRequest, CallSettings)
            // Additional: GetHotelPerformanceViewAsync(GetHotelPerformanceViewRequest, CancellationToken)
            // Create client
            HotelPerformanceViewServiceClient hotelPerformanceViewServiceClient = await HotelPerformanceViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetHotelPerformanceViewRequest request = new GetHotelPerformanceViewRequest
            {
                ResourceNameAsHotelPerformanceViewName = HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            // Make the request
            HotelPerformanceView response = await hotelPerformanceViewServiceClient.GetHotelPerformanceViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHotelPerformanceView</summary>
        public void GetHotelPerformanceView()
        {
            // Snippet: GetHotelPerformanceView(string, CallSettings)
            // Create client
            HotelPerformanceViewServiceClient hotelPerformanceViewServiceClient = HotelPerformanceViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/hotelPerformanceView";
            // Make the request
            HotelPerformanceView response = hotelPerformanceViewServiceClient.GetHotelPerformanceView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetHotelPerformanceViewAsync</summary>
        public async Task GetHotelPerformanceViewAsync()
        {
            // Snippet: GetHotelPerformanceViewAsync(string, CallSettings)
            // Additional: GetHotelPerformanceViewAsync(string, CancellationToken)
            // Create client
            HotelPerformanceViewServiceClient hotelPerformanceViewServiceClient = await HotelPerformanceViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER_ID]/hotelPerformanceView";
            // Make the request
            HotelPerformanceView response = await hotelPerformanceViewServiceClient.GetHotelPerformanceViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetHotelPerformanceView</summary>
        public void GetHotelPerformanceViewResourceNames()
        {
            // Snippet: GetHotelPerformanceView(HotelPerformanceViewName, CallSettings)
            // Create client
            HotelPerformanceViewServiceClient hotelPerformanceViewServiceClient = HotelPerformanceViewServiceClient.Create();
            // Initialize request argument(s)
            HotelPerformanceViewName resourceName = HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]");
            // Make the request
            HotelPerformanceView response = hotelPerformanceViewServiceClient.GetHotelPerformanceView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetHotelPerformanceViewAsync</summary>
        public async Task GetHotelPerformanceViewResourceNamesAsync()
        {
            // Snippet: GetHotelPerformanceViewAsync(HotelPerformanceViewName, CallSettings)
            // Additional: GetHotelPerformanceViewAsync(HotelPerformanceViewName, CancellationToken)
            // Create client
            HotelPerformanceViewServiceClient hotelPerformanceViewServiceClient = await HotelPerformanceViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            HotelPerformanceViewName resourceName = HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]");
            // Make the request
            HotelPerformanceView response = await hotelPerformanceViewServiceClient.GetHotelPerformanceViewAsync(resourceName);
            // End snippet
        }
    }
}
