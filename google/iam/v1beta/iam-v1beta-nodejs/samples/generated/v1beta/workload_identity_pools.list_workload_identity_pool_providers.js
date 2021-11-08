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
  // [START iam_v1beta_generated_WorkloadIdentityPools_ListWorkloadIdentityPoolProviders_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The pool to list providers for.
   */
  // const parent = 'abc123'
  /**
   *  The maximum number of providers to return.
   *  If unspecified, at most 50 providers are returned.
   *  The maximum value is 100; values above 100 are truncated to 100.
   */
  // const pageSize = 1234
  /**
   *  A page token, received from a previous
   *  `ListWorkloadIdentityPoolProviders` call. Provide this to retrieve the
   *  subsequent page.
   */
  // const pageToken = 'abc123'
  /**
   *  Whether to return soft-deleted providers.
   */
  // const showDeleted = true

  // Imports the Iam library
  const {WorkloadIdentityPoolsClient} = require('iam').v1beta;

  // Instantiates a client
  const iamClient = new WorkloadIdentityPoolsClient();

  async function callListWorkloadIdentityPoolProviders() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const iterable = await iamClient.listWorkloadIdentityPoolProvidersAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callListWorkloadIdentityPoolProviders();
  // [END iam_v1beta_generated_WorkloadIdentityPools_ListWorkloadIdentityPoolProviders_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
