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

function main(parent, predictionApiKeyRegistration) {
  // [START recommendationengine_v1beta1_generated_PredictionApiKeyRegistry_CreatePredictionApiKeyRegistration_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The parent resource path.
   *  `projects/* /locations/global/catalogs/default_catalog/eventStores/default_event_store`.
   */
  // const parent = 'abc123'
  /**
   *  Required. The prediction API key registration.
   */
  // const predictionApiKeyRegistration = {}

  // Imports the Recommendationengine library
  const {PredictionApiKeyRegistryClient} = require('recommendationengine').v1beta1;

  // Instantiates a client
  const recommendationengineClient = new PredictionApiKeyRegistryClient();

  async function callCreatePredictionApiKeyRegistration() {
    // Construct request
    const request = {
      parent,
      predictionApiKeyRegistration,
    };

    // Run request
    const response = await recommendationengineClient.createPredictionApiKeyRegistration(request);
    console.log(response);
  }

  callCreatePredictionApiKeyRegistration();
  // [END recommendationengine_v1beta1_generated_PredictionApiKeyRegistry_CreatePredictionApiKeyRegistration_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
