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
  // [START appsmarket_v2_generated_UserLicenseService_Get_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Application Id
   */
  // const applicationId = 'abc123'
  /**
   *  User Id
   */
  // const userId = 'abc123'

  // Imports the Marketplace library
  const {UserLicenseServiceClient} = require('@google-cloud/marketplace').v2;

  // Instantiates a client
  const marketplaceClient = new UserLicenseServiceClient();

  async function callGet() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await marketplaceClient.get(request);
    console.log(response);
  }

  callGet();
  // [END appsmarket_v2_generated_UserLicenseService_Get_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
