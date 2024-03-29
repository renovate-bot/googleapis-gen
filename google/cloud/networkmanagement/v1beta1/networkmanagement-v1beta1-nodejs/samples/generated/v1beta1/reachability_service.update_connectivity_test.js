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

function main(updateMask, resource) {
  // [START networkmanagement_v1beta1_generated_ReachabilityService_UpdateConnectivityTest_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Mask of fields to update. At least one path must be supplied in
   *  this field.
   */
  // const updateMask = {}
  /**
   *  Required. Only fields specified in update_mask are updated.
   */
  // const resource = {}

  // Imports the Networkmanagement library
  const {ReachabilityServiceClient} = require('@google-cloud/network-management').v1beta1;

  // Instantiates a client
  const networkmanagementClient = new ReachabilityServiceClient();

  async function callUpdateConnectivityTest() {
    // Construct request
    const request = {
      updateMask,
      resource,
    };

    // Run request
    const [operation] = await networkmanagementClient.updateConnectivityTest(request);
    const [response] = await operation.promise();
    console.log(response);
  }

  callUpdateConnectivityTest();
  // [END networkmanagement_v1beta1_generated_ReachabilityService_UpdateConnectivityTest_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
