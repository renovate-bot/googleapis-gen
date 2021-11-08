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

function main(debuggeeId, breakpoint, clientVersion) {
  // [START clouddebugger_v2_generated_Debugger2_SetBreakpoint_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. ID of the debuggee where the breakpoint is to be set.
   */
  // const debuggeeId = 'abc123'
  /**
   *  Required. Breakpoint specification to set.
   *  The field `location` of the breakpoint must be set.
   */
  // const breakpoint = {}
  /**
   *  Required. The client version making the call.
   *  Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
   */
  // const clientVersion = 'abc123'

  // Imports the Clouddebugger library
  const {Debugger2Client} = require('clouddebugger').v2;

  // Instantiates a client
  const clouddebuggerClient = new Debugger2Client();

  async function callSetBreakpoint() {
    // Construct request
    const request = {
      debuggeeId,
      breakpoint,
      clientVersion,
    };

    // Run request
    const response = await clouddebuggerClient.setBreakpoint(request);
    console.log(response);
  }

  callSetBreakpoint();
  // [END clouddebugger_v2_generated_Debugger2_SetBreakpoint_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
