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

function main(settings) {
  // [START securitycenter_v1beta1_generated_SecurityCenterSettingsService_UpdateSettings_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The settings to update.
   *  The settings' `name` field is used to identify the settings to be updated.
   *  Formats:
   *   * `organizations/{organization}/settings`
   *   * `folders/{folder}/settings`
   *   * `projects/{project}/settings`
   *   * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
   *   * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
   *   * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
   */
  // const settings = {}
  /**
   *  The list of fields to be updated on the settings.
   */
  // const updateMask = {}

  // Imports the Settings library
  const {SecurityCenterSettingsServiceClient} = require('settings').v1beta1;

  // Instantiates a client
  const settingsClient = new SecurityCenterSettingsServiceClient();

  async function callUpdateSettings() {
    // Construct request
    const request = {
      settings,
    };

    // Run request
    const response = await settingsClient.updateSettings(request);
    console.log(response);
  }

  callUpdateSettings();
  // [END securitycenter_v1beta1_generated_SecurityCenterSettingsService_UpdateSettings_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
