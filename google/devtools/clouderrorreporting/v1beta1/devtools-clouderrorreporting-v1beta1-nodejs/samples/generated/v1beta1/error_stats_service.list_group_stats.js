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

function main(projectName) {
  // [START clouderrorreporting_v1beta1_generated_ErrorStatsService_ListGroupStats_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The resource name of the Google Cloud Platform project. Written
   *  as `projects/{projectID}` or `projects/{projectNumber}`, where `{projectID}`
   *  and `{projectNumber}` can be found in the
   *  Google Cloud Console (https://support.google.com/cloud/answer/6158840).
   *  Examples: `projects/my-project-123`, `projects/5551234`.
   */
  // const projectName = 'abc123'
  /**
   *  Optional. List all <code>ErrorGroupStats</code> with these IDs.
   */
  // const groupId = 'abc123'
  /**
   *  Optional. List only <code>ErrorGroupStats</code> which belong to a service
   *  context that matches the filter.
   *  Data for all service contexts is returned if this field is not specified.
   */
  // const serviceFilter = {}
  /**
   *  Optional. List data for the given time range.
   *  If not set, a default time range is used. The field
   *  <code>time_range_begin</code> in the response will specify the beginning
   *  of this time range.
   *  Only <code>ErrorGroupStats</code> with a non-zero count in the given time
   *  range are returned, unless the request contains an explicit
   *  <code>group_id</code> list. If a <code>group_id</code> list is given, also
   *  <code>ErrorGroupStats</code> with zero occurrences are returned.
   */
  // const timeRange = {}
  /**
   *  Optional. The preferred duration for a single returned `TimedCount`.
   *  If not set, no timed counts are returned.
   */
  // const timedCountDuration = {}
  /**
   *  Optional. The alignment of the timed counts to be returned.
   *  Default is `ALIGNMENT_EQUAL_AT_END`.
   */
  // const alignment = {}
  /**
   *  Optional. Time where the timed counts shall be aligned if rounded
   *  alignment is chosen. Default is 00:00 UTC.
   */
  // const alignmentTime = {}
  /**
   *  Optional. The sort order in which the results are returned.
   *  Default is `COUNT_DESC`.
   */
  // const order = {}
  /**
   *  Optional. The maximum number of results to return per response.
   *  Default is 20.
   */
  // const pageSize = 1234
  /**
   *  Optional. A `next_page_token` provided by a previous response. To view
   *  additional results, pass this token along with the identical query
   *  parameters as the first request.
   */
  // const pageToken = 'abc123'

  // Imports the Clouderrorreporting library
  const {ErrorStatsServiceClient} = require('@google-cloud/clouderrorreporting').v1beta1;

  // Instantiates a client
  const clouderrorreportingClient = new ErrorStatsServiceClient();

  async function callListGroupStats() {
    // Construct request
    const request = {
      projectName,
    };

    // Run request
    const iterable = await clouderrorreportingClient.listGroupStatsAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callListGroupStats();
  // [END clouderrorreporting_v1beta1_generated_ErrorStatsService_ListGroupStats_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
