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
  // [START testing_get_test_environment_catalog_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The type of environment that should be listed.
   */
  // const environmentType = ''
  /**
   *  For authorization, the cloud project requesting the TestEnvironmentCatalog.
   */
  // const projectId = 'abc123'

  // Imports the Testing library
  const {TestEnvironmentDiscoveryServiceClient} = require('@google-cloud/testing').v1;

  // Instantiates a client
  const testingClient = new TestEnvironmentDiscoveryServiceClient();

  async function getTestEnvironmentCatalog() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await testingClient.getTestEnvironmentCatalog(request);
    console.log(response);
  }

  getTestEnvironmentCatalog();
  // [END testing_get_test_environment_catalog_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
