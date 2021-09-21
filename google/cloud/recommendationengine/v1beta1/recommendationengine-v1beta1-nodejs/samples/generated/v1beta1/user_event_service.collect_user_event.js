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

function main(parent, userEvent) {
  // [START recommendationengine_collect_user_event_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The parent eventStore name, such as
   *  `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
   */
  // const parent = 'abc123'
  /**
   *  Required. URL encoded UserEvent proto.
   */
  // const userEvent = 'abc123'
  /**
   *  Optional. The url including cgi-parameters but excluding the hash fragment.
   *  The URL must be truncated to 1.5K bytes to conservatively be under the 2K
   *  bytes. This is often more useful than the referer url, because many
   *  browsers only send the domain for 3rd party requests.
   */
  // const uri = 'abc123'
  /**
   *  Optional. The event timestamp in milliseconds. This prevents browser
   *  caching of otherwise identical get requests. The name is abbreviated to
   *  reduce the payload bytes.
   */
  // const ets = 1234

  // Imports the Recommendationengine library
  const {UserEventServiceClient} = require('recommendationengine').v1beta1;

  // Instantiates a client
  const recommendationengineClient = new UserEventServiceClient();

  async function collectUserEvent() {
    // Construct request
    const request = {
      parent,
      userEvent,
    };

    // Run request
    const response = await recommendationengineClient.collectUserEvent(request);
    console.log(response);
  }

  collectUserEvent();
  // [END recommendationengine_collect_user_event_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
