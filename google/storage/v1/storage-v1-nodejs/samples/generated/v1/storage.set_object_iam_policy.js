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
  // [START storage_v1_generated_Storage_SetObjectIamPolicy_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The request sent to IAM.
   */
  // const iamRequest = {}
  /**
   *  A set of parameters common to all Storage API requests.
   */
  // const commonRequestParams = {}

  // Imports the Storage library
  const {StorageClient} = require('storage').v1;

  // Instantiates a client
  const storageClient = new StorageClient();

  async function callSetObjectIamPolicy() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await storageClient.setObjectIamPolicy(request);
    console.log(response);
  }

  callSetObjectIamPolicy();
  // [END storage_v1_generated_Storage_SetObjectIamPolicy_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
