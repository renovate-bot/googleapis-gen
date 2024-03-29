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
  // [START cloudbilling_v1_generated_CloudCatalog_ListServices_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Requested page size. Defaults to 5000.
   */
  // const pageSize = 1234
  /**
   *  A token identifying a page of results to return. This should be a
   *  `next_page_token` value returned from a previous `ListServices`
   *  call. If unspecified, the first page of results is returned.
   */
  // const pageToken = 'abc123'

  // Imports the Billing library
  const {CloudCatalogClient} = require('@google-cloud/billing').v1;

  // Instantiates a client
  const billingClient = new CloudCatalogClient();

  async function callListServices() {
    // Construct request
    const request = {
    };

    // Run request
    const iterable = await billingClient.listServicesAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callListServices();
  // [END cloudbilling_v1_generated_CloudCatalog_ListServices_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
