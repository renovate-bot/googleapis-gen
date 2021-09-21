// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


'use strict';

function main(parent, vehicleId, vehicle) {
  // [START fleetengine_create_vehicle_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The standard Fleet Engine request header.
   */
  // const header = ''
  /**
   *  Required. Must be in the format "providers/{provider}".
   *  The provider must be the Project ID (for example, sample-cloud-project)
   *  of the Google Cloud Project of which the service account making
   *  this call is a member.
   */
  // const parent = 'abc123'
  /**
   *  Required. Unique Vehicle ID; must be unique per provider.  The actual
   *  format and value is opaque to the Fleet Engine and is determined
   *  by the provider.
   */
  // const vehicleId = 'abc123'
  /**
   *  Required. The Vehicle entity to create. When creating a Vehicle, the following
   *  fields are required:
   *  * vehicle_state
   *  * supported_trip_types
   *  * maximum_capacity
   *  * vehicle_type
   *  When creating a Vehicle, the following fields are ignored:
   *  * name
   *  * current_trips
   *  * available_capacity
   *  * current_route_segment
   *  * current_route_segment_version
   *  * waypoints
   *  * waypoints_version
   *  * remaining_distance_meters
   *  * eta_to_next_waypoint
   *  * navigation_status
   *  All other fields will be used if provided.
   */
  // const vehicle = ''

  // Imports the Fleetengine library
  const {VehicleServiceClient} = require('@googlemaps/fleetengine').v1;

  // Instantiates a client
  const fleetengineClient = new VehicleServiceClient();

  async function createVehicle() {
    // Construct request
    const request = {
      parent,
      vehicleId,
      vehicle,
    };

    // Run request
    const response = await fleetengineClient.createVehicle(request);
    console.log(response);
  }

  createVehicle();
  // [END fleetengine_create_vehicle_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
