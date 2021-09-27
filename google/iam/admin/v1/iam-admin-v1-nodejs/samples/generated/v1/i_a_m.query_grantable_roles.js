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

function main(fullResourceName) {
  // [START iam_v1_generated_IAM_QueryGrantableRoles_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The full resource name to query from the list of grantable roles.
   *  The name follows the Google Cloud Platform resource format.
   *  For example, a Cloud Platform project with id `my-project` will be named
   *  `//cloudresourcemanager.googleapis.com/projects/my-project`.
   */
  // const fullResourceName = 'abc123'
  /**
   */
  // const view = ''
  /**
   *  Optional limit on the number of roles to include in the response.
   *  The default is 300, and the maximum is 1,000.
   */
  // const pageSize = 1234
  /**
   *  Optional pagination token returned in an earlier
   *  QueryGrantableRolesResponse.
   */
  // const pageToken = 'abc123'

  // Imports the Admin library
  const {IAMClient} = require('@google-cloud/admin').v1;

  // Instantiates a client
  const adminClient = new IAMClient();

  async function queryGrantableRoles() {
    // Construct request
    const request = {
      fullResourceName,
    };

    // Run request
    const iterable = await adminClient.queryGrantableRolesAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  queryGrantableRoles();
  // [END iam_v1_generated_IAM_QueryGrantableRoles_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
