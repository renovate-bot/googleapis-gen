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
  // [START notebooks_v1_generated_ManagedNotebookService_StopRuntime_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Format:
   *  `projects/{project_id}/locations/{location}/runtimes/{runtime_id}`
   */
  // const name = 'abc123'

  // Imports the Notebooks library
  const {ManagedNotebookServiceClient} = require('@google-cloud/notebooks').v1;

  // Instantiates a client
  const notebooksClient = new ManagedNotebookServiceClient();

  async function callStopRuntime() {
    // Construct request
    const request = {
      name,
    };

    // Run request
    const [operation] = await notebooksClient.stopRuntime(request);
    const [response] = await operation.promise();
    console.log(response);
  }

  callStopRuntime();
  // [END notebooks_v1_generated_ManagedNotebookService_StopRuntime_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
