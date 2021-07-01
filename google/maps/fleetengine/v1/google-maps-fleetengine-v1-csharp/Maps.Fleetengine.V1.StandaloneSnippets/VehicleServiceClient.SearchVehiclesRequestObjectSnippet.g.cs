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

    public sealed partial class GeneratedVehicleServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for SearchVehicles</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void SearchVehiclesRequestObject()
        {
            // Create client
            VehicleServiceClient vehicleServiceClient = VehicleServiceClient.Create();
            // Initialize request argument(s)
            SearchVehiclesRequest request = new SearchVehiclesRequest
            {
                Header = new RequestHeader(),
                Parent = "",
                PickupPoint = new TerminalLocation(),
                DropoffPoint = new TerminalLocation(),
                PickupRadiusMeters = 0,
                Count = 0,
                MinimumCapacity = 0,
                TripTypes =
                {
                    TripType.UnknownTripType,
                },
                MaximumStaleness = new Duration(),
                RequiredAttributes =
                {
                    new VehicleAttribute(),
                },
                OrderBy = SearchVehiclesRequest.Types.VehicleMatchOrder.UnknownVehicleMatchOrder,
                VehicleTypes =
                {
                    new Vehicle.Types.VehicleType(),
                },
                RequiredOneOfAttributes =
                {
                    new VehicleAttributeList(),
                },
                IncludeBackToBack = false,
                TripId = "",
                RequiredOneOfAttributeSets =
                {
                    new VehicleAttributeList(),
                },
            };
            // Make the request
            SearchVehiclesResponse response = vehicleServiceClient.SearchVehicles(request);
        }
    }
}
