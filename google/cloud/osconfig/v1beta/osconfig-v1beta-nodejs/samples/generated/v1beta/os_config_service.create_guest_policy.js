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

function main(parent, guestPolicyId, guestPolicy) {
  // [START osconfig_v1beta_generated_OsConfigService_CreateGuestPolicy_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The resource name of the parent using one of the following forms:
   *  `projects/{project_number}`.
   */
  // const parent = 'abc123'
  /**
   *  Required. The logical name of the guest policy in the project
   *  with the following restrictions:
   *  * Must contain only lowercase letters, numbers, and hyphens.
   *  * Must start with a letter.
   *  * Must be between 1-63 characters.
   *  * Must end with a number or a letter.
   *  * Must be unique within the project.
   */
  // const guestPolicyId = 'abc123'
  /**
   *  Required. The GuestPolicy to create.
   */
  // const guestPolicy = ''

  // Imports the Osconfig library
  const {OsConfigServiceClient} = require('osconfig').v1beta;

  // Instantiates a client
  const osconfigClient = new OsConfigServiceClient();

  async function createGuestPolicy() {
    // Construct request
    const request = {
      parent,
      guestPolicyId,
      guestPolicy,
    };

    // Run request
    const response = await osconfigClient.createGuestPolicy(request);
    console.log(response);
  }

  createGuestPolicy();
  // [END osconfig_v1beta_generated_OsConfigService_CreateGuestPolicy_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
