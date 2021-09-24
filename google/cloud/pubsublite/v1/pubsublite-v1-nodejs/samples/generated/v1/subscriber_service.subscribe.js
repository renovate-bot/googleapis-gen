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
  // [START pubsublite_v1_generated_SubscriberService_Subscribe_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Initial request on the stream.
   */
  // const initial = ''
  /**
   *  Request to update the stream's delivery cursor.
   */
  // const seek = ''
  /**
   *  Request to grant tokens to the server,
   */
  // const flowControl = ''

  // Imports the Pubsublite library
  const {SubscriberServiceClient} = require('@google-cloud/pubsublite').v1;

  // Instantiates a client
  const pubsubliteClient = new SubscriberServiceClient();

  async function subscribe() {
    // Construct request
    const request = {
    };

    // Run request
    const stream = await pubsubliteClient.subscribe();
    stream.on('data', (response) => { console.log(response) });
    stream.on('error', (err) => { throw(err) });
    stream.on('end', () => { /* API call completed */ });
    stream.write(request);
    stream.end(); 
  }

  subscribe();
  // [END pubsublite_v1_generated_SubscriberService_Subscribe_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
