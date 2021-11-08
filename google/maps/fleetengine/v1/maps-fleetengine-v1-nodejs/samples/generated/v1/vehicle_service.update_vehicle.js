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

function main(name, vehicle, updateMask) {
  // [START fleetengine_v1_generated_VehicleService_UpdateVehicle_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The standard Fleet Engine request header.
   */
  // const header = {}
  /**
   *  Required. Must be in the format
   *  "providers/{provider}/vehicles/{vehicle}".
   *  The {provider} must be the Project ID (for example, sample-cloud-project)
   *  of the Google Cloud Project of which the service account making
   *  this call is a member.
   *  Note that if the name is also specified in the name field of the
   *  vehicle and name is set in the update_mask, both names must be the
   *  same.  Otherwise it is an Error.
   */
  // const name = 'abc123'
  /**
   *  Required. The Vehicle entity update to apply.  When updating a Vehicle,
   *  the following fields may not be updated as they are managed by the
   *  Fleet Engine.
   *    current_trips
   *    available_capacity
   *    current_route_segment_version
   *    waypoints_version
   *  Furthermore, the name of the vehicle cannot be updated.
   */
  // const vehicle = {}
  /**
   *  Required. A field mask indicating which fields of the Vehicle to update.
   *  The update_mask must contain at least one field.
   */
  // const updateMask = {}

  // Imports the Fleetengine library
  const {VehicleServiceClient} = require('@googlemaps/fleetengine').v1;

  // Instantiates a client
  const fleetengineClient = new VehicleServiceClient();

  async function callUpdateVehicle() {
    // Construct request
    const request = {
      name,
      vehicle,
      updateMask,
    };

    // Run request
    const response = await fleetengineClient.updateVehicle(request);
    console.log(response);
  }

  callUpdateVehicle();
  // [END fleetengine_v1_generated_VehicleService_UpdateVehicle_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
