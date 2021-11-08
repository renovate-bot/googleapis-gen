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

function main(destinationBucket, destinationObject, sourceBucket, sourceObject) {
  // [START storage_v1_generated_Storage_RewriteObject_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. Name of the bucket in which to store the new object. Overrides the provided
   *  object metadata's `bucket` value, if any.
   */
  // const destinationBucket = 'abc123'
  /**
   *  Required. Name of the new object.
   *  Required when the object metadata is not otherwise provided. Overrides the
   *  object metadata's `name` value, if any.
   */
  // const destinationObject = 'abc123'
  /**
   *  Resource name of the Cloud KMS key, of the form
   *  `projects/my-project/locations/my-location/keyRings/my-kr/cryptoKeys/my-key`,
   *  that will be used to encrypt the object. Overrides the object
   *  metadata's `kms_key_name` value, if any.
   */
  // const destinationKmsKeyName = 'abc123'
  /**
   *  Apply a predefined set of access controls to the destination object.
   */
  // const destinationPredefinedAcl = {}
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
   *  Makes the operation conditional on whether the destination object's current
   *  metageneration matches the given value.
   */
  // const ifMetagenerationMatch = {}
  /**
   *  Makes the operation conditional on whether the destination object's current
   *  metageneration does not match the given value.
   */
  // const ifMetagenerationNotMatch = {}
  /**
   *  Makes the operation conditional on whether the source object's current
   *  generation matches the given value.
   */
  // const ifSourceGenerationMatch = {}
  /**
   *  Makes the operation conditional on whether the source object's current
   *  generation does not match the given value.
   */
  // const ifSourceGenerationNotMatch = {}
  /**
   *  Makes the operation conditional on whether the source object's current
   *  metageneration matches the given value.
   */
  // const ifSourceMetagenerationMatch = {}
  /**
   *  Makes the operation conditional on whether the source object's current
   *  metageneration does not match the given value.
   */
  // const ifSourceMetagenerationNotMatch = {}
  /**
   *  The maximum number of bytes that will be rewritten per rewrite request.
   *  Most callers
   *  shouldn't need to specify this parameter - it is primarily in place to
   *  support testing. If specified the value must be an integral multiple of
   *  1 MiB (1048576). Also, this only applies to requests where the source and
   *  destination span locations and/or storage classes. Finally, this value must
   *  not change across rewrite calls else you'll get an error that the
   *  `rewriteToken` is invalid.
   */
  // const maxBytesRewrittenPerCall = 1234
  /**
   *  Set of properties to return. Defaults to `NO_ACL`, unless the
   *  object resource specifies the `acl` property, when it defaults
   *  to `full`.
   */
  // const projection = {}
  /**
   *  Include this field (from the previous rewrite response) on each rewrite
   *  request after the first one, until the rewrite response 'done' flag is
   *  true. Calls that provide a rewriteToken can omit all other request fields,
   *  but if included those fields must match the values provided in the first
   *  rewrite request.
   */
  // const rewriteToken = 'abc123'
  /**
   *  Required. Name of the bucket in which to find the source object.
   */
  // const sourceBucket = 'abc123'
  /**
   *  Required. Name of the source object.
   */
  // const sourceObject = 'abc123'
  /**
   *  If present, selects a specific revision of the source object (as opposed to
   *  the latest version, the default).
   */
  // const sourceGeneration = 1234
  /**
   *  Properties of the destination, post-rewrite object.
   */
  // const object = {}
  /**
   *  The algorithm used to encrypt the source object, if any.
   */
  // const copySourceEncryptionAlgorithm = 'abc123'
  /**
   *  The encryption key used to encrypt the source object, if any.
   */
  // const copySourceEncryptionKey = 'abc123'
  /**
   *  The SHA-256 hash of the key used to encrypt the source object, if any.
   */
  // const copySourceEncryptionKeySha256 = 'abc123'
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

  async function callRewriteObject() {
    // Construct request
    const request = {
      destinationBucket,
      destinationObject,
      sourceBucket,
      sourceObject,
    };

    // Run request
    const response = await storageClient.rewriteObject(request);
    console.log(response);
  }

  callRewriteObject();
  // [END storage_v1_generated_Storage_RewriteObject_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
