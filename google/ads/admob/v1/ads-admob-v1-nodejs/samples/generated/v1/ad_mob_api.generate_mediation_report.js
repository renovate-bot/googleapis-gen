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
  // [START admob_v1_generated_AdMobApi_GenerateMediationReport_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Resource name of the account to generate the report for.
   *  Example: accounts/pub-9876543210987654
   */
  // const parent = 'abc123'
  /**
   *  Network report specification.
   */
  // const reportSpec = {}

  // Imports the Admob library
  const {AdMobApiClient} = require('admob').v1;

  // Instantiates a client
  const admobClient = new AdMobApiClient();

  async function callGenerateMediationReport() {
    // Construct request
    const request = {
    };

    // Run request
    const stream = await admobClient.generateMediationReport(request);
    stream.on('data', (response) => { console.log(response) });
    stream.on('error', (err) => { throw(err) });
    stream.on('end', () => { /* API call completed */ });
  }

  callGenerateMediationReport();
  // [END admob_v1_generated_AdMobApi_GenerateMediationReport_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
