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

function main(instance) {
  // [START osconfig_v1beta_generated_OsConfigService_LookupEffectiveGuestPolicy_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The VM instance whose policies are being looked up.
   */
  // const instance = 'abc123'
  /**
   *  Short name of the OS running on the instance. The OS Config agent only
   *  provides this field for targeting if OS Inventory is enabled for that
   *  instance.
   */
  // const osShortName = 'abc123'
  /**
   *  Version of the OS running on the instance. The OS Config agent only
   *  provides this field for targeting if OS Inventory is enabled for that
   *  VM instance.
   */
  // const osVersion = 'abc123'
  /**
   *  Architecture of OS running on the instance. The OS Config agent only
   *  provides this field for targeting if OS Inventory is enabled for that
   *  instance.
   */
  // const osArchitecture = 'abc123'

  // Imports the Osconfig library
  const {OsConfigServiceClient} = require('osconfig').v1beta;

  // Instantiates a client
  const osconfigClient = new OsConfigServiceClient();

  async function callLookupEffectiveGuestPolicy() {
    // Construct request
    const request = {
      instance,
    };

    // Run request
    const response = await osconfigClient.lookupEffectiveGuestPolicy(request);
    console.log(response);
  }

  callLookupEffectiveGuestPolicy();
  // [END osconfig_v1beta_generated_OsConfigService_LookupEffectiveGuestPolicy_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
