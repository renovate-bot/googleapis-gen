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

function main(instanceIdToken) {
  // [START agentendpoint_lookup_effective_guest_policy_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. This is the GCE instance identity token described in
   *  https://cloud.google.com/compute/docs/instances/verifying-instance-identity
   *  where the audience is 'osconfig.googleapis.com' and the format is 'full'.
   */
  // const instanceIdToken = 'abc123'
  /**
   *  Short name of the OS running on the instance. The OS Config agent only
   *  provideS this field for targeting if OS Inventory is enabled for that
   *  instance.
   */
  // const osShortName = 'abc123'
  /**
   *  Version of the OS running on the instance. The OS Config agent only
   *  provide this field for targeting if OS Inventory is enabled for that
   *  VM instance.
   */
  // const osVersion = 'abc123'
  /**
   *  Architecture of OS running on the instance. The OS Config agent only
   *  provide this field for targeting if OS Inventory is enabled for that
   *  instance.
   */
  // const osArchitecture = 'abc123'

  // Imports the Agentendpoint library
  const {AgentEndpointServiceClient} = require('agentendpoint').v1beta;

  // Instantiates a client
  const agentendpointClient = new AgentEndpointServiceClient();

  async function lookupEffectiveGuestPolicy() {
    // Construct request
    const request = {
      instanceIdToken,
    };

    // Run request
    const response = await agentendpointClient.lookupEffectiveGuestPolicy(request);
    console.log(response);
  }

  lookupEffectiveGuestPolicy();
  // [END agentendpoint_lookup_effective_guest_policy_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
