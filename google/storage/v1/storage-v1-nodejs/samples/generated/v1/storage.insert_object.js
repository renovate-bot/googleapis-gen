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

function main(writeOffset) {
  // [START storage_v1_generated_Storage_InsertObject_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  For resumable uploads. This should be the `upload_id` returned from a
   *  call to `StartResumableWriteResponse`.
   */
  // const uploadId = 'abc123'
  /**
   *  For non-resumable uploads. Describes the overall upload, including the
   *  destination bucket and object name, preconditions, etc.
   */
  // const insertObjectSpec = {}
  /**
   *  Required. The offset from the beginning of the object at which the data should be
   *  written.
   *  In the first `InsertObjectRequest` of a `InsertObject()` action, it
   *  indicates the initial offset for the `Insert()` call. The value **must** be
   *  equal to the `committed_size` that a call to `QueryWriteStatus()` would
   *  return (0 if this is the first write to the object).
   *  On subsequent calls, this value **must** be no larger than the sum of the
   *  first `write_offset` and the sizes of all `data` chunks sent previously on
   *  this stream.
   *  An incorrect value will cause an error.
   */
  // const writeOffset = 1234
  /**
   *  The data to insert. If a crc32c checksum is provided that doesn't match
   *  the checksum computed by the service, the request will fail.
   */
  // const checksummedData = {}
  /**
   *  A reference to an existing object. This can be used to support
   *  several use cases:
   *    - Writing a sequence of data buffers supports the basic use case of
   *      uploading a complete object, chunk by chunk.
   *    - Writing a sequence of references to existing objects allows an
   *      object to be composed from a collection of objects, which can be
   *      used to support parallel object writes.
   *    - Writing a single reference with a given offset and size can be used
   *      to create an object from a slice of an existing object.
   *    - Writing an object referencing a object slice (created as noted
   *      above) followed by a data buffer followed by another object
   *      slice can be used to support delta upload functionality.
   */
  // const reference = {}
  /**
   *  Checksums for the complete object. If the checksums computed by the service
   *  don't match the specifified checksums the call will fail. May only be
   *  provided in the first or last request (either with first_message, or
   *  finish_write set).
   */
  // const objectChecksums = {}
  /**
   *  If `true`, this indicates that the write is complete. Sending any
   *  `InsertObjectRequest`s subsequent to one in which `finish_write` is `true`
   *  will cause an error.
   *  For a non-resumable write (where the upload_id was not set in the first
   *  message), it is an error not to set this field in the final message of the
   *  stream.
   */
  // const finishWrite = true
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

  async function callInsertObject() {
    // Construct request
    const request = {
      writeOffset,
    };

    // Run request
    const stream = await storageClient.insertObject((response) => console.log(response));
    stream.write(request);
    stream.end();
  }

  callInsertObject();
  // [END storage_v1_generated_Storage_InsertObject_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
