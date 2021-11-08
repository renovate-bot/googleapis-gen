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

function main(debuggee) {
  // [START clouddebugger_v2_generated_Controller2_RegisterDebuggee_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Debuggee information to register.
   *  The fields `project`, `uniquifier`, `description` and `agent_version`
   *  of the debuggee must be set.
   */
  // const debuggee = {}

  // Imports the Clouddebugger library
  const {Controller2Client} = require('clouddebugger').v2;

  // Instantiates a client
  const clouddebuggerClient = new Controller2Client();

  async function callRegisterDebuggee() {
    // Construct request
    const request = {
      debuggee,
    };

    // Run request
    const response = await clouddebuggerClient.registerDebuggee(request);
    console.log(response);
  }

  callRegisterDebuggee();
  // [END clouddebugger_v2_generated_Controller2_RegisterDebuggee_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
