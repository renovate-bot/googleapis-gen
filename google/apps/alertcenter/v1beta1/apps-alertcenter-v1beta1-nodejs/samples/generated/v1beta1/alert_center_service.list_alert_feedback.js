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
  // [START alertcenter_v1beta1_generated_AlertCenterService_ListAlertFeedback_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Optional. The unique identifier of the Google Workspace organization
   *  account of the customer the alert feedback are associated with.
   *  Inferred from the caller identity if not provided.
   */
  // const customerId = 'abc123'
  /**
   *  Required. The alert identifier.
   *  The "-" wildcard could be used to represent all alerts.
   */
  // const alertId = 'abc123'
  /**
   *  Optional. A query string for filtering alert feedback results.
   *  For more details, see [Query
   *  filters](https://developers.google.com/admin-sdk/alertcenter/guides/query-filters) and [Supported
   *  query filter
   *  fields](https://developers.google.com/admin-sdk/alertcenter/reference/filter-fields#alerts.feedback.list).
   */
  // const filter = 'abc123'

  // Imports the Alertcenter library
  const {AlertCenterServiceClient} = require('@google-cloud/alertcenter').v1beta1;

  // Instantiates a client
  const alertcenterClient = new AlertCenterServiceClient();

  async function listAlertFeedback() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await alertcenterClient.listAlertFeedback(request);
    console.log(response);
  }

  listAlertFeedback();
  // [END alertcenter_v1beta1_generated_AlertCenterService_ListAlertFeedback_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
