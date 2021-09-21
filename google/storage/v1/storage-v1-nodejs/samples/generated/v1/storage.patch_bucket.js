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
  // [START storage_patch_bucket_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Name of a bucket.
   */
  // const bucket = 'abc123'
  /**
   *  Makes the return of the bucket metadata conditional on whether the bucket's
   *  current metageneration matches the given value.
   */
  // const ifMetagenerationMatch = ''
  /**
   *  Makes the return of the bucket metadata conditional on whether the bucket's
   *  current metageneration does not match the given value.
   */
  // const ifMetagenerationNotMatch = ''
  /**
   *  Apply a predefined set of access controls to this bucket.
   */
  // const predefinedAcl = ''
  /**
   *  Apply a predefined set of default object access controls to this bucket.
   */
  // const predefinedDefaultObjectAcl = ''
  /**
   *  Set of properties to return. Defaults to `FULL`.
   */
  // const projection = ''
  /**
   *  The Bucket metadata for updating.
   */
  // const metadata = ''
  /**
   *  List of fields to be updated.
   *  To specify ALL fields, equivalent to the JSON API's "update" function,
   *  specify a single field with the value `*`. Note: not recommended. If a new
   *  field is introduced at a later time, an older client updating with the `*`
   *  may accidentally reset the new field's value.
   *  Not specifying any fields is an error.
   *  Not specifying a field while setting that field to a non-default value is
   *  an error.
   */
  // const updateMask = ''
  /**
   *  A set of parameters common to all Storage API requests.
   */
  // const commonRequestParams = ''

  // Imports the Storage library
  const {StorageClient} = require('storage').v1;

  // Instantiates a client
  const storageClient = new StorageClient();

  async function patchBucket() {
    // Construct request
    const request = {
      bucket,
    };

    // Run request
    const response = await storageClient.patchBucket(request);
    console.log(response);
  }

  patchBucket();
  // [END storage_patch_bucket_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
