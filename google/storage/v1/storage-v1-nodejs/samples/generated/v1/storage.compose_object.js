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

function main(destinationBucket, destinationObject) {
  // [START storage_v1_generated_Storage_ComposeObject_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Name of the bucket containing the source objects. The destination object is
   *  stored in this bucket.
   */
  // const destinationBucket = 'abc123'
  /**
   *  Required. Name of the new object.
   */
  // const destinationObject = 'abc123'
  /**
   *  Apply a predefined set of access controls to the destination object.
   */
  // const destinationPredefinedAcl = {}
  /**
   *  Properties of the resulting object.
   */
  // const destination = {}
  /**
   *  The list of source objects that will be concatenated into a single object.
   */
  // const sourceObjects = 1234
  /**
   *  Makes the operation conditional on whether the object's current generation
   *  matches the given value. Setting to 0 makes the operation succeed only if
   *  there are no live versions of the object.
   */
  // const ifGenerationMatch = {}
  /**
   *  Makes the operation conditional on whether the object's current
   *  metageneration matches the given value.
   */
  // const ifMetagenerationMatch = {}
  /**
   *  Resource name of the Cloud KMS key, of the form
   *  `projects/my-project/locations/my-location/keyRings/my-kr/cryptoKeys/my-key`,
   *  that will be used to encrypt the object. Overrides the object
   *  metadata's `kms_key_name` value, if any.
   */
  // const kmsKeyName = 'abc123'
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

  async function callComposeObject() {
    // Construct request
    const request = {
      destinationBucket,
      destinationObject,
    };

    // Run request
    const response = await storageClient.composeObject(request);
    console.log(response);
  }

  callComposeObject();
  // [END storage_v1_generated_Storage_ComposeObject_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
