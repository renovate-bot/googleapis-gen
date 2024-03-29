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
  // [START monitoring_v3_generated_NotificationChannelService_ListNotificationChannels_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on
   *  which to execute the request. The format is:
   *      projects/[PROJECT_ID_OR_NUMBER]
   *  This names the container
   *  in which to look for the notification channels; it does not name a
   *  specific channel. To query a specific channel by REST resource name, use
   *  the
   *  `GetNotificationChannel` google.monitoring.v3.NotificationChannelService.GetNotificationChannel 
   *  operation.
   */
  // const name = 'abc123'
  /**
   *  If provided, this field specifies the criteria that must be met by
   *  notification channels to be included in the response.
   *  For more details, see sorting and
   *  filtering (https://cloud.google.com/monitoring/api/v3/sorting-and-filtering).
   */
  // const filter = 'abc123'
  /**
   *  A comma-separated list of fields by which to sort the result. Supports
   *  the same set of fields as in `filter`. Entries can be prefixed with
   *  a minus sign to sort in descending rather than ascending order.
   *  For more details, see sorting and
   *  filtering (https://cloud.google.com/monitoring/api/v3/sorting-and-filtering).
   */
  // const orderBy = 'abc123'
  /**
   *  The maximum number of results to return in a single response. If
   *  not set to a positive number, a reasonable value will be chosen by the
   *  service.
   */
  // const pageSize = 1234
  /**
   *  If non-empty, `page_token` must contain a value returned as the
   *  `next_page_token` in a previous response to request the next set
   *  of results.
   */
  // const pageToken = 'abc123'

  // Imports the Monitoring library
  const {NotificationChannelServiceClient} = require('@google-cloud/monitoring').v3;

  // Instantiates a client
  const monitoringClient = new NotificationChannelServiceClient();

  async function callListNotificationChannels() {
    // Construct request
    const request = {
      name,
    };

    // Run request
    const iterable = await monitoringClient.listNotificationChannelsAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callListNotificationChannels();
  // [END monitoring_v3_generated_NotificationChannelService_ListNotificationChannels_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
