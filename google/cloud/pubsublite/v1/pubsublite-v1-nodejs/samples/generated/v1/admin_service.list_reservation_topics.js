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

function main(name) {
  // [START pubsublite_v1_generated_AdminService_ListReservationTopics_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The name of the reservation whose topics to list.
   *  Structured like:
   *  projects/{project_number}/locations/{location}/reservations/{reservation_id}
   */
  // const name = 'abc123'
  /**
   *  The maximum number of topics to return. The service may return fewer
   *  than this value.
   *  If unset or zero, all topics for the given reservation will be returned.
   */
  // const pageSize = 1234
  /**
   *  A page token, received from a previous `ListReservationTopics` call.
   *  Provide this to retrieve the subsequent page.
   *  When paginating, all other parameters provided to `ListReservationTopics`
   *  must match the call that provided the page token.
   */
  // const pageToken = 'abc123'

  // Imports the Pubsublite library
  const {AdminServiceClient} = require('@google-cloud/pubsublite').v1;

  // Instantiates a client
  const pubsubliteClient = new AdminServiceClient();

  async function callListReservationTopics() {
    // Construct request
    const request = {
      name,
    };

    // Run request
    const iterable = await pubsubliteClient.listReservationTopicsAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  callListReservationTopics();
  // [END pubsublite_v1_generated_AdminService_ListReservationTopics_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
