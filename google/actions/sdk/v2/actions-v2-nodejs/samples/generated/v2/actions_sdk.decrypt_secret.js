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

function main(encryptedClientSecret) {
  // [START sdk_decrypt_secret_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The account linking client secret ciphertext.
   */
  // const encryptedClientSecret = 'Buffer.from('string')'

  // Imports the Sdk library
  const {ActionsSdkClient} = require('@assistant/actions').v2;

  // Instantiates a client
  const sdkClient = new ActionsSdkClient();

  async function decryptSecret() {
    // Construct request
    const request = {
      encryptedClientSecret,
    };

    // Run request
    const response = await sdkClient.decryptSecret(request);
    console.log(response);
  }

  decryptSecret();
  // [END sdk_decrypt_secret_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
