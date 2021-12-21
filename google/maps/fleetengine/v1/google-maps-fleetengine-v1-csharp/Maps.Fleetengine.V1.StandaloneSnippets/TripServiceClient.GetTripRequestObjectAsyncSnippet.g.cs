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

namespace Maps.Fleetengine.V1.Snippets
{
    using Google.Protobuf.WellKnownTypes;
    using Maps.Fleetengine.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedTripServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for GetTripAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetTripRequestObjectAsync()
        {
            // Create client
            TripServiceClient tripServiceClient = await TripServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTripRequest request = new GetTripRequest
            {
                Header = new RequestHeader(),
                TripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                CurrentRouteSegmentVersion = new Timestamp(),
                RemainingWaypointsVersion = new Timestamp(),
                RouteFormatType = PolylineFormatType.UnknownFormatType,
                CurrentRouteSegmentTrafficVersion = new Timestamp(),
                RemainingWaypointsRouteVersion = new Timestamp(),
                View = TripView.Unspecified,
            };
            // Make the request
            Trip response = await tripServiceClient.GetTripAsync(request);
        }
    }
}
