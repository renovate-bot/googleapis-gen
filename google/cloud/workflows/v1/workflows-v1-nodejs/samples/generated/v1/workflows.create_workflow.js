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

function main(parent, workflow, workflowId) {
  // [START workflows_v1_generated_Workflows_CreateWorkflow_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Project and location in which the workflow should be created.
   *  Format:  projects/{project}/locations/{location}
   */
  // const parent = 'abc123'
  /**
   *  Required. Workflow to be created.
   */
  // const workflow = {}
  /**
   *  Required. The ID of the workflow to be created. It has to fulfill the
   *  following requirements:
   *  * Must contain only letters, numbers, underscores and hyphens.
   *  * Must start with a letter.
   *  * Must be between 1-64 characters.
   *  * Must end with a number or a letter.
   *  * Must be unique within the customer project and location.
   */
  // const workflowId = 'abc123'

  // Imports the Workflows library
  const {WorkflowsClient} = require('@google-cloud/workflows').v1;

  // Instantiates a client
  const workflowsClient = new WorkflowsClient();

  async function callCreateWorkflow() {
    // Construct request
    const request = {
      parent,
      workflow,
      workflowId,
    };

    // Run request
    const [operation] = await workflowsClient.createWorkflow(request);
    const [response] = await operation.promise();
    console.log(response);
  }

  callCreateWorkflow();
  // [END workflows_v1_generated_Workflows_CreateWorkflow_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
