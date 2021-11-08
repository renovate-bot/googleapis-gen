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

function main(parent, botSession) {
  // [START remoteworkers_v1test2_generated_Bots_CreateBotSession_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The farm resource.
   */
  // const parent = 'abc123'
  /**
   *  Required. The bot session to create. Server-assigned fields like name must be unset.
   */
  // const botSession = {}

  // Imports the Remoteworkers library
  const {BotsClient} = require('remoteworkers').v1test2;

  // Instantiates a client
  const remoteworkersClient = new BotsClient();

  async function callCreateBotSession() {
    // Construct request
    const request = {
      parent,
      botSession,
    };

    // Run request
    const response = await remoteworkersClient.createBotSession(request);
    console.log(response);
  }

  callCreateBotSession();
  // [END remoteworkers_v1test2_generated_Bots_CreateBotSession_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
