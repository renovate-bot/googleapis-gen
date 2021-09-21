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

function main(parent, filter) {
  // [START recommendationengine_purge_user_events_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The resource name of the event_store under which the events are
   *  created. The format is
   *  `projects/${projectId}/locations/global/catalogs/${catalogId}/eventStores/${eventStoreId}`
   */
  // const parent = 'abc123'
  /**
   *  Required. The filter string to specify the events to be deleted. Empty
   *  string filter is not allowed. This filter can also be used with
   *  ListUserEvents API to list events that will be deleted. The eligible fields
   *  for filtering are:
   *  * eventType - UserEvent.eventType field of type string.
   *  * eventTime - in ISO 8601 "zulu" format.
   *  * visitorId - field of type string. Specifying this will delete all events
   *  associated with a visitor.
   *  * userId - field of type string. Specifying this will delete all events
   *  associated with a user.
   *  Example 1: Deleting all events in a time range.
   *  `eventTime > "2012-04-23T18:25:43.511Z" eventTime <
   *  "2012-04-23T18:30:43.511Z"`
   *  Example 2: Deleting specific eventType in time range.
   *  `eventTime > "2012-04-23T18:25:43.511Z" eventType = "detail-page-view"`
   *  Example 3: Deleting all events for a specific visitor
   *  `visitorId = visitor1024`
   *  The filtering fields are assumed to have an implicit AND.
   */
  // const filter = 'abc123'
  /**
   *  Optional. The default value is false. Override this flag to true to
   *  actually perform the purge. If the field is not set to true, a sampling of
   *  events to be deleted will be returned.
   */
  // const force = true

  // Imports the Recommendationengine library
  const {UserEventServiceClient} = require('recommendationengine').v1beta1;

  // Instantiates a client
  const recommendationengineClient = new UserEventServiceClient();

  async function purgeUserEvents() {
    // Construct request
    const request = {
      parent,
      filter,
    };

    // Run request
    const [operation] = await recommendationengineClient.purgeUserEvents(request);
    const [response] = await operation.promise();
    console.log(response);
  }

  purgeUserEvents();
  // [END recommendationengine_purge_user_events_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
