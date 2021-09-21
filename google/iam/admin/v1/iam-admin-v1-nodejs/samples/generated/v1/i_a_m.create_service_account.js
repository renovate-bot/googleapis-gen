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

function main(name, accountId) {
  // [START admin_create_service_account_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The resource name of the project associated with the service
   *  accounts, such as `projects/my-project-123`.
   */
  // const name = 'abc123'
  /**
   *  Required. The account id that is used to generate the service account
   *  email address and a stable unique id. It is unique within a project,
   *  must be 6-30 characters long, and match the regular expression
   *  `[a-z]([-a-z0-9]*[a-z0-9])` to comply with RFC1035.
   */
  // const accountId = 'abc123'
  /**
   *  The [ServiceAccount][google.iam.admin.v1.ServiceAccount] resource to
   *  create. Currently, only the following values are user assignable:
   *  `display_name` and `description`.
   */
  // const serviceAccount = ''

  // Imports the Admin library
  const {IAMClient} = require('@google-cloud/admin').v1;

  // Instantiates a client
  const adminClient = new IAMClient();

  async function createServiceAccount() {
    // Construct request
    const request = {
      name,
      accountId,
    };

    // Run request
    const response = await adminClient.createServiceAccount(request);
    console.log(response);
  }

  createServiceAccount();
  // [END admin_create_service_account_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
