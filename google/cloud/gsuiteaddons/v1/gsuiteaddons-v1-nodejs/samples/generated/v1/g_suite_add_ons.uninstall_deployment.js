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

function main(name) {
  // [START gsuiteaddons_uninstall_deployment_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The full resource name of the deployment to install.
   *  Example:  `projects/my_project/deployments/my_deployment`.
   */
  // const name = 'abc123'

  // Imports the Gsuiteaddons library
  const {GSuiteAddOnsClient} = require('@google-cloud/gsuiteaddons').v1;

  // Instantiates a client
  const gsuiteaddonsClient = new GSuiteAddOnsClient();

  async function uninstallDeployment() {
    // Construct request
    const request = {
      name,
    };

    // Run request
    const response = await gsuiteaddonsClient.uninstallDeployment(request);
    console.log(response);
  }

  uninstallDeployment();
  // [END gsuiteaddons_uninstall_deployment_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
