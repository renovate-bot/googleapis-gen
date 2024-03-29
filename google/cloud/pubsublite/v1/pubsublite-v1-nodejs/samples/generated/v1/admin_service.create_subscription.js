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

function main(parent, subscription, subscriptionId) {
  // [START pubsublite_v1_generated_AdminService_CreateSubscription_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The parent location in which to create the subscription.
   *  Structured like `projects/{project_number}/locations/{location}`.
   */
  // const parent = 'abc123'
  /**
   *  Required. Configuration of the subscription to create. Its `name` field is ignored.
   */
  // const subscription = {}
  /**
   *  Required. The ID to use for the subscription, which will become the final component
   *  of the subscription's name.
   *  This value is structured like: `my-sub-name`.
   */
  // const subscriptionId = 'abc123'
  /**
   *  If true, the newly created subscription will only receive messages
   *  published after the subscription was created. Otherwise, the entire
   *  message backlog will be received on the subscription. Defaults to false.
   */
  // const skipBacklog = true

  // Imports the Pubsublite library
  const {AdminServiceClient} = require('@google-cloud/pubsublite').v1;

  // Instantiates a client
  const pubsubliteClient = new AdminServiceClient();

  async function callCreateSubscription() {
    // Construct request
    const request = {
      parent,
      subscription,
      subscriptionId,
    };

    // Run request
    const response = await pubsubliteClient.createSubscription(request);
    console.log(response);
  }

  callCreateSubscription();
  // [END pubsublite_v1_generated_AdminService_CreateSubscription_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
