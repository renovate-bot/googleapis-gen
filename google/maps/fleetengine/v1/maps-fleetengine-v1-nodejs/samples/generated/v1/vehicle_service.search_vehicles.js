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

function main(parent, pickupPoint, pickupRadiusMeters, count, minimumCapacity, tripTypes, vehicleTypes, orderBy) {
  // [START fleetengine_v1_generated_VehicleService_SearchVehicles_async]
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
   *  Required. The pickup point to search near.
   */
  // const pickupPoint = {}
  /**
   *  The customer's intended dropoff location. The field is required if
   *  `trip_types` contains `TripType.SHARED`.
   */
  // const dropoffPoint = {}
  /**
   *  Required. Defines the vehicle search radius around the pickup point. Only
   *  vehicles within the search radius will be returned. Value must be between
   *  400 and 10000 meters (inclusive).
   */
  // const pickupRadiusMeters = 1234
  /**
   *  Required. Specifies the maximum number of vehicles to return. The value
   *  must be between 1 and 50 (inclusive).
   */
  // const count = 1234
  /**
   *  Required. Specifies the number of passengers being considered for a trip. The
   *  value must be greater than or equal to one. The driver is not considered in
   *  the capacity value.
   */
  // const minimumCapacity = 1234
  /**
   *  Required. Restricts the search to only those vehicles that support at least
   *  one of the specified trip types.
   *  At the present time, only `EXCLUSIVE` is supported.
   */
  // const tripTypes = 1234
  /**
   *  Restricts the search to only those vehicles that have updated their
   *  locations within the specified duration. If this field is not
   *  set, the server uses five minutes as the default value.
   */
  // const maximumStaleness = {}
  /**
   *  Required. Restricts the search to vehicles with one of the specified types.
   *  At least one vehicle type must be specified.
   */
  // const vehicleTypes = 1234
  /**
   *  Callers can form complex logical operations using any combination of the
   *  `required_attributes`, `required_one_of_attributes`, and
   *  `required_one_of_attribute_sets` fields.
   *  `required_attributes` is a list; `required_one_of_attributes` uses a
   *  message which allows a list of lists. In combination, the two fields allow
   *  the composition of this expression:
   *  ```
   *  (required_attributes0  AND required_attributes1  AND ...)
   *  AND
   *  (required_one_of_attributes0 0  OR required_one_of_attributes0 1  OR
   *  ...)
   *  AND
   *  (required_one_of_attributes1 0  OR required_one_of_attributes1 1  OR
   *  ...)
   *  ```
   *  Restricts the search to only those vehicles with the specified attributes.
   *  This field is a conjunction/AND operation. Your app can specify up to 100
   *  attributes; however, the combined key:value string length cannot exceed
   *  1024 characters.
   */
  // const requiredAttributes = 1234
  /**
   *  Restricts the search to only those vehicles with at least one of
   *  the specified attributes in each `VehicleAttributeList`. Within each
   *  list, a vehicle must match at least one of the attributes. This field is an
   *  inclusive disjunction/OR operation in each `VehicleAttributeList` and a
   *  conjunction/AND operation across the collection of `VehicleAttributeList`.
   */
  // const requiredOneOfAttributes = 1234
  /**
   *  `required_one_of_attribute_sets` provides additional functionality.
   *  Similar to `required_one_of_attributes`, `required_one_of_attribute_sets`
   *  uses a message which allows a list of lists, allowing expressions such as
   *  this one:
   *  ```
   *  (required_attributes0  AND required_attributes1  AND ...)
   *  AND
   *  (required_one_of_attributes0 0  AND required_one_of_attributes0 1  AND
   *  ...)
   *  OR
   *  (required_one_of_attributes1 0  AND required_one_of_attributes1 1  AND
   *  ...)
   *  ```
   *  Restricts the search to only those vehicles with all the attributes in a
   *  `VehicleAttributeList`. Within each list, a
   *  vehicle must match all of the attributes. This field is a conjunction/AND
   *  operation in each `VehicleAttributeList` and inclusive disjunction/OR
   *  operation across the collection of `VehicleAttributeList`.
   */
  // const requiredOneOfAttributeSets = 1234
  /**
   *  Required. Specifies the desired ordering criterion for results.
   */
  // const orderBy = {}
  /**
   *  Indicates if a vehicle with a single active trip is eligible for another
   *  match. If `false`, vehicles with assigned trips are excluded from the
   *  search results. If `true`, search results include vehicles with
   *  `TripStatus` of `ENROUTE_TO_DROPOFF`.
   *  This field is only considered if a single `trip_type` of `EXCLUSIVE` is
   *  specified.
   *  The default value is `false`.
   */
  // const includeBackToBack = true
  /**
   *  Indicates the trip associated with this `SearchVehicleRequest`.
   *  Unique Trip ID; must be unique per provider.
   *  Subject to the following normalization and restrictions:
   *  1. IDs must be valid Unicode strings.
   *  2. IDs are limited to a maximum length of 64 characters.
   *  3. IDs will be normalized according to Unicode Normalization Form C
   *  (http://www.unicode.org/reports/tr15/).
   *  4. IDs may not contain any of the following ASCII characters: '/', ':',
   *  '\\', '?', or '#'.
   */
  // const tripId = 'abc123'

  // Imports the Fleetengine library
  const {VehicleServiceClient} = require('@googlemaps/fleetengine').v1;

  // Instantiates a client
  const fleetengineClient = new VehicleServiceClient();

  async function callSearchVehicles() {
    // Construct request
    const request = {
      parent,
      pickupPoint,
      pickupRadiusMeters,
      count,
      minimumCapacity,
      tripTypes,
      vehicleTypes,
      orderBy,
    };

    // Run request
    const response = await fleetengineClient.searchVehicles(request);
    console.log(response);
  }

  callSearchVehicles();
  // [END fleetengine_v1_generated_VehicleService_SearchVehicles_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
