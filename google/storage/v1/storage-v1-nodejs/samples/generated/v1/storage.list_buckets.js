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

function main(project) {
  // [START storage_v1_generated_Storage_ListBuckets_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Maximum number of buckets to return in a single response. The service will
   *  use this parameter or 1,000 items, whichever is smaller.
   */
  // const maxResults = 1234
  /**
   *  A previously-returned page token representing part of the larger set of
   *  results to view.
   */
  // const pageToken = 'abc123'
  /**
   *  Filter results to buckets whose names begin with this prefix.
   */
  // const prefix = 'abc123'
  /**
   *  Required. A valid API project identifier.
   */
  // const project = 'my-project'
  /**
   *  Set of properties to return. Defaults to `NO_ACL`.
   */
  // const projection = {}
  /**
   *  A set of parameters common to all Storage API requests.
   */
  // const commonRequestParams = {}

  // Imports the Storage library
  const {StorageClient} = require('storage').v1;

  // Instantiates a client
  const storageClient = new StorageClient();

  async function callListBuckets() {
    // Construct request
    const request = {
      project,
    };

    // Run request
    const response = await storageClient.listBuckets(request);
    console.log(response);
  }

  callListBuckets();
  // [END storage_v1_generated_Storage_ListBuckets_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
