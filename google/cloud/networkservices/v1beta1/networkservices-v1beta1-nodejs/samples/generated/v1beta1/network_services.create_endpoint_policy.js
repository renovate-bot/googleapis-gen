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

function main(parent, endpointPolicyId, endpointPolicy) {
  // [START networkservices_v1beta1_generated_NetworkServices_CreateEndpointPolicy_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The parent resource of the EndpointPolicy. Must be in the
   *  format `projects/* /locations/global`.
   */
  // const parent = 'abc123'
  /**
   *  Required. Short name of the EndpointPolicy resource to be created.
   *  E.g. "CustomECS".
   */
  // const endpointPolicyId = 'abc123'
  /**
   *  Required. EndpointPolicy resource to be created.
   */
  // const endpointPolicy = {}

  // Imports the Networkservices library
  const {NetworkServicesClient} = require('@google-cloud/networkservices').v1beta1;

  // Instantiates a client
  const networkservicesClient = new NetworkServicesClient();

  async function callCreateEndpointPolicy() {
    // Construct request
    const request = {
      parent,
      endpointPolicyId,
      endpointPolicy,
    };

    // Run request
    const [operation] = await networkservicesClient.createEndpointPolicy(request);
    const [response] = await operation.promise();
    console.log(response);
  }

  callCreateEndpointPolicy();
  // [END networkservices_v1beta1_generated_NetworkServices_CreateEndpointPolicy_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
