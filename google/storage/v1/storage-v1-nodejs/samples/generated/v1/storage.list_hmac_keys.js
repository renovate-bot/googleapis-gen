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

function main(projectId) {
  // [START storage_v1_generated_Storage_ListHmacKeys_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The project id to list HMAC keys for.
   */
  // const projectId = 'abc123'
  /**
   *  An optional filter to only return HMAC keys for one service account.
   */
  // const serviceAccountEmail = 'abc123'
  /**
   *  An optional bool to return deleted keys that have not been wiped out yet.
   */
  // const showDeletedKeys = true
  /**
   *  The maximum number of keys to return.
   */
  // const maxResults = 1234
  /**
   *  A previously returned token from ListHmacKeysResponse to get the next page.
   */
  // const pageToken = 'abc123'
  /**
   *  A set of parameters common to all Storage API requests.
   */
  // const commonRequestParams = {}

  // Imports the Storage library
  const {StorageClient} = require('storage').v1;

  // Instantiates a client
  const storageClient = new StorageClient();

  async function callListHmacKeys() {
    // Construct request
    const request = {
      projectId,
    };

    // Run request
    const response = await storageClient.listHmacKeys(request);
    console.log(response);
  }

  callListHmacKeys();
  // [END storage_v1_generated_Storage_ListHmacKeys_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
