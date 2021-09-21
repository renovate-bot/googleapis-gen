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

function main(parent) {
  // [START migration_list_migration_subtasks_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The migration task of the subtasks to list.
   *  Example: `projects/123/locations/us/workflows/1234`
   */
  // const parent = 'abc123'
  /**
   *  Optional. The list of fields to be retrieved.
   */
  // const readMask = ''
  /**
   *  Optional. The maximum number of migration tasks to return. The service may return
   *  fewer than this number.
   */
  // const pageSize = 1234
  /**
   *  Optional. A page token, received from previous `ListMigrationSubtasks` call.
   *  Provide this to retrieve the subsequent page.
   *  When paginating, all other parameters provided to `ListMigrationSubtasks`
   *  must match the call that provided the page token.
   */
  // const pageToken = 'abc123'
  /**
   *  Optional. The filter to apply. This can be used to get the subtasks of a specific
   *  tasks in a workflow, e.g. `migration_task = "ab012"` where `"ab012"` is the
   *  task ID (not the name in the named map).
   */
  // const filter = 'abc123'

  // Imports the Migration library
  const {MigrationServiceClient} = require('@google-cloud/migration').v2alpha;

  // Instantiates a client
  const migrationClient = new MigrationServiceClient();

  async function listMigrationSubtasks() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const iterable = await migrationClient.listMigrationSubtasksAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  listMigrationSubtasks();
  // [END migration_list_migration_subtasks_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
