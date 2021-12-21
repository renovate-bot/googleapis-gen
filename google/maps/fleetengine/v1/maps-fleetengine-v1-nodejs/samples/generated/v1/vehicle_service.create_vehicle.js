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
  // [START fleetengine_v1_generated_VehicleService_CreateVehicle_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The standard Fleet Engine request header.
   */
  // const header = {}
  /**
   *  Required. Must be in the format `providers/{provider}`.
   *  The provider must be the Project ID (for example, `sample-cloud-project`)
   *  of the Google Cloud Project of which the service account making
   *  this call is a member.
   */
  // const parent = 'abc123'
  /**
   *  Required. Unique Vehicle ID; must be unique per provider.
   *  Subject to the following normalization and restrictions:
   *  1. IDs must be valid Unicode strings.
   *  2. IDs are limited to a maximum length of 64 characters.
   *  3. IDs will be normalized according to Unicode Normalization Form C
   *  (http://www.unicode.org/reports/tr15/).
   *  4. IDs may not contain any of the following ASCII characters: '/', ':',
   *  '\\', '?', or '#'.
   */
  // const vehicleId = 'abc123'
  /**
   *  Required. The Vehicle entity to create. When creating a Vehicle, the following
   *  fields are required:
   *  * `vehicleState`
   *  * `supportedTripTypes`
   *  * `maximumCapacity`
   *  * `vehicleType`
   *  When creating a Vehicle, the following fields are ignored:
   *  * `name`
   *  * `currentTrips`
   *  * `availableCapacity`
   *  * `current_route_segment`
   *  * `current_route_segment_end_point`
   *  * `current_route_segment_version`
   *  * `current_route_segment_traffic`
   *  * `route`
   *  * `waypoints`
   *  * `waypoints_version`
   *  * `remaining_distance_meters`
   *  * `remaining_time_seconds`
   *  * `eta_to_next_waypoint`
   *  * `navigation_status`
   *  All other fields are optional and used if provided.
   */
  // const vehicle = {}

  // Imports the Fleetengine library
  const {VehicleServiceClient} = require('@googlemaps/fleetengine').v1;

  // Instantiates a client
  const fleetengineClient = new VehicleServiceClient();

  async function callCreateVehicle() {
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

  callCreateVehicle();
  // [END fleetengine_v1_generated_VehicleService_CreateVehicle_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
