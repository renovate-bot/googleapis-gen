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

function main(bucket, object) {
  // [START storage_v1_generated_Storage_GetObject_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Name of the bucket in which the object resides.
   */
  // const bucket = 'abc123'
  /**
   *  Required. Name of the object.
   */
  // const object = 'abc123'
  /**
   *  If present, selects a specific revision of this object (as opposed to the
   *  latest version, the default).
   */
  // const generation = 1234
  /**
   *  Makes the operation conditional on whether the object's current generation
   *  matches the given value. Setting to 0 makes the operation succeed only if
   *  there are no live versions of the object.
   */
  // const ifGenerationMatch = {}
  /**
   *  Makes the operation conditional on whether the object's current generation
   *  does not match the given value. If no live object exists, the precondition
   *  fails. Setting to 0 makes the operation succeed only if there is a live
   *  version of the object.
   */
  // const ifGenerationNotMatch = {}
  /**
   *  Makes the operation conditional on whether the object's current
   *  metageneration matches the given value.
   */
  // const ifMetagenerationMatch = {}
  /**
   *  Makes the operation conditional on whether the object's current
   *  metageneration does not match the given value.
   */
  // const ifMetagenerationNotMatch = {}
  /**
   *  Set of properties to return. Defaults to `NO_ACL`.
   */
  // const projection = {}
  /**
   *  A set of parameters common to Storage API requests concerning an object.
   */
  // const commonObjectRequestParams = {}
  /**
   *  A set of parameters common to all Storage API requests.
   */
  // const commonRequestParams = {}

  // Imports the Storage library
  const {StorageClient} = require('storage').v1;

  // Instantiates a client
  const storageClient = new StorageClient();

  async function callGetObject() {
    // Construct request
    const request = {
      bucket,
      object,
    };

    // Run request
    const response = await storageClient.getObject(request);
    console.log(response);
  }

  callGetObject();
  // [END storage_v1_generated_Storage_GetObject_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
