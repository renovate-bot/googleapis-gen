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
  // const header = ''
  /**
   *  Required. Must be in the format "providers/{provider}".
   *  The provider must be the Project ID (for example, sample-cloud-project)
   *  of the Google Cloud Project of which the service account making
   *  this call is a member.
   */
  // const parent = 'abc123'
  /**
   *  Required. The pickup point to search near.
   */
  // const pickupPoint = ''
  /**
   *  The customer's intended dropoff location. The field is required if
   *  trip_types contains TripType.SHARED.
   */
  // const dropoffPoint = ''
  /**
   *  Required. Defines the vehicle search radius around the pickup point. Only
   *  vehicles within the search radius will be returned. Value must be between
   *  400 and 10000 meters.
   */
  // const pickupRadiusMeters = 1234
  /**
   *  Required. Specifies the maximum number of available vehicles to return. By
   *  default, the Fleet Engine limits the number to  50.
   */
  // const count = 1234
  /**
   *  Required. Specifies the minimum number of passengers allowed in the
   *  vehicle. Must number must be greater than or equal to one. The driver is
   *  not considered in the capacity search. This number indicates the number of
   *  passengers being considered for a trip.
   */
  // const minimumCapacity = 1234
  /**
   *  Required. Restricts the search to only those vehicles that support at least
   *  one of the specified trip types.
   */
  // const tripTypes = 1234
  /**
   *  Restricts the search to only those vehicles that have updated their
   *  locations within the specified duration back from now. If this field is not
   *  set, the server uses five minutes as the default value.
   */
  // const maximumStaleness = ''
  /**
   *  Required. Restricts the search to those vehicles with the specified types.
   *  At least one vehicle type must be specified.
   */
  // const vehicleTypes = 1234
  /**
   *  Callers can form complex logical operations using the
   *  requiredAttributes and requiredOneOfAttributes fields.
   *  requiredAttributes is a list; requiredOneOfAttributes uses a message which
   *  allows a list of lists. In combination, the two fields allow the
   *  composition of this expression:
   *  ```
   *  (required_attribute[0] AND required_attribute[1] AND ...)
   *  AND
   *  (required_one_of_attribute[0][0] OR required_one_of_attribute[0][1] OR ...)
   *  AND
   *  (required_one_of_attribute[1][0] OR required_one_of_attribute[1][1] OR ...)
   *  ```
   *  Restricts the search to only those vehicles with the specified attributes.
   *  This field is a conjunction/AND operation. Your app can specify up to 100
   *  attributes; however, the combined key:value string length cannot exceed
   *  1024 characters.
   */
  // const requiredAttributes = 1234
  /**
   *  Restricts the search to only those vehicles with at least one of
   *  the specified attributes applied to each VehicleAttributeList. Within each
   *  list, a vehicle must match at least one of the attributes. This field is an
   *  inclusive disjunction/OR operation in each VehicleAttributeList and a
   *  conjunction/AND operation across the collection of VehicleAttributeList.
   */
  // const requiredOneOfAttributes = 1234
  /**
   *  Restricts the search to only those vehicles with at least one set of the
   *  specified attributes in the VehicleAttributeList. Within each list, a
   *  vehicle must match all of the attributes. This field is a conjunction/AND
   *  operation in each VehicleAttributeList and inclusive disjunction/OR
   *  operation across the collection of VehicleAttributeList.
   */
  // const requiredOneOfAttributeSets = 1234
  /**
   *  Required. Specifies ordering criterion for results.
   */
  // const orderBy = ''
  /**
   *  Indicates if a vehicle with an active trip is eligible for
   *  another match. If `false`, a vehicle is excluded from search results.
   *  If `true`, search results include vehicles with `TripStatus` of
   *  `ENROUTE_TO_DROPOFF`. The services only use this field if
   *  the `SearchVehicles` request has `TripType` set to EXCLUSIVE.
   *  Default value is `false`.
   */
  // const includeBackToBack = true
  /**
   *  Indicates the ID of the trip the searchVehicleRequest is
   *  associated with.
   */
  // const tripId = 'abc123'

  // Imports the Fleetengine library
  const {VehicleServiceClient} = require('@googlemaps/fleetengine').v1;

  // Instantiates a client
  const fleetengineClient = new VehicleServiceClient();

  async function searchVehicles() {
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

  searchVehicles();
  // [END fleetengine_v1_generated_VehicleService_SearchVehicles_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
