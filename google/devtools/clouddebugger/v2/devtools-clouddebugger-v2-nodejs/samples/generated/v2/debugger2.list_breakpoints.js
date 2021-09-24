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

function main(debuggeeId, clientVersion) {
  // [START clouddebugger_v2_generated_Debugger2_ListBreakpoints_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. ID of the debuggee whose breakpoints to list.
   */
  // const debuggeeId = 'abc123'
  /**
   *  When set to `true`, the response includes the list of breakpoints set by
   *  any user. Otherwise, it includes only breakpoints set by the caller.
   */
  // const includeAllUsers = true
  /**
   *  When set to `true`, the response includes active and inactive
   *  breakpoints. Otherwise, it includes only active breakpoints.
   */
  // const includeInactive = true
  /**
   *  When set, the response includes only breakpoints with the specified action.
   */
  // const action = ''
  /**
   *  This field is deprecated. The following fields are always stripped out of
   *  the result: `stack_frames`, `evaluated_expressions` and `variable_table`.
   */
  // const stripResults = true
  /**
   *  A wait token that, if specified, blocks the call until the breakpoints
   *  list has changed, or a server selected timeout has expired.  The value
   *  should be set from the last response. The error code
   *  `google.rpc.Code.ABORTED` (RPC) is returned on wait timeout, which
   *  should be called again with the same `wait_token`.
   */
  // const waitToken = 'abc123'
  /**
   *  Required. The client version making the call.
   *  Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
   */
  // const clientVersion = 'abc123'

  // Imports the Clouddebugger library
  const {Debugger2Client} = require('clouddebugger').v2;

  // Instantiates a client
  const clouddebuggerClient = new Debugger2Client();

  async function listBreakpoints() {
    // Construct request
    const request = {
      debuggeeId,
      clientVersion,
    };

    // Run request
    const response = await clouddebuggerClient.listBreakpoints(request);
    console.log(response);
  }

  listBreakpoints();
  // [END clouddebugger_v2_generated_Debugger2_ListBreakpoints_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
