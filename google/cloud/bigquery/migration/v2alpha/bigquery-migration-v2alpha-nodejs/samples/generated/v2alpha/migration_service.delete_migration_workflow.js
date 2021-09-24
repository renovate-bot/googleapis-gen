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
  // [START migration_v2alpha_generated_MigrationService_DeleteMigrationWorkflow_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The unique identifier for the migration workflow.
   *  Example: `projects/123/locations/us/workflows/1234`
   */
  // const name = 'abc123'

  // Imports the Migration library
  const {MigrationServiceClient} = require('@google-cloud/migration').v2alpha;

  // Instantiates a client
  const migrationClient = new MigrationServiceClient();

  async function deleteMigrationWorkflow() {
    // Construct request
    const request = {
      name,
    };

    // Run request
    const response = await migrationClient.deleteMigrationWorkflow(request);
    console.log(response);
  }

  deleteMigrationWorkflow();
  // [END migration_v2alpha_generated_MigrationService_DeleteMigrationWorkflow_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
