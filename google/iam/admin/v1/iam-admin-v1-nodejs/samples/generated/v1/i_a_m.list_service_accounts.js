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
  // [START iam_v1_generated_IAM_ListServiceAccounts_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The resource name of the project associated with the service
   *  accounts, such as `projects/my-project-123`.
   */
  // const name = 'abc123'
  /**
   *  Optional limit on the number of service accounts to include in the
   *  response. Further accounts can subsequently be obtained by including the
   *  ListServiceAccountsResponse.next_page_token google.iam.admin.v1.ListServiceAccountsResponse.next_page_token 
   *  in a subsequent request.
   *  The default is 20, and the maximum is 100.
   */
  // const pageSize = 1234
  /**
   *  Optional pagination token returned in an earlier
   *  ListServiceAccountsResponse.next_page_token google.iam.admin.v1.ListServiceAccountsResponse.next_page_token.
   */
  // const pageToken = 'abc123'

  // Imports the Admin library
  const {IAMClient} = require('@google-cloud/admin').v1;

  // Instantiates a client
  const adminClient = new IAMClient();

  async function callListServiceAccounts() {
    // Construct request
    const request = {
      name,
    };

    // Run request
    const iterable = await adminClient.listServiceAccountsAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callListServiceAccounts();
  // [END iam_v1_generated_IAM_ListServiceAccounts_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
