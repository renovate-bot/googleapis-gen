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

function main(groupName) {
  // [START clouderrorreporting_v1beta1_generated_ErrorGroupService_GetGroup_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The group resource name. Written as
   *  `projects/{projectID}/groups/{group_name}`. Call
   *  `groupStats.list` (https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.groupStats/list)
   *  to return a list of groups belonging to this project.
   *  Example: `projects/my-project-123/groups/my-group`
   */
  // const groupName = 'abc123'

  // Imports the Clouderrorreporting library
  const {ErrorGroupServiceClient} = require('@google-cloud/clouderrorreporting').v1beta1;

  // Instantiates a client
  const clouderrorreportingClient = new ErrorGroupServiceClient();

  async function callGetGroup() {
    // Construct request
    const request = {
      groupName,
    };

    // Run request
    const response = await clouderrorreportingClient.getGroup(request);
    console.log(response);
  }

  callGetGroup();
  // [END clouderrorreporting_v1beta1_generated_ErrorGroupService_GetGroup_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
