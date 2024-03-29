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

function main(parent, inputConfig) {
  // [START recommendationengine_v1beta1_generated_CatalogService_ImportCatalogItems_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. `projects/1234/locations/global/catalogs/default_catalog`
   */
  // const parent = 'abc123'
  /**
   *  Optional. Unique identifier provided by client, within the ancestor
   *  dataset scope. Ensures idempotency and used for request deduplication.
   *  Server-generated if unspecified. Up to 128 characters long. This is
   *  returned as google.longrunning.Operation.name in the response.
   */
  // const requestId = 'abc123'
  /**
   *  Required. The desired input location of the data.
   */
  // const inputConfig = {}
  /**
   *  Optional. The desired location of errors incurred during the Import.
   */
  // const errorsConfig = {}

  // Imports the Recommendationengine library
  const {CatalogServiceClient} = require('recommendationengine').v1beta1;

  // Instantiates a client
  const recommendationengineClient = new CatalogServiceClient();

  async function callImportCatalogItems() {
    // Construct request
    const request = {
      parent,
      inputConfig,
    };

    // Run request
    const [operation] = await recommendationengineClient.importCatalogItems(request);
    const [response] = await operation.promise();
    console.log(response);
  }

  callImportCatalogItems();
  // [END recommendationengine_v1beta1_generated_CatalogService_ImportCatalogItems_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
