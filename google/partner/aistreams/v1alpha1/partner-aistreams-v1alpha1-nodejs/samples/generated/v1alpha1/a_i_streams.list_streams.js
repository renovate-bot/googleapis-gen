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
  // [START aistreams_v1alpha1_generated_AIStreams_ListStreams_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The parent that owns the collection of the Streams.
   */
  // const parent = 'abc123'
  /**
   *  Maximum number of Streams to return.
   */
  // const pageSize = 1234
  /**
   *  Page token received from a previous `ListStreams` call. Provide this to
   *  retrieve the subsequent page. When paginating, all other parameters
   *  provided to `ListClusters` must match the call that provided the page
   *  token.
   */
  // const pageToken = 'abc123'
  /**
   *  Filter request.
   */
  // const filter = 'abc123'
  /**
   *  Order by fields for the result.
   */
  // const orderBy = 'abc123'

  // Imports the Aistreams library
  const {AIStreamsClient} = require('aistreams').v1alpha1;

  // Instantiates a client
  const aistreamsClient = new AIStreamsClient();

  async function listStreams() {
    // Construct request
    const request = {
      parent,
    };

    // Run request
    const iterable = await aistreamsClient.listStreamsAsync(request);
    for await (const response of iterable) {
        console.log(response);
    }
  }

  listStreams();
  // [END aistreams_v1alpha1_generated_AIStreams_ListStreams_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
