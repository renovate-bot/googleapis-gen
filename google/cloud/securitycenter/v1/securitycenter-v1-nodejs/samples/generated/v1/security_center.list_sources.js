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
  // [START securitycenter_list_sources_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Resource name of the parent of sources to list. Its format should be
   *  "organizations/[organization_id], folders/[folder_id], or
   *  projects/[project_id]".
   */
  // const parent = 'abc123'
  /**
   *  The value returned by the last `ListSourcesResponse`; indicates
   *  that this is a continuation of a prior `ListSources` call, and
   *  that the system should return the next page of data.
   */
  // const pageToken = 'abc123'
  /**
   *  The maximum number of results to return in a single response. Default is
   *  10, minimum is 1, maximum is 1000.
   */
  // const pageSize = 1234

  // Imports the Securitycenter library
  const {SecurityCenterClient} = require('@google-cloud/security-center').v1;

  // Instantiates a client
  const securitycenterClient = new SecurityCenterClient();

  async function listSources() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const iterable = await securitycenterClient.listSourcesAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  listSources();
  // [END securitycenter_list_sources_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
