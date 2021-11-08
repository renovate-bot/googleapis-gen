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

function main(name, query) {
  // [START monitoring_v3_generated_QueryService_QueryTimeSeries_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on
   *  which to execute the request. The format is:
   *      projects/[PROJECT_ID_OR_NUMBER]
   */
  // const name = 'abc123'
  /**
   *  Required. The query in the Monitoring Query
   *  Language (https://cloud.google.com/monitoring/mql/reference) format.
   *  The default time zone is in UTC.
   */
  // const query = 'abc123'
  /**
   *  A positive number that is the maximum number of time_series_data to return.
   */
  // const pageSize = 1234
  /**
   *  If this field is not empty then it must contain the `nextPageToken` value
   *  returned by a previous call to this method.  Using this field causes the
   *  method to return additional results from the previous method call.
   */
  // const pageToken = 'abc123'

  // Imports the Monitoring library
  const {QueryServiceClient} = require('@google-cloud/monitoring').v3;

  // Instantiates a client
  const monitoringClient = new QueryServiceClient();

  async function callQueryTimeSeries() {
    // Construct request
    const request = {
      name,
      query,
    };

    // Run request
    const iterable = await monitoringClient.queryTimeSeriesAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callQueryTimeSeries();
  // [END monitoring_v3_generated_QueryService_QueryTimeSeries_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
