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

function main(parent, workloadIdentityPool, workloadIdentityPoolId) {
  // [START iam_v1beta_generated_WorkloadIdentityPools_CreateWorkloadIdentityPool_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The parent resource to create the pool in. The only supported
   *  location is `global`.
   */
  // const parent = 'abc123'
  /**
   *  Required. The pool to create.
   */
  // const workloadIdentityPool = ''
  /**
   *  Required. The ID to use for the pool, which becomes the
   *  final component of the resource name. This value should be 4-32 characters,
   *  and may contain the characters [a-z0-9-]. The prefix `gcp-` is
   *  reserved for use by Google, and may not be specified.
   */
  // const workloadIdentityPoolId = 'abc123'

  // Imports the Iam library
  const {WorkloadIdentityPoolsClient} = require('iam').v1beta;

  // Instantiates a client
  const iamClient = new WorkloadIdentityPoolsClient();

  async function createWorkloadIdentityPool() {
    // Construct request
    const request = {
      parent,
      workloadIdentityPool,
      workloadIdentityPoolId,
    };

    // Run request
    const [operation] = await iamClient.createWorkloadIdentityPool(request);
    const [response] = await operation.promise();
    console.log(response);
  }

  createWorkloadIdentityPool();
  // [END iam_v1beta_generated_WorkloadIdentityPools_CreateWorkloadIdentityPool_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
