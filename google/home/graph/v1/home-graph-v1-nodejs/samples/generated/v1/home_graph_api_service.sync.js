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

function main(agentUserId) {
  // [START graph_sync_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Request ID used for debugging.
   */
  // const requestId = 'abc123'
  /**
   *  Required. Third-party user ID.
   */
  // const agentUserId = 'abc123'

  // Imports the Graph library
  const {HomeGraphApiServiceClient} = require('graph').v1;

  // Instantiates a client
  const graphClient = new HomeGraphApiServiceClient();

  async function sync() {
    // Construct request
    const request = {
      agentUserId,
    };

    // Run request
    const response = await graphClient.sync(request);
    console.log(response);
  }

  sync();
  // [END graph_sync_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
