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
  // [START dlp_v2_generated_DlpService_UpdateDeidentifyTemplate_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Resource name of organization and deidentify template to be updated, for
   *  example `organizations/433245324/deidentifyTemplates/432452342` or
   *  projects/project-id/deidentifyTemplates/432452342.
   */
  // const name = 'abc123'
  /**
   *  New DeidentifyTemplate value.
   */
  // const deidentifyTemplate = {}
  /**
   *  Mask to control which fields get updated.
   */
  // const updateMask = {}

  // Imports the Dlp library
  const {DlpServiceClient} = require('@google-cloud/dlp').v2;

  // Instantiates a client
  const dlpClient = new DlpServiceClient();

  async function callUpdateDeidentifyTemplate() {
    // Construct request
    const request = {
      name,
    };

    // Run request
    const response = await dlpClient.updateDeidentifyTemplate(request);
    console.log(response);
  }

  callUpdateDeidentifyTemplate();
  // [END dlp_v2_generated_DlpService_UpdateDeidentifyTemplate_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
