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

function main(projectId, datasetId, modelId) {
  // [START bigquery_get_model_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Project ID of the requested model.
   */
  // const projectId = 'abc123'
  /**
   *  Required. Dataset ID of the requested model.
   */
  // const datasetId = 'abc123'
  /**
   *  Required. Model ID of the requested model.
   */
  // const modelId = 'abc123'

  // Imports the Bigquery library
  const {ModelServiceClient} = require('bigquery').v2;

  // Instantiates a client
  const bigqueryClient = new ModelServiceClient();

  async function getModel() {
    // Construct request
    const request = {
      projectId,
      datasetId,
      modelId,
    };

    // Run request
    const response = await bigqueryClient.getModel(request);
    console.log(response);
  }

  getModel();
  // [END bigquery_get_model_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
