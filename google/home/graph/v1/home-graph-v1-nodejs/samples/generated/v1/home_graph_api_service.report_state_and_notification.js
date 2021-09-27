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

function main(agentUserId, payload) {
  // [START homegraph_v1_generated_HomeGraphApiService_ReportStateAndNotification_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Request ID used for debugging.
   */
  // const requestId = 'abc123'
  /**
   *  Unique identifier per event (for example, a doorbell press).
   */
  // const eventId = 'abc123'
  /**
   *  Required. Third-party user ID.
   */
  // const agentUserId = 'abc123'
  /**
   *  Deprecated.
   *  (-- Token to maintain state in the follow up notification response. See the
   *  notifications guide at
   *  https://developers.google.com/assistant/smarthome/develop/notifications for
   *  details on implementing follow up notifications --)
   */
  // const followUpToken = 'abc123'
  /**
   *  Required. State of devices to update and notification metadata for devices.
   */
  // const payload = ''

  // Imports the Graph library
  const {HomeGraphApiServiceClient} = require('graph').v1;

  // Instantiates a client
  const graphClient = new HomeGraphApiServiceClient();

  async function reportStateAndNotification() {
    // Construct request
    const request = {
      agentUserId,
      payload,
    };

    // Run request
    const response = await graphClient.reportStateAndNotification(request);
    console.log(response);
  }

  reportStateAndNotification();
  // [END homegraph_v1_generated_HomeGraphApiService_ReportStateAndNotification_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
