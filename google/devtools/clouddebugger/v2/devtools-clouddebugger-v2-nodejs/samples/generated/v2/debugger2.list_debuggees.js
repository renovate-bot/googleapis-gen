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

function main(project, clientVersion) {
  // [START clouddebugger_v2_generated_Debugger2_ListDebuggees_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Project number of a Google Cloud project whose debuggees to list.
   */
  // const project = 'my-project'
  /**
   *  When set to `true`, the result includes all debuggees. Otherwise, the
   *  result includes only debuggees that are active.
   */
  // const includeInactive = true
  /**
   *  Required. The client version making the call.
   *  Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
   */
  // const clientVersion = 'abc123'

  // Imports the Clouddebugger library
  const {Debugger2Client} = require('clouddebugger').v2;

  // Instantiates a client
  const clouddebuggerClient = new Debugger2Client();

  async function callListDebuggees() {
    // Construct request
    const request = {
      project,
      clientVersion,
    };

    // Run request
    const response = await clouddebuggerClient.listDebuggees(request);
    console.log(response);
  }

  callListDebuggees();
  // [END clouddebugger_v2_generated_Debugger2_ListDebuggees_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
