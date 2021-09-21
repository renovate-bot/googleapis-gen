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

function main(parent, deploymentId, deployment) {
  // [START gsuiteaddons_create_deployment_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Name of the project in which to create the deployment.
   *  Example: `projects/my_project`.
   */
  // const parent = 'abc123'
  /**
   *  Required. The id to use for this deployment.  The full name of the created
   *  resource will be `projects/<project_number>/deployments/<deployment_id>`.
   */
  // const deploymentId = 'abc123'
  /**
   *  Required. The deployment to create (deployment.name cannot be set).
   */
  // const deployment = ''

  // Imports the Gsuiteaddons library
  const {GSuiteAddOnsClient} = require('@google-cloud/gsuiteaddons').v1;

  // Instantiates a client
  const gsuiteaddonsClient = new GSuiteAddOnsClient();

  async function createDeployment() {
    // Construct request
    const request = {
      parent,
      deploymentId,
      deployment,
    };

    // Run request
    const response = await gsuiteaddonsClient.createDeployment(request);
    console.log(response);
  }

  createDeployment();
  // [END gsuiteaddons_create_deployment_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
