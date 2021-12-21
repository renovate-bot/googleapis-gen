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

function main(parent, vehicleTypeCategories) {
  // [START fleetengine_v1_generated_VehicleService_ListVehicles_async]
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
   *  The maximum number of vehicles to return.
   *  Default value: 100.
   */
  // const pageSize = 1234
  /**
   *  The `next_page_token` value returned from a previous call to
   *  `ListVehicles`. Functionality is undefined if the filter criteria of this
   *  request don't match the criteria in the request that produced this
   *  `page_token`.
   */
  // const pageToken = 'abc123'
  /**
   *  Specifies the required minimum capacity of the vehicle. All vehicles
   *  returned will have a `maximum_capacity` greater than or equal to this
   *  value. If set, must be greater or equal to 0.
   */
  // const minimumCapacity = {}
  /**
   *  Restrict the response to vehicles that support at least
   *  one of the specified trip types.
   */
  // const tripTypes = 1234
  /**
   *  Restrict the response to vehicles that have updated
   *  their locations within the specified duration back from now.
   *  If present, must be a valid positive duration.
   */
  // const maximumStaleness = {}
  /**
   *  Required. Restrict the response to vehicles with one of the specified type
   *  categories.
   */
  // const vehicleTypeCategories = 1234
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
   *  Restrict the response to vehicles with the specified attributes. This field
   *  is a conjunction/AND operation. Your app can specify up to 100 attributes;
   *  however, the combined key:value string length cannot exceed 1024
   *  characters.
   */
  // const requiredAttributes = 'abc123'
  /**
   *  Restrict the response to vehicles with at least one
   *  of the specified attributes in each `VehicleAttributeList`.
   *  Within each list, a vehicle must match at least one of the attributes.
   *  This field is an inclusive disjunction/OR operation in each
   *  `VehicleAttributeList` and a conjunction/AND operation across the
   *  collection of `VehicleAttributeList`. Format:
   *  key1:value1|key2:value2|key3:value3...
   */
  // const requiredOneOfAttributes = 'abc123'
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
   *  Restrict the response to vehicles that match all the attributes in a
   *  `VehicleAttributeList`. Within each list, a vehicle must match all of the
   *  attributes. This field is a conjunction/AND operation in each
   *  `VehicleAttributeList` and inclusive disjunction/OR operation across the
   *  collection of `VehicleAttributeList`. Format:
   *  key1:value1|key2:value2|key3:value3...
   */
  // const requiredOneOfAttributeSets = 'abc123'
  /**
   *  Restrict the response to vehicles that have this vehicle state.
   */
  // const vehicleState = {}
  /**
   *  Only return the vehicles with current trip(s).
   */
  // const onTripOnly = true

  // Imports the Fleetengine library
  const {VehicleServiceClient} = require('@googlemaps/fleetengine').v1;

  // Instantiates a client
  const fleetengineClient = new VehicleServiceClient();

  async function callListVehicles() {
    // Construct request
    const request = {
      parent,
      vehicleTypeCategories,
    };

    // Run request
    const iterable = await fleetengineClient.listVehiclesAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callListVehicles();
  // [END fleetengine_v1_generated_VehicleService_ListVehicles_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
