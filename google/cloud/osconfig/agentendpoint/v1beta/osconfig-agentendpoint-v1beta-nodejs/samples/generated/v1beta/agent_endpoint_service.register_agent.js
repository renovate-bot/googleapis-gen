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

function main(instanceIdToken, agentVersion, supportedCapabilities) {
  // [START osconfig_v1beta_generated_AgentEndpointService_RegisterAgent_async]
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
   *  Required. The version of the agent.
   */
  // const agentVersion = 'abc123'
  /**
   *  Required. The capabilities supported by the agent. Supported values are:
   *  PATCH_GA
   *  GUEST_POLICY_BETA
   */
  // const supportedCapabilities = 'abc123'

  // Imports the Agentendpoint library
  const {AgentEndpointServiceClient} = require('agentendpoint').v1beta;

  // Instantiates a client
  const agentendpointClient = new AgentEndpointServiceClient();

  async function callRegisterAgent() {
    // Construct request
    const request = {
      instanceIdToken,
      agentVersion,
      supportedCapabilities,
    };

    // Run request
    const response = await agentendpointClient.registerAgent(request);
    console.log(response);
  }

  callRegisterAgent();
  // [END osconfig_v1beta_generated_AgentEndpointService_RegisterAgent_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
