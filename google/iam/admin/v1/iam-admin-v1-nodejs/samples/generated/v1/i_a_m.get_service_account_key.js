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
  // [START admin_v1_generated_IAM_GetServiceAccountKey_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The resource name of the service account key in the following format:
   *  `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
   *  Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
   *  the account. The `ACCOUNT` value can be the `email` address or the
   *  `unique_id` of the service account.
   */
  // const name = 'abc123'
  /**
   *  The output format of the public key requested.
   *  X509_PEM is the default output format.
   */
  // const publicKeyType = ''

  // Imports the Admin library
  const {IAMClient} = require('@google-cloud/admin').v1;

  // Instantiates a client
  const adminClient = new IAMClient();

  async function getServiceAccountKey() {
    // Construct request
    const request = {
      name,
    };

    // Run request
    const response = await adminClient.getServiceAccountKey(request);
    console.log(response);
  }

  getServiceAccountKey();
  // [END admin_v1_generated_IAM_GetServiceAccountKey_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
