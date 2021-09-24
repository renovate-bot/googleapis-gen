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
  // [START networkservices_v1beta1_generated_NetworkServices_ListEndpointPolicies_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The project and location from which the EndpointPolicies should be
   *  listed, specified in the format `projects/* /locations/global`.
   */
  // const parent = 'abc123'
  /**
   *  Maximum number of EndpointPolicies to return per call.
   */
  // const pageSize = 1234
  /**
   *  The value returned by the last `ListEndpointPoliciesResponse`
   *  Indicates that this is a continuation of a prior
   *  `ListEndpointPolicies` call, and that the system should return the
   *  next page of data.
   */
  // const pageToken = 'abc123'

  // Imports the Networkservices library
  const {NetworkServicesClient} = require('@google-cloud/networkservices').v1beta1;

  // Instantiates a client
  const networkservicesClient = new NetworkServicesClient();

  async function listEndpointPolicies() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const iterable = await networkservicesClient.listEndpointPoliciesAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  listEndpointPolicies();
  // [END networkservices_v1beta1_generated_NetworkServices_ListEndpointPolicies_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
