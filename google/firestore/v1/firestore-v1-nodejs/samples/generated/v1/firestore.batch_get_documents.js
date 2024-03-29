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

function main(database) {
  // [START firestore_v1_generated_Firestore_BatchGetDocuments_async]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Required. The database name. In the format:
   *  `projects/{project_id}/databases/{database_id}`.
   */
  // const database = 'abc123'
  /**
   *  The names of the documents to retrieve. In the format:
   *  `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
   *  The request will fail if any of the document is not a child resource of the
   *  given `database`. Duplicate names will be elided.
   */
  // const documents = 'abc123'
  /**
   *  The fields to return. If not set, returns all fields.
   *  If a document has a field that is not present in this mask, that field will
   *  not be returned in the response.
   */
  // const mask = {}
  /**
   *  Reads documents in a transaction.
   */
  // const transaction = 'Buffer.from('string')'
  /**
   *  Starts a new transaction and reads the documents.
   *  Defaults to a read-only transaction.
   *  The new transaction ID will be returned as the first response in the
   *  stream.
   */
  // const newTransaction = {}
  /**
   *  Reads documents as they were at the given time.
   *  This may not be older than 270 seconds.
   */
  // const readTime = {}

  // Imports the Firestore library
  const {FirestoreClient} = require('@google-cloud/firestore').v1;

  // Instantiates a client
  const firestoreClient = new FirestoreClient();

  async function callBatchGetDocuments() {
    // Construct request
    const request = {
      database,
    };

    // Run request
    const stream = await firestoreClient.batchGetDocuments(request);
    stream.on('data', (response) => { console.log(response) });
    stream.on('error', (err) => { throw(err) });
    stream.on('end', () => { /* API call completed */ });
  }

  callBatchGetDocuments();
  // [END firestore_v1_generated_Firestore_BatchGetDocuments_async]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
