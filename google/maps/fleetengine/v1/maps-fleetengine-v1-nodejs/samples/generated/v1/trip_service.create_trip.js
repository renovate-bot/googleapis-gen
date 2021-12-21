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

function main(parent, tripId, trip) {
  // [START fleetengine_v1_generated_TripService_CreateTrip_async]
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
   *  Required. Unique Trip ID; must be unique per provider.
   *  Subject to the following normalization and restrictions:
   *  1. IDs must be valid Unicode strings.
   *  2. IDs are limited to a maximum length of 64 characters.
   *  3. IDs will be normalized according to Unicode Normalization Form C
   *  (http://www.unicode.org/reports/tr15/).
   *  4. IDs may not contain any of the following ASCII characters: '/', ':',
   *  '\\', '?', or '#'.
   */
  // const tripId = 'abc123'
  /**
   *  Required. Trip entity to create.
   *  When creating a Trip, the following fields are required:
   *  * `trip_type`
   *  * `pickup_point`
   *  The following fields are used if you provide them:
   *  * `number_of_passengers`
   *  * `vehicle_id`
   *  * `dropoff_point`
   *  * `intermediate_destinations`
   *  Only `EXCLUSIVE` trips support multiple destinations.
   *  When `vehicle_id` is set for a shared trip, you must supply
   *  the list of `Trip.vehicle_waypoints` to specify the order of the remaining
   *  waypoints for the vehicle, otherwise the waypoint order will be
   *  undetermined.
   *  When you specify `Trip.vehicle_waypoints`, the list must contain all
   *  the remaining waypoints of the vehicle's trips, with no extra waypoints.
   *  You must order these waypoints such that for a given trip, the pickup
   *  point is before intermediate destinations, and all intermediate
   *  destinations come before the drop-off point. An `EXCLUSIVE` trip's
   *  waypoints must not interleave with any other trips.
   *  The `trip_id`, `waypoint_type` and `location` fields are used, and all
   *  other TripWaypoint fields in `vehicle_waypoints` are ignored.
   *  All other Trip fields are ignored.
   */
  // const trip = {}

  // Imports the Fleetengine library
  const {TripServiceClient} = require('@googlemaps/fleetengine').v1;

  // Instantiates a client
  const fleetengineClient = new TripServiceClient();

  async function callCreateTrip() {
    // Construct request
    const request = {
      parent,
      tripId,
      trip,
    };

    // Run request
    const response = await fleetengineClient.createTrip(request);
    console.log(response);
  }

  callCreateTrip();
  // [END fleetengine_v1_generated_TripService_CreateTrip_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
