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

function main(instanceIdToken, inventoryChecksum) {
  // [START osconfig_v1_generated_AgentEndpointService_ReportInventory_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. This is the Compute Engine instance identity token described in
   *  https://cloud.google.com/compute/docs/instances/verifying-instance-identity
   *  where the audience is 'osconfig.googleapis.com' and the format is 'full'.
   */
  // const instanceIdToken = 'abc123'
  /**
   *  Required. This is a client created checksum that should be generated based
   *  on the contents of the reported inventory.  This will be used by the
   *  service to determine if it has the latest version of inventory.
   */
  // const inventoryChecksum = 'abc123'
  /**
   *  Optional. This is the details of the inventory.  Should only be provided if
   *  the inventory has changed since the last report, or if instructed by the
   *  service to provide full inventory.
   */
  // const inventory = {}

  // Imports the Agentendpoint library
  const {AgentEndpointServiceClient} = require('agentendpoint').v1;

  // Instantiates a client
  const agentendpointClient = new AgentEndpointServiceClient();

  async function callReportInventory() {
    // Construct request
    const request = {
      instanceIdToken,
      inventoryChecksum,
    };

    // Run request
    const response = await agentendpointClient.reportInventory(request);
    console.log(response);
  }

  callReportInventory();
  // [END osconfig_v1_generated_AgentEndpointService_ReportInventory_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
