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

function main(parent) {
  // [START securitycenter_run_asset_discovery_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Name of the organization to run asset discovery for. Its format is
   *  "organizations/[organization_id]".
   */
  // const parent = 'abc123'

  // Imports the Securitycenter library
  const {SecurityCenterClient} = require('@google-cloud/security-center').v1beta1;

  // Instantiates a client
  const securitycenterClient = new SecurityCenterClient();

  async function runAssetDiscovery() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const [operation] = await securitycenterClient.runAssetDiscovery(request);
    const [response] = await operation.promise();
    console.log(response);
  }

  runAssetDiscovery();
  // [END securitycenter_run_asset_discovery_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
