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
  // [START cloudshell_v1_generated_CloudShellService_RemovePublicKey_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Environment this key should be removed from, e.g.
   *  `users/me/environments/default`.
   */
  // const environment = 'abc123'
  /**
   *  Key that should be removed from the environment.
   */
  // const key = 'abc123'

  // Imports the Shell library
  const {CloudShellServiceClient} = require('@google-cloud/shell').v1;

  // Instantiates a client
  const shellClient = new CloudShellServiceClient();

  async function callRemovePublicKey() {
    // Construct request
    const request = {
    };

    // Run request
    const [operation] = await shellClient.removePublicKey(request);
    const [response] = await operation.promise();
    console.log(response);
  }

  callRemovePublicKey();
  // [END cloudshell_v1_generated_CloudShellService_RemovePublicKey_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
