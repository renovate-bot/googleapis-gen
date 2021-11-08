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

function main(guestPolicy) {
  // [START osconfig_v1beta_generated_OsConfigService_UpdateGuestPolicy_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The updated GuestPolicy.
   */
  // const guestPolicy = {}
  /**
   *  Field mask that controls which fields of the guest policy should be
   *  updated.
   */
  // const updateMask = {}

  // Imports the Osconfig library
  const {OsConfigServiceClient} = require('osconfig').v1beta;

  // Instantiates a client
  const osconfigClient = new OsConfigServiceClient();

  async function callUpdateGuestPolicy() {
    // Construct request
    const request = {
      guestPolicy,
    };

    // Run request
    const response = await osconfigClient.updateGuestPolicy(request);
    console.log(response);
  }

  callUpdateGuestPolicy();
  // [END osconfig_v1beta_generated_OsConfigService_UpdateGuestPolicy_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
