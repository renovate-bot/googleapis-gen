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

function main(parent) {
  // [START settings_batch_get_settings_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The relative resource name of the organization shared by all of the
   *  settings being retrieved.
   *  Format:
   *   * `organizations/{organization}`
   */
  // const parent = 'abc123'
  /**
   *  The names of the settings to retrieve.
   *  A maximum of 1000 settings can be retrieved in a batch.
   *  Formats:
   *   * `organizations/{organization}/settings`
   *   * `folders/{folder}/settings`
   *   * `projects/{project}/settings`
   *   * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
   *   * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
   *   * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
   */
  // const names = 'abc123'

  // Imports the Settings library
  const {SecurityCenterSettingsServiceClient} = require('settings').v1beta1;

  // Instantiates a client
  const settingsClient = new SecurityCenterSettingsServiceClient();

  async function batchGetSettings() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const response = await settingsClient.batchGetSettings(request);
    console.log(response);
  }

  batchGetSettings();
  // [END settings_batch_get_settings_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
