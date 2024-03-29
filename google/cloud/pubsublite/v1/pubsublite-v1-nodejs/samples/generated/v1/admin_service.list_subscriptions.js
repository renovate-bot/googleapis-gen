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
  // [START pubsublite_v1_generated_AdminService_ListSubscriptions_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The parent whose subscriptions are to be listed.
   *  Structured like `projects/{project_number}/locations/{location}`.
   */
  // const parent = 'abc123'
  /**
   *  The maximum number of subscriptions to return. The service may return fewer
   *  than this value.
   *  If unset or zero, all subscriptions for the parent will be returned.
   */
  // const pageSize = 1234
  /**
   *  A page token, received from a previous `ListSubscriptions` call.
   *  Provide this to retrieve the subsequent page.
   *  When paginating, all other parameters provided to `ListSubscriptions` must
   *  match the call that provided the page token.
   */
  // const pageToken = 'abc123'

  // Imports the Pubsublite library
  const {AdminServiceClient} = require('@google-cloud/pubsublite').v1;

  // Instantiates a client
  const pubsubliteClient = new AdminServiceClient();

  async function callListSubscriptions() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const iterable = await pubsubliteClient.listSubscriptionsAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callListSubscriptions();
  // [END pubsublite_v1_generated_AdminService_ListSubscriptions_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
