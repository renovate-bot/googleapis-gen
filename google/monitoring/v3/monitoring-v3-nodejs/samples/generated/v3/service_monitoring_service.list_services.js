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
  // [START monitoring_list_services_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Resource name of the parent containing the listed services, either a
   *  [project](https://cloud.google.com/monitoring/api/v3#project_name) or a
   *  Monitoring Workspace. The formats are:
   *      projects/[PROJECT_ID_OR_NUMBER]
   *      workspaces/[HOST_PROJECT_ID_OR_NUMBER]
   */
  // const parent = 'abc123'
  /**
   *  A filter specifying what `Service`s to return. The filter currently
   *  supports the following fields:
   *      - `identifier_case`
   *      - `app_engine.module_id`
   *      - `cloud_endpoints.service` (reserved for future use)
   *      - `mesh_istio.mesh_uid`
   *      - `mesh_istio.service_namespace`
   *      - `mesh_istio.service_name`
   *      - `cluster_istio.location` (deprecated)
   *      - `cluster_istio.cluster_name` (deprecated)
   *      - `cluster_istio.service_namespace` (deprecated)
   *      - `cluster_istio.service_name` (deprecated)
   *  `identifier_case` refers to which option in the identifier oneof is
   *  populated. For example, the filter `identifier_case = "CUSTOM"` would match
   *  all services with a value for the `custom` field. Valid options are
   *  "CUSTOM", "APP_ENGINE", "MESH_ISTIO", plus "CLUSTER_ISTIO" (deprecated)
   *  and "CLOUD_ENDPOINTS" (reserved for future use).
   */
  // const filter = 'abc123'
  /**
   *  A non-negative number that is the maximum number of results to return.
   *  When 0, use default page size.
   */
  // const pageSize = 1234
  /**
   *  If this field is not empty then it must contain the `nextPageToken` value
   *  returned by a previous call to this method.  Using this field causes the
   *  method to return additional results from the previous method call.
   */
  // const pageToken = 'abc123'

  // Imports the Monitoring library
  const {ServiceMonitoringServiceClient} = require('@google-cloud/monitoring').v3;

  // Instantiates a client
  const monitoringClient = new ServiceMonitoringServiceClient();

  async function listServices() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const iterable = await monitoringClient.listServicesAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  listServices();
  // [END monitoring_list_services_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
