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

function main(iapSettings) {
  // [START iap_v1_generated_IdentityAwareProxyAdminService_UpdateIapSettings_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The new values for the IAP settings to be updated.
   *  Authorization: Requires the `updateSettings` permission for the associated
   *  resource.
   */
  // const iapSettings = {}
  /**
   *  The field mask specifying which IAP settings should be updated.
   *  If omitted, the all of the settings are updated. See
   *  https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
   */
  // const updateMask = {}

  // Imports the Iap library
  const {IdentityAwareProxyAdminServiceClient} = require('@google-cloud/iap').v1;

  // Instantiates a client
  const iapClient = new IdentityAwareProxyAdminServiceClient();

  async function callUpdateIapSettings() {
    // Construct request
    const request = {
      iapSettings,
    };

    // Run request
    const response = await iapClient.updateIapSettings(request);
    console.log(response);
  }

  callUpdateIapSettings();
  // [END iap_v1_generated_IdentityAwareProxyAdminService_UpdateIapSettings_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
