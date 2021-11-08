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

function main(impressions, requestId, clientInfo) {
  // [START playablelocations_v3_generated_PlayableLocations_LogImpressions_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Impression event details. The maximum number of impression
   *  reports that you can log at once is 50.
   */
  // const impressions = 1234
  /**
   *  Required. A string that uniquely identifies the log impressions request.
   *  This allows you to detect duplicate requests. We recommend that you use
   *  UUIDs for this value. The value must not exceed 50 characters.
   *  You should reuse the `request_id` only when retrying a request in case of
   *  failure. In this case, the request must be identical to the one that
   *  failed.
   */
  // const requestId = 'abc123'
  /**
   *  Required. Information about the client device. For example, device model
   *  and operating system.
   */
  // const clientInfo = {}

  // Imports the Playablelocations library
  const {PlayableLocationsClient} = require('playablelocations').v3;

  // Instantiates a client
  const playablelocationsClient = new PlayableLocationsClient();

  async function callLogImpressions() {
    // Construct request
    const request = {
      impressions,
      requestId,
      clientInfo,
    };

    // Run request
    const response = await playablelocationsClient.logImpressions(request);
    console.log(response);
  }

  callLogImpressions();
  // [END playablelocations_v3_generated_PlayableLocations_LogImpressions_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
