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

function main(name, alertPolicy) {
  // [START monitoring_v3_generated_AlertPolicyService_CreateAlertPolicy_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The project (https://cloud.google.com/monitoring/api/v3#project_name) in
   *  which to create the alerting policy. The format is:
   *      projects/[PROJECT_ID_OR_NUMBER]
   *  Note that this field names the parent container in which the alerting
   *  policy will be written, not the name of the created policy. |name| must be
   *  a host project of a workspace, otherwise INVALID_ARGUMENT error will
   *  return. The alerting policy that is returned will have a name that contains
   *  a normalized representation of this name as a prefix but adds a suffix of
   *  the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
   *  container.
   */
  // const name = 'abc123'
  /**
   *  Required. The requested alerting policy. You should omit the `name` field in this
   *  policy. The name will be returned in the new policy, including
   *  a new `[ALERT_POLICY_ID]` value.
   */
  // const alertPolicy = {}

  // Imports the Monitoring library
  const {AlertPolicyServiceClient} = require('@google-cloud/monitoring').v3;

  // Instantiates a client
  const monitoringClient = new AlertPolicyServiceClient();

  async function callCreateAlertPolicy() {
    // Construct request
    const request = {
      name,
      alertPolicy,
    };

    // Run request
    const response = await monitoringClient.createAlertPolicy(request);
    console.log(response);
  }

  callCreateAlertPolicy();
  // [END monitoring_v3_generated_AlertPolicyService_CreateAlertPolicy_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
