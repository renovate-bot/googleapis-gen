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

function main(componentSettings) {
  // [START securitycenter_v1beta1_generated_SecurityCenterSettingsService_UpdateComponentSettings_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The component settings to update.
   *  The component settings' `name` field is used to identify the component
   *  settings to be updated. Formats:
   *   * `organizations/{organization}/components/{component}/settings`
   *   * `folders/{folder}/components/{component}/settings`
   *   * `projects/{project}/components/{component}/settings`
   *   * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
   *   * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
   *   * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
   */
  // const componentSettings = ''
  /**
   *  The list of fields to be updated on the component settings resource.
   */
  // const updateMask = ''

  // Imports the Settings library
  const {SecurityCenterSettingsServiceClient} = require('settings').v1beta1;

  // Instantiates a client
  const settingsClient = new SecurityCenterSettingsServiceClient();

  async function updateComponentSettings() {
    // Construct request
    const request = {
      componentSettings,
    };

    // Run request
    const response = await settingsClient.updateComponentSettings(request);
    console.log(response);
  }

  updateComponentSettings();
  // [END securitycenter_v1beta1_generated_SecurityCenterSettingsService_UpdateComponentSettings_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
