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
  // [START sdm_get_device_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The name of the device requested. For example:
   *  "enterprises/XYZ/devices/123"
   */
  // const name = 'abc123'

  // Imports the Sdm library
  const {SmartDeviceManagementServiceClient} = require('sdm').v1;

  // Instantiates a client
  const sdmClient = new SmartDeviceManagementServiceClient();

  async function getDevice() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await sdmClient.getDevice(request);
    console.log(response);
  }

  getDevice();
  // [END sdm_get_device_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
