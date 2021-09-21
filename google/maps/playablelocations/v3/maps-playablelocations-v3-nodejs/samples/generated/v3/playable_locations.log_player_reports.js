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

function main(playerReports, requestId, clientInfo) {
  // [START playablelocations_log_player_reports_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Player reports. The maximum number of player reports that you can
   *  log at once is 50.
   */
  // const playerReports = 1234
  /**
   *  Required. A string that uniquely identifies the log player reports request.
   *  This allows you to detect duplicate requests. We recommend that you use
   *  UUIDs for this value. The value must not exceed 50 characters.
   *  You should reuse the `request_id` only when retrying a request in the case
   *  of a failure. In that case, the request must be identical to the one that
   *  failed.
   */
  // const requestId = 'abc123'
  /**
   *  Required. Information about the client device (for example, device model
   *  and operating system).
   */
  // const clientInfo = ''

  // Imports the Playablelocations library
  const {PlayableLocationsClient} = require('playablelocations').v3;

  // Instantiates a client
  const playablelocationsClient = new PlayableLocationsClient();

  async function logPlayerReports() {
    // Construct request
    const request = {
      playerReports,
      requestId,
      clientInfo,
    };

    // Run request
    const response = await playablelocationsClient.logPlayerReports(request);
    console.log(response);
  }

  logPlayerReports();
  // [END playablelocations_log_player_reports_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
