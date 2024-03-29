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
  // [START servicemanagement_v1_generated_ServiceManager_ListServices_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Include services produced by the specified project.
   */
  // const producerProjectId = 'abc123'
  /**
   *  The max number of items to include in the response list. Page size is 50
   *  if not specified. Maximum value is 100.
   */
  // const pageSize = 1234
  /**
   *  Token identifying which result to start with; returned by a previous list
   *  call.
   */
  // const pageToken = 'abc123'
  /**
   *  Include services consumed by the specified consumer.
   *  The Google Service Management implementation accepts the following
   *  forms:
   *  - project:<project_id>
   */
  // const consumerId = 'abc123'

  // Imports the Servicemanagement library
  const {ServiceManagerClient} = require('@google-cloud/service-management').v1;

  // Instantiates a client
  const servicemanagementClient = new ServiceManagerClient();

  async function callListServices() {
    // Construct request
    const request = {
    };

    // Run request
    const iterable = await servicemanagementClient.listServicesAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callListServices();
  // [END servicemanagement_v1_generated_ServiceManager_ListServices_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
