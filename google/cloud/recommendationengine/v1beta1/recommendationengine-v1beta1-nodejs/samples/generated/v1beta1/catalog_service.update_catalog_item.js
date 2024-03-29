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

function main(name, catalogItem) {
  // [START recommendationengine_v1beta1_generated_CatalogService_UpdateCatalogItem_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Full resource name of catalog item, such as
   *  "projects/* /locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id".
   */
  // const name = 'abc123'
  /**
   *  Required. The catalog item to update/create. The 'catalog_item_id' field
   *  has to match that in the 'name'.
   */
  // const catalogItem = {}
  /**
   *  Optional. Indicates which fields in the provided 'item' to update. If not
   *  set, will by default update all fields.
   */
  // const updateMask = {}

  // Imports the Recommendationengine library
  const {CatalogServiceClient} = require('recommendationengine').v1beta1;

  // Instantiates a client
  const recommendationengineClient = new CatalogServiceClient();

  async function callUpdateCatalogItem() {
    // Construct request
    const request = {
      name,
      catalogItem,
    };

    // Run request
    const response = await recommendationengineClient.updateCatalogItem(request);
    console.log(response);
  }

  callUpdateCatalogItem();
  // [END recommendationengine_v1beta1_generated_CatalogService_UpdateCatalogItem_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
