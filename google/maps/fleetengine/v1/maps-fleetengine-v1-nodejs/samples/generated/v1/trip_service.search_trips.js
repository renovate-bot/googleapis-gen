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

function main(parent) {
  // [START fleetengine_search_trips_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The standard Fleet Engine request header.
   */
  // const header = ''
  /**
   *  Required. Must be in the format "providers/*"
   *  The provider must be the Project ID (for example, sample-cloud-project)
   *  of the Google Cloud Project of which the service account making
   *  this call is a member.
   */
  // const parent = 'abc123'
  /**
   *  The vehicle associated with the trips in the request. If unspecified, the
   *  returned trips do not contain:
   *  * current_route_segment
   *  * remaining_waypoints
   *  * remaining_distance_meters
   *  * eta_to_first_waypoint
   */
  // const vehicleId = 'abc123'
  /**
   *  If set to true, only Trips that influence the drivers route
   *  are included in the response.
   */
  // const activeTripsOnly = true
  /**
   *  If not set, the server will decide the number of
   *  results to return.
   */
  // const pageSize = 1234
  /**
   *  Set this to a value previously returned in the
   *  SearchTripsResponse to continue from previous results.
   */
  // const pageToken = 'abc123'
  /**
   *  If specified, returns the trips that have not been updated after
   *  the time (current - minimum_staleness).
   */
  // const minimumStaleness = ''

  // Imports the Fleetengine library
  const {TripServiceClient} = require('@googlemaps/fleetengine').v1;

  // Instantiates a client
  const fleetengineClient = new TripServiceClient();

  async function searchTrips() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const iterable = await fleetengineClient.searchTripsAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  searchTrips();
  // [END fleetengine_search_trips_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
