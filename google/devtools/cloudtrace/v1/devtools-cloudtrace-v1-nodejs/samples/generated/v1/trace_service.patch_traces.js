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

function main(projectId, traces) {
  // [START cloudtrace_v1_generated_TraceService_PatchTraces_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. ID of the Cloud project where the trace data is stored.
   */
  // const projectId = 'abc123'
  /**
   *  Required. The body of the message.
   */
  // const traces = {}

  // Imports the Cloudtrace library
  const {TraceServiceClient} = require('cloudtrace').v1;

  // Instantiates a client
  const cloudtraceClient = new TraceServiceClient();

  async function callPatchTraces() {
    // Construct request
    const request = {
      projectId,
      traces,
    };

    // Run request
    const response = await cloudtraceClient.patchTraces(request);
    console.log(response);
  }

  callPatchTraces();
  // [END cloudtrace_v1_generated_TraceService_PatchTraces_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
