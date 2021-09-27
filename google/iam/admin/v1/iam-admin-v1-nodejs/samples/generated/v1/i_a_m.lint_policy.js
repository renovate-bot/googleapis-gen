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
  // [START iam_v1_generated_IAM_LintPolicy_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The full resource name of the policy this lint request is about.
   *  The name follows the Google Cloud Platform (GCP) resource format.
   *  For example, a GCP project with ID `my-project` will be named
   *  `//cloudresourcemanager.googleapis.com/projects/my-project`.
   *  The resource name is not used to read the policy instance from the Cloud
   *  IAM database. The candidate policy for lint has to be provided in the same
   *  request object.
   */
  // const fullResourceName = 'abc123'
  /**
   *  [google.iam.v1.Binding.condition] [google.iam.v1.Binding.condition] object to be linted.
   */
  // const condition = ''

  // Imports the Admin library
  const {IAMClient} = require('@google-cloud/admin').v1;

  // Instantiates a client
  const adminClient = new IAMClient();

  async function lintPolicy() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await adminClient.lintPolicy(request);
    console.log(response);
  }

  lintPolicy();
  // [END iam_v1_generated_IAM_LintPolicy_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
