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

function main(parent, execution) {
  // [START workflowexecutions_v1beta_generated_Executions_CreateExecution_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Name of the workflow for which an execution should be created.
   *  Format: projects/{project}/locations/{location}/workflows/{workflow}
   *  The latest revision of the workflow will be used.
   */
  // const parent = 'abc123'
  /**
   *  Required. Execution to be created.
   */
  // const execution = {}

  // Imports the Executions library
  const {ExecutionsClient} = require('@google-cloud/workflows-executions').v1beta;

  // Instantiates a client
  const executionsClient = new ExecutionsClient();

  async function callCreateExecution() {
    // Construct request
    const request = {
      parent,
      execution,
    };

    // Run request
    const response = await executionsClient.createExecution(request);
    console.log(response);
  }

  callCreateExecution();
  // [END workflowexecutions_v1beta_generated_Executions_CreateExecution_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
