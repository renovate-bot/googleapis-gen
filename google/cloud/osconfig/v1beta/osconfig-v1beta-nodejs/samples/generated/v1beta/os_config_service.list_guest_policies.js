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
  // [START osconfig_list_guest_policies_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The resource name of the parent using one of the following forms:
   *  `projects/{project_number}`.
   */
  // const parent = 'abc123'
  /**
   *  The maximum number of guest policies to return.
   */
  // const pageSize = 1234
  /**
   *  A pagination token returned from a previous call to `ListGuestPolicies`
   *  that indicates where this listing should continue from.
   */
  // const pageToken = 'abc123'

  // Imports the Osconfig library
  const {OsConfigServiceClient} = require('osconfig').v1beta;

  // Instantiates a client
  const osconfigClient = new OsConfigServiceClient();

  async function listGuestPolicies() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const iterable = await osconfigClient.listGuestPoliciesAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  listGuestPolicies();
  // [END osconfig_list_guest_policies_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
