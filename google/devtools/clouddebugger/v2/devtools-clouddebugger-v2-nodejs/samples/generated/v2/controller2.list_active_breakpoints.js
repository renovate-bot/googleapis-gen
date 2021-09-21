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

function main(debuggeeId) {
  // [START clouddebugger_list_active_breakpoints_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Identifies the debuggee.
   */
  // const debuggeeId = 'abc123'
  /**
   *  A token that, if specified, blocks the method call until the list
   *  of active breakpoints has changed, or a server-selected timeout has
   *  expired. The value should be set from the `next_wait_token` field in
   *  the last response. The initial value should be set to `"init"`.
   */
  // const waitToken = 'abc123'
  /**
   *  If set to `true` (recommended), returns `google.rpc.Code.OK` status and
   *  sets the `wait_expired` response field to `true` when the server-selected
   *  timeout has expired.
   *  If set to `false` (deprecated), returns `google.rpc.Code.ABORTED` status
   *  when the server-selected timeout has expired.
   */
  // const successOnTimeout = true

  // Imports the Clouddebugger library
  const {Controller2Client} = require('clouddebugger').v2;

  // Instantiates a client
  const clouddebuggerClient = new Controller2Client();

  async function listActiveBreakpoints() {
    // Construct request
    const request = {
      debuggeeId,
    };

    // Run request
    const response = await clouddebuggerClient.listActiveBreakpoints(request);
    console.log(response);
  }

  listActiveBreakpoints();
  // [END clouddebugger_list_active_breakpoints_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
