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

function main(name, botSession, updateMask) {
  // [START remoteworkers_v1test2_generated_Bots_UpdateBotSession_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The bot session name. Must match bot_session.name.
   */
  // const name = 'abc123'
  /**
   *  Required. The bot session resource to update.
   */
  // const botSession = ''
  /**
   *  Required. The fields on the bot that should be updated. See the BotSession resource
   *  for which fields are updatable by which caller.
   */
  // const updateMask = ''

  // Imports the Remoteworkers library
  const {BotsClient} = require('remoteworkers').v1test2;

  // Instantiates a client
  const remoteworkersClient = new BotsClient();

  async function updateBotSession() {
    // Construct request
    const request = {
      name,
      botSession,
      updateMask,
    };

    // Run request
    const response = await remoteworkersClient.updateBotSession(request);
    console.log(response);
  }

  updateBotSession();
  // [END remoteworkers_v1test2_generated_Bots_UpdateBotSession_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
