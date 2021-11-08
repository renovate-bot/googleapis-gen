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

function main(bucket) {
  // [START storage_v1_generated_Storage_ListDefaultObjectAccessControls_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Name of a bucket.
   */
  // const bucket = 'abc123'
  /**
   *  If present, only return default ACL listing if the bucket's current
   *  metageneration matches this value.
   */
  // const ifMetagenerationMatch = {}
  /**
   *  If present, only return default ACL listing if the bucket's current
   *  metageneration does not match the given value.
   */
  // const ifMetagenerationNotMatch = {}
  /**
   *  A set of parameters common to all Storage API requests.
   */
  // const commonRequestParams = {}

  // Imports the Storage library
  const {StorageClient} = require('storage').v1;

  // Instantiates a client
  const storageClient = new StorageClient();

  async function callListDefaultObjectAccessControls() {
    // Construct request
    const request = {
      bucket,
    };

    // Run request
    const response = await storageClient.listDefaultObjectAccessControls(request);
    console.log(response);
  }

  callListDefaultObjectAccessControls();
  // [END storage_v1_generated_Storage_ListDefaultObjectAccessControls_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
