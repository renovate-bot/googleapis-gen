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
  // [START ids_v1_generated_IDS_GetEndpoint_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The name of the endpoint to retrieve.
   *  Format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
   */
  // const name = 'abc123'

  // Imports the Ids library
  const {IDSClient} = require('@google-cloud/ids').v1;

  // Instantiates a client
  const idsClient = new IDSClient();

  async function callGetEndpoint() {
    // Construct request
    const request = {
      name,
    };

    // Run request
    const response = await idsClient.getEndpoint(request);
    console.log(response);
  }

  callGetEndpoint();
  // [END ids_v1_generated_IDS_GetEndpoint_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
