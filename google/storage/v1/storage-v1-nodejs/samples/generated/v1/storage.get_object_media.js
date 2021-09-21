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

function main() {
  // [START storage_get_object_media_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  The name of the bucket containing the object to read.
   */
  // const bucket = 'abc123'
  /**
   *  The name of the object to read.
   */
  // const object = 'abc123'
  /**
   *  If present, selects a specific revision of this object (as opposed
   *  to the latest version, the default).
   */
  // const generation = 1234
  /**
   *  The offset for the first byte to return in the read, relative to the start
   *  of the object.
   *  A negative `read_offset` value will be interpreted as the number of bytes
   *  back from the end of the object to be returned. For example, if an object's
   *  length is 15 bytes, a GetObjectMediaRequest with `read_offset` = -5 and
   *  `read_limit` = 3 would return bytes 10 through 12 of the object.
   */
  // const readOffset = 1234
  /**
   *  The maximum number of `data` bytes the server is allowed to return in the
   *  sum of all `Object` messages. A `read_limit` of zero indicates that there
   *  is no limit, and a negative `read_limit` will cause an error.
   *  If the stream returns fewer bytes than allowed by the `read_limit` and no
   *  error occurred, the stream includes all data from the `read_offset` to the
   *  end of the resource.
   */
  // const readLimit = 1234
  /**
   *  Makes the operation conditional on whether the object's current generation
   *  matches the given value. Setting to 0 makes the operation succeed only if
   *  there are no live versions of the object.
   */
  // const ifGenerationMatch = ''
  /**
   *  Makes the operation conditional on whether the object's current generation
   *  does not match the given value. If no live object exists, the precondition
   *  fails. Setting to 0 makes the operation succeed only if there is a live
   *  version of the object.
   */
  // const ifGenerationNotMatch = ''
  /**
   *  Makes the operation conditional on whether the object's current
   *  metageneration matches the given value.
   */
  // const ifMetagenerationMatch = ''
  /**
   *  Makes the operation conditional on whether the object's current
   *  metageneration does not match the given value.
   */
  // const ifMetagenerationNotMatch = ''
  /**
   *  A set of parameters common to Storage API requests concerning an object.
   */
  // const commonObjectRequestParams = ''
  /**
   *  A set of parameters common to all Storage API requests.
   */
  // const commonRequestParams = ''

  // Imports the Storage library
  const {StorageClient} = require('storage').v1;

  // Instantiates a client
  const storageClient = new StorageClient();

  async function getObjectMedia() {
    // Construct request
    const request = {
    };

    // Run request
    const stream = await storageClient.getObjectMedia(request);
    stream.on('data', (response) => { console.log(response) });
    stream.on('error', (err) => { throw(err) });
    stream.on('end', () => { /* API call completed */ });
  }

  getObjectMedia();
  // [END storage_get_object_media_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
