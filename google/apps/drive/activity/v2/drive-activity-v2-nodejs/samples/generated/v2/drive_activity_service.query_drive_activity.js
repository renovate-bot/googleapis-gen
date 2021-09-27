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
  // [START driveactivity_v2_generated_DriveActivityService_QueryDriveActivity_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Return activities for this Drive item. The format is
   *  `items/ITEM_ID`.
   */
  // const itemName = 'abc123'
  /**
   *  Return activities for this Drive folder and all children and descendants.
   *  The format is `items/ITEM_ID`.
   */
  // const ancestorName = 'abc123'
  /**
   *  Details on how to consolidate related actions that make up the activity. If
   *  not set, then related actions are not consolidated.
   */
  // const consolidationStrategy = ''
  /**
   *  The miminum number of activities desired in the response; the server will
   *  attempt to return at least this quanitity. The server may also return fewer
   *  activities if it has a partial response ready before the request times out.
   *  If not set, a default value is used.
   */
  // const pageSize = 1234
  /**
   *  The token identifying which page of results to return. Set this to the
   *  next_page_token value returned from a previous query to obtain the
   *  following page of results. If not set, the first page of results will be
   *  returned.
   */
  // const pageToken = 'abc123'
  /**
   *  The filtering for items returned from this query request. The format of the
   *  filter string is a sequence of expressions, joined by an optional "AND",
   *  where each expression is of the form "field operator value".
   *  Supported fields:
   *    - `time`: Uses numerical operators on date values either in
   *      terms of milliseconds since Jan 1, 1970 or in RFC 3339 format.
   *      Examples:
   *        - `time > 1452409200000 AND time <= 1492812924310`
   *        - `time >= "2016-01-10T01:02:03-05:00"`
   *    - `detail.action_detail_case`: Uses the "has" operator (:) and
   *      either a singular value or a list of allowed action types enclosed in
   *      parentheses.
   *      Examples:
   *        - `detail.action_detail_case: RENAME`
   *        - `detail.action_detail_case:(CREATE EDIT)`
   *        - `-detail.action_detail_case:MOVE`
   */
  // const filter = 'abc123'

  // Imports the Activity library
  const {DriveActivityServiceClient} = require('@google-cloud/drive-activity').v2;

  // Instantiates a client
  const activityClient = new DriveActivityServiceClient();

  async function queryDriveActivity() {
    // Construct request
    const request = {
    };

    // Run request
    const iterable = await activityClient.queryDriveActivityAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  queryDriveActivity();
  // [END driveactivity_v2_generated_DriveActivityService_QueryDriveActivity_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
