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

function main(projectId, traceId) {
  // [START cloudtrace_v1_generated_TraceService_GetTrace_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. ID of the Cloud project where the trace data is stored.
   */
  // const projectId = 'abc123'
  /**
   *  Required. ID of the trace to return.
   */
  // const traceId = 'abc123'

  // Imports the Cloudtrace library
  const {TraceServiceClient} = require('cloudtrace').v1;

  // Instantiates a client
  const cloudtraceClient = new TraceServiceClient();

  async function callGetTrace() {
    // Construct request
    const request = {
      projectId,
      traceId,
    };

    // Run request
    const response = await cloudtraceClient.getTrace(request);
    console.log(response);
  }

  callGetTrace();
  // [END cloudtrace_v1_generated_TraceService_GetTrace_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
