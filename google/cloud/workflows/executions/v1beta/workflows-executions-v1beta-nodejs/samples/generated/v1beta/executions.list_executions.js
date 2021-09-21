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
  // [START executions_list_executions_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Name of the workflow for which the executions should be listed.
   *  Format: projects/{project}/locations/{location}/workflows/{workflow}
   */
  // const parent = 'abc123'
  /**
   *  Maximum number of executions to return per call.
   *  Max supported value depends on the selected Execution view: it's 10000 for
   *  BASIC and 100 for FULL. The default value used if the field is not
   *  specified is 100, regardless of the selected view. Values greater than
   *  the max value will be coerced down to it.
   */
  // const pageSize = 1234
  /**
   *  A page token, received from a previous `ListExecutions` call.
   *  Provide this to retrieve the subsequent page.
   *  When paginating, all other parameters provided to `ListExecutions` must
   *  match the call that provided the page token.
   */
  // const pageToken = 'abc123'
  /**
   *  Optional. A view defining which fields should be filled in the returned executions.
   *  The API will default to the BASIC view.
   */
  // const view = ''

  // Imports the Executions library
  const {ExecutionsClient} = require('@google-cloud/workflows-executions').v1beta;

  // Instantiates a client
  const executionsClient = new ExecutionsClient();

  async function listExecutions() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const iterable = await executionsClient.listExecutionsAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  listExecutions();
  // [END executions_list_executions_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
