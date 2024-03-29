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

function main(instanceIdToken, taskId, taskType) {
  // [START osconfig_v1_generated_AgentEndpointService_ReportTaskComplete_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. This is the Compute Engine instance identity token described in
   *  https://cloud.google.com/compute/docs/instances/verifying-instance-identity
   *  where the audience is 'osconfig.googleapis.com' and the format is 'full'.
   */
  // const instanceIdToken = 'abc123'
  /**
   *  Required. Unique identifier of the task this applies to.
   */
  // const taskId = 'abc123'
  /**
   *  Required. The type of task to report completed.
   *  Output must include the appropriate message based on this enum as
   *  specified below:
   *  APPLY_PATCHES = ApplyPatchesTaskOutput
   *  EXEC_STEP = ExecStepTaskOutput
   *  APPLY_CONFIG_TASK = ApplyConfigTaskOutput
   */
  // const taskType = {}
  /**
   *  Descriptive error message if the task execution ended in error.
   */
  // const errorMessage = 'abc123'
  /**
   *  Final output details of the apply patches task;
   */
  // const applyPatchesTaskOutput = {}
  /**
   *  Final output details of the exec step task;
   */
  // const execStepTaskOutput = {}
  /**
   *  Final output details of the apply config task;
   */
  // const applyConfigTaskOutput = {}

  // Imports the Agentendpoint library
  const {AgentEndpointServiceClient} = require('agentendpoint').v1;

  // Instantiates a client
  const agentendpointClient = new AgentEndpointServiceClient();

  async function callReportTaskComplete() {
    // Construct request
    const request = {
      instanceIdToken,
      taskId,
      taskType,
    };

    // Run request
    const response = await agentendpointClient.reportTaskComplete(request);
    console.log(response);
  }

  callReportTaskComplete();
  // [END osconfig_v1_generated_AgentEndpointService_ReportTaskComplete_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
