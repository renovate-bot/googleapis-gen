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
  // [START dlp_v2_generated_DlpService_HybridInspectDlpJob_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Resource name of the job to execute a hybrid inspect on, for example
   *  `projects/dlp-test-project/dlpJob/53234423`.
   */
  // const name = 'abc123'
  /**
   *  The item to inspect.
   */
  // const hybridItem = {}

  // Imports the Dlp library
  const {DlpServiceClient} = require('@google-cloud/dlp').v2;

  // Instantiates a client
  const dlpClient = new DlpServiceClient();

  async function callHybridInspectDlpJob() {
    // Construct request
    const request = {
      name,
    };

    // Run request
    const response = await dlpClient.hybridInspectDlpJob(request);
    console.log(response);
  }

  callHybridInspectDlpJob();
  // [END dlp_v2_generated_DlpService_HybridInspectDlpJob_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
