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

function main(name, currentLocation) {
  // [START fleetengine_v1_generated_VehicleService_UpdateVehicleLocation_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The standard Fleet Engine request header.
   */
  // const header = {}
  /**
   *  Required. Must be in the format
   *  "providers/{provider}/vehicles/{vehicle}.
   *  The {provider} must be the Project ID (for example, sample-cloud-project)
   *  of the Google Cloud Project of which the service account making
   *  this call is a member.
   */
  // const name = 'abc123'
  /**
   *  Required. The location to update to.  The last_location and update_time
   *  subfields are required.
   */
  // const currentLocation = {}
  /**
   *  Set current vehicle state to either ONLINE or OFFLINE;
   *  if set to UNKNOWN_VEHICLE_STATE, vehicle state will not be altered.
   */
  // const currentState = {}

  // Imports the Fleetengine library
  const {VehicleServiceClient} = require('@googlemaps/fleetengine').v1;

  // Instantiates a client
  const fleetengineClient = new VehicleServiceClient();

  async function callUpdateVehicleLocation() {
    // Construct request
    const request = {
      name,
      currentLocation,
    };

    // Run request
    const response = await fleetengineClient.updateVehicleLocation(request);
    console.log(response);
  }

  callUpdateVehicleLocation();
  // [END fleetengine_v1_generated_VehicleService_UpdateVehicleLocation_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
