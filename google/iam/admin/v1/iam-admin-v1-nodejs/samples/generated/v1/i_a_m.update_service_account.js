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

function main(projectId, uniqueId, email, oauth2ClientId, disabled) {
  // [START iam_v1_generated_IAM_UpdateServiceAccount_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The resource name of the service account.
   *  Use one of the following formats:
   *  * `projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}`
   *  * `projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}`
   *  As an alternative, you can use the `-` wildcard character instead of the
   *  project ID:
   *  * `projects/-/serviceAccounts/{EMAIL_ADDRESS}`
   *  * `projects/-/serviceAccounts/{UNIQUE_ID}`
   *  When possible, avoid using the `-` wildcard character, because it can cause
   *  response messages to contain misleading error codes. For example, if you
   *  try to get the service account
   *  `projects/-/serviceAccounts/fake@example.com`, which does not exist, the
   *  response contains an HTTP `403 Forbidden` error instead of a `404 Not
   *  Found` error.
   */
  // const name = 'abc123'
  /**
   *  Output only. The ID of the project that owns the service account.
   */
  // const projectId = 'abc123'
  /**
   *  Output only. The unique, stable numeric ID for the service account.
   *  Each service account retains its unique ID even if you delete the service
   *  account. For example, if you delete a service account, then create a new
   *  service account with the same name, the new service account has a different
   *  unique ID than the deleted service account.
   */
  // const uniqueId = 'abc123'
  /**
   *  Output only. The email address of the service account.
   */
  // const email = 'abc123'
  /**
   *  Optional. A user-specified, human-readable name for the service account. The maximum
   *  length is 100 UTF-8 bytes.
   */
  // const displayName = 'abc123'
  /**
   *  Deprecated. Do not use.
   */
  // const etag = 'Buffer.from('string')'
  /**
   *  Optional. A user-specified, human-readable description of the service account. The
   *  maximum length is 256 UTF-8 bytes.
   */
  // const description = 'abc123'
  /**
   *  Output only. The OAuth 2.0 client ID for the service account.
   */
  // const oauth2ClientId = 'abc123'
  /**
   *  Output only. Whether the service account is disabled.
   */
  // const disabled = true

  // Imports the Admin library
  const {IAMClient} = require('@google-cloud/admin').v1;

  // Instantiates a client
  const adminClient = new IAMClient();

  async function updateServiceAccount() {
    // Construct request
    const request = {
      projectId,
      uniqueId,
      email,
      oauth2ClientId,
      disabled,
    };

    // Run request
    const response = await adminClient.updateServiceAccount(request);
    console.log(response);
  }

  updateServiceAccount();
  // [END iam_v1_generated_IAM_UpdateServiceAccount_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
