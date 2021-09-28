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
  // [START example_v1alpha_generated_AllocationEndpointService_Allocate_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The required realm name in the following form:
   *  `{location}/{realm}`.
   */
  // const realm = 'abc123'
  /**
   *  The default game server deployment name.
   *  This is used to increase the likelihood of a successful
   *  allocation.
   */
  // const defaultGameServerDeployment = 'abc123'
  /**
   *  The ordered list of game server labels to match for allocations.
   *  If the first game server selector is not matched, the selection attempts
   *  the second game server selector, and so on.
   */
  // const gameServerSelectors = 1234
  /**
   *  Metadata is optional custom metadata that is added to the game server at
   *  allocation. You can use this to tell the server necessary session data.
   */
  // const metadata = ''

  // Imports the Allocationendpoint library
  const {AllocationEndpointServiceClient} = require('@google-cloud/allocationendpoint').v1alpha;

  // Instantiates a client
  const allocationendpointClient = new AllocationEndpointServiceClient();

  async function allocate() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await allocationendpointClient.allocate(request);
    console.log(response);
  }

  allocate();
  // [END example_v1alpha_generated_AllocationEndpointService_Allocate_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
