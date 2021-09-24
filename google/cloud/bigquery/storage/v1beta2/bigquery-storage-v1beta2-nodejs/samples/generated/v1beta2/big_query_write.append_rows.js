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

function main(writeStream) {
  // [START storage_v1beta2_generated_BigQueryWrite_AppendRows_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The stream that is the target of the append operation. This value must be
   *  specified for the initial request. If subsequent requests specify the
   *  stream name, it must equal to the value provided in the first request.
   *  To write to the _default stream, populate this field with a string in the
   *  format `projects/{project}/datasets/{dataset}/tables/{table}/_default`.
   */
  // const writeStream = 'abc123'
  /**
   *  If present, the write is only performed if the next append offset is same
   *  as the provided value. If not present, the write is performed at the
   *  current end of stream. Specifying a value for this field is not allowed
   *  when calling AppendRows for the '_default' stream.
   */
  // const offset = ''
  /**
   *  Rows in proto format.
   */
  // const protoRows = ''
  /**
   *  Id set by client to annotate its identity. Only initial request setting is
   *  respected.
   */
  // const traceId = 'abc123'

  // Imports the Storage library
  const {BigQueryWriteClient} = require('storage').v1beta2;

  // Instantiates a client
  const storageClient = new BigQueryWriteClient();

  async function appendRows() {
    // Construct request
    const request = {
      writeStream,
    };

    // Run request
    const stream = await storageClient.appendRows();
    stream.on('data', (response) => { console.log(response) });
    stream.on('error', (err) => { throw(err) });
    stream.on('end', () => { /* API call completed */ });
    stream.write(request);
    stream.end(); 
  }

  appendRows();
  // [END storage_v1beta2_generated_BigQueryWrite_AppendRows_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
