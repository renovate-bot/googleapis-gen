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

function main() {
  // [START iam_v1_generated_IAM_UndeleteRole_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The `name` parameter's value depends on the target resource for the
   *  request, namely
   *  [`projects`](/iam/reference/rest/v1/projects.roles) or
   *  [`organizations`](/iam/reference/rest/v1/organizations.roles). Each
   *  resource type's `name` value format is described below:
   *  * [`projects.roles.undelete()`](/iam/reference/rest/v1/projects.roles/undelete):
   *    `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes
   *    only [custom roles](/iam/docs/understanding-custom-roles) that have been
   *    created at the project level. Example request URL:
   *    `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`
   *  * [`organizations.roles.undelete()`](/iam/reference/rest/v1/organizations.roles/undelete):
   *    `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method
   *    undeletes only [custom roles](/iam/docs/understanding-custom-roles) that
   *    have been created at the organization level. Example request URL:
   *    `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
   *  Note: Wildcard (*) values are invalid; you must specify a complete project
   *  ID or organization ID.
   */
  // const name = 'abc123'
  /**
   *  Used to perform a consistent read-modify-write.
   */
  // const etag = 'Buffer.from('string')'

  // Imports the Admin library
  const {IAMClient} = require('@google-cloud/admin').v1;

  // Instantiates a client
  const adminClient = new IAMClient();

  async function undeleteRole() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await adminClient.undeleteRole(request);
    console.log(response);
  }

  undeleteRole();
  // [END iam_v1_generated_IAM_UndeleteRole_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
