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

function main(name) {
  // [START fleetengine_get_vehicle_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The standard Fleet Engine request header.
   */
  // const header = ''
  /**
   *  Required. Must be in the format
   *  "providers/{provider}/vehicles/{vehicle}".
   *  The provider must be the Project ID (for example, sample-cloud-project)
   *  of the Google Cloud Project of which the service account making
   *  this call is a member.
   */
  // const name = 'abc123'
  /**
   *  Indicates the minimum timestamp (exclusive) for which
   *  vehicle.current_route_segment is retrieved.
   *  If route is unchanged since this timestamp, the current_route_segment
   *  field is not set in the response. If a minimum is unspecified, the
   *  current_route_segment is always retrieved.
   */
  // const currentRouteSegmentVersion = ''
  /**
   *  Indicates the minimum timestamp (exclusive) for which vehicle.waypoints
   *  data is retrieved. If data is unchanged since this timestamp, the
   *  vehicle.waypoints data is not set in the response. If this field is
   *  unspecified, vehicle.waypoints is always retrieved.
   */
  // const waypointsVersion = ''

  // Imports the Fleetengine library
  const {VehicleServiceClient} = require('@googlemaps/fleetengine').v1;

  // Instantiates a client
  const fleetengineClient = new VehicleServiceClient();

  async function getVehicle() {
    // Construct request
    const request = {
      name,
    };

    // Run request
    const response = await fleetengineClient.getVehicle(request);
    console.log(response);
  }

  getVehicle();
  // [END fleetengine_get_vehicle_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
