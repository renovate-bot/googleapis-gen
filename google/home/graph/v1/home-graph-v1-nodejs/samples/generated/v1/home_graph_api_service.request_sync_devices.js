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
  // [START homegraph_v1_generated_HomeGraphApiService_RequestSyncDevices_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Third-party user ID.
   */
  // const agentUserId = 'abc123'
  /**
   *  Optional. If set, the request will be added to a queue and a response will
   *  be returned immediately. This enables concurrent requests for the given
   *  `agent_user_id`, but the caller will not receive any error responses.
   */
  // const async = true

  // Imports the Graph library
  const {HomeGraphApiServiceClient} = require('graph').v1;

  // Instantiates a client
  const graphClient = new HomeGraphApiServiceClient();

  async function requestSyncDevices() {
    // Construct request
    const request = {
      agentUserId,
    };

    // Run request
    const response = await graphClient.requestSyncDevices(request);
    console.log(response);
  }

  requestSyncDevices();
  // [END homegraph_v1_generated_HomeGraphApiService_RequestSyncDevices_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
