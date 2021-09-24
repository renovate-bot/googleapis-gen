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
  // [START moblab_v1beta1_generated_BuildService_CheckBuildStageStatus_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The full resource name of the build artifact.
   *  For example,
   *  'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
   */
  // const name = 'abc123'
  /**
   *  Optional. Filter that specifies value constraints of fields. For example, the
   *  filter can be set as "filter='type=release'" to only check the release
   *  builds.
   */
  // const filter = 'abc123'

  // Imports the Moblab library
  const {BuildServiceClient} = require('@google-cloud/moblab').v1beta1;

  // Instantiates a client
  const moblabClient = new BuildServiceClient();

  async function checkBuildStageStatus() {
    // Construct request
    const request = {
      name,
    };

    // Run request
    const response = await moblabClient.checkBuildStageStatus(request);
    console.log(response);
  }

  checkBuildStageStatus();
  // [END moblab_v1beta1_generated_BuildService_CheckBuildStageStatus_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
