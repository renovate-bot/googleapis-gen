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

function main(parent) {
  // [START recommendationengine_v1beta1_generated_UserEventService_ListUserEvents_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The parent eventStore resource name, such as
   *  `projects/* /locations/* /catalogs/default_catalog/eventStores/default_event_store`.
   */
  // const parent = 'abc123'
  /**
   *  Optional. Maximum number of results to return per page. If zero, the
   *  service will choose a reasonable default.
   */
  // const pageSize = 1234
  /**
   *  Optional. The previous ListUserEventsResponse.next_page_token.
   */
  // const pageToken = 'abc123'
  /**
   *  Optional. Filtering expression to specify restrictions over
   *  returned events. This is a sequence of terms, where each term applies some
   *  kind of a restriction to the returned user events. Use this expression to
   *  restrict results to a specific time range, or filter events by eventType.
   *     eg: eventTime > "2012-04-23T18:25:43.511Z" eventsMissingCatalogItems
   *     eventTime<"2012-04-23T18:25:43.511Z" eventType=search
   *    We expect only 3 types of fields:
   *     * eventTime: this can be specified a maximum of 2 times, once with a
   *       less than operator and once with a greater than operator. The
   *       eventTime restrict should result in one contiguous valid eventTime
   *       range.
   *     * eventType: only 1 eventType restriction can be specified.
   *     * eventsMissingCatalogItems: specififying this will restrict results
   *       to events for which catalog items were not found in the catalog. The
   *       default behavior is to return only those events for which catalog
   *       items were found.
   *    Some examples of valid filters expressions:
   *    * Example 1: eventTime > "2012-04-23T18:25:43.511Z"
   *              eventTime < "2012-04-23T18:30:43.511Z"
   *    * Example 2: eventTime > "2012-04-23T18:25:43.511Z"
   *              eventType = detail-page-view
   *    * Example 3: eventsMissingCatalogItems
   *              eventType = search eventTime < "2018-04-23T18:30:43.511Z"
   *    * Example 4: eventTime > "2012-04-23T18:25:43.511Z"
   *    * Example 5: eventType = search
   *    * Example 6: eventsMissingCatalogItems
   */
  // const filter = 'abc123'

  // Imports the Recommendationengine library
  const {UserEventServiceClient} = require('recommendationengine').v1beta1;

  // Instantiates a client
  const recommendationengineClient = new UserEventServiceClient();

  async function callListUserEvents() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const iterable = await recommendationengineClient.listUserEventsAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callListUserEvents();
  // [END recommendationengine_v1beta1_generated_UserEventService_ListUserEvents_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
