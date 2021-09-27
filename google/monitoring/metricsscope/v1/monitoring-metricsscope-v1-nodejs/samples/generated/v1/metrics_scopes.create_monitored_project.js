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

function main(parent, monitoredProject) {
  // [START monitoring_v1_generated_MetricsScopes_CreateMonitoredProject_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The resource name of the existing `Metrics Scope` that will monitor this
   *  project.
   *  Example:
   *  `locations/global/metricsScopes/{SCOPING_PROJECT_ID_OR_NUMBER}`
   */
  // const parent = 'abc123'
  /**
   *  Required. The initial `MonitoredProject` configuration.
   *  Specify only the `monitored_project.name` field. All other fields are
   *  ignored. The `monitored_project.name` must be in the format:
   *  `locations/global/metricsScopes/{SCOPING_PROJECT_ID_OR_NUMBER}/projects/{MONITORED_PROJECT_ID_OR_NUMBER}`
   */
  // const monitoredProject = ''

  // Imports the Metricsscope library
  const {MetricsScopesClient} = require('@google-cloud/metricsscope').v1;

  // Instantiates a client
  const metricsscopeClient = new MetricsScopesClient();

  async function createMonitoredProject() {
    // Construct request
    const request = {
      parent,
      monitoredProject,
    };

    // Run request
    const [operation] = await metricsscopeClient.createMonitoredProject(request);
    const [response] = await operation.promise();
    console.log(response);
  }

  createMonitoredProject();
  // [END monitoring_v1_generated_MetricsScopes_CreateMonitoredProject_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
