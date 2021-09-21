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
  // [START alertcenter_list_alerts_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Optional. The unique identifier of the Google Workspace organization
   *  account of the customer the alerts are associated with.
   *  Inferred from the caller identity if not provided.
   */
  // const customerId = 'abc123'
  /**
   *  Optional. The requested page size. Server may return fewer items than
   *  requested. If unspecified, server picks an appropriate default.
   */
  // const pageSize = 1234
  /**
   *  Optional. A token identifying a page of results the server should return.
   *  If empty, a new iteration is started. To continue an iteration, pass in
   *  the value from the previous ListAlertsResponse's
   *  [next_page_token][google.apps.alertcenter.v1beta1.ListAlertsResponse.next_page_token] field.
   */
  // const pageToken = 'abc123'
  /**
   *  Optional. A query string for filtering alert results.
   *  For more details, see [Query
   *  filters](https://developers.google.com/admin-sdk/alertcenter/guides/query-filters) and [Supported
   *  query filter
   *  fields](https://developers.google.com/admin-sdk/alertcenter/reference/filter-fields#alerts.list).
   */
  // const filter = 'abc123'
  /**
   *  Optional. The sort order of the list results.
   *  If not specified results may be returned in arbitrary order.
   *  You can sort the results in descending order based on the creation
   *  timestamp using `order_by="create_time desc"`.
   *  Currently, supported sorting are `create_time asc`, `create_time desc`,
   *  `update_time desc`
   */
  // const orderBy = 'abc123'

  // Imports the Alertcenter library
  const {AlertCenterServiceClient} = require('@google-cloud/alertcenter').v1beta1;

  // Instantiates a client
  const alertcenterClient = new AlertCenterServiceClient();

  async function listAlerts() {
    // Construct request
    const request = {
    };

    // Run request
    const iterable = await alertcenterClient.listAlertsAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  listAlerts();
  // [END alertcenter_list_alerts_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
