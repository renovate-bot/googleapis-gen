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

function main(projectName, groupId) {
  // [START clouderrorreporting_v1beta1_generated_ErrorStatsService_ListEvents_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The resource name of the Google Cloud Platform project. Written
   *  as `projects/{projectID}`, where `{projectID}` is the
   *  Google Cloud Platform project
   *  ID (https://support.google.com/cloud/answer/6158840).
   *  Example: `projects/my-project-123`.
   */
  // const projectName = 'abc123'
  /**
   *  Required. The group for which events shall be returned.
   */
  // const groupId = 'abc123'
  /**
   *  Optional. List only ErrorGroups which belong to a service context that
   *  matches the filter.
   *  Data for all service contexts is returned if this field is not specified.
   */
  // const serviceFilter = {}
  /**
   *  Optional. List only data for the given time range.
   *  If not set a default time range is used. The field time_range_begin
   *  in the response will specify the beginning of this time range.
   */
  // const timeRange = {}
  /**
   *  Optional. The maximum number of results to return per response.
   */
  // const pageSize = 1234
  /**
   *  Optional. A `next_page_token` provided by a previous response.
   */
  // const pageToken = 'abc123'

  // Imports the Clouderrorreporting library
  const {ErrorStatsServiceClient} = require('@google-cloud/clouderrorreporting').v1beta1;

  // Instantiates a client
  const clouderrorreportingClient = new ErrorStatsServiceClient();

  async function callListEvents() {
    // Construct request
    const request = {
      projectName,
      groupId,
    };

    // Run request
    const iterable = await clouderrorreportingClient.listEventsAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callListEvents();
  // [END clouderrorreporting_v1beta1_generated_ErrorStatsService_ListEvents_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
