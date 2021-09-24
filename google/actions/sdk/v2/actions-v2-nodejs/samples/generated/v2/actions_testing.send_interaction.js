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

function main(project, input, deviceProperties) {
  // [START sdk_v2_generated_ActionsTesting_SendInteraction_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The project being tested, indicated by the Project ID.
   *  Format: projects/{project}
   */
  // const project = 'my-project'
  /**
   *  Required. Input provided by the user.
   */
  // const input = ''
  /**
   *  Required. Properties of the device used for interacting with the Action.
   */
  // const deviceProperties = ''
  /**
   *  Opaque token that must be passed as received from SendInteractionResponse
   *  on the previous interaction. This can be left unset in order to start a new
   *  conversation, either as the first interaction of a testing session or to
   *  abandon a previous conversation and start a new one.
   */
  // const conversationToken = 'abc123'

  // Imports the Sdk library
  const {ActionsTestingClient} = require('@assistant/actions').v2;

  // Instantiates a client
  const sdkClient = new ActionsTestingClient();

  async function sendInteraction() {
    // Construct request
    const request = {
      project,
      input,
      deviceProperties,
    };

    // Run request
    const response = await sdkClient.sendInteraction(request);
    console.log(response);
  }

  sendInteraction();
  // [END sdk_v2_generated_ActionsTesting_SendInteraction_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
