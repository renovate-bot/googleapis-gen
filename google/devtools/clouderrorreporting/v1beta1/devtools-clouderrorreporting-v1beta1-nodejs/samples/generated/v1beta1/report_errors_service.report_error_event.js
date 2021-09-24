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

function main(projectName, event) {
  // [START clouderrorreporting_v1beta1_generated_ReportErrorsService_ReportErrorEvent_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The resource name of the Google Cloud Platform project. Written
   *  as `projects/{projectId}`, where `{projectId}` is the
   *  [Google Cloud Platform project
   *  ID](https://support.google.com/cloud/answer/6158840).
   *  Example: // `projects/my-project-123`.
   */
  // const projectName = 'abc123'
  /**
   *  Required. The error event to be reported.
   */
  // const event = ''

  // Imports the Clouderrorreporting library
  const {ReportErrorsServiceClient} = require('@google-cloud/clouderrorreporting').v1beta1;

  // Instantiates a client
  const clouderrorreportingClient = new ReportErrorsServiceClient();

  async function reportErrorEvent() {
    // Construct request
    const request = {
      projectName,
      event,
    };

    // Run request
    const response = await clouderrorreportingClient.reportErrorEvent(request);
    console.log(response);
  }

  reportErrorEvent();
  // [END clouderrorreporting_v1beta1_generated_ReportErrorsService_ReportErrorEvent_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
