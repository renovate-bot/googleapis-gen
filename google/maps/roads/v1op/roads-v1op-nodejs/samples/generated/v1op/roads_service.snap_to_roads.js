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

function main() {
  // [START roads_v1op_generated_RoadsService_SnapToRoads_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The path to be snapped as a series of lat, lng points. Specified as
   *  a string of the format: lat,lng|lat,lng|...
   */
  // const path = 'abc123'
  /**
   *  Whether to interpolate the points to return full road geometry.
   */
  // const interpolate = true
  /**
   *  The asset ID of the asset to which this path relates. This is used for
   *  abuse detection purposes for clients with asset-based SKUs.
   */
  // const assetId = 'abc123'
  /**
   *  The type of travel being tracked. This will constrain the paths we snap to.
   */
  // const travelMode = ''

  // Imports the Roads library
  const {RoadsServiceClient} = require('roads').v1op;

  // Instantiates a client
  const roadsClient = new RoadsServiceClient();

  async function snapToRoads() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await roadsClient.snapToRoads(request);
    console.log(response);
  }

  snapToRoads();
  // [END roads_v1op_generated_RoadsService_SnapToRoads_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
