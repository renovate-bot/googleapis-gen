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
  // [START testing_v1_generated_TestExecutionService_GetTestMatrix_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Cloud project that owns the test matrix.
   */
  // const projectId = 'abc123'
  /**
   *  Unique test matrix id which was assigned by the service.
   */
  // const testMatrixId = 'abc123'

  // Imports the Testing library
  const {TestExecutionServiceClient} = require('@google-cloud/testing').v1;

  // Instantiates a client
  const testingClient = new TestExecutionServiceClient();

  async function getTestMatrix() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await testingClient.getTestMatrix(request);
    console.log(response);
  }

  getTestMatrix();
  // [END testing_v1_generated_TestExecutionService_GetTestMatrix_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
