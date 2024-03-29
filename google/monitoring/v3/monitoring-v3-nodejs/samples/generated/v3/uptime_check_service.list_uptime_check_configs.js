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
  // [START monitoring_v3_generated_UptimeCheckService_ListUptimeCheckConfigs_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The project (https://cloud.google.com/monitoring/api/v3#project_name)
   *  whose Uptime check configurations are listed. The format is:
   *      projects/[PROJECT_ID_OR_NUMBER]
   */
  // const parent = 'abc123'
  /**
   *  The maximum number of results to return in a single response. The server
   *  may further constrain the maximum number of results returned in a single
   *  page. If the page_size is <=0, the server will decide the number of results
   *  to be returned.
   */
  // const pageSize = 1234
  /**
   *  If this field is not empty then it must contain the `nextPageToken` value
   *  returned by a previous call to this method.  Using this field causes the
   *  method to return more results from the previous method call.
   */
  // const pageToken = 'abc123'

  // Imports the Monitoring library
  const {UptimeCheckServiceClient} = require('@google-cloud/monitoring').v3;

  // Instantiates a client
  const monitoringClient = new UptimeCheckServiceClient();

  async function callListUptimeCheckConfigs() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const iterable = await monitoringClient.listUptimeCheckConfigsAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callListUptimeCheckConfigs();
  // [END monitoring_v3_generated_UptimeCheckService_ListUptimeCheckConfigs_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
