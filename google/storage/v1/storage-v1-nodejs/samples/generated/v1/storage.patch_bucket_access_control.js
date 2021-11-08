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

function main(bucket, entity) {
  // [START storage_v1_generated_Storage_PatchBucketAccessControl_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Name of a bucket.
   */
  // const bucket = 'abc123'
  /**
   *  Required. The entity holding the permission. Can be one of:
   *  * `user-`*userId*
   *  * `user-`*emailAddress*
   *  * `group-`*groupId*
   *  * `group-`*emailAddress*
   *  * `allUsers`
   *  * `allAuthenticatedUsers`
   */
  // const entity = 'abc123'
  /**
   *  The BucketAccessControl for updating.
   */
  // const bucketAccessControl = {}
  /**
   *  List of fields to be updated.
   *  To specify ALL fields, equivalent to the JSON API's "update" function,
   *  specify a single field with the value `*`.
   *  Not specifying any fields is an error.
   *  Not specifying a field while setting that field to a non-default value is
   *  an error.
   */
  // const updateMask = {}
  /**
   *  A set of parameters common to all Storage API requests.
   */
  // const commonRequestParams = {}

  // Imports the Storage library
  const {StorageClient} = require('storage').v1;

  // Instantiates a client
  const storageClient = new StorageClient();

  async function callPatchBucketAccessControl() {
    // Construct request
    const request = {
      bucket,
      entity,
    };

    // Run request
    const response = await storageClient.patchBucketAccessControl(request);
    console.log(response);
  }

  callPatchBucketAccessControl();
  // [END storage_v1_generated_Storage_PatchBucketAccessControl_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
