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

function main(imagePng, request) {
  // [START chromeosuidetection_v1_generated_UiDetectionService_ExecuteDetection_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Required field that represents a PNG image.
   */
  // const imagePng = 'Buffer.from('string')'
  /**
   *  Required. Required field that indicates the detection type.
   */
  // const request = {}

  // Imports the Uidetection library
  const {UiDetectionServiceClient} = require('@google-cloud/uidetection').v1;

  // Instantiates a client
  const uidetectionClient = new UiDetectionServiceClient();

  async function callExecuteDetection() {
    // Construct request
    const request = {
      imagePng,
      request,
    };

    // Run request
    const response = await uidetectionClient.executeDetection(request);
    console.log(response);
  }

  callExecuteDetection();
  // [END chromeosuidetection_v1_generated_UiDetectionService_ExecuteDetection_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
