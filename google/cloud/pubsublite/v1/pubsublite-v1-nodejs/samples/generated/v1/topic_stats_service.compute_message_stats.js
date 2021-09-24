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

function main(topic, partition) {
  // [START pubsublite_v1_generated_TopicStatsService_ComputeMessageStats_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The topic for which we should compute message stats.
   */
  // const topic = 'abc123'
  /**
   *  Required. The partition for which we should compute message stats.
   */
  // const partition = 1234
  /**
   *  The inclusive start of the range.
   */
  // const startCursor = ''
  /**
   *  The exclusive end of the range. The range is empty if end_cursor <=
   *  start_cursor. Specifying a start_cursor before the first message and an
   *  end_cursor after the last message will retrieve all messages.
   */
  // const endCursor = ''

  // Imports the Pubsublite library
  const {TopicStatsServiceClient} = require('@google-cloud/pubsublite').v1;

  // Instantiates a client
  const pubsubliteClient = new TopicStatsServiceClient();

  async function computeMessageStats() {
    // Construct request
    const request = {
      topic,
      partition,
    };

    // Run request
    const response = await pubsubliteClient.computeMessageStats(request);
    console.log(response);
  }

  computeMessageStats();
  // [END pubsublite_v1_generated_TopicStatsService_ComputeMessageStats_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
