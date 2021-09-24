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

function main(workloadIdentityPool, updateMask) {
  // [START iam_v1beta_generated_WorkloadIdentityPools_UpdateWorkloadIdentityPool_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The pool to update. The `name` field is used to identify the pool.
   */
  // const workloadIdentityPool = ''
  /**
   *  Required. The list of fields update.
   */
  // const updateMask = ''

  // Imports the Iam library
  const {WorkloadIdentityPoolsClient} = require('iam').v1beta;

  // Instantiates a client
  const iamClient = new WorkloadIdentityPoolsClient();

  async function updateWorkloadIdentityPool() {
    // Construct request
    const request = {
      workloadIdentityPool,
      updateMask,
    };

    // Run request
    const [operation] = await iamClient.updateWorkloadIdentityPool(request);
    const [response] = await operation.promise();
    console.log(response);
  }

  updateWorkloadIdentityPool();
  // [END iam_v1beta_generated_WorkloadIdentityPools_UpdateWorkloadIdentityPool_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
