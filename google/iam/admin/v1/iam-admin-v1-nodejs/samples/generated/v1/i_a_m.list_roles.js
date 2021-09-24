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
  // [START admin_v1_generated_IAM_ListRoles_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The `parent` parameter's value depends on the target resource for the
   *  request, namely
   *  [`roles`](/iam/reference/rest/v1/roles),
   *  [`projects`](/iam/reference/rest/v1/projects.roles), or
   *  [`organizations`](/iam/reference/rest/v1/organizations.roles). Each
   *  resource type's `parent` value format is described below:
   *  * [`roles.list()`](/iam/reference/rest/v1/roles/list): An empty string.
   *    This method doesn't require a resource; it simply returns all
   *    [predefined roles](/iam/docs/understanding-roles#predefined_roles) in
   *    Cloud IAM. Example request URL:
   *    `https://iam.googleapis.com/v1/roles`
   *  * [`projects.roles.list()`](/iam/reference/rest/v1/projects.roles/list):
   *    `projects/{PROJECT_ID}`. This method lists all project-level
   *    [custom roles](/iam/docs/understanding-custom-roles).
   *    Example request URL:
   *    `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles`
   *  * [`organizations.roles.list()`](/iam/reference/rest/v1/organizations.roles/list):
   *    `organizations/{ORGANIZATION_ID}`. This method lists all
   *    organization-level [custom roles](/iam/docs/understanding-custom-roles).
   *    Example request URL:
   *    `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles`
   *  Note: Wildcard (*) values are invalid; you must specify a complete project
   *  ID or organization ID.
   */
  // const parent = 'abc123'
  /**
   *  Optional limit on the number of roles to include in the response.
   *  The default is 300, and the maximum is 1,000.
   */
  // const pageSize = 1234
  /**
   *  Optional pagination token returned in an earlier ListRolesResponse.
   */
  // const pageToken = 'abc123'
  /**
   *  Optional view for the returned Role objects. When `FULL` is specified,
   *  the `includedPermissions` field is returned, which includes a list of all
   *  permissions in the role. The default value is `BASIC`, which does not
   *  return the `includedPermissions` field.
   */
  // const view = ''
  /**
   *  Include Roles that have been deleted.
   */
  // const showDeleted = true

  // Imports the Admin library
  const {IAMClient} = require('@google-cloud/admin').v1;

  // Instantiates a client
  const adminClient = new IAMClient();

  async function listRoles() {
    // Construct request
    const request = {
    };

    // Run request
    const iterable = await adminClient.listRolesAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  listRoles();
  // [END admin_v1_generated_IAM_ListRoles_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
