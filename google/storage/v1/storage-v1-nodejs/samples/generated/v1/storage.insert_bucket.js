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
  // [START storage_v1_generated_Storage_InsertBucket_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Apply a predefined set of access controls to this bucket.
   */
  // const predefinedAcl = ''
  /**
   *  Apply a predefined set of default object access controls to this bucket.
   */
  // const predefinedDefaultObjectAcl = ''
  /**
   *  Required. A valid API project identifier.
   */
  // const project = 'my-project'
  /**
   *  Set of properties to return. Defaults to `NO_ACL`, unless the
   *  bucket resource specifies `acl` or `defaultObjectAcl`
   *  properties, when it defaults to `FULL`.
   */
  // const projection = ''
  /**
   *  Properties of the new bucket being inserted, including its name.
   */
  // const bucket = ''
  /**
   *  A set of parameters common to all Storage API requests.
   */
  // const commonRequestParams = ''

  // Imports the Storage library
  const {StorageClient} = require('storage').v1;

  // Instantiates a client
  const storageClient = new StorageClient();

  async function insertBucket() {
    // Construct request
    const request = {
      project,
    };

    // Run request
    const response = await storageClient.insertBucket(request);
    console.log(response);
  }

  insertBucket();
  // [END storage_v1_generated_Storage_InsertBucket_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
