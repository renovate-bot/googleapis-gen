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

namespace Google.Ads.GoogleAds.V4.Services.Snippets
{
    using Google.Ads.GoogleAds.V4.Resources;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedHotelGroupViewServiceClientSnippets
    {
        /// <summary>Snippet for GetHotelGroupView</summary>
        public void GetHotelGroupViewRequestObject()
        {
            // Snippet: GetHotelGroupView(GetHotelGroupViewRequest, CallSettings)
            // Create client
            HotelGroupViewServiceClient hotelGroupViewServiceClient = HotelGroupViewServiceClient.Create();
            // Initialize request argument(s)
            GetHotelGroupViewRequest request = new GetHotelGroupViewRequest
            {
                ResourceNameAsHotelGroupViewName = HotelGroupViewName.FromCustomerHotelGroupView("[CUSTOMER]", "[HOTEL_GROUP_VIEW]"),
            };
            // Make the request
            HotelGroupView response = hotelGroupViewServiceClient.GetHotelGroupView(request);
            // End snippet
        }

        /// <summary>Snippet for GetHotelGroupViewAsync</summary>
        public async Task GetHotelGroupViewRequestObjectAsync()
        {
            // Snippet: GetHotelGroupViewAsync(GetHotelGroupViewRequest, CallSettings)
            // Additional: GetHotelGroupViewAsync(GetHotelGroupViewRequest, CancellationToken)
            // Create client
            HotelGroupViewServiceClient hotelGroupViewServiceClient = await HotelGroupViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetHotelGroupViewRequest request = new GetHotelGroupViewRequest
            {
                ResourceNameAsHotelGroupViewName = HotelGroupViewName.FromCustomerHotelGroupView("[CUSTOMER]", "[HOTEL_GROUP_VIEW]"),
            };
            // Make the request
            HotelGroupView response = await hotelGroupViewServiceClient.GetHotelGroupViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHotelGroupView</summary>
        public void GetHotelGroupView()
        {
            // Snippet: GetHotelGroupView(string, CallSettings)
            // Create client
            HotelGroupViewServiceClient hotelGroupViewServiceClient = HotelGroupViewServiceClient.Create();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/hotelGroupViews/[HOTEL_GROUP_VIEW]";
            // Make the request
            HotelGroupView response = hotelGroupViewServiceClient.GetHotelGroupView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetHotelGroupViewAsync</summary>
        public async Task GetHotelGroupViewAsync()
        {
            // Snippet: GetHotelGroupViewAsync(string, CallSettings)
            // Additional: GetHotelGroupViewAsync(string, CancellationToken)
            // Create client
            HotelGroupViewServiceClient hotelGroupViewServiceClient = await HotelGroupViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resourceName = "customers/[CUSTOMER]/hotelGroupViews/[HOTEL_GROUP_VIEW]";
            // Make the request
            HotelGroupView response = await hotelGroupViewServiceClient.GetHotelGroupViewAsync(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetHotelGroupView</summary>
        public void GetHotelGroupViewResourceNames()
        {
            // Snippet: GetHotelGroupView(HotelGroupViewName, CallSettings)
            // Create client
            HotelGroupViewServiceClient hotelGroupViewServiceClient = HotelGroupViewServiceClient.Create();
            // Initialize request argument(s)
            HotelGroupViewName resourceName = HotelGroupViewName.FromCustomerHotelGroupView("[CUSTOMER]", "[HOTEL_GROUP_VIEW]");
            // Make the request
            HotelGroupView response = hotelGroupViewServiceClient.GetHotelGroupView(resourceName);
            // End snippet
        }

        /// <summary>Snippet for GetHotelGroupViewAsync</summary>
        public async Task GetHotelGroupViewResourceNamesAsync()
        {
            // Snippet: GetHotelGroupViewAsync(HotelGroupViewName, CallSettings)
            // Additional: GetHotelGroupViewAsync(HotelGroupViewName, CancellationToken)
            // Create client
            HotelGroupViewServiceClient hotelGroupViewServiceClient = await HotelGroupViewServiceClient.CreateAsync();
            // Initialize request argument(s)
            HotelGroupViewName resourceName = HotelGroupViewName.FromCustomerHotelGroupView("[CUSTOMER]", "[HOTEL_GROUP_VIEW]");
            // Make the request
            HotelGroupView response = await hotelGroupViewServiceClient.GetHotelGroupViewAsync(resourceName);
            // End snippet
        }
    }
}
