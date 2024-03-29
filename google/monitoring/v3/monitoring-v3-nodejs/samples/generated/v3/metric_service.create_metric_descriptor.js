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

function main(name, metricDescriptor) {
  // [START monitoring_v3_generated_MetricService_CreateMetricDescriptor_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) on
   *  which to execute the request. The format is:
   *  4
   *      projects/[PROJECT_ID_OR_NUMBER]
   */
  // const name = 'abc123'
  /**
   *  Required. The new custom metric (https://cloud.google.com/monitoring/custom-metrics)
   *  descriptor.
   */
  // const metricDescriptor = {}

  // Imports the Monitoring library
  const {MetricServiceClient} = require('@google-cloud/monitoring').v3;

  // Instantiates a client
  const monitoringClient = new MetricServiceClient();

  async function callCreateMetricDescriptor() {
    // Construct request
    const request = {
      name,
      metricDescriptor,
    };

    // Run request
    const response = await monitoringClient.createMetricDescriptor(request);
    console.log(response);
  }

  callCreateMetricDescriptor();
  // [END monitoring_v3_generated_MetricService_CreateMetricDescriptor_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
