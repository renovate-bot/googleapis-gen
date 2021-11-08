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
  // [START smartdevicemanagement_v1_generated_SmartDeviceManagementService_ExecuteDeviceCommand_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The name of the device requested. For example:
   *  "enterprises/XYZ/devices/123"
   */
  // const name = 'abc123'
  /**
   *  The command name to execute, represented by the fully qualified protobuf
   *  message name.
   */
  // const command = 'abc123'
  /**
   *  The command message to execute, represented as a Struct.
   */
  // const params = {}

  // Imports the Sdm library
  const {SmartDeviceManagementServiceClient} = require('sdm').v1;

  // Instantiates a client
  const sdmClient = new SmartDeviceManagementServiceClient();

  async function callExecuteDeviceCommand() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await sdmClient.executeDeviceCommand(request);
    console.log(response);
  }

  callExecuteDeviceCommand();
  // [END smartdevicemanagement_v1_generated_SmartDeviceManagementService_ExecuteDeviceCommand_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
