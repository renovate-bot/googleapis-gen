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
  // [START pubsublite_v1_generated_CursorService_CommitCursor_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The subscription for which to update the cursor.
   */
  // const subscription = 'abc123'
  /**
   *  The partition for which to update the cursor. Partitions are zero indexed,
   *  so `partition` must be in the range 0, topic.num_partitions).
   */
  // const partition = 1234
  /**
   *  The new value for the committed cursor.
   */
  // const cursor = {}

  // Imports the Pubsublite library
  const {CursorServiceClient} = require('@google-cloud/pubsublite').v1;

  // Instantiates a client
  const pubsubliteClient = new CursorServiceClient();

  async function callCommitCursor() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await pubsubliteClient.commitCursor(request);
    console.log(response);
  }

  callCommitCursor();
  // [END pubsublite_v1_generated_CursorService_CommitCursor_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
