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
  // [START smartdevicemanagement_v1_generated_SmartDeviceManagementService_ListDevices_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The parent enterprise to list devices under. E.g. "enterprises/XYZ".
   */
  // const parent = 'abc123'
  /**
   *  Optional requested page size. Server may return fewer devices than
   *  requested. If unspecified, server will pick an appropriate default.
   */
  // const pageSize = 1234
  /**
   *  Optional token of the page to retrieve.
   */
  // const pageToken = 'abc123'
  /**
   *  Optional filter to list devices.
   *  Filters can match the exact parent (could be a structure or a room):
   *  'parent=enterprises/XYZ/structures/jkl'
   *  or filter by device custom name (substring match):
   *  'customName=wing'
   */
  // const filter = 'abc123'

  // Imports the Sdm library
  const {SmartDeviceManagementServiceClient} = require('sdm').v1;

  // Instantiates a client
  const sdmClient = new SmartDeviceManagementServiceClient();

  async function callListDevices() {
    // Construct request
    const request = {
    };

    // Run request
    const iterable = await sdmClient.listDevicesAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callListDevices();
  // [END smartdevicemanagement_v1_generated_SmartDeviceManagementService_ListDevices_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
