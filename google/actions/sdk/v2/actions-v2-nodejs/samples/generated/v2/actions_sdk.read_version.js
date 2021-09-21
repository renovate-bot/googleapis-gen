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

function main(name) {
  // [START sdk_read_version_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The name of the version resource in the format
   *  `projects/{project}/versions/{version}`. `{project}` is the
   *  cloud project ID associated with the project, `{version}` is the
   *  identifier of the version being read.
   */
  // const name = 'abc123'
  /**
   *  Optional. The version of the crypto key used to encrypt the account linking OAuth
   *  client secret. If not specified, the primary key version is used for
   *  encryption. Only relevant for projects with account linking with client
   *  secret.
   */
  // const clientSecretEncryptionKeyVersion = 'abc123'

  // Imports the Sdk library
  const {ActionsSdkClient} = require('@assistant/actions').v2;

  // Instantiates a client
  const sdkClient = new ActionsSdkClient();

  async function readVersion() {
    // Construct request
    const request = {
      name,
    };

    // Run request
    const stream = await sdkClient.readVersion(request);
    stream.on('data', (response) => { console.log(response) });
    stream.on('error', (err) => { throw(err) });
    stream.on('end', () => { /* API call completed */ });
  }

  readVersion();
  // [END sdk_read_version_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
