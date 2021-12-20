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

function main(parent, volumeSnapshot) {
  // [START baremetalsolution_v2_generated_BareMetalSolution_CreateVolumeSnapshot_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The volume to snapshot.
   */
  // const parent = 'abc123'
  /**
   *  Required. The volume snapshot to create. Only the description field may be specified.
   */
  // const volumeSnapshot = {}

  // Imports the Baremetalsolution library
  const {BareMetalSolutionClient} = require('@google-cloud/baremetalsolution').v2;

  // Instantiates a client
  const baremetalsolutionClient = new BareMetalSolutionClient();

  async function callCreateVolumeSnapshot() {
    // Construct request
    const request = {
      parent,
      volumeSnapshot,
    };

    // Run request
    const response = await baremetalsolutionClient.createVolumeSnapshot(request);
    console.log(response);
  }

  callCreateVolumeSnapshot();
  // [END baremetalsolution_v2_generated_BareMetalSolution_CreateVolumeSnapshot_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
