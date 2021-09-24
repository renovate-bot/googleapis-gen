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
  // [START agentendpoint_v1beta_generated_AgentEndpointService_ReportTaskProgress_async]
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
   *  Required. The type of task to report progress on.
   *  Progress must include the appropriate message based on this enum as
   *  specified below:
   *  APPLY_PATCHES = ApplyPatchesTaskProgress
   *  EXEC_STEP = Progress not supported for this type.
   */
  // const taskType = ''
  /**
   *  Details about the progress of the apply patches task.
   */
  // const applyPatchesTaskProgress = ''
  /**
   *  Details about the progress of the exec step task.
   */
  // const execStepTaskProgress = ''

  // Imports the Agentendpoint library
  const {AgentEndpointServiceClient} = require('agentendpoint').v1beta;

  // Instantiates a client
  const agentendpointClient = new AgentEndpointServiceClient();

  async function reportTaskProgress() {
    // Construct request
    const request = {
      instanceIdToken,
      taskId,
      taskType,
    };

    // Run request
    const response = await agentendpointClient.reportTaskProgress(request);
    console.log(response);
  }

  reportTaskProgress();
  // [END agentendpoint_v1beta_generated_AgentEndpointService_ReportTaskProgress_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
