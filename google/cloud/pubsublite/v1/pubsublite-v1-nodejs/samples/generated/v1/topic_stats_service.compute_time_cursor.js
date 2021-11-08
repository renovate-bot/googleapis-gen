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

function main(topic, partition, target) {
  // [START pubsublite_v1_generated_TopicStatsService_ComputeTimeCursor_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The topic for which we should compute the cursor.
   */
  // const topic = 'abc123'
  /**
   *  Required. The partition for which we should compute the cursor.
   */
  // const partition = 1234
  /**
   *  Required. The target publish or event time. Specifying a future time will return an
   *  unset cursor.
   */
  // const target = {}

  // Imports the Pubsublite library
  const {TopicStatsServiceClient} = require('@google-cloud/pubsublite').v1;

  // Instantiates a client
  const pubsubliteClient = new TopicStatsServiceClient();

  async function callComputeTimeCursor() {
    // Construct request
    const request = {
      topic,
      partition,
      target,
    };

    // Run request
    const response = await pubsubliteClient.computeTimeCursor(request);
    console.log(response);
  }

  callComputeTimeCursor();
  // [END pubsublite_v1_generated_TopicStatsService_ComputeTimeCursor_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
