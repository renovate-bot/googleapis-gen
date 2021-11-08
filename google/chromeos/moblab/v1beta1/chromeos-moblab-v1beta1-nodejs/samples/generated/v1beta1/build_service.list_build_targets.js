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
  // [START chromeosmoblab_v1beta1_generated_BuildService_ListBuildTargets_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Optional. The number of build targets to return in a page.
   */
  // const pageSize = 1234
  /**
   *  Optional. A page token, received from a previous `ListBuildTargets` call. Provide
   *  this to retrieve the subsequent page.
   */
  // const pageToken = 'abc123'

  // Imports the Moblab library
  const {BuildServiceClient} = require('@google-cloud/moblab').v1beta1;

  // Instantiates a client
  const moblabClient = new BuildServiceClient();

  async function callListBuildTargets() {
    // Construct request
    const request = {
    };

    // Run request
    const iterable = await moblabClient.listBuildTargetsAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callListBuildTargets();
  // [END chromeosmoblab_v1beta1_generated_BuildService_ListBuildTargets_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
