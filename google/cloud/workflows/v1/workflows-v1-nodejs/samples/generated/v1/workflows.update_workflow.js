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

function main(workflow) {
  // [START workflows_v1_generated_Workflows_UpdateWorkflow_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Workflow to be updated.
   */
  // const workflow = ''
  /**
   *  List of fields to be updated. If not present, the entire workflow
   *  will be updated.
   */
  // const updateMask = ''

  // Imports the Workflows library
  const {WorkflowsClient} = require('@google-cloud/workflows').v1;

  // Instantiates a client
  const workflowsClient = new WorkflowsClient();

  async function updateWorkflow() {
    // Construct request
    const request = {
      workflow,
    };

    // Run request
    const [operation] = await workflowsClient.updateWorkflow(request);
    const [response] = await operation.promise();
    console.log(response);
  }

  updateWorkflow();
  // [END workflows_v1_generated_Workflows_UpdateWorkflow_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
