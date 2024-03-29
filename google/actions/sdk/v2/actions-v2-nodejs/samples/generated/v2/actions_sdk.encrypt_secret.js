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

function main(clientSecret) {
  // [START actions_v2_generated_ActionsSdk_EncryptSecret_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The account linking client secret plaintext.
   */
  // const clientSecret = 'abc123'

  // Imports the Sdk library
  const {ActionsSdkClient} = require('@assistant/actions').v2;

  // Instantiates a client
  const sdkClient = new ActionsSdkClient();

  async function callEncryptSecret() {
    // Construct request
    const request = {
      clientSecret,
    };

    // Run request
    const response = await sdkClient.encryptSecret(request);
    console.log(response);
  }

  callEncryptSecret();
  // [END actions_v2_generated_ActionsSdk_EncryptSecret_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
