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
  // [START pubsublite_v1_generated_AdminService_SeekSubscription_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The name of the subscription to seek.
   */
  // const name = 'abc123'
  /**
   *  Seek to a named position with respect to the message backlog.
   */
  // const namedTarget = {}
  /**
   *  Seek to the first message whose publish or event time is greater than or
   *  equal to the specified query time. If no such message can be located,
   *  will seek to the end of the message backlog.
   */
  // const timeTarget = {}

  // Imports the Pubsublite library
  const {AdminServiceClient} = require('@google-cloud/pubsublite').v1;

  // Instantiates a client
  const pubsubliteClient = new AdminServiceClient();

  async function callSeekSubscription() {
    // Construct request
    const request = {
      name,
    };

    // Run request
    const [operation] = await pubsubliteClient.seekSubscription(request);
    const [response] = await operation.promise();
    console.log(response);
  }

  callSeekSubscription();
  // [END pubsublite_v1_generated_AdminService_SeekSubscription_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
