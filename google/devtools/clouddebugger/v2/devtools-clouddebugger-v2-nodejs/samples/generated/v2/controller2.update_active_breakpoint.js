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

function main(debuggeeId, breakpoint) {
  // [START clouddebugger_update_active_breakpoint_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Identifies the debuggee being debugged.
   */
  // const debuggeeId = 'abc123'
  /**
   *  Required. Updated breakpoint information.
   *  The field `id` must be set.
   *  The agent must echo all Breakpoint specification fields in the update.
   */
  // const breakpoint = ''

  // Imports the Clouddebugger library
  const {Controller2Client} = require('clouddebugger').v2;

  // Instantiates a client
  const clouddebuggerClient = new Controller2Client();

  async function updateActiveBreakpoint() {
    // Construct request
    const request = {
      debuggeeId,
      breakpoint,
    };

    // Run request
    const response = await clouddebuggerClient.updateActiveBreakpoint(request);
    console.log(response);
  }

  updateActiveBreakpoint();
  // [END clouddebugger_update_active_breakpoint_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
