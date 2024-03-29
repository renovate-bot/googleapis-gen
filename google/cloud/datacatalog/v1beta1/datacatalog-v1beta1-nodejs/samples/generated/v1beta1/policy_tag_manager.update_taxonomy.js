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
  // [START datacatalog_v1beta1_generated_PolicyTagManager_UpdateTaxonomy_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The taxonomy to update. Only description, display_name, and activated
   *  policy types can be updated.
   */
  // const taxonomy = {}
  /**
   *  The update mask applies to the resource. For the `FieldMask` definition,
   *  see
   *  https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
   *  If not set, defaults to all of the fields that are allowed to update.
   */
  // const updateMask = {}

  // Imports the Datacatalog library
  const {PolicyTagManagerClient} = require('@google-cloud/datacatalog').v1beta1;

  // Instantiates a client
  const datacatalogClient = new PolicyTagManagerClient();

  async function callUpdateTaxonomy() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await datacatalogClient.updateTaxonomy(request);
    console.log(response);
  }

  callUpdateTaxonomy();
  // [END datacatalog_v1beta1_generated_PolicyTagManager_UpdateTaxonomy_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
