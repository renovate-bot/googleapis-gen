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
  // [START fleetengine_get_trip_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The standard Fleet Engine request header.
   */
  // const header = ''
  /**
   *  Required. Must be in the format "providers/{provider}/trips/{trip}".
   *  The provider must be the Project ID (for example, sample-cloud-project)
   *  of the Google Cloud Project of which the service account making
   *  this call is a member.
   */
  // const name = 'abc123'
  /**
   *  The subset of Trip fields that should be returned and their interpretation.
   */
  // const view = ''
  /**
   *  Indicates the minimum timestamp (exclusive) for which Trip.route or
   *  Trip.current_route_segment data is retrieved. If route data is unchanged
   *  since this timestamp, the route field is not set in the response. If a
   *  minimum is unspecified, the route data is always retrieved.
   */
  // const currentRouteSegmentVersion = ''
  /**
   *  Indicates the minimum timestamp (exclusive) for which
   *  Trip.remaining_waypoints are retrieved. If they are unchanged since this
   *  timestamp, the remaining_waypoints are not set in the response. If this
   *  field is unspecified, remaining_waypoints is always retrieved.
   */
  // const remainingWaypointsVersion = ''
  /**
   *  The returned current route format, LAT_LNG_LIST_TYPE (in Trip.route), or
   *  ENCODED_POLYLINE_TYPE (in Trip.current_route_segment).
   *  The default is LAT_LNG_LIST_TYPE.
   */
  // const routeFormatType = ''

  // Imports the Fleetengine library
  const {TripServiceClient} = require('@googlemaps/fleetengine').v1;

  // Instantiates a client
  const fleetengineClient = new TripServiceClient();

  async function getTrip() {
    // Construct request
    const request = {
      name,
    };

    // Run request
    const response = await fleetengineClient.getTrip(request);
    console.log(response);
  }

  getTrip();
  // [END fleetengine_get_trip_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
